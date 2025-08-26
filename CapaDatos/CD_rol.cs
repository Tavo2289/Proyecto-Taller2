using System;
using System.Collections.Generic;
using System.Data;  // Libreria para trabajar con bases de datos
using System.Data.SqlClient; // Libreria para trabajar con SQL Server
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad; // se importa la capa entidad para usar la clase usuario

namespace CapaDatos
{
    public class CD_rol
    {

        public List<Rol> Listar()
        {

            List<Rol> lista = new List<Rol>(); // se cre una lista de roles vacia

            using (SqlConnection conexion = new SqlConnection(Conexion.conexion))
            { // se crea la conexion a la base de datos con la cadena de conexion que esta en la clase Conexion
                try
                {  // por si ocurre un error

                    StringBuilder query = new StringBuilder(); // se crea un objeto de tipo string builder para concatenar cadenas de texto
                    query.AppendLine("select id_rol ,nombre_rol from Rol"); // se agrega la consulta sql
                  



                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion); // se crea el comando sql sql coman (consulta, conexion) objeto que ejecuta la consulta
        
                    cmd.CommandType = CommandType.Text; // se especifica que es un comando de texto

                    conexion.Open(); // se abre la conexion 

                    using (SqlDataReader dr = cmd.ExecuteReader()) // asignacion de un data reader para leer los datos de la base de datos 

                    //cmd.execute reader ejecuta el comando y devuelve un data reader
                    { // se ejecuta el comando y se obtiene un data reader que es una tabla virtual 


                        while (dr.Read()) // mientras haya registros y se pueda leer
                        {

                            lista.Add(new Rol() // se agrega un  nuevo rol a la lista
                            {
                                //se asignan los valores a las propiedades del objeto rol

                                 id_rol = Convert.ToInt32(dr["id_rol"]) , // se convierte a entero
                                 nombre_rol = dr["nombre_rol"].ToString(), // se convierte a string




                            });




                        }

                    }



                }
                catch (Exception ex) // si ocurre un error se captura la excepcion
                {
                    lista = new List<Rol>(); // si hay un error se crea una lista vacia
                }

            }

            return lista; // se devuelve la lista de usuarios
        }



    }





}

