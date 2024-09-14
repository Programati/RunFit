using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Venta
    {
        public int idVenta { get; set; }
        public decimal importeTotal { get; set; }
        public string fechaFactura { get; set; }
        public List<DetalleVenta> oDetalleVenta { get; set; }//Dentro de una venta, puede contener una lista de detalles de ventas
        public Usuario oUsuario { get; set; }
    }
}
