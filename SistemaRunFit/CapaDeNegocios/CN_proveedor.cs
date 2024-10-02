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
    }
}
