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
        // Creamos una instancia de la clase CD_Persona que es responsable de realizar las operaciones de acceso a datos.
        private CD_Persona objcd_persona = new CD_Persona();

        // Método que llama a la capa de datos para obtener una lista de personas.
        public List<Persona> ListarPersonas()
        {
            // Devuelve la lista de personas obtenida desde la capa de datos.
            return objcd_persona.ListarPersonas();
        }

        // Método para registrar una nueva persona en la base de datos.
        public int Registrar(Persona ObjPersona, out string Mensaje)
        {
            // Inicializa el mensaje como una cadena vacía.
            Mensaje = string.Empty;

            // Verifica si el campo DNI está vacío.
            if (ObjPersona.dni == "")
            {
                // Si el DNI está vacío, se agrega un mensaje indicando que es necesario.
                Mensaje += "El DNI es necesario para cargar la BD\n";
            }

            // Si el mensaje no está vacío, significa que hubo un error, y se devuelve 0.
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                // Si no hay errores, se llama al método Registrar de la capa de datos.
                return objcd_persona.Registrar(ObjPersona, out Mensaje);
            }
        }

        // Método para editar los datos de una persona existente.
        public bool Editar(Persona ObjPersona, out string Mensaje)
        {
            // Inicializa el mensaje como una cadena vacía.
            Mensaje = string.Empty;

            // Verifica si el campo DNI está vacío.
            if (ObjPersona.dni == "")
            {
                // Si el DNI está vacío, se agrega un mensaje indicando que es necesario.
                Mensaje += "El DNI es necesario para cargar la BD\n";
            }

            // Si el mensaje no está vacío, significa que hubo un error, y se devuelve false.
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                // Si no hay errores, se llama al método Editar de la capa de datos.
                return objcd_persona.Editar(ObjPersona, out Mensaje);
            }
        }
        public bool Eliminar(Persona ObjPersona, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_persona.Eliminar(ObjPersona, out Mensaje);
        }
    }

}
