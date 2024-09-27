using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Categoria
    {
        // Propiedad que almacena el ID único de la categoría.
        public int idCategoria { get; set; }

        // Propiedad que almacena el nombre de la categoría.
        public string nombre { get; set; }

        // Propiedad que almacena la fecha en la que la categoría fue dada de alta.
        public string fechaAlta { get; set; }

        // Propiedad que almacena la fecha en la que la categoría fue dada de baja (si aplica).
        public string fechaBaja { get; set; }
    }

}
