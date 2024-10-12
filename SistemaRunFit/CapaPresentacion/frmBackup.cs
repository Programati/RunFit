using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        CN_Backup backup = new CN_Backup();
        private Label lblUltimaCopia;
        // Campo privado que almacena la referencia al formulario principal 'Inicio'
        private Inicio _inicio;

        // Constructor que inicializa el formulario y desactiva el panel del menú en 'Inicio'
        public frmBackup(Inicio inicio)
        {
            _inicio = inicio; 
            InitializeComponent(); 
            _inicio.PnlContenedorMenu.Enabled = false; 
            lblUltimoBackup = new Label();
            lblUltima.Text = backup.ObtenerUltimaFechaBackup();
        }

        // Evento del botón que regresa al menú de 'Marca' o al menú principal
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            // Si la referencia a 'Inicio' es válida
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel del menú en 'Inicio'
                _inicio.MostrarImagenFondo(); // Muestra nuevamente la imagen de fondo en 'Inicio'
            }
            this.Close(); // Cierra el formulario actual de 'Backup'
        }

        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            CN_Backup backup = new CN_Backup();
            backup.Backup(lblUltimoBackup); // Actualiza el label dentro del método
            lblUltima.Text = backup.ObtenerUltimaFechaBackup();
        }

    }
}
