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
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT * from proveedores order by fecha_baja asc");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Proveedor()
                            {
                                idProveedor = Convert.ToInt32(dr["id_proveedor"]),
                                razonSocial = dr["razon_social"].ToString(),
                                cuit = dr["cuit"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                telefono= dr["telefono"].ToString(),
                                direccion= dr["direccion"].ToString(),
                                email = dr["email"].ToString(),
                                fechaAlta = Convert.ToDateTime(dr["fecha_alta"]),
                                fechaBaja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
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
                    SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_REGISTRAR", oconexion);

                    cmd.Parameters.AddWithValue("@razon_social", ObjProvee.razonSocial);
                    cmd.Parameters.AddWithValue("@cuit", ObjProvee.cuit);
                    cmd.Parameters.AddWithValue("@descripcion", ObjProvee.descripcion);
                    cmd.Parameters.AddWithValue("@direccion", ObjProvee.direccion);
                    cmd.Parameters.AddWithValue("@telefono", ObjProvee.telefono);
                    cmd.Parameters.AddWithValue("@email", ObjProvee.email);

                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

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
        public bool Editar(Proveedor ObjProvee, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_EDITAR", oconexion);
                    cmd.Parameters.AddWithValue("id_proveedor", ObjProvee.idProveedor);
                    cmd.Parameters.AddWithValue("razon_social", ObjProvee.razonSocial);
                    cmd.Parameters.AddWithValue("cuit", ObjProvee.cuit);
                    cmd.Parameters.AddWithValue("descripcion", ObjProvee.descripcion);
                    cmd.Parameters.AddWithValue("direccion", ObjProvee.direccion);
                    cmd.Parameters.AddWithValue("telefono", ObjProvee.telefono);
                    cmd.Parameters.AddWithValue("email", ObjProvee.email);

                    cmd.Parameters.Add("@Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = (bool)cmd.Parameters["@Respuesta"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta;
        }
        public bool Eliminar(Proveedor ObjProvee, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PROVEEDOR_ELIMINAR", oconexion);
                    cmd.Parameters.AddWithValue("id_proveedor", ObjProvee.idProveedor);
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
