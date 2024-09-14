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

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (EsDniMuyCorto())
            {
                return;
            }
        }
        private bool EsDniMuyCorto()
        {
            if (txtBuscarCliente.Text.Length < 7)
            {
                MessageBox.Show("El número de DNI es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }
    }
}
