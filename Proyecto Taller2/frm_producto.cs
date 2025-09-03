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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller2
{
    public partial class frm_producto : Form
    {
        public frm_producto()
        {
            InitializeComponent();
        }

        private void frm_producto_Load(object sender, EventArgs e)
        {
            //1 representa true y 0 representa false
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });// agregar una opcion al combo con valor 1
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";// mostrar el texto en el combo
            comboEstado.ValueMember = "Valor";// asociar el valor al texto
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            List<Categoria> listacategoria = new CN_Categoria().Listar(); // se crea una lista de roles y se llama al metodo listar de la clase CN_rol que esta en la capa de negocio


            foreach (Categoria item in listacategoria) // recorrer la lista de roles
            {
                //para cada item de la lista de roles
                // se almacena en la variable item y se agrega al combo
                combocategoria.Items.Add(new OpcionCombo() { Valor = item.id_categoria, Texto = item.descripcion });// agregar una opcion al combo con valor y texto del rol
            }
            combocategoria.DisplayMember = "Texto";// mostrar el texto en el combo
            combocategoria.ValueMember = "Valor";// asociar el valor al texto
            combocategoria.SelectedIndex = 0;// seleccionar la primera opcion del combo

            foreach (DataGridViewColumn columna in dataGrid_listacategoria.Columns)
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

            List<Producto> listaUsuario = new CN_Producto().Listar(); // obtiener la lista de usuarios desde la capa de negocio


            foreach (Producto item in lista) // recorre la lista
            {
                dataGrid_listacategoria.Rows.Add(new object[] // agregar una fila al datagrid
                 {"",
                 item.id_producto,
                 item.codigo,
                 item.nombre_producto,
                 item.descripcion,
                 item.oCategoria.id_categoria,      
                 item.oCategoria.descripcion,
                 item.stock,
                 item.precioCompra,
                 item.precioVenta,
                 item.estado == true ?1:0, // operador ternario para mostrar 1 o 0 en el datagrid
                 item.estado == true ?"Activo":"No Activo" // operador ternario para mostrar Activo o No Activo en el datagrid
                 });
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
        
        

           // if (!verificar_campos()) { return; } // si la verificación falla, salimos del método
            string mensaje = string.Empty; // variable para almacenar el mensaje de error
            Producto obj = new Producto()
            {  // crear un objeto de tipo usuario y asignar los valores de los campos del formulario
                id_producto = Convert.ToInt32(txt_id.Text),
                codigo = txt_codigo.Text,// asignar el valor del textbox documento
                nombre = txt_nombre.Text,
                descripcion = txt_descripcion.Text,
                oCategoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionCombo)comboCategoria.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.id_producto == 0)
            {

                int id_productoGenerado = new CN_Producto().Registrar(obj, out mensaje); // llamar al metodo registrar de la clase CN_usuario que esta en la capa de negocio

                if (id_productoGenerado != 0)
                {
                    dataGrid_listacategoria.Rows.Add(new object[]
                    {"",
                    id_productoGenerado,
                    txt_codigo.Text, 
                    txt_nombre.Text,
                    txt_descripcion.Text,
                    ((OpcionCombo)comboCategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboCategoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
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

                bool resultado = new CN_Producto().Editar(obj, out mensaje); // llamar al metodo editar de la clase CN_Productoque esta en la capa de negocio

                if (resultado)    // si el resultado es true
                {
                    DataGridViewRow row = dataGrid_listacategoria.Rows[Convert.ToInt32(txt_id.Text)];// dgvdata remplace por dataGrid_listaproducto
                    row.Cells["id_producto"].Value = txt_id.Text;
                    row.Cells["codigo"].Value = txt_codigo.Text;
                    row.Cells["nombre"].Value = txt_nombre.Text;
                    row.Cells["descripcion"].Value = txt_descripcion.Text;
                    row.Cells["id_categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).Texto.ToString();
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
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            comboCategoria.SelectedIndex = 0; // seleccionar la primera opcion del combo
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo


            txt_codigo.Select(); // colocar el foco en el textbox documento

        }

        private void dataGrid_listacategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dataGrid_listacategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_listacategoria.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                    //txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
                    txt_id.Text = dataGrid_listacategoria.Rows[indiceFila].Cells["id"].Value.ToString();
                    txt_codigo.Text = dataGrid_listacategoria.Rows[indiceFila].Cells["codigo"].Value.ToString();
                    txt_nombre.Text = dataGrid_listacategoria.Rows[indiceFila].Cells["nombre"].Value.ToString();
                    txt_descripcion.Text = dataGrid_listacategoria.Rows[indiceFila].Cells["descripcion"].Value.ToString();
            
                    foreach (OpcionCombo oc in comboCategoria.Items)
                    {// recorrer las opciones del combo rol
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listacategoria.Rows[indiceFila].Cells["id_rol"].Value))
                        { // si el valor de la opcion es igual al id_rol de la fila seleccionada
                            int indiceCombo = comboCategoria.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboCategoria.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in comboEstado.Items)// recorrer las opciones del combo estado
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listacategoria.Rows[indiceFila].Cells["estadoValor"].Value))// si el valor de la opcion es igual al estado_valor de la fila seleccionada
                        {
                            int indiceCombo = comboEstado.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboEstado.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }
                    }
                }
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
                string nombre = txt_nombre.Text + " " ; // obtener el nombre del usuario
                if (MessageBox.Show("¿ Desea elimina el producto " + nombre, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        id_producto = Convert.ToInt32(txt_id.Text),
                    };

                    bool respuesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (respuesta) // si la respuesta es true (se elimino el usuario)
                    {
                        dataGrid_listacategoria.Rows.RemoveAt(Convert.ToInt32(txt_id.Text)); //eliminar la fila del datagrid
                        limpiar(); // limpiar los campos del formulario
                        MessageBox.Show("Producto " + nombre + " Eliminado correctamente", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dataGrid_listacategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listacategoria.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay usuarios cargados que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listacategoria.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
            limpiar(); // limpiar los campos del formulario
        }



    }
}
