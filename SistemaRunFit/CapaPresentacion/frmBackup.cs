using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidades;
using CapaDeNegocios;

namespace CapaPresentacion
{
    public partial class frmBackup : Form
    {
        CN_Backup backup = new CN_Backup();
        private Label lblUltimaCopia;
        // Campo privado que almacena la referencia al formulario principal 'Inicio'
        private Inicio _inicio;

        // Constructor que inicializa el formulario y desactiva el panel del menú en 'Inicio'
        public frmBackup(Inicio inicio)
        {
            _inicio = inicio; // Guarda la referencia del formulario 'Inicio'
            InitializeComponent(); // Inicializa los componentes del formulario
            _inicio.PnlContenedorMenu.Enabled = false; // Desactiva el panel del menú en 'Inicio' mientras se muestra este formulario
            lblUltimoBackup = new Label();

            // Llamar al método para cargar el último backup
            CargarUltimoBackup();

        }

        private void CargarUltimoBackup()
        {
            // Asigna la última fecha de backup
            lblUltima.Text = backup.ObtenerUltimaFechaBackup();

            // Verifica si el resultado de ObtenerUltimaCopia tiene valor
            var ultimaCopia = backup.ObtenerUltimaCopia();

            if (ultimaCopia.HasValue)
            {
                lblUltima.Text = ultimaCopia.Value.ToString();
            }
            else
            {
                lblUltima.Text = "No hay copias disponibles";  // Manejo del caso donde no hay valor
            }

        }
       


        // Evento del botón que regresa al menú de 'Marca' o al menú principal
        private void btnMenuMarca_Click(object sender, EventArgs e)
        {
            // Si la referencia a 'Inicio' es válida
            if (_inicio != null)
            {
                _inicio.PnlContenedorMenu.Enabled = true; // Reactiva el panel del menú en 'Inicio'
                _inicio.MostrarImagenFondo(); // Muestra nuevamente la imagen de fondo en 'Inicio'
            }
            this.Close(); // Cierra el formulario actual de 'Backup'
        }

        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            CN_Backup backup = new CN_Backup();

            // Realizar el backup y actualizar el label
            backup.Backup(lblUltimoBackup);

            // Actualizar la fecha del último backup en otro label
            lblUltima.Text = backup.ObtenerUltimaFechaBackup();
        }
        
        private void comprobarUsuario()
        {
            List<Usuario> TEST = new CN_Usuario().ListarUsuarios();


            //Descomentar la linea de abajo, una vez que creaste el superAdmin
            //Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuario.Text && u.passwordUsuario == Encrypt.GetSHA256(txtContrasena.Text)).FirstOrDefault();
            Usuario ousuario = new CN_Usuario().ListarUsuarios().Where(u => u.nombreUsuario == txtUsuarioBackup.Text && u.oRol.nombreRol=="Gerente" &&   u.passwordUsuario == (txtPassBackup.Text)).FirstOrDefault() ;


            if (ousuario != null)
            {
                object estado = ousuario.fechaBaja;

                if (estado != null)
                {
                    MessageBox.Show("Usted esta dado de BAJA en el sistema");
                    return;
                }
              
                string rutaBackup = txtRutaArchivo.Text; // Obtener la ruta desde el TextBox

                // Verificar que la ruta no esté vacía
                if (!string.IsNullOrEmpty(rutaBackup))
                {
                    // Pregunta crítica al usuario
                    DialogResult resultado = MessageBox.Show(
                        "¿Estás seguro de que deseas restaurar la base de datos desde el backup? " +
                        "Cualquier dato no guardado se perderá.", // Mensaje de advertencia
                        "Confirmar Restauración",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    // Si el usuario hace clic en "Sí", proceder con la restauración
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            CN_Backup backup = new CN_Backup(); // Crear una instancia de CN_Backup
                            backup.Restaurar(rutaBackup); // Llamar al método Restaurar
                            txtRutaArchivo.Clear();
                            txtUsuarioBackup.Clear();
                            txtPassBackup.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al restaurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un archivo de respaldo (.bak) antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas o no tiene permisos suficientes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRutaArchivo.Text))
            {
                MessageBox.Show("Debe seleccionar un archivo .bak para restaurar");
                return;
            }
            if(string.IsNullOrEmpty(txtUsuarioBackup.Text) || string.IsNullOrEmpty(txtUsuarioBackup.Text))
            {
                MessageBox.Show("Debe introducir el nombre de usuario y contraseña con permisos para poder restaurar");
                return;
            }
            comprobarUsuario();
        }


        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak"; // Filtrar solo archivos .bak
            openFileDialog.Title = "Seleccionar archivo de respaldo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = openFileDialog.FileName; // Mostrar la ruta seleccionada en el TextBox
            }
        }
    }
}
