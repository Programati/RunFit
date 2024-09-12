using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        



        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().ListarUsuarios();

            Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == txtContrasena.Text).FirstOrDefault();

            if(ousuario != null)
            {
                Inicio formInicioMenu = new Inicio();

                formInicioMenu.Show();
                this.Hide();

                formInicioMenu.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
