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
        public List<Venta> ReporteGerente_1()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener el reporte
                    string consulta = @"
                SELECT 
                    u.nombre_usuario AS vendedor, 
                    p.nombre_producto,
                    SUM(dv.cantidad) AS cantidad_total
                FROM 
                    usuarios u
                INNER JOIN 
                    ventas v ON v.id_usuario = u.id_usuario
                INNER JOIN 
                    detalle_ventas dv ON dv.id_venta = v.id_venta
                INNER JOIN 
                    productos p ON p.id_producto = dv.id_producto
                GROUP BY 
                    u.nombre_usuario, p.nombre_producto
                ORDER BY 
                    cantidad_total DESC;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de Venta
                            Venta venta = new Venta
                            {
                                // Asignar el objeto Usuario
                                oUsuario = new Usuario
                                {
                                    nombreUsuario = dr["vendedor"].ToString() // Obtener el nombre del vendedor
                                },
                                oDetalleVenta = new List<DetalleVenta>
                            {
                                new DetalleVenta
                                {
                                    cantidad = Convert.ToInt32(dr["cantidad_total"]),
                                    // Asignar valores adicionales según lo necesites
                                    subTotal = 0, // Asigna el subtotal adecuado aquí
                                    oProducto = new Producto
                                    {
                                        nombre = dr["nombre_producto"].ToString(),
                                        precioVenta = 0 // Asigna el precio correcto aquí
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
                    // Manejo de errores, puedes registrar el error en un log
                    lista = new List<Venta>(); // Retornar lista vacía en caso de error
                }
            }

            return lista; // Retorna la lista de ventas
        }
        public List<Venta> ReporteGerente_2()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener el reporte
                    string consulta = @"
                SELECT 
                    p.nombre_producto,
                    SUM(dv.cantidad) AS cantidad_total
                FROM 
                    productos p
                INNER JOIN 
                    detalle_ventas dv ON p.id_producto = dv.id_producto
                GROUP BY 
                    p.nombre_producto;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de Venta
                            Venta venta = new Venta
                            {
                                oDetalleVenta = new List<DetalleVenta>
                        {
                            new DetalleVenta
                            {
                                cantidad = Convert.ToInt32(dr["cantidad_total"]),
                                // Asignar valores adicionales según lo necesites
                                subTotal = 0, // Asigna el subtotal adecuado aquí
                                oProducto = new Producto
                                {
                                    nombre = dr["nombre_producto"].ToString(),
                                    precioVenta = 0 // Asigna el precio correcto aquí si es necesario
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
                    // Manejo de errores, puedes registrar el error en un log
                    lista = new List<Venta>(); // Retornar lista vacía en caso de error
                }
            }

            return lista; // Retorna la lista de ventas
        }
        public List<Venta> ReporteGerente_3()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Consulta SQL para obtener el reporte
                    string consulta = @"
                	WITH VentasMaximas AS (
                    SELECT 
                        u.nombre_usuario AS vendedor,
                        p.nombre_producto,
                        SUM(dv.cantidad) AS cantidad_total,
                        ROW_NUMBER() OVER (PARTITION BY p.nombre_producto ORDER BY SUM(dv.cantidad) DESC) AS fila
                    FROM 
                        usuarios u
                    INNER JOIN 
                        ventas v ON v.id_usuario = u.id_usuario
                    INNER JOIN 
                        detalle_ventas dv ON dv.id_venta = v.id_venta
                    INNER JOIN 
                        productos p ON p.id_producto = dv.id_producto
                    GROUP BY 
                        u.nombre_usuario, p.nombre_producto
                )
                SELECT 
                    vendedor, 
                    nombre_producto, 
                    cantidad_total
                FROM 
                    VentasMaximas
                WHERE 
                    fila = 1;";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Crear una nueva instancia de Venta
                            Venta venta = new Venta
                            {
                                // Asignar el objeto Usuario
                                oUsuario = new Usuario
                                {
                                    nombreUsuario = dr["vendedor"].ToString() // Obtener el nombre del vendedor
                                },
                                oDetalleVenta = new List<DetalleVenta>
                            {
                                new DetalleVenta
                                {
                                    cantidad = Convert.ToInt32(dr["cantidad_total"]),
                                    // Asignar valores adicionales según lo necesites
                                    subTotal = 0, // Asigna el subtotal adecuado aquí
                                    oProducto = new Producto
                                    {
                                        nombre = dr["nombre_producto"].ToString(),
                                        precioVenta = 0 // Asigna el precio correcto aquí
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
                    // Manejo de errores, puedes registrar el error en un log
                    lista = new List<Venta>(); // Retornar lista vacía en caso de error
                }
            }

            return lista; // Retorna la lista de ventas
        }

    }


}

