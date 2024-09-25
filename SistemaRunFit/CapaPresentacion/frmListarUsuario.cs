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
using System.Web.WebSockets;

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
            txtBuscarUser.Focus();
        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            //Pone el foco en el txtbox buscar usuario
            txtBuscarUser.Focus();
            listar_usuario();
        }
        private void listar_usuario()
        {
            List<Usuario> ListaUsuario = new CN_Usuario().ListarUsuarios();

            foreach (Usuario item in ListaUsuario)
            {
                dgvListaUser.Rows.Add(new object[] { CapaPresentacion.Properties.Resources.pencil,
                    item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_user : CapaPresentacion.Properties.Resources.activar_user,
                    item.idUsuario, item.oRol.idRol, item.oRol.nombreRol,
                    item.nombreUsuario, item.passwordUsuario, item.fechaBaja == null ? "Activo" : "Inactivo",
                    item.oPersona.idPersona,
                    item.oPersona.dni,
                    item.oPersona.nombre,
                    item.oPersona.apellido,
                    item.oPersona.email,
                    item.oPersona.telefono,
                    (Convert.ToDateTime(item.oPersona.fechaNacimiento)).ToString("dd-MM-yyyy"),
                    item.oPersona.sexo });

            }
            for (int i = 0; i < dgvListaUser.Rows.Count; i++)
            {
                // Obtener el valor de la celda "Estado" en la fila actual
                string estado = dgvListaUser.Rows[i].Cells["Estado"].Value.ToString();

                // Cambiar el color tanto para cuando la fila está seleccionada como cuando no lo está
                if (estado == "Activo")
                {
                    // Cambiar el color del texto a negro si es "Activo"
                    dgvListaUser.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvListaUser.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black; // También cuando está seleccionada
                }
                else if (estado == "Inactivo")
                {
                    // Cambiar el color del texto a rojo si es "Inactivo"
                    dgvListaUser.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvListaUser.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red; // También cuando está seleccionada
                }
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
                    Usuario UsuarioEditar = new Usuario() { idUsuario = (int)dgvListaUser.Rows[n].Cells["IdUsuario"].Value, nombreUsuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString(),  oRol = RolEditar, oPersona = PersonaEditar };
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
            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Accion")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty;
                    Usuario UsuarioEliminar = new Usuario()
                    {
                        idUsuario = (int)dgvListaUser.Rows[n].Cells["IdUsuario"].Value
                    };

                    string estadoActual = dgvListaUser.Rows[n].Cells["Estado"].Value.ToString();
                    string usuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString();
                    // Respuesta = 1, se activará el usuario
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al usuario {usuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llamamos al procedimiento almacenado y obtenemos la respuesta
                            bool respuesta = new CN_Usuario().Eliminar(UsuarioEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado del usuario
                                dgvListaUser.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaUser.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black;
                                dgvListaUser.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black;

                                MessageBox.Show("Usuario " + usuario + " activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al usuario {usuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)

                        {   // Llamamos al procedimiento almacenado y obtenemos la respuesta
                            bool respuesta = new CN_Usuario().Eliminar(UsuarioEliminar, out mensaje);

                            // Actualizar el estado del usuario
                            dgvListaUser.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaUser.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red;
                            dgvListaUser.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red;

                            MessageBox.Show("Usuario " + usuario + " desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    // Limpiar las filas del DataGridView y volver a cargar los datos
                    dgvListaUser.Rows.Clear();
                    listar_usuario(); // Asegúrate de que esta función recargue correctamente los datos del DataGridView
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
