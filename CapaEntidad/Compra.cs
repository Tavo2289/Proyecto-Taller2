using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {


        public int id_compra { get; set; }
        public Usuario id_usuario { get; set; } // Propiedad de tipo Usuario para representar la relación
        public Proveedor id_proveedor { get; set; } // Propiedad de tipo Proveedor para representar la relación
        public string fecha_compra { get; set; }

        public string nro_documento { get; set; }
        public string tipo_documento { get; set; }
        public List <DetalleCompra> detalleCompras { get; set; } // Lista de DetalleCompra para representar la relación uno a muchos
        public decimal monto_total { get; set; }
     
        public bool estado { get; set; }
    }
}
