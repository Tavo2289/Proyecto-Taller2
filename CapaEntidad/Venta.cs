using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {


        public int id_venta { get; set; }
        public Cliente id_cliente { get; set; } // Propiedad de tipo Cliente para representar la relación
        public Usuario id_usuario { get; set; } // Propiedad de tipo Usuario para representar la relación
        public decimal importe_total { get; set; }
        public string fecha_venta { get; set; }

    }
}
