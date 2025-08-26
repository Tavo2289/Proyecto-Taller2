using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nro_documento { get; set; }

        public string gmail { get; set; }
        public string contraseña { get; set; }
        public string fecha_alta { get; set; }
        public string fecha_baja { get; set; }
        public bool estado { get; set; }


        public Rol id_rol { get; set; }
    }
}
