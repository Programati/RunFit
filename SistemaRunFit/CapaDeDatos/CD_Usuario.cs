using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using System.Windows.Forms;

namespace CapaDeDatos
{
    public class CD_Usuario
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id_usuario,u.nombre_usuario,u.password,u.fecha_alta,u.fecha_baja,u.id_persona, u.id_rol,r.nombre_rol,p.dni,p.nombre,p.apellido,p.email,p.telefono,p.fecha_nacimiento,p.sexo FROM USUARIOS u");
                    query.AppendLine("inner join PERSONAS p on p.id_persona = u.id_persona");
                    query.AppendLine("inner join ROL r on r.id_rol = u.id_rol");
                    query.AppendLine("WHERE u.id_persona = p.id_persona");
                    query.AppendLine("ORDER BY u.fecha_baja asc");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;
                    
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["id_usuario"]),
                                nombreUsuario = dr["nombre_usuario"].ToString(), 
                                passwordUsuario = dr["password"].ToString(),
                                fechaAlta = dr["fecha_alta"].ToString(),
                                fechaBaja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),
                                oRol = new Rol { idRol = Convert.ToInt32(dr["id_rol"]), nombreRol = dr["nombre_rol"].ToString() },
                                oPersona = new Persona { idPersona = Convert.ToInt32(dr["id_persona"]), dni = dr["dni"].ToString(), nombre = dr["nombre"].ToString(), apellido = dr["apellido"].ToString(), email = dr["email"].ToString(), telefono = dr["telefono"].ToString(), fechaNacimiento = dr["fecha_nacimiento"].ToString(), sexo = Convert.ToChar(dr["sexo"]) }
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Usuario>();
                }
            }
            return Lista;
        }
       

        public int Registrar(Usuario ObjUsuario, out string Mensaje)
        {
            int IdUsuarioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_USUARIO_REGISTRAR", oconexion);
                    cmd.Parameters.AddWithValue("nombre_usuario", ObjUsuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("password", ObjUsuario.passwordUsuario);
                    cmd.Parameters.AddWithValue("id_persona", ObjUsuario.oPersona.idPersona);
                    cmd.Parameters.AddWithValue("id_rol", ObjUsuario.oRol.idRol);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdUsuarioGenerado = (int)cmd.Parameters["IdUsuarioResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdUsuarioGenerado;
        }

        public bool Editar(Usuario ObjUsuario, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_USUARIO_EDITAR", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", ObjUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("nombre_usuario", ObjUsuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("password", ObjUsuario.passwordUsuario);
                    cmd.Parameters.AddWithValue("id_persona", ObjUsuario.oPersona.idPersona);
                    cmd.Parameters.AddWithValue("id_rol", ObjUsuario.oRol.idRol);

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

        public bool Eliminar(Usuario ObjUsuario, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_USUARIO_ELIMINAR", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", ObjUsuario.idUsuario);

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
        public List<Venta> ReporteUsuario(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> lista = new List<Venta>();
           // mensaje = string.Empty; // Inicializa el mensaje

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Crear la consulta SQL directamente
                    string consulta = @"
            SELECT v.fecha_factura, 
                   dv.cantidad, 
                   p.nombre_producto, 
                   p.precio_venta, 
                   dv.subtotal
            FROM ventas v
            INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
            INNER JOIN productos p ON dv.id_producto = p.id_producto
            WHERE v.id_usuario = @idUsuario
              AND v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
            ORDER BY v.fecha_factura DESC;";

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Agregar el parámetro de entrada
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                fechaFactura = dr["fecha_factura"] != DBNull.Value
               ? Convert.ToDateTime(dr["fecha_factura"]).ToString("yyyy-MM-dd")
               : string.Empty, // O establece otra cadena predeterminada si es necesario

                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                                cantidad =  Convert.ToInt32(dr["cantidad"]),
                                subTotal =  Convert.ToDouble(dr["subtotal"]),
                                oProducto = new Producto
                                {
                                    nombre = dr["nombre_producto"] != DBNull.Value ? dr["nombre_producto"].ToString() : "Sin nombre",
                                    precioVenta = Convert.ToDouble(dr["precio_venta"])
                                }
                            }
                        }
                            };
                            lista.Add(venta);
                        }
                    }

                }
                catch (Exception ex)
                {
                    
                    lista = new List<Venta>(); 
                }
            }

            return lista; 
        }
        public List<Venta> ReporteUsuario2(int idUsuario, DateTime fechaDesde,DateTime fechaHasta)
        {
            List<Venta> lista = new List<Venta>();
           
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                   
                    string consulta = @"
                SELECT p.nombre_producto, 
                       SUM(dv.cantidad) AS total_cantidad, 
                       MAX(p.precio_venta) AS precio_venta, 
                       SUM(dv.subtotal) AS total_subtotal,
                       MAX(v.fecha_factura) AS ultima_fecha_factura
                FROM ventas v
                INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
                INNER JOIN productos p ON dv.id_producto = p.id_producto
                WHERE v.id_usuario = @idUsuario
                AND v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
                GROUP BY p.nombre_producto
                        order by total_cantidad desc;";

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Agregar el parámetro de entrada
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                fechaFactura = dr["ultima_fecha_factura"] != DBNull.Value
                                    ? Convert.ToDateTime(dr["ultima_fecha_factura"]).ToString("yyyy-MM-dd")
                                    : string.Empty, 

                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                                cantidad = Convert.ToInt32(dr["total_cantidad"]),
                                subTotal = Convert.ToDouble(dr["total_subtotal"]),
                                oProducto = new Producto
                                {
                                    nombre = dr["nombre_producto"] != DBNull.Value ? dr["nombre_producto"].ToString() : "Sin nombre",
                                    precioVenta = Convert.ToDouble(dr["precio_venta"])
                                }
                            }
                        }
                            };

                            lista.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Venta>(); 
                }
            }

            return lista;
        }
        public List<Venta> ReporteUsuario3(int idUsuario,DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> lista = new List<Venta>();
            
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Crear la consulta SQL directamente
                    string consulta = @"
                SELECT p.nombre_producto, 
                       SUM(dv.cantidad) AS total_cantidad, 
                       MAX(p.precio_venta) AS precio_venta, 
                       SUM(dv.subtotal) AS total_subtotal,
                       MAX(v.fecha_factura) AS ultima_fecha_factura
                FROM ventas v
                INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
                INNER JOIN productos p ON dv.id_producto = p.id_producto
                WHERE v.id_usuario = @idUsuario
                AND v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
                GROUP BY p.nombre_producto
                        order by total_subtotal desc;";

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Agregar el parámetro de entrada
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                fechaFactura = dr["ultima_fecha_factura"] != DBNull.Value
                                    ? Convert.ToDateTime(dr["ultima_fecha_factura"]).ToString("yyyy-MM-dd")
                                    : string.Empty, // O establece otra cadena predeterminada si es necesario

                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                                cantidad = Convert.ToInt32(dr["total_cantidad"]),
                                subTotal = Convert.ToDouble(dr["total_subtotal"]),
                                oProducto = new Producto
                                {
                                    nombre = dr["nombre_producto"] != DBNull.Value ? dr["nombre_producto"].ToString() : "Sin nombre",
                                    precioVenta = Convert.ToDouble(dr["precio_venta"])
                                }
                            }
                        }
                            };

                            lista.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                   lista = new List<Venta>(); // Retorna una lista vacía en caso de error
                }
            }

            return lista;
        }
        




    }

}
