using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria(); // se crea un objeto de la clase CD_Categoria para acceder a sus metodos

        // metodos publicos que seran llamados desde la capa presentacion



        public List<Categoria> Listar() // metodo para listar Categorias
        {
            return objcd_Categoria.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de Categorias
        }




        public int Registrar(Categoria obj, out string Mensaje)// metodo para registrar Categorias
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio



            //  VALIDACIONES
            if (obj.Descripcion == "")
            {// se valida que la descripcion no este vacio
                Mensaje += "Es necesario la descripcion de la categoria\n"; // se agrega el mensaje de error 
            }

            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return 0; // se devuelve 0 para indicar que no se pudo registrar el Categoria
            }
            else
            {
                return objcd_Categoria.Registrar(obj, out Mensaje); // se llama al metodo registrar de la capa datos y se devuelve el id del Categoria registrado y un mensaje
            }
        }


        public bool Editar(Categoria obj, out string Mensaje)// metodo para EDITAR Categorias
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio

            //  VALIDACIONES
            if (obj.Descripcion == "")
            {// se valida que la descripcion no este vacio
                Mensaje += "Es necesario la descripcion de la categoria\n"; // se agrega el mensaje de error 
            }

            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el Categoria
            }
            return objcd_Categoria.Editar(obj, out Mensaje); // se llama al metodo editar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }

        /*PARA ELIMINAR Categoria*/
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
