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
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });// agregar una opcion al combo con valor 1
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

                if (columna.Visible == true && columna.Name != "btn_seleccionar")
                { // si la columna es visible
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


        private void limpiar()
        {
            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_documentoUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_apellidoUsuario.Text = "";
            txt_gmail.Text = "";
            txt_contraseñaUsuario.Text = "";
            txt_confirmarContraseña.Text = "";
            comboRol.SelectedIndex = 0; // seleccionar la primera opcion del combo
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo


        }

        private void txt_documentoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_listaUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // si es la fila de los encabezados
                return;
            if (e.ColumnIndex == 0)// si es la columna del boton seleccionar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); // pintar la celda
                var w = Properties.Resources.check20.Width;// obtener el ancho de la imagen
                var h = Properties.Resources.check20.Height;// obtener el alto de la imagen
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;// centrar la imagen en la celda
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;// centrar la imagen en la celda

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));// dibujar la imagen
                e.Handled = true;// indicar que se ha manejado el evento
            }
        }

        private void dataGrid_listaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_listaUsuario.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                    txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
                    txt_id.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["id"].Value.ToString();
                    txt_documentoUsuario.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["documento"].Value.ToString();
                    txt_nombreUsuario.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["nombre"].Value.ToString();
                    txt_apellidoUsuario.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["apellido"].Value.ToString();
                    txt_gmail.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["gmail"].Value.ToString();
                    txt_contraseñaUsuario.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["contraseña"].Value.ToString();
                    txt_confirmarContraseña.Text = dataGrid_listaUsuario.Rows[indiceFila].Cells["contraseña"].Value.ToString();

                    foreach (OpcionCombo oc in comboRol.Items)
                    {// recorrer las opciones del combo rol
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaUsuario.Rows[indiceFila].Cells["id_rol"].Value))
                        { // si el valor de la opcion es igual al id_rol de la fila seleccionada
                            int indiceCombo = comboRol.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboRol.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }


                    }

                    foreach (OpcionCombo oc in comboEstado.Items)// recorrer las opciones del combo estado
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaUsuario.Rows[indiceFila].Cells["estadoValor"].Value))// si el valor de la opcion es igual al estado_valor de la fila seleccionada
                        {
                            int indiceCombo = comboEstado.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboEstado.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }

                    }
                }



            }
        }

        private void lbl_detallaUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
