using CapaDeEntidades;
using CapaDeNegocios;
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
        Inicio _inicio;
        private static Usuario usuarioActual = null;

        // Constructor del formulario
        public frmListarCliente(Inicio frminicio, Usuario usuario)
        {
            InitializeComponent();
            _inicio = frminicio;
            usuarioActual = usuario;
            frminicio.PnlContenedorMenu.Enabled = false;
            ConfigurarVisibilidadColumnas(usuario);
        }

        // Configura la visibilidad de las columnas según el rol del usuario
        private void ConfigurarVisibilidadColumnas(Usuario usuario)
        {
            if (usuario != null && usuario.oRol != null)
            {
                dgvListaClientes.Columns["Accion"].Visible = usuario.oRol.idRol != 3;
            }
        }

        // Evento para agregar un nuevo cliente
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



        // Evento que se ejecuta cuando el formulario de cliente se cierra
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarCliente ListarNuevoCliente = new frmListarCliente(_inicio, usuarioActual);
            ListarNuevoCliente.TopLevel = false;
            pnlContenedorCliente.Controls.Clear();
            pnlContenedorCliente.Controls.Add(ListarNuevoCliente);
            ListarNuevoCliente.FormBorderStyle = FormBorderStyle.None;
            ListarNuevoCliente.Dock = DockStyle.Fill;
            ListarNuevoCliente.Show();
        }

        // Evento que controla la entrada de texto en el campo de búsqueda
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (dgvListaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaClientes.Rows)
                {
                    if (row.Cells["Dni"].Value.ToString().Trim().Contains(txtBuscarCliente.Text.Trim()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "LimpiarCliente"
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();

            foreach (DataGridViewRow row in dgvListaClientes.Rows)
            {
                row.Visible = true;
            }

            txtBuscarCliente.Focus();
        }

        // Evento que se ejecuta cuando se carga el formulario 'frmListarCliente'
        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            txtBuscarCliente.Focus();
            Listar_Clientes();
        }

        private void Listar_Clientes()
        {
            List<Domicilio> ListaDomicilio = new CN_Domicilio().ListarDomicilios();
            foreach (Domicilio item in ListaDomicilio)
            {
                dgvListaClientes.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil,
            item.oPersona.estado == '0' ? CapaPresentacion.Properties.Resources.activar_user: CapaPresentacion.Properties.Resources.eliminar_user,
            item.oPersona.estado=='0' ? "Inactivo" : "Activo",
            item.oPersona.idPersona,
            item.oPersona.dni,
            item.oPersona.nombre,
            item.oPersona.apellido,
            item.oPersona.email,
            item.oPersona.telefono,
            (Convert.ToDateTime(item.oPersona.fechaNacimiento)).ToString("dd-MM-yyyy"),
            item.oPersona.sexo,
            item.idDomicilio,
            item.calle,
            item.altura,
            item.casa,
            item.manzana,
            item.departamento,
            item.piso
        });
            }
            for (int i = 0; i < dgvListaClientes.Rows.Count; i++)
            {
                string estado = dgvListaClientes.Rows[i].Cells["Estado"].Value.ToString();

                if (estado == "Activo")
                {
                    dgvListaClientes.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvListaClientes.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                }
                else if (estado == "Inactivo")
                {
                    dgvListaClientes.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvListaClientes.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                }
            }
        }

        // Evento que se dispara cuando se hace clic en una celda del DataGridView 'dgvListaClientes'
        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    // Crea una nueva instancia del objeto 'Domicilio' con los datos de la fila seleccionada
                    Domicilio DomicilioEditar = new Domicilio()
                    {
                        idDomicilio = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idDomicilio"].Value),
                        calle = dgvListaClientes.Rows[n].Cells["Calle"].Value.ToString(),
                        altura = dgvListaClientes.Rows[n].Cells["Altura"].Value.ToString(),
                        casa = dgvListaClientes.Rows[n].Cells["Casa"].Value.ToString(),
                        manzana = dgvListaClientes.Rows[n].Cells["Manzana"].Value.ToString(),
                        departamento = dgvListaClientes.Rows[n].Cells["Departamento"].Value.ToString(),
                        piso = dgvListaClientes.Rows[n].Cells["Piso"].Value.ToString(),
                        oPersona = new Persona()
                        {
                            idPersona = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idPersona"].Value),
                            dni = dgvListaClientes.Rows[n].Cells["Dni"].Value.ToString(),
                            nombre = dgvListaClientes.Rows[n].Cells["Nombre"].Value.ToString(),
                            apellido = dgvListaClientes.Rows[n].Cells["Apellido"].Value.ToString(),
                            email = dgvListaClientes.Rows[n].Cells["Email"].Value.ToString(),
                            telefono = dgvListaClientes.Rows[n].Cells["Telefono"].Value.ToString(),
                            fechaNacimiento = dgvListaClientes.Rows[n].Cells["FechaNacimiento"].Value.ToString(),
                            sexo = Convert.ToChar(dgvListaClientes.Rows[n].Cells["Sexo"].Value),
                        }
                    };

                    // Crea una nueva instancia del formulario 'frmCliente' para editar el domicilio
                    frmCliente CrearNuevoCliente = new frmCliente(DomicilioEditar);
                    CrearNuevoCliente.TopLevel = false;
                    pnlContenedorCliente.Controls.Clear();
                    pnlContenedorCliente.Controls.Add(CrearNuevoCliente);
                    CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None;
                    CrearNuevoCliente.Dock = DockStyle.Fill;

                    CrearNuevoCliente.Show();
                    CrearNuevoCliente.FormClosing += frm_closing;
                }
            }

            // Verifica si la columna seleccionada es la de "Accion"
            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Accion")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty;

                    // Crea un objeto Persona para la acción de eliminar o activar
                    Persona PersonEliminar = new Persona()
                    {
                        idPersona = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idPersona"].Value)
                    };

                    string estadoActual = dgvListaClientes.Rows[n].Cells["Estado"].Value.ToString();
                    string Nombre = dgvListaClientes.Rows[n].Cells["Nombre"].Value.ToString();
                    string Apellido = dgvListaClientes.Rows[n].Cells["Apellido"].Value.ToString();

                    // Si el Cliente está inactivo, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al cliente {Apellido} {Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Persona().Eliminar(PersonEliminar, out mensaje);

                            if (respuesta)
                            {
                                dgvListaClientes.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaClientes.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black;
                                dgvListaClientes.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black;

                                MessageBox.Show($" {Apellido} {Nombre} activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si el Cliente está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al cliente {Apellido} {Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Persona().Eliminar(PersonEliminar, out mensaje);

                            dgvListaClientes.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaClientes.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red;
                            dgvListaClientes.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red;

                            MessageBox.Show($" {Apellido} {Nombre} desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvListaClientes.Rows.Clear();
                    Listar_Clientes();
                }
            }
        }


        // Evento que se dispara al hacer clic en el botón "MenuClientes"
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                
                _inicio.PnlContenedorMenu.Enabled = true;
                
                _inicio.MostrarImagenFondo();
            }
            
            this.Close();
        }


    }
}
