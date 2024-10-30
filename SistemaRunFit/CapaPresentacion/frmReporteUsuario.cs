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
            CargarReporteUsuario(idUsuarioActual); // Carga el reporte usando el id del usuario
            grbDetalleVta.Text = $"Detalles de ventas del vendedor: {usuario.nombreUsuario.ToUpper()}";
            cmbReporteUsuario.SelectedIndexChanged += cmbReporteUsuario_SelectedIndexChanged;
        }

        private void CargarReporteUsuario(int idUsuario)
        {
            string mensaje; // Variable para almacenar el mensaje de salida
                            // Llama al método de la instancia de CN_Usuario
            List<Venta> ventas = cnUsuario.ListarReporteUsuario(idUsuario, out mensaje);

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
                // Muestra el mensaje si no hay ventas
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarReporteUsuario2(int idUsuario)
        {
            string mensaje; // Variable para almacenar el mensaje de salida
                            // Llama al método de la instancia de CN_Usuario
            List<Venta> ventas = cnUsuario.ListarReporteUsuario2(idUsuario, out mensaje);

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
                // Muestra el mensaje si no hay ventas
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CargarReporteUsuario3(int idUsuario)
        {
            string mensaje; // Variable para almacenar el mensaje de salida
                            // Llama al método de la instancia de CN_Usuario
            List<Venta> ventas = cnUsuario.ListarReporteUsuario3(idUsuario, out mensaje);

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
                // Muestra el mensaje si no hay ventas
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cmbReporteUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica si se ha seleccionado una opción válida en el ComboBox
                if (cmbReporteUsuario.SelectedIndex >= 0)
                {
                    // Instancia la capa de negocios
                    CN_Usuario cnUsuario = new CN_Usuario();

                    // Variable para recibir el mensaje desde la capa de negocio
                    string mensaje = string.Empty;

                    // Determina qué reporte generar según la selección en el ComboBox
                    if (cmbReporteUsuario.SelectedIndex == 0) // "Ventas cronológico"
                    {
                        CargarReporteUsuario(idUsuarioActual);

                    }
                    else if (cmbReporteUsuario.SelectedIndex == 1) // "Productos más vendidos por unidad"
                    {
                        CargarReporteUsuario2(idUsuarioActual);
                    }
                    else if (cmbReporteUsuario.SelectedIndex == 2) // "Productos más vendidos en dinero"
                    {
                        CargarReporteUsuario3(idUsuarioActual);

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

    




    


