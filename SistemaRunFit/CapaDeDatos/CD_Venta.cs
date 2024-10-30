using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CapaDeDatos
{
    public class CD_Venta
    {
        public Venta ObtenerVentaPorId(int idVenta)
        {
            Venta _venta = new Venta();
            List<DetalleVenta> _detalleVenta = new List<DetalleVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT v.id_venta, v.importe_total, v.fecha_factura,");
                    query.AppendLine("u.nombre_usuario,");
                    query.AppendLine("p.apellido, p.nombre, p.dni, p.telefono, p.email,");
                    query.AppendLine("d.calle, d.altura, d.manzana, d.casa, d.piso, d.departamento,");
                    query.AppendLine("dv.cantidad, prod.nombre_producto, prod.detalle_producto,");
                    query.AppendLine("prod.precio_venta, dv.subtotal");
                    query.AppendLine("FROM VENTAS v");
                    query.AppendLine("JOIN DETALLE_VENTAS dv ON dv.id_venta = v.id_venta");
                    query.AppendLine("JOIN PERSONAS p ON p.id_persona = v.id_cliente");
                    query.AppendLine("JOIN USUARIOS u ON u.id_usuario = v.id_usuario");
                    query.AppendLine("JOIN PRODUCTOS prod ON prod.id_producto = dv.id_producto");
                    query.AppendLine("JOIN DOMICILIOS d ON d.id_persona = v.id_cliente");
                    query.AppendLine("WHERE v.id_venta = @idVenta");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _venta.idVenta = Convert.ToInt32(dr["id_venta"]);
                            _venta.importeTotal = Convert.ToDouble(dr["importe_total"]);
                            _venta.fechaFactura = Convert.ToDateTime(dr["fecha_factura"]).ToString("dd/MM/yyyy");
                            _venta.oUsuario = new Usuario()
                            {
                                nombreUsuario = dr["nombre_usuario"].ToString()
                            };
                            _venta.oCliente = new Domicilio()
                            {
                                oPersona = new Persona()
                                {
                                    apellido = dr["apellido"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    dni = dr["dni"].ToString(),
                                    telefono = dr["telefono"].ToString(),
                                    email = dr["email"].ToString(),
                                },
                                calle = dr["calle"].ToString(),
                                altura = dr["altura"].ToString(),
                                manzana = dr["manzana"].ToString(),
                                casa = dr["casa"].ToString(),
                                piso = dr["piso"].ToString(),
                                departamento = dr["departamento"].ToString(),
                            };
                            
                            
                            _detalleVenta.Add(new DetalleVenta()
                            {
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                oProducto = new Producto()
                                {
                                    nombre = dr["nombre_producto"].ToString(),
                                    detalle = dr["detalle_producto"].ToString(),
                                    precioVenta = Convert.ToDouble(dr["precio_venta"])
                                },
                                subTotal = Convert.ToDouble(dr["subtotal"]),
                            });
                        }
                        _venta.oDetalleVenta = _detalleVenta;
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    _venta = new Venta();
                }
            }
            return _venta;
        }
        public List<Venta> UltimasVentas()
        {
            List<Venta> _ListaVenta = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT top(15) v.id_venta, v.fecha_factura, p.apellido,");
                    query.AppendLine("p.nombre, v.importe_total, u.nombre_usuario");
                    query.AppendLine("FROM VENTAS v");
                    query.AppendLine("JOIN USUARIOS u ON u.id_usuario = v.id_usuario");
                    query.AppendLine("JOIN PERSONAS p ON p.id_persona = v.id_cliente");
                    query.AppendLine("ORDER BY v.fecha_factura DESC");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _ListaVenta.Add(new Venta()
                            {
                                idVenta = Convert.ToInt32(dr["id_venta"]),
                                fechaFactura = Convert.ToDateTime(dr["fecha_factura"]).ToString("dd/MM/yyyy"),
                                oCliente = new Domicilio
                                {
                                    oPersona = new Persona
                                    {
                                        apellido = dr["apellido"].ToString(),
                                        nombre = dr["nombre"].ToString()
                                    }
                                },
                                importeTotal = Convert.ToDouble(dr["importe_total"]),
                                oUsuario = new Usuario
                                {
                                    nombreUsuario = dr["nombre_usuario"].ToString()
                                }
                            });
                        }
                        dr.Close();
                        oconexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    _ListaVenta = new List<Venta>();
                }
            }

            return _ListaVenta;
        }
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
                    cmd.Parameters.AddWithValue("@id_cliente", ObjVenta.oCliente.oPersona.idPersona);
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
