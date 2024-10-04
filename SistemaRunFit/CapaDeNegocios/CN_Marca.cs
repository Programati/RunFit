using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Marca
    {
        private CD_Marca objcd_marca = new CD_Marca();

        // Método que lista todas las marcas
        public List<Marca> ListarMarcas()
        {
            // Llama al método ListarMarca en la capa de datos y devuelve la lista de marcas
            return objcd_marca.ListarMarca();
        }
    }
}
