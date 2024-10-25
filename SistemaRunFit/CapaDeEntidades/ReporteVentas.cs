using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    internal class ReporteVentas
    {
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Producto { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }
    }
}
