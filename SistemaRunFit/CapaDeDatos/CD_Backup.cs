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

            string ruta_copia = $"C:\\Users\\JULIO_GAMER_PC\\Desktop\\runfit_3_repositorio\\BackUp\\{nombre_copia}.bak";
            string comando_consulta = $"BACKUP DATABASE [RunFit] TO DISK = N'{ruta_copia}' WITH NOFORMAT, NOINIT, NAME = N'RunFit-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    // Actualiza la última fecha de backup
                    ultimaFechaBackup = nombre_copia; // Guardar el nombre de la copia
                    lblUltimoBackup.Text = "Última copia realizada: " + ultimaFechaBackup;

                    MessageBox.Show($"Copia de seguridad realizada con éxito.\nNombre del archivo: {nombre_copia}");
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
    }

}

