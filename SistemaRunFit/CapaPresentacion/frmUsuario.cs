using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            if (camposValidados())
            {
                string user = txtUsuario.Text;
                string rolSeleccionado = cmbTipoUsuarioUser.SelectedItem.ToString();

                var confirmacion = MessageBox.Show(
                    $"¿Desea agregar al usuario {user} con el rol {rolSeleccionado} al sistema?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Datos guardados exitosamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    int n = dgvListaUser.Rows.Add();
                    //Colocamos la información en el renglon creado
                    dgvListaUser.Rows[n].Cells[2].Value = cmbTipoUsuarioUser.SelectedIndex.ToString();
                    dgvListaUser.Rows[n].Cells[3].Value = txtUsuario.Text;
                    dgvListaUser.Rows[n].Cells[4].Value = txtPassUser.Text;
                    //Borrar cuando se integre la BD
                    LimpiarCamposUser();


                }
            }
        }

        

        private bool camposValidados()
        {
            
            bool usuarioVacio = string.IsNullOrEmpty(txtUsuario.Text);
            bool passVacio = string.IsNullOrEmpty(txtPassUser.Text);
            bool tipoUsuarioSeleccionado = cmbTipoUsuarioUser.SelectedIndex != -1;

            if (usuarioVacio || passVacio || !tipoUsuarioSeleccionado )
            {
                MessageBox.Show("Debe completar todos los campos!","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCamposUser()
        {
            // Limpiar los campos de texto
            txtUsuario.Clear();
            txtPassUser.Clear();

            // Limpiar la selección en ComboBox
            cmbTipoUsuarioUser.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtPassUser.Clear();
            cmbTipoUsuarioUser.SelectedIndex = -1;
        }

        private void btnLimpiarUser_Click(object sender, EventArgs e)
        {
            cmbBuscarPorUser.SelectedIndex = -1;
            txtBuscarUser.Clear();
        }

        private void btnLimpiarCamposUser_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {

        }
    }
}
