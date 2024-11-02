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
    public partial class frmReporteGerente : Form
    {
        private CN_Gerente cnGerente = new CN_Gerente();
        private CN_Usuario objCN_Usuario = new CN_Usuario();

        public frmReporteGerente()
        {
            InitializeComponent();
            CargarVendedores();
            componentesInicio();
        }

        private void CargarReporteGerente_1()
        {
            // Obtén las fechas seleccionadas en los DateTimePickers
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            // Llama al método de la instancia de la capa de negocios con las fechas
            List<ReporteGrafico> reporteGrafico = cnGerente.ListarReporteGerente_1(fechaDesde, fechaHasta);

            if (reporteGrafico.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = reporteGrafico.Select(rg => new
                {
                    Vendedor = rg.Vendedor,
                    Importe_Total = rg.SubTotal
                })
                .OrderByDescending(x => x.Importe_Total)
                .ToList();

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;

                // Limpiar las series del gráfico antes de cargar nuevos datos
                chartGerente.Series.Clear();

                // Crear una nueva serie para el gráfico
                var series = chartGerente.Series.Add("Importe Total");

                // Definir el tipo de gráfico, por ejemplo, un gráfico de barras
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // Recorrer los datos del reporte para llenarlo en el gráfico
                foreach (var item in reporteGrafico)
                {
                    series.Points.AddXY(item.Vendedor, item.SubTotal);
                }

                // Opcional: configurar títulos y leyendas
                chartGerente.Titles.Clear();
                chartGerente.Titles.Add("Importe Total por Vendedor");
            }
            else
            {
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el gráfico si no hay datos
                chartGerente.Series.Clear();
            }
        }
        private void CargarReporteGerente_2()
        {
            // Obtén las fechas seleccionadas en los DateTimePickers
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            // Llama al método de la instancia de la capa de negocios con las fechas
            List<ReporteGrafico> reporteGrafico = cnGerente.ListarReporteGerente_2(fechaDesde, fechaHasta);

            if (reporteGrafico.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = reporteGrafico.Select(rg => new
                {
                    Producto = rg.Producto,
                    Cantidad = rg.Cantidad
                })
                .OrderByDescending(x => x.Cantidad)
                .ToList();

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;

                // Limpiar las series del gráfico antes de cargar nuevos datos
                chartGerente.Series.Clear();

                // Crear una nueva serie para el gráfico
                var series = chartGerente.Series.Add("Cantidad");

                // Definir el tipo de gráfico, por ejemplo, un gráfico de barras
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // Recorrer los datos del reporte para llenarlo en el gráfico
                foreach (var item in reporteGrafico)
                {
                    series.Points.AddXY(item.Producto, item.Cantidad);
                }

                // Opcional: configurar títulos y leyendas
                chartGerente.Titles.Clear();
                chartGerente.Titles.Add("Ventas por Producto ");
            }
            else
            {
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el gráfico si no hay datos
                chartGerente.Series.Clear();
            }
        }





        private void CargarReporteGerente_3()
        {
            // Obtén las fechas seleccionadas en los DateTimePickers
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            // Llama al método de la instancia de la capa de negocios con las fechas
            List<ReporteGrafico> reporteGrafico = cnGerente.ListarReporteGerente_3(fechaDesde, fechaHasta);

            if (reporteGrafico.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = reporteGrafico.Select(rg => new
                {
                    Producto = rg.Producto,
                    Ventas_Totales = rg.SubTotal
                })
                .OrderByDescending(x => x.Ventas_Totales)
                .ToList();

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;

                // Limpiar las series del gráfico antes de cargar nuevos datos
                chartGerente.Series.Clear();

                // Crear una nueva serie para el gráfico
                var series = chartGerente.Series.Add("Ventas Totales");

                // Definir el tipo de gráfico, por ejemplo, un gráfico de barras
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                // Recorrer los datos del reporte para llenarlo en el gráfico
                foreach (var item in reporteGrafico)
                {
                    series.Points.AddXY(item.Producto, item.SubTotal);
                }

                // Opcional: configurar títulos y leyendas
                chartGerente.Titles.Clear();
                chartGerente.Titles.Add("Productos mas rentables ");
            }
            else
            {
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el gráfico si no hay datos
                chartGerente.Series.Clear();
            }
        }
        private void CargarReporteGerente_4( )
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            List<Venta> ventas = cnGerente.ListarReporteGerente_4( fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                dgvReporteGerente.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Num_Factura =dv.idDetalleVenta,
                    Vendedor = v.oUsuario.nombreUsuario,
                    Cantidad=dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    Subtotal = dv.subTotal
                })).ToList();
            }
            else
            {
                dgvReporteGerente.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void CargarReporteGerente_5()
        {
            //DateTime fechaDesde = dtpFechaDesde.Value;
           // DateTime fechaHasta = dtpFechaHasta.Value;
            List<Venta> ventas = cnGerente.ListarReporteGerente_5();

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                dgvReporteGerente.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Producto = dv.oProducto.nombre,
                    Talle = dv.oProducto.detalle,
                    Stock = dv.oProducto.stock,
                    Stock_Min = dv.oProducto.stockMinimo,
                    Marca = dv.oProducto.oMarca.nombre,
                    Categoria = dv.oProducto.oCategoria.nombre_categoria,
                    Proveedor = dv.oProducto.oProveedor.razonSocial
                })).ToList();
            }
            else
            {
                dgvReporteGerente.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        

        private void cmbReporteGerente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se ha seleccionado una opción válida en el ComboBox
                if (cmbReporteGerente.SelectedIndex >= 0)
                {
                    // Instancia la capa de negocios
                    CN_Usuario cnUsuario = new CN_Usuario();

                    // Variable para recibir el mensaje desde la capa de negocio
                    string mensaje = string.Empty;

                    // Determina qué reporte generar según la selección en el ComboBox
                    if (cmbReporteGerente.SelectedIndex == 0) // "Ventas cronológico"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_1();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;

                    }
                    else if (cmbReporteGerente.SelectedIndex == 1) // "Productos más vendidos por unidad"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_2();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;
                    }
                    else if (cmbReporteGerente.SelectedIndex == 2) // "Productos más vendidos en dinero"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_3();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible=false;

                    }
                    else if (cmbReporteGerente.SelectedIndex == 3) // "Productos más vendidos en dinero"
                    {
                        ExpandirPanel();
                        CargarReporteGerente_4();
                        cmbVendedorSelector.Visible= true;
                        CargarVendedores();

                    }
                    else if (cmbReporteGerente.SelectedIndex == 4) // "Productos más vendidos en dinero"
                    {
                        
                        ExpandirPanel();
                        CargarReporteGerente_5();

                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una opción del reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Método para expandir el panel y ocultar el gráfico
            

        }

        private void componentesInicio()
        {
            cmbVendedorSelector.Visible = false;
            lblVendedorSelector.Visible = false;
            chartGerente.Visible = false;
        }
        private void ExpandirPanel()
        {
            panel1.Size = new Size(900, 402); 
            chartGerente.Visible = false;     
            panel1.BringToFront();           
        }
        private void RestaurarPanel()
        {
            panel1.Size = new Size(406, 420); 
            chartGerente.Visible = true;
            chartGerente.Location = new Point(453, 195);
        }

       
        private void CargarVendedores()
        {
            List<Usuario> listaVendores = objCN_Usuario.ListarUsuarios();

            // Filtrar usuarios activos con id_rol igual a 3, verificando que oRol no sea null
            List<Usuario> UsuariosActivas = listaVendores
                .Where(c => c.fechaBaja == null && c.oRol != null && c.oRol.idRol == 3)
                .ToList();

            
            cmbVendedorSelector.DataSource = UsuariosActivas;
            cmbVendedorSelector.DisplayMember = "nombreUsuario";
            cmbVendedorSelector.ValueMember = "idUsuario";
            cmbVendedorSelector.SelectedIndex = -1;

          
            cmbVendedorSelector.SelectionChangeCommitted += cmbVendedorSelector_SelectionChangeCommitted;
        }

        
        private void cmbVendedorSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbVendedorSelector.SelectedIndex != -1)
            {
                
                int idUsuarioSeleccionado = (int)cmbVendedorSelector.SelectedValue;
                CargarReporteGerente_6(idUsuarioSeleccionado);
            }
        }

       
        private void CargarReporteGerente_6(int idUsuario)
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            
            List<Venta> ventas = cnGerente.ListarReporteGerente_6(idUsuario, fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                
                dgvReporteGerente.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Num_Factura = dv.idDetalleVenta,
                    Vendedor = v.oUsuario.nombreUsuario != null ? v.oUsuario.nombreUsuario : "Sin vendedor", // Manejo de null
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    Subtotal = dv.subTotal
                })).ToList();
            }
            else
            {
                dgvReporteGerente.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
