using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;  // Libreria para trabajar con bases de datos
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_permisos
    {
        public List<Permisos> Listar(int idUsuario)
        {

            List<Permisos> lista = new List<Permisos>(); // se crea una lista de usuarios vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de tipo string builder para concatenar cadenas de texto
                    query.AppendLine("select p.id_rol ,p.nombre_menu from Permisos p"); // se agrega la consulta sql
                    query.AppendLine("inner join Rol r on r.id_rol = p.id_rol"); //lo que hace es unir dos tablas por medio de una columna en comun
                    query.AppendLine("inner join Usuario u on u.id_rol = r.id_rol");//consulta por medio de la cual se obtienen los permisos asociados a un usuario especifico
                    query.AppendLine("where u.id_usuario = @idUsuario"); 

                 

                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario); // se agrega el parametro idUsuario para evitar inyeccion sqlS
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) // asignacion de un data reader para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Permisos() // se agrega un nuevo usuario a la lista
                                 {
                                //se asignan los valores a las propiedades del objeto usuario
                            
                               id_rol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) }, // se convierte a entero
                               nombre_menu = dr["nombre_menu"].ToString(), // se convierte a string




                            });




                        }

                    }



                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Permisos>(); // si hay un error se crea una lista vacia
                }

            }

            return lista; // se devuelve la lista de usuarios
        }



    }
}
