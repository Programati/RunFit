using CapaDeEntidades;
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
    public partial class frmFactura : Form
    {
        private static Venta _factura = null;
        DateTime fechaHoy = DateTime.Today;
        public frmFactura()
        {
            InitializeComponent();
        }
        public frmFactura(Venta Factura)
        {
            _factura = Factura;
            InitializeComponent();
        }

        private void btnCerrarFactura_Click(object sender, EventArgs e)
        {
            _factura = null;
            this.Close();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            lblIdFactura.Text = "COD-" + _factura.idVenta.ToString();
            lblVendedorFactura.Text = _factura.oUsuario.nombreUsuario;
            lblFechaFactura.Text = _factura.fechaFactura;

            lblNyApCliente.Text = _factura.oCliente.oPersona.apellido + " " + _factura.oCliente.oPersona.nombre;
            lblDniCliente.Text = _factura.oCliente.oPersona.dni;
            lblTelefonoCliente.Text = _factura.oCliente.oPersona.telefono;
            lblCorreoCliente.Text = _factura.oCliente.oPersona.email;

            lblDireccionCliente.Text = "";
            lblDireccionCliente.Text += _factura.oCliente.calle + " ";

            lblDireccionCliente.Text += _factura.oCliente.altura != "" ? _factura.oCliente.altura + " " : "";
            lblDireccionCliente.Text += _factura.oCliente.manzana != "" ? "Mz" + _factura.oCliente.manzana + " Cs" + _factura.oCliente.manzana + " " : "";

            lblDireccionCliente.Text += _factura.oCliente.piso != "" ? "Piso" + _factura.oCliente.piso + " Departamento" + _factura.oCliente.departamento : "";

            lblTotalFactura.Text = "$" + _factura.importeTotal.ToString();

            foreach (var item in _factura.oDetalleVenta)
            {

                dgvDetalleFacturaFinal.Rows.Add(new object[]
                {
                        item.cantidad.ToString(),
                        item.oProducto.nombre + " " + item.oProducto.detalle,
                        item.oProducto.precioVenta.ToString(),
                        item.subTotal.ToString()
                });
            }
        }
    }
}
