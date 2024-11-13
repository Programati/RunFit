using System;
using System.Windows.Forms;
using CapaDeNegocios;
using Guna.UI.WinForms;
using System.Collections.Generic;
using CapaDeEntidades;
using System.Runtime.CompilerServices;
using System.Linq;
using System.IO;
using System.Drawing;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        private Inicio _inicio;
        private Usuario _usuarioVendedor;
        private List<Producto> _listaProductos = null;
        private List<Domicilio> _listaClientes = null;
        private Domicilio _cliente = null;
        private Producto _producto = null;
        private List<Carrito> _carrito = new List<Carrito>();
        private string factura = "";
        private double _totalCompra = 0;
        DateTime fechaHoy = DateTime.Today;
       
        public frmRegistrarVenta(Inicio inicioForm, Usuario usuario)
        {
            InitializeComponent();
            _inicio = inicioForm;
            _usuarioVendedor = usuario;
            this.Load += new EventHandler(frmRegistrarVenta_Load);
            _listaProductos = new CN_Producto().ListarProductosActivos();
            _listaClientes = new CN_Domicilio().ListarDomicilios();
            lblFechaVenta.Text = fechaHoy.ToString("dd/MM/yyyy");
            autocompletar();
        }
        void autocompletar()
        {
            AutoCompleteStringCollection _ListaProductosAutoCompletar = new AutoCompleteStringCollection();
            foreach (Producto producto in _listaProductos)
            {
                _ListaProductosAutoCompletar.Add(producto.nombre + " " + producto.detalle);
            }
            // Configurar las propiedades del autocompletado
            txtNombreProductoVenta.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreProductoVenta.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombreProductoVenta.AutoCompleteCustomSource = _ListaProductosAutoCompletar;
        }
        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarDniVta.Focus();
        }
        private void btnBuscarClteVta_Click(object sender, System.EventArgs e)
        {
            if (txtBuscarDniVta.Text.Length > 8)
            {
                MessageBox.Show("El DNI no puede contener más de 8 dígitos");
                return;
            }
            if (txtBuscarDniVta.Text.Length < 7)
            {
                MessageBox.Show("El DNI es muy corto");
                return;
            }

            int dniCliente;
            // Verificar si el valor ingresado es un número válido
            if (int.TryParse(txtBuscarDniVta.Text, out dniCliente))
            {
                // Buscar cliente por DNI
                _cliente = _listaClientes.FirstOrDefault(c => Convert.ToInt32(c.oPersona.dni) == dniCliente);

                if (_cliente != null)
                {
                    // Verificar si el cliente está activo
                    if (_cliente.oPersona.estado == '1')
                    {
                        lblNombreYApellidoCliente.Text = _cliente.oPersona.apellido + " " + _cliente.oPersona.nombre;
                    }
                    else
                    {
                        MessageBox.Show("El cliente con el DNI " + txtBuscarDniVta.Text + " está DADO DE BAJA.");
                    }
                }
                else
                {
                    MessageBox.Show("No existe cliente con el DNI " + txtBuscarDniVta.Text);
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no es válido.");
            }
        }
        private void txtBuscarPtoVta_Click(object sender, EventArgs e)
        {
            LimpiarGrupoDetalle();
            int codigoProducto;

            // Verificar si el valor ingresado es un número válido
            if (int.TryParse(txtBuscarCodigoVta.Text, out codigoProducto))
            {
                // Buscar el producto
                _producto = _listaProductos.FirstOrDefault(p => p.idProducto == codigoProducto);

                if (_producto != null)
                {
                    //txtNombreProductoVenta.Text = _producto.nombre;
                    txtNombreProductoVenta.Text = _producto.nombre + " " + _producto.detalle;
                    pbImgProductoVenta.Image = ImagenProducto(_producto);
                    lblPrecio.Text = "$"+_producto.precioVenta.ToString("N2");

                    if (dgvDetalleVta.Rows.Count > 0)
                    {
                        var _productoDelCarrito = _carrito.FirstOrDefault(p => p.Producto.idProducto == codigoProducto);
                        if ( BuscarEnDataGridView(_producto.idProducto.ToString()) )
                        {
                            txtStockRegistrarVenta.Text = (_producto.stock - (int)_productoDelCarrito.Cantidad).ToString();
                            return;
                        }
                        txtStockRegistrarVenta.Text = _producto.stock.ToString();
                    }
                    else
                    {
                        txtStockRegistrarVenta.Text = _producto.stock.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("No existe producto con el códgio #" + txtBuscarCodigoVta.Text);
                    LimpiarGrupoDetalle();
                    LimpiarGrupoProducto();
                }
            }
            else
            {
                MessageBox.Show("El código ingresado no es válido.");
            }

        }
        private void txtBuscarDniVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBuscarCodigoVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCantidadItenVta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true;
                _inicio.MostrarImagenFondo();
            }
            this.Close();
        }
        private void btnAgregaritemVta_Click(object sender, EventArgs e)
        {
            int cantidadProducto = 0;
            if (string.IsNullOrEmpty(txtBuscarCodigoVta.Text) || string.IsNullOrEmpty(txtNombreProductoVenta.Text))
            {
                MessageBox.Show("No hay producto para agregar");
                return;
            }
            if (string.IsNullOrEmpty(txtCantidadItenVta.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            if (string.IsNullOrEmpty(txtStockRegistrarVenta.Text) || _producto.stock <= 0)
            {
                MessageBox.Show("No hay Stock del producto");
                return;
            }
            if (_producto.stock < Convert.ToInt16(txtCantidadItenVta.Text))
            {
                MessageBox.Show("Stock insuficiente");
                return;
            }

            cantidadProducto = Convert.ToInt32(txtCantidadItenVta.Text);
            if(cantidadProducto <= 0)
            {
                MessageBox.Show("Cantidad incorrecta!");
                return;
            }

            CargarCarrito(_producto, cantidadProducto);
            LimpiarGrupoProducto();
            LimpiarGrupoDetalle();
            CargarDataGrid();
        }
        private void CargarCarrito(Producto p, int cant)
        {
            // Buscar si el producto ya está en el carrito
            var itemExistente = _carrito.FirstOrDefault(c => c.Producto.idProducto == p.idProducto);
            var ProductoElegido = _listaProductos.FirstOrDefault(pe => pe.idProducto == p.idProducto);

            if(itemExistente == null)
            {
                _carrito.Add(new Carrito { Producto = p, Cantidad = cant });
                return;
            }

            if (ProductoElegido.stock >= (itemExistente.Cantidad + cant))
            {
                itemExistente.Cantidad += cant;
            }
            else
            {
                MessageBox.Show("Stock insuficiente!");
            }
            
        }
        public void EliminarProductoDelCarrito(int idProducto)
        {
            // Buscar el producto en la lista
            var itemAEliminar = _carrito.FirstOrDefault(c => c.Producto.idProducto == idProducto);

            if (itemAEliminar != null)
            {
                // Si el producto existe en la lista, eliminarlo
                _carrito.Remove(itemAEliminar);
            }
        }
        public bool RecorrerProductosDelCarrito(List<Carrito> CarritoLleno)
        {
            foreach (var item in _listaProductos)
            {
                var itemCarrito = CarritoLleno.FirstOrDefault(c => c.Producto.idProducto == item.idProducto);
                if (itemCarrito != null)
                {
                    if(item.stock <= 0 || item.stock < itemCarrito.Cantidad )
                    {
                        MessageBox.Show($"No hay stock suficiente del producto: {item.nombre}!");
                        BuscarYPintarEnDataGridView(itemCarrito.Producto.idProducto.ToString());
                        _listaProductos = new CN_Producto().ListarProductosActivos();
                        return false;
                    }
                }
            }
            return true;
        }
        private void CargarDataGrid()
        {
            _totalCompra = 0;

            if (_carrito.Count > 0)
            {
                dgvDetalleVta.Rows.Clear();
                foreach (var item in _carrito)
                {
                    
                    dgvDetalleVta.Rows.Add(new object[]
                    {
                        item.Producto.idProducto,
                        item.Producto.nombre,
                        item.Producto.detalle,
                        item.Cantidad.ToString(),
                        "$"+item.Producto.precioVenta.ToString(),
                        "$"+(item.Cantidad * item.Producto.precioVenta).ToString(),
                        CapaPresentacion.Properties.Resources.Eliminar
                    });
                    _totalCompra += (item.Cantidad * item.Producto.precioVenta);
                }
                lblMontoSubtotalVta.Text = "$" + _totalCompra.ToString();
                return;
            }
            lblMontoSubtotalVta.Text = "$0";
            dgvDetalleVta.Rows.Clear();
        }
        private void dgvDetalleVta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleVta.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    int ProductoElegido = Convert.ToInt32(dgvDetalleVta.Rows[n].Cells["Codigo"].Value);
                    EliminarProductoDelCarrito(ProductoElegido);
                    CargarDataGrid();
                }
            }
        }
        private bool BuscarEnDataGridView(string codigo)
        {
            if (dgvDetalleVta.Columns["Codigo"] != null)
            {
                int indiceColumnaCodigo = dgvDetalleVta.Columns["Codigo"].Index;

                foreach (DataGridViewRow fila in dgvDetalleVta.Rows)
                {
                    DataGridViewCell celda = fila.Cells[indiceColumnaCodigo];

                    if (celda.Value != null)
                    {
                        // Limpiar los espacios en blanco y comparar de manera insensible a mayúsculas
                        string valorCelda = celda.Value.ToString().Trim();
                        string codigoBuscado = codigo.Trim();

                        if (valorCelda.Equals(codigoBuscado, StringComparison.OrdinalIgnoreCase))
                        {
                            return true; // Código encontrado
                        }
                    }
                }
            }
            return false; // Código no encontrado
        }
        private void BuscarYPintarEnDataGridView(string codigo)
        {
            // Asegurarse de que la columna "Codigo" exista en el DataGridView
            if (dgvDetalleVta.Columns["Codigo"] != null)
            {
                int indiceColumnaCodigo = dgvDetalleVta.Columns["Codigo"].Index;

                // Recorrer todas las filas para buscar coincidencias
                foreach (DataGridViewRow fila in dgvDetalleVta.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        DataGridViewCell celda = fila.Cells[indiceColumnaCodigo];

                        if (celda.Value != null && celda.Value.ToString().Contains(codigo))
                        {
                            // Cambiar el color de fondo y el color de selección
                            fila.DefaultCellStyle.BackColor = Color.Red;
                            fila.DefaultCellStyle.SelectionBackColor = Color.DarkRed; // También cambia el color cuando está seleccionada
                        }
                    }
                }
            }


        }
        private void btnConfirmarVta_Click(object sender, EventArgs e)
        {
            _listaProductos = new CN_Producto().ListarProductosActivos();
            
            string MensajeVenta = string.Empty;
            string MensajeDetalleVenta = string.Empty;
            string MensajeProducto = string.Empty;
            int IdVentaGenerada = 0;
            int IdDetalleVentaGenerada = 0;
            int ProductoActualizado = 0;

            if(string.IsNullOrEmpty(txtBuscarDniVta.Text))
            {
                MessageBox.Show("Falta DNI");
                return;
            }
            var cliente = _listaClientes.FirstOrDefault(c => Convert.ToInt32(c.oPersona.dni) == Convert.ToInt32(txtBuscarDniVta.Text));
            if ( cliente == null)
            {
                MessageBox.Show("No existe cliente");
                return;
            }
            if (string.IsNullOrEmpty(lblNombreYApellidoCliente.Text)) 
            {
                MessageBox.Show("No hay cliente para la venta");
                return;
            }
            if (_carrito.Count <= 0)
            {
                MessageBox.Show("No hay productos para la venta");
                return;
            }

            var confirmacion = MessageBox.Show(
                    "Desea finalizar la venta?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (confirmacion == DialogResult.Yes)
            {
                if (RecorrerProductosDelCarrito(_carrito))
                {
                    Venta VentaNueva = new Venta()
                    {
                        importeTotal = _totalCompra,
                        fechaFactura = fechaHoy.ToString("yyyy-MM-dd"),
                        oUsuario = _usuarioVendedor,
                        oCliente = new Domicilio() 
                        { 
                            oPersona = new Persona()
                            {
                                idPersona = (_cliente = _listaClientes.FirstOrDefault(c => Convert.ToInt32(c.oPersona.dni) == Convert.ToInt32(txtBuscarDniVta.Text))).oPersona.idPersona
                            }
                        }
                    };

                    IdVentaGenerada = new CN_Venta().Registrar(VentaNueva, out MensajeVenta);

                    if (IdVentaGenerada != 0)
                    {
                        foreach (var item in _carrito)
                        {
                            DetalleVenta DetalleVentaNuevo = new DetalleVenta()
                            {
                                cantidad = item.Cantidad,
                                subTotal = item.Producto.precioVenta * item.Cantidad,
                                oProducto = item.Producto,
                                oVenta = new Venta() { idVenta = IdVentaGenerada }
                            };

                            IdDetalleVentaGenerada = new CN_DetalleVentas().Registrar(DetalleVentaNuevo, out MensajeDetalleVenta);

                            if(IdDetalleVentaGenerada == 0)
                            {
                                MessageBox.Show(MensajeDetalleVenta);
                                return;
                            }
                            ProductoActualizado = new CN_Producto().Actualizar(item.Producto.idProducto, item.Cantidad, out MensajeProducto);
                        }
                    }
                    if (IdVentaGenerada != 0 && IdDetalleVentaGenerada != 0 && ProductoActualizado != 0)
                    {
                        MessageBox.Show("Venta registrada correctamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarFormVentaCompleto();
                        _listaProductos = new CN_Producto().ListarProductos();

                        Venta factura = new CN_Venta().ObtenerVentaPorId(IdVentaGenerada);
                        if (factura.idVenta != 0)
                        {
                            frmFactura VistaFactura = new frmFactura(factura);
                            VistaFactura.Show();
                        }
                        else
                        {
                            MessageBox.Show("Numero de factura incorrecta!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(MensajeVenta + "\n" + MensajeDetalleVenta);
                    }
                }
            }
        }
        private void LimpiarGrupoCliente()
        {
            lblNombreYApellidoCliente.Text = "";
            txtBuscarDniVta.Clear();
        }
        private void LimpiarGrupoProducto()
        {
            txtBuscarCodigoVta.Clear();
            txtNombreProductoVenta.Clear();
        }
        private void LimpiarGrupoDetalle()
        {
            txtCantidadItenVta.Clear();
            txtStockRegistrarVenta.Clear();
            lblCategoria.Text = "";
            lblMarca.Text = "";
            pbImgProductoVenta.Image = CapaPresentacion.Properties.Resources.ProductoGenerico;
            lblPrecio.Text = "$00.00";
        }
        private void limpiarFormVentaCompleto()
        {
            LimpiarGrupoCliente();
            LimpiarGrupoProducto();
            LimpiarGrupoDetalle();
            dgvDetalleVta.Rows.Clear();
            lblMontoSubtotalVta.Text = "$0.00";
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
                return CapaPresentacion.Properties.Resources.ProductoGenerico;
            }

        }
        private void txtNombreProductoVenta_Leave(object sender, EventArgs e)
        {
            txtBuscarCodigoVta.Clear();
            txtCantidadItenVta.Clear();
            AplicarProductoSeleccionado();
        }
        private void AplicarProductoSeleccionado()
        {
            int cod;
            // Obtener el nombre del producto ingresado por el usuario
            string productoSeleccionado = txtNombreProductoVenta.Text;

            // Buscar el producto en la lista
            Producto producto = _listaProductos.FirstOrDefault(p => string.Equals(p.nombre + " " + p.detalle, productoSeleccionado, StringComparison.OrdinalIgnoreCase));


            // Si se encuentra el producto, llenar los campos correspondientes
            if (producto != null)
            {
                cod = producto.idProducto;
                txtStockRegistrarVenta.Text = producto.stock.ToString();
                txtBuscarCodigoVta.Text = producto.idProducto.ToString();
                pbImgProductoVenta.Image = ImagenProducto(producto);
                lblCategoria.Text = producto.oCategoria.nombre_categoria;
                lblMarca.Text = producto.oMarca.nombre;
                _producto = producto;
                lblPrecio.Text = "$"+producto.precioVenta.ToString("N2");
            }
            // Verificar si el valor ingresado es un número válido
            if (int.TryParse(txtBuscarCodigoVta.Text, out cod))
            {
                _producto = _listaProductos.FirstOrDefault(p => p.idProducto == cod);

                if (_producto != null)
                {
                    txtNombreProductoVenta.Text = _producto.nombre + " " + _producto.detalle;
                    pbImgProductoVenta.Image = ImagenProducto(_producto);
                    lblCategoria.Text = producto.oCategoria.nombre_categoria;
                    lblMarca.Text = producto.oMarca.nombre;

                    if (dgvDetalleVta.Rows.Count > 0)
                    {
                        var _productoDelCarrito = _carrito.FirstOrDefault(p => p.Producto.idProducto == cod);
                        if (BuscarEnDataGridView(_producto.idProducto.ToString()))
                        {
                            txtStockRegistrarVenta.Text = (_producto.stock - (int)_productoDelCarrito.Cantidad).ToString();
                            return;
                        }
                        txtStockRegistrarVenta.Text = _producto.stock.ToString();
                    }
                    else
                    {
                        txtStockRegistrarVenta.Text = _producto.stock.ToString();
                    }

                }
            }
            else
            {
                MessageBox.Show("El producto ingresado no existe.");
                LimpiarGrupoProducto();
                LimpiarGrupoDetalle();
            }
        }
        private void txtNombreProductoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBuscarCodigoVta.Clear();
                AplicarProductoSeleccionado();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}
