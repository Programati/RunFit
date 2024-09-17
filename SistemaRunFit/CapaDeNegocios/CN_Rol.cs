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
        private CD_Rol objcd_usuario = new CD_Rol();
        public List<Rol> Listar()
        {
            return objcd_usuario.Listar();
        }
    }
}
