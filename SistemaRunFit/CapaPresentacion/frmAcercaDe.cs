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
        // Constructor del formulario frmAcercaDe. Inicializa los componentes visuales del formulario.
        public frmAcercaDe()
        {
            InitializeComponent(); // Método que carga y configura los controles del formulario.
        }

        // Evento que se ejecuta cuando el mouse se mueve sobre el control lblSoftAcerca.
        private void lblSoftAcerca_MouseMove(object sender, MouseEventArgs e)
        {
            // Cambia el color del texto a rojo y el fondo a CadetBlue cuando el mouse está sobre el label.
            lblSoftAcerca.ForeColor = Color.Red;
            lblSoftAcerca.BackColor = Color.CadetBlue;
        }

        // Evento que se ejecuta cuando el mouse deja el control lblSoftAcerca.
        private void lblSoftAcerca_MouseLeave(object sender, EventArgs e)
        {
            // Cambia el color del texto a negro y el fondo a transparente cuando el mouse se aleja del label.
            lblSoftAcerca.ForeColor = Color.Black;
            lblSoftAcerca.BackColor = Color.Transparent;
        }
    }

}
