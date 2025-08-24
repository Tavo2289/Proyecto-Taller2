using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;  // Libreria para trabajar con bases de datos
using System.Data.SqlClient;// Libreria para trabajar con SQL Server
using CapaEntidad; // se agrega la referencia a la capa entidad

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

                    string query = "select id_usuario, nombre, apellido, nro_documento, contraseña, fecha_alta,estado from usuario"; // consulta sql para listar los usuarios
                    SqlCommand cmd = new SqlCommand(query, conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
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
                                contraseña = dr["contraseña"].ToString(),
                                fecha_alta = dr["fecha_alta"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]), // se convierte a booleano
                                





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

    }

}