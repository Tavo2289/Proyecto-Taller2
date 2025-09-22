using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_negocio
    {
        private CD_negocio objcd_negocio = new CD_negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_negocio.obtenerDatos();
        }


        public bool guardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Es necesario el nombre\n";
            }

            if (obj.ruc == "")
            {
                Mensaje += "Es necesario el numero de RUC\n";
            }

            if (obj.direccion == "")
            {
                Mensaje += "Es necesario la direccion\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_negocio.guardarDatos(obj, out Mensaje);
            }
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objcd_negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objcd_negocio.ActualizarLogo(imagen, out mensaje);
        }

    }
}
