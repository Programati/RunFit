﻿using System;
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
    public partial class frmListarProveedor : Form
    {
        public frmListarProveedor()
        {
            InitializeComponent();
        }
        private void LimpiarPorProveedor()
        {
            txtBuscarPorProveedor.Clear();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarProveedor ListarNuevoProveedor = new frmListarProveedor();

            ListarNuevoProveedor.TopLevel = false;
            pnlContenedorDatosProveedor.Controls.Clear();
            pnlContenedorDatosProveedor.Controls.Add(ListarNuevoProveedor);
            ListarNuevoProveedor.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoProveedor.Dock = DockStyle.Fill;

            ListarNuevoProveedor.Show();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor CrearNuevoProveedor = new frmProveedor();

            CrearNuevoProveedor.TopLevel = false;
            pnlContenedorDatosProveedor.Controls.Clear();
            pnlContenedorDatosProveedor.Controls.Add(CrearNuevoProveedor);
            CrearNuevoProveedor.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoProveedor.Dock = DockStyle.Fill;

            CrearNuevoProveedor.Show();
            CrearNuevoProveedor.FormClosing += frm_closing;
        }

        private void btnLimpiarPorProveedor_Click_1(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Clear();
        }

        private void txtBuscarPorProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarPorProveedor_Click(object sender, EventArgs e)
        {
            if (EsCuitMuyCorto())
            {
                return;
            }
        }
        private bool EsCuitMuyCorto()
        {
            if (txtBuscarPorProveedor.Text.Length < 10)
            {
                MessageBox.Show("El número del CUIT del Proveedor es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }
    }

}
