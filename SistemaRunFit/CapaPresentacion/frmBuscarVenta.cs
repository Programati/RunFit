using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades;
using CapaDeNegocios;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmBuscarVenta : Form
    {
        Inicio _inicio;

        public frmBuscarVenta(Inicio inicio)
        {
            _inicio = inicio;
            InitializeComponent();
            _inicio.PnlContenedorMenu.Enabled = false;
        }

        private void frmBuscarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarFactura.Focus();
            ListarUltimasVentas();
        }

        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true;
                _inicio.MostrarImagenFondo();
            }
            this.Close();
        }

        private void ListarUltimasVentas()
        {
            List<Venta> _ListaVentas = new CN_Venta().UltimasVentas();
            foreach (Venta item in _ListaVentas)
            {
                dgvVentas.Rows.Add(new object[] {
                    item.idVenta,
                    item.fechaFactura,
                    item.oCliente.oPersona.apellido+" "+item.oCliente.oPersona.nombre,
                    "$"+item.importeTotal,
                    item.oUsuario.nombreUsuario,
                    CapaPresentacion.Properties.Resources.ver
                });
            }
        }

        private void btnBuscarBuscarVta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarFactura.Text))
            {
                MessageBox.Show("N° Factrua vacia!");
                return;
            }

            int _NumeroFactura;

            if (int.TryParse(txtBuscarFactura.Text, out _NumeroFactura))
            {
                Venta factura = new CN_Venta().ObtenerVentaPorId(_NumeroFactura);
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
                MessageBox.Show("Por favor, ingresa un número de Factura válido!");
            }

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "Ver")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    int _FacturaElegida = Convert.ToInt32(dgvVentas.Rows[n].Cells["Factura"].Value);
                    Venta factura = new CN_Venta().ObtenerVentaPorId(_FacturaElegida);
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
            }
        }

        private void btnLimpiarBuscarVta_Click(object sender, EventArgs e)
        {
            txtBuscarFactura.Clear();
        }
    }

}
