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
        public int Registrar(Marca ObjMarca, out string Mensaje)
        {
            int IdMarcaGenerada = 0; // Variable para almacenar el id generado
            Mensaje = string.Empty; // Variable para almacenar el mensaje de salida

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Configuramos el comando para el procedimiento almacenado SP_REGISTRARCATEGORIAS
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARMARCAS", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un stored procedure

                    // Parámetro de entrada para nombre_categoria
                    cmd.Parameters.AddWithValue("@nombre", ObjMarca.nombre);

                    // Parámetro de salida para el resultado
                    SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultadoParam);

                    // Parámetro de salida para el mensaje
                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    mensajeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeParam);

                    // Abrimos la conexión
                    oconexion.Open();

                    // Ejecutamos el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    IdMarcaGenerada = (int)cmd.Parameters["@Resultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // En caso de error, devolvemos 0 y el mensaje de la excepción
                IdMarcaGenerada = 0;
                Mensaje = ex.Message;
            }

            return IdMarcaGenerada; // Retornamos el ID generado o 0 en caso de error
        }
    }
}
