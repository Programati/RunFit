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
         * Aquí vamos a hacer:
         * Las peticiones a la BD con las sentencias SQL
         */

        // Método para listar todos los usuarios desde la base de datos
        public List<Usuario> ListarUsuarios()
        {
            // Inicializamos una lista de objetos Usuario
            List<Usuario> Lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Usamos StringBuilder para construir la consulta SQL de forma eficiente
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id_usuario,u.nombre_usuario,u.password,u.fecha_alta,u.fecha_baja,u.id_persona, u.id_rol,r.nombre_rol,p.dni,p.nombre,p.apellido,p.email,p.telefono,p.fecha_nacimiento,p.sexo FROM USUARIOS u");
                    query.AppendLine("inner join PERSONAS p on p.id_persona = u.id_persona");
                    query.AppendLine("inner join ROL r on r.id_rol = u.id_rol");
                    query.AppendLine("WHERE u.id_persona = p.id_persona");
                    query.AppendLine("ORDER BY u.fecha_baja asc");

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
                            Lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["id_usuario"]), // Convertimos el id_usuario a entero
                                nombreUsuario = dr["nombre_usuario"].ToString(), // Convertimos nombre_usuario a string
                                passwordUsuario = dr["password"].ToString(), // Convertimos password a string
                                fechaAlta = dr["fecha_alta"].ToString(), // Convertimos fecha_alta a string
                                                                         // Convertimos fecha_baja a DateTime? (nullable) o lo dejamos como null si es DBNull
                                fechaBaja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),
                                // Creamos un nuevo objeto Rol y lo asociamos al usuario
                                oRol = new Rol { idRol = Convert.ToInt32(dr["id_rol"]), nombreRol = dr["nombre_rol"].ToString() },
                                // Creamos un nuevo objeto Persona y lo asociamos al usuario
                                oPersona = new Persona { idPersona = Convert.ToInt32(dr["id_persona"]), dni = dr["dni"].ToString(), nombre = dr["nombre"].ToString(), apellido = dr["apellido"].ToString(), email = dr["email"].ToString(), telefono = dr["telefono"].ToString(), fechaNacimiento = dr["fecha_nacimiento"].ToString(), sexo = Convert.ToChar(dr["sexo"]) }
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

        // Método para registrar un nuevo usuario en la base de datos
        public int Registrar(Usuario ObjUsuario, out string Mensaje)
        {
            int IdUsuarioGenerado = 0; // Variable para almacenar el id generado
            Mensaje = string.Empty; // Variable para almacenar el mensaje de salida

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Configuramos el comando para el procedimiento almacenado SP_REGISTRARUSUARIO
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("nombre_usuario", ObjUsuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("password", ObjUsuario.passwordUsuario);
                    cmd.Parameters.AddWithValue("id_persona", ObjUsuario.oPersona.idPersona);
                    cmd.Parameters.AddWithValue("id_rol", ObjUsuario.oRol.idRol);

                    // Parámetros de salida
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un stored procedure
                    oconexion.Open();

                    // Ejecutamos el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    IdUsuarioGenerado = (int)cmd.Parameters["IdUsuarioResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // En caso de error, devolvemos 0 y el mensaje de la excepción
                IdUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdUsuarioGenerado; // Retornamos el ID generado o 0 en caso de error
        }

        // Método para editar un usuario en la base de datos
        public bool Editar(Usuario ObjUsuario, out string Mensaje)
        {
            bool Respuesta = false; // Variable para almacenar el resultado
            Mensaje = string.Empty; // Variable para almacenar el mensaje de salida

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Configuramos el comando para el procedimiento almacenado SP_EDITARUSUARIO
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", ObjUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("nombre_usuario", ObjUsuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("password", ObjUsuario.passwordUsuario);
                    cmd.Parameters.AddWithValue("id_persona", ObjUsuario.oPersona.idPersona);
                    cmd.Parameters.AddWithValue("id_rol", ObjUsuario.oRol.idRol);

                    // Parámetros de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un stored procedure
                    oconexion.Open();

                    // Ejecutamos el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // En caso de error, devolvemos false y el mensaje de la excepción
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta; // Retornamos la respuesta o false en caso de error
        }

        // Método para eliminar un usuario en la base de datos
        public bool Eliminar(Usuario ObjUsuario, out string Mensaje)
        {
            bool Respuesta = false; // Variable para almacenar el resultado
            Mensaje = string.Empty; // Variable para almacenar el mensaje de salida

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Configuramos el comando para el procedimiento almacenado SP_ELIMINARUSUARIO
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", ObjUsuario.idUsuario);

                    // Parámetros de salida
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un stored procedure
                    oconexion.Open();

                    // Ejecutamos el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // En caso de error, devolvemos false y el mensaje de la excepción
                Respuesta = false;
                Mensaje = ex.Message;
            }
            return Respuesta; // Retornamos la respuesta o false en caso de error
        }
    }

}
