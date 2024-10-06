using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> Lista = new List<Rol>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id_rol, nombre_rol, fecha_alta, fecha_baja from ROL";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text; 
                   
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Rol()
                            {
                                idRol = Convert.ToInt32(dr["id_rol"]),
                                nombreRol = dr["nombre_rol"].ToString(),
                                fechaAlta = dr["fecha_alta"].ToString(),
                                fechaBaja = dr["fecha_baja"].ToString()
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Rol>();
                }
            }
            return Lista;
        }
    }
}
