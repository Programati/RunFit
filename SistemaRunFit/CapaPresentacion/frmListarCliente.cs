using Guna.UI.WinForms;
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
    public partial class frmListarCliente : Form
    {
        public frmListarCliente()
        {
            InitializeComponent();
            txtBuscarCliente.Focus();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {

            frmCliente CrearNuevoCliente = new frmCliente();

            CrearNuevoCliente.TopLevel = false;
            pnlContenedorCliente.Controls.Clear();
            pnlContenedorCliente.Controls.Add(CrearNuevoCliente);
            CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoCliente.Dock = DockStyle.Fill;

            CrearNuevoCliente.Show();
            CrearNuevoCliente.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarCliente ListarNuevoCliente = new frmListarCliente();

            ListarNuevoCliente.TopLevel = false;
            pnlContenedorCliente.Controls.Clear();
            pnlContenedorCliente.Controls.Add(ListarNuevoCliente);
            ListarNuevoCliente.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoCliente.Dock = DockStyle.Fill;

            ListarNuevoCliente.Show();
        }

    }
}
