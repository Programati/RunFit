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
    public partial class frmListarUsuario : Form
    {
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            txtBuscarUser.Clear();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarUsuario ListarNuevoUsario = new frmListarUsuario();

            ListarNuevoUsario.TopLevel = false;
            pnlContenedorUser.Controls.Clear();
            pnlContenedorUser.Controls.Add(ListarNuevoUsario);
            ListarNuevoUsario.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoUsario.Dock = DockStyle.Fill;

            ListarNuevoUsario.Show();
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            frmUsuario CrearNuevoUsuario = new frmUsuario();

            CrearNuevoUsuario.TopLevel = false;
            pnlContenedorUser.Controls.Clear();
            pnlContenedorUser.Controls.Add(CrearNuevoUsuario);
            CrearNuevoUsuario.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoUsuario.Dock = DockStyle.Fill;

            CrearNuevoUsuario.Show();
            CrearNuevoUsuario.FormClosing += frm_closing;
        }
    }
}
