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
    public partial class frmListarProducto : Form
    {
        Inicio _inicio;
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
                return null;
            }

        }
        public frmListarProducto(Inicio inicio)
        {
            InitializeComponent();
            _inicio = inicio;
            _inicio.PnlContenedorMenu.Enabled = false;
           
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            
            frmProducto CrearNuevoProducto = new frmProducto(); 
            CrearNuevoProducto.TopLevel = false;
            pnlContenedorProducto.Controls.Clear();
            pnlContenedorProducto.Controls.Add(CrearNuevoProducto);
            CrearNuevoProducto.FormBorderStyle = FormBorderStyle.None;
            CrearNuevoProducto.Dock = DockStyle.Fill;
            CrearNuevoProducto.Show();
            CrearNuevoProducto.FormClosing += frm_closing;
        }

        private void Listar_Productos()
        {
            List<Producto> ListaProducto = new CN_Producto().ListarProductos();
            
            foreach (Producto item in ListaProducto)
            {
                dgvListaProducto.Rows.Add(new object[] {
                    CapaPresentacion.Properties.Resources.pencil,
                    item.fechaBaja == null ? CapaPresentacion.Properties.Resources.producto_eliminar: CapaPresentacion.Properties.Resources.producto_activar,
                    item.idProducto,
                    item.fechaBaja == null ? "Activo" : "Inactivo",
                    item.nombre,
                    item.detalle,
                    item.precioCompra,
                    item.precioVenta,
                    item.stock,
                    item.stockMinimo,
                    item.oMarca.nombre,
                    item.oMarca.idMarca,
                    item.oCategoria.nombre_categoria,
                    item.oCategoria.idCategoria,
                    item.oProveedor.razonSocial,
                    item.oProveedor.idProveedor,
                    ImagenProducto(item),
                 });
            }

            for (int i = 0; i < dgvListaProducto.Rows.Count; i++)
            {
                string estado = dgvListaProducto.Rows[i].Cells["Estado"].Value.ToString();

                if (estado == "Activo")
                {
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                }
                else if (estado == "Inactivo")
                {
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvListaProducto.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                }
            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            frmListarProducto ListarNuevoProducto = new frmListarProducto(_inicio); 
            ListarNuevoProducto.TopLevel = false; 
            pnlContenedorProducto.Controls.Clear(); 
            pnlContenedorProducto.Controls.Add(ListarNuevoProducto); 
            ListarNuevoProducto.FormBorderStyle = FormBorderStyle.None; 
            ListarNuevoProducto.Dock = DockStyle.Fill; 
            ListarNuevoProducto.Show(); 
        }

        private void btnLimpiarBuscarProducto_Click(object sender, EventArgs e)
        {
            txtBuscarProducto.Clear(); 
        }
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
           
            if (dgvListaProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    if (row.Cells["ID_Producto"].Value.ToString().Trim().ToUpper().Contains(txtBuscarProducto.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (EsCodigoMuyCorto())
            {
                return;
            }
        }

        private bool EsCodigoMuyCorto()
        {
            if (txtBuscarProducto.Text.Length < 4)
            {
                MessageBox.Show("El CODIGO del Producto es muy corto, vuelva intentar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true; 
            }
            return false; 
        }
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; 
                _inicio.MostrarImagenFondo(); 
            }
            this.Close(); 
        }

        private void frmListarProducto_Load_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Focus();
            Listar_Productos();
        }

        private void dgvListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaProducto.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    byte[] imagenProducto = dgvListaProducto.Rows[n].Cells["Imagen"].Value != null ? ImageToByteArray((Image)dgvListaProducto.Rows[n].Cells["Imagen"].Value) : null;

                    Categoria CategoriaEditar = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["id_categoria"].Value),
                        nombre_categoria = dgvListaProducto.Rows[n].Cells["Categoria"].Value.ToString()
                    };
                    Marca MarcaEditar = new Marca()
                    {
                        nombre = dgvListaProducto.Rows[n].Cells["Marca"].Value.ToString(),
                        idMarca = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["id_marca"].Value),
                    };
                    
                    Proveedor ProveedorEditar = new Proveedor()
                    {
                        razonSocial = dgvListaProducto.Rows[n].Cells["Proveedor"].Value.ToString(),
                        idProveedor = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["ID_Proveedor"].Value),

                    };
                    Producto ProductoEditar = new Producto()
                    {
                        idProducto = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["ID_producto"].Value),
                        nombre = dgvListaProducto.Rows[n].Cells["Producto"].Value.ToString(),
                        precioCompra = Convert.ToDouble(dgvListaProducto.Rows[n].Cells["PrecioCompra"].Value),
                        precioVenta = Convert.ToDouble(dgvListaProducto.Rows[n].Cells["PrecioVenta"].Value),
                        stock = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["Stock"].Value),
                        stockMinimo = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["StockMinimo"].Value),
                        Imagen = imagenProducto,
                        detalle = dgvListaProducto.Rows[n].Cells["Detalle"].Value.ToString(),

                        oCategoria = CategoriaEditar,
                        oMarca = MarcaEditar,
                        oProveedor= ProveedorEditar,


                    };
                    frmProducto CrearNuevoProducto = new frmProducto(ProductoEditar);

                    CrearNuevoProducto.TopLevel = false;
                    pnlContenedorProducto.Controls.Clear();
                    pnlContenedorProducto.Controls.Add(CrearNuevoProducto);
                    CrearNuevoProducto.FormBorderStyle = FormBorderStyle.None;
                    CrearNuevoProducto.Dock = DockStyle.Fill;

                    CrearNuevoProducto.Show();
                    CrearNuevoProducto.FormClosing += frm_closing;
                }
            }
           
            if (dgvListaProducto.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty; 
                    Producto ProductoEliminar = new Producto() 
                    {
                         idProducto= (int)dgvListaProducto.Rows[n].Cells["ID_producto"].Value 
                    };

                    string estadoActual = dgvListaProducto.Rows[n].Cells["Estado"].Value.ToString(); 
                    string producto = dgvListaProducto.Rows[n].Cells["Producto"].Value.ToString(); 

                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al producto {producto}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Producto().Eliminar(ProductoEliminar, out mensaje);

                            if (respuesta)
                            {
                                dgvListaProducto.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaProducto.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black;
                                dgvListaProducto.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                                MessageBox.Show("Prdocuto " + producto + " activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al producto {producto}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Producto().Eliminar(ProductoEliminar, out mensaje);
                            dgvListaProducto.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaProducto.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red;
                            dgvListaProducto.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                            MessageBox.Show("Producto " + producto + " desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    dgvListaProducto.Rows.Clear();
                    Listar_Productos();
                }
            }
        }
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
    }
}
