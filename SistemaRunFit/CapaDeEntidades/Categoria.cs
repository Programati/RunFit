using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Categoria
    {
        public int idCategoria { get; set; }

        public string nombre_categoria { get; set; }

        public  DateTime? fecha_alta { get; set; }

        public DateTime? fecha_baja { get; set; }
    }

}
