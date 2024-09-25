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
        private static Usuario UsuarioDGV = null;
        public frmUsuario()
        {
            InitializeComponent();
            //this.Load += new EventHandler(frmUsuario_Load);
        }
        public frmUsuario(Usuario UsuarioEditar)
        {
            UsuarioDGV = UsuarioEditar;
            InitializeComponent();
            
        }
              
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            string MensajeUsuario = string.Empty;
            string MensajePersona = string.Empty;
            int IdPersonaGenerada = 0;
            bool VerdadPersonaGenerada = false;
            int IdUsuarioGenerado = 0;
            bool VerdadUsuarioGenerado = false;
            string mensajeConfirmacion = "¿Desea agrear al";
            object contrasena = null;

            if (camposValidados())
            {
                contrasena = txtPassUser.Text;
                string user = txtUsuario.Text;
                string rolSeleccionado = ((Rol)cmbTipoUsuarioUser.SelectedItem).nombreRol.ToString();
                if (txtIdPersona.Text != "" && txtIdUsuario.Text != "") mensajeConfirmacion = "¿Confirma los cambios del";

                var confirmacion = MessageBox.Show(
                    $"{mensajeConfirmacion} usuario {user} con el rol {rolSeleccionado} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Seteo la fecha para la BD
                    string fechaFormateada = dtpFechaUser.Value.ToString("yyyy-MM-dd");
                    
                    //Cargo la persona
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
                    //Si hay dato en txtIdPersona, EDITAMOS
                    if (txtIdPersona.Text != "")
                    {
                        VerdadPersonaGenerada = new CN_Persona().Editar(PersonaNueva, out MensajePersona);
                        IdPersonaGenerada = PersonaNueva.idPersona;
                    }
                    //Si no hay dato en txtIdPersona REGISTRAMOS
                    else
                    {
                        IdPersonaGenerada = new CN_Persona().Registrar(PersonaNueva, out MensajePersona);
                    }

                    Usuario UsuarioNuevo = new Usuario()
                    {
                        idUsuario = txtIdUsuario.Text != "" ? Convert.ToInt32(txtIdUsuario.Text) : IdUsuarioGenerado,
                        passwordUsuario = contrasena != null ? Encrypt.GetSHA256(contrasena.ToString()) : null,
                        nombreUsuario = txtUsuario.Text,

                        oPersona = new Persona() { idPersona = IdPersonaGenerada },
                        oRol = new Rol() { idRol = ((Rol)cmbTipoUsuarioUser.SelectedItem).idRol }
                    };

                    //Si hay dato en txtIdUsuario, EDITAMOS
                    if (txtIdUsuario.Text != "")
                    {
                        VerdadUsuarioGenerado = new CN_Usuario().Editar(UsuarioNuevo, out MensajeUsuario);
                        IdPersonaGenerada = PersonaNueva.idPersona;
                    }
                    //Si no hay dato en txtIdUsuario REGISTRAMOS
                    else
                    {
                        IdUsuarioGenerado = new CN_Usuario().Registrar(UsuarioNuevo, out MensajeUsuario);
                    }

                    if (IdUsuarioGenerado != 0 && IdPersonaGenerada != 0)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(MensajePersona + "\n" + MensajeUsuario);
                    }

                    


                }
            }
        }

        

        private bool camposValidados()
        {
            bool nombreVacio = string.IsNullOrEmpty(txtNombreUser.Text);
            bool apellidoVacio = string.IsNullOrEmpty(txtApellidoUser.Text);
            bool dniVacio = string.IsNullOrEmpty(txtDniUser.Text);
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoUser.Text);
            bool emailVacio = string.IsNullOrEmpty(txtEmailUser.Text);
            bool usuarioVacio = string.IsNullOrEmpty(txtUsuario.Text);
            bool passVacio = string.IsNullOrEmpty(txtPassUser.Text);
            bool masculinoVacio = !rdbtnMasculinoUser.Checked;
            bool femeninoVacio = !rdbtnFemeninoUser.Checked;

            if (passVacio && (string.IsNullOrEmpty(txtIdPersona.Text) && string.IsNullOrEmpty(txtIdUsuario.Text)))
            {
                MessageBox.Show("Debe establecer una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (nombreVacio || apellidoVacio || dniVacio || telefonoVacio || emailVacio || (masculinoVacio && femeninoVacio) || usuarioVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDniUser.TextLength > 8 || txtDniUser.TextLength < 7)
            {
                MessageBox.Show("Ingresó un número de DNI incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefonoUser.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!EsEmailValido(txtEmailUser.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtpFechaUser.Value.Date;

            // Calcular la fecha mínima permitida (18 años atrás desde hoy)
            DateTime fechaMinima = DateTime.Today.AddYears(-18);

            if (fechaSeleccionada >= fechaMinima)
            {
                MessageBox.Show("Usted es menor de edad, no puede ser dado de alta en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtNombreUser.Clear();
            txtApellidoUser.Clear();
            txtDniUser.Clear();
            txtTelefonoUser.Clear();
            txtEmailUser.Clear();
            txtUsuario.Clear();
            txtPassUser.Clear();
            cmbTipoUsuarioUser.SelectedIndex = 2;
            rdbtnMasculinoUser.Checked = false;
            rdbtnFemeninoUser.Checked = false;
            dtpFechaUser.Value = DateTime.Now;
            txtNombreUser.Focus();
        }

        private void btnLimpiarCamposUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();            
        }

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            //Limpiamos el USUARIO que trajimos del DGV
            UsuarioDGV = null;
            this.Close();
        }

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

        private void txtNombreUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDniUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //Pone el foco en el nombre del usuaio al abrir el formulario usuario
            btnVolverUser.Focus();
            

            List<Rol> ListaRol = new CN_Rol().Listar();
            foreach (Rol item in ListaRol)
            {
                cmbTipoUsuarioUser.Items.Add(new Rol() { idRol = item.idRol, nombreRol = item.nombreRol });
            }
            cmbTipoUsuarioUser.DisplayMember = "nombreRol";
            cmbTipoUsuarioUser.ValueMember = "idRol";
            cmbTipoUsuarioUser.SelectedIndex = 2;


            /*
             Si EDITAMOS un USUARIO, vamos a traer todos los datos y rellenar los campos
             */
            if (UsuarioDGV != null)
            {
                char sexo = UsuarioDGV.oPersona.sexo;

                txtIdUsuario.Text = UsuarioDGV.idUsuario.ToString();
                txtIdPersona.Text = UsuarioDGV.oPersona.idPersona.ToString();

                txtNombreUser.Text = UsuarioDGV.oPersona.nombre;
                txtApellidoUser.Text = UsuarioDGV.oPersona.apellido;
                txtDniUser.Text = UsuarioDGV.oPersona.dni;
                txtTelefonoUser.Text = UsuarioDGV.oPersona.telefono;
                txtEmailUser.Text = UsuarioDGV.oPersona.email;
                if (sexo == 'M') rdbtnMasculinoUser.Checked = true;
                else rdbtnFemeninoUser.Checked = true;

                string fechaString = UsuarioDGV.oPersona.fechaNacimiento;
                DateTime fecha = DateTime.Parse(fechaString);
                dtpFechaUser.Value = fecha;

                txtUsuario.Text = UsuarioDGV.nombreUsuario;
                txtPassUser.Text = UsuarioDGV.passwordUsuario;

                foreach (Rol item in cmbTipoUsuarioUser.Items)
                {
                    if ((int)item.idRol == UsuarioDGV.oRol.idRol)
                    {
                        int IndiceCombo = cmbTipoUsuarioUser.Items.IndexOf(item);
                        cmbTipoUsuarioUser.SelectedIndex = IndiceCombo;
                        break;
                    }
                }
            }
        }
    }
}
