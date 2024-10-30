using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int cantidad { get; set; }
        public double subTotal { get; set; }
        public Producto oProducto { get; set; }
        public Venta oVenta { get; set; }

    }

}
