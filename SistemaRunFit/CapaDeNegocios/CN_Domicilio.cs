using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    // Clase para la lógica de negocio relacionada con los domicilios
    public class CN_Domicilio
    {
        // Instancia de la clase CD_Domicilio que se encarga de la interacción con la base de datos
        private CD_Domicilio objcd_domicilio = new CD_Domicilio();

        // Método que lista todos los domicilios
        public List<Domicilio> ListarDomicilios()
        {
            // Llama al método ListarDomicilios en la capa de datos y devuelve la lista de domicilios
            return objcd_domicilio.ListarDomicilios();
        }

        // Método para registrar un nuevo domicilio
        public int Registrar(Domicilio ObjDomicilio, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que la calle del domicilio no esté vacía
            if (ObjDomicilio.calle == "")
            {
                // Si la calle está vacía, se añade un mensaje de error
                Mensaje += "La calle es un dato necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza el registro
            if (Mensaje != string.Empty)
            {
                return 0; // Devuelve 0 si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Registrar en la capa de datos para guardar el domicilio
                return objcd_domicilio.Registrar(ObjDomicilio, out Mensaje);
            }
        }

        // Método para editar un domicilio existente
        public bool Editar(Domicilio ObjDomicilio, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que la calle del domicilio no esté vacía
            if (ObjDomicilio.calle == "")
            {
                // Si la calle está vacía, se añade un mensaje de error
                Mensaje += "La calle es un dato necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza la edición
            if (Mensaje != string.Empty)
            {
                return false; // Devuelve false si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Editar en la capa de datos para actualizar el domicilio
                return objcd_domicilio.Editar(ObjDomicilio, out Mensaje);
            }
        }
    }

}
