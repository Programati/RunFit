using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        // Método que lista todas las marcas
        public List<Producto> ListarProductos()
        {
            // Llama al método ListarMarca en la capa de datos y devuelve la lista de marcas
            return objcd_producto.ListarProducto();
        }
    }
}
