using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDeDatos;
using CapaDeEntidades;

namespace CapaDeNegocios
{
    public class CN_proveedor
    {
        private CD_Proveedor objcd_proveedor = new CD_Proveedor();

        public List<Proveedor> ListarProveedores()
        {
            return objcd_proveedor.ListarProv();
        }
        public int Registrar(Proveedor ObjProvee, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            
            if (ObjProvee.razonSocial == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "La razon social  es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza el registro
            if (Mensaje != string.Empty)
            {
                return 0; // Devuelve 0 si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Registrar en la capa de datos para guardar el usuario
                return objcd_proveedor.Registrar(ObjProvee, out Mensaje);
            }
        }
        // Método para editar proveedor
        public bool Editar(Proveedor ObjProvee, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            
            if (ObjProvee.razonSocial == "")
            {
                
                Mensaje += "La Razon Social es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza la edición
            if (Mensaje != string.Empty)
            {
                return false; // Devuelve false si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Editar en la capa de datos para actualizar el usuario
                return objcd_proveedor.Editar(ObjProvee, out Mensaje);
            }
        }
        // Método para eliminar proveedor
        public bool Eliminar(Proveedor ObjProvee, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_proveedor.Eliminar(ObjProvee, out Mensaje);
        }
    }
}
