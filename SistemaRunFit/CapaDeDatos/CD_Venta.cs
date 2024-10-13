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
    public class CD_Venta
    {
        public int Registrar(Venta ObjVenta, out string Mensaje)
        {
            int IdVentaGenerada = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_VENTAS_REGISTRAR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@importe_total", ObjVenta.importeTotal);
                    cmd.Parameters.AddWithValue("@id_usuario", ObjVenta.oUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("@id_cliente", ObjVenta.oCliente.idPersona);
                    cmd.Parameters.Add("@IdVentaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    IdVentaGenerada = (int)cmd.Parameters["@IdVentaResultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdVentaGenerada = 0;
                Mensaje = ex.Message;
            }
            return IdVentaGenerada;
        }
    }
}
