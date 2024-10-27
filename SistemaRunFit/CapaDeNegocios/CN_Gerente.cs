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
        public List<Venta> ListarReporteGerente_1()
        {
            // Llama al método de la capa de datos que devuelve el reporte de usuario
            return objcd_gerente.ReporteGerente_1();
        }
        public List<Venta> ListarReporteGerente_2()
        {
            // Llama al método de la capa de datos que devuelve el reporte de usuario
            return objcd_gerente.ReporteGerente_2();
        }
        public List<Venta> ListarReporteGerente_3()
        {
            // Llama al método de la capa de datos que devuelve el reporte de usuario
            return objcd_gerente.ReporteGerente_3();
        }
    }
}
