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
    public class CD_Categoria
    {
        

        public List<Categoria> Listar(bool estado)
        {
            List<Categoria> lista = new List<Categoria>(); // se crea una lista de Categorias vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de la clase StringBuilder para construir la consulta sql
                    query.AppendLine("select id_categoria,nombre_categoria,estado from Categoria"); // se construye la consulta sql
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) //sql dara reader sirve para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Categoria() // se agrega un nuevo Categoria a la lista
                            {
                                //se asignan los valores a las propiedades del objeto Categoria
                                id_categoria = Convert.ToInt32(dr["id_categoria"]), // se convierte a entero
                                nombre_categoria = dr["nombre_categoria"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]) // se convierte a booleano
                            });
                        }

                    }
                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Categoria>(); // si hay un error se crea una lista vacia
                }
            }
            return lista; // se devuelve la lista de Categorias
        }


        /*PARA REGISTRAR Categoria*/

        public int Registrar(Categoria obj, out string Mensaje)
        { // 
            int id_CategoriaGenerado = 0;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_RegistrarCategoria", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("estado", obj.estado);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Categoria
                    cmd.Parameters.AddWithValue("Descripcion", obj.nombre_categoria);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Categoria
                    
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    id_CategoriaGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value); //   asigna el valor del parametro de salida al id_CategoriaGenerado
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex)
            {

                id_CategoriaGenerado = 0;  // se inicializa en 0
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return id_CategoriaGenerado;
        }





        /*PARA EDITAR Categoria*/
        public bool Editar(Categoria obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EditarCategoria", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_Categoria", obj.id_categoria);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Categoria
                    cmd.Parameters.AddWithValue("nombre_categoria", obj.nombre_categoria);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Categoria
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //   asigna el valor del parametro de salida al resultado, tambien se convierte a booleano
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





        /*PARA ELIMINAR Categoria*/
        public bool Eliminar(Categoria obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EliminarCategoria", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_Categoria", obj.id_categoria);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Categoria

                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value); //   asigna el valor del parametro de salida al resultado, tambien se convierte a booleano
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

        public List<Categoria> Listar()
        {
            return Listar(true); // o false, según lo que necesites mostrar

        }
    }
}
