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
    public partial class frmBackup : Form
    {
        private Inicio _inicio;
        public frmBackup(Inicio inicioform)
        {
            _inicio = inicioform;
            InitializeComponent();
            _inicio.PnlContenedorMenu.Enabled = false;
            
        }

        private void btnVolverUser_Click(object sender, EventArgs e)
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
