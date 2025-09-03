using CapaEntidad;
using CapaNegocio;
using Proyecto_Taller2.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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

            if (!verificar_campos()) { return; } // si la verificación falla, salimos del método
            string mensaje = string.Empty; // variable para almacenar el mensaje de error
            Usuario usuario = new Usuario()
            {  // crear un objeto de tipo usuario y asignar los valores de los campos del formulario
                id_usuario = Convert.ToInt32(txt_id.Text), 
                nro_documento = txt_documentoUsuario.Text,// asignar el valor del textbox documento
                nombre = txt_nombreUsuario.Text,
                apellido = txt_apellidoUsuario.Text,
                gmail = txt_gmail.Text,
                contraseña = txt_contraseñaUsuario.Text,
                id_rol = new Rol() { id_rol = Convert.ToInt32(((OpcionCombo)comboRol.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (usuario.id_usuario == 0)
            {

                int id_usuarioGenerado = new CN_usuario().Registrar(usuario, out mensaje); // llamar al metodo registrar de la clase CN_usuario que esta en la capa de negocio

                if (id_usuarioGenerado != 0)
                {
                    dataGrid_listaUsuario.Rows.Add(new object[]
                    {"",id_usuarioGenerado,txt_documentoUsuario.Text,txt_nombreUsuario.Text,txt_apellidoUsuario.Text,txt_gmail.Text,txt_contraseñaUsuario.Text ,
                    ((OpcionCombo)comboRol.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboRol.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString()
                    });
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }
            else
            { // si no es 0 es porque ya existe y se va a editar 

                bool resultado = new CN_usuario().Editar(usuario, out mensaje); // llamar al metodo editar de la clase CN_usuario que esta en la capa de negocio

                if (resultado)    // si el resultado es true
                {
                    DataGridViewRow row = dataGrid_listaUsuario.Rows[Convert.ToInt32(txt_id.Text)];// dgvdata remplace por dataGrid_listaUsuario
                    row.Cells["id"].Value = txt_id.Text;
                    row.Cells["documento"].Value = txt_documentoUsuario.Text;
                    row.Cells["nombre"].Value = txt_nombreUsuario.Text;
                    row.Cells["apellido"].Value = txt_apellidoUsuario.Text;
                    row.Cells["gmail"].Value = txt_gmail.Text;
                    row.Cells["contraseña"].Value = txt_contraseñaUsuario.Text;
                    row.Cells["id_rol"].Value = ((OpcionCombo)comboRol.SelectedItem).Valor.ToString();
                    row.Cells["rol"].Value = ((OpcionCombo)comboRol.SelectedItem).Texto.ToString();
                    row.Cells["estadoValor"].Value = ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    limpiar();// limpiar los campos del formulario
                }
                else 
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }
        }


        private void limpiar()
        {
            //txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_documentoUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_apellidoUsuario.Text = "";
            txt_gmail.Text = "";
            txt_contraseñaUsuario.Text = "";
            txt_confirmarContraseña.Text = "";
            comboRol.SelectedIndex = 0; // seleccionar la primera opcion del combo
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo


            txt_nombreUsuario.Select(); // colocar el foco en el textbox documento

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
                    //txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
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

        /******************VALIDACIONES DE CAMPOS**********************/

        public bool verificar_campos()
        {// metodo para verificar que los campos no esten vacios y que el numero de documento sea numerico

            if (new[] { txt_nombreUsuario, txt_apellidoUsuario, txt_documentoUsuario, txt_contraseñaUsuario, txt_confirmarContraseña, txt_gmail }.Any(tb => string.IsNullOrWhiteSpace(tb.Text))) // verifica que los campos no esten vacios
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (int.TryParse(txt_documentoUsuario.Text, out _)) { } //int.tryparse verificar que el valor ingresado sea numerico

            else
            {

                MessageBox.Show("El Documento debe ser Numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //verficar campos apellido y nombre solo contengan letras

            if (Regex.IsMatch(txt_apellidoUsuario.Text, @"^[a-zA-Z]+$")) //verifica que solo contenga letras (mayúsculas o minúsculas)
            {
                // Es solo texto (letras mayúsculas o minúsculas)

            }
            else
            {
                MessageBox.Show("Ingresa correctamente su Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Regex.IsMatch(txt_nombreUsuario.Text, @"^[a-zA-Z]+$"))
            {
                // Es solo texto (letras mayúsculas o minúsculas)

            }
            else
            {

                MessageBox.Show("Ingresa correctamente su Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //verificamos que el gmail tenga un formato correcto

            if (Regex.IsMatch(txt_gmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) //verifica que el formato del gmail sea correcto
            {
                // El formato del correo electrónico es válido

            }
            else
            {
                MessageBox.Show("El formato del Gmail es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //verificamos que las contraseñas sean iguales

            if (txt_contraseñaUsuario.Text != txt_confirmarContraseña.Text) // verifica que las contraseñas sean iguales
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {


                return true; // si todo esta bien devuelve true

            }
        }

        /*poner la primera letra en mayusculas*/


        private void txtnombreUsuario_Leave(object sender, EventArgs e)
        {
            txt_nombreUsuario.Text = FormatearTexto(txt_nombreUsuario.Text);
        }

        private void txtapellidoUsuario_Leave(object sender, EventArgs e)
        {
            txt_apellidoUsuario.Text = FormatearTexto(txt_apellidoUsuario.Text);
        }
        private string FormatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            texto = texto.Trim().ToLower(); // todo minúscula y sin espacios sobrantes
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }

        //ACEPTAR SOLO NUMEROS EN EL CAMPO DOCUMENTO
        private void txt_soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e) // eliminar usuario
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
               string nombreUsuario = txt_nombreUsuario.Text+" "+ txt_apellidoUsuario.Text; // obtener el nombre del usuario
                if (MessageBox.Show("¿ Desea elimina el usuario "+ nombreUsuario, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario usuario = new Usuario()
                    {
                        id_usuario = Convert.ToInt32(txt_id.Text),
                    };

                    bool respuesta = new CN_usuario().Eliminar(usuario, out mensaje);

                    if (respuesta) // si la respuesta es true (se elimino el usuario)
                    {
                        dataGrid_listaUsuario.Rows.RemoveAt(Convert.ToInt32(txt_id.Text)); //eliminar la fila del datagrid
                        limpiar(); // limpiar los campos del formulario
                        MessageBox.Show("Usuario "+nombreUsuario+" Eliminado correctamente","Usuario eliminado",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }                
            } 
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();

            if (dataGrid_listaUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else {
                MessageBox.Show("No hay usuarios cargados que pueda buscar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaUsuario.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
            limpiar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_documentoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbl_contraseñaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contraseñaUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellidoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_confirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_confirmarContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rolUsuario_Click(object sender, EventArgs e)
        {

        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_estadoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_buscar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_gmail_Click(object sender, EventArgs e)
        {

        }

        private void txt_indice_TextChanged(object sender, EventArgs e)
        {

        }

        private void brt_limpiar_Click(object sender, EventArgs e)
        {
            limpiar(); // limpiar los campos del formulario
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar(); // limpiar los campos del formulario
        }
    }



}
