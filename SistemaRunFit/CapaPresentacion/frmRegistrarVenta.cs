using System;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        private Inicio _inicioForm; // Variable para almacenar la referencia del formulario Inicio

        public frmRegistrarVenta(Inicio inicioForm)
        {
            InitializeComponent();
            _inicioForm = inicioForm; // Asignar la referencia del formulario Inicio
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
                MessageBox.Show("El DNI no puede contener más de 8 dígitos");
            }
            if (txtBuscarDniVta.Text.Length < 7)
            {
                MessageBox.Show("El DNI es muy corto");
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
            // Lógica de confirmación de venta
        }

        private void btnAgregaritemVta_Click(object sender, System.EventArgs e)
        {
            // Lógica de agregar ítem
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (_inicioForm != null)
            {
                _inicioForm.PnlContenedorMenu.Enabled = true; // Reactivar el panel en Inicio
            }
            this.Close(); // Cierra el formulario actual
        }
    }
}
