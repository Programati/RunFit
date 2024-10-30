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
    public partial class frmListarProveedor : Form
    {
        // Variable para almacenar la referencia del formulario Inicio.
        private Inicio _inicioForm;

        // Constructor que recibe una instancia del formulario Inicio.
        public frmListarProveedor(Inicio inicioForm)
        {
            InitializeComponent(); 
            _inicioForm = inicioForm; 
            _inicioForm.PnlContenedorMenu.Enabled = false; 
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmListarProveedor_Load(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Focus(); 
        }

        // Método para limpiar el campo de búsqueda por proveedor.
        private void LimpiarPorProveedor()
        {
            txtBuscarPorProveedor.Clear(); 
        }

        // Evento que se ejecuta al cerrar el formulario.
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Crea una nueva instancia del formulario para listar proveedores.
            frmListarProveedor ListarNuevoProveedor = new frmListarProveedor(_inicioForm);

            ListarNuevoProveedor.TopLevel = false; 
            pnlContenedorDatosProveedor.Controls.Clear(); 
            pnlContenedorDatosProveedor.Controls.Add(ListarNuevoProveedor); 
            ListarNuevoProveedor.FormBorderStyle = FormBorderStyle.None; 
            ListarNuevoProveedor.Dock = DockStyle.Fill; 

            ListarNuevoProveedor.Show(); 
        }

        // Evento que se ejecuta al hacer clic en el botón btnNuevoProveedor.
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario para crear un nuevo proveedor.
            frmProveedor CrearNuevoProveedor = new frmProveedor();

            CrearNuevoProveedor.TopLevel = false; // Establece el formulario como un formulario hijo.
            pnlContenedorDatosProveedor.Controls.Clear(); // Limpia el contenedor de datos de proveedor.
            pnlContenedorDatosProveedor.Controls.Add(CrearNuevoProveedor); // Agrega el nuevo formulario al contenedor.
            CrearNuevoProveedor.FormBorderStyle = FormBorderStyle.None; // Elimina el borde del formulario.
            CrearNuevoProveedor.Dock = DockStyle.Fill; // Ajusta el formulario para que ocupe todo el espacio disponible.

            CrearNuevoProveedor.Show(); // Muestra el formulario para crear un nuevo proveedor.
            CrearNuevoProveedor.FormClosing += frm_closing; // Asocia el evento de cierre del formulario al método frm_closing.
        }

        // Evento que se ejecuta al hacer clic en el botón btnLimpiarPorProveedor.
        private void btnLimpiarPorProveedor_Click_1(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Clear();
        }

        // Evento que se ejecuta al presionar una tecla en el campo txtBuscarPorProveedor.
        private void txtBuscarPorProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
            if (dgvListaProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaProveedor.Rows)
                {

                    if (row.Cells["Cuit_Prev"].Value.ToString().Trim().ToUpper().Contains(txtBuscarPorProveedor.Text.Trim().ToUpper()))
                        row.Visible = true; // Muestra la fila si coincide
                    else
                        row.Visible = false; // Oculta la fila si no coincide
                }
            }
        }

        // Evento que se ejecuta al hacer clic en el botón btnBuscarPorProveedor.
        private void btnBuscarPorProveedor_Click(object sender, EventArgs e)
        {
            if (EsCuitMuyCorto()) 
            {
                return; 
            }
        }

        // Método para verificar si el CUIT ingresado es demasiado corto.
        private bool EsCuitMuyCorto()
        {
            
            if (txtBuscarPorProveedor.Text.Length < 10)
            {
                
                MessageBox.Show("El número del CUIT del Proveedor es muy corto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true; 
            }
            return false; // Devuelve false indicando que el CUIT es de longitud adecuada.
        }

        // Evento que se ejecuta al hacer clic en el botón btnCancelar.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_inicioForm != null) // Verifica si la referencia de _inicioForm no es nula.
            {
                _inicioForm.PnlContenedorMenu.Enabled = true;
                _inicioForm.MostrarImagenFondo(); 
            }
            this.Close(); 
        }

        // Evento que se ejecuta al cargar el formulario.
        private void frmListarProveedor_Load_1(object sender, EventArgs e)
        {
            txtBuscarPorProveedor.Focus();

            listar_proveedores();
        }
        private void listar_proveedores()
        {
            // Obtiene la lista de usuarios desde la capa de negocio
            List<Proveedor> ListaProveedor = new CN_proveedor().ListarProveedores();

            // Agrega cada usuario a la fila del DataGridView
            foreach (Proveedor item in ListaProveedor)
            {
                dgvListaProveedor.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil, // Icono de editar
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_prov: CapaPresentacion.Properties.Resources.activar_prov, // Icono de acción
            item.cuit,
            item.idProveedor,
            item.razonSocial,
            item.fechaBaja == null ? "Activo" : "Inactivo", // Estado del usuario
            item.fechaAlta,
            item.email,
            item.telefono,
            item.direccion,
            item.descripcion,
            });
            }
            
            for (int i = 0; i < dgvListaProveedor.Rows.Count; i++)
            {
                
                string estado = dgvListaProveedor.Rows[i].Cells["Estado"].Value.ToString();

                
                if (estado == "Activo")
                {
                    // Cambiar el color del texto a negro si es "Activo"
                    dgvListaProveedor.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvListaProveedor.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black; // También cuando está seleccionada
                }
                else if (estado == "Inactivo")
                {
                    // Cambiar el color del texto a rojo si es "Inactivo"
                    dgvListaProveedor.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvListaProveedor.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red; // También cuando está seleccionada
                }
            }
        }
        

        private void dgvListaProveedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaProveedor.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty;
                    // Crea una nueva instancia del objeto 'Domicilio' con los datos de la fila seleccionada
                    Proveedor ProveedorEditar = new Proveedor()
                    {
                        idProveedor = Convert.ToInt32(dgvListaProveedor.Rows[n].Cells["id_Proveedor"].Value),
                        razonSocial = dgvListaProveedor.Rows[n].Cells["razon_social"].Value.ToString(),
                        cuit = dgvListaProveedor.Rows[n].Cells["Cuit_Prev"].Value.ToString(),
                        descripcion = dgvListaProveedor.Rows[n].Cells["Descrip_Proveedor"].Value.ToString(),
                        telefono = dgvListaProveedor.Rows[n].Cells["telefono"].Value.ToString(),
                        direccion = dgvListaProveedor.Rows[n].Cells["direccion"].Value.ToString(),
                        email = dgvListaProveedor.Rows[n].Cells["email"].Value.ToString(),

                    };

                    // Crea una nueva instancia del formulario 'frmCliente' para editar el domicilio
                    frmProveedor CrearNuevoProveedor = new frmProveedor(ProveedorEditar);
                    CrearNuevoProveedor.TopLevel = false;
                    pnlContenedorDatosProveedor.Controls.Clear();
                    pnlContenedorDatosProveedor.Controls.Add(CrearNuevoProveedor);
                    CrearNuevoProveedor.FormBorderStyle = FormBorderStyle.None;
                    CrearNuevoProveedor.Dock = DockStyle.Fill;

                    CrearNuevoProveedor.Show();
                    CrearNuevoProveedor.FormClosing += frm_closing;
                }
            }
            if (dgvListaProveedor.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex; // Obtiene el índice de la fila seleccionada
                if (n >= 0) // Verifica que el índice sea válido
                {
                    string mensaje = string.Empty; // Mensaje para la acción
                    Proveedor ProveedorEliminar = new Proveedor() // Crea un objeto Usuario para la acción
                    {
                        idProveedor = (int)dgvListaProveedor.Rows[n].Cells["ID_proveedor"].Value // Asigna el ID del usuario
                    };

                    string estadoActual = dgvListaProveedor.Rows[n].Cells["Estado"].Value.ToString(); // Obtiene el estado actual del usuario
                    string proveedor = dgvListaProveedor.Rows[n].Cells["razon_social"].Value.ToString(); // Obtiene el nombre del usuario

                    // Si el usuario está inactivo, se le pregunta si desea activarlo
                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR al proveedor {proveedor}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para activar el proveedor
                            bool respuesta = new CN_proveedor().Eliminar(ProveedorEliminar, out mensaje);

                            if (respuesta)
                            {
                                // Actualizar el estado del usuario
                                dgvListaProveedor.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvListaProveedor.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black; // Cambia el color a negro
                                dgvListaProveedor.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black; // Cambia el color de selección a negro

                                MessageBox.Show("Proveedor " + proveedor + " activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else // Si el proveedor está activo, se le pregunta si desea desactivarlo
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR al proveedor {proveedor}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            // Llama al procedimiento almacenado para desactivar el usuario
                            bool respuesta = new CN_proveedor().Eliminar(ProveedorEliminar, out mensaje);

                            // Actualizar el estado del usuario
                            dgvListaProveedor.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvListaProveedor.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red; // Cambia el color a rojo
                            dgvListaProveedor.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red; // Cambia el color de selección a rojo

                            MessageBox.Show("Usuario " + proveedor + " desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    // Limpia las filas del DataGridView y vuelve a cargar los datos
                    dgvListaProveedor.Rows.Clear(); // Limpia el DataGridView
                    listar_proveedores(); // Llama a la función para volver a cargar los datos
                }
            }
        }
    }
}
