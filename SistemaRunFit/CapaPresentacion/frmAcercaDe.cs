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
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void lblSoftAcerca_MouseMove(object sender, MouseEventArgs e)
        {
            lblSoftAcerca.ForeColor = Color.Red;
            lblSoftAcerca.BackColor = Color.CadetBlue;
        }

        private void lblSoftAcerca_MouseLeave(object sender, EventArgs e)
        {
            lblSoftAcerca.ForeColor = Color.Black;
            lblSoftAcerca.BackColor = Color.Transparent;
        }
    }
}
