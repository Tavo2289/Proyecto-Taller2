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

namespace Proyecto_Taller2
{
    public partial class frm_proveedores : Form
    {
        public frm_proveedores()
        {
            InitializeComponent();
        }

        private void frm_proveedores_Load(object sender, EventArgs e)
        {
            //1 representa true y 0 representa false
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });// agregar una opcion al combo con valor 1
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";// mostrar el texto en el combo
            comboEstado.ValueMember = "Valor";// asociar el valor al texto
            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            //LLENAR COMBOBOX BUSQUEDA

            foreach (DataGridViewColumn columna in dataGrid_listaProveedor.Columns)
            {  // recorrer las columnas del datagrid

                if (columna.Visible == true && columna.Name != "btn_seleccionar")
                { // si la columna es visible
                    comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });// agregar una opcion al combo con valor y texto de la columna


                }


            }

            comboBox_busqueda.DisplayMember = "Texto";// mostrar el texto en el combo
            comboBox_busqueda.ValueMember = "Valor";// asociar el valor al texto
            comboBox_busqueda.SelectedIndex = 0;// seleccionar la primera opcion del combo

            /***MOSTRAR TODOS LOS Proveedor ***/



            List<Proveedor> listaProveedor = new CN_proveedor().Listar(); // obtiener la lista de Proveedor desde la capa de negocio


            foreach (Proveedor item in listaProveedor) // recorre la lista
            {
                dataGrid_listaProveedor.Rows.Add(new object[] // agregar una fila al datagrid
                 {"",item.id_proveedor,
                        item.razon_social,
                        item.nro_documento,
                        item.telefono,
                        item.correo,
                        item.estado == true ? 1 : 0,
                        item.estado == true ? "Activo" : "No Activo"
                    });


            }
        }



        private void dataGrid_listaProveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        private void dataGrid_listaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_listaProveedor.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                    txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
                    txt_id.Text = dataGrid_listaProveedor.Rows[indiceFila].Cells["id"].Value.ToString();
                    txt_razonSocial.Text = dataGrid_listaProveedor.Rows[indiceFila].Cells["razon_social"].Value.ToString();
                    txt_documento.Text = dataGrid_listaProveedor.Rows[indiceFila].Cells["nro_documento"].Value.ToString();
                    txt_telefono.Text = dataGrid_listaProveedor.Rows[indiceFila].Cells["telefono"].Value.ToString();
                    txt_correo.Text = dataGrid_listaProveedor.Rows[indiceFila].Cells["correo"].Value.ToString();




                    foreach (OpcionCombo oc in comboEstado.Items)// recorrer las opciones del combo estado
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaProveedor.Rows[indiceFila].Cells["estadoValor"].Value))// si el valor de la opcion es igual al estado_valor de la fila seleccionada
                        {
                            int indiceCombo = comboEstado.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboEstado.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }

                    }
                }
            }



        }


        private void limpiar()
        {
            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_documento.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_razonSocial.Text = "";


            comboEstado.SelectedIndex = 0;// seleccionar la primera opcion del combo

            txt_razonSocial.Select(); // colocar el foco en el textbox documento
        }


        public bool verificar_campos()
        {// metodo para verificar que los campos no esten vacios y que el numero de documento sea numerico

            if (new[] { txt_razonSocial, txt_documento, txt_correo, txt_telefono }.Any(tb => string.IsNullOrWhiteSpace(tb.Text))) // verifica que los campos no esten vacios
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (int.TryParse(txt_documento.Text, out _)) { } //int.tryparse verificar que el valor ingresado sea numerico

            else
            {

                MessageBox.Show("El Documento debe ser Numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (int.TryParse(txt_telefono.Text, out _)) { } //int.tryparse verificar que el valor ingresado sea numerico

            else
            {

                MessageBox.Show("El Documento debe ser Numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //verficar campos apellido y nombre solo contengan letras




            //verificamos que el gmail tenga un formato correcto

            if (Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) //verifica que el formato del gmail sea correcto
            {
                // El formato del correo electrónico es válido

            }
            else
            {
                MessageBox.Show("El formato del Gmail es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

            //verificamos que las contraseñas sean iguales

        }



        private void txt_soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!verificar_campos()) { return; } // si la verificación falla, salimos del método
            string mensaje = string.Empty; // variable para almacenar el mensaje de error
            Proveedor Proveedor = new Proveedor()
            {  // crear un objeto de tipo Proveedor y asignar los valores de los campos del formulario
                id_proveedor = Convert.ToInt32(txt_id.Text),
                nro_documento = txt_documento.Text,// asignar el valor del textbox documento
                razon_social = txt_razonSocial.Text,
                correo = txt_correo.Text,
                telefono = txt_telefono.Text,

                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (Proveedor.id_proveedor == 0)
            {

                int id_ProveedorGenerado = new CN_proveedor().Registrar(Proveedor, out mensaje); // llamar al metodo registrar de la clase CN_Proveedor que esta en la capa de negocio

                if (id_ProveedorGenerado != 0)
                {
                    dataGrid_listaProveedor.Rows.Add(new object[]
                    {"",id_ProveedorGenerado,
                        txt_razonSocial.Text,
                        txt_documento.Text,
                        txt_telefono.Text,
                        txt_correo.Text,
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

                bool resultado = new CN_proveedor().Editar(Proveedor, out mensaje); // llamar al metodo editar de la clase CN_Proveedors que esta en la capa de negocio

                if (resultado)    // si el resultado es true
                {
                    DataGridViewRow row = dataGrid_listaProveedor.Rows[Convert.ToInt32(txt_indice.Text)];// dgvdata remplace por dataGrid_listaProveedor
                    row.Cells["id"].Value = txt_id.Text;
                    row.Cells["razon_social"].Value = txt_razonSocial.Text;
                    row.Cells["nro_documento"].Value = txt_documento.Text;
                    row.Cells["telefono"].Value = txt_telefono.Text;
                    row.Cells["telefono"].Value = txt_telefono.Text;
                    row.Cells["correo"].Value = txt_correo.Text;
                  

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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
                string nombreProveedor = txt_razonSocial.Text; // obtener el nombre del usuario
                if (MessageBox.Show("¿ Desea elimina el Proveedor " + nombreProveedor, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Proveedor Proveedor = new Proveedor()
                    {
                        id_proveedor = Convert.ToInt32(txt_id.Text),
                    };

                    bool respuesta = new CN_proveedor().Eliminar(Proveedor, out mensaje);

                    if (respuesta) // si la respuesta es true (se elimino el usuario)
                    {
                        dataGrid_listaProveedor.Rows.RemoveAt(Convert.ToInt32(txt_indice.Text)); //eliminar la fila del datagrid
                        limpiar(); // limpiar los campos del formulario
                        MessageBox.Show("Proveedor " + nombreProveedor + " Eliminado correctamente", "Proveedor eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dataGrid_listaProveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay Proveedores cargados que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
        }
    }
}
