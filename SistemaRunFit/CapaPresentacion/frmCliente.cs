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
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Media3D;


namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {
        Color colorAzul = Color.FromArgb(6, 71, 109);
        public frmCliente()
        {
            InitializeComponent();
            txtNombreCliente.Focus();
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlturaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtManzanaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCasaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPisoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void chbActivarOpcion1Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbActivarOpcion1Cliente.Checked == true)
            {
                chbActivarOpcion2Cliente.Checked = false;//Checke2 void
                grbOpcion2Cliente.Enabled = false;//Grup 2 Disabled

                grbOpcion1Cliente.Enabled = true;//Grup 1 Enable
                txtDeptoCliente.ForeColor = colorAzul;
                txtPisoCliente.ForeColor = colorAzul;

                txtCasaCliente.Clear();//Clear txtGroup2
                txtManzanaCliente.Clear();//Clear txtGroup2
                txtPisoCliente.Focus();
            }
            if(chbActivarOpcion1Cliente.Checked == false)
            {
                grbOpcion1Cliente.Enabled = false;//Grup 1 Disabled
                txtAlturaCliente.Focus();
            }
        }

        private void chbActivarOpcion2Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbActivarOpcion2Cliente.Checked == true)
            {
                chbActivarOpcion1Cliente.Checked = false;//Checke1 void
                grbOpcion1Cliente.Enabled = false;//Grup 1 Disabled

                grbOpcion2Cliente.Enabled = true;//Grup 2 Enable
                txtCasaCliente.ForeColor = colorAzul;
                txtManzanaCliente.ForeColor = colorAzul;

                txtPisoCliente.Clear();//Clear txtGroup1
                txtDeptoCliente.Clear();//Clear txtGroup 1
                txtAlturaCliente.Clear();
                txtManzanaCliente.Focus();
            }

            if (chbActivarOpcion2Cliente.Checked == false)
            {
                grbOpcion2Cliente.Enabled = false;//Grup 1 Disabled
                txtAlturaCliente.Focus();
            }
        }

        private void btnLimpiarContenedorCliente_Click(object sender, EventArgs e)
        {
            limpiarFormCliente();
        }

        private void limpiarFormCliente()
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtDniCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();
            rdbtnMasculinoCliente.Checked = false;
            rdbtnFemeninoCliente.Checked = false;
            dtpFechaCliente.Value =  DateTime.Now;

            txtCalleCliente.Clear();
            txtAlturaCliente.Clear();

            chbActivarOpcion1Cliente.Checked = false;
            grbOpcion1Cliente.Enabled = false;
            txtPisoCliente.Clear();
            txtDeptoCliente.Clear();

            chbActivarOpcion2Cliente.Checked = false;
            grbOpcion2Cliente.Enabled = false;
            txtManzanaCliente.Clear();
            txtCasaCliente.Clear();

            txtNombreCliente.Focus();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (datosPersonalesValidados() && datosDomicilioValidados())
            {
                var confirmacion = MessageBox.Show(
                    $"Desea agregar a la persona {txtApellidoCliente.Text} {txtNombreCliente.Text}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Aquí puedes agregar el código para guardar los datos
                    MessageBox.Show("Los datos se guardaron exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarFormCliente();
                }

            }

        }

        private bool datosPersonalesValidados()
        {
            //Todos las variables daran TRUE si están vacias
            bool nombreVacio = string.IsNullOrEmpty(txtNombreCliente.Text);
            bool apellidoVacio = string.IsNullOrEmpty(txtApellidoCliente.Text);
            bool dniVacio = string.IsNullOrEmpty(txtDniCliente.Text);
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoCliente.Text);
            bool emailVacio = string.IsNullOrEmpty(txtEmailCliente.Text);
            bool masculinoVacio = !rdbtnMasculinoCliente.Checked;
            bool femeninoVacio = !rdbtnFemeninoCliente.Checked;

            if (nombreVacio || apellidoVacio || dniVacio || telefonoVacio || emailVacio || (masculinoVacio && femeninoVacio))
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDniCliente.TextLength > 8 || txtDniCliente.TextLength < 7)
            {
                MessageBox.Show("Ingresó un número de DNI incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefonoCliente.TextLength < 10 )
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!EsEmailValido(txtEmailCliente.Text))
            {
            MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
            }

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime fechaSeleccionada = dtpFechaCliente.Value.Date;

            // Calcular la fecha mínima permitida (18 años atrás desde hoy)
            DateTime fechaMinima = DateTime.Today.AddYears(-18);

            if (fechaSeleccionada >= fechaMinima)
            {
                MessageBox.Show("Usted es menor de edad, no puede ser dado de alta en el sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool datosDomicilioValidados()
        {
            bool calleVacio = string.IsNullOrEmpty(txtCalleCliente.Text);
            bool alturaVacio = string.IsNullOrEmpty(txtAlturaCliente.Text);
            bool opcion1Vacio = !chbActivarOpcion1Cliente.Checked;
            bool pisoVacio = string.IsNullOrEmpty(txtPisoCliente.Text);
            bool deptoVacio = string.IsNullOrEmpty(txtDeptoCliente.Text);
            bool opcion2Vacio = !chbActivarOpcion2Cliente.Checked;
            bool casaVacio = string.IsNullOrEmpty(txtCasaCliente.Text);
            bool manzanaVacio = string.IsNullOrEmpty(txtManzanaCliente.Text);

            if (calleVacio)
            {
                MessageBox.Show("Debe ingresar calle", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!calleVacio && !alturaVacio && opcion1Vacio && opcion2Vacio)
            {
                return true;
            }

            if(opcion1Vacio && opcion2Vacio)
            {
                MessageBox.Show("Debe seleccionar una opcion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!opcion1Vacio && (pisoVacio || deptoVacio || alturaVacio))
            {
                MessageBox.Show("Debe ingresar una Altura, el N° del Piso y el N° del Departamento", "Atencion", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return false;
            }

            if(!opcion2Vacio && (casaVacio || manzanaVacio))
            {
                MessageBox.Show("Debe ingresar el N° de Casa y el N° de la Manzana", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
