using CapaDeDatos;
using System;
using System.Collections.Generic;
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
        private CD_Backup _cdBackup;

        public CN_Backup()
        {
            _cdBackup = new CD_Backup(); // Inicializa la clase de la capa de datos
        }

        public DateTime? ObtenerUltimaCopia()
        {
            return _cdBackup.UltimaCopia(); // Llama a la función de la capa de datos
        }
    }

}
