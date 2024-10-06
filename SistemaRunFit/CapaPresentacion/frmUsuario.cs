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
using System.Windows.Forms;
using System.Windows.Navigation;
using Guna.UI.WinForms;

using CapaDeEntidades;
using CapaDeNegocios;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        private static Usuario UsuarioDGV = null; // Almacena el usuario que se va a editar

        public frmUsuario()
        {
            InitializeComponent();
            //this.Load += new EventHandler(frmUsuario_Load); // Se puede activar el evento Load para inicializar datos al cargar el formulario
        }

        // Constructor que recibe un objeto Usuario para editar
        public frmUsuario(Usuario UsuarioEditar)
        {
            UsuarioDGV = UsuarioEditar; // Asigna el usuario a editar
            InitializeComponent();
        }

        // Evento al hacer clic en el botón "Guardar"
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            string MensajeUsuario = string.Empty; // Mensaje para el resultado del proceso de usuario
            string MensajePersona = string.Empty; // Mensaje para el resultado del proceso de persona
            int IdPersonaGenerada = 0; // ID de persona generada
            bool VerdadPersonaGenerada = false; // Bandera para verificar si la persona fue generada correctamente
            int IdUsuarioGenerado = 0; // ID de usuario generado
            bool VerdadUsuarioGenerado = false; // Bandera para verificar si el usuario fue generado correctamente
            string mensajeConfirmacion = "¿Desea agregar al"; // Mensaje de confirmación inicial
            string contrasena = null; // Variable para almacenar la contraseña

            // Verifica si los campos están validados
            if (camposValidados())
            {
                contrasena = txtPassUser.Text; // Obtiene la contraseña del campo
                string user = txtUsuario.Text; // Obtiene el nombre de usuario
                string rolSeleccionado = ((Rol)cmbTipoUsuarioUser.SelectedItem).nombreRol.ToString(); // Obtiene el rol seleccionado

                // Modifica el mensaje de confirmación si se está editando un usuario existente
                if (txtIdPersona.Text != "" && txtIdUsuario.Text != "")
                    mensajeConfirmacion = "¿Confirma los cambios del";

                // Muestra un cuadro de diálogo de confirmación
                var confirmacion = MessageBox.Show(
                    $"{mensajeConfirmacion} usuario {user} con el rol {rolSeleccionado} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma la acción
                if (confirmacion == DialogResult.Yes)
                {
                    // Formatea la fecha para la base de datos
                    string fechaFormateada = dtpFechaUser.Value.ToString("yyyy-MM-dd");

                    // Crea un nuevo objeto Persona con los datos del formulario
                    Persona PersonaNueva = new Persona()
                    {
                        idPersona = txtIdPersona.Text != "" ? Convert.ToInt32(txtIdPersona.Text) : IdPersonaGenerada,
                        nombre = txtNombreUser.Text,
                        apellido = txtApellidoUser.Text,
                        dni = txtDniUser.Text,
                        telefono = txtTelefonoUser.Text,
                        email = txtEmailUser.Text,
                        fechaNacimiento = fechaFormateada,
                        sexo = rdbtnMasculinoUser.Checked == true ? Convert.ToChar('M') : Convert.ToChar('F')
                    };

                    // Si hay un ID de persona, se edita
                    if (txtIdPersona.Text != "")
                    {
                        VerdadPersonaGenerada = new CN_Persona().Editar(PersonaNueva, out MensajePersona);
                        IdPersonaGenerada = PersonaNueva.idPersona; // Actualiza el ID de persona generada
                    }
                    // Si no hay ID de persona, se registra como nueva
                    else
                    {
                        IdPersonaGenerada = new CN_Persona().Registrar(PersonaNueva, out MensajePersona);
                    }

                    // Crea un nuevo objeto Usuario con los datos del formulario
                    Usuario UsuarioNuevo = new Usuario()
                    {
                        idUsuario = txtIdUsuario.Text != "" ? Convert.ToInt32(txtIdUsuario.Text) : IdUsuarioGenerado,
                        passwordUsuario = string.IsNullOrEmpty(contrasena.ToString()) ? "" : Encrypt.GetSHA256(txtPassUser.Text),
                        nombreUsuario = txtUsuario.Text,

                        oPersona = new Persona() { idPersona = IdPersonaGenerada }, 
                        oRol = new Rol() { idRol = ((Rol)cmbTipoUsuarioUser.SelectedItem).idRol } 
                    };

                    // Si hay un ID de usuario, se edita
                    if (txtIdUsuario.Text != "")
                    {
                        VerdadUsuarioGenerado = new CN_Usuario().Editar(UsuarioNuevo, out MensajeUsuario);
                        IdPersonaGenerada = PersonaNueva.idPersona; 
                    }
                    // Si no hay ID de usuario, se registra como nuevo
                    else
                    {
                        IdUsuarioGenerado = new CN_Usuario().Registrar(UsuarioNuevo, out MensajeUsuario);
                    }

                    // Verifica si los datos se guardaron correctamente
                    if (IdUsuarioGenerado != 0 && IdPersonaGenerada != 0)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos(); 
                    }
                    else
                    {
                        // Muestra mensajes de error si no se guardaron los datos
                        MessageBox.Show(MensajePersona + "\n" + MensajeUsuario);
                    }
                }
            }
        }


        private bool camposValidados()//Metodo para validar los campos
        {
            // Verifica si el campo de nombre está vacío
            bool nombreVacio = string.IsNullOrEmpty(txtNombreUser.Text);
            // Verifica si el campo de apellido está vacío
            bool apellidoVacio = string.IsNullOrEmpty(txtApellidoUser.Text);
            // Verifica si el campo de DNI está vacío
            bool dniVacio = string.IsNullOrEmpty(txtDniUser.Text);
            // Verifica si el campo de teléfono está vacío
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoUser.Text);
            // Verifica si el campo de email está vacío
            bool emailVacio = string.IsNullOrEmpty(txtEmailUser.Text);
            // Verifica si el campo de usuario está vacío
            bool usuarioVacio = string.IsNullOrEmpty(txtUsuario.Text);
            // Verifica si el campo de contraseña está vacío
            bool passVacio = string.IsNullOrEmpty(txtPassUser.Text);
            // Verifica si el botón de masculino no está seleccionado
            bool masculinoVacio = !rdbtnMasculinoUser.Checked;
            // Verifica si el botón de femenino no está seleccionado
            bool femeninoVacio = !rdbtnFemeninoUser.Checked;

            // Si la contraseña está vacía y no hay ID de persona ni ID de usuario, muestra un mensaje de error
            if (passVacio && (string.IsNullOrEmpty(txtIdPersona.Text) && string.IsNullOrEmpty(txtIdUsuario.Text)))
            {
                MessageBox.Show("Debe establecer una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica si alguno de los campos obligatorios está vacío, incluyendo el sexo
            if (nombreVacio || apellidoVacio || dniVacio || telefonoVacio || emailVacio || (masculinoVacio && femeninoVacio) || usuarioVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verifica que el DNI tenga una longitud válida (7 u 8 dígitos)
            if (txtDniUser.TextLength > 8 || txtDniUser.TextLength < 7)
            {
                MessageBox.Show("Ingresó un número de DNI incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica que el número de teléfono tenga al menos 10 dígitos
            if (txtTelefonoUser.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Valida el formato del correo electrónico
            if (!EsEmailValido(txtEmailUser.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtpFechaUser.Value.Date;

            // Calcular la fecha mínima permitida (18 años atrás desde hoy)
            DateTime fechaMinima = DateTime.Today.AddYears(-18);

            // Verifica si el usuario es menor de 18 años
            if (fechaSeleccionada >= fechaMinima)
            {
                MessageBox.Show("Usted es menor de edad, no puede ser dado de alta en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true; // Todos los campos son válidos
        }

        private void LimpiarCampos()
        {
            // Limpia todos los campos de texto
            txtNombreUser.Clear();
            txtApellidoUser.Clear();
            txtDniUser.Clear();
            txtTelefonoUser.Clear();
            txtEmailUser.Clear();
            txtUsuario.Clear();
            txtPassUser.Clear();
            // Establece el índice seleccionado del ComboBox a 2
            cmbTipoUsuarioUser.SelectedIndex = 2;
            // Desmarca ambos RadioButtons de sexo
            rdbtnMasculinoUser.Checked = false;
            rdbtnFemeninoUser.Checked = false;
            // Establece la fecha actual en el DateTimePicker
            dtpFechaUser.Value = DateTime.Now;
            // Pone el foco en el campo de nombre
            txtNombreUser.Focus();
        }

        private void btnLimpiarCamposUser_Click(object sender, EventArgs e)
        {
            // Llama al método LimpiarCampos cuando se hace clic en el botón
            LimpiarCampos();
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            // Limpia el objeto UsuarioDGV que se trajo del DataGridView
            UsuarioDGV = null;
            // Cierra el formulario
            this.Close();
        }

        private bool EsEmailValido(string email)
        {
            try
            {
                // Expresión regular para validar el formato del correo electrónico
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                // Retorna true si el correo electrónico es válido
                return emailRegex.IsMatch(email);
            }
            catch
            {
                // Muestra un mensaje si hubo un error al validar el correo electrónico
                MessageBox.Show("Ingresó un email inválido");
                return false;
            }
        }

        private void txtNombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, control y espacios en blanco en el campo de nombre
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es válida
            }
        }

        private void txtApellidoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, control y espacios en blanco en el campo de apellido
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es válida
            }
        }

        private void txtDniUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y control en el campo de DNI
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es válida
            }
        }

        private void txtTelefonoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y control en el campo de teléfono
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es válida
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // Pone el foco en el botón de volver al abrir el formulario
            btnVolverUser.Focus();

            // Obtiene la lista de roles y la agrega al ComboBox
            List<Rol> ListaRol = new CN_Rol().Listar();
            foreach (Rol item in ListaRol)
            {
                cmbTipoUsuarioUser.Items.Add(new Rol() { idRol = item.idRol, nombreRol = item.nombreRol });
            }
            // Establece los nombres y valores que se mostrarán en el ComboBox
            cmbTipoUsuarioUser.DisplayMember = "nombreRol";
            cmbTipoUsuarioUser.ValueMember = "idRol";
            cmbTipoUsuarioUser.SelectedIndex = 2; // Selecciona un rol por defecto

            /*
             Si EDITAMOS un USUARIO, vamos a traer todos los datos y rellenar los campos
             */
            if (UsuarioDGV != null)
            {
                char sexo = UsuarioDGV.oPersona.sexo;

                // Rellena los campos con los datos del usuario seleccionado
                txtIdUsuario.Text = UsuarioDGV.idUsuario.ToString();
                txtIdPersona.Text = UsuarioDGV.oPersona.idPersona.ToString();

                txtNombreUser.Text = UsuarioDGV.oPersona.nombre;
                txtApellidoUser.Text = UsuarioDGV.oPersona.apellido;
                txtDniUser.Text = UsuarioDGV.oPersona.dni;
                txtTelefonoUser.Text = UsuarioDGV.oPersona.telefono;
                txtEmailUser.Text = UsuarioDGV.oPersona.email;
                // Selecciona el RadioButton de sexo correspondiente
                if (sexo == 'M') rdbtnMasculinoUser.Checked = true;
                else rdbtnFemeninoUser.Checked = true;

                // Convierte la fecha de nacimiento en formato de cadena a DateTime
                string fechaString = UsuarioDGV.oPersona.fechaNacimiento;
                DateTime fecha = DateTime.Parse(fechaString);
                dtpFechaUser.Value = fecha; // Establece la fecha en el DateTimePicker

                // Rellena el campo de usuario y contraseña
                txtUsuario.Text = UsuarioDGV.nombreUsuario;
                txtPassUser.Text = UsuarioDGV.passwordUsuario;

                // Selecciona el rol correspondiente en el ComboBox
                foreach (Rol item in cmbTipoUsuarioUser.Items)
                {
                    if ((int)item.idRol == UsuarioDGV.oRol.idRol)
                    {
                        int IndiceCombo = cmbTipoUsuarioUser.Items.IndexOf(item);
                        cmbTipoUsuarioUser.SelectedIndex = IndiceCombo; // Establece el índice seleccionado
                        break;
                    }
                }
            }
        }

    }
}
