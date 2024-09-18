using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDeDatos;
using CapaDeEntidades;

namespace CapaDeNegocios
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuario> ListarUsuarios()
        {
            return objcd_usuario.ListarUsuarios();
        }
        public int Registrar(Usuario ObjUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjUsuario.nombreUsuario == "")
            {
                Mensaje += "El Nombre es necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(ObjUsuario, out Mensaje);
            }
        }
        public bool Editar(Usuario ObjUsuario, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjUsuario.nombreUsuario == "")
            {
                Mensaje += "El NOMBRE es necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(ObjUsuario, out Mensaje);
            }
        }
    }
}
