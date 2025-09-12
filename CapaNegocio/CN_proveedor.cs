using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos; // se agrega la referencia a la capa datos
using CapaEntidad; // se agrega la referencia a la capa entidad


namespace CapaEntidad
{
    public class CN_proveedor
    {
        private CD_proveedor objcd_proveedor = new CD_proveedor(); // se crea un objeto de la clase CD_proveedor para acceder a sus metodos

        // metodos publicos que seran llamados desde la capa presentacion



        public List<Proveedor> Listar() // metodo para listar proveedors
        {
            return objcd_proveedor.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de proveedors
        }




        public int Registrar(Proveedor obj, out string Mensaje)// metodo para registrar proveedors
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio

            if (obj.razon_social == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La razon social no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.nro_documento == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.correo == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.telefono == "")
            {// se valida que la contraseña no este vacia
                Mensaje += "La telefono no puede estar vacia\n"; // se agrega el mensaje de error  


            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return 0; // se devuelve 0 para indicar que no se pudo registrar el proveedor
            }
            else
            {

                return objcd_proveedor.Registrar(obj, out Mensaje); // se llama al metodo registrar de la capa datos y se devuelve el id del proveedor registrado y un mensaje
            }



        }



        public bool Editar(Proveedor obj, out string Mensaje)// metodo para EDITAR proveedors
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio


            if (obj.razon_social == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La razon social no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.nro_documento == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.correo == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.telefono == "")
            {// se valida que la contraseña no este vacia
                Mensaje += "La telefono no puede estar vacia\n"; // se agrega el mensaje de error  


            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el proveedor
            }

            return objcd_proveedor.Editar(obj, out Mensaje); // se llama al metodo editar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)// metodo para ELIMINAR proveedors
        {

            Mensaje = string.Empty; // se inicializa el mensaje como vacio


            if (obj.razon_social == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "La razon social no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.nro_documento == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.correo == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.telefono == "")
            {// se valida que la contraseña no este vacia
                Mensaje += "La telefono no puede estar vacia\n"; // se agrega el mensaje de error  


            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el proveedor
            }
            return objcd_proveedor.Eliminar(obj, out Mensaje); // se llama al metodo eliminar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }



    }
}
