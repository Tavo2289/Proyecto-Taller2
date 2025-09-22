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

        public int cantidad { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }

        public decimal montoTotal { get; set; }

       
      
        public bool estado { get; set; }
    }
}
