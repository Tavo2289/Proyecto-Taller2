using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class MetodoPago
    {
        string id_metodo_pago { get; set; }

        public string nombre_metodo { get; set; }

        public string descripcion { get; set; }

        public bool estado { get; set; }

        public string fecha_alta { get; set; }

        public string fecha_baja { get; set; }




    }
}
