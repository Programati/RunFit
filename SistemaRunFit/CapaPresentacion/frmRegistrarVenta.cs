using System;
using System.Windows.Forms;
using CapaDeNegocios;
using Guna.UI.WinForms;
using System.Collections.Generic;
using CapaDeEntidades;
using System.Runtime.CompilerServices;
using System.Linq;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        private Inicio _inicio;
        private List<Producto> _listaProductos = null;
        private List<Domicilio> _listaClientes = null;
        private Domicilio _cliente = null;
        private Producto _producto = null;
        private List<Carrito> _carrito = new List<Carrito>();
        private string factura = "";
        private decimal _totalCompra = 0;

        public frmRegistrarVenta(Inicio inicioForm)
        {
            InitializeComponent();
            _inicio = inicioForm;
            this.Load += new EventHandler(frmRegistrarVenta_Load);
            _listaProductos = new CN_Producto().ListarProductos();
            _listaClientes = new CN_Domicilio().ListarDomicilios();
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
                // Buscar el producto
                _cliente = _listaClientes.FirstOrDefault(c => Convert.ToInt32(c.oPersona.dni) == dniCliente);

                if (_cliente != null)
                {
                    txtNyApeRegVta.Text = _cliente.oPersona.apellido + " " + _cliente.oPersona.nombre;
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
            txtCantidadItenVta.Clear();
            txtNomPtoRegVtas.Clear();
            txtStockRegistrarVenta.Clear();
            int codigoProducto;
            // Verificar si el valor ingresado es un número válido
            if (int.TryParse(txtBuscarCodigoVta.Text, out codigoProducto))
            {
                // Buscar el producto
                _producto = _listaProductos.FirstOrDefault(p => p.idProducto == codigoProducto);

                if (_producto != null)
                {
                    txtNomPtoRegVtas.Text = _producto.nombre;
                    txtStockRegistrarVenta.Text = _producto.stock.ToString();
                }
                else
                {
                    MessageBox.Show("No existe producto con el códgio #" + txtBuscarCodigoVta.Text);
                }
            }
            else
            {
                MessageBox.Show("El código ingresado no es válido.");
            }

        }

        private void txtLimpiarBuscarPtoVta_Click(object sender, System.EventArgs e)
        {
            txtNomPtoRegVtas.Clear();
            txtBuscarCodigoVta.Clear(); 
            txtCantidadItenVta.Clear(); 
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
            if (string.IsNullOrEmpty(txtBuscarCodigoVta.Text) || string.IsNullOrEmpty(txtNomPtoRegVtas.Text))
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
            txtBuscarCodigoVta.Clear();
            txtCantidadItenVta.Clear();
            txtNomPtoRegVtas.Clear();
            txtStockRegistrarVenta.Clear();

            //ACA HAY QUE VACIAR EL GRID Y CARGARLO DENUEVO
            CargarDataGrid();
            /*_totalCompra = 0;
            if (_carrito.Count > 0)
            {
                dgvDetalleVta.Rows.Clear(); // Limpia el DataGridView
                foreach (var item in _carrito)
                {
                    dgvDetalleVta.Rows.Add(new object[]
                    {
                        "#"+item.Producto.idProducto,
                        item.Producto.nombre,
                        item.Cantidad.ToString(),
                        CapaPresentacion.Properties.Resources.Eliminar,
                        "$"+(item.Cantidad * item.Producto.precioVenta).ToString()
                    });
                    _totalCompra += (item.Cantidad * item.Producto.precioVenta);
                }
                lblMontoSubtotalVta.Text = "$"+_totalCompra.ToString();
            }*/

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
            else
            {
                // Si no se encuentra el producto, mostrar un mensaje
                Console.WriteLine($"Producto con ID {idProducto} no encontrado en el carrito.");
            }
        }

        private void CargarDataGrid()
        {
            _totalCompra = 0;
            if (_carrito.Count > 0)
            {
                dgvDetalleVta.Rows.Clear(); // Limpia el DataGridView
                foreach (var item in _carrito)
                {
                    dgvDetalleVta.Rows.Add(new object[]
                    {
                        item.Producto.idProducto,
                        item.Producto.nombre,
                        item.Cantidad.ToString(),
                        CapaPresentacion.Properties.Resources.Eliminar,
                        "$"+(item.Cantidad * item.Producto.precioVenta).ToString()
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
    }
}
