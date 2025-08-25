using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // se agrega la referencia a la capa datos
using CapaEntidad; // se agrega la referencia a la capa entidad

namespace CapaNegocio
{
    public class CN_permisos
    {


        private CD_permisos objcd_permiso = new CD_permisos(); // se crea un objeto de la clase CD_usuario para acceder a sus metodos


        public List<Permisos> Listar(int idUsuario)
        {
            return objcd_permiso.Listar(idUsuario); // se llama al metodo listar de la capa datos y se devuelve la lista de usuarios
        }



    }
}
