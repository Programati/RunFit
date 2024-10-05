using CapaDeEntidades;
using CapaDeNegocios;
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
        private void Listar_Marcas()
        {
            List<Marca> ListaMarca = new CN_Marca().ListarMarcas();
            foreach (Marca item in ListaMarca)
            {
                dgvMarca.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_user: CapaPresentacion.Properties.Resources.activar_user, // Icono de acción
            item.idMarca,
            item.fechaBaja == null ? "Activo" : "Inactivo",
            item.nombre,
           // item.fecha_alta,
            
            
                 });
            }

            // Cambia el color del texto según el estado de la Marca (Activo/Inactivo)
            for (int i = 0; i < dgvMarca.Rows.Count; i++)
            {
                // Obtener el valor de la celda "Estado" en la fila actual
                string estado = dgvMarca.Rows[i].Cells["Estado"].Value.ToString();

                // Cambiar el color tanto para cuando la fila está seleccionada como cuando no lo está
                if (estado == "Activo")
                {
                    // Cambiar el color del texto a negro si es "Activo"
                    dgvMarca.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvMarca.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black; // También cuando está seleccionada
                }
                else if (estado == "Inactivo")
                {
                    // Cambiar el color del texto a rojo si es "Inactivo"
                    dgvMarca.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvMarca.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red; // También cuando está seleccionada
                }
            }
        }
        // Evento que se ejecuta al cargar el formulario
        private void frmMarca_Load(object sender, EventArgs e)
        {
            txtBuscarMarca.Focus(); // Pone el foco en el TextBox de búsqueda de marcas
            Listar_Marcas();
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
        private void LimpiarCampos()
        {
            txtMarca.Clear();
        }
        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            string MensajeMarca = string.Empty; // Mensaje para el resultado del proceso de usuario
            int IdMarcaGenerada = 0; // ID de persona generada

            // bool VerdadUsuarioGenerado = false; // Bandera para verificar si el usuario fue generado correctamente
            string mensajeConfirmacion = "¿Desea agregar al"; // Mensaje de confirmación inicial


            // Verifica si el campo de texto txtCategoria no está vacío.
            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                // Muestra un cuadro de diálogo para confirmar la acción de agregar la categoría.
                var confirmacion = MessageBox.Show(
                    $"Desea agregar la categoria {txtMarca.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma, se procede a guardar los datos.
                if (confirmacion == DialogResult.Yes)
                {
                    Marca CategoriaNueva = new Marca()
                    {
                         idMarca= txtIdMarca.Text != "" ? Convert.ToInt32(txtMarca.Text) : IdMarcaGenerada,
                        nombre = txtMarca.Text,

                    };

                    // Si hay un ID de persona, se edita
                    if (txtIdMarca.Text != "")
                    {
                        // VerdadPersonaGenerada = new CN_Persona().Editar(PersonaNueva, out MensajePersona);
                        // IdPersonaGenerada = PersonaNueva.idPersona; // Actualiza el ID de persona generada
                    }
                    else
                    {
                        IdMarcaGenerada = new CN_Marca().Registrar(CategoriaNueva, out MensajeMarca);
                    }
                    if (IdMarcaGenerada != 0)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                    else
                    {
                        // Muestra mensajes de error si no se guardaron los datos
                        MessageBox.Show(MensajeMarca);
                    }

                    // Borrar cuando se integre la BD
                    txtMarca.Clear();
                    dgvMarca.Rows.Clear();
                    Listar_Marcas();
                     txtMarca.Focus(); 
                }
            }
            else
            {
                // Muestra un mensaje de error si la categoría está vacía.
                MessageBox.Show("Categoria vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
