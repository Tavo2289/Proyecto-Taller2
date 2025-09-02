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
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            //1 representa true y 0 representa false
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });// agregar una opcion al combo con valor 1
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";// mostrar el texto en el combo
            comboEstado.ValueMember = "Valor";// asociar el valor al texto
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            foreach (DataGridViewColumn columna in dataGrid_listaCategoria.Columns)
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

            List<Categoria> lista = new CN_Categoria().Listar(); // obtiener la lista de usuarios desde la capa de negocio

            foreach (Categoria item in lista) // recorre la lista
            {
                dataGrid_listaCategoria.Rows.Add(new object[] // agregar una fila al datagrid
                 {"",item.id_categoria,item.nombre_categoria,
                 item.estado == true ?1:0, // operador ternario para mostrar 1 o 0 en el datagrid
                 item.estado == true ?"Activo":"No Activo" // operador ternario para mostrar Activo o No Activo en el datagrid
                    });
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty; // variable para almacenar el mensaje de error

            Categoria obj = new Categoria()
            {  // crear un objeto de tipo usuario y asignar los valores de los campos del formulario
                id_categoria = Convert.ToInt32(txt_id.Text),
                nombre_categoria= txt_descripcion.Text,// asignar el valor del textbox documento
                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj.id_categoria == 0)
            {

                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje); // llamar al metodo registrar de la clase CN_usuario que esta en la capa de negocio

                if (idgenerado != 0)
                {
                    dataGrid_listaCategoria.Rows.Add(new object[]
                    {"",idgenerado,txt_descripcion.Text,
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
            {
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dataGrid_listaCategoria.Rows[Convert.ToInt32(txt_indice.Text)];// dgvdata remplace por dataGrid_listaUsuario
                    row.Cells["id"].Value = txt_id.Text;
                    row.Cells["Descripcion"].Value = txt_descripcion.Text;
                    row.Cells["estadoValor"].Value = ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }
        }

            private void limpiar()
        {
            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_descripcion.Text = "";

            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            txt_descripcion.Select();
        }

        private void dataGrid_lista_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dataGrid_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_listaCategoria.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                    txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
                    txt_id.Text = dataGrid_listaCategoria.Rows[indiceFila].Cells["id"].Value.ToString();
                    txt_descripcion.Text = dataGrid_listaCategoria.Rows[indiceFila].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in comboEstado.Items)// recorrer las opciones del combo estado
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaCategoria.Rows[indiceFila].Cells["estadoValor"].Value))// si el valor de la opcion es igual al estado_valor de la fila seleccionada
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
                string descripcion = txt_descripcion.Text;
                if (MessageBox.Show("¿ Desea elimina la categoria "+ descripcion+" ?" , "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        id_categoria = Convert.ToInt32(txt_id.Text),
                    };

                    bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dataGrid_listaCategoria.Rows.RemoveAt(Convert.ToInt32(txt_indice.Text));
                        limpiar();
                        MessageBox.Show("Categoria "+descripcion + " eliminada correctamente","Categoria Eliminada",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

            if (dataGrid_listaCategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaCategoria.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            foreach (DataGridViewRow row in dataGrid_listaCategoria.Rows)
            {
                row.Visible = true;
            }
        }

        private void brt_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}