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
        // Campo privado que almacena la referencia al formulario principal 'Inicio'
        Inicio _inicio;

        // Constructor que inicializa el formulario y desactiva el panel del menú en 'Inicio'
        public frmBuscarVenta(Inicio inicio)
        {
            _inicio = inicio; // Almacena la referencia al formulario 'Inicio'
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en el formulario principal
        }

        // Evento que se ejecuta cuando el formulario se carga
        private void frmBuscarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarUser.Focus(); // Establece el foco en el campo de búsqueda de usuario al cargar el formulario
        }

        // Evento del botón que regresa al menú principal de 'Marca'
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            // Si hay una referencia válida al formulario 'Inicio'
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel del menú en 'Inicio'
                _inicio.MostrarImagenFondo(); // Muestra nuevamente la imagen de fondo en 'Inicio'
            }
            this.Close(); // Cierra el formulario actual de búsqueda de ventas
        }
    }

}
