using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class DetalleVenta
    {


        public int id_detalle_venta { get; set; }
        public Venta id_venta { get; set; } // Propiedad de tipo Venta para representar la relación
        public Producto id_producto { get; set; } // Propiedad de tipo Producto para representar la relación
        public MetodoPago id_metodo_pago { get; set; } // Propiedad de tipo MetodoPago para representar la relación
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }
        public string pago_recibido { get; set; }
        public string cambio { get; set; }

    }
}
