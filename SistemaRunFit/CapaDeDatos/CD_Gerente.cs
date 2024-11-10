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
   
public class CD_Gerente
    {
        public List<ReporteGrafico> ReporteGerente_1(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ReporteGrafico> listaGrafico = new List<ReporteGrafico>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL con filtro de fechas
                    string consulta = @"
            SELECT 
                u.nombre_usuario AS vendedor, 
                SUM(dv.cantidad) AS cantidad_total,
                SUM(dv.subtotal) AS importe_total
            FROM 
                usuarios u
            INNER JOIN 
                ventas v ON v.id_usuario = u.id_usuario
            INNER JOIN 
                detalle_ventas dv ON dv.id_venta = v.id_venta
            WHERE 
                v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
            GROUP BY 
                u.nombre_usuario
            ORDER BY 
                importe_total DESC;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Asignación de parámetros de fecha
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de ReporteGrafico
                            ReporteGrafico grafico = new ReporteGrafico
                            {
                                Vendedor = dr["vendedor"].ToString(), // Nombre del vendedor
                                SubTotal = Convert.ToDouble(dr["importe_total"]) // Importe total
                            };

                            listaGrafico.Add(grafico);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    listaGrafico = new List<ReporteGrafico>(); // Retorna lista vacía en caso de error
                                                               // Aquí puedes agregar más lógica para manejar el error (logging, etc.)
                }
            }

            return listaGrafico; // Retorna la lista para el gráfico
        }

        public List<ReporteGrafico> ReporteGerente_2(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ReporteGrafico> listaGrafico = new List<ReporteGrafico>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener el reporte con filtros de fecha
                    string consulta = @"
            SELECT TOP 5
                p.nombre_producto,
                SUM(dv.cantidad) AS cantidad_total
            FROM 
                productos p
            INNER JOIN 
                detalle_ventas dv ON p.id_producto = dv.id_producto
            INNER JOIN 
                ventas v ON dv.id_venta = v.id_venta
            WHERE 
                v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
            GROUP BY 
                p.nombre_producto
                order by cantidad_total desc;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Asignación de parámetros de fecha
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de ReporteGrafico
                            ReporteGrafico reporte = new ReporteGrafico
                            {
                                Producto = dr["nombre_producto"].ToString(), // Asigna el nombre del producto
                                Cantidad = Convert.ToInt32(dr["cantidad_total"]) // Asigna la cantidad total
                            };

                            listaGrafico.Add(reporte);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, puedes registrar el error en un log
                    listaGrafico = new List<ReporteGrafico>(); // Retornar lista vacía en caso de error
                }
            }

            return listaGrafico; // Retorna la lista de ReporteGrafico
        }




        public List<ReporteGrafico> ReporteGerente_3(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ReporteGrafico> listaGrafico = new List<ReporteGrafico>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener el reporte con filtros de fecha
                    string consulta = @"
            SELECT TOP 5
                p.nombre_producto,
                 SUM(dv.subtotal) AS monto_total
            FROM 
                productos p
            INNER JOIN 
                detalle_ventas dv ON p.id_producto = dv.id_producto
            INNER JOIN 
                ventas v ON dv.id_venta = v.id_venta
            WHERE 
                v.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
            GROUP BY 
                p.nombre_producto
                order by monto_total desc;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Asignación de parámetros de fecha
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de ReporteGrafico
                            ReporteGrafico reporte = new ReporteGrafico
                            {
                                Producto = dr["nombre_producto"].ToString(), // Asigna el nombre del producto
                                SubTotal = Convert.ToDouble(dr["monto_total"]) // Importe total
                            };

                            listaGrafico.Add(reporte);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, puedes registrar el error en un log
                    listaGrafico = new List<ReporteGrafico>(); // Retornar lista vacía en caso de error
                }
            }

            return listaGrafico; // Retorna la lista de ReporteGrafico
        }
        public List<Venta> ReporteGerente4(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Crear la consulta SQL directamente
                    string consulta = @"
                SELECT 
                    u.fecha_factura AS Fecha,
                    df.id_venta AS Factura,
                    us.nombre_usuario AS Vendedor, 
                    df.cantidad, 
                    df.subtotal, 
                    pr.nombre_producto AS Producto
                FROM 
                    DETALLE_VENTAS df
                INNER JOIN 
                    ventas u ON df.id_venta = u.id_venta
                INNER JOIN 
                    usuarios us ON u.id_usuario = us.id_usuario
                INNER JOIN 
                    productos pr ON df.id_producto = pr.id_producto
                WHERE 
                    u.fecha_factura BETWEEN @fechaDesde AND @fechaHasta 
                   order by u.fecha_factura DESC;";

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Agregar los parámetros de fecha
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                // Manejar la fecha de la venta
                                fechaFactura = dr["Fecha"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha"]).ToString("yyyy-MM-dd") : string.Empty, // O establece otra cadena predeterminada si es necesario

                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                               idDetalleVenta = dr["Factura"] != DBNull.Value ? Convert.ToInt32(dr["Factura"]) : 0,

                                cantidad = dr["cantidad"] != DBNull.Value ? Convert.ToInt32(dr["cantidad"]) : 0,
                                subTotal = dr["subtotal"] != DBNull.Value ? Convert.ToDouble(dr["subtotal"]) : 0.0,
                                oProducto = new Producto
                                {
                                    nombre = dr["Producto"] != DBNull.Value ? dr["Producto"].ToString() : "Sin nombre"
                                },
                                oVenta = new Venta
                                {
                                    idVenta = dr["Factura"] != DBNull.Value ? Convert.ToInt32(dr["Factura"]) : 0,
                                }
                            }
                        },

                                oUsuario = new Usuario
                                {
                                    nombreUsuario = dr["Vendedor"] != DBNull.Value ? dr["Vendedor"].ToString() : "Desconocido"
                                }
                            };

                            lista.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo del error (opcionalmente podrías loguear el error)
                    lista = new List<Venta>(); // Retorna una lista vacía en caso de error
                }
            }

            return lista;
        }
        public List<Venta> ReporteGerente5()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Crear la consulta SQL directamente
                    string consulta = @"
                SELECT 
                    nombre_producto,
                    detalle_producto,
                    stock,
                    stock_minimo,
                    m.id_marca AS idMarca, -- Incluimos el ID de la marca
                    m.nombre AS marca, 
                    c.id_categoria AS idCategoria, -- Incluimos el ID de la categoría
                    c.nombre_categoria AS categoria,
                    p.id_proveedor AS idProveedor, -- Incluimos el ID del proveedor
                    p.razon_social AS proveedor
                FROM 
                    productos pr
                INNER JOIN 
                    MARCAS m ON m.id_marca = pr.id_marca
                INNER JOIN 
                    CATEGORIAS c ON c.id_categoria = pr.id_categoria
                INNER JOIN 
                    PROVEEDORES p ON p.id_proveedor = pr.id_proveedor
                WHERE 
                    stock = stock_minimo + 5 OR stock <= stock_minimo;";

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                
                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                                
                                idDetalleVenta = 0, 

                                
                                cantidad = 1, // Cambia según la lógica de negocio
                                subTotal = 0.0, // No se especifica en la consulta

                                oProducto = new Producto
                                {
                                    nombre = dr["nombre_producto"] != DBNull.Value ? dr["nombre_producto"].ToString() : "Sin nombre",
                                    detalle = dr["detalle_producto"] != DBNull.Value ? dr["detalle_producto"].ToString() : "Sin detalle",
                                    stock = dr["stock"] != DBNull.Value ? Convert.ToInt32(dr["stock"]) : 0,
                                    stockMinimo = dr["stock_minimo"] != DBNull.Value ? Convert.ToInt32(dr["stock_minimo"]) : 0,
                                    oMarca = new Marca
                                    {
                                        idMarca = dr["idMarca"] != DBNull.Value ? Convert.ToInt32(dr["idMarca"]) : 0,
                                        nombre = dr["marca"] != DBNull.Value ? dr["marca"].ToString() : "Sin marca"
                                    },
                                    oCategoria = new Categoria
                                    {
                                        idCategoria = dr["idCategoria"] != DBNull.Value ? Convert.ToInt32(dr["idCategoria"]) : 0,
                                        nombre_categoria = dr["categoria"] != DBNull.Value ? dr["categoria"].ToString() : "Sin categoría"
                                    },
                                    oProveedor = new Proveedor
                                    {
                                        idProveedor = dr["idProveedor"] != DBNull.Value ? Convert.ToInt32(dr["idProveedor"]) : 0,
                                        razonSocial = dr["proveedor"] != DBNull.Value ? dr["proveedor"].ToString() : "Sin proveedor"
                                    }
                                }
                            }
                        }
                            };

                            lista.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo del error (opcionalmente podrías loguear el error)
                    lista = new List<Venta>(); // Retorna una lista vacía en caso de error
                }
            }

            return lista;
        }
        public List<Venta> ReporteGerente6(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Crear la consulta SQL directamente
                    string consulta = @"
                SELECT 
                    u.fecha_factura AS Fecha,
                    df.id_venta AS Factura,
                    us.nombre_usuario AS Vendedor, 
                    df.cantidad, 
                    df.subtotal, 
                    pr.nombre_producto AS Producto
                FROM 
                    DETALLE_VENTAS df
                INNER JOIN 
                    ventas u ON df.id_venta = u.id_venta
                INNER JOIN 
                    usuarios us ON u.id_usuario = us.id_usuario
                INNER JOIN 
                    productos pr ON df.id_producto = pr.id_producto
                WHERE 
                    u.id_usuario = @idUsuario
                    AND u.fecha_factura BETWEEN @fechaDesde AND @fechaHasta
                ORDER BY 
                    u.fecha_factura DESC;";  // Asegúrate de usar el alias correcto aquí

                    // Crear el comando para ejecutar la consulta
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    // Agregar los parámetros de entrada
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                    oconexion.Open();

                    // Ejecutar el lector para obtener los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Venta venta = new Venta
                            {
                                // Manejar la fecha de la venta
                                fechaFactura = dr["Fecha"] != DBNull.Value ? Convert.ToDateTime(dr["Fecha"]).ToString("yyyy-MM-dd") : string.Empty, // O establece otra cadena predeterminada si es necesario

                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                               idDetalleVenta = dr["Factura"] != DBNull.Value ? Convert.ToInt32(dr["Factura"]) : 0,

                                cantidad = dr["cantidad"] != DBNull.Value ? Convert.ToInt32(dr["cantidad"]) : 0,
                                subTotal = dr["subtotal"] != DBNull.Value ? Convert.ToDouble(dr["subtotal"]) : 0.0,
                                oProducto = new Producto
                                {
                                    nombre = dr["Producto"] != DBNull.Value ? dr["Producto"].ToString() : "Sin nombre"
                                },
                                oVenta = new Venta
                                {
                                    idVenta = dr["Factura"] != DBNull.Value ? Convert.ToInt32(dr["Factura"]) : 0,
                                }
                            }
                        },

                                oUsuario = new Usuario
                                {
                                    nombreUsuario = dr["Vendedor"] != DBNull.Value ? dr["Vendedor"].ToString() : "Desconocido"
                                }
                            };

                            lista.Add(venta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo del error (puedes registrar el error si lo deseas)
                    lista = new List<Venta>(); // Retorna una lista vacía en caso de error
                }
            }

            return lista;
        }





    }


}

