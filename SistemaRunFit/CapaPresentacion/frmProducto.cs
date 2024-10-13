using CapaDeEntidades;
using CapaDeNegocios;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{

    public partial class frmProducto : Form
    {
        private static Producto ProductoDGV = null;

        private CN_Marca objCN_Marca;
        private CN_Categoria objCN_Categoria;
        private CN_proveedor objCN_proveedor;
        private CN_Producto objCN_Producto;
        public frmProducto()
        {
            InitializeComponent();
            //this.Load += new EventHandler(frmProducto_Load_1);

        }
        public frmProducto(Producto ProductoEditar)
        {
            ProductoDGV = ProductoEditar; // Asigna el producto a editar
            InitializeComponent();
           
        }
        private void CargarProveedores()
        {
            // Obtener todos los proveedores
            List<Proveedor> listaProveedor = objCN_proveedor.ListarProveedores();

            // Filtrar los proveedores donde fecha_baja sea null
            List<Proveedor> proveedoresActivos = listaProveedor
                .Where(c => c.fechaBaja == null)
                .ToList();

            // Limpiar el combo box y asignar la lista filtrada
            cmbProveedorProducto.Items.Clear();
            cmbProveedorProducto.DataSource = proveedoresActivos; // Usar la lista filtrada aquí
            cmbProveedorProducto.DisplayMember = "razonSocial";
            cmbProveedorProducto.ValueMember = "idProveedor";
            cmbProveedorProducto.SelectedIndex = -1;
        }

        private void CargarCategorias()
        {
            // Obtener todas las categorías
            List<Categoria> listaCategorias = objCN_Categoria.ListarCategorias();

            // Filtrar las categorías donde fecha_baja sea null
            List<Categoria> categoriasActivas = listaCategorias
                .Where(c => c.fecha_baja == null)
                .ToList();

            // Limpiar el combo box y asignar la lista filtrada
            cmbCategoriaProducto.Items.Clear();
            cmbCategoriaProducto.DataSource = categoriasActivas;
            cmbCategoriaProducto.DisplayMember = "nombre_categoria";
            cmbCategoriaProducto.ValueMember = "idCategoria";
            cmbCategoriaProducto.SelectedIndex = -1;
        }


        private void CargarMarcas()
        {
            // Obtener todas las marcas
            List<Marca> listaMarcas = objCN_Marca.ListarMarcas();

            // Filtrar las marcas donde fecha_baja sea null
            List<Marca> marcasActivas = listaMarcas
                .Where(c => c.fechaBaja == null)
                .ToList();

            // Limpiar el combo box y asignar la lista filtrada
            cmbMarcaProducto.Items.Clear();
            cmbMarcaProducto.DataSource = marcasActivas; // Usar la lista filtrada aquí
            cmbMarcaProducto.DisplayMember = "nombre";
            cmbMarcaProducto.ValueMember = "idMarca";
            cmbMarcaProducto.SelectedIndex = -1;
        }

       /* private void frmProducto_Load(object sender, EventArgs e)
        {
           
            
            
        }*/
        private void LimpiarControles()
        {
            txtNombreProducto.Clear();
            txtDetalleProducto.Clear();
            txtStockProducto.Clear();
            txtStockMinimoProducto.Clear();
            txtPrecioCompraProducto.Clear();
            txtPrecioVentaProducto.Clear();
            cmbProveedorProducto.SelectedIndex = -1;
            cmbCategoriaProducto.SelectedIndex = -1;
            cmbMarcaProducto.SelectedIndex = -1;
        }

        private void btnVolverUser_Click(object sender, EventArgs e)
        {
            ProductoDGV = null;
            this.Close();
        }

        private void btnLimpiarContenedorProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

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

        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioCompraProducto.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioVentaProducto.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarImagenProducto_Click(object sender, EventArgs e)
        {

            // Crear un OpenFileDialog para seleccionar la imagen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtro para mostrar solo archivos de imagen
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar una imagen";

                // Verificar si el usuario seleccionó una imagen y presionó OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen seleccionada en el PictureBox
                    pbImagenProducto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string mensajeProducto = string.Empty;
            int idProductoGenerado = 0;
            string mensajeConfirmacion = "¿Desea agregar el producto";
            bool VerdadProductoGenerado = false;

            // Validar imagen en el PictureBox antes de convertirla a byte[]
            byte[] imagenProducto = pbImagenProducto.Image != null ? ImageToByteArray(pbImagenProducto.Image) : null;

            // Validación de campos antes de convertirlos
            if (camposValidados() && double.TryParse(txtPrecioCompraProducto.Text, out double precioCompra)
                && double.TryParse(txtPrecioVentaProducto.Text, out double precioVenta)
                && int.TryParse(txtStockProducto.Text, out int stock)
                && int.TryParse(txtStockMinimoProducto.Text, out int stockMinimo))
            {
                string nombreProducto = txtNombreProducto.Text;
                string detalleProducto = txtDetalleProducto.Text;
                int idMarcaSeleccionada = (int)cmbMarcaProducto.SelectedValue;
                int idProveedorSeleccionado = (int)cmbProveedorProducto.SelectedValue;
                int idCategoriaSeleccionada = (int)cmbCategoriaProducto.SelectedValue;

                if (!string.IsNullOrEmpty(txtIdProducto.Text))
                    mensajeConfirmacion = "¿Confirma los cambios de";

                var confirmacion = MessageBox.Show(
                    $"{mensajeConfirmacion} {nombreProducto} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    Producto productoNuevo = new Producto()
                    {
                        idProducto = string.IsNullOrEmpty(txtIdProducto.Text) ? 0 : Convert.ToInt32(txtIdProducto.Text),
                        nombre = nombreProducto,
                        precioCompra = precioCompra,
                        precioVenta = precioVenta,
                        stock = stock,
                        stockMinimo = stockMinimo,
                        detalle = detalleProducto,
                        oMarca = new Marca() { idMarca = idMarcaSeleccionada },
                        oCategoria = new Categoria() { idCategoria = idCategoriaSeleccionada },
                        oProveedor = new Proveedor() { idProveedor = idProveedorSeleccionado },
                        Imagen = imagenProducto
                    };

                    // Si hay un ID de producto, se edita
                    if (!string.IsNullOrEmpty(txtIdProducto.Text))
                    {
                        VerdadProductoGenerado = new CN_Producto().Editar(productoNuevo, out mensajeProducto);
                        idProductoGenerado = productoNuevo.idProducto;
                    }
                    // Si no hay ID de producto, se registra como nuevo
                    else
                    {
                        idProductoGenerado = new CN_Producto().Registrar(productoNuevo, out mensajeProducto);
                    }

                    if (idProductoGenerado != 0)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensajeProducto);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error en la validación de los campos.");
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
            if (precioCompraVacio || precioVentaVacio || stockVacio || stockMinimoVacio || marcaVacio || categoriaVacio || proveedorVacio || detalle_productoVacio)
            {
                MessageBox.Show("Debe completar todos los campos del Formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (pbImagenProducto.Image == CapaPresentacion.Properties.Resources.fotoProducto)
            {
                MessageBox.Show("Por favor, seleccione una imagen para el producto.");
                return false;
            }


            return true;
        }

        //Función para convertir la imagen a byte[]
        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ImagenProducto(Producto p)
        {
            if (p.Imagen != null)
            {
                using (var ms = new MemoryStream(p.Imagen))
                {
                    return Image.FromStream(ms);
                }
            }
            else
            {
                return null; // Si no hay imagen
            }

        }

        private void frmProducto_Load_1(object sender, EventArgs e)
        {
            txtNombreProducto.Focus();
            objCN_Marca = new CN_Marca();
            objCN_Categoria = new CN_Categoria();
            objCN_proveedor = new CN_proveedor();
            CargarProveedores();
            CargarCategorias();
            CargarMarcas();
            if (ProductoDGV != null)
            {
                // Asignar valores de los TextBox
                txtDetalleProducto.Text = ProductoDGV.detalle?.ToString() ?? string.Empty;  // Maneja también si el detalle es null
                txtNombreProducto.Text = ProductoDGV.nombre?.ToString() ?? string.Empty;
                txtStockProducto.Text = ProductoDGV.stock.ToString();
                txtStockMinimoProducto.Text = ProductoDGV.stockMinimo.ToString();
                txtPrecioCompraProducto.Text = ProductoDGV.precioCompra.ToString();
                txtPrecioVentaProducto.Text = ProductoDGV.precioVenta.ToString();
                txtIdProducto.Text = ProductoDGV.idProducto.ToString();
                pbImagenProducto.Image = ImagenProducto(ProductoDGV);


                // Seleccionar la categoría en el ComboBox correspondiente
                foreach (Categoria item in cmbCategoriaProducto.Items)
                {
                    if (item.idCategoria == ProductoDGV.oCategoria.idCategoria)
                    {
                        cmbCategoriaProducto.SelectedItem = item;  // Establece el objeto seleccionado directamente
                        break;
                    }
                }

                // Seleccionar la marca en el ComboBox correspondiente
                foreach (Marca item in cmbMarcaProducto.Items)
                {
                    if (item.idMarca == ProductoDGV.oMarca.idMarca)
                    {
                        cmbMarcaProducto.SelectedItem = item;  // Establece el objeto seleccionado directamente
                        break;
                    }
                }

                // Seleccionar el proveedor en el ComboBox correspondiente
                foreach (Proveedor item in cmbProveedorProducto.Items)
                {
                    if (item.idProveedor == ProductoDGV.oProveedor.idProveedor)
                    {
                        cmbProveedorProducto.SelectedItem = item;  // Establece el objeto seleccionado directamente
                        break;
                    }
                }
            }
           


        }
    }
}

