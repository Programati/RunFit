using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Domicilio
    {
        private CD_Domicilio objcd_domicilio = new CD_Domicilio();

        public List<Domicilio> ListarDomicilios()
        {
            return objcd_domicilio.ListarDomicilios();
        }
    }
}
