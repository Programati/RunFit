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
        public int Registrar(Domicilio ObjDomicilio, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjDomicilio.calle == "")
            {
                Mensaje += "La calle es un dato necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_domicilio.Registrar(ObjDomicilio, out Mensaje);
            }   
        }
        public bool Editar(Domicilio ObjDomicilio, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjDomicilio.calle == "")
            {
                Mensaje += "La calle es un dato necesario para cargar la BD\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_domicilio.Editar(ObjDomicilio, out Mensaje);
            }
        }
    }
}
