using CapaDeEntidades;
using CapaDeNegocios;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Media3D;


namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {
        // Variable estática para almacenar el objeto Domicilio que se pasará desde el DataGridView
        private static Domicilio DomicilioDGV = null;
        Color colorAzul = Color.FromArgb(6, 71, 109);

        // Constructor por defecto (sin parámetros)
        public frmCliente()
        {
            
            InitializeComponent();

        }

        // Constructor que recibe un objeto Domicilio para editar
        public frmCliente(Domicilio DomicilioEditar)
        {
            DomicilioDGV = DomicilioEditar;
            InitializeComponent();
        }

        // Evento para restringir la entrada de caracteres en el TextBox txtNombreCliente.
        // Solo permite letras, controles como Backspace, y espacios en blanco.
        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el carácter presionado no es una letra, un carácter de control (como Backspace), o un espacio, se anula la entrada.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // Evento para restringir la entrada de caracteres en el TextBox txtApellidoCliente.
        // Solo permite letras, controles como Backspace, y espacios en blanco.
        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        
        // Solo permite dígitos y caracteres de control como Backspace.
        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        
        // Solo permite dígitos y caracteres de control como Backspace.
        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el carácter presionado no es un dígito ni un carácter de control, se anula la entrada.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        // Solo permite números y teclas de control en txtAlturaCliente.
        private void txtAlturaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // Solo permite números y teclas de control en txtManzanaCliente.
        private void txtManzanaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Solo permite números y teclas de control en txtCasaCliente.
        private void txtCasaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Solo permite números y teclas de control en txtPisoCliente.
        private void txtPisoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // Maneja el cambio de estado del CheckBox Opcion1.
        private void chbActivarOpcion1Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbActivarOpcion1Cliente.Checked == true)
            {
                chbActivarOpcion2Cliente.Checked = false; 
                grbOpcion2Cliente.Enabled = false;

                grbOpcion1Cliente.Enabled = true; 
                txtDeptoCliente.ForeColor = colorAzul; 
                txtPisoCliente.ForeColor = colorAzul;  

                txtCasaCliente.Clear(); 
                txtManzanaCliente.Clear(); 
                txtPisoCliente.Focus();
            }
            if (chbActivarOpcion1Cliente.Checked == false)
            {
                grbOpcion1Cliente.Enabled = false; 
                txtAlturaCliente.Focus(); 
            }
        }

        // Maneja el cambio de estado del CheckBox Opcion2.
        private void chbActivarOpcion2Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbActivarOpcion2Cliente.Checked == true)
            {
                chbActivarOpcion1Cliente.Checked = false; // Desmarca Opcion1.
                grbOpcion1Cliente.Enabled = false; // Desactiva el grupo Opcion1.

                grbOpcion2Cliente.Enabled = true; // Activa el grupo Opcion2.
                txtCasaCliente.ForeColor = colorAzul; // Cambia el color del texto de Casa.
                txtManzanaCliente.ForeColor = colorAzul; // Cambia el color del texto de Manzana.

                txtPisoCliente.Clear(); // Limpia el campo Piso de Opcion1.
                txtDeptoCliente.Clear(); // Limpia el campo Depto de Opcion1.
                txtAlturaCliente.Clear(); // Limpia el campo Altura.
                txtManzanaCliente.Focus(); // Coloca el foco en el campo Manzana.
            }

            if (chbActivarOpcion2Cliente.Checked == false)
            {
                grbOpcion2Cliente.Enabled = false; // Desactiva el grupo Opcion2.
                txtAlturaCliente.Focus(); // Coloca el foco en el campo Altura.
            }
        }

        // Evento que llama a la función para limpiar los campos del formulario.
        private void btnLimpiarContenedorCliente_Click(object sender, EventArgs e)
        {
            limpiarFormCliente();
        }

        // Limpia todos los campos del formulario.
        private void limpiarFormCliente()
        {
            txtNombreCliente.Clear(); // Limpia el campo Nombre.
            txtApellidoCliente.Clear(); // Limpia el campo Apellido.
            txtDniCliente.Clear(); // Limpia el campo DNI.
            txtTelefonoCliente.Clear(); // Limpia el campo Teléfono.
            txtEmailCliente.Clear(); // Limpia el campo Email.
            rdbtnMasculinoCliente.Checked = false; // Desmarca el botón Masculino.
            rdbtnFemeninoCliente.Checked = false; // Desmarca el botón Femenino.
            dtpFechaCliente.Value = DateTime.Now; // Resetea la fecha a hoy.

            txtCalleCliente.Clear(); // Limpia el campo Calle.
            txtAlturaCliente.Clear(); // Limpia el campo Altura.

            chbActivarOpcion1Cliente.Checked = false; // Desmarca Opcion1.
            grbOpcion1Cliente.Enabled = false; // Desactiva el grupo Opcion1.
            txtPisoCliente.Clear(); // Limpia el campo Piso.
            txtDeptoCliente.Clear(); // Limpia el campo Depto.

            chbActivarOpcion2Cliente.Checked = false; // Desmarca Opcion2.
            grbOpcion2Cliente.Enabled = false; // Desactiva el grupo Opcion2.
            txtManzanaCliente.Clear(); // Limpia el campo Manzana.
            txtCasaCliente.Clear(); // Limpia el campo Casa.

            txtNombreCliente.Focus(); // Coloca el foco en el campo Nombre.
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            // Variables para almacenar mensajes y resultados de validación.
            string MensajeDomicilio = string.Empty;
            string MensajePersona = string.Empty;
            int IdPersonaGenerada = 0; // ID de la persona generada o editada.
            bool VerdadPersonaGenerada = false; // Indica si la persona fue generada correctamente.
            int IdDomicilioGenerado = 0; // ID del domicilio generado o editado.
            bool VerdadDomicilioGenerado = false; // Indica si el domicilio fue generado correctamente.

            // Valida si los datos personales y de domicilio son correctos.
            if (datosPersonalesValidados() && datosDomicilioValidados())
            {
                // Muestra un mensaje de confirmación antes de guardar.
                var confirmacion = MessageBox.Show(
                    $"Desea agregar a la persona {txtApellidoCliente.Text} {txtNombreCliente.Text}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma (elige "Yes").
                if (confirmacion == DialogResult.Yes)
                {
                    // Formatea la fecha seleccionada en el DateTimePicker para guardar en la BD.
                    string fechaFormateada = dtpFechaCliente.Value.ToString("yyyy-MM-dd");

                    // Crea un nuevo objeto de tipo Persona con los datos del formulario.
                    Persona PersonaNueva = new Persona()
                    {
                        idPersona = txtIdPersona.Text != "" ? Convert.ToInt32(txtIdPersona.Text) : IdPersonaGenerada, // Si el ID está vacío, asigna el nuevo ID.
                        nombre = txtNombreCliente.Text,
                        apellido = txtApellidoCliente.Text,
                        dni = txtDniCliente.Text,
                        telefono = txtTelefonoCliente.Text,
                        email = txtEmailCliente.Text,
                        fechaNacimiento = fechaFormateada,
                        sexo = rdbtnMasculinoCliente.Checked == true ? Convert.ToChar('M') : Convert.ToChar('F') // Asigna 'M' o 'F' según el sexo seleccionado.
                    };

                    // Si el ID de persona ya existe, edita la persona.
                    if (txtIdPersona.Text != "")
                    {
                        VerdadPersonaGenerada = new CN_Persona().Editar(PersonaNueva, out MensajePersona);
                        IdPersonaGenerada = PersonaNueva.idPersona; // Asigna el ID de la persona generada.
                    }
                    // Si no existe ID de persona, registra una nueva persona.
                    else
                    {
                        IdPersonaGenerada = new CN_Persona().Registrar(PersonaNueva, out MensajePersona); // Registra la nueva persona.
                    }

                    // Crea un nuevo objeto de tipo Domicilio con los datos del formulario.
                    Domicilio DomicilioNuevo = new Domicilio()
                    {
                        idDomicilio = txtIdDomicilio.Text != "" ? Convert.ToInt32(txtIdDomicilio.Text) : IdDomicilioGenerado, // Si el ID está vacío, asigna el nuevo ID.
                        calle = txtCalleCliente.Text,
                        altura = txtAlturaCliente.Text,
                        manzana = txtManzanaCliente.Text,
                        casa = txtCasaCliente.Text,
                        piso = txtPisoCliente.Text,
                        departamento = txtDeptoCliente.Text,
                        oPersona = new Persona() { idPersona = IdPersonaGenerada } // Asocia el domicilio a la persona creada o editada.
                    };

                    // Si el ID de domicilio ya existe, edita el domicilio.
                    if (txtIdDomicilio.Text != "")
                    {
                        VerdadDomicilioGenerado = new CN_Domicilio().Editar(DomicilioNuevo, out MensajeDomicilio);
                        IdPersonaGenerada = PersonaNueva.idPersona;
                    }
                    // Si no existe ID de domicilio, registra un nuevo domicilio.
                    else
                    {
                        IdDomicilioGenerado = new CN_Domicilio().Registrar(DomicilioNuevo, out MensajeDomicilio); // Registra el nuevo domicilio.
                    }

                    // Si ambos, persona y domicilio, se generaron correctamente.
                    if (IdDomicilioGenerado != 0 && IdPersonaGenerada != 0)
                    {
                        // Muestra mensaje de éxito y limpia el formulario.
                        MessageBox.Show("Los datos se guardaron exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarFormCliente(); // Limpia el formulario.
                    }
                    else
                    {
                        // Si hubo errores, muestra los mensajes de error.
                        MessageBox.Show(MensajePersona + "\n" + MensajeDomicilio);
                    }
                }
            }
        }


        // Método para validar los datos personales ingresados en el formulario
        private bool datosPersonalesValidados()
        {
            // Verificar si los campos de datos personales están vacíos
            bool nombreVacio = string.IsNullOrEmpty(txtNombreCliente.Text);
            bool apellidoVacio = string.IsNullOrEmpty(txtApellidoCliente.Text);
            bool dniVacio = string.IsNullOrEmpty(txtDniCliente.Text);
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoCliente.Text);
            bool emailVacio = string.IsNullOrEmpty(txtEmailCliente.Text);
            // Verificar si no se ha seleccionado ninguno de los radios de sexo
            bool masculinoVacio = !rdbtnMasculinoCliente.Checked;
            bool femeninoVacio = !rdbtnFemeninoCliente.Checked;

            // Verifica si algún campo obligatorio está vacío
            if (nombreVacio || apellidoVacio || dniVacio || telefonoVacio || emailVacio || (masculinoVacio && femeninoVacio))
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el DNI tenga entre 7 y 8 caracteres
            if (txtDniCliente.TextLength > 8 || txtDniCliente.TextLength < 7)
            {
                MessageBox.Show("Ingresó un número de DNI incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el teléfono tenga al menos 10 caracteres
            if (txtTelefonoCliente.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el correo electrónico tenga un formato correcto
            if (!EsEmailValido(txtEmailCliente.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtpFechaCliente.Value.Date;

            // Calcular la fecha mínima permitida (persona debe tener al menos 18 años)
            DateTime fechaMinima = DateTime.Today.AddYears(-18);

            // Validar que la persona tenga al menos 18 años
            if (fechaSeleccionada >= fechaMinima)
            {
                MessageBox.Show("Usted es menor de edad, no puede ser dado de alta en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Si todas las validaciones pasaron, retorna true
        }

        // Método para validar los datos del domicilio ingresados en el formulario
        private bool datosDomicilioValidados()
        {
            // Verificar si los campos de domicilio están vacíos
            bool calleVacio = string.IsNullOrEmpty(txtCalleCliente.Text);
            bool alturaVacio = string.IsNullOrEmpty(txtAlturaCliente.Text);
            bool opcion1Vacio = !chbActivarOpcion1Cliente.Checked;
            bool pisoVacio = string.IsNullOrEmpty(txtPisoCliente.Text);
            bool deptoVacio = string.IsNullOrEmpty(txtDeptoCliente.Text);
            bool opcion2Vacio = !chbActivarOpcion2Cliente.Checked;
            bool casaVacio = string.IsNullOrEmpty(txtCasaCliente.Text);
            bool manzanaVacio = string.IsNullOrEmpty(txtManzanaCliente.Text);

            // Validar que la calle no esté vacía
            if (calleVacio)
            {
                MessageBox.Show("Debe ingresar calle", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Si la calle y altura están llenas y ninguna opción de tipo de vivienda está seleccionada, se permite continuar
            if (!calleVacio && !alturaVacio && opcion1Vacio && opcion2Vacio)
            {
                return true;
            }

            // Validar que se seleccione al menos una opción (departamento o casa)
            if (opcion1Vacio && opcion2Vacio)
            {
                MessageBox.Show("Debe seleccionar una opción", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Si se selecciona la opción de departamento, validar que el piso, el depto y la altura no estén vacíos
            if (!opcion1Vacio && (pisoVacio || deptoVacio || alturaVacio))
            {
                MessageBox.Show("Debe ingresar una Altura, el N° del Piso y el N° del Departamento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Si se selecciona la opción de casa, validar que el número de casa y manzana no estén vacíos
            if (!opcion2Vacio && (casaVacio || manzanaVacio))
            {
                MessageBox.Show("Debe ingresar el N° de Casa y el N° de la Manzana", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Si todas las validaciones pasaron, retorna true
        }

        // Método para validar el formato del email usando una expresión regular
        private bool EsEmailValido(string email)
        {
            try
            {
                // Expresión regular para validar el formato del correo
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return emailRegex.IsMatch(email);
            }
            catch
            {
                MessageBox.Show("Ingresó un email inválido");
                return false;
            }
        }

        // Evento del botón Volver para cerrar el formulario
        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            // Reinicia la variable de DomicilioDGV y cierra el formulario
            DomicilioDGV = null;
            this.Close();
        }

        // Evento que se ejecuta cuando se carga el formulario
        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Pone el foco en el campo nombre del cliente al abrir el formulario
            txtNombreCliente.Focus();

            // Si se está editando un cliente, carga los datos en los campos correspondientes
            if (DomicilioDGV != null)
            {
                // Cargar el sexo del cliente
                char sexo = DomicilioDGV.oPersona.sexo;

                // Rellenar los campos con los datos del cliente
                txtIdPersona.Text = DomicilioDGV.oPersona.idPersona.ToString();
                txtNombreCliente.Text = DomicilioDGV.oPersona.nombre;
                txtApellidoCliente.Text = DomicilioDGV.oPersona.apellido;
                txtDniCliente.Text = DomicilioDGV.oPersona.dni;
                txtTelefonoCliente.Text = DomicilioDGV.oPersona.telefono;
                txtEmailCliente.Text = DomicilioDGV.oPersona.email;
                if (sexo == 'M') rdbtnMasculinoCliente.Checked = true;
                else rdbtnFemeninoCliente.Checked = true;

                // Cargar y asignar la fecha de nacimiento
                string fechaString = DomicilioDGV.oPersona.fechaNacimiento;
                DateTime fecha = DateTime.Parse(fechaString);
                dtpFechaCliente.Value = fecha;

                // Cargar los datos del domicilio del cliente
                txtIdDomicilio.Text = DomicilioDGV.idDomicilio.ToString();
                txtCalleCliente.Text = DomicilioDGV.calle;
                txtAlturaCliente.Text = DomicilioDGV.altura;

                // Si tiene departamento, activar la opción de departamento y cargar los datos
                if (DomicilioDGV.departamento != "")
                {
                    chbActivarOpcion1Cliente.Checked = true;
                    txtPisoCliente.Text = DomicilioDGV.piso;
                    txtDeptoCliente.Text = DomicilioDGV.departamento;
                }

                // Si tiene casa, activar la opción de casa y cargar los datos
                if (DomicilioDGV.casa != "")
                {
                    chbActivarOpcion2Cliente.Checked = true;
                    txtCasaCliente.Text = DomicilioDGV.casa;
                    txtManzanaCliente.Text = DomicilioDGV.manzana;
                }

                // Pone el foco en el botón Volver al finalizar la carga de datos
                btnVolverCliente.Focus();
            }
        }

    }
}
