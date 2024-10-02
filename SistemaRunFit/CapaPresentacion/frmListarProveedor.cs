using CapaDeEntidades;
using CapaDeNegocios;
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
    public partial class frmListarProveedor : Form
    {
        // Variable para almacenar la referencia del formulario Inicio.
        private Inicio _inicioForm;

        // Constructor que recibe una instancia del formulario Inicio.
        public frmListarProveedor(Inicio inicioForm)
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario.
            _inicioForm = inicioForm; // Guarda la referencia del formulario Inicio.
            _inicioForm.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en el formulario Inicio.
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Focus(); // Establece el foco en el campo de texto txtBuscarPorProveedor al cargar el formulario.
        }

        // Método para limpiar el campo de búsqueda por proveedor.
        private void LimpiarPorProveedor()
        {
            txtBuscarPorProveedor.Clear(); // Limpia el campo de texto de búsqueda por proveedor.
        }

        // Evento que se ejecuta al cerrar el formulario.
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Crea una nueva instancia del formulario para listar proveedores.
            frmListarProveedor ListarNuevoProveedor = new frmListarProveedor(_inicioForm);

            ListarNuevoProveedor.TopLevel = false; // Establece el formulario como un formulario hijo.
            pnlContenedorDatosProveedor.Controls.Clear(); // Limpia el contenedor de datos de proveedor.
            pnlContenedorDatosProveedor.Controls.Add(ListarNuevoProveedor); // Agrega el nuevo formulario al contenedor.
            ListarNuevoProveedor.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario.
            ListarNuevoProveedor.Dock = DockStyle.Fill; // Ajusta el formulario para que ocupe todo el espacio disponible.

            ListarNuevoProveedor.Show(); // Muestra el nuevo formulario.
        }

        // Evento que se ejecuta al hacer clic en el botón btnNuevoProveedor.
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario para crear un nuevo proveedor.
            frmProveedor CrearNuevoProveedor = new frmProveedor();

            CrearNuevoProveedor.TopLevel = false; // Establece el formulario como un formulario hijo.
            pnlContenedorDatosProveedor.Controls.Clear(); // Limpia el contenedor de datos de proveedor.
            pnlContenedorDatosProveedor.Controls.Add(CrearNuevoProveedor); // Agrega el nuevo formulario al contenedor.
            CrearNuevoProveedor.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario.
            CrearNuevoProveedor.Dock = DockStyle.Fill; // Ajusta el formulario para que ocupe todo el espacio disponible.

            CrearNuevoProveedor.Show(); // Muestra el formulario para crear un nuevo proveedor.
            CrearNuevoProveedor.FormClosing += frm_closing; // Asocia el evento de cierre del formulario al método frm_closing.
        }

        // Evento que se ejecuta al hacer clic en el botón btnLimpiarPorProveedor.
        private void btnLimpiarPorProveedor_Click_1(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Clear(); // Limpia el campo de texto de búsqueda por proveedor.
        }

        // Evento que se ejecuta al presionar una tecla en el campo txtBuscarPorProveedor.
        private void txtBuscarPorProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y controles en el campo de texto.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si se ingresa un carácter no válido, se maneja el evento.
            }
        }

        // Evento que se ejecuta al hacer clic en el botón btnBuscarPorProveedor.
        private void btnBuscarPorProveedor_Click(object sender, EventArgs e)
        {
            if (EsCuitMuyCorto()) // Verifica si el CUIT ingresado es muy corto.
            {
                return; // Si es corto, sale del método.
            }
        }

        // Método para verificar si el CUIT ingresado es demasiado corto.
        private bool EsCuitMuyCorto()
        {
            // Verifica la longitud del texto en txtBuscarPorProveedor.
            if (txtBuscarPorProveedor.Text.Length < 10)
            {
                // Muestra un mensaje de advertencia si el CUIT es corto.
                MessageBox.Show("El número del CUIT del Proveedor es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true; // Devuelve true indicando que el CUIT es corto.
            }
            return false; // Devuelve false indicando que el CUIT es de longitud adecuada.
        }

        // Evento que se ejecuta al hacer clic en el botón btnCancelar.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_inicioForm != null) // Verifica si la referencia de _inicioForm no es nula.
            {
                _inicioForm.PnlContenedorMenu.Enabled = true; // Reactiva el panel en el formulario Inicio.
                _inicioForm.MostrarImagenFondo(); // Muestra la imagen de fondo en el formulario Inicio.
            }
            this.Close(); // Cierra el formulario actual.
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmListarProveedor_Load_1(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Focus(); // Establece el foco en el campo de texto txtBuscarPorProveedor al cargar el formulario.
            
            listar_proveedores();
        }
        private void listar_proveedores()
        {
            // Obtiene la lista de usuarios desde la capa de negocio
            List<Proveedor> ListaProveedor = new CN_proveedor().ListarProveedores();

            // Agrega cada usuario a la fila del DataGridView
            foreach (Proveedor item in ListaProveedor)
            {
                dgvListaProveedor.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_user: CapaPresentacion.Properties.Resources.activar_user, // Icono de acción
            item.cuit,
            item.idProveedor,
            item.razonSocial,
            item.fechaBaja == null ? "Activo" : "Inactivo", // Estado del usuario
            item.fechaAlta,
            item.email,
            item.telefono,
            item.direccion,
            item.descripcion,
            });
            }
        }

    }
}
