using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.CN_venta;

namespace CapaNegocio
{
    public class CN_venta
    {


        private CD_venta objcd_venta = new CD_venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objcd_venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objcd_venta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objcd_venta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objcd_venta.Registrar(obj, DetalleVenta, out Mensaje);
        }


        public Venta ObtenerVenta(string numero)
        {
            // Crea una nueva instancia de Venta, que se devolverá al final.
            Venta oVenta = new CD_venta().ObtenerVenta(numero);

            // Comprueba si se encontró una venta (si el IdVenta es diferente de 0).
            if (oVenta.IdVenta != 0)
            {
                // Si se encuentra la venta, llama a la capa de datos (CD_Venta) para obtener los detalles de la venta.
                List<DetalleVenta> oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta);

                // Asigna la lista de detalles de venta obtenida a la propiedad oDetalleVenta del objeto Venta.
                oVenta.oDetalleVenta = oDetalleVenta;
            }

            // Devuelve el objeto Venta, que ahora contiene los detalles de la venta si fueron encontrados.
            return oVenta;
        }


        public List<DetalleVenta> ObtenerDetalleVenta(string numero)
        {
            // Crea una nueva instancia de Venta, que se devolverá al final.
            Venta oVenta = new CD_venta().ObtenerVenta(numero);
            List<DetalleVenta> oDetalleVenta = new List<DetalleVenta>();

            // Devuelve el objeto Venta, que ahora contiene los detalles de la venta si fueron encontrados.
            return oDetalleVenta = objcd_venta.ObtenerDetalleVenta(oVenta.IdVenta);
        }

          
        public List<Venta> Listar()
        {
            return objcd_venta.Listar();
        }











    }
}
