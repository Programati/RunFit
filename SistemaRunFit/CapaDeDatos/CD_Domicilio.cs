using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

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
                    query.AppendLine("SELECT d.id_domicilio, d.calle, d.altura, d.casa, d.manzana, d.departamento, d.piso, d.id_persona, p.dni, p.nombre, p.apellido, p.email, p.telefono, p.fecha_nacimiento, p.sexo FROM DOMICILIOS d");
                    query.AppendLine("inner join PERSONAS p on p.id_persona = d.id_persona");
                    query.AppendLine("WHERE d.id_persona = p.id_persona");


                    

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
                                oPersona = new Persona { idPersona = Convert.ToInt32(dr["id_persona"]), dni = dr["dni"].ToString(), nombre = dr["nombre"].ToString(), apellido = dr["apellido"].ToString(), email = dr["email"].ToString(), telefono = dr["telefono"].ToString(), fechaNacimiento = dr["fecha_nacimiento"].ToString(), sexo = Convert.ToChar(dr["sexo"]) }
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
    }
}
