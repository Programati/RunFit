using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace CapaDeDatos
{
    public class CD_Domicilio
    {
        // Método que lista los domicilios de la base de datos y retorna una lista de objetos Domicilio
        public List<Domicilio> ListarDomicilios()
        {
            List<Domicilio> Lista = new List<Domicilio>(); // Lista donde se guardarán los domicilios obtenidos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) // Establece la conexión a la base de datos
            {
                try
                {
                    // Construcción de la consulta SQL usando StringBuilder para mayor flexibilidad
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT d.id_domicilio, d.calle, d.altura, d.casa, d.manzana, d.departamento, d.piso, d.id_persona, p.dni, p.nombre, p.apellido, p.email, p.telefono, p.fecha_nacimiento, p.sexo,p.estado FROM DOMICILIOS d");
                    query.AppendLine("inner join PERSONAS p on p.id_persona = d.id_persona"); // Join para obtener datos de la persona asociada al domicilio
                    query.AppendLine("WHERE d.id_persona = p.id_persona");
                    query.AppendLine("order by p.estado desc");// Condición para asegurar que el join se haga correctamente

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion); // Se prepara el comando SQL
                    cmd.CommandType = CommandType.Text; // El comando es de tipo texto (consulta SQL normal)

                    oconexion.Open(); // Se abre la conexión a la base de datos

                    // Se ejecuta la consulta y se utiliza un SqlDataReader para leer los resultados
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read()) // Se recorren los resultados fila por fila
                        {
                            // Se agrega un nuevo objeto Domicilio a la lista con los valores obtenidos de la base de datos
                            Lista.Add(new Domicilio()
                            {
                                idDomicilio = Convert.ToInt32(dr["id_domicilio"]),
                                calle = dr["calle"].ToString(),
                                altura = dr["altura"].ToString(),
                                piso = dr["piso"].ToString(),
                                departamento = dr["departamento"].ToString(),
                                manzana = dr["manzana"].ToString(),
                                casa = dr["casa"].ToString(),
                                oPersona = new Persona
                                {
                                    idPersona = Convert.ToInt32(dr["id_persona"]),
                                    dni = dr["dni"].ToString(),
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString(),
                                    email = dr["email"].ToString(),
                                    telefono = dr["telefono"].ToString(),
                                    fechaNacimiento = dr["fecha_nacimiento"].ToString(),
                                    sexo = Convert.ToChar(dr["sexo"]),
                                    estado= Convert.ToChar(dr["estado"]),
                                }
                            });
                        }
                        dr.Close(); // Cierra el SqlDataReader
                        oconexion.Close(); // Cierra la conexión a la base de datos
                    }
                }
                catch (Exception ex) // Captura cualquier excepción que ocurra durante la ejecución
                {
                    Lista = new List<Domicilio>(); // En caso de error, se devuelve una lista vacía
                }
            }
            return Lista; // Retorna la lista de domicilios obtenida
        }

        // Método que registra un nuevo domicilio en la base de datos utilizando un procedimiento almacenado
        public int Registrar(Domicilio ObjDomicilio, out string Mensaje)
        {
            int IdDomicilioGenerado = 0; // Variable que almacenará el ID generado por la base de datos
            Mensaje = string.Empty; // Variable para el mensaje devuelto

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) // Establece la conexión
                {
                    // Se configura el comando para llamar al procedimiento almacenado SP_REGISTRARDOMICILIO
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARDOMICILIO", oconexion);
                    // Se agregan los parámetros necesarios para la inserción de un domicilio
                    cmd.Parameters.AddWithValue("calle", ObjDomicilio.calle);
                    cmd.Parameters.AddWithValue("altura", ObjDomicilio.altura);
                    cmd.Parameters.AddWithValue("casa", ObjDomicilio.casa);
                    cmd.Parameters.AddWithValue("manzana", ObjDomicilio.manzana);
                    cmd.Parameters.AddWithValue("departamento", ObjDomicilio.departamento);
                    cmd.Parameters.AddWithValue("piso", ObjDomicilio.piso);
                    cmd.Parameters.AddWithValue("id_persona", ObjDomicilio.oPersona.idPersona);

                    // Parámetro de salida para capturar el ID del domicilio generado por la base de datos
                    cmd.Parameters.Add("IdDomicilioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    // Parámetro de salida para capturar el mensaje devuelto por el procedimiento almacenado
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // Se define el comando como un procedimiento almacenado
                    oconexion.Open(); // Abre la conexión

                    cmd.ExecuteNonQuery(); // Ejecuta el comando

                    // Recupera los valores de los parámetros de salida
                    IdDomicilioGenerado = (int)cmd.Parameters["IdDomicilioResultado"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex) // Manejo de errores
            {
                IdDomicilioGenerado = 0; // En caso de error, no se genera ningún ID
                Mensaje = ex.Message; // Se guarda el mensaje de error
            }
            return IdDomicilioGenerado; // Retorna el ID del domicilio generado
        }

        // Método para editar un domicilio existente en la base de datos
        public bool Editar(Domicilio ObjDomicilio, out string Mensaje)
        {
            bool Respuesta = false; // Variable que indicará si la operación fue exitosa
            Mensaje = string.Empty; // Variable para el mensaje devuelto

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) // Establece la conexión
                {
                    // Se configura el comando para llamar al procedimiento almacenado SP_EDITARDOMICILIO
                    SqlCommand cmd = new SqlCommand("SP_EDITARDOMICILIO", oconexion);
                    // Se agregan los parámetros necesarios para la actualización de un domicilio
                    cmd.Parameters.AddWithValue("@id_domicilio", ObjDomicilio.idDomicilio);
                    cmd.Parameters.AddWithValue("calle", ObjDomicilio.calle);
                    cmd.Parameters.AddWithValue("altura", ObjDomicilio.altura);
                    cmd.Parameters.AddWithValue("casa", ObjDomicilio.casa);
                    cmd.Parameters.AddWithValue("manzana", ObjDomicilio.manzana);
                    cmd.Parameters.AddWithValue("departamento", ObjDomicilio.departamento);
                    cmd.Parameters.AddWithValue("piso", ObjDomicilio.piso);
                    cmd.Parameters.AddWithValue("id_persona", ObjDomicilio.oPersona.idPersona);

                    // Parámetro de salida para capturar si la operación fue exitosa
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    // Parámetro de salida para capturar el mensaje devuelto por el procedimiento almacenado
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure; // Se define el comando como un procedimiento almacenado
                    oconexion.Open(); // Abre la conexión

                    cmd.ExecuteNonQuery(); // Ejecuta el comando

                    // Recupera los valores de los parámetros de salida
                    Respuesta = (bool)cmd.Parameters["Respuesta"].Value;
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex) // Manejo de errores
            {
                Respuesta = false; // En caso de error, la respuesta será false
                Mensaje = ex.Message; // Se guarda el mensaje de error
            }
            return Respuesta; // Retorna el estado de la operación (true/false)
        }
    }

}
