using CapaDeEntidades;
using CapaDeNegocios;
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
            InitializeComponent(); 
            _inicio = inicio; 
            _inicio.PnlContenedorMenu.Enabled = false; 
            Listar_Categorias();
        }
        private void Listar_Categorias()
        {
            List<Categoria> ListaCategoria = new CN_Categoria().ListarCategorias();
            foreach (Categoria item in ListaCategoria)
            {
                dgvCategoria.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fecha_baja == null ? CapaPresentacion.Properties.Resources.eliminar_user: CapaPresentacion.Properties.Resources.activar_user, // Icono de acción
            item.idCategoria,
            item.fecha_baja == null ? "Activo" : "Inactivo", 
            item.nombre_categoria,
           // item.fecha_alta,
            
            
                 });
            }

            // Cambia el color del texto según el estado de la categoria (Activo/Inactivo)
            for (int i = 0; i < dgvCategoria.Rows.Count; i++)
            {
                // Obtener el valor de la celda "Estado" en la fila actual
                string estado = dgvCategoria.Rows[i].Cells["Estado"].Value.ToString();

                // Cambiar el color tanto para cuando la fila está seleccionada como cuando no lo está
                if (estado == "Activo")
                {
                    // Cambiar el color del texto a negro si es "Activo"
                    dgvCategoria.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvCategoria.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black; // También cuando está seleccionada
                }
                else if (estado == "Inactivo")
                {
                    // Cambiar el color del texto a rojo si es "Inactivo"
                    dgvCategoria.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvCategoria.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red; // También cuando está seleccionada
                }
            }
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
                    dgvCategoria.Rows[n].Cells[3].Value = textInfo.ToTitleCase(txtCategoria.Text.ToLower()); 

                    // Borrar cuando se integre la BD
                    txtCategoria.Clear(); 
                    txtCategoria.Focus(); 
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
                e.Handled = true; 
            }
        }

        // Evento que se ejecuta al presionar una tecla en el campo txtBuscarCategoria.
        private void txtBuscarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, controles y espacios en blanco.
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            txtCategoria.Focus(); 
        }

        // Evento que se ejecuta al hacer clic en el botón btnMenuMarca.
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            if (_inicio != null) 
            {
                _inicio.PnlContenedorMenu.Enabled = true; 
                _inicio.MostrarImagenFondo(); 
            }
            this.Close(); 
        }
    }


}
