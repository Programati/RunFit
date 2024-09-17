﻿using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaDeNegocios;

namespace CapaPresentacion
{
    public partial class frmListarUsuario : Form
    {
        Inicio _inicio;
        public frmListarUsuario(Inicio inicio)
        {
            InitializeComponent();
            _inicio = inicio;
            _inicio.PnlContenedorMenu.Enabled = false;
           
        }
      
        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            txtBuscarUser.Clear();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarUsuario ListarNuevoUsario = new frmListarUsuario(_inicio);

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

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            if (EsDniMuyCorto())
            {
                return;
            }
        }

        private bool EsDniMuyCorto()
        {
            if (txtBuscarUser.Text.Length < 7)
            {
                MessageBox.Show("El número de DNI es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;
        }

        private void txtBuscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            //Pone el foco en el txtbox buscar usuario
            txtBuscarUser.Focus();
            
            List<Usuario> ListaUsuario = new CN_Usuario().ListarUsuarios();

            foreach (Usuario item in ListaUsuario)
            {
                dgvListaUser.Rows.Add(new object[] {CapaPresentacion.Properties.Resources.Culture, CapaPresentacion.Properties.Resources.Eliminar, item.idUsuario, item.oRol.idRol, item.oRol.nombreRol, item.nombreUsuario, item.fechaBaja != null ? "Activo" : "Inactivo"});
            }
        }

        private void dgvListaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    Rol rolEditar = new Rol() {idRol = (int)dgvListaUser.Rows[n].Cells["IdRol"].Value, nombreRol = dgvListaUser.Rows[n].Cells["NombreRol"].Value.ToString() };
                    Usuario usuarioEditar = new Usuario() { nombreUsuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString(), oRol = rolEditar };
                    frmUsuario CrearNuevoUsuario = new frmUsuario(usuarioEditar);

                    CrearNuevoUsuario.TopLevel = false;
                    pnlContenedorUser.Controls.Clear();
                    pnlContenedorUser.Controls.Add(CrearNuevoUsuario);
                    CrearNuevoUsuario.FormBorderStyle = FormBorderStyle.None;
                    CrearNuevoUsuario.Dock = DockStyle.Fill;

                    CrearNuevoUsuario.Show();
                    CrearNuevoUsuario.FormClosing += frm_closing;
                }
            }

            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    dgvListaUser.Rows[n].DefaultCellStyle.BackColor = Color.Purple;
                }
            }
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactivar el panel en Inicio
            }
            this.Close(); // Cierra el formulario actual
        }
    }
}
