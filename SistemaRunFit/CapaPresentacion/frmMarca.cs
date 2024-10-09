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
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_marca: CapaPresentacion.Properties.Resources.activar_marca, // Icono de acción
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
<<<<<<< HEAD
            string MensajeMarca = string.Empty; // Mensaje para el resultado del proceso de usuario
            int IdMarcaGenerada = 0; // ID de persona generada
            bool VerdadMarcaGenerada = false;
            // bool VerdadUsuarioGenerado = false; // Bandera para verificar si el usuario fue generado correctamente
            string mensajeConfirmacion = "¿Desea agregar al"; // Mensaje de confirmación inicial


            // Verifica si el campo de texto txtCategoria no está vacío.
=======
            string MensajeMarca = string.Empty;
            int IdMarcaGenerada = 0;
            bool VerdadMarcaGenerada = false;
            string mensajeConfirmacion = "¿Desea agregar al";

>>>>>>> 6d736377c4440647d72df7ddc5756a8c894d504c
            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                var confirmacion = MessageBox.Show(
                    $"Desea agregar la categoria {txtMarca.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario confirma, se procede a guardar los datos.
                if (confirmacion == DialogResult.Yes)
                {
                    Marca MarcaNueva = new Marca()
                    {
<<<<<<< HEAD
                        idMarca = txtIdMarca.Text != "" ? Convert.ToInt32(txtIdMarca.Text) : IdMarcaGenerada,
                        nombre = txtMarca.Text.ToString(),
=======
                         idMarca = txtIdMarca.Text != "" ? Convert.ToInt32(txtIdMarca.Text) : IdMarcaGenerada,
                        nombre = txtMarca.Text,
>>>>>>> 6d736377c4440647d72df7ddc5756a8c894d504c

                    };

                    if (txtIdMarca.Text != "")
                    {
                        VerdadMarcaGenerada = new CN_Marca().Editar(MarcaNueva, out MensajeMarca);
<<<<<<< HEAD
                        IdMarcaGenerada = MarcaNueva.idMarca; // Actualiza el ID de persona generada
=======
                        IdMarcaGenerada = MarcaNueva.idMarca;
>>>>>>> 6d736377c4440647d72df7ddc5756a8c894d504c
                    }
                    else
                    {
                        IdMarcaGenerada = new CN_Marca().Registrar(MarcaNueva, out MensajeMarca);
                    }
                    if (IdMarcaGenerada != 0)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                    else
                    {
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

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarca.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {

                    Marca MarcaEditar = new Marca()
                    {
                        idMarca = Convert.ToInt32(dgvMarca.Rows[n].Cells["ID_marca"].Value),
                        nombre = dgvMarca.Rows[n].Cells["nombre_marca"].Value.ToString()
                    };

                    txtMarca.Text = MarcaEditar.nombre;
                    txtIdMarca.Text = MarcaEditar.idMarca.ToString();
                    // btnGuardarCategoria.Text = "Actualizar";

                }
                //txtIdCategoria.Text = "";
            }
            // Verifica si la columna seleccionada es la de "Accion"
            if (dgvMarca.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    string mensaje = string.Empty; // Mensaje para la acción
                    Marca MarcaEliminar = new Marca() // Crea un objeto marca para la acción
                    {
                        idMarca = (int)dgvMarca.Rows[n].Cells["ID_marca"].Value 
                    };

                    string estadoActual = dgvMarca.Rows[n].Cells["Estado"].Value.ToString();
                    string marca = dgvMarca.Rows[n].Cells["nombre_marca"].Value.ToString();

                    // Si la Marca está inactiva, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR la marca {marca}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para activar la marca
                            bool respuesta = new CN_Marca().Eliminar(MarcaEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado de la categoria
                                dgvMarca.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvMarca.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black; // Cambia el color a negro
                                dgvMarca.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black; // Cambia el color de selección a negro

                                MessageBox.Show("Marca " + marca + " activada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si la Marca está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR la marca {marca}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para desactivar la categoria
                            bool respuesta = new CN_Marca().Eliminar(MarcaEliminar, out mensaje);

                            // Actualizar el estado del usuario
                            dgvMarca.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvMarca.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red; // Cambia el color a rojo
                            dgvMarca.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red; // Cambia el color de selección a rojo

                            MessageBox.Show("Marca " + marca + " desactivada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvMarca.Rows.Clear(); // Limpia el DataGridView
                    Listar_Marcas(); // Llama a la función para volver a cargar los datos
                }
            }
        }
    }

}
