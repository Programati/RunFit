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
        // Variable privada que almacena la referencia al formulario principal (Inicio)
        Inicio _inicio;

        // Constructor de la clase frmMarca
        public frmMarca(Inicio inicio)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio = inicio; // Asigna la referencia del formulario principal a la variable _inicio
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel de menú en el formulario principal
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmMarca_Load(object sender, EventArgs e)
        {
            txtBuscarMarca.Focus(); // Pone el foco en el TextBox de búsqueda de marcas
        }

        // Evento que se ejecuta al hacer clic en el botón de menú de marcas
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            // Verifica si la variable _inicio no es nula
            if (_inicio != null)
            {
                // Reactiva el panel en el formulario de inicio
                _inicio.PnlContenedorMenu.Enabled = true;
                // Muestra la imagen de fondo en el formulario de inicio
                _inicio.MostrarImagenFondo();
            }
            // Cierra el formulario actual
            this.Close();
        }
    }

}
