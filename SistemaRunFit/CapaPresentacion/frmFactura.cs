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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog _GuardarPDF = new SaveFileDialog();
            _GuardarPDF.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginahtml_texto = Properties.Resources.plantilla.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@NUMFACTURA", lblIdFactura.Text);
            paginahtml_texto = paginahtml_texto.Replace("@VENDEDOR", lblVendedorFactura.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", lblFechaFactura.Text);


            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", lblNyApCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@DIRECCION", lblDireccionCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@DNI", lblDniCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", lblTelefonoCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@EMAIL", lblCorreoCliente.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetalleFacturaFinal.Rows)
            {
                filas += "<tr>";
                
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["ImporteTotal"].Value.ToString() + "</td>";

                filas += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", lblTotalFactura.Text);

            if (_GuardarPDF.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(_GuardarPDF.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Factura guardada correctamente!");
                }
            }
            
        }
    }
}
