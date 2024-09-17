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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmProducto_Load);
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Focus();
        }
        private void btnVolverUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarContenedorProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            cmbMarcaProducto.SelectedIndex = -1;
            cmbCategoriaProducto.SelectedIndex = -1;
            cmbProveedorProducto.SelectedIndex = -1;
            txtDetalleProducto.Clear();
            txtPrecioCompraProducto.Clear();
            txtPrecioVentaProducto.Clear();
            txtStockProducto.Clear();
            txtStockMinimoProducto.Clear();
            pbImagenProducto.Image = CapaPresentacion.Properties.Resources.fotoProducto;
            txtNombreProducto.Focus();
        }

        private void txtPrecioCompraProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioCompraProducto.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVentaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',') || (e.KeyChar == ',' && txtPrecioVentaProducto.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSeleccionarImagenProducto_Click(object sender, EventArgs e)
        {
            // Crear y configurar el OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar una imagen";

            // Mostrar el diálogo y comprobar si se seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                string rutaImagen = openFileDialog.FileName;
                pbImagenProducto.Image = Image.FromFile(rutaImagen);
            }
        }
    }
}
