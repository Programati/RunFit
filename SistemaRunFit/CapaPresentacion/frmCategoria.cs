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
        public frmCategoria()
        {
            InitializeComponent();
            
        }
      
               
        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                var confirmacion = MessageBox.Show(
                    $"Desea agregar la categoria {txtCategoria.Text} ?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Aquí puedes agregar el código para guardar los datos
                    MessageBox.Show("Los datos se guardaron exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Momentaneamente Cargamos al DataGrid
                    //Adicionamos un nuevo renglon
                    int n = dgvCategoria.Rows.Add();
                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                    //Colocamos la información en el renglon creado
                    dgvCategoria.Rows[n].Cells[2].Value = n+1;
                    dgvCategoria.Rows[n].Cells[3].Value = textInfo.ToTitleCase(txtCategoria.Text.ToLower());
                    
                    //Borrar cuando se integre la BD
                    txtCategoria.Clear();
                    txtCategoria.Focus();
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
        }

        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            txtCategoria.Focus();
        }
    }
}
