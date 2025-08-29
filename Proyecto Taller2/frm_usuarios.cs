using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller2.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace Proyecto_Taller2
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void frm_usuarios_Load(object sender, EventArgs e)// cargar el formulario
        {
            //1 representa true y 0 representa false
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1 , Texto="Activo"});// agregar una opcion al combo con valor 1
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";// mostrar el texto en el combo
            comboEstado.ValueMember = "Valor";// asociar el valor al texto
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            List<Rol> listaRol = new CN_rol().Listar(); // se crea una lista de roles y se llama al metodo listar de la clase CN_rol que esta en la capa de negocio


            foreach (Rol item in listaRol) // recorrer la lista de roles
            {
                //para cada item de la lista de roles
                // se almacena en la variable item y se agrega al combo
                comboRol.Items.Add(new OpcionCombo() { Valor = item.id_rol, Texto = item.nombre_rol });// agregar una opcion al combo con valor y texto del rol
            }
            comboRol.DisplayMember = "Texto";// mostrar el texto en el combo
            comboRol.ValueMember = "Valor";// asociar el valor al texto
            comboRol.SelectedIndex = 0;// seleccionar la primera opcion del combo

            foreach (DataGridViewColumn columna in dataGrid_listaUsuario.Columns)
            {  // recorrer las columnas del datagrid

                if (columna.Visible == true && columna.Name != "btn_seleccionar") { // si la columna es visible
                    comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });// agregar una opcion al combo con valor y texto de la columna


                }
            
            
            }

            comboBox_busqueda.DisplayMember = "Texto";// mostrar el texto en el combo
            comboBox_busqueda.ValueMember = "Valor";// asociar el valor al texto
            comboBox_busqueda.SelectedIndex = 0;// seleccionar la primera opcion del combo

            /***MOSTRAR TODOS LOS USUARIOS ***/



            List<Usuario> listaUsuario = new CN_usuario().Listar(); // obtiener la lista de usuarios desde la capa de negocio


            foreach (Usuario item in listaUsuario) // recorre la lista
            {
                dataGrid_listaUsuario.Rows.Add(new object[] // agregar una fila al datagrid
                 {"",item.id_usuario,item.nro_documento,item.nombre,item.apellido,item.gmail,item.contraseña ,
                 item.id_rol.id_rol,item.id_rol.nombre_rol,
                 item.estado == true ?1:0, // operador ternario para mostrar 1 o 0 en el datagrid
                 item.estado == true ?"Activo":"No Activo" // operador ternario para mostrar Activo o No Activo en el datagrid
                    });
             

            }
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            dataGrid_listaUsuario.Rows.Add(new object[] 
            {"",txt_id.Text,txt_documentoUsuario.Text,txt_nombreUsuario.Text,txt_apellidoUsuario.Text,txt_gmail.Text,txt_contraseñaUsuario.Text ,
                ((OpcionCombo)comboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString()
            });
            limpiar();
        }


        private void limpiar() {
            txt_id.Text = "0";
            txt_documentoUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_apellidoUsuario.Text = "";
            txt_gmail.Text = "";
            txt_contraseñaUsuario.Text = "";
            txt_confirmarContraseña.Text = "";
            comboRol.SelectedIndex = 0; // seleccionar la primera opcion del combo
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            //aca hice cagada

        }

        private void txt_documentoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
