using System;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CapaPresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        private Inicio _inicio; // Variable para almacenar la referencia del formulario Inicio

        // Constructor del formulario para registrar una venta, recibe como parámetro el formulario Inicio
        public frmRegistrarVenta(Inicio inicioForm)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio = inicioForm; // Asigna la referencia del formulario Inicio a la variable _inicio
            this.Load += new EventHandler(frmRegistrarVenta_Load); // Asocia el evento de carga del formulario con el método frmRegistrarVenta_Load
        }

        // Evento que se ejecuta al cargar el formulario
        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            txtBuscarDniVta.Focus(); // Pone el foco en el TextBox para buscar el DNI al cargar el formulario
        }

        // Evento que se ejecuta al hacer clic en el botón "Buscar Cliente"
        private void btnBuscarClteVta_Click(object sender, System.EventArgs e)
        {
            // Verifica la longitud del DNI ingresado
            if (txtBuscarDniVta.Text.Length > 8)
            {
                MessageBox.Show("El DNI no puede contener más de 8 dígitos"); 
            }
            if (txtBuscarDniVta.Text.Length < 7)
            {
                MessageBox.Show("El DNI es muy corto"); 
            }
        }

        // Evento que se ejecuta al hacer clic en el botón para limpiar campos de búsqueda
        private void txtLimpiarBuscarPtoVta_Click(object sender, System.EventArgs e)
        {
            // Limpia los campos de texto relacionados con la venta
            txtNomPtoRegVtas.Clear();
            txtBuscarCodigoVta.Clear(); 
            txtCantidadItenVta.Clear(); 
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox para buscar el DNI
        private void txtBuscarDniVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox para buscar el código de venta
        private void txtBuscarCodigoVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al presionar una tecla en el TextBox para la cantidad de ítem
        private void txtCantidadItenVta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito o un control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Si es inválido, se ignora la tecla
            }
        }

        // Evento que se ejecuta al hacer clic en el botón "Confirmar Venta"
        private void btnConfirmarVta_Click(object sender, System.EventArgs e)
        {
            // Aun no realizado
        }

        // Evento que se ejecuta al hacer clic en el botón "Agregar ítem"
        private void btnAgregaritemVta_Click(object sender, System.EventArgs e)
        {
            // Aun no realizado
        }

        // Evento que se ejecuta al hacer clic en el botón "Cancelar"
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            // Si se ha asignado un formulario de inicio
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel de menú en el formulario Inicio
                _inicio.MostrarImagenFondo(); // Muestra la imagen de fondo en el formulario Inicio
            }
            this.Close(); // Cierra el formulario actual
        }

    }
}
