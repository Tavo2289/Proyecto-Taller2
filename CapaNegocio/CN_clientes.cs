using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_clientes
    {
        private CD_cliente objcd_Cliente = new CD_cliente(); // se crea un objeto de la clase CD_Cliente para acceder a sus metodos

        // metodos publicos que seran llamados desde la capa presentacion



        public List<Cliente> Listar() // metodo para listar Clientes
        {
            return objcd_Cliente.Listar(); // se llama al metodo listar de la capa datos y se devuelve la lista de Clientes
        }




        public int Registrar(Cliente obj, out string Mensaje)// metodo para registrar Clientes
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

            if (obj.correo == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }
            if (obj.telefono == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El telefono no puede estar vacio\n"; // se agrega el mensaje de error  
            }




            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return 0; // se devuelve 0 para indicar que no se pudo registrar el Cliente
            }
            else
            {

                return objcd_Cliente.Registrar(obj, out Mensaje); // se llama al metodo registrar de la capa datos y se devuelve el id del Cliente registrado y un mensaje
            }



        }



        public bool Editar(Cliente obj, out string Mensaje)// metodo para EDITAR Clientes
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
                return false; // se devuelve false para indicar que no se pudo registrar el Cliente
            }

            return objcd_Cliente.Editar(obj, out Mensaje); // se llama al metodo editar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }

        public bool Eliminar(Cliente obj, out string Mensaje)// metodo para ELIMINAR Clientes
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

            if (obj.correo  == "")
            {// se valida que el gmail no este vacio
                Mensaje += "El gmail no puede estar vacio\n"; // se agrega el mensaje de error  
            }


            if (obj.telefono == "")
            {// se valida que la telefono no este vacia
                Mensaje += "La telefono no puede estar vacia\n"; // se agrega el mensaje de error  
            }


            if (Mensaje != string.Empty)
            {// si el mensaje no esta vacio es porque hubo errores en las validaciones
                return false; // se devuelve false para indicar que no se pudo registrar el Cliente
            }
            return objcd_Cliente.Eliminar(obj, out Mensaje); // se llama al metodo eliminar de la capa datos y se devuelve el resultado de la operacion y un mensaje
        }
    }
 } 
