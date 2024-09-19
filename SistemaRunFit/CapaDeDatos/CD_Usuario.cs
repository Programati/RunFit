using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;

namespace CapaDeDatos
{
    public class CD_Usuario
    {
        /*
         * Aqi vamos a hacer:
         Las peticiones a la BD con las sentencias SQL
         */

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
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
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
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", ObjUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("nombre_usuario", ObjUsuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("password", ObjUsuario.passwordUsuario);
                    cmd.Parameters.AddWithValue("fecha_baja", ObjUsuario.fechaBaja);
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
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
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
    }
}
