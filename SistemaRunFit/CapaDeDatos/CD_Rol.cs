using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CD_Rol
    {
        // Método para listar todos los roles de la base de datos
        public List<Rol> Listar()
        {
            // Inicializamos una lista de objetos Rol
            List<Rol> Lista = new List<Rol>();
            // Usamos una conexión SQL con la base de datos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener los datos de la tabla ROL
                    string query = "select id_rol, nombre_rol, fecha_alta, fecha_baja from ROL";

                    // Creamos un comando SQL con la consulta anterior
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text; // El comando es un texto SQL simple

                    // Abrimos la conexión con la base de datos
                    oconexion.Open();

                    // Ejecutamos la consulta y usamos un SqlDataReader para leer los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Iteramos sobre cada registro devuelto
                        while (dr.Read())
                        {
                            // Agregamos cada registro como un nuevo objeto Rol a la lista
                            Lista.Add(new Rol()
                            {
                                idRol = Convert.ToInt32(dr["id_rol"]), // Convertimos el id_rol a entero
                                nombreRol = dr["nombre_rol"].ToString(), // Convertimos nombre_rol a string
                                fechaAlta = dr["fecha_alta"].ToString(), // Convertimos fecha_alta a string
                                fechaBaja = dr["fecha_baja"].ToString() // Convertimos fecha_baja a string
                            });
                        }
                        dr.Close(); // Cerramos el SqlDataReader
                        oconexion.Close(); // Cerramos la conexión con la base de datos
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, devolvemos una lista vacía
                    Lista = new List<Rol>();
                }
            }
            // Retornamos la lista de roles obtenida
            return Lista;
        }
    }
}
