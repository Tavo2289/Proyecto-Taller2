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
    public class CD_proveedor
    {


        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>(); // se crea una lista de Proveedors vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de la clase StringBuilder para construir la consulta sql
                    query.AppendLine("\r\nselect id_proveedor,nro_documento, razon_social , telefono,correo, estado from Proveedor\r\n"); // se construye la consulta sql

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) //sql dara reader sirve para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Proveedor() // se agrega un nuevo Proveedor a la lista
                            {
                                //se asignan los valores a las propiedades del objeto Proveedor
                                id_proveedor = Convert.ToInt32(dr["id_proveedor"]), // se convierte a entero
                                nro_documento = dr["nro_documento"].ToString(),
                                razon_social = dr["razon_social"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]), // se convierte a booleano
                             

                            });

                        }

                    }

                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Proveedor>(); // si hay un error se crea una lista vacia
                }

            }

            return lista; // se devuelve la lista de Proveedors
        }


        /*PARA REGISTRAR Proveedor*/

        public int Registrar(Proveedor obj, out string Mensaje)
        { // 
            int id_ProveedorGenerado = 0;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                                                                                       // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Proveedor
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Proveedor
                    cmd.Parameters.AddWithValue("correo", obj.correo);
                    cmd.Parameters.AddWithValue("razon_social", obj.razon_social);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    id_ProveedorGenerado = Convert.ToInt32(cmd.Parameters["resultado"].Value); //   asigna el valor del parametro de salida al id_ProveedorGenerado
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex)
            {

                id_ProveedorGenerado = 0;  // se inicializa en 0
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return id_ProveedorGenerado;
        }





        /*PARA EDITAR Proveedor*/
        public bool Editar(Proveedor obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EditarProveedor", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Proveedor
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Proveedor
                    cmd.Parameters.AddWithValue("razon_social", obj.razon_social);
                    cmd.Parameters.AddWithValue("telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("correo", obj.correo);
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





        /*PARA ELIMINAR Proveedor*/
        public bool Eliminar(Proveedor obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_proveedor", obj.id_proveedor);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Proveedor

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

    }
}

