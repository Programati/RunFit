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

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            if (camposValidados())
            {
                string user = txtUsuario.Text;
                string rolSeleccionado = cmbTipoUsuarioUser.SelectedItem.ToString();

                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al usuario {user} con el rol {rolSeleccionado} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Datos guardados exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();


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


            if (nombreVacio || apellidoVacio || dniVacio || telefonoVacio || emailVacio || (masculinoVacio && femeninoVacio))
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
            cmbTipoUsuarioUser.SelectedIndex = -1;
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
    }
}
