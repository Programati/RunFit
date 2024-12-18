﻿using CapaDeEntidades;
using CapaDeNegocios;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Diagrams;
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
            componentesInicio();
            CargarVendedores();
        }
        private void CargarReporteGerente_1()
        {
            
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            // Llama al método de la instancia de la capa de negocios con las fechas
            List<ReporteGrafico> reporteGrafico = cnGerente.ListarReporteGerente_1(fechaDesde, fechaHasta);

            if (reporteGrafico.Count > 0)
            {
               
                var dataSource = reporteGrafico.Select(rg => new
                {
                    Vendedor = rg.Vendedor,
                    Importe_Total = rg.SubTotal
                })
                .OrderByDescending(x => x.Importe_Total)
                .ToList();

                dgvReporteGerente.DataSource = dataSource;

                chartGerente.Series.Clear();

                // Crear una nueva serie para el gráfico
                var series = chartGerente.Series.Add("Importe Total");
                
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                series.Label = "#PERCENT{P0}";
                series.LegendText = "#VALX";

                

                
                foreach (var item in reporteGrafico)
                {
                    series.Points.AddXY(item.Vendedor, item.SubTotal);
                }

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
            
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

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

                dgvReporteGerente.DataSource = dataSource;

                chartGerente.Series.Clear();

                var series = chartGerente.Series.Add("Cantidad");
                
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                series.Label = "#PERCENT{P0}";
                series.LegendText = "#VALX";

                

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
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            List<ReporteGrafico> reporteGrafico = cnGerente.ListarReporteGerente_3(fechaDesde, fechaHasta);

            if (reporteGrafico.Count > 0)
            {
                var dataSource = reporteGrafico.Select(rg => new
                {
                    Producto = rg.Producto,
                    Ventas_Totales = rg.SubTotal
                })
                .OrderByDescending(x => x.Ventas_Totales)
                .ToList();

                dgvReporteGerente.DataSource = dataSource;

                chartGerente.Series.Clear();

                var series = chartGerente.Series.Add("Ventas Totales");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                series.Label = "#PERCENT{P0}";
                series.LegendText = "#VALX";

                foreach (var item in reporteGrafico)
                {
                    series.Points.AddXY(item.Producto, item.SubTotal);
                }

                chartGerente.Titles.Clear();
                chartGerente.Titles.Add("Productos más rentables");
            }
            else
            {
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chartGerente.Series.Clear();
            }
        }

        private void CargarReporteGerente_4()
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            List<Venta> ventas = cnGerente.ListarReporteGerente_4(fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                var data = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Factura = dv.oVenta.idVenta,
                    Vendedor = v.oUsuario.nombreUsuario,
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    Subtotal = dv.subTotal
                })).ToList();

                dgvReporteGerente.DataSource = data;

                
                double totalSubtotal = data.Sum(d => d.Subtotal);

                
                lblTotalSubtotal.Text = $"Total Subtotal: {totalSubtotal:C}";
            }
            else
            {
                dgvReporteGerente.DataSource = null;
                lblTotalSubtotal.Text = "Total Subtotal: $0.00";
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void CargarReporteGerente_5()
        {

            List<Venta> ventas = cnGerente.ListarReporteGerente_5();

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                dgvReporteGerente.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Producto = dv.oProducto.nombre,
                    Detalle = dv.oProducto.detalle,
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
               
                if (cmbReporteGerente.SelectedIndex >= 0)
                {
                    
                    CN_Usuario cnUsuario = new CN_Usuario();

                    
                    string mensaje = string.Empty;

                   
                    if (cmbReporteGerente.SelectedIndex == 0) // "Mejor Vendedor"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_1();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;
                        lblTotalSubtotal.Visible = false;

                    }
                    else if (cmbReporteGerente.SelectedIndex == 1) // "Productos más vendidos"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_2();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;
                        lblTotalSubtotal.Visible = false;
                    }
                    else if (cmbReporteGerente.SelectedIndex == 2) // "Productos más rentables"
                    {
                        RestaurarPanel();
                        CargarReporteGerente_3();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;
                        lblTotalSubtotal.Visible = false;

                    }

                    else if (cmbReporteGerente.SelectedIndex == 3) //ventas totales

                    {
                        ExpandirPanel();
                        CargarReporteGerente_4();
                        cmbVendedorSelector.Visible= true;
                        cmbVendedorSelector.SelectedIndex = -1;
                        lblTotalSubtotal.Visible=true;
                        lblVendedorSelector.Visible = true;
                    }
                    else if (cmbReporteGerente.SelectedIndex == 4) // "Productos proximos al punto de pedido"

                    {
                        
                        ExpandirPanel();
                        CargarReporteGerente_5();
                        cmbVendedorSelector.Visible = false;
                        lblVendedorSelector.Visible = false;
                        lblTotalSubtotal.Visible = false;

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
            chartGerente.Location = new System.Drawing.Point(453, 195);
        }
        private void CargarVendedores()
        {
            List<Usuario> listaVendores = objCN_Usuario.ListarUsuarios();

            
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

                var data = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Factura = dv.oVenta.idVenta,
                    Vendedor = v.oUsuario.nombreUsuario,
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    Subtotal = dv.subTotal
                })).ToList();
                dgvReporteGerente.DataSource = data;

                
                double totalSubtotal = data.Sum(d => d.Subtotal);

                
                lblTotalSubtotal.Text = $"Total Subtotal: {totalSubtotal:C}";
            }
            else
            {
                dgvReporteGerente.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if(dgvReporteGerente.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos que exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvReporteGerente.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvReporteGerente.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        
                        object[] values = new object[dgvReporteGerente.Columns.Count];

                        
                        for (int i = 0; i < dgvReporteGerente.Columns.Count; i++)
                        {
                            values[i] = row.Cells[i].Value?.ToString() ?? ""; 
                        }

                       
                        dt.Rows.Add(values);
                    }
                }

                SaveFileDialog guardarExcel = new SaveFileDialog();
                guardarExcel.FileName = string.Format("Reporte " + cmbReporteGerente.Text + "_{0}.xlsx", DateTime.Now.ToString("yyyyMMdd"));
                guardarExcel.Filter = "Excel  File | *.xlsx";

                if(guardarExcel.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();

                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(guardarExcel.FileName);

                        MessageBox.Show("Reporte generado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }
    }
}
