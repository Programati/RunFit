using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        public List<Producto> ListarProductos()
        {
            return objcd_producto.ListarProducto();
        }
        public int Registrar(Producto ObjProducto, out string Mensaje)
        {
            StringBuilder sbMensaje = new StringBuilder();

            if (string.IsNullOrWhiteSpace(ObjProducto.nombre))
            {
                sbMensaje.AppendLine("El Nombre es necesario para cargar la BD.");
            }

            if (ObjProducto.precioCompra <= 0)
            {
                sbMensaje.AppendLine("El Precio de Compra debe ser mayor que cero.");
            }

            if (ObjProducto.precioVenta <= 0)
            {
                sbMensaje.AppendLine("El Precio de Venta debe ser mayor que cero.");
            }

            if (ObjProducto.stock < 0)
            {
                sbMensaje.AppendLine("El Stock no puede ser negativo.");
            }

            Mensaje = sbMensaje.ToString();

            if (!string.IsNullOrEmpty(Mensaje))
            {
                return 0;
            }

            try
            {
                return objcd_producto.Registrar(ObjProducto, out Mensaje);
            }
            catch (Exception ex)
            {
                Mensaje = $"Error al registrar el producto: {ex.Message}";
                return 0;
            }
        }
        public bool Editar(Producto ObjProducto, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre del usuario no esté vacío
            if (ObjProducto.nombre == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "El NOMBRE es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza la edición
            if (Mensaje != string.Empty)
            {
                return false; // Devuelve false si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Editar en la capa de datos para actualizar el usuario
                return objcd_producto.Editar(ObjProducto, out Mensaje);
            }
        }
        public bool Eliminar(Producto ObjProducto, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_producto.Eliminar(ObjProducto, out Mensaje);
        }

    }
}
