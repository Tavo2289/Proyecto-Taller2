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

        // metodos publicos que seran llamados desde la capa presentacion



        public List<Usuario> Listar() // metodo para listar usuarios
        {
            return objcd_usuario.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de usuarios
        }




        public int Registrar(Usuario obj, out string Mensaje)// metodo para registrar usuarios
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio



            //  VALIDACIONES
            if (obj.nombre == "") {// se valida que el nombre no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  


            }

            if (obj.apellido == "") {// se valida que el apellido no este vacio
                Mensaje += "El apellido no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nro_documento == "") {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.gmail == "") {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.contraseña == "") {// se valida que la contraseña no este vacia
                Mensaje += "La contraseña no puede estar vacia\n"; // se agrega el mensaje de error  
               
               
            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return 0; // se devuelve 0 para indicar que no se pudo registrar el usuario
            }
            else {

                return objcd_usuario.Registrar(obj, out Mensaje); // se llama al metodo registrar de la capa datos y se devuelve el id del usuario registrado y un mensaje
            }


               
        }



        public bool Editar(Usuario obj, out string Mensaje)// metodo para EDITAR usuarios
        {
            Mensaje = string.Empty; // se inicializa el mensaje como vacio



            //  VALIDACIONES
            if (obj.nombre == "")
            {// se valida que el nombre no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  


            }

            if (obj.apellido == "")
            {// se valida que el apellido no este vacio
                Mensaje += "El apellido no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nro_documento == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.gmail == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.contraseña == "")
            {// se valida que la contraseña no este vacia
                Mensaje += "La contraseña no puede estar vacia\n"; // se agrega el mensaje de error  
            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el usuario
            }

            return objcd_usuario.Editar(obj, out Mensaje); // se llama al metodo editar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }

        public bool Eliminar(Usuario obj, out string Mensaje)// metodo para ELIMINAR usuarios
        {

            Mensaje = string.Empty; // se inicializa el mensaje como vacio



            //  VALIDACIONES
            if (obj.nombre == "")
            {// se valida que el nombre no este vacio
                Mensaje += "El nombre no puede estar vacio\n"; // se agrega el mensaje de error  


            }

            if (obj.apellido == "")
            {// se valida que el apellido no este vacio
                Mensaje += "El apellido no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.nro_documento == "")
            {// se valida que el numero de documento no este vacio
                Mensaje += "El numero de documento no puede estar vacio\n"; // se agrega el mensaje de error  
            }

            if (obj.gmail == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.contraseña == "")
            {// se valida que la contraseña no este vacia
                Mensaje += "La contraseña no puede estar vacia\n"; // se agrega el mensaje de error  
            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el usuario
            }
            return objcd_usuario.Eliminar(obj, out Mensaje); // se llama al metodo eliminar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }
    }
}
