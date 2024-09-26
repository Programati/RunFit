using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDeDatos
{
    public class Conexion
    {
        // Esta propiedad estática contiene la cadena de conexión a la base de datos.
        // Se obtiene del archivo de configuración (app.config o web.config), 
        // utilizando la clave "cadena_conexion".
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}

