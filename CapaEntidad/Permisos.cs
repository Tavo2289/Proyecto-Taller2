using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
        public int id_permiso { get; set; }
        public Rol id_rol { get; set; } // Propiedad de tipo Rol para representar la relación
        public string nombre_permiso { get; set; }
        public string fecha_creacion { get; set; }



    }
}
