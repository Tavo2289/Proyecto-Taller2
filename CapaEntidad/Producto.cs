using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }

        public int stock_minimo { get; set; }
        public string fecha_alta { get; set; }
        public string fecha_baja { get; set; }
        public bool estado { get; set; }

        public Categoria id_categoria { get; set; } // Propiedad de tipo Categoria para representar la relación
        public Proveedor id_proveedor { get; set; } // Propiedad de tipo Proveedor para representar la relación
    }
}
