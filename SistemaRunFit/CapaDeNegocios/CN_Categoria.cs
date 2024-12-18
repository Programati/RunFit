﻿using CapaDeDatos;
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
        public int Registrar(Categoria ObjCategoria, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre de la categoria no esté vacío
            if (ObjCategoria.nombre_categoria == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "El Nombre es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza el registro
            if (Mensaje != string.Empty)
            {
                return 0; // Devuelve 0 si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Registrar en la capa de datos para guardar el usuario
                return objcd_categoria.Registrar(ObjCategoria, out Mensaje);
            }
        }
        public bool Editar(Categoria ObjCategoria, out string Mensaje)
        {
            // Inicializa el mensaje vacío
            Mensaje = string.Empty;

            // Verifica que el nombre del usuario no esté vacío
            if (ObjCategoria.nombre_categoria == "")
            {
                // Si el nombre está vacío, se añade un mensaje de error
                Mensaje += "El NOMBRE es necesario para cargar la BD\n";
            }

            // Si hay algún mensaje de error, no se realiza la edición
            if (Mensaje != string.Empty)
            {
                return false; // Devuelve false si hay errores
            }
            else
            {
                // Si no hay errores, llama al método Editar en la capa de datos para actualizar el usuario
                return objcd_categoria.Editar(ObjCategoria, out Mensaje);
            }
        }
        // Método para eliminar un categoria
        public bool Eliminar(Categoria ObjCategoria, out string Mensaje)
        {
            // Llama al método Eliminar en la capa de datos y devuelve el resultado
            return objcd_categoria.Eliminar(ObjCategoria, out Mensaje);
        }
    }
    
}
