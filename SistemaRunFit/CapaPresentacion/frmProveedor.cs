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
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            txtRSocialProveedor.Focus();
        }
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

        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCuitProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (camposValidados())
            {
                string proveedor = txtRSocialProveedor.Text;


                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al proveedor {proveedor}  al sistema?",
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
            bool RSocialVacio = string.IsNullOrEmpty(txtRSocialProveedor.Text);
            bool cuitVacio = string.IsNullOrEmpty(txtCuitProveedor.Text);
            bool direccionVacio = string.IsNullOrEmpty(txtDireccionProveedor.Text);
            bool telefonoVacio = string.IsNullOrEmpty(txtTelefonoProveedor.Text);
            bool emailVacio = string.IsNullOrEmpty(txtEmailProveedor.Text);
            bool descripcionVacio = string.IsNullOrEmpty(txtDescripcionProveedor.Text);
            


            if (RSocialVacio || cuitVacio || direccionVacio || telefonoVacio || emailVacio || descripcionVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtCuitProveedor.TextLength > 11 || txtCuitProveedor.TextLength < 10)
            {
                MessageBox.Show("Ingresó un número de CUIT incorrecto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTelefonoProveedor.TextLength < 10)
            {
                MessageBox.Show("El número de teléfono es muy corto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!EsEmailValido(txtEmailProveedor.Text))
            {
                MessageBox.Show("Correo electrónico no válido", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
    

