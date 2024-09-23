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

        public int Registrar(Persona ObjPersona, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjPersona.dni == "")
            {
                Mensaje += "El DNI es necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_persona.Registrar(ObjPersona, out Mensaje);
            }
        }
        public bool Editar(Persona ObjPersona, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjPersona.dni == "")
            {
                Mensaje += "El DNI es necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_persona.Editar(ObjPersona, out Mensaje);
            }
        }
    }
}
