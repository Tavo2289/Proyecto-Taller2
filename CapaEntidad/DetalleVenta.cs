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
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
        public decimal subtotal { get; set; }

    }
}
