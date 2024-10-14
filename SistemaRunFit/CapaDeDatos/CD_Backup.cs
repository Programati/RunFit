using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace CapaDeDatos
{
    public class CD_Backup
    {
        private static string ultimaFechaBackup = string.Empty;
        Label lblUltimoBackup = new Label();
        public void Backup(Label lblUltimoBackup)
        {
            string nombre_copia = DateTime.Now.ToString("dd-MM-yyyy_HH' horas '_mm' minutos '_ss' segundos'");

            string ruta_copia = $"C:\\Users\\JULIO-NOTEBOOK2\\Desktop\\Runfit_repositorio\\BackUp\\{nombre_copia}.bak";

            string nuevo_formato = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace('-', '/').Replace('_', ' '); // Cambiamos '/' a '-' y ' ' a '_' para un nombre de archivo válido
            string comando_consulta = $"BACKUP DATABASE [RunFit] TO DISK = N'{ruta_copia}' WITH NOFORMAT, NOINIT, NAME = N'RunFit-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

        //C: \Users\JULIO - NOTEBOOK2\Desktop\Runfit_repositorio\BackUp\\{ nombre_copia}.bak

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    // Actualiza la última fecha de backup
                    ultimaFechaBackup = nuevo_formato; // Guardar el nombre de la copia
                    lblUltimoBackup.Text = "Última copia realizada: " + ultimaFechaBackup;

                    MessageBox.Show($"Copia de seguridad realizada con éxito.\nNombre del archivo: {nuevo_formato}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la copia de seguridad: " + ex.Message);
                }
            }
        }
        public string ObtenerUltimaFechaBackup()
        {
            return ultimaFechaBackup;
        }
        public DateTime? UltimaCopia()
        {
            // Cadena de conexión a la base de datos
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                // Query SQL para obtener la fecha de la última copia de seguridad
                string query = @"
                    SELECT MAX(BackupStartDate) 
                    FROM (
                        SELECT 
                            backupset.backup_start_date AS BackupStartDate
                        FROM 
                            msdb.dbo.backupset AS backupset
                        INNER JOIN 
                            msdb.dbo.backupmediafamily AS backupmediafamily
                        ON 
                            backupset.media_set_id = backupmediafamily.media_set_id
                        WHERE 
                            backupset.database_name = 'RunFit'
                    ) AS BackupDates;";

                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != DBNull.Value && resultado != null)
                    {
                        return Convert.ToDateTime(resultado);
                    }
                    else
                    {
                        return null; // Si no hay copias de seguridad
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    throw new Exception("Error al obtener la última copia de seguridad: " + ex.Message);
                }
            }
        }
    }

}

