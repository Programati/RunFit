using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Venta
    {
        private CD_Venta objcd_venta = new CD_Venta();

        public Venta ObtenerVentaPorId(int idVenta)
        {
            return objcd_venta.ObtenerVentaPorId(idVenta);
        }
        public int Registrar(Venta ObjVenta, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjVenta.importeTotal <= 0)
            {
                Mensaje += "No se está cargando ningun producto\n";
                return 0;
            }
            else
            {
                return objcd_venta.Registrar(ObjVenta, out Mensaje);
            }
        }
    }
}
