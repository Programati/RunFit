using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using System.Net;

namespace CapaDeDatos
{
    public class CD_Persona
    {
        // Método para listar todas las personas de la base de datos
        public List<Persona> ListarPersonas()
        {
            // Inicializamos una lista de objetos Persona
            List<Persona> Lista = new List<Persona>();
            // Usamos una conexión SQL a la base de datos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Definimos la consulta SQL para obtener los datos de la tabla PERSONAS
                    string query = " SELECT id_persona, dni, nombre, apellido, email, telefono, fecha_nacimiento, sexo FROM PERSONAS";

                    // Creamos un comando SQL con la consulta anterior
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text; // El tipo de comando es texto SQL normal

                    // Abrimos la conexión con la base de datos
                    oconexion.Open();

                    // Ejecutamos la consulta y leemos los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Recorremos cada registro devuelto por la consulta
                        while (dr.Read())
                        {
                            // Agregamos cada registro a la lista como un nuevo objeto Persona
                            Lista.Add(new Persona()
                            {
                                idPersona = Convert.ToInt32(dr["id_persona"]), // Convertimos el id_persona a entero
                                dni = dr["dni"].ToString(), // Convertimos el DNI a string
                                nombre = dr["nombre"].ToString(), // Nombre a string
                                apellido = dr["apellido"].ToString(), // Apellido a string
                                email = dr["email"].ToString(), // Email a string
                                telefono = dr["telefono"].ToString(), // Teléfono a string
                                fechaNacimiento = dr["fecha_nacimiento"].ToString(), // Fecha de nacimiento a string
                                sexo = Convert.ToChar(dr["sexo"]) // Sexo a char
                            });
                        }
                        dr.Close(); // Cerramos el lector de datos
                        oconexion.Close(); // Cerramos la conexión con la base de datos
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, devolvemos una lista vacía
                    Lista = new List<Persona>();
                }
            }
            // Retornamos la lista de personas obtenidas
            return Lista;
        }

        // Método para registrar una nueva persona en la base de datos
        public int Registrar(Persona ObjPersona, out string Mensaje)
        {
            int IdPersonaGenerada = 0; // Variable para almacenar el ID generado para la nueva persona
            Mensaje = string.Empty; // Inicializamos el mensaje como vacío

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Usamos un procedimiento almacenado para registrar la persona
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPERSONA", oconexion);
                    // Agregamos los parámetros necesarios para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("dni", ObjPersona.dni);
                    cmd.Parameters.AddWithValue("nombre", ObjPersona.nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjPersona.apellido);
                    cmd.Parameters.AddWithValue("email", ObjPersona.email);
                    cmd.Parameters.AddWithValue("telefono", ObjPersona.telefono);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", ObjPersona.fechaNacimiento);
                    cmd.Parameters.AddWithValue("sexo", ObjPersona.sexo);

                    // Parámetros de salida que retornan el ID generado y el mensaje
                    cmd.Parameters.Add("IdPersonaResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // El comando es un procedimiento almacenado
                    oconexion.Open(); // Abrimos la conexión

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    // Obtenemos los valores de salida del procedimiento
                    IdPersonaGenerada = (int)cmd.Parameters["IdPersonaResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); // Obtenemos el mensaje de salida

                }

            }
            catch (Exception ex)
            {
                // En caso de error, asignamos 0 al ID generado y mostramos el mensaje de error
                IdPersonaGenerada = 0;
                Mensaje = ex.Message;
            }
            // Retornamos el ID de la persona registrada
            return IdPersonaGenerada;
        }

        // Método para editar una persona existente
        public bool Editar(Persona ObjPersona, out string Mensaje)
        {
            bool Respuesta = false; // Variable para indicar si la operación fue exitosa
            Mensaje = string.Empty; // Inicializamos el mensaje como vacío

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    // Usamos un procedimiento almacenado para editar la persona
                    SqlCommand cmd = new SqlCommand("SP_EDITARPERSONA", oconexion);
                    // Agregamos los parámetros necesarios para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@id_persona", ObjPersona.idPersona);
                    cmd.Parameters.AddWithValue("dni", ObjPersona.dni);
                    cmd.Parameters.AddWithValue("nombre", ObjPersona.nombre);
                    cmd.Parameters.AddWithValue("apellido", ObjPersona.apellido);
                    cmd.Parameters.AddWithValue("email", ObjPersona.email);
                    cmd.Parameters.AddWithValue("telefono", ObjPersona.telefono);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", ObjPersona.fechaNacimiento);
                    cmd.Parameters.AddWithValue("sexo", ObjPersona.sexo);

                    // Parámetros de salida que retornan si la operación fue exitosa y el mensaje
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // El comando es un procedimiento almacenado
                    oconexion.Open(); // Abrimos la conexión

                    cmd.ExecuteNonQuery(); // Ejecutamos el comando

                    // Obtenemos los valores de salida del procedimiento
                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value; // Indicamos si la operación fue exitosa
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); // Obtenemos el mensaje de salida

                }

            }
            catch (Exception ex)
            {
                // En caso de error, asignamos false a la respuesta y mostramos el mensaje de error
                Respuesta = false;
                Mensaje = ex.Message;
            }
            // Retornamos si la operación fue exitosa
            return Respuesta;
        }
    }

}
