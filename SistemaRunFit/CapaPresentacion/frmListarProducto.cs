using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmListarProducto : Form
    {
        Inicio _inicio;
        public frmListarProducto(Inicio inicio)
        {
            InitializeComponent();
            _inicio = inicio;
            _inicio.PnlContenedorMenu.Enabled = false;
            
        }
        private void frmListarProducto_Load(object sender, EventArgs e)
        {
            txtBuscarProducto.Focus();
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto CrearNuevoProducto = new frmProducto();

            CrearNuevoProducto.TopLevel = false;
            pnlContenedorProducto.Controls.Clear();
            pnlContenedorProducto.Controls.Add(CrearNuevoProducto);
            CrearNuevoProducto.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoProducto.Dock = DockStyle.Fill;

            CrearNuevoProducto.Show();
            CrearNuevoProducto.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarProducto ListarNuevoProducto = new frmListarProducto(_inicio);

            ListarNuevoProducto.TopLevel = false;
            pnlContenedorProducto.Controls.Clear();
            pnlContenedorProducto.Controls.Add(ListarNuevoProducto);
            ListarNuevoProducto.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoProducto.Dock = DockStyle.Fill;

            ListarNuevoProducto.Show();
        }

        private void btnLimpiarBuscarProducto_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Clear();
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (EsCodigoMuyCorto())
            {
                return;
            }
        }
        private bool EsCodigoMuyCorto()
        {
            if (txtBuscarProducto.Text.Length < 4)
            {
                MessageBox.Show("El CODIGO del Producto es muy corto, vuelva intentar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactivar el panel en Inicio
                _inicio.MostrarImagenFondo(); // Mostrar la imagen de fondo

            }
            this.Close(); // Cierra el formulario actual
        }
    }
}
