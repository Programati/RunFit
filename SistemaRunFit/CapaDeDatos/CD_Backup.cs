﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;



namespace CapaDeDatos
{
    public class CD_Backup
    {
        private static string ultimaFechaBackup = string.Empty;
        Label lblUltimoBackup = new Label();

        public void Backup(Label lblUltimoBackup)
        {
            string nombre_copia = DateTime.Now.ToString("dd-MM-yyyy_HH' horas '_mm' minutos '_ss' segundos'");
            string ruta_copia = $"C:\\Users\\Matias-Pc\\OneDrive\\Documentos\\BackUp\\{nombre_copia}.bak";
            string nuevo_formato = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss").Replace('-', '/').Replace('_', ' ');

            // Comando para realizar el backup
            string comando_consulta = $"BACKUP DATABASE [RunFit] TO DISK = N'{ruta_copia}' WITH NOFORMAT, NOINIT, NAME = N'RunFit-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

            // Comando para insertar la información del backup en la tabla BackupLogs
            string comando_insert = $"INSERT INTO BackupList (BackupFileName, BackupDate) VALUES (@BackupFileName, @BackupDate)";


            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmdBackup = new SqlCommand(comando_consulta, conexion);
                SqlCommand cmdInsert = new SqlCommand(comando_insert, conexion);

                try
                {
                    conexion.Open();

                    // Ejecutar el backup
                    cmdBackup.ExecuteNonQuery();

                    // Insertar el registro en la tabla BackupLogs
                    cmdInsert.Parameters.AddWithValue("@BackupFileName", nombre_copia);
                    cmdInsert.Parameters.AddWithValue("@BackupDate", DateTime.Now);
                    cmdInsert.ExecuteNonQuery();

                    // Actualiza la última fecha de backup
                    ultimaFechaBackup = nuevo_formato;
                    lblUltimoBackup.Text = "Última copia realizada: " + ultimaFechaBackup;

                    MessageBox.Show($"Copia de seguridad realizada con éxito.\nNombre del archivo: {nuevo_formato}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la copia de seguridad: " + ex.Message);
                }
            }
        }

        
        private string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=RunFit;Integrated Security=True";

        public void Restaurar(string rutaBackup)

        {
            // Ruta de destino para los archivos de datos y log en tu sistema
            string rutaMDF = @"C:\Users\Matias-Pc\OneDrive\Documentos\BackUp\RunFit.mdf";
            string rutaLDF = @"C:\Users\Matias-Pc\OneDrive\Documentos\BackUp\RunFit_log.ldf";

            string query = $@"
USE master;
ALTER DATABASE [RunFit] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
RESTORE DATABASE [RunFit]
FROM DISK = '{rutaBackup}'
WITH 
    MOVE 'RunFit' TO '{rutaMDF}', 
    MOVE 'RunFit_log' TO '{rutaLDF}', 
    REPLACE;
ALTER DATABASE [RunFit] SET MULTI_USER;";

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Base de datos restaurada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restaurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // Método para verificar los backups ejecutando el procedimiento almacenado



        public DataTable ListarBackups()
        {
            DataTable backups = new DataTable();

            string query = "SELECT * FROM BackupList order by BackupDate desc";

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(backups);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los backups: " + ex.Message);
                }
            }

            return backups;
        }
    }

}



