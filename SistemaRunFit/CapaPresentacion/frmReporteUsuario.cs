using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using Guna.UI.WinForms;
using CapaDeEntidades;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    public partial class frmReporteUsuario : Form
    {
        private CN_Usuario cnUsuario = new CN_Usuario();
        private CN_Usuario negocioUsuario;

        private int idUsuarioActual;
        private Usuario usuarioActual;
        


        public frmReporteUsuario(Usuario usuario)
        {
            InitializeComponent();
            idUsuarioActual = usuario.idUsuario; // Almacena el id del usuario
            //CargarReporteUsuario(idUsuarioActual,fechaDesde,fechaHasta); // Carga el reporte usando el id del usuario
            grbDetalleVta.Text = $"Detalles de ventas del vendedor: {usuario.nombreUsuario.ToUpper()}";
           
        }

        private void CargarReporteUsuario(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = cnUsuario.ListarReporteUsuario(idUsuario, fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                dgvReporteUsuario.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    PrecioUnitario = dv.oProducto.precioVenta,
                    Subtotal = dv.subTotal
                })).ToList();
            }
            else
            {
                // Limpiar el DataGridView y mostrar mensaje solo si no hay ventas
                dgvReporteUsuario.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarReporteUsuario2(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            
            List<Venta> ventas = cnUsuario.ListarReporteUsuario2(idUsuario, fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                dgvReporteUsuario.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    PrecioUnitario = dv.oProducto.precioVenta,
                    Subtotal = dv.subTotal
                })).ToList();
            }
            else
            {
                dgvReporteUsuario.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
        }
        private void CargarReporteUsuario3(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            
            List<Venta> ventas = cnUsuario.ListarReporteUsuario3(idUsuario, fechaDesde, fechaHasta);

            if (ventas.Count > 0)
            {
                // Llena el DataGridView con los datos de ventas
                dgvReporteUsuario.DataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Fecha = v.fechaFactura,
                    Cantidad = dv.cantidad,
                    Producto = dv.oProducto.nombre,
                    PrecioUnitario = dv.oProducto.precioVenta,
                    Subtotal = dv.subTotal
                })).ToList();
            }
            else
            {
                dgvReporteUsuario.DataSource = null;
                MessageBox.Show("NO HAY VENTAS EN EL PERIODO SELECCIONADO", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        
        private void cmbReporteUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                DateTime fechaDesde = dtpFechaDesdeUsuario.Value;
                DateTime fechaHasta = dtpFechaHastaUsuario.Value;
               
                if (cmbReporteUsuario.SelectedIndex >= 0)
                {
                    
                    if (cmbReporteUsuario.SelectedIndex == 0) // "Ventas cronológico"
                    {
                        CargarReporteUsuario(idUsuarioActual,fechaDesde,fechaHasta);

                    }
                    else if (cmbReporteUsuario.SelectedIndex == 1) // "Productos más vendidos por unidad"
                    {
                        CargarReporteUsuario2(idUsuarioActual, fechaDesde, fechaHasta);
                    }
                    else if (cmbReporteUsuario.SelectedIndex == 2) // "Productos más vendidos en dinero"
                    {
                        CargarReporteUsuario3(idUsuarioActual, fechaDesde, fechaHasta);

                    }
                }
                
            
           
        }
    }

    }




    




    


