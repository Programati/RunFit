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
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id_usuario, nombre_usuario, password, id_rol from USUARIOS";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["id_usuario"]),
                                nombreUsuario = dr["nombre_usuario"].ToString(),
                                passwordUsuario = dr["password"].ToString(),
                                oRol = new Rol { idRol = Convert.ToInt32(dr["id_rol"]) }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
