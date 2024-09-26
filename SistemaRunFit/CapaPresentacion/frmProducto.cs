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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.Load += new EventHandler(frmProducto_Load); // Asocia el evento Load del formulario a su manejador
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmProducto_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Focus(); // Pone el foco en el TextBox de nombre del producto
        }

        // Evento que se ejecuta al hacer clic en el botón "Volver"
        private void btnVolverUser_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        // Evento que se ejecuta al hacer clic en el botón "Limpiar"
        private void btnLimpiarContenedorProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Llama al método para limpiar los campos del formulario
        }

        // Método que limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            cmbMarcaProducto.SelectedIndex = -1;
            cmbCategoriaProducto.SelectedIndex = -1;
            cmbProveedorProducto.SelectedIndex = -1;
            txtDetalleProducto.Clear();
            txtPrecioCompraProducto.Clear();
            txtPrecioVentaProducto.Clear();
            txtStockProducto.Clear();
            txtStockMinimoProducto.Clear();
            pbImagenProducto.Image = CapaPresentacion.Properties.Resources.fotoProducto;
            txtNombreProducto.Focus();
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de precio de compra
        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito, un control o una coma (y que no haya otra coma ya)
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioCompraProducto.Text.Contains(",")))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de precio de venta
        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito, un control o una coma (y que no haya otra coma ya)
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioVentaProducto.Text.Contains(",")))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de stock mínimo
        private void txtStockMinimoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de stock
        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para seleccionar una imagen del producto
        private void btnSeleccionarImagenProducto_Click(object sender, EventArgs e)
        {
            // Crear y configurar el OpenFileDialog para seleccionar una imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filtros para formatos de imagen
            openFileDialog.Title = "Seleccionar una imagen"; // Título del diálogo

            // Mostrar el diálogo y comprobar si se seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                string rutaImagen = openFileDialog.FileName; // Obtener la ruta del archivo
                pbImagenProducto.Image = Image.FromFile(rutaImagen); // Cargar la imagen en el PictureBox
            }
        }

    }
}
