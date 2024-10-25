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
            CargarReporteGerente_3();
        }

        private void CargarReporteGerente_1()
        {
            // Llama al método de la instancia de la capa de negocios
            List<Venta> ventas = cnGerente.ListarReporteGerente_1();

            if (ventas.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Vendedor = v.oUsuario != null ? v.oUsuario.nombreUsuario : "Sin vendedor", // Asegúrate de tener la propiedad correcta
                    Nombre_Producto = dv.oProducto != null ? dv.oProducto.nombre : "Sin producto", // Nombre del producto
                    Cantidad_Total = dv.cantidad // Cantidad total vendida
                })).OrderByDescending(x => x.Cantidad_Total).ToList(); // Ordenar por cantidad total

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;
            }
            else
            {
                // Muestra un mensaje si no hay ventas
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarReporteGerente_2()
        {
            // Llama al método de la instancia de la capa de negocios
            List<Venta> ventas = cnGerente.ListarReporteGerente_2();

            if (ventas.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    
                    Nombre_Producto = dv.oProducto != null ? dv.oProducto.nombre : "Sin producto", // Nombre del producto
                    Cantidad_Total = dv.cantidad // Cantidad total vendida
                })).OrderByDescending(x => x.Cantidad_Total).ToList(); // Ordenar por cantidad total

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;
            }
            else
            {
                // Muestra un mensaje si no hay ventas
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarReporteGerente_3()
        {
            // Llama al método de la instancia de la capa de negocios
            List<Venta> ventas = cnGerente.ListarReporteGerente_3();

            if (ventas.Count > 0)
            {
                // Crear una lista para almacenar los datos que se mostrarán en el DataGridView
                var dataSource = ventas.SelectMany(v => v.oDetalleVenta.Select(dv => new
                {
                    Vendedor = v.oUsuario != null ? v.oUsuario.nombreUsuario : "Sin vendedor", // Asegúrate de tener la propiedad correcta
                    Nombre_Producto = dv.oProducto != null ? dv.oProducto.nombre : "Sin producto", // Nombre del producto
                    Cantidad_Total = dv.cantidad // Cantidad total vendida
                })).OrderByDescending(x => x.Cantidad_Total).ToList(); // Ordenar por cantidad total

                // Asignar la lista resultante como origen de datos del DataGridView
                dgvReporteGerente.DataSource = dataSource;
            }
            else
            {
                // Muestra un mensaje si no hay ventas
                MessageBox.Show("Atención", "No se encontraron ventas para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
