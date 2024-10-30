using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Marca
    {
        public int idMarca { get; set; }
        public string nombre { get; set; }
        public DateTime? fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
    }
}
