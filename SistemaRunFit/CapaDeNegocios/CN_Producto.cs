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

        // Método que lista todas las marcas
        public List<Producto> ListarProductos()
        {
            // Llama al método ListarMarca en la capa de datos y devuelve la lista de marcas
            return objcd_producto.ListarProducto();
        }
        public int Registrar(Producto ObjProducto, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            StringBuilder sbMensaje = new StringBuilder();

            // Verifica que el nombre del producto no esté vacío
            if (string.IsNullOrWhiteSpace(ObjProducto.nombre))
            {
                sbMensaje.AppendLine("El Nombre es necesario para cargar la BD.");
            }

            // Verifica otros campos obligatorios
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

            // Convertimos los mensajes a una cadena
            Mensaje = sbMensaje.ToString();

            // Si hay algún mensaje de error, no se realiza el registro
            if (!string.IsNullOrEmpty(Mensaje))
            {
                return 0; // Devuelve 0 si hay errores
            }

            try
            {
                // Si no hay errores, llama al método Registrar en la capa de datos para guardar el producto
                return objcd_producto.Registrar(ObjProducto, out Mensaje);
            }
            catch (Exception ex)
            {
                // En caso de excepción, se devuelve 0 y se incluye el mensaje de error
                Mensaje = $"Error al registrar el producto: {ex.Message}";
                return 0;
            }
        }

    }
}
