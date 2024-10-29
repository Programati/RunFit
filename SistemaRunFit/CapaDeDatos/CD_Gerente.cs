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
            SELECT 
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
            SELECT 
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

    }


}

