using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDeNegocios
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_categoria = new CD_Categoria();

        // Método que lista todos las categorias
        public List<Categoria> ListarCategorias()
        {
            // Llama al método ListarCategoria en la capa de datos y devuelve la lista de categorias
            return objcd_categoria.ListarCategoria();
        }
    }
}
