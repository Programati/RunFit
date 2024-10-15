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
        Inicio _inicio;

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
            CapaPresentacion.Properties.Resources.pencil,
            item.fecha_baja == null ? CapaPresentacion.Properties.Resources.eliminar_categoria: CapaPresentacion.Properties.Resources.activar_categoria,
            item.idCategoria,
            item.fecha_baja == null ? "Activo" : "Inactivo", 
            item.nombre_categoria,
                 });
            }

            for (int i = 0; i < dgvCategoria.Rows.Count; i++)
            {
                string estado = dgvCategoria.Rows[i].Cells["Estado"].Value.ToString();

                if (estado == "Activo")
                {
                    dgvCategoria.Rows[i].Cells["Estado"].Style.ForeColor = Color.Black;
                    dgvCategoria.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                }
                else if (estado == "Inactivo")
                {
                    dgvCategoria.Rows[i].Cells["Estado"].Style.ForeColor = Color.Red;
                    dgvCategoria.Rows[i].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCategoria.Clear();
            txtBuscarCategoria.Clear();
            txtIdCategoria.Clear();
        }
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            string MensajeCategoria = string.Empty;
            int IdCategoriaGenerada = 0;
            bool VerdadCategoriaGenerada = false;
            string mensajeConfirmacion = "¿Desea agregar la categoria";
            
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (!string.IsNullOrEmpty(txtIdCategoria.Text))
                {
                    mensajeConfirmacion = "¿Modificar la categoria a";
                }
                var confirmacion = MessageBox.Show(
                    $"{mensajeConfirmacion} {txtCategoria.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    Categoria CategoriaNueva = new Categoria()
                    {
                        idCategoria = txtIdCategoria.Text != "" ? Convert.ToInt32(txtIdCategoria.Text) : IdCategoriaGenerada,
                        nombre_categoria = txtCategoria.Text,
                    };

                    if (txtIdCategoria.Text != "")
                    {
                        VerdadCategoriaGenerada = new CN_Categoria().Editar(CategoriaNueva, out MensajeCategoria);
                        IdCategoriaGenerada = CategoriaNueva.idCategoria;
                    }
                    else
                    {
                        IdCategoriaGenerada = new CN_Categoria().Registrar(CategoriaNueva, out MensajeCategoria);
                    }
                    if (IdCategoriaGenerada != 0 && VerdadCategoriaGenerada)
                    {
                        MessageBox.Show("Datos guardados exitosamente.", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                        txtIdCategoria.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(MensajeCategoria );
                        txtIdCategoria.Text = "";
                    }
                    
                    LimpiarCampos();
                    dgvCategoria.Rows.Clear();
                    Listar_Categorias();
                    txtCategoria.Clear();
                    txtCategoria.Focus();
                    lblCategoria.Text = "Nueva Categoria";
                    btnGuardarCategoria.Text = "Guardar";
                }
            }
            else
            {
                MessageBox.Show("Categoria vacia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void txtBuscarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
           
            if (dgvCategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCategoria.Rows)
                {
                    
                    if (row.Cells["Categoria"].Value.ToString().Trim().ToUpper().Contains(txtBuscarCategoria.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            txtCategoria.Focus();
            Listar_Categorias();
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

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "Editar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    
                    Categoria CategoriaEditar = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(dgvCategoria.Rows[n].Cells["ID_categoria"].Value),
                        nombre_categoria = dgvCategoria.Rows[n].Cells["categoria"].Value.ToString()
                    };

                    txtCategoria.Text= CategoriaEditar.nombre_categoria;
                    txtIdCategoria.Text = CategoriaEditar.idCategoria.ToString();
                    lblCategoria.Text = "Editar Categoria";
                    btnGuardarCategoria.Text = "Actualizar";
                    dgvCategoria.Rows.Clear();
                    Listar_Categorias();

                }
            }

            if (dgvCategoria.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int n = e.RowIndex;
                if (n >= 0)
                {
                    string mensaje = string.Empty;
                    Categoria CategoriaEliminar = new Categoria()
                    {
                        idCategoria = (int)dgvCategoria.Rows[n].Cells["ID_Categoria"].Value
                    };

                    string estadoActual = dgvCategoria.Rows[n].Cells["Estado"].Value.ToString(); 
                    string categoria = dgvCategoria.Rows[n].Cells["Categoria"].Value.ToString(); 

                    if (estadoActual == "Inactivo")
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea ACTIVAR la categoria {categoria}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Categoria().Eliminar(CategoriaEliminar, out mensaje);

                            if (respuesta)
                            {
                                dgvCategoria.Rows[n].Cells["Estado"].Value = "Activo";
                                dgvCategoria.Rows[n].Cells["Estado"].Style.ForeColor = Color.Black;
                                dgvCategoria.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Black;
                                MessageBox.Show("Categoria " + categoria + " activada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        DialogResult ask = MessageBox.Show($"¿Desea DESACTIVAR la categoria {categoria}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (ask == DialogResult.Yes)
                        {
                            bool respuesta = new CN_Categoria().Eliminar(CategoriaEliminar, out mensaje);
                            dgvCategoria.Rows[n].Cells["Estado"].Value = "Inactivo";
                            dgvCategoria.Rows[n].Cells["Estado"].Style.ForeColor = Color.Red;
                            dgvCategoria.Rows[n].Cells["Estado"].Style.SelectionForeColor = Color.Red;
                            MessageBox.Show("Categoria " + categoria + " desactivada correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    dgvCategoria.Rows.Clear();
                    Listar_Categorias();
                }
            }
        }
    }
}



