using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Marca
    {
        private CD_Marca objcd_marca = new CD_Marca();

        // Método que lista todas las marcas
        public List<Marca> ListarMarcas()
        {
            // Llama al método ListarMarca en la capa de datos y devuelve la lista de marcas
            return objcd_marca.ListarMarca();
        }
        public int Registrar(Marca ObjMarca, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre de la categoria no esté vacío
            if (ObjMarca.nombre == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "El Nombre es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza el registro
            if (Mensaje != string.Empty)
            {
                return 0; // Devuelve 0 si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Registrar en la capa de datos para guardar el usuario
                return objcd_marca.Registrar(ObjMarca, out Mensaje);
            }
        }
        // Método para eliminar un marca
        public bool Eliminar(Marca ObjMarca, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_marca.Eliminar(ObjMarca, out Mensaje);
        }
    }

}
