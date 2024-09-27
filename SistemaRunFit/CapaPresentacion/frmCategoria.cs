using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        // Variable para almacenar la referencia del formulario Inicio.
        Inicio _inicio;

        // Constructor de frmCategoria que recibe una instancia de Inicio.
        public frmCategoria(Inicio inicio)
        {
            InitializeComponent(); // Inicializa los componentes visuales del formulario.
            _inicio = inicio; // Guarda la referencia del formulario Inicio.
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en el formulario Inicio.
        }

        // Evento que se ejecuta al hacer clic en el botón btnGuardarCategoria.
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de texto txtCategoria no está vacío.
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                // Muestra un cuadro de diálogo para confirmar la acción de agregar la categoría.
                var confirmacion = MessageBox.Show(
                    $"Desea agregar la categoria {txtCategoria.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma, se procede a guardar los datos.
                if (confirmacion == DialogResult.Yes)
                {
                    // Aquí puedes agregar el código para guardar los datos
                    MessageBox.Show("Los datos se guardaron exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Momentáneamente cargamos al DataGrid
                    // Adicionamos un nuevo renglón
                    int n = dgvCategoria.Rows.Add();
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    // Colocamos la información en el renglón creado
                    dgvCategoria.Rows[n].Cells[2].Value = n + 1; // Asigna el número de renglón
                    dgvCategoria.Rows[n].Cells[3].Value = textInfo.ToTitleCase(txtCategoria.Text.ToLower()); // Formatea el nombre de la categoría en título

                    // Borrar cuando se integre la BD
                    txtCategoria.Clear(); // Limpia el campo de texto de categoría.
                    txtCategoria.Focus(); // Establece el foco en el campo de texto.
                }
            }
            else
            {
                // Muestra un mensaje de error si la categoría está vacía.
                MessageBox.Show("Categoria vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento que se ejecuta al presionar una tecla en el campo txtCategoria.
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, controles y espacios en blanco.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Si se ingresa un carácter no válido, se maneja el evento.
            }
        }

        // Evento que se ejecuta al presionar una tecla en el campo txtBuscarCategoria.
        private void txtBuscarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, controles y espacios en blanco.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Si se ingresa un carácter no válido, se maneja el evento.
            }
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            txtCategoria.Focus(); // Establece el foco en el campo de texto txtCategoria al cargar el formulario.
        }

        // Evento que se ejecuta al hacer clic en el botón btnMenuMarca.
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            if (_inicio != null) // Verifica si la referencia de _inicio no es nula.
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel en el formulario Inicio.
                _inicio.MostrarImagenFondo(); // Muestra la imagen de fondo en el formulario Inicio.
            }
            this.Close(); // Cierra el formulario actual.
        }
    }


}
