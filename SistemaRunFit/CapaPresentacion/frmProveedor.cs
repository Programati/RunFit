using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtProveedor.Clear();
            txtCuitProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtProveedor.Focus();
        }
        private void LimpiarPorProveedor()
        {
            cmbBuscarPorProveedor.SelectedIndex = -1;
            txtBuscarPorProveedor.Clear();
        }

        private void btnLimpiarPorProveedor_Click(object sender, EventArgs e)
        {
            LimpiarPorProveedor();
        }

        private void btnLimpiarCamposUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private bool camposValidados()
        {

            bool proveedorVacio = string.IsNullOrEmpty(txtProveedor.Text);
            bool cuitVacio = string.IsNullOrEmpty(txtCuitProveedor.Text);
            bool descripcionVacio = string.IsNullOrEmpty(txtDescripcionProveedor.Text);

            if (proveedorVacio || cuitVacio || descripcionVacio)
            {
                MessageBox.Show("Debe completar todos los campos!", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGuardarProveedor_Click(object sender, EventArgs e)
        {
            if (camposValidados())
            {
                string proveedor = txtProveedor.Text;

                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al proveedor {proveedor} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Datos guardados exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    int n = dgvListaProveedor.Rows.Add();
                    //Colocamos la información en el renglon creado
                    dgvListaProveedor.Rows[n].Cells[2].Value = txtCuitProveedor.Text;
                    dgvListaProveedor.Rows[n].Cells[3].Value = txtProveedor.Text;
                    dgvListaProveedor.Rows[n].Cells[4].Value = txtDescripcionProveedor.Text;
                    //Borrar cuando se integre la BD
                    LimpiarCampos();


                }
            }
        }
    }
}
