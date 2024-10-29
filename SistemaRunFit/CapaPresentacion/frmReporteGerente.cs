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
        public frmReporteGerente()
        {
            InitializeComponent();
            //CargarReporteGerente_3();
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
                        CargarReporteGerente_1();

                    }
                    else if (cmbReporteGerente.SelectedIndex == 1) // "Productos más vendidos por unidad"
                    {
                        CargarReporteGerente_2();
                    }
                    else if (cmbReporteGerente.SelectedIndex == 2) // "Productos más vendidos en dinero"
                    {
                        CargarReporteGerente_3();

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
        }
    }
}
