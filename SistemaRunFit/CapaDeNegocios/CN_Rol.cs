using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Rol
    {
        // Se crea una instancia de la clase CD_Rol, que es la encargada de manejar las operaciones de acceso a datos relacionadas con el rol.
        private CD_Rol objcd_usuario = new CD_Rol();

        // Método para obtener una lista de roles.
        public List<Rol> Listar()
        {
            // Llama al método Listar de la capa de datos y devuelve la lista de roles.
            return objcd_usuario.Listar();
        }
    }

}
