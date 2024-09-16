using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Persona
    {
        private CD_Persona objcd_persona = new CD_Persona();

        public List<Persona> ListarPersonas()
        {
            return objcd_persona.ListarPersonas();
        }
    }
}
