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
    public class CD_Persona
    {
        public List<Persona> ListarPersonas()
        {
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = " SELECT id_persona, dni, nombre, apellido, email, telefono, fecha_nacimiento, sexo FROM PERSONAS";

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
                                sexo = Convert.ToChar(dr["sexo"])
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
    }
}
