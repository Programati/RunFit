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
            Listar_Marcas();
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
