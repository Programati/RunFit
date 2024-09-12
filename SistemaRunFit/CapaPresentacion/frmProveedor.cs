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
            txtRSocialProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtCuitProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtEmailProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtRSocialProveedor.Focus();
        }
        
        private void btnLimpiarCamposProvedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

