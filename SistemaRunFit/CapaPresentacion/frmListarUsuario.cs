using CapaDeEntidades;
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
            //if (EsDniMuyCorto())
            //{
            //    return;
            //}
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (dgvListaUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaUser.Rows)
                {
                    if (row.Cells["Usuario"].Value.ToString().Trim().ToUpper().Contains(txtBuscarUser.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            txtBuscarUser.Clear();
            foreach (DataGridViewRow row in dgvListaUser.Rows)
            {
                row.Visible = true;
            }
        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            //Pone el foco en el txtbox buscar usuario
            txtBuscarUser.Focus();

            List<Usuario> ListaUsuario = new CN_Usuario().ListarUsuarios();

            foreach (Usuario item in ListaUsuario)
            {
                dgvListaUser.Rows.Add(new object[] { CapaPresentacion.Properties.Resources.editar, CapaPresentacion.Properties.Resources.Eliminar, item.idUsuario, item.oRol.idRol, item.oRol.nombreRol, item.nombreUsuario, item.passwordUsuario ,item.fechaBaja != null ? "Activo" : "Inactivo", item.oPersona.idPersona, item.oPersona.dni, item.oPersona.nombre, item.oPersona.apellido, item.oPersona.email, item.oPersona.telefono, item.oPersona.fechaNacimiento, item.oPersona.sexo });
            }
        }

        private void dgvListaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    Rol RolEditar = new Rol() {idRol = (int)dgvListaUser.Rows[n].Cells["IdRol"].Value, nombreRol = dgvListaUser.Rows[n].Cells["NombreRol"].Value.ToString() };
                    Persona PersonaEditar = new Persona() { idPersona = Convert.ToInt32(dgvListaUser.Rows[n].Cells["idPersona"].Value), dni = dgvListaUser.Rows[n].Cells["Dni"].Value.ToString(), nombre = dgvListaUser.Rows[n].Cells["Nombre"].Value.ToString(), apellido = dgvListaUser.Rows[n].Cells["Apellido"].Value.ToString(), email = dgvListaUser.Rows[n].Cells["Email"].Value.ToString(), telefono = dgvListaUser.Rows[n].Cells["Telefono"].Value.ToString(), fechaNacimiento = dgvListaUser.Rows[n].Cells["FechaNacimiento"].Value.ToString(), sexo = Convert.ToChar(dgvListaUser.Rows[n].Cells["Sexo"].Value) };
                    Usuario UsuarioEditar = new Usuario() { idUsuario = (int)dgvListaUser.Rows[n].Cells["IdUsuario"].Value, nombreUsuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString(), passwordUsuario = dgvListaUser.Rows[n].Cells["Password"].Value.ToString(), oRol = RolEditar, oPersona = PersonaEditar };
                    frmUsuario CrearNuevoUsuario = new frmUsuario(UsuarioEditar);

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
                _inicio.MostrarImagenFondo(); // Mostrar la imagen de fondo
            }
            this.Close(); // Cierra el formulario actual
        }

        private void pnlBusquedaUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
