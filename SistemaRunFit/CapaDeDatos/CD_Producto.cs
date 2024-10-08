using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

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
                    query.AppendLine("SELECT p.id_producto, p.nombre_producto, p.precio_compra, p.precio_venta, p.stock, p.stock_minimo, p.imagen, p.fecha_alta, p.fecha_baja,");
                    query.AppendLine("m.nombre as marca_nombre, c.nombre_categoria, pv.razon_social");
                    query.AppendLine("FROM productos p");
                    query.AppendLine("INNER JOIN MARCAS m ON m.id_marca = p.id_marca");
                    query.AppendLine("INNER JOIN CATEGORIAS c ON c.id_categoria = p.id_categoria");
                    query.AppendLine("INNER JOIN PROVEEDORES pv ON pv.id_proveedor = p.id_proveedor");
                    query.AppendLine("ORDER BY p.fecha_baja ASC;");

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
                                precioCompra = (double)dr["precio_compra"],
                                precioVenta = (double)dr["precio_venta"],
                                stock = Convert.ToInt32(dr["stock"]),
                                stockMinimo = Convert.ToInt32(dr["stock_minimo"]),

                                // Corregido: uso del nombre de la columna en lugar del índice
                                Imagen = dr["imagen"] == DBNull.Value ? null : (byte[])dr["imagen"],

                                fechaAlta = dr["fecha_alta"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_alta"]),
                                fechaBaja = dr["fecha_baja"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["fecha_baja"]),

                                oMarca = new Marca() { nombre = dr["marca_nombre"].ToString() },
                                oCategoria = new Categoria() { nombre_categoria = dr["nombre_categoria"].ToString() },
                                oProveedor = new Proveedor() { razonSocial = dr["razon_social"].ToString() }
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
            int IdProductoGenerado = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_PRODUCTO_REGISTRAR", oconexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre_producto", SqlDbType.VarChar).Value = ObjProducto.nombre;
                    cmd.Parameters.AddWithValue("@precio_compra", SqlDbType.Decimal).Value = ObjProducto.precioCompra;
                    cmd.Parameters.AddWithValue("@precio_venta", SqlDbType.Decimal).Value = ObjProducto.precioVenta;
                    cmd.Parameters.AddWithValue("@id_marca", SqlDbType.Int).Value = ObjProducto.oMarca.idMarca;
                    cmd.Parameters.AddWithValue("@id_categoria", SqlDbType.Int).Value = ObjProducto.oCategoria.idCategoria;
                    cmd.Parameters.AddWithValue("@id_proveedor", SqlDbType.Int).Value = ObjProducto.oProveedor.idProveedor;
                    cmd.Parameters.AddWithValue("@stock", SqlDbType.Int).Value = ObjProducto.stock;
                    cmd.Parameters.AddWithValue("@stock_minimo", SqlDbType.Int).Value = ObjProducto.stockMinimo;
                    cmd.Parameters.AddWithValue("@detalle", SqlDbType.VarChar).Value = ObjProducto.detalle;
                    cmd.Parameters.AddWithValue("@imagen", (object)ObjProducto.Imagen ?? DBNull.Value);

                    cmd.Parameters.Add("@IdProductoResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    IdProductoGenerado = (int)cmd.Parameters["@IdProductoResultado"].Value;
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                IdProductoGenerado = 0;
                Mensaje = ex.Message;
            }
            return IdProductoGenerado;
        }



    }
}
