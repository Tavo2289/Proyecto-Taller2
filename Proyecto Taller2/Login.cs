using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;  // se agrega la referencia a la capa negocio
using CapaEntidad;
using System.Windows.Documents; // se agrega la referencia a la capa entidad

namespace Proyecto_Taller2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

           // if (!verificar_campos()) { return;  } // si la verificación falla, salimos del método
               

            //se crea un objeto usuario que busca en la lista de usuarios el que coincida con el número de documento y la contraseña ingresados
            Usuario usuario = new CN_usuario().Listar().Where(u => u.nro_documento == txt_NroDocumento.Text && u.contraseña == txt_contraseñaLogin.Text ).FirstOrDefault(); // busca el usuario en la lista de usuarios que coincida con el número de documento y la contraseña ingresados

            if (usuario != null) // si el usuario existe
            {
                Inicio formulario = new Inicio(usuario); //crea una instancia del formulario que se quiere abrir

                formulario.Show();//muestra el formulario
                this.Hide();//oculta el formulario actual

                formulario.FormClosed += new FormClosedEventHandler(frm_closing); //evento que se ejecuta al cerrar el formulario
            }
            else { MessageBox.Show("Usuario Incorrecto","Error de Sesion",MessageBoxButtons.OK,MessageBoxIcon.Error); } // si el usuario no existe muestra un mensaje de error


        }



        private void frm_closing(object sender, FormClosedEventArgs e)
        {

            txt_contraseñaLogin.Clear(); // Limpia el campo de contraseña
            txt_NroDocumento.Clear(); // Limpia el campo de número de documento
            this.Show(); // Muestra el formulario de login nuevamente
        }

        public bool verificar_campos()
        {// metodo para verificar que los campos no esten vacios y que el numero de documento sea numerico

            if (new[] { txt_contraseñaLogin, txt_NroDocumento }.Any(tb => string.IsNullOrWhiteSpace(tb.Text))) // verifica que los campos no esten vacios
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (int.TryParse(txt_NroDocumento.Text, out _)) { } //int.tryparse verificar que el valor ingresado sea numerico

            else
            {

                MessageBox.Show("El Documento debe ser Numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true; // si todo esta bien devuelve true

        }
    }
}
