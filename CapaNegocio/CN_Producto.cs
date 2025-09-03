using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto(); // se crea un objeto de la clase CD_Producto para acceder a sus metodos

        // metodos publicos que seran llamados desde la capa presentacion

        public List<Producto> Listar() // metodo para listar Productos
        {
            return objcd_Producto.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de Productos
        }

        public int Registrar(Producto obj, out string Mensaje)// metodo para registrar Productos
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio

            //  VALIDACIONES
            if (obj.codigo == "")
            {// se valida que el nombre no este vacio
                Mensaje += "El codigo no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nombre_producto == "")
            {// se valida que el apellido no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.descripcion == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La descripcion no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return 0; // se devuelve 0 para indicar que no se pudo registrar el Producto
            }
            else
            {
                return objcd_Producto.Registrar(obj, out Mensaje); // se llama al metodo registrar de la capa datos y se devuelve el id del Producto registrado y un mensaje
            }
        }



        public bool Editar(Producto obj, out string Mensaje)// metodo para EDITAR Productos
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio

            //  VALIDACIONES
            if (obj.codigo == "")
            {// se valida que el nombre no este vacio
                Mensaje += "El codigo no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nombre_producto == "")
            {// se valida que el apellido no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.descripcion == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La descripcion no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el Producto
            }

            return objcd_Producto.Editar(obj, out Mensaje); // se llama al metodo editar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }

        public bool Eliminar(Producto obj, out string Mensaje)// metodo para ELIMINAR Productos
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio

            //  VALIDACIONES
            if (obj.codigo == "")
            {// se valida que el nombre no este vacio
                Mensaje += "El codigo no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nombre_producto == "")
            {// se valida que el apellido no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.descripcion == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La descripcion no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el Producto
            }
            return objcd_Producto.Eliminar(obj, out Mensaje); // se llama al metodo eliminar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }
    }
}
