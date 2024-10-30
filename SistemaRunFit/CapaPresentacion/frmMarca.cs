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
        Inicio _inicio;
        public frmMarca(Inicio inicio)
        {
            InitializeComponent();
            _inicio = inicio;
            _inicio.PnlContenedorMenu.Enabled = false;
           
        }
        private void Listar_Marcas()
        {
            List<Marca> ListaMarca = new CN_Marca().ListarMarcas();
            foreach (Marca item in ListaMarca)
            {
                dgvMarca.Rows.Add(new object[] {
            CapaPresentacion.Properties.Resources.pencil,
            item.fechaBaja == null ? CapaPresentacion.Properties.Resources.eliminar_marca: CapaPresentacion.Properties.Resources.activar_marca,
            item.idMarca,
            item.fechaBaja == null ? "Activo" : "Inactivo",
            item.nombre,
                 });
            }

            for (int i = 0; i < dgvMarca.Rows.Count; i++)
            {
                string estado = dgvMarca.Rows[i].Cells["Estado"].Value.ToString();

                if (estado == "Activo")
                {
                    dgvMarca.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvMarca.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                }
                else if (estado == "Inactivo")
                {
                    dgvMarca.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvMarca.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                }
            }
        }
        private void frmMarca_Load(object sender, EventArgs e)
        {
            txtMarca.Focus();
            Listar_Marcas();
        }

        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true;
                _inicio.MostrarImagenFondo();
            }
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtBuscarMarca.Clear();
            txtIdMarca.Clear();
        }
        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            string MensajeMarca = string.Empty;
            int IdMarcaGenerada = 0;
            bool VerdadMarcaGenerada = false;
            string mensajeConfirmacion = "¿Desea agregar la marca";


            if (!string.IsNullOrEmpty(txtMarca.Text))
            {
                if (!string.IsNullOrEmpty(txtIdMarca.Text))
                {
                    mensajeConfirmacion = "¿Modificar la marca a";
                }

                var confirmacion = MessageBox.Show(
                    $"{mensajeConfirmacion} {txtMarca.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    Marca MarcaNueva = new Marca()
                    {
                        idMarca = txtIdMarca.Text != "" ? Convert.ToInt32(txtIdMarca.Text) : IdMarcaGenerada,
                        nombre = txtMarca.Text.ToString(),
                    };

                    if (txtIdMarca.Text != "")
                    {
                        VerdadMarcaGenerada = new CN_Marca().Editar(MarcaNueva, out MensajeMarca);
                        IdMarcaGenerada = MarcaNueva.idMarca; 
                    }
                    else
                    {
                        IdMarcaGenerada = new CN_Marca().Registrar(MarcaNueva, out MensajeMarca);
                    }
                    if (IdMarcaGenerada != 0 && VerdadMarcaGenerada)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(MensajeMarca);
                        txtIdMarca.Text = "";
                    }

                    LimpiarCampos();
                    dgvMarca.Rows.Clear();
                    Listar_Marcas();
                    txtMarca.Focus();
                    lblNuevaMarca.Text = "Nueva Marca";
                    btnGuardarMarca.Text = "Guardar";
                }
            }
            else
            {
                MessageBox.Show("Categoria vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarca.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {

                    Marca MarcaEditar = new Marca()
                    {
                        idMarca = Convert.ToInt32(dgvMarca.Rows[n].Cells["ID_marca"].Value),
                        nombre = dgvMarca.Rows[n].Cells["nombre_marca"].Value.ToString()
                    };

                    txtMarca.Text = MarcaEditar.nombre;
                    txtIdMarca.Text = MarcaEditar.idMarca.ToString();
                    lblNuevaMarca.Text = "Editar Marca";
                    btnGuardarMarca.Text = "Actualizar";
                    dgvMarca.Rows.Clear();
                    Listar_Marcas();

                }
            }

            if (dgvMarca.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty;
                    Marca MarcaEliminar = new Marca()
                    {
                        idMarca = (int)dgvMarca.Rows[n].Cells["ID_marca"].Value 
                    };

                    string estadoActual = dgvMarca.Rows[n].Cells["Estado"].Value.ToString();
                    string marca = dgvMarca.Rows[n].Cells["nombre_marca"].Value.ToString();

                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR la marca {marca}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Marca().Eliminar(MarcaEliminar, out mensaje);

                            if (respuesta)
                            {
                                dgvMarca.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvMarca.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black;
                                dgvMarca.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                                MessageBox.Show("Marca " + marca + " activada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR la marca {marca}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Marca().Eliminar(MarcaEliminar, out mensaje);
                            dgvMarca.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvMarca.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red;
                            dgvMarca.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                            MessageBox.Show("Marca " + marca + " desactivada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    dgvMarca.Rows.Clear();
                    Listar_Marcas();
                }
            }
        }

        private void txtBuscarMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (dgvMarca.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMarca.Rows)
                {
                    
                    if (row.Cells["nombre_marca"].Value.ToString().Trim().ToUpper().Contains(txtBuscarMarca.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
    }

}
