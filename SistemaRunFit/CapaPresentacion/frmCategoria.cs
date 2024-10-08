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
           
        }
        private void Listar_Categorias()
        {
            List<Categoria> ListaCategoria = new CN_Categoria().ListarCategorias();
            foreach (Categoria item in ListaCategoria)
            {
                dgvCategoria.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fecha_baja == null ? CapaPresentacion.Properties.Resources.eliminar_categoria: CapaPresentacion.Properties.Resources.activar_categoria, // Icono de acción
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
        private void LimpiarCampos()
        {
            txtCategoria.Clear();
        }
        // Evento que se ejecuta al hacer clic en el botón btnGuardarCategoria.
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            string MensajeCategoria = string.Empty; // Mensaje para el resultado del proceso de usuario
            int IdCategoriaGenerada = 0; // ID de persona generada
            
           // bool VerdadUsuarioGenerado = false; // Bandera para verificar si el usuario fue generado correctamente
            string mensajeConfirmacion = "¿Desea agregar al"; // Mensaje de confirmación inicial
            

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
                    Categoria CategoriaNueva = new Categoria()
                    {
                        idCategoria = txtIdCategoria.Text != "" ? Convert.ToInt32(txtIdCategoria.Text) : IdCategoriaGenerada,
                        nombre_categoria = txtCategoria.Text,
                        
                    };

                    // Si hay un ID de persona, se edita
                    if (txtIdCategoria.Text != "")
                    {
                       // VerdadPersonaGenerada = new CN_Persona().Editar(PersonaNueva, out MensajePersona);
                       // IdPersonaGenerada = PersonaNueva.idPersona; // Actualiza el ID de persona generada
                    }
                    else
                    {
                        IdCategoriaGenerada = new CN_Categoria().Registrar(CategoriaNueva, out MensajeCategoria);
                    }
                    if (IdCategoriaGenerada != 0 )
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos(); 
                    }
                    else
                    {
                        // Muestra mensajes de error si no se guardaron los datos
                        MessageBox.Show(MensajeCategoria );
                    }
                    
                    // Borrar cuando se integre la BD
                    txtCategoria.Clear();
                    dgvCategoria.Rows.Clear();
                    Listar_Categorias();
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
            Listar_Categorias();
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

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna seleccionada es la de "Accion"
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    string mensaje = string.Empty; // Mensaje para la acción
                    Categoria CategoriaEliminar = new Categoria() // Crea un objeto Usuario para la acción
                    {
                        idCategoria = (int)dgvCategoria.Rows[n].Cells["ID_Categoria"].Value // Asigna el ID del usuario
                    };

                    string estadoActual = dgvCategoria.Rows[n].Cells["Estado"].Value.ToString(); 
                    string categoria = dgvCategoria.Rows[n].Cells["Categoria"].Value.ToString(); 

                    // Si la categoria está inactiva, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR la categoria {categoria}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para activar la categoria
                            bool respuesta = new CN_Categoria().Eliminar(CategoriaEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado de la categoria
                                dgvCategoria.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvCategoria.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black; // Cambia el color a negro
                                dgvCategoria.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black; // Cambia el color de selección a negro

                                MessageBox.Show("Categoria " + categoria + " activada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si la categoria está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR la categoria {categoria}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para desactivar la categoria
                            bool respuesta = new CN_Categoria().Eliminar(CategoriaEliminar, out mensaje);

                            // Actualizar el estado del usuario
                            dgvCategoria.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvCategoria.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red; // Cambia el color a rojo
                            dgvCategoria.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red; // Cambia el color de selección a rojo

                            MessageBox.Show("Categoria " + categoria + " desactivada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvCategoria.Rows.Clear(); // Limpia el DataGridView
                    Listar_Categorias(); // Llama a la función para volver a cargar los datos
                }
            }
        }
    }
    }



