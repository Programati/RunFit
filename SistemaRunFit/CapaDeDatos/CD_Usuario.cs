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
                    query.AppendLine("SELECT u.id_usuario, u.nombre_usuario, u.password, u.fecha_alta, u.fecha_baja, u.id_persona, r.id_rol, r.nombre_rol from USUARIOS u");
                    query.AppendLine("inner join ROL r on r.id_rol = u.id_rol");

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
                                fechaBaja = dr["fecha_baja"].ToString(),
                                oRol = new Rol { idRol = Convert.ToInt32(dr["id_rol"]), nombreRol = dr["nombre_rol"].ToString() },
                                oPersona = new Persona { idPersona = Convert.ToInt32(dr["id_persona"]) }
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
    }
}
