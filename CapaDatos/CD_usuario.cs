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

    }

}