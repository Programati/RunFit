using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CapaDeEntidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string detalle { get; set; }
        public double precioCompra { get; set; }
        public double precioVenta { get; set; }
        public int stock { get; set; }
        public int stockMinimo { get; set; }
        public byte[] Imagen { get; set; }  // Guardar la imagen como byte[]
        public DateTime? fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public Marca oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public Proveedor oProveedor { get; set; }

    }

}
