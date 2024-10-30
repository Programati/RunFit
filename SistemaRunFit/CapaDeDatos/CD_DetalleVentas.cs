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
    public class CD_DetalleVentas
    {
        public int Registrar(DetalleVenta ObjDetalleVenta, out string Mensaje)
        {

            int IdDetalleVentaGenerado = 0;
            Mensaje = string.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_DETALLE_VENTAS_REGISTRAR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cantidad", ObjDetalleVenta.cantidad);
                    cmd.Parameters.AddWithValue("@subtotal", ObjDetalleVenta.subTotal);
                    cmd.Parameters.AddWithValue("@id_producto", ObjDetalleVenta.oProducto.idProducto);
                    cmd.Parameters.AddWithValue("@id_venta", ObjDetalleVenta.oVenta.idVenta);

                    cmd.Parameters.Add("@IdDetalleVentaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    IdDetalleVentaGenerado = (int)cmd.Parameters["@IdDetalleVentaResultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdDetalleVentaGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdDetalleVentaGenerado;
        }
    }
}
