using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using CapaDeEntidades;
using CapaDeNegocios;


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


            //Descomentar la linea de abajo, una vez que creaste el superAdmin
<<<<<<< HEAD

           // Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == Encrypt.GetSHA256(txtContrasena.Text)).FirstOrDefault();

=======
            //Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == Encrypt.GetSHA256(txtContrasena.Text)).FirstOrDefault();
>>>>>>> 53d25f6e474e6eafaed02dd8074556453c398f5e
            Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == (txtContrasena.Text)).FirstOrDefault();


            if (ousuario != null)
            {
                object estado = ousuario.fechaBaja;

                if (estado != null)
                {
                    MessageBox.Show("Usted esta dado de BAJA en el sistema");
                    return;
                }
                Inicio formInicioMenu = new Inicio(ousuario);

                formInicioMenu.Show();
                this.Hide();
                
                formInicioMenu.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
                                                                 
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click( sender, e);
            }
        }
    }
}
