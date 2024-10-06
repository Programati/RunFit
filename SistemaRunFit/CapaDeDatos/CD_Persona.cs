using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using System.Net;

namespace CapaDeDatos
{
    public class CD_Persona
    {
        public List<Persona> ListarPersonas()
        {
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = " SELECT id_persona, dni, nombre, apellido, email, telefono, fecha_nacimiento, sexo,estado FROM PERSONAS";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Persona()
                            {
                                idPersona = Convert.ToInt32(dr["id_persona"]),
                                dni = dr["dni"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                fechaNacimiento = dr["fecha_nacimiento"].ToString(),
                                sexo = Convert.ToChar(dr["sexo"]),
                                estado = Convert.ToChar(dr["estado"]),
                            });
                            
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Persona>();
                }
            }
            return Lista;
        }

        public int Registrar(Persona ObjPersona, out string Mensaje)
        {
            int IdPersonaGenerada = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PERSONA_REGISTRAR", oconexion);
                    cmd.Parameters.AddWithValue("dni", ObjPersona.dni);
                    cmd.Parameters.AddWithValue("nombre", ObjPersona.nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjPersona.apellido);
                    cmd.Parameters.AddWithValue("email", ObjPersona.email);
                    cmd.Parameters.AddWithValue("telefono", ObjPersona.telefono);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", ObjPersona.fechaNacimiento);
                    cmd.Parameters.AddWithValue("sexo", ObjPersona.sexo);

                    cmd.Parameters.Add("IdPersonaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();
                    IdPersonaGenerada = (int)cmd.Parameters["IdPersonaResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                IdPersonaGenerada = 0;
                Mensaje = ex.Message;
            }
            return IdPersonaGenerada;
        }

        public bool Editar(Persona ObjPersona, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PERSONA_EDITAR", oconexion);
                    cmd.Parameters.AddWithValue("@id_persona", ObjPersona.idPersona);
                    cmd.Parameters.AddWithValue("dni", ObjPersona.dni);
                    cmd.Parameters.AddWithValue("nombre", ObjPersona.nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjPersona.apellido);
                    cmd.Parameters.AddWithValue("email", ObjPersona.email);
                    cmd.Parameters.AddWithValue("telefono", ObjPersona.telefono);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", ObjPersona.fechaNacimiento);
                    cmd.Parameters.AddWithValue("sexo", ObjPersona.sexo);
                   
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
        public bool Eliminar(Persona ObjPersona, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PERSONA_ELIMINAR", oconexion);
                    cmd.Parameters.AddWithValue("@id_persona", ObjPersona.idPersona);
                    SqlParameter respuestaParam = new SqlParameter("@Respuesta", SqlDbType.Char, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(respuestaParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = (respuestaParam.Value.ToString() == "1");
                    Mensaje = mensajeParam.Value.ToString();
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
