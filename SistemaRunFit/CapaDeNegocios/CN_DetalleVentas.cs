using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_DetalleVentas
    {
        private CD_DetalleVentas objcd_detalleventas = new CD_DetalleVentas();

        public int Registrar(DetalleVenta ObjDetalleVentas, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (ObjDetalleVentas.cantidad <= 0)
            {
                Mensaje += "No se está cargando ningun producto\n";
                return 0;
            }
            else
            {
                return objcd_detalleventas.Registrar(ObjDetalleVentas, out Mensaje);
            }
        }
    }
}
