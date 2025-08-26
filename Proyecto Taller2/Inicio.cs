using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad; // referencia capa de entidad
using FontAwesome.Sharp;  // referencia a plugin de iconos
using CapaNegocio; // referencia a capa de negocio

namespace Proyecto_Taller2
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual; //variable estatica de tipo usuario para almacenar el usuario que ha iniciado sesión
        private static IconMenuItem menuActivo = null; // representa a los iconos del menu de formularios
        private static Form formularioActivo = null; //indica el formulario que va estar activo
        public Inicio(Usuario objUsuario =null)
        {

            if (objUsuario == null) { usuarioActual = new Usuario() { nombre = "Admin", apellido = "predifinido", id_usuario = 1 }; }// si no se pasa ningun usuario por defecto se crea un usuario admin predeterminado
            else { usuarioActual = objUsuario; } // si no se pasa ningun usuario por defecto se crea un usuario admin predeterminado
             // se asigna el usuario que ha iniciado sesión a la variable estatica
            InitializeComponent();
        }

        private void lbl_nombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> listaPermisos = new CN_permisos().Listar(usuarioActual.id_usuario); //se obtiene la lista de permisos del usuario que ha iniciado sesión

            foreach (IconMenuItem iconMenu in menuPrincipal.Items) //recorre todos los iconos del menu
            {
                bool encontrado = listaPermisos.Any(p => p.nombre_menu == iconMenu.Name); //verifica si el nombre del icono coincide con algun permiso del usuario


                if (!encontrado) //si no se encuentra el permiso
                {
                    iconMenu.Visible = false; //oculta el icono del menu
                }
            }

            lbl_nombreUsuario.Text = usuarioActual.nombre + " " + usuarioActual.apellido; //muestra el nombre y apellido del usuario que ha iniciado sesión
        }

        private void iconUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frm_usuarios()); //abre el formulario de usuarios al hacer clic en el icono de usuario
        }


        private void abrirFormulario(IconMenuItem menu , Form formulario) { // metodo recibe menu el cual esta siendo clicleado

            if (menuActivo != null) {// si un icono esta precionado

                menuActivo.BackColor = Color.White; //cuando este en un menu su color de icono sera blanco
            
            }
            menu.BackColor = Color.Silver;  //se colorea el icono precionado
            menuActivo = menu; // se asigna el valor a la variable global


            if (formularioActivo != null) { // si hay un formulario abierto

                formularioActivo.Close();  // se cierra
            }

            formularioActivo = formulario; //se actualiza la variable global con el nuevo formulario
            formulario.TopLevel = false; // 
            formulario.FormBorderStyle = FormBorderStyle.None; ; // el formulario actual no tendra ningun borde
            formulario.Dock = DockStyle.Fill; //propiedad dock , el formulario va tomar todo el espacio del contenedor panel_contendor
            formulario.BackColor = Color.SlateBlue; //cambia el color de fondo del formulario
            panel_contenedor.Controls.Add(formulario); // se agrega el formulario al contenedor
            formulario.Show(); // mostrar el formulario

        }

        private void subMenu_categoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMantenedor, new frm_categoria());//abre el formulario de categorias al hacer clic en el submenu categoria
        }

        private void subMenu_producto_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconMantenedor, new frm_producto());// primer parametro es el icono que se esta clicleando y el segundo es el formulario que se va abrir
        }

        private void subMenu_registrar_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconVentas, new frm_venta());
        }

        private void subMenu_verDetalles_Click(object sender, EventArgs e) //submenu ver detalles de venta
        {
            abrirFormulario(iconVentas, new frm_detalleVenta()); 
        }

        private void subMenu_registrarCompra_Click(object sender, EventArgs e)
        {

            abrirFormulario(iconCompras, new frm_compras());

        }

        private void subMenu_verDetallesCompra_Click(object sender, EventArgs e)
        {
            abrirFormulario(iconCompras, new frm_detalleCompra());
        }

        private void iconClientes_Click(object sender, EventArgs e)
        {
            //el primer parametro es el icono que se esta clicleando que se convierte a IconMenuItem y el segundo es el formulario que se va abrir
            abrirFormulario((IconMenuItem)sender, new frm_clientes()); //abre el formulario de clientes al hacer clic en el icono de clientes
        }

        private void iconProveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frm_proveedores()); //abre el formulario de proveedores al hacer clic en el icono de proveedores
        }

        private void iconReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frm_reportes()); //abre el formulario de reportes al hacer clic en el icono de reportes
        }
    }
}
