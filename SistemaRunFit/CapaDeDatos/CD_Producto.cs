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
                    query.AppendLine("select p.id_producto, p.nombre_producto, p.precio_compra, p.stock, p.stock_minimo, p.imagen,");
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

    }
}
