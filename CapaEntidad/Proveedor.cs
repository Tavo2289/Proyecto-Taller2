using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {



        public int id_proveedor { get; set; }
        public string razon_social { get; set; }
        public string nro_documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string fecha_alta { get; set; }
        public string fecha_baja { get; set; }

        public bool estado { get; set; }
    }
}
