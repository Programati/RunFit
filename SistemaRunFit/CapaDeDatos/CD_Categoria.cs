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
    public class CD_Categoria
    {
        public List<Categoria> ListarCategoria()
        {
            
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_categoria,nombre_categoria,fecha_alta,fecha_baja from categorias");
                    
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
                            // Creamos un nuevo objeto Categoria y lo agregamos a la lista
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
                    Lista = new List<Categoria>();
                }
            }
            // Retornamos la lista de usuarios obtenida
            return Lista;
        }
        public int Registrar(Categoria ObjCategoria, out string Mensaje)
        {
            int IdCategoriaGenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_CATEGORIAS_REGISTRAR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nombre_categoria", ObjCategoria.nombre_categoria);
                    SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultadoParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    mensajeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeParam);

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdCategoriaGenerada = (int)cmd.Parameters["@Resultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdCategoriaGenerada = 0;
                Mensaje = ex.Message;
            }

            return IdCategoriaGenerada;
        }
        public bool Editar(Categoria ObjCategoria, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_CATEGORIAS_EDITAR", oconexion);
                    cmd.Parameters.AddWithValue("id_categoria", ObjCategoria.idCategoria);
                    cmd.Parameters.AddWithValue("nombre_categoria", ObjCategoria.nombre_categoria);
                    

                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }

        public bool Eliminar(Categoria ObjCategoria, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_CATEGORIA_ELIMINAR", oconexion);
                    cmd.Parameters.AddWithValue("id_categoria", ObjCategoria.idCategoria);

                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }

    }
}
