using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Inicio formulario = new Inicio(); //crea una instancia del formulario que se quiere abrir

            formulario.Show();//muestra el formulario
            this.Hide();//oculta el formulario actual

            formulario.FormClosed += new FormClosedEventHandler(frm_closing); //evento que se ejecuta al cerrar el formulario

        }



        private void frm_closing(object sender, FormClosedEventArgs e)
        {

            txt_contraseñaLogin.Clear(); // Limpia el campo de contraseña
            txt_NroDocumento.Clear(); // Limpia el campo de número de documento
            this.Show(); // Muestra el formulario de login nuevamente
        }
    }
}
