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
    public partial class frmBuscarVenta : Form
    {
        public frmBuscarVenta()
        {
            InitializeComponent();
           
        }
        

        private void frmBuscarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarUser.Focus();
        }
    }
}
