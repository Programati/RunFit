using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaDeNegocios
{
    public class CN_Backup
    {
        private CD_Backup objcd_backup = new CD_Backup();

        public void Backup(System.Windows.Forms.Label lblUltimaCopia)
        {
            objcd_backup.Backup(lblUltimaCopia);
        }

        public string ObtenerUltimaFechaBackup()
        {
            return objcd_backup.ObtenerUltimaFechaBackup();
        }
        // private CD_Backup _cdBackup;


        public DateTime? ObtenerUltimaCopia()
        {
            return objcd_backup.UltimaCopia(); // Llama a la función de la capa de datos
        }
        public void Restaurar(string rutaBackup)
        {
            objcd_backup.Restaurar(rutaBackup); // Llamada a la capa de datos
        }
        

        public DataTable ListarBackups()
        {
            return objcd_backup.ListarBackups();
        }

    }
}
