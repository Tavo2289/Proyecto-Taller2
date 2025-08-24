using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // se agrega la referencia a la capa datos
using CapaEntidad; // se agrega la referencia a la capa entidad

namespace CapaNegocio // capa negocio sirve de intermediario entre la capa datos y la capa presentacion
                      //su funcion es procesar los datos que vienen de la capa datos y enviarlos a la capa presentacion
{
    public class CN_usuario
    {
        private CD_usuario objcd_usuario = new CD_usuario(); // se crea un objeto de la clase CD_usuario para acceder a sus metodos


            public List<Usuario> Listar()
            {
                return objcd_usuario.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de usuarios
        }
    }
}
