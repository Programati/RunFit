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
    public partial class frmMarca : Form
    {
        Inicio _inicio;
        public frmMarca(Inicio inicio)
        {
            InitializeComponent();
            _inicio = inicio;
            _inicio.PnlContenedorMenu.Enabled = false;
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            txtBuscarMarca.Focus();
        }

        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactivar el panel en Inicio
                _inicio.MostrarImagenFondo(); // Mostrar la imagen de fondo
            }
            this.Close(); // Cierra el formulario actual  
        }
    }
}
