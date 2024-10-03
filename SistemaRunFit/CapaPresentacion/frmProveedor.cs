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
        private static Proveedor ProveedorDGV = null;
        public frmProveedor()
        {
            InitializeComponent();
            txtCuitProveedor.MaxLength = 11;
            txtRSocialProveedor.MaxLength = 20;
            txtDescripcionProveedor.MaxLength = 150;
        }
        public frmProveedor(Proveedor ProveedorEditar)
        {
            ProveedorDGV = ProveedorEditar; // Asigna el usuario a editar
            InitializeComponent();
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

        
        private void btnLimpiarCamposProvedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); 
        }

        // Evento que se ejecuta al hacer clic en el botón "Volver"
        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            ProveedorDGV = null;
            this.Close(); 
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de CUIT
        private void txtCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de teléfono
        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Guardar proveedor"
        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            // Inicializa mensajes y estados
            
            string MensajeProveedor = string.Empty;
            int idProveedorGenerado = 0;
            bool VerdadPersonaGenerada = false;
            bool VerdadUsuarioGenerado = false;
            string mensajeConfirmacion = "¿Desea agregar al";
            string contrasena = null;

            // Verifica si los campos son válidos
            if (camposValidados())
            {
                string proveedor = txtRSocialProveedor.Text; // Obtiene razón social

                // Muestra cuadro de confirmación
                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al proveedor {proveedor} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma
                if (confirmacion == DialogResult.Yes)
                {
                    // Crea nuevo objeto Proveedor
                    Proveedor ProveedorNuevo = new Proveedor()
                    {
                        idProveedor = txtIdProvee.Text != "" ? Convert.ToInt32(txtIdProvee.Text) : idProveedorGenerado,
                        razonSocial = txtRSocialProveedor.Text,
                        cuit = txtCuitProveedor.Text,
                        descripcion = txtDescripcionProveedor.Text,
                        fechaAlta = DateTime.Now,
                        fechaBaja = null,
                        direccion = txtDireccionProveedor.Text,
                        email = txtEmailProveedor.Text,
                        telefono = txtTelefonoProveedor.Text
                    };

                    // Si hay ID, se edita; si no, se registra como nuevo
                    if (txtIdProvee.Text != "")
                    {
                        // Lógica de edición (comentada)
                         VerdadPersonaGenerada = new CN_proveedor().Editar(ProveedorNuevo, out MensajeProveedor);
                        idProveedorGenerado=ProveedorNuevo.idProveedor;
                    }
                    else
                    {
                        idProveedorGenerado = new CN_proveedor().Registrar(ProveedorNuevo, out MensajeProveedor); // Registra
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
                return false; 
            }

            // Valida la longitud del CUIT
            if (txtCuitProveedor.TextLength > 11 || txtCuitProveedor.TextLength < 10)
            {
                MessageBox.Show("Ingresó un número de CUIT incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            // Valida la longitud del número de teléfono
            if (txtTelefonoProveedor.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            // Valida el formato del correo electrónico
            if (!EsEmailValido(txtEmailProveedor.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; 
            }

            return true; 
        }

        // Método que valida el formato del correo electrónico
        private bool EsEmailValido(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); 
                return emailRegex.IsMatch(email); 
            }
            catch
            {
                MessageBox.Show("Ingresó un email inválido");
                return false; 
            }
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmProveedor_Load_1(object sender, EventArgs e)
        {
            txtRSocialProveedor.Focus();
            if (ProveedorDGV != null)
            {
                

                // Rellena los campos con los datos del proveedor seleccionado
                txtRSocialProveedor.Text = ProveedorDGV.razonSocial.ToString();
                txtCuitProveedor.Text = ProveedorDGV.cuit.ToString();

                txtDireccionProveedor.Text = ProveedorDGV.direccion.ToString();
                txtTelefonoProveedor.Text = ProveedorDGV.telefono.ToString();
                txtEmailProveedor.Text = ProveedorDGV.email.ToString();
                txtDescripcionProveedor.Text = ProveedorDGV.descripcion.ToString();
                txtIdProvee.Text=ProveedorDGV.idProveedor.ToString();
                
            }
        }

    }
}



