using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void txtCantidadItenVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe Ingresas solo numeros en la cantidad de la venta", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
        private void txtBuscarCodigoVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe Ingresas solo numeros para el codigo del producto", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void txtBuscarDniVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe Ingresas solo numeros para el DNI del cliente", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBuscarNombrePtoVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debe Ingresas solo letras en el nombre del producto", "atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void btnLimpiarBuscarClteVta_Click(object sender, System.EventArgs e)
        {
            txtBuscarDniVta.Clear();
            txtApellidoRegVta.Clear();
            txtNombreRegVta.Clear();
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
    }
}
