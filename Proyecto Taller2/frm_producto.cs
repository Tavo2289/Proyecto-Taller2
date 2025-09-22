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
using ClosedXML.Excel; // importa la libreria ClosedXML para trabajar con archivos Excel

namespace Proyecto_Taller2
{
    public partial class frm_producto : Form
    {
        public frm_producto()
        {
            InitializeComponent();
        }

    

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {

            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaProducto.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }

        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();

            if (dataGrid_listaProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaProducto.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay productos cargados que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }









        }

       

        private void frm_producto_Load(object sender, EventArgs e)
        {
            //1 representa true y 0 representa false
            comboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });// agregar una opcion al combo con valor 1
            comboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            comboEstado.DisplayMember = "Texto";// mostrar el texto en el combo
            comboEstado.ValueMember = "Valor";// asociar el valor al texto
            comboEstado.SelectedIndex = -1;// seleccionar la primera opcion del combo

            List<Categoria> listaCategoria = new CN_Categoria().Listar(); // se crea una lista de Categoriaes y se llama al metodo listar de la clase CN_Categoria que esta en la capa de negocio


            foreach (Categoria item in listaCategoria) // recorrer la lista de Categoriaes
            {
                //para cada item de la lista de Categoriaes
                // se almacena en la variable item y se agrega al combo
                comboCategoria.Items.Add(new OpcionCombo() { Valor = item.id_categoria, Texto = item.nombre_categoria });// agregar una opcion al combo con valor y texto del Categoria
            }
            comboCategoria.DisplayMember = "Texto";// mostrar el texto en el combo
            comboCategoria.ValueMember = "Valor";// asociar el valor al texto
            comboCategoria.SelectedIndex = -1;// seleccionar la primera opcion del combo

            foreach (DataGridViewColumn columna in dataGrid_listaProducto.Columns)
            {  // recorrer las columnas del datagrid

                if (columna.Visible == true && columna.Name != "btn_seleccionar")
                { // si la columna es visible
                    comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });// agregar una opcion al combo con valor y texto de la columna


                }


            }

            comboBox_busqueda.DisplayMember = "Texto";// mostrar el texto en el combo
            comboBox_busqueda.ValueMember = "Valor";// asociar el valor al texto
            comboBox_busqueda.SelectedIndex = 0;// seleccionar la primera opcion del combo

            /***MOSTRAR TODOS LOS ProductoS ***/



            List<Producto> listaProducto = new CN_producto().Listar(); // obtiener la lista de Productos desde la capa de negocio


            foreach (Producto item in listaProducto) // recorre la lista
            {
                dataGrid_listaProducto.Rows.Add(new object[] // agregar una fila al datagrid
                 {"",item.id_producto,
                     item.codigo,
                     item.nombre_producto,
                     item.descripcion,
                     item.id_categoria.id_categoria,/*id_categoria es un objeto que contiene atributos asi que debo indicar que atributo quiero pasar despues del punto*/
                     item.id_categoria.nombre_categoria,
                     item.stock,
                     item.precio_compra,
                     item.precio_venta,

                 item.estado == true ?1:0, // operador ternario para mostrar 1 o 0 en el datagrid
                 item.estado == true ?"Activo":"No Activo" // operador ternario para mostrar Activo o No Activo en el datagrid
                    });


            }
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {


            if (!verificar_campos_Registrar()) { return; }// si la verificación falla, salimos del método
            string mensaje = string.Empty; // variable para almacenar el mensaje de error
            Producto Producto = new Producto()
            {  // crear un objeto de tipo Producto y asignar los valores de los campos del formulario
                id_producto = Convert.ToInt32(txt_id.Text),
                id_categoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionCombo)comboCategoria.SelectedItem).Valor) },
                codigo = txt_codigo.Text,
                nombre_producto = txt_nombre.Text,
                descripcion = txt_descripcion.Text,

                estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (Producto.id_producto == 0)
            {

                int id_ProductoGenerado = new CN_producto().Registrar(Producto, out mensaje); // llamar al metodo registrar de la clase CN_Producto que esta en la capa de negocio

                if (id_ProductoGenerado != 0)
                {
                    dataGrid_listaProducto.Rows.Add(new object[]
                    {"",id_ProductoGenerado,txt_codigo.Text,txt_nombre.Text,txt_descripcion.Text,
                    ((OpcionCombo)comboCategoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboCategoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",

                    ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString()
                    });
                    MessageBox.Show("Producto "+txt_nombre.Text +" Cod:"+txt_codigo.Text+" Registrado Correctamente","Producto Registrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }
           

        }

        private void dataGrid_listaProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dataGrid_listaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_listaProducto.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                btn_modificar.Visible=true;
                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                    txt_indice.Text = indiceFila.ToString(); // mostrar el indice en el textbox
                    txt_id.Text = dataGrid_listaProducto.Rows[indiceFila].Cells["id"].Value.ToString();
                    txt_codigo.Text = dataGrid_listaProducto.Rows[indiceFila].Cells["codigo"].Value.ToString();
                    txt_nombre.Text = dataGrid_listaProducto.Rows[indiceFila].Cells["nombre"].Value.ToString();
                    txt_descripcion.Text = dataGrid_listaProducto.Rows[indiceFila].Cells["descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in comboCategoria.Items)
                    {// recorrer las opciones del combo Categoria
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaProducto.Rows[indiceFila].Cells["id_categoria"].Value))
                        { // si el valor de la opcion es igual al id_Categoria de la fila seleccionada
                            int indiceCombo = comboCategoria.Items.IndexOf(oc);// obtener el indice de la opcion
                            comboCategoria.SelectedIndex = indiceCombo;// seleccionar la opcion en el combo
                            break;
                        }


                    }






                    foreach (OpcionCombo oc in comboEstado.Items)// recorrer las opciones del combo estado
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dataGrid_listaProducto.Rows[indiceFila].Cells["estadoValor"].Value))// si el valor de la opcion es igual al estado_valor de la fila seleccionada
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

            btn_modificar.Visible= false;
            btn_guardar.Visible= true; 

            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";

            comboCategoria.SelectedIndex = -1; // seleccionar la primera opcion del combo
            comboEstado.SelectedIndex = -1;// seleccionar la primera opcion del combo

            txt_codigo.Select(); // colocar el foco en el textbox documento
        }


        

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
                string nombreProducto = txt_nombre.Text; // obtener el nombre del producto
                if (MessageBox.Show("¿ Desea elimina el producto " + nombreProducto, "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto producto = new Producto()
                    {
                        id_producto = Convert.ToInt32(txt_id.Text),
                    };

                    bool respuesta = new CN_producto().Eliminar(producto, out mensaje);

                    if (respuesta) // si la respuesta es true (se elimino el producto)
                    {
                        dataGrid_listaProducto.Rows.RemoveAt(Convert.ToInt32(txt_indice.Text)); //eliminar la fila del datagrid
                        limpiar(); // limpiar los campos del formulario
                        MessageBox.Show("Producto " + nombreProducto + " Eliminado correctamente", "Producto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //el cambo txt_codigo solo permite numeros
        private void txt_soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }


        private void txtnombre_Leave(object sender, EventArgs e)
        {
            txt_nombre.Text = FormatearTexto(txt_nombre.Text);
        }

        private void txtdescripcion_Leave(object sender, EventArgs e)
        {
            txt_descripcion.Text = FormatearTexto(txt_descripcion.Text);
        }
        private string FormatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return string.Empty;

            texto = texto.Trim().ToLower(); // todo minúscula y sin espacios sobrantes
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dataGrid_listaProducto.Rows.Count < 1)
            { // si no hay filas en el datagrid
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dataGrid_listaProducto.Columns) // recorrer las columnas del datagrid
                {
                    if (column.HeaderText != "" && column.Visible) // si el encabezado de la columna no esta vacio
                        dt.Columns.Add(column.HeaderText, typeof(string)); // agregar la columna al datatable
                }
                foreach (DataGridViewRow row in dataGrid_listaProducto.Rows) // recorrer las filas del datagrid
                {
                    if (row.Visible) // si la fila es visible
                    {
                        dt.Rows.Add(new object[] // agregar la fila al datatable
                            {

                                row.Cells[2].Value.ToString(), // omitir la columna del boton seleccionar
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[6].Value.ToString(),

                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[11].Value.ToString(),

                            });



                    }
                }

                    SaveFileDialog savefile = new SaveFileDialog(); // crear un cuadro de dialogo para guardar el archivo
                    savefile.FileName = string.Format("Reporte_Productos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));// nombre del archivo
                    savefile.Filter = "Excel Files | *.xlsx"; // solo permitir archivos excel


                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        try
                        {
                            XLWorkbook wb = new XLWorkbook(); // crear un libro de excel
                            var hoja = wb.Worksheets.Add(dt, "Informe"); // agregar el datatable a la hoja de excel
                            hoja.ColumnsUsed().AdjustToContents(); // ajustar el ancho de las columnas al contenido
                            wb.SaveAs(savefile.FileName); // guardar el archivo

                            MessageBox.Show("Reporte exportado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Error al exportar el reporte ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
            }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
                if (!verificar_campos_Modificar()) { return; }// si la verificación falla, salimos del método
                string mensaje = string.Empty; // variable para almacenar el mensaje de error
                Producto Producto = new Producto()
                {  // crear un objeto de tipo Producto y asignar los valores de los campos del formulario
                    id_producto = Convert.ToInt32(txt_id.Text),
                    id_categoria = new Categoria() { id_categoria = Convert.ToInt32(((OpcionCombo)comboCategoria.SelectedItem).Valor) },
                    codigo = txt_codigo.Text,
                    nombre_producto = txt_nombre.Text,
                    descripcion = txt_descripcion.Text,

                    estado = Convert.ToInt32(((OpcionCombo)comboEstado.SelectedItem).Valor) == 1 ? true : false
                };

            bool resultado = new CN_producto().Editar(Producto, out mensaje); // llamar al metodo editar de la clase CN_Producto que esta en la capa de negocio

                if (resultado)    // si el resultado es true
                {
                    DataGridViewRow row = dataGrid_listaProducto.Rows[Convert.ToInt32(txt_indice.Text)];// dgvdata remplace por dataGrid_listaProducto
                    row.Cells["id"].Value = txt_id.Text;
                    row.Cells["codigo"].Value = txt_codigo.Text;
                    row.Cells["nombre"].Value = txt_nombre.Text;
                    row.Cells["descripcion"].Value = txt_descripcion.Text;
                    row.Cells["id_categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).Valor.ToString();
                    row.Cells["categoria"].Value = ((OpcionCombo)comboCategoria.SelectedItem).Texto.ToString();
                    //row.Cells["stock"].Value = txt_stock.Text;
                    //row.Cells["precio_compra"].Value = txt_precioCompra.Text;
                    //row.Cells["precio_venta"].Value = txt_precioVenta.Text;
                    row.Cells["estadoValor"].Value = ((OpcionCombo)comboEstado.SelectedItem).Valor.ToString();
                    row.Cells["estado"].Value = ((OpcionCombo)comboEstado.SelectedItem).Texto.ToString();

                    limpiar();// limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }




        public bool verificar_campos_Registrar()
        {
            // Limpia errores y colores de todos los campos al inicio
            LimpiarErroresYColores();
            bool respuesta = true; // Bandera para indicar si hay algún campo vacío o algun error

            // Lista de todos los TextBoxes
            TextBox[] textboxes = { txt_codigo, txt_nombre, txt_descripcion };

            // Paso 1: Verificar si todos los campos están vacíos
            if (textboxes.All(tb => string.IsNullOrWhiteSpace(tb.Text)) && comboEstado.SelectedIndex == -1 && comboCategoria.SelectedIndex == -1)
            {
                MarcarTodosLosCampos();
                MessageBox.Show("Todos los campos están vacíos. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool algúnCampoVacio = false;

            // Paso 2: Verificación de cada campo individualmente
            // Se valida cada campo y se activa la bandera si está vacío o no es válido

            // Verificación de codigo 
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                errorCodigo.SetError(txt_nombre, "Ingrese el Codigo.");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (txt_codigo.Text.Length > 4 || !int.TryParse(txt_codigo.Text, out int documento) || documento < 1000 || documento > 9999)
            {
                errorCodigo.SetError(txt_codigo, "El Codigo no es válido o está fuera de rango, Debe contener 4 digitos");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Codigo no es válido o está fuera de rango, Debe contener 4 digitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }
            else if (CodigoExiste())
            {


                errorCodigo.SetError(txt_codigo, "Este Codigo ya fue registrado.");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este Codigo de Productp ya fue registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                respuesta = false;

            }

            // Verificación de nombre
            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                errorNombre.SetError(txt_nombre, "Ingrese el Nombre.");
                txt_nombre.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.]+$"))
            {
                errorNombre.SetError(txt_nombre, "El Nombre solo debe contener letras y puntos.");
                txt_nombre.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Nombre solo debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }


            //verificacion de descripcion
            // Verificación de nombre
            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                errorDescripcion.SetError(txt_descripcion, "Ingrese el Descripcion.");
                txt_descripcion.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_descripcion.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.\d]+$")) 
            {
                errorDescripcion.SetError(txt_descripcion, "La Descripcion solo debe contener letras , puntos o numeros.");
                txt_descripcion.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("La Descripcion solo debe contener letras , puntos o numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }



            //verificacion de combox
            if (comboCategoria.SelectedIndex == -1)
            {
                if (algúnCampoVacio == true) // si algun campo antes de combo estado ya estaba vacio , no mostrar mensaje
                {

                    errorCategoria.SetError(comboCategoria, "Seleccione una Categoria.");
                    comboCategoria.BackColor = System.Drawing.Color.MistyRose;

                    algúnCampoVacio = true;

                }
                else
                {

                    errorCategoria.SetError(comboCategoria, "Seleccione un Categoria.");
                    comboCategoria.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Seleccione un Categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    respuesta = false;

                }
            }




            if (comboEstado.SelectedIndex == -1)
            {
                if (algúnCampoVacio == true) // si algun campo antes de combo estado ya estaba vacio , no mostrar mensaje
                {

                    errorEstado.SetError(comboEstado, "Seleccione un Estado.");
                    comboEstado.BackColor = System.Drawing.Color.MistyRose;

                    algúnCampoVacio = true;

                }
                else
                {

                    errorEstado.SetError(comboEstado, "Seleccione un Estado.");
                    comboEstado.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Seleccione un Estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    respuesta = false;

                }
            }

            // Paso 3: Al finalizar, si algún campo está vacío, se muestra el MessageBox
            if (algúnCampoVacio)
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }

            // Si todas las validaciones pasan, el método devuelve true
            return respuesta;
        }

        // Métodos auxiliares para la lógica anterior
        private void LimpiarErroresYColores()
        {
            // Lógica para limpiar todos los errores y restablecer los colores
            errorCodigo.Clear();
            errorNombre.Clear();
            errorDescripcion.Clear();
            errorEstado.Clear();
            errorCategoria.Clear();

            txt_codigo.BackColor = System.Drawing.Color.White;
            txt_nombre.BackColor = System.Drawing.Color.White;
            txt_descripcion.BackColor = System.Drawing.Color.White;
            comboEstado.BackColor = System.Drawing.Color.White;
            comboCategoria.BackColor = System.Drawing.Color.White;

        }

        private void MarcarTodosLosCampos()
        {
            // Lógica para marcar todos los campos vacíos con color y error
            errorCodigo.SetError(txt_codigo, "Este campo es requerido.");
            errorNombre.SetError(txt_nombre, "Este campo es requerido.");
            errorDescripcion.SetError(txt_descripcion, "Este campo es requerido.");
            errorCategoria.SetError(comboCategoria, "Este campo es requerido.");
            errorEstado.SetError(comboEstado, "Este campo es requerido.");
            

            txt_codigo.BackColor = System.Drawing.Color.MistyRose;
            txt_nombre.BackColor = System.Drawing.Color.MistyRose;
            txt_descripcion.BackColor = System.Drawing.Color.MistyRose;
            comboEstado.BackColor = System.Drawing.Color.MistyRose;
            comboCategoria.BackColor = System.Drawing.Color.MistyRose;
        }

       


        private bool CodigoExiste()
        {
            foreach (DataGridViewRow row in dataGrid_listaProducto.Rows)
            {
                if (row.Cells["codigo"].Value != null && row.Cells["codigo"].Value.ToString() == txt_codigo.Text)
                {
                    return true;
                }
            }
            return false;
        }



        //VALIDACIONES DE MODIFICAR
        public bool verificar_campos_Modificar()
        {
            // Limpia errores y colores de todos los campos al inicio
            LimpiarErroresYColores();
            bool respuesta = true; // Bandera para indicar si hay algún campo vacío o algun error

            // Lista de todos los TextBoxes
            TextBox[] textboxes = { txt_codigo, txt_nombre, txt_descripcion };

            // Paso 1: Verificar si todos los campos están vacíos
            if (textboxes.All(tb => string.IsNullOrWhiteSpace(tb.Text)) && comboEstado.SelectedIndex == -1 && comboCategoria.SelectedIndex == -1)
            {
                MarcarTodosLosCampos();
                MessageBox.Show("Todos los campos están vacíos. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool algúnCampoVacio = false;

            // Paso 2: Verificación de cada campo individualmente
            // Se valida cada campo y se activa la bandera si está vacío o no es válido

            // Verificación de codigo 
            // Verificación de codigo 
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                errorCodigo.SetError(txt_nombre, "Ingrese el Codigo.");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (txt_codigo.Text.Length > 4 || !int.TryParse(txt_codigo.Text, out int documento) || documento < 1000 || documento > 9999)
            {
                errorCodigo.SetError(txt_codigo, "El Codigo no es válido o está fuera de rango, Debe contener 4 digitos");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Codigo no es válido o está fuera de rango, Debe contener 4 digitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }
            else if (CodigoExisteModificar())
            {


                errorCodigo.SetError(txt_codigo, "Este Codigo ya fue registrado.");
                txt_codigo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este Codigo de Productp ya fue registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                respuesta = false;

            }

            // Verificación de nombre
            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                errorNombre.SetError(txt_nombre, "Ingrese el Nombre.");
                txt_nombre.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.]+$"))
            {
                errorNombre.SetError(txt_nombre, "El Nombre solo debe contener letras y puntos.");
                txt_nombre.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Nombre solo debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }


            //verificacion de descripcion
            // Verificación de nombre
            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                errorDescripcion.SetError(txt_descripcion, "Ingrese el Descripcion.");
                txt_descripcion.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_descripcion.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.]+$"))
            {
                errorDescripcion.SetError(txt_descripcion, "La Descripcion solo debe contener letras y puntos.");
                txt_descripcion.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Descripcion solo debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }



            //verificacion de combox
            if (comboCategoria.SelectedIndex == -1)
            {
                if (algúnCampoVacio == true) // si algun campo antes de combo estado ya estaba vacio , no mostrar mensaje
                {

                    errorCategoria.SetError(comboCategoria, "Seleccione una Categoria.");
                    comboCategoria.BackColor = System.Drawing.Color.MistyRose;

                    algúnCampoVacio = true;

                }
                else
                {

                    errorCategoria.SetError(comboCategoria, "Seleccione un Categoria.");
                    comboCategoria.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Seleccione un Categoria.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    respuesta = false;

                }
            }




            if (comboEstado.SelectedIndex == -1)
            {
                if (algúnCampoVacio == true) // si algun campo antes de combo estado ya estaba vacio , no mostrar mensaje
                {

                    errorEstado.SetError(comboEstado, "Seleccione un Estado.");
                    comboEstado.BackColor = System.Drawing.Color.MistyRose;

                    algúnCampoVacio = true;

                }
                else
                {

                    errorEstado.SetError(comboEstado, "Seleccione un Estado.");
                    comboEstado.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Seleccione un Estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    respuesta = false;

                }
            }

            // Paso 3: Al finalizar, si algún campo está vacío, se muestra el MessageBox
            if (algúnCampoVacio)
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }

            // Si todas las validaciones pasan, el método devuelve true
            return respuesta;
        }



        private bool CodigoExisteModificar()
        {
            foreach (DataGridViewRow row in dataGrid_listaProducto.Rows)
            {
                if (row.Cells["codigo"].Value != null && row.Cells["codigo"].Value.ToString() == txt_codigo.Text && row.Cells["id"].Value.ToString() != txt_id.Text)
                {
                    return true;
                }
            }
            return false;
        }















    }
}
    


