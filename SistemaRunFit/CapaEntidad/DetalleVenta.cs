using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }
        public Producto oProducto { get; set; }
        //Omitimos el Objeto venta, porque venta contiene una lista de DetalleVenta
    }
}
