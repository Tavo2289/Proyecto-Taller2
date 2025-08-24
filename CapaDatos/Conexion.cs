using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CapaDatos
{
    public class Conexion
    {

        //cadena contiene la cadena de conexion a la base de datos
        public static string conexion = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString(); // se agrega la cadena de conexion del archivo App.config

    }
}
