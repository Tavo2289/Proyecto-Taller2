using CapaEntidad; // se agrega la referencia a la capa entidad
using System;
using System.Collections.Generic;
using System.Data;  // Libreria para trabajar con bases de datos
using System.Data.SqlClient;// Libreria para trabajar con SQL Server
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CapaDatos 
{
    public class CD_usuario
    {

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>(); // se crea una lista de usuarios vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de la clase StringBuilder para construir la consulta sql
                    query.AppendLine("\r\nselect u.id_usuario, u.nombre, u.apellido, u.nro_documento, u.gmail, u.contraseña, u.fecha_alta ,u.estado, r.id_rol, r.nombre_rol from usuario u"); // se construye la consulta sql
                    query.AppendLine("inner join rol r on r.id_rol = u.id_rol"); // se construye la consulta sql

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) //sql dara reader sirve para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Usuario() // se agrega un nuevo usuario a la lista
                            {
                                //se asignan los valores a las propiedades del objeto usuario
                                id_usuario = Convert.ToInt32(dr["id_usuario"]), // se convierte a entero
                                nombre = dr["nombre"].ToString(), // se convierte a string
                                apellido = dr["apellido"].ToString(),
                                nro_documento = dr["nro_documento"].ToString(),
                                gmail = dr["gmail"].ToString(),
                                contraseña = dr["contraseña"].ToString(),
                                fecha_alta = dr["fecha_alta"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]), // se convierte a booleano
                                id_rol = new Rol() // se crea un nuevo objeto rol
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]), // se convierte a entero
                                    nombre_rol = dr["nombre_rol"].ToString() // se convierte a string
                                }   

                            });

                        }

                    }

                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Usuario>(); // si hay un error se crea una lista vacia
                }

            }

            return lista; // se devuelve la lista de usuarios
        }


        /*PARA REGISTRAR USUARIO*/

        public int Registrar(Usuario obj, out string Mensaje ) { // 
            int id_usuarioGenerado = 0;  //
            Mensaje= string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion)) { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_USUARIO", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                                                                                       // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto usuario
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto usuario
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("gmail", obj.gmail);
                    cmd.Parameters.AddWithValue("contraseña", obj.contraseña);
                    cmd.Parameters.AddWithValue("id_rol", obj.id_rol.id_rol); 
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("idUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    id_usuarioGenerado = Convert.ToInt32(cmd.Parameters["idUsuarioResultado"].Value); //   asigna el valor del parametro de salida al id_usuarioGenerado
                    Mensaje= cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex) {

                id_usuarioGenerado = 0;  // se inicializa en 0
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return id_usuarioGenerado;
        }





        /*PARA EDITAR USUARIO*/
        public bool Editar(Usuario obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto usuario
                    cmd.Parameters.AddWithValue("documento", obj.nro_documento);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto usuario
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("contraseña", obj.contraseña);
                    cmd.Parameters.AddWithValue("gmail", obj.gmail);
                    cmd.Parameters.AddWithValue("id_rol", obj.id_rol.id_rol);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    respuesta= Convert.ToBoolean(cmd.Parameters["respuesta"].Value); //   asigna el valor del parametro de salida al resultado, tambien se convierte a booleano
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





        /*PARA ELIMINAR USUARIO*/
        public bool Eliminar(Usuario obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_ELIMINAR_USUARIO", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto usuario

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