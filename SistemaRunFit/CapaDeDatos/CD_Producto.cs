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
    public class CD_Producto
    {
        public List<Producto> ListarProducto()
        {
            List<Producto> Lista = new List<Producto>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id_producto, p.nombre_producto, p.precio_compra,p.precio_venta, p.stock, p.stock_minimo, p.imagen,");
                    query.AppendLine("m.nombre as marca_nombre, c.nombre_categoria, pv.razon_social");
                    query.AppendLine("from productos p");
                    query.AppendLine("inner join MARCAS m on m.id_marca = p.id_marca");
                    query.AppendLine("inner join CATEGORIAS c on c.id_categoria = p.id_categoria");
                    query.AppendLine("inner join PROVEEDORES pv on pv.id_proveedor = p.id_proveedor");
                    query.AppendLine("order by p.fecha_baja asc;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Producto()
                            {
                                idProducto = Convert.ToInt32(dr["id_producto"]),
                                nombre = dr["nombre_producto"].ToString(),
                                precioCompra = Convert.ToDecimal(dr["precio_compra"]),
                                precioVenta = Convert.ToDecimal(dr["precio_venta"]),
                                stock = Convert.ToInt32(dr["stock"]),
                                stockMinimo = Convert.ToInt32(dr["stock_minimo"]),
                                imagen = dr["imagen"].ToString(),
                                     oMarca = new Marca(){nombre = dr["marca_nombre"].ToString(),},
                                    oCategoria = new Categoria(){nombre_categoria = dr["nombre_categoria"].ToString(),},
                                    oProveedor = new Proveedor(){razonSocial = dr["razon_social"].ToString(),}
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Producto>();
                }
            }
            return Lista;
        }
        public int Registrar(Producto ObjProducto, out string Mensaje)
        {
            int IdProductoGenerado = 0; // Variable para almacenar el id generado
            Mensaje = string.Empty; // Variable para almacenar el mensaje de salida

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Configuramos el comando para el procedimiento almacenado SP_AGREGAR_PRODUCTO
                    SqlCommand cmd = new SqlCommand("SP_AGREGAR_PRODUCTO", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure; // Indicamos que es un stored procedure

                    // Agregamos los parámetros
                    cmd.Parameters.Add("@nombre_producto", SqlDbType.VarChar).Value = ObjProducto.nombre;
                    cmd.Parameters.Add("@precio_compra", SqlDbType.Decimal).Value = ObjProducto.precioCompra;
                    cmd.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = ObjProducto.precioVenta;
                    cmd.Parameters.Add("@id_marca", SqlDbType.Int).Value = ObjProducto.oMarca.idMarca; // Asegúrate de que este ID exista en la clase Marca
                    cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = ObjProducto.oCategoria.idCategoria; // Asegúrate de que este ID exista en la clase Categoria
                    cmd.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = ObjProducto.oProveedor.idProveedor; // Asegúrate de que este ID exista en la clase Proveedor
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = ObjProducto.stock;
                    cmd.Parameters.Add("@stock_minimo", SqlDbType.Int).Value = ObjProducto.stockMinimo;
                    cmd.Parameters.Add("@detalle", SqlDbType.VarChar).Value = ObjProducto.detalle;
                    cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = string.IsNullOrEmpty(ObjProducto.imagen) ? (object)DBNull.Value : ObjProducto.imagen;


                    // Parámetros de salida
                    cmd.Parameters.Add("@IdProductoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();

                    // Ejecutamos el procedimiento almacenado
                    cmd.ExecuteNonQuery();

                    // Obtenemos los valores de los parámetros de salida
                    IdProductoGenerado = (int)cmd.Parameters["@IdProductoResultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdProductoGenerado = 0;
                Mensaje = ex.Message;
                // Considera registrar el error en un log
            }
            return IdProductoGenerado; // Retornamos el ID generado o 0 en caso de error
        }



    }
}
