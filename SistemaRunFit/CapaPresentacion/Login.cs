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
        public Login()// constructor del login, el cual inicia mostrando los componentes
        {
            InitializeComponent();
        }
        private void frm_closing(object sender, FormClosingEventArgs e)// Funcion que limpia el login , lo muestra y pone el foco en usuario listo para ingresar
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            this.Show();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)// Funcion que permite salir del programa
        {
            this.Close();
        }


        private void btnIngresar_Click(object sender, EventArgs e)// Funcion que permite el ingreso al sistema o no, mediate usuario y contraseña
        {
            List<Usuario> TEST = new CN_Usuario().ListarUsuarios();

            //Descomentar la linea de abajo, una vez que creaste el superAdmin
            Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == Encrypt.GetSHA256(txtContrasena.Text)).FirstOrDefault();
           // Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == txtContrasena.Text).FirstOrDefault();


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

        private void Login_KeyDown(object sender, KeyEventArgs e)// Funcion que permite ingresar apretando la tecla enter mediante el llamado a la funcion btnIngresar_Click
                                                                 
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click( sender, e);
            }
        }
    }
}
