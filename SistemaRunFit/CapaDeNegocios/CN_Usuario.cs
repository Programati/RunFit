using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDeDatos;
using CapaDeEntidades;

namespace CapaDeNegocios
{
    // Clase para la lógica de negocio relacionada con los usuarios
    public class CN_Usuario
    {
        // Instancia de la clase CD_Usuario que se encarga de la interacción con la base de datos
        private CD_Usuario objcd_usuario = new CD_Usuario();

        // Método que lista todos los usuarios
        public List<Usuario> ListarUsuarios()
        {
            // Llama al método ListarUsuarios en la capa de datos y devuelve la lista de usuarios
            return objcd_usuario.ListarUsuarios();
        }

        // Método para registrar un nuevo usuario
        public int Registrar(Usuario ObjUsuario, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre del usuario no esté vacío
            if (ObjUsuario.nombreUsuario == "")
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
                return objcd_usuario.Registrar(ObjUsuario, out Mensaje);
            }
        }

        // Método para editar un usuario existente
        public bool Editar(Usuario ObjUsuario, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre del usuario no esté vacío
            if (ObjUsuario.nombreUsuario == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "El NOMBRE es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza la edición
            if (Mensaje != string.Empty)
            {
                return false; // Devuelve false si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Editar en la capa de datos para actualizar el usuario
                return objcd_usuario.Editar(ObjUsuario, out Mensaje);
            }
        }

        // Método para eliminar un usuario
        public bool Eliminar(Usuario ObjUsuario, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_usuario.Eliminar(ObjUsuario, out Mensaje);
        }
    }


}
