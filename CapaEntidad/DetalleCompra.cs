using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {


        public int id_detalle_compra { get; set; }
        public Compra id_compra { get; set; } // Propiedad de tipo Compra para representar la relación
        public Producto id_producto { get; set; } // Propiedad de tipo Producto para representar la relación

        public MetodoPago id_metodo_pago { get; set; } // Propiedad de tipo MetodoPago para representar la relación
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }

       
      
        public bool estado { get; set; }
    }
}
