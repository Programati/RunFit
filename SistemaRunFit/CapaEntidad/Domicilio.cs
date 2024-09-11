using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Domicilio
    {
        public int idDomicilio { get; set; }
        public string calle { get; set; }
        public string altura { get; set; }
        public string piso { get; set; }
        public string departamento { get; set; }
        public string manzana { get; set; }
        public string casa { get; set; }
        public Persona oPersona { get; set; }

    }
}
