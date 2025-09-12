using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_cliente
    {


        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>(); // se crea una lista de Clientes vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de la clase StringBuilder para construir la consulta sql
                    query.AppendLine("select id_cliente, nombre, apellido, nro_documento, telefono, correo, estado from Cliente "); // se construye la consulta sql
                    

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) //sql dara reader sirve para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Cliente() // se agrega un nuevo Cliente a la lista
                            {
                                //se asignan los valores a las propiedades del objeto Cliente
                                id_cliente = Convert.ToInt32(dr["id_cliente"]), // se convierte a entero
                                nombre = dr["nombre"].ToString(), // se convierte a string
                                apellido = dr["apellido"].ToString(),
                                nro_documento = dr["nro_documento"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                correo = dr["correo"].ToString(),
                              
                                
                                estado = Convert.ToBoolean(dr["estado"]), // se convierte a booleano
                                

                            });

                        }

                    }

                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Cliente>(); // si hay un error se crea una lista vacia
                }

            }

            return lista; // se devuelve la lista de Clientes
        }


        /*PARA REGISTRAR Cliente*/

        public int Registrar(Cliente obj, out string Mensaje)
        { // 
            int id_ClienteGenerado = 0;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_CLIENTE", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                                                                                       // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Cliente
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Cliente
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("gmail", obj.correo);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);

                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    id_ClienteGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value); //   asigna el valor del parametro de salida al id_ClienteGenerado
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex)
            {

                id_ClienteGenerado = 0;  // se inicializa en 0
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return id_ClienteGenerado;
        }





        /*PARA EDITAR Cliente*/
        public bool Editar(Cliente obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EDITAR_CLIENTE", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_Cliente", obj.id_cliente);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Cliente
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Cliente
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("gmail", obj.correo);

                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value); //   asigna el valor del parametro de salida al resultado, tambien se convierte a booleano
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex)
            {

                respuesta = false;
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return respuesta;
        }





        /*PARA ELIMINAR Cliente*/
        public bool Eliminar(Cliente obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("delete from cliente where id_cliente = @id", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id", obj.id_cliente);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Cliente

                  
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;//si se ejecuto el comando y afecto a mas de 0 filas, respuesta sera true, si no false


                }


            }
            catch (Exception ex)
            {

                respuesta = false;
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return respuesta;
        }

    }
}

