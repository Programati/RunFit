using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public string cuit { get; set; }
        public string descripcion { get; set; }
        public string  telefono { get; set; }
        public string  direccion { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; } // Cambiado a DateTime
        public DateTime? fechaBaja { get; set; }
        

    }
}
