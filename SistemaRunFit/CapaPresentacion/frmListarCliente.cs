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
        // Campo privado que almacena la referencia al formulario principal 'Inicio'
        Inicio _inicio;

        // Campo estático que almacena el usuario actual
        private static Usuario usuarioActual = null;

        // Constructor del formulario que recibe como parámetros el formulario de inicio y el usuario actual
        public frmListarCliente(Inicio frminicio, Usuario usuario)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio = frminicio; // Asigna el formulario de inicio
            usuarioActual = usuario; // Asigna el usuario actual pasado como argumento
            frminicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en el formulario de inicio
            ConfigurarVisibilidadColumnas(usuario); // Configura la visibilidad de las columnas del DataGridView basado en el rol del usuario
        }

        // Método que configura la visibilidad de las columnas del DataGridView según el rol del usuario
        private void ConfigurarVisibilidadColumnas(Usuario usuario)
        {
            // Si el usuario y su rol no son nulos, ajusta la visibilidad de la columna "Accion"
            if (usuario != null && usuario.oRol != null)
            {
                // Si el idRol del usuario es 3, oculta la columna "Accion", en caso contrario, la muestra
                dgvListaClientes.Columns["Accion"].Visible = usuario.oRol.idRol != 3;
            }
        }

        // Evento del botón para agregar un nuevo cliente
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente CrearNuevoCliente = new frmCliente(); // Crea una nueva instancia del formulario de cliente

            CrearNuevoCliente.TopLevel = false; // El formulario será contenido dentro del panel, no en el nivel superior
            pnlContenedorCliente.Controls.Clear(); // Limpia el panel contenedor
            pnlContenedorCliente.Controls.Add(CrearNuevoCliente); // Agrega el nuevo formulario al panel contenedor
            CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
            CrearNuevoCliente.Dock = DockStyle.Fill; // Establece que el formulario ocupe todo el espacio del panel contenedor

            CrearNuevoCliente.Show(); // Muestra el formulario
            CrearNuevoCliente.FormClosing += frm_closing; // Asocia el evento de cierre del formulario al método 'frm_closing'
        }

        // Evento que se ejecuta cuando el formulario de cliente se cierra
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Crea una nueva instancia del formulario de listar clientes con el formulario de inicio y el usuario actual
            frmListarCliente ListarNuevoCliente = new frmListarCliente(_inicio, usuarioActual);

            ListarNuevoCliente.TopLevel = false; // El formulario será contenido dentro del panel, no en el nivel superior
            pnlContenedorCliente.Controls.Clear(); // Limpia el panel contenedor
            pnlContenedorCliente.Controls.Add(ListarNuevoCliente); // Agrega el nuevo formulario al panel contenedor
            ListarNuevoCliente.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
            ListarNuevoCliente.Dock = DockStyle.Fill; // Establece que el formulario ocupe todo el espacio del panel contenedor

            ListarNuevoCliente.Show(); // Muestra el formulario
        }

        // Evento que controla la entrada de texto en el campo de búsqueda
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como borrar), evitando la entrada de otros caracteres
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si el carácter no es un dígito ni una tecla de control, se cancela el evento
            }

            // Si hay filas en el DataGridView
            if (dgvListaClientes.Rows.Count > 0)
            {
                // Recorre cada fila del DataGridView
                foreach (DataGridViewRow row in dgvListaClientes.Rows)
                {
                    // Verifica si el campo 'Dni' de la fila contiene el texto buscado
                    if (row.Cells["Dni"].Value.ToString().Trim().Contains(txtBuscarCliente.Text.Trim()))
                        row.Visible = true; // Si coincide, la fila se muestra
                    else
                        row.Visible = false; // Si no coincide, la fila se oculta
                }
            }
        }
        // Evento que se ejecuta al hacer clic en el botón "LimpiarCliente"
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            // Limpia el campo de búsqueda de clientes
            txtBuscarCliente.Clear();

            // Recorre todas las filas del DataGridView y las vuelve visibles
            foreach (DataGridViewRow row in dgvListaClientes.Rows)
            {
                row.Visible = true; // Muestra todas las filas del DataGridView
            }

            // Establece el foco en el campo de búsqueda
            txtBuscarCliente.Focus();
        }

        // Evento que se ejecuta cuando se carga el formulario 'frmListarCliente'
        private void frmListarCliente_Load(object sender, EventArgs e)
        {
            // Pone el foco en el campo de búsqueda al cargar el formulario
            txtBuscarCliente.Focus();

            // Llama al método 'ListarDomicilios' para obtener una lista de domicilios
            List<Domicilio> ListaDomicilio = new CN_Domicilio().ListarDomicilios();

            // Recorre cada elemento de la lista de domicilios
            foreach (Domicilio item in ListaDomicilio)
            {
                // Agrega una nueva fila al DataGridView con la información del domicilio y de la persona
                dgvListaClientes.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            CapaPresentacion.Properties.Resources.Eliminar, // Icono de eliminar
            item.oPersona.idPersona, // ID de la persona
            item.oPersona.dni, // DNI de la persona
            item.oPersona.nombre, // Nombre de la persona
            item.oPersona.apellido, // Apellido de la persona
            item.oPersona.email, // Email de la persona
            item.oPersona.telefono, // Teléfono de la persona
            (Convert.ToDateTime(item.oPersona.fechaNacimiento)).ToString("dd-MM-yyyy"), // Fecha de nacimiento formateada
            item.oPersona.sexo, // Sexo de la persona
            item.idDomicilio, // ID del domicilio
            item.calle, // Calle del domicilio
            item.altura, // Altura del domicilio
            item.casa, // Casa del domicilio (si aplica)
            item.manzana, // Manzana del domicilio (si aplica)
            item.departamento, // Departamento del domicilio (si aplica)
            item.piso // Piso del domicilio (si aplica)
        });
            }
        }

        // Evento que se dispara cuando se hace clic en una celda del DataGridView 'dgvListaClientes'
        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si se hace clic en la columna "Editar"
            if (dgvListaClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila clicada
                if (n >= 0)
                {
                    // Crea una nueva instancia del objeto 'Domicilio' con los datos de la fila seleccionada
                    Domicilio DomicilioEditar = new Domicilio()
                    {
                        idDomicilio = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idDomicilio"].Value), // ID del domicilio
                        calle = dgvListaClientes.Rows[n].Cells["Calle"].Value.ToString(), // Calle
                        altura = dgvListaClientes.Rows[n].Cells["Altura"].Value.ToString(), // Altura
                        casa = dgvListaClientes.Rows[n].Cells["Casa"].Value.ToString(), // Casa (si aplica)
                        manzana = dgvListaClientes.Rows[n].Cells["Manzana"].Value.ToString(), // Manzana (si aplica)
                        departamento = dgvListaClientes.Rows[n].Cells["Departamento"].Value.ToString(), // Departamento (si aplica)
                        piso = dgvListaClientes.Rows[n].Cells["Piso"].Value.ToString(), // Piso (si aplica)
                        oPersona = new Persona()
                        {
                            idPersona = Convert.ToInt32(dgvListaClientes.Rows[n].Cells["idPersona"].Value), // ID de la persona
                            dni = dgvListaClientes.Rows[n].Cells["Dni"].Value.ToString(), // DNI
                            nombre = dgvListaClientes.Rows[n].Cells["Nombre"].Value.ToString(), // Nombre
                            apellido = dgvListaClientes.Rows[n].Cells["Apellido"].Value.ToString(), // Apellido
                            email = dgvListaClientes.Rows[n].Cells["Email"].Value.ToString(), // Email
                            telefono = dgvListaClientes.Rows[n].Cells["Telefono"].Value.ToString(), // Teléfono
                            fechaNacimiento = dgvListaClientes.Rows[n].Cells["FechaNacimiento"].Value.ToString(), // Fecha de nacimiento
                            sexo = Convert.ToChar(dgvListaClientes.Rows[n].Cells["Sexo"].Value) // Sexo
                        }
                    };

                    // Crea una nueva instancia del formulario 'frmCliente' para editar el domicilio
                    frmCliente CrearNuevoCliente = new frmCliente(DomicilioEditar);

                    CrearNuevoCliente.TopLevel = false; // Indica que no es un formulario principal
                    pnlContenedorCliente.Controls.Clear(); // Limpia el panel contenedor
                    pnlContenedorCliente.Controls.Add(CrearNuevoCliente); // Agrega el formulario al panel
                    CrearNuevoCliente.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
                    CrearNuevoCliente.Dock = DockStyle.Fill; // Hace que el formulario se ajuste al tamaño del panel

                    CrearNuevoCliente.Show(); // Muestra el formulario
                    CrearNuevoCliente.FormClosing += frm_closing; // Asocia el evento de cierre del formulario con 'frm_closing'
                }
            }
        }

        // Evento que se dispara al hacer clic en el botón "MenuClientes"
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel en el formulario de inicio
                _inicio.MostrarImagenFondo(); // Muestra la imagen de fondo en el formulario de inicio
            }
            this.Close(); // Cierra el formulario actual
        }

    }
}
