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
            Listar_Productos();
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

        private void Listar_Productos()
        {
            List<Producto> ListaProducto = new CN_Producto().ListarProductos();
            foreach (Producto item in ListaProducto)
            {
                dgvListaProducto.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_user: CapaPresentacion.Properties.Resources.activar_user, // Icono de acción
            item.idProducto,
            item.fechaBaja == null ? "Activo" : "Inactivo",
            item.nombre,
            item.precioCompra,
            item.precioVenta,
            item.stock,
            item.stockMinimo,
            item.oMarca.nombre,
            item.oCategoria.nombre_categoria,
            item.oProveedor.razonSocial,
            item.imagen,
           
            
            
                 });
            }

            // Cambia el color del texto según el estado de la Marca (Activo/Inactivo)
            for (int i = 0; i < dgvListaProducto.Rows.Count; i++)
            {
                // Obtener el valor de la celda "Estado" en la fila actual
                string estado = dgvListaProducto.Rows[i].Cells["Estado"].Value.ToString();

                // Cambiar el color tanto para cuando la fila está seleccionada como cuando no lo está
                if (estado == "Activo")
                {
                    // Cambiar el color del texto a negro si es "Activo"
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black; // También cuando está seleccionada
                }
                else if (estado == "Inactivo")
                {
                    // Cambiar el color del texto a rojo si es "Inactivo"
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red; // También cuando está seleccionada
                }
            }
        }
        // Evento que se ejecuta cuando el formulario de 'frmProducto' se está cerrando
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarProducto ListarNuevoProducto = new frmListarProducto(_inicio); // Crea una nueva instancia del formulario 'frmListarProducto'

            ListarNuevoProducto.TopLevel = false; 
            pnlContenedorProducto.Controls.Clear(); 
            pnlContenedorProducto.Controls.Add(ListarNuevoProducto); 
            ListarNuevoProducto.FormBorderStyle = FormBorderStyle.None; 
            ListarNuevoProducto.Dock = DockStyle.Fill; 

            ListarNuevoProducto.Show(); 
        }

        // Evento del botón que limpia el campo de búsqueda de producto
        private void btnLimpiarBuscarProducto_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Clear(); 
        }

        // Evento que controla la entrada de solo dígitos en el campo de búsqueda de productos
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que solo se ingresen dígitos o controles (como borrar), si no, ignora la entrada
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
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
                return true; 
            }
            return false; 
        }

        // Evento del botón que regresa al menú de clientes y reactiva el panel de menú principal
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            // Si hay una referencia válida al formulario 'Inicio'
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; 
                _inicio.MostrarImagenFondo(); 
            }
            this.Close(); 
        }

        // Evento que se ejecuta cuando el formulario se carga, establece el foco en el campo de búsqueda
        private void frmListarProducto_Load_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Focus(); 
        }
    }

}
