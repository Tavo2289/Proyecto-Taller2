using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CN_rol
    {


        private CD_rol objcd_rol = new CD_rol(); // se crea un objeto de la clase CD_permiso para acceder a sus metodos


        public List<Rol> Listar()
        {
            return objcd_rol.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de usuarios
        }
    }
}
