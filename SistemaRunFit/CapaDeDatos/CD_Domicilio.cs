using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace CapaDeDatos
{
    public class CD_Domicilio
    {
        public List<Domicilio> ListarDomicilios()
        {
            List<Domicilio> Lista = new List<Domicilio>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT d.id_domicilio, d.calle, d.altura, d.casa, d.manzana, d.departamento, d.piso, d.id_persona, p.dni, p.nombre, p.apellido, p.email, p.telefono, p.fecha_nacimiento, p.sexo,p.estado FROM DOMICILIOS d");
                    query.AppendLine("inner join PERSONAS p on p.id_persona = d.id_persona");
                    query.AppendLine("WHERE d.id_persona = p.id_persona");
                    query.AppendLine("order by p.estado desc");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        { 
                            Lista.Add(new Domicilio()
                            {
                                idDomicilio = Convert.ToInt32(dr["id_domicilio"]),
                                calle = dr["calle"].ToString(),
                                altura = dr["altura"].ToString(),
                                piso = dr["piso"].ToString(),
                                departamento = dr["departamento"].ToString(),
                                manzana = dr["manzana"].ToString(),
                                casa = dr["casa"].ToString(),
                                oPersona = new Persona
                                {
                                    idPersona = Convert.ToInt32(dr["id_persona"]),
                                    dni = dr["dni"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString(),
                                    email = dr["email"].ToString(),
                                    telefono = dr["telefono"].ToString(),
                                    fechaNacimiento = dr["fecha_nacimiento"].ToString(),
                                    sexo = Convert.ToChar(dr["sexo"]),
                                    estado= Convert.ToChar(dr["estado"]),
                                }
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Domicilio>();
                }
            }
            return Lista;
        }

        public int Registrar(Domicilio ObjDomicilio, out string Mensaje)
        {
            int IdDomicilioGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_DOMICILIO_REGISTRAR", oconexion);
                    cmd.Parameters.AddWithValue("calle", ObjDomicilio.calle);
                    cmd.Parameters.AddWithValue("altura", ObjDomicilio.altura);
                    cmd.Parameters.AddWithValue("casa", ObjDomicilio.casa);
                    cmd.Parameters.AddWithValue("manzana", ObjDomicilio.manzana);
                    cmd.Parameters.AddWithValue("departamento", ObjDomicilio.departamento);
                    cmd.Parameters.AddWithValue("piso", ObjDomicilio.piso);
                    cmd.Parameters.AddWithValue("id_persona", ObjDomicilio.oPersona.idPersona);

                    cmd.Parameters.Add("IdDomicilioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdDomicilioGenerado = (int)cmd.Parameters["IdDomicilioResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdDomicilioGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdDomicilioGenerado;
        }

        public bool Editar(Domicilio ObjDomicilio, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) 
                {
                    SqlCommand cmd = new SqlCommand("SP_DOMICILIO_EDITAR", oconexion);
                    cmd.Parameters.AddWithValue("@id_domicilio", ObjDomicilio.idDomicilio);
                    cmd.Parameters.AddWithValue("calle", ObjDomicilio.calle);
                    cmd.Parameters.AddWithValue("altura", ObjDomicilio.altura);
                    cmd.Parameters.AddWithValue("casa", ObjDomicilio.casa);
                    cmd.Parameters.AddWithValue("manzana", ObjDomicilio.manzana);
                    cmd.Parameters.AddWithValue("departamento", ObjDomicilio.departamento);
                    cmd.Parameters.AddWithValue("piso", ObjDomicilio.piso);
                    cmd.Parameters.AddWithValue("id_persona", ObjDomicilio.oPersona.idPersona);

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
