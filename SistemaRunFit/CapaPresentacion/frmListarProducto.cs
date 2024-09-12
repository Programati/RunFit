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
        public frmListarProducto()
        {
            InitializeComponent();
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
            frmListarProducto ListarNuevoProducto = new frmListarProducto();

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
    }
}
