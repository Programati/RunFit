using CapaDeEntidades;
using CapaDeNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Listar_Productos()
        {
            List<Producto> ListaProducto = new CN_Producto().ListarProductos();

            
            foreach (Producto item in ListaProducto)
            {
                dgvListaProducto.Rows.Add(new object[] {
                    CapaPresentacion.Properties.Resources.pencil, // Icono de editar
                    item.fechaBaja == null ? CapaPresentacion.Properties.Resources.producto_eliminar: CapaPresentacion.Properties.Resources.producto_activar, // Icono de acción
                    item.idProducto,
                    item.fechaBaja == null ? "Activo" : "Inactivo",
                    item.nombre,
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
                    //item.Imagen,
                    ImagenProducto(item)           
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
           
            // Filtra las filas de la lista de usuarios según el texto ingresado
            if (dgvListaProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaProducto.Rows)
                {
                    // Verifica si el nombre del producto contiene el texto de búsqueda
                    if (row.Cells["ID_Producto"].Value.ToString().Trim().ToUpper().Contains(txtBuscarProducto.Text.Trim().ToUpper()))
                        row.Visible = true; // Muestra la fila si coincide
                    else
                        row.Visible = false; // Oculta la fila si no coincide
                }
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
            Listar_Productos();
        }

        private void dgvListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaProducto.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {

                    Categoria CategoriaEditar = new Categoria()
                    {
                        nombre_categoria = dgvListaProducto.Rows[n].Cells["Categoria"].Value.ToString(),
                       // idCategoria=Convert.ToInt32(dgvListaProducto.Rows[n].Cells["ID_Categoria"].Value),
                        


                    };
                    Marca MarcaEditar = new Marca()
                    {
                        nombre =dgvListaProducto.Rows[n].Cells["Marca"].Value.ToString(),
                        idMarca = Convert.ToInt32(dgvListaProducto.Rows[n].Cells["ID_Marca"].Value),

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
                        //detalle = dgvListaProducto.Rows[n].Cells["Detalle"].Value.ToString() ,

                        oCategoria = CategoriaEditar,
                        oMarca = MarcaEditar,
                        oProveedor= ProveedorEditar,


                    };
                    // Abre el formulario para editar el usuario
                    frmProducto CrearNuevoProducto = new frmProducto(ProductoEditar);

                    CrearNuevoProducto.TopLevel = false; // Establece el formulario como hijo
                    pnlContenedorProducto.Controls.Clear(); // Limpia los controles del panel contenedor
                    pnlContenedorProducto.Controls.Add(CrearNuevoProducto); // Agrega el nuevo formulario al panel
                    CrearNuevoProducto.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario
                    CrearNuevoProducto.Dock = DockStyle.Fill; // Ajusta el tamaño del formulario al panel

                    CrearNuevoProducto.Show(); // Muestra el nuevo formulario
                    CrearNuevoProducto.FormClosing += frm_closing; // Suscribe al evento de cierre del formulario
                }
            }
            // Verifica si la columna seleccionada es la de "Eliminar"
            if (dgvListaProducto.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    string mensaje = string.Empty; 
                    Producto ProductoEliminar = new Producto() 
                    {
                         idProducto= (int)dgvListaProducto.Rows[n].Cells["ID_producto"].Value 
                    };

                    string estadoActual = dgvListaProducto.Rows[n].Cells["Estado"].Value.ToString(); 
                    string producto = dgvListaProducto.Rows[n].Cells["Producto"].Value.ToString(); 

                    // Si el producto está inactivo, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al producto {producto}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para activar el usuario
                            bool respuesta = new CN_Producto().Eliminar(ProductoEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado del usuario
                                dgvListaProducto.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaProducto.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black; // Cambia el color a negro
                                dgvListaProducto.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black; // Cambia el color de selección a negro

                                MessageBox.Show("Prdocuto " + producto + " activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si el producto está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al producto {producto}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para desactivar el producto
                            bool respuesta = new CN_Producto().Eliminar(ProductoEliminar, out mensaje);

                            // Actualizar el estado del producto
                            dgvListaProducto.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaProducto.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red; // Cambia el color a rojo
                            dgvListaProducto.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red; // Cambia el color de selección a rojo

                            MessageBox.Show("Producto " + producto + " desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvListaProducto.Rows.Clear(); // Limpia el DataGridView
                    Listar_Productos(); // Llama a la función para volver a cargar los datos
                }
            }
        }
    }

    

}
