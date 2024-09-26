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
        // Referencia al formulario de inicio
        Inicio _inicio;

        // Constructor del formulario que recibe una instancia de Inicio
        public frmListarUsuario(Inicio inicio)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio = inicio; // Asigna el formulario de inicio a la variable _inicio
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel de menú en el formulario de inicio
        }

        // Evento que se ejecuta al cerrar el formulario
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Crea una nueva instancia del formulario para listar usuarios
            frmListarUsuario ListarNuevoUsario = new frmListarUsuario(_inicio);

            ListarNuevoUsario.TopLevel = false; // Establece el formulario como hijo
            pnlContenedorUser.Controls.Clear(); // Limpia los controles del panel contenedor
            pnlContenedorUser.Controls.Add(ListarNuevoUsario); // Agrega el nuevo formulario al panel
            ListarNuevoUsario.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
            ListarNuevoUsario.Dock = DockStyle.Fill; // Ajusta el tamaño del formulario al panel

            ListarNuevoUsario.Show(); // Muestra el nuevo formulario
        }

        // Evento que se ejecuta al hacer clic en el botón para crear un nuevo usuario
        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario para crear un nuevo usuario
            frmUsuario CrearNuevoUsuario = new frmUsuario();

            CrearNuevoUsuario.TopLevel = false; // Establece el formulario como hijo
            pnlContenedorUser.Controls.Clear(); // Limpia los controles del panel contenedor
            pnlContenedorUser.Controls.Add(CrearNuevoUsuario); // Agrega el nuevo formulario al panel
            CrearNuevoUsuario.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
            CrearNuevoUsuario.Dock = DockStyle.Fill; // Ajusta el tamaño del formulario al panel

            CrearNuevoUsuario.Show(); // Muestra el nuevo formulario
            CrearNuevoUsuario.FormClosing += frm_closing; // Suscribe al evento de cierre del formulario
        }

        // Evento que se ejecuta al presionar una tecla en el campo de búsqueda
        private void txtBuscarUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se permitan letras, control y espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada si no es válida
            }

            // Filtra las filas de la lista de usuarios según el texto ingresado
            if (dgvListaUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaUser.Rows)
                {
                    // Verifica si el nombre de usuario contiene el texto de búsqueda
                    if (row.Cells["Usuario"].Value.ToString().Trim().ToUpper().Contains(txtBuscarUser.Text.Trim().ToUpper()))
                        row.Visible = true; // Muestra la fila si coincide
                    else
                        row.Visible = false; // Oculta la fila si no coincide
                }
            }
        }


        // Evento que se ejecuta al hacer clic en el botón "Limpiar"
        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            // Limpia el contenido del TextBox de búsqueda
            txtBuscarUser.Clear();

            // Muestra todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvListaUser.Rows)
            {
                row.Visible = true; // Asegura que todas las filas sean visibles
            }

            // Pone el foco nuevamente en el TextBox de búsqueda
            txtBuscarUser.Focus();
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            // Pone el foco en el TextBox para buscar usuarios
            txtBuscarUser.Focus();

            // Llama a la función para listar los usuarios
            listar_usuario();
        }

        // Método que lista los usuarios en el DataGridView
        private void listar_usuario()
        {
            // Obtiene la lista de usuarios desde la capa de negocio
            List<Usuario> ListaUsuario = new CN_Usuario().ListarUsuarios();

            // Agrega cada usuario a la fila del DataGridView
            foreach (Usuario item in ListaUsuario)
            {
                dgvListaUser.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_user: CapaPresentacion.Properties.Resources.activar_user, // Icono de acción
            item.idUsuario,
            item.oRol.idRol,
            item.oRol.nombreRol,
            item.nombreUsuario,
            item.passwordUsuario,
            item.fechaBaja == null ? "Activo" : "Inactivo", // Estado del usuario
            item.oPersona.idPersona,
            item.oPersona.dni,
            item.oPersona.nombre,
            item.oPersona.apellido,
            item.oPersona.email,
            item.oPersona.telefono,
            (Convert.ToDateTime(item.oPersona.fechaNacimiento)).ToString("dd-MM-yyyy"), // Formato de fecha de nacimiento
            item.oPersona.sexo
                 });
            }

            // Cambia el color del texto según el estado del usuario (Activo/Inactivo)
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

        // Evento que se ejecuta al hacer clic en una celda del DataGridView
        private void dgvListaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna seleccionada es la de "Editar"
            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    // Crea un objeto Rol con los datos del rol del usuario a editar
                    Rol RolEditar = new Rol()
                    {
                        idRol = (int)dgvListaUser.Rows[n].Cells["IdRol"].Value,
                        nombreRol = dgvListaUser.Rows[n].Cells["NombreRol"].Value.ToString()
                    };

                    // Crea un objeto Persona con los datos de la persona del usuario a editar
                    Persona PersonaEditar = new Persona()
                    {
                        idPersona = Convert.ToInt32(dgvListaUser.Rows[n].Cells["idPersona"].Value),
                        dni = dgvListaUser.Rows[n].Cells["Dni"].Value.ToString(),
                        nombre = dgvListaUser.Rows[n].Cells["Nombre"].Value.ToString(),
                        apellido = dgvListaUser.Rows[n].Cells["Apellido"].Value.ToString(),
                        email = dgvListaUser.Rows[n].Cells["Email"].Value.ToString(),
                        telefono = dgvListaUser.Rows[n].Cells["Telefono"].Value.ToString(),
                        fechaNacimiento = dgvListaUser.Rows[n].Cells["FechaNacimiento"].Value.ToString(),
                        sexo = Convert.ToChar(dgvListaUser.Rows[n].Cells["Sexo"].Value)
                    };

                    // Crea un objeto Usuario con los datos del usuario a editar
                    Usuario UsuarioEditar = new Usuario()
                    {
                        idUsuario = (int)dgvListaUser.Rows[n].Cells["IdUsuario"].Value,
                        nombreUsuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString(),
                        oRol = RolEditar,
                        oPersona = PersonaEditar
                    };

                    // Abre el formulario para editar el usuario
                    frmUsuario CrearNuevoUsuario = new frmUsuario(UsuarioEditar);

                    CrearNuevoUsuario.TopLevel = false; // Establece el formulario como hijo
                    pnlContenedorUser.Controls.Clear(); // Limpia los controles del panel contenedor
                    pnlContenedorUser.Controls.Add(CrearNuevoUsuario); // Agrega el nuevo formulario al panel
                    CrearNuevoUsuario.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
                    CrearNuevoUsuario.Dock = DockStyle.Fill; // Ajusta el tamaño del formulario al panel

                    CrearNuevoUsuario.Show(); // Muestra el nuevo formulario
                    CrearNuevoUsuario.FormClosing += frm_closing; // Suscribe al evento de cierre del formulario
                }
            }

            // Verifica si la columna seleccionada es la de "Accion"
            if (dgvListaUser.Columns[e.ColumnIndex].Name == "Accion")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    string mensaje = string.Empty; // Mensaje para la acción
                    Usuario UsuarioEliminar = new Usuario() // Crea un objeto Usuario para la acción
                    {
                        idUsuario = (int)dgvListaUser.Rows[n].Cells["IdUsuario"].Value // Asigna el ID del usuario
                    };

                    string estadoActual = dgvListaUser.Rows[n].Cells["Estado"].Value.ToString(); // Obtiene el estado actual del usuario
                    string usuario = dgvListaUser.Rows[n].Cells["Usuario"].Value.ToString(); // Obtiene el nombre del usuario

                    // Si el usuario está inactivo, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al usuario {usuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para activar el usuario
                            bool respuesta = new CN_Usuario().Eliminar(UsuarioEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado del usuario
                                dgvListaUser.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaUser.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black; // Cambia el color a negro
                                dgvListaUser.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black; // Cambia el color de selección a negro

                                MessageBox.Show("Usuario " + usuario + " activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si el usuario está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al usuario {usuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para desactivar el usuario
                            bool respuesta = new CN_Usuario().Eliminar(UsuarioEliminar, out mensaje);

                            // Actualizar el estado del usuario
                            dgvListaUser.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaUser.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red; // Cambia el color a rojo
                            dgvListaUser.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red; // Cambia el color de selección a rojo

                            MessageBox.Show("Usuario " + usuario + " desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvListaUser.Rows.Clear(); // Limpia el DataGridView
                    listar_usuario(); // Llama a la función para volver a cargar los datos
                }
            }
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            // Verifica si la variable _inicio no es nula
            if (_inicio != null)
            {
                // Reactiva el panel en el formulario de inicio
                _inicio.PnlContenedorMenu.Enabled = true;
                // Muestra la imagen de fondo en el formulario de inicio
                _inicio.MostrarImagenFondo();
            }
            // Cierra el formulario actual
            this.Close();
        }

        

    }
}
