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

       

        private void frmReporteBackup_Load(object sender, EventArgs e)
        {
            CN_Backup backup = new CN_Backup();

            // Obtener la lista de backups y mostrarla en el DataGridView
            DataTable backups = backup.ListarBackups();
            dgvReporteBackup.DataSource = backups; // Asumiendo que tienes un DataGridView en tu formulario llamado dataGridViewBackups
        }
    }
}
