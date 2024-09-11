using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {
        public int idRol { get; set; }
        public string nombreRol { get; set; }
        public string fechaAlta { get; set; }
        public string fechaBaja { get; set; }
        /*
         * La fecha de registro, no la vamos a enviar por la aplicacion
         *Lo va a completar automaticamente la BD
         *La app no insertará ni actualizará, lo va a hacer la BD
         *Sólo lo vamos a obtener
         */
    }
}
