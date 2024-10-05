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
    public partial class frmProducto : Form
    {
        private CN_Marca objCN_Marca;
        private CN_Categoria objCN_Categoria;
        private CN_proveedor objCN_proveedor;
        public frmProducto()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.Load += new EventHandler(frmProducto_Load); // Asocia el evento Load del formulario a su manejador
            
        }
        private void CargarProveedores()
        {
            List<Proveedor> listaProveedor = objCN_proveedor.ListarProveedores();
            cmbProveedorProducto.Items.Clear();
            cmbProveedorProducto.Items.Add(new Proveedor { idProveedor = 0, razonSocial = "Seleccione un proveedor" });
            cmbProveedorProducto.DataSource = listaProveedor;
            cmbProveedorProducto.DisplayMember = "razonSocial";
            cmbProveedorProducto.ValueMember = "idProveedor";
            cmbProveedorProducto.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            List<Categoria> listaCategorias = objCN_Categoria.ListarCategorias();
            cmbCategoriaProducto.Items.Clear();
            cmbCategoriaProducto.DataSource = listaCategorias;
            cmbCategoriaProducto.DisplayMember = "nombre_categoria";
            cmbCategoriaProducto.ValueMember = "idCategoria";
            cmbCategoriaProducto.SelectedIndex = -1;
        }

        private void CargarMarcas()
        {
            List<Marca> listaMarcas = objCN_Marca.ListarMarcas();
            cmbMarcaProducto.Items.Clear();
            cmbMarcaProducto.DataSource = listaMarcas;
            cmbMarcaProducto.DisplayMember = "nombre";
            cmbMarcaProducto.ValueMember = "idMarca";
            cmbMarcaProducto.SelectedIndex = -1;
        }




        // Evento que se ejecuta al cargar el formulario
        private void frmProducto_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Focus();
            objCN_Marca = new CN_Marca();
            objCN_Categoria = new CN_Categoria();
            objCN_proveedor = new CN_proveedor();
            CargarProveedores();
            CargarCategorias();
            CargarMarcas();
        }

        // Evento que se ejecuta al hacer clic en el botón "Volver"
        private void btnVolverUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento que se ejecuta al hacer clic en el botón "Limpiar"
        private void btnLimpiarContenedorProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
                e.Handled = true;
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de precio de venta
        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito, un control o una coma (y que no haya otra coma ya)
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioVentaProducto.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de stock mínimo
        private void txtStockMinimoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox de stock
        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para seleccionar una imagen del producto
        private void btnSeleccionarImagenProducto_Click(object sender, EventArgs e)
        {
            // Crear y configurar el OpenFileDialog para seleccionar una imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el diálogo y comprobar si se seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                string rutaImagen = openFileDialog.FileName; // Obtener la ruta del archivo
                pbImagenProducto.Image = Image.FromFile(rutaImagen); // Cargar la imagen en el PictureBox
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string mensajeProducto = string.Empty; // Mensaje para el resultado del proceso de usuario
            int idProductoGenerado = 0; // ID de producto generado
            string mensajeConfirmacion = "¿Desea agregar el producto"; // Mensaje de confirmación inicial

            // Verifica si los campos están validados
            if (camposValidados())
            {
                try
                {
                    // Obtiene los datos del formulario
                    string nombreProducto = txtNombreProducto.Text;
                    decimal precioCompra = Convert.ToDecimal(txtPrecioCompraProducto.Text);
                    decimal precioVenta = Convert.ToDecimal(txtPrecioVentaProducto.Text);
                    int stock = Convert.ToInt32(txtStockProducto.Text);
                    int stockMinimo = Convert.ToInt32(txtStockMinimoProducto.Text);
                    string detalleProducto = txtDetalleProducto.Text;
                    int idMarcaSeleccionada = (int)cmbMarcaProducto.SelectedValue;
                    int idProveedorSeleccionado = (int)cmbProveedorProducto.SelectedValue;
                    int idCategoriaSeleccionada = (int)cmbCategoriaProducto.SelectedValue;



                    // Modifica el mensaje de confirmación si se está editando un producto existente
                    if (!string.IsNullOrEmpty(txtIdProducto.Text))
                        mensajeConfirmacion = "¿Confirma los cambios de";

                    // Muestra un cuadro de diálogo de confirmación
                    var confirmacion = MessageBox.Show(
                        $"{mensajeConfirmacion} {nombreProducto} al sistema?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Crea un nuevo objeto Producto con los datos del formulario
                        Producto productoNuevo = new Producto()
                        {
                            idProducto = string.IsNullOrEmpty(txtIdProducto.Text) ? 0 : Convert.ToInt32(txtIdProducto.Text),
                            nombre = nombreProducto,
                            precioCompra = precioCompra,
                            precioVenta = precioVenta,
                            stock = stock,
                            stockMinimo = stockMinimo,
                            detalle = detalleProducto,
                            oMarca = new Marca() { idMarca= idMarcaSeleccionada },
                            oCategoria = new Categoria() {  idCategoria = idCategoriaSeleccionada },
                            oProveedor = new Proveedor() {  idProveedor = idProveedorSeleccionado }
                        };

                        // Registrar el nuevo producto
                        idProductoGenerado = new CN_Producto().Registrar(productoNuevo, out mensajeProducto);

                        if (idProductoGenerado > 0)
                        {
                            MessageBox.Show("Producto registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(mensajeProducto, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos numéricos estén correctamente formateados.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool camposValidados()//Metodo para validar los campos
        {
           
            bool productoVacio = string.IsNullOrEmpty(txtIdProducto.Text);
            
            bool precioCompraVacio = string.IsNullOrEmpty(txtPrecioCompraProducto.Text);
          
            bool precioVentaVacio = string.IsNullOrEmpty(txtPrecioVentaProducto.Text);
           
            bool stockVacio = string.IsNullOrEmpty(txtStockProducto.Text);
           
            bool stockMinimoVacio = string.IsNullOrEmpty(txtStockMinimoProducto.Text);
            
            bool marcaVacio = string.IsNullOrEmpty(cmbMarcaProducto.Text);
            
            bool categoriaVacio = string.IsNullOrEmpty(cmbCategoriaProducto.Text);
           
            bool proveedorVacio = string.IsNullOrEmpty(cmbProveedorProducto.Text);
            
            bool detalle_productoVacio = string.IsNullOrEmpty(txtDetalleProducto.Text);

           
            // Verifica si alguno de los campos obligatorios está vacío, incluyendo el sexo
            if ( precioCompraVacio || precioVentaVacio || stockVacio || stockMinimoVacio || marcaVacio || categoriaVacio ||proveedorVacio||detalle_productoVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return true; // Todos los campos son válidos
        }
    }
}
