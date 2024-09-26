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
    public partial class frmListarProducto : Form
    {
        // Campo privado que almacena la referencia al formulario principal 'Inicio'
        Inicio _inicio;

        // Constructor que inicializa el formulario y desactiva el panel del menú en 'Inicio'
        public frmListarProducto(Inicio inicio)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio = inicio; // Almacena la referencia al formulario 'Inicio'
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en el formulario principal
        }

        // Evento del botón para crear un nuevo producto
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto CrearNuevoProducto = new frmProducto(); // Crea una nueva instancia del formulario 'frmProducto'

            CrearNuevoProducto.TopLevel = false; // El formulario no será de nivel superior
            pnlContenedorProducto.Controls.Clear(); // Limpia el contenedor de productos
            pnlContenedorProducto.Controls.Add(CrearNuevoProducto); // Añade el formulario al panel contenedor
            CrearNuevoProducto.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
            CrearNuevoProducto.Dock = DockStyle.Fill; // Hace que el formulario ocupe todo el panel

            CrearNuevoProducto.Show(); // Muestra el formulario
            CrearNuevoProducto.FormClosing += frm_closing; // Asigna el evento 'FormClosing' para ejecutar código al cerrar el formulario
        }

        // Evento que se ejecuta cuando el formulario de 'frmProducto' se está cerrando
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarProducto ListarNuevoProducto = new frmListarProducto(_inicio); // Crea una nueva instancia del formulario 'frmListarProducto'

            ListarNuevoProducto.TopLevel = false; // El formulario no será de nivel superior
            pnlContenedorProducto.Controls.Clear(); // Limpia el contenedor de productos
            pnlContenedorProducto.Controls.Add(ListarNuevoProducto); // Añade el formulario al panel contenedor
            ListarNuevoProducto.FormBorderStyle = FormBorderStyle.None; // Elimina los bordes del formulario
            ListarNuevoProducto.Dock = DockStyle.Fill; // Hace que el formulario ocupe todo el panel

            ListarNuevoProducto.Show(); // Muestra el formulario de nuevo
        }

        // Evento del botón que limpia el campo de búsqueda de producto
        private void btnLimpiarBuscarProducto_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Clear(); // Limpia el texto en el campo de búsqueda
        }

        // Evento que controla la entrada de solo dígitos en el campo de búsqueda de productos
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresen dígitos o controles (como borrar), si no, ignora la entrada
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no permitidos
            }
        }

        // Evento del botón para buscar un producto
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Si el código es muy corto, no hace la búsqueda y retorna
            if (EsCodigoMuyCorto())
            {
                return;
            }
        }

        // Método que valida si el código del producto ingresado es demasiado corto
        private bool EsCodigoMuyCorto()
        {
            // Si la longitud del texto es menor a 4, muestra un mensaje de advertencia
            if (txtBuscarProducto.Text.Length < 4)
            {
                MessageBox.Show("El CODIGO del Producto es muy corto, vuelva intentar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true; // Retorna verdadero si el código es muy corto
            }
            return false; // Retorna falso si el código tiene la longitud adecuada
        }

        // Evento del botón que regresa al menú de clientes y reactiva el panel de menú principal
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            // Si hay una referencia válida al formulario 'Inicio'
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel del menú en 'Inicio'
                _inicio.MostrarImagenFondo(); // Muestra nuevamente la imagen de fondo en 'Inicio'
            }
            this.Close(); // Cierra el formulario actual de listar productos
        }

        // Evento que se ejecuta cuando el formulario se carga, establece el foco en el campo de búsqueda
        private void frmListarProducto_Load_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Focus(); // Establece el foco en el campo de texto de búsqueda de productos
        }
    }

}
