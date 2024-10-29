using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Gerente
    {
        private CD_Gerente objcd_gerente = new CD_Gerente();
        public List<ReporteGrafico> ListarReporteGerente_1(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Llama al método de la capa de datos que ahora retorna ReporteGrafico
            return objcd_gerente.ReporteGerente_1(fechaDesde, fechaHasta);
        }


        public List<ReporteGrafico> ListarReporteGerente_2(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Llama al método de la capa de datos con los parámetros de fecha
            return objcd_gerente.ReporteGerente_2(fechaDesde, fechaHasta);
        }
        public List<ReporteGrafico> ListarReporteGerente_3(DateTime fechaDesde, DateTime fechaHasta)
        {
            // Llama al método de la capa de datos con los parámetros de fecha
            return objcd_gerente.ReporteGerente_3(fechaDesde, fechaHasta);
        }
    }
}
