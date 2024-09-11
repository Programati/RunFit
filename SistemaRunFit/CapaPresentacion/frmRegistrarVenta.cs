using System.Windows.Forms;

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
    }
}
