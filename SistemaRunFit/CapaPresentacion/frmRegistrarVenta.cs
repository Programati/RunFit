using System;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmRegistrarVenta_Load);
        }
        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarDniVta.Focus();
        }

        private void btnBuscarClteVta_Click(object sender, System.EventArgs e)
        {
            if (txtBuscarDniVta.Text.Length > 8)
            {
                MessageBox.Show("El DNI no puede contener mas de 8 digitos");
            }
            if (txtBuscarDniVta.Text.Length < 7)
            {
                MessageBox.Show("El DNI  es muy corto");
            }

        }

        private void txtLimpiarBuscarPtoVta_Click(object sender, System.EventArgs e)
        {
            txtNomPtoRegVtas.Clear();
            txtBuscarCodigoVta.Clear();
            txtCantidadItenVta.Clear();
        }

        private void txtBuscarDniVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarCodigoVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadItenVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirmarVta_Click(object sender, System.EventArgs e)
        {

        }

        private void btnAgregaritemVta_Click(object sender, System.EventArgs e)
        {

        }
    }
}
