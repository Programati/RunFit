using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string passwordUsuario { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        public Rol oRol { get; set; }
        public Persona oPersona { get; set; }

    }
}
