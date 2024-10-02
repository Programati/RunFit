using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades;
using CapaDeNegocios;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
            txtCuitProveedor.MaxLength = 11;
            txtRSocialProveedor.MaxLength = 20;
            txtDescripcionProveedor.MaxLength = 150;
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtRSocialProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtCuitProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtEmailProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtRSocialProveedor.Focus();
        }

        // Evento que se ejecuta al hacer clic en el botón "Limpiar campos"
        private void btnLimpiarCamposProvedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Llama al método para limpiar los campos
        }

        // Evento que se ejecuta al hacer clic en el botón "Volver"
        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de CUIT
        private void txtCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de teléfono
        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Guardar proveedor"
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            string MensajeUsuario = string.Empty; // Mensaje para el resultado del proceso de usuario
            string MensajePersona = string.Empty; // Mensaje para el resultado del proceso de persona
            int idProveedorGenerado = 0; // ID de persona generada
            bool VerdadPersonaGenerada = false; // Bandera para verificar si la persona fue generada correctamente
            
            bool VerdadUsuarioGenerado = false; // Bandera para verificar si el usuario fue generado correctamente
            string mensajeConfirmacion = "¿Desea agregar al"; // Mensaje de confirmación inicial
            string contrasena = null; // Variable para almacenar la contraseña

            // Verifica si los campos están validados
            if (camposValidados())
            {
                string proveedor = txtRSocialProveedor.Text; // Obtiene el texto de razón social

                // Muestra un cuadro de diálogo de confirmación
                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al proveedor {proveedor} al sistema?", // Mensaje
                    "Confirmación", // Título del cuadro de diálogo
                    MessageBoxButtons.YesNo, // Opciones de botones
                    MessageBoxIcon.Question // Icono del cuadro de diálogo
                );

                // Si el usuario confirma
                if (confirmacion == DialogResult.Yes)
                {
                    // Formatea la fecha para la base de datos
                   // string fechaFormateada = .Value.ToString("yyyy-MM-dd");

                    // Crea un nuevo objeto Persona con los datos del formulario
                    Proveedor ProveedorNuevo = new Proveedor()
                    {
                        idProveedor = txtIdProvee.Text != "" ? Convert.ToInt32(txtIdProvee.Text) : idProveedorGenerado,
                        razonSocial = txtRSocialProveedor.Text,
                        cuit = txtCuitProveedor.Text,
                        descripcion = txtDescripcionProveedor.Text,
                        fechaAlta=DateTime.Now,
                        fechaBaja=null,
                        direccion =txtDireccionProveedor.Text,
                        email = txtEmailProveedor.Text,
                        telefono = txtTelefonoProveedor.Text
                        
                    };
                    if (txtIdProvee.Text != "")
                    {
                        //VerdadPersonaGenerada = new CN_proveedor().Editar(PersonaNueva, out MensajePersona);
                        //IdPersonaGenerada = PersonaNueva.idPersona; // Actualiza el ID de persona generada
                    }
                    // Si no hay ID de persona, se registra como nueva
                    else
                    {
                        idProveedorGenerado = new CN_proveedor().Registrar(ProveedorNuevo, out MensajePersona);
                    }

                }
            }
        }

        // Método que valida los campos del formulario
        private bool camposValidados()
        {
            bool RSocialVacio = string.IsNullOrEmpty(txtRSocialProveedor.Text);
            bool cuitVacio = string.IsNullOrEmpty(txtCuitProveedor.Text);
            bool direccionVacio = string.IsNullOrEmpty(txtDireccionProveedor.Text);
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoProveedor.Text);
            bool emailVacio = string.IsNullOrEmpty(txtEmailProveedor.Text);
            bool descripcionVacio = string.IsNullOrEmpty(txtDescripcionProveedor.Text);

            // Verifica si algún campo requerido está vacío
            if (RSocialVacio || cuitVacio || direccionVacio || telefonoVacio || emailVacio || descripcionVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna falso si hay campos vacíos
            }

            // Valida la longitud del CUIT
            if (txtCuitProveedor.TextLength > 11 || txtCuitProveedor.TextLength < 10)
            {
                MessageBox.Show("Ingresó un número de CUIT incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Retorna falso si el CUIT es incorrecto
            }

            // Valida la longitud del número de teléfono
            if (txtTelefonoProveedor.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Retorna falso si el teléfono es muy corto
            }

            // Valida el formato del correo electrónico
            if (!EsEmailValido(txtEmailProveedor.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Retorna falso si el email no es válido
            }

            return true; // Retorna verdadero si todos los campos son válidos
        }

        // Método que valida el formato del correo electrónico
        private bool EsEmailValido(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Expresión regular para validar el email
                return emailRegex.IsMatch(email); // Retorna verdadero si el email es válido
            }
            catch
            {
                MessageBox.Show("Ingresó un email inválido");
                return false; // Retorna falso si ocurre una excepción
            }
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmProveedor_Load_1(object sender, EventArgs e)
        {
            txtRSocialProveedor.Focus(); // Pone el foco en el TextBox de razón social al cargar el formulario
        }

    }
}



