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
    public partial class frmReporteBackup : Form
    {
        public frmReporteBackup()
        {
            InitializeComponent();
        }

        private void btnComprobarBackup_Click(object sender, EventArgs e)
        {
            CN_Backup backup = new CN_Backup(); // Instancia de la capa de negocios
            string resultado = backup.VerificarBackups(); // Llama al método de la capa de negocios y obtiene el resultado

            // Mostrar el resultado en un cuadro de mensaje
            MessageBox.Show(resultado, "Verificación de Backups", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmReporteBackup_Load(object sender, EventArgs e)
        {
            CN_Backup backup = new CN_Backup();

            // Obtener la lista de backups y mostrarla en el DataGridView
            DataTable backups = backup.ListarBackups();
            dgvReporteBackup.DataSource = backups; // Asumiendo que tienes un DataGridView en tu formulario llamado dataGridViewBackups
        }
    }
}
