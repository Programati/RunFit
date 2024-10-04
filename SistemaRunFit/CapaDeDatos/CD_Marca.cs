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
    public class CD_Marca
    {
        public List<Marca> ListarMarca()
        {

            List<Marca> Lista = new List<Marca>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_marca,nombre,fecha_alta,fecha_baja from MARCAS");

                    // Creamos un comando SQL con la consulta construida
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Abrimos la conexión con la base de datos
                    oconexion.Open();

                    // Ejecutamos la consulta y leemos los resultados con SqlDataReader
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Iteramos sobre cada fila de los resultados
                        while (dr.Read())
                        {
                            // Creamos un nuevo objeto Usuario y lo agregamos a la lista
                            Lista.Add(new Marca()
                            {
                                idMarca = Convert.ToInt32(dr["id_marca"]),
                                nombre = dr["nombre"].ToString(),
                                fechaAlta = Convert.ToDateTime(dr["fecha_alta"]),
                                fechaBaja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),

                            });
                        }
                        dr.Close(); // Cerramos el SqlDataReader
                        oconexion.Close(); // Cerramos la conexión con la base de datos
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, retornamos una lista vacía
                    Lista = new List<Marca>();
                }
            }
            // Retornamos la lista de usuarios obtenida
            return Lista;
        }
    }
}
