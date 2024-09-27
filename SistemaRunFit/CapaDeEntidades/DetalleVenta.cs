using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class DetalleVenta
    {
        // Propiedad que almacena el ID único del detalle de la venta.
        public int idDetalleVenta { get; set; }

        // Propiedad que almacena la cantidad de productos en el detalle de la venta.
        public int cantidad { get; set; }

        // Propiedad que almacena el subtotal correspondiente al detalle de la venta (precio * cantidad).
        public decimal subTotal { get; set; }

        // Propiedad que referencia al objeto Producto, que contiene los detalles del producto vendido.
        public Producto oProducto { get; set; }

        // Omitimos el objeto Venta, ya que una Venta contiene una lista de DetalleVenta, por lo que incluir
        // un objeto Venta dentro de DetalleVenta podría generar redundancia o ciclos de referencia.
    }

}
