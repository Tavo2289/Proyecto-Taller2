using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Rol
    {
        //creamos las varibles que van a representar los campos de la tabla rol
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }

        public string fecha_alta { get; set; }

        public string fecha_baja { get; set; }


    }
}
