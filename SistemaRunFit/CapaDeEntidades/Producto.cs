using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string detalle { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public int stock { get; set; }
        public int stockMinimo { get; set; }
        public string imagen { get; set; }
        public DateTime? fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public Proveedor oProveedor { get; set; }
    }
}
