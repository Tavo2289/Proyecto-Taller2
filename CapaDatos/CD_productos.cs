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
    public class CD_productos
    {

        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>(); // se crea una lista de Productos vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de la clase StringBuilder para construir la consulta sql
                    query.AppendLine("select p.id_producto, p.codigo, p.nombre_producto, p.descripcion, c.id_categoria,c.nombre_categoria,p.stock, p.precioCompra, p.precioVenta,p.estado from Producto p"); // se construye la consulta sql
                    query.AppendLine("inner join Categoria c on c.id_categoria = p.id_categoria"); // se construye la consulta sql

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) //sql dara reader sirve para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Producto() // se agrega un nuevo Producto a la lista
                            {
                                //se asignan los valores a las propiedades del objeto Producto
                                id_producto = Convert.ToInt32(dr["id_producto"]), // se convierte a entero
                                codigo = dr["codigo"].ToString(), // se convierte a entero
                                nombre_producto = dr["nombre_producto"].ToString(), // se convierte a string
                                descripcion = dr["descripcion"].ToString(), // se convierte a string
                                id_categoria = new Categoria() // se crea un nuevo objeto categoria
                                {
                                    id_categoria = Convert.ToInt32(dr["id_categoria"]) // se convierte a entero
                                    ,
                                    nombre_categoria = dr["nombre_categoria"].ToString()
                                },
                                stock = Convert.ToInt32(dr["stock"].ToString()), // se convierte a entero

                                precio_compra = Convert.ToDecimal(dr["precioCompra"].ToString()), // se convierte a decimal
                                precio_venta = Convert.ToDecimal(dr["precioVenta"].ToString()), // se convierte a decimal
                          

                                estado = Convert.ToBoolean(dr["estado"]) // se convierte a booleano
                                

                            });

                        }

                    }

                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Producto>(); // si hay un error se crea una lista vacia
                   
                }

            }

            return lista; // se devuelve la lista de Productos
        }


        /*PARA REGISTRAR Producto*/

        public int Registrar(Producto obj, out string Mensaje)
        { // 
            int id_ProductoGenerado = 0;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("sp_RegistrarProducto", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                                                                                       // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Producto
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Producto
                    cmd.Parameters.AddWithValue("nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("id_categoria", obj.id_categoria.id_categoria);
                    cmd.Parameters.AddWithValue("estado", obj.estado);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output; //parametros de salida
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output; // parametro de salida

                    cmd.CommandType = CommandType.StoredProcedure; // se especifica que es un comando de texto
                    conexion.Open(); // se abre la conexion 

                    cmd.ExecuteNonQuery();//ejecuta comando

                    id_ProductoGenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value); //   asigna el valor del parametro de salida al id_ProductoGenerado
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString(); // asigna el valor del parametro de salida al mensaje
                }


            }
            catch (Exception ex)
            {

                id_ProductoGenerado = 0;  // se inicializa en 0
                Mensaje = ex.Message;  // se asigna el mensaje de error



            }

            return id_ProductoGenerado;
        }





        /*PARA EDITAR Producto*/
        public bool Editar(Producto obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("sp_ModificarProducto", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_Producto", obj.id_producto);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Producto
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);    //se agrega los valores de las variables del procedimiento sp_registrar a los parametros del objeto Producto
                    cmd.Parameters.AddWithValue("nombre_producto", obj.nombre_producto);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("id_categoria", obj.id_categoria.id_categoria);
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





        /*PARA ELIMINAR Producto*/
        public bool Eliminar(Producto obj, out string Mensaje)
        { // 
            bool respuesta = false;  //
            Mensaje = string.Empty;  //  

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
                { //conexion a base de datos

                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("id_producto", obj.id_producto);                                                                  // se guardan los valores de las variables del procedimiento sp_registrar a los parametros del objeto Producto

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

                respuesta = false; // se inicializa en false

                if (ex.Message.Contains("DELETE en conflicto con la restricción REFERENCE")) // si el mensaje de error contiene esa cadena es porque el Producto esta relacionado con ventas o compras
                {
                    Mensaje = "No se puede eliminar el producto porque está relacionado con ventas o compras.";
                }
                else
                {
                    Mensaje = ex.Message; 
                }


            }

            return respuesta;
        }

    }



}

