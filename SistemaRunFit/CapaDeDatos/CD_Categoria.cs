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
    internal class CD_Categoria
    {
        public List<Usuario> ListarUsuarios()
        {
            
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_categoria,nombre_categoria,fecha_alta,fecha_baja,");
                    
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
                            Lista.Add(new Categoria()
                            {
                                idCategoria = Convert.ToInt32(dr["id_categoria"]), 
                                nombre_categoria = dr["nombre_categoria"].ToString(),
                                fecha_alta = Convert.ToDateTime(dr["fecha_alta"]),
                                fecha_baja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),
                                
                            });
                        }
                        dr.Close(); // Cerramos el SqlDataReader
                        oconexion.Close(); // Cerramos la conexión con la base de datos
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, retornamos una lista vacía
                    Lista = new List<Usuario>();
                }
            }
            // Retornamos la lista de usuarios obtenida
            return Lista;
        }
    }
}
