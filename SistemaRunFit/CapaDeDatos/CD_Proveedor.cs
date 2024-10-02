using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace CapaDeDatos
{
    public class CD_Proveedor
    {
        public List<Proveedor> ListarProv()
        {
            List<Proveedor> Lista = new List<Proveedor>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Usamos StringBuilder para construir la consulta SQL de forma eficiente
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT * from proveedores");
                    

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
                            Lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(dr["id_proveedor"]), // Convertimos el id_usuario a entero
                                razonSocial = dr["razon_social"].ToString(), // Convertimos nombre_usuario a string
                                cuit = dr["cuit"].ToString(), // Convertimos cuit a string
                                descripcion = dr["descripcion"].ToString(),
                                telefono= dr["telefono"].ToString(),
                                direccion= dr["direccion"].ToString(),
                                email = dr["email"].ToString(),
                                fechaAlta = Convert.ToDateTime(dr["fecha_alta"]), // Convertimos fecha_alta a DateTime
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
                     Lista = new List<Proveedor>();
                }
            }
            return Lista;
        }
        public int Registrar(Proveedor ObjProvee, out string Mensaje)
        {
            int IdProveedorGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_AGREGARPROVEEDOR", oconexion);

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@razon_social", ObjProvee.razonSocial);
                    cmd.Parameters.AddWithValue("@cuit", ObjProvee.cuit);
                    cmd.Parameters.AddWithValue("@descripcion", ObjProvee.descripcion);
                    cmd.Parameters.AddWithValue("@direccion", ObjProvee.direccion);
                    cmd.Parameters.AddWithValue("@telefono", ObjProvee.telefono);
                    cmd.Parameters.AddWithValue("@email", ObjProvee.email);  // Nuevo parámetro email

                    // Parámetros de salida
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    IdProveedorGenerado = (int)cmd.Parameters["@Resultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdProveedorGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdProveedorGenerado;
        }


    }
}
