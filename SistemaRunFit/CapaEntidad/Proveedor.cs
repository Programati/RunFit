using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string razonSocial { get; set; }
        public int cuit { get; set; }
        public string descripcion { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public Persona oPersona { get; set; }

    }
}
