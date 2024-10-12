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
    }

}
