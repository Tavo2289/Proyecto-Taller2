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
            comboEstado.SelectedIndex = -1;// seleccionar la primera opcion del combo

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
            comboBox_busqueda.SelectedIndex = -1;// seleccionar la primera opcion del combo

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

                LimpiarErroresYColores(); // limpiar errores y colores de todos los campos
                btn_modificar.Visible = true; // mostrar el boton modificar
                // desactiva el campo documento para que no se pueda modificar

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
            /*activa boton de guardar y oculta el boton de modificar*/
            btn_modificar.Visible = false;
            btn_guardar.Visible = true;
            // activa el campo documento 




            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_documento.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_razonSocial.Text = "";


            comboEstado.SelectedIndex = -1;// seleccionar la primera opcion del combo

            txt_razonSocial.Select(); // colocar el foco en el textbox documento
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
            if (!verificar_campos_Registrar()) { return; } // si la verificación falla, salimos del método
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

                    MessageBox.Show("El Proveedor "+txt_razonSocial.Text+" Registrado correctamente","Proveedor Registrado Exitosamente",MessageBoxButtons.OK , MessageBoxIcon.Information);
                    limpiar();
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
            LimpiarErroresYColores();
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

        /*validaciones de campos*/

        public bool verificar_campos_Registrar()
        {
            // Limpia errores y colores de todos los campos al inicio
            LimpiarErroresYColores();
            bool respuesta = true; // Bandera para indicar si hay algún campo vacío o algun error

            // Lista de todos los TextBoxes
            TextBox[] textboxes = { txt_razonSocial, txt_documento, txt_correo, txt_telefono };

            // Paso 1: Verificar si todos los campos están vacíos
            if (textboxes.All(tb => string.IsNullOrWhiteSpace(tb.Text)) && comboEstado.SelectedIndex == -1)
            {
                MarcarTodosLosCampos();
                MessageBox.Show("Todos los campos están vacíos. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool algúnCampoVacio = false;

            // Paso 2: Verificación de cada campo individualmente
            // Se valida cada campo y se activa la bandera si está vacío o no es válido

          

            // Verificación de razon social
            if (string.IsNullOrWhiteSpace(txt_razonSocial.Text))
            {
                errorRazonSocial.SetError(txt_razonSocial, "Ingrese el Razon Social.");
                txt_razonSocial.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_razonSocial.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.]+$"))
            {
                errorRazonSocial.SetError(txt_razonSocial, "El Razon Social solo debe contener letras y puntos.");
                txt_razonSocial.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Razon Social solo debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }

            // Verificación de DNI
            if (string.IsNullOrWhiteSpace(txt_documento.Text))
            {
                errorDocumento.SetError(txt_documento, "Ingrese el Documento.");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (txt_documento.Text.Length > 8 || !int.TryParse(txt_documento.Text, out int documento) || documento <= 15000000 || documento > 47000000)
            {
                errorDocumento.SetError(txt_documento, "El DNI no es válido o está fuera de rango, rango permitido desde 15000000, hasta 47000000");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El DNI no es válido o está fuera de rango.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }
            else if (DocumentoExiste())
            {


                errorDocumento.SetError(txt_documento, "Este Documento ya fue registrado por otro Usuario");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este Documento ya fue registrado por otro Usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                respuesta = false;

            }

            // Verificación de telefono
            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                errorTelefono.SetError(txt_telefono, "Ingrese el teléfono.");
                txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_telefono.Text, @"^\d{10}$"))
            {
                // Validar que sean exactamente 10 dígitos
                errorTelefono.SetError(txt_telefono, "El teléfono debe tener exactamente 10 dígitos numéricos.");
                txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El teléfono ingresado no es válido. Debe contener exactamente 10 dígitos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else
            {
                // Lista de algunos códigos de área válidos en Argentina (se puede extender con todos los de ENACOM)
                string[] codigosValidos = {
                                            "11","221","223","261","264","280","299",
                                            "351","362","370","379","381","383","385","387","388"
                                        };

                bool codigoValido = codigosValidos.Any(c => txt_telefono.Text.StartsWith(c));

                if (!codigoValido)
                {
                    errorTelefono.SetError(txt_telefono, "El código de área no es válido.");
                    txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("El código de área ingresado no corresponde a un número válido en Argentina.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    respuesta = false;
                }
                else if (TelefonoExiste())
                {
                    errorTelefono.SetError(txt_telefono, "Este teléfono ya fue registrado por otro usuario.");
                    txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Este teléfono ya fue registrado por otro usuario.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    respuesta = false;
                }
            }






            // Verificación de Email y duplicados
            if (string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                errorCorreo.SetError(txt_correo, "Ingrese el Gmail.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorCorreo.SetError(txt_correo, "El formato del correo es incorrecto.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El formato del correo es incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else if (CorreoExiste()) // Método para verificar duplicado, si es necesario
            {
                errorCorreo.SetError(txt_correo, "Este correo ya existe en la base de datos.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este correo ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
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
            errorDocumento.Clear();
            errorCorreo.Clear();
            errorTelefono.Clear();
            errorEstado.Clear();

            txt_documento.BackColor = System.Drawing.Color.White;
            txt_correo.BackColor = System.Drawing.Color.White;
            txt_telefono.BackColor = System.Drawing.Color.White;
            comboEstado.BackColor = System.Drawing.Color.White;
        }

        private void MarcarTodosLosCampos()
        {
            // Lógica para marcar todos los campos vacíos con color y error
            errorDocumento.SetError(txt_documento, "Este campo es requerido.");
            errorCorreo.SetError(txt_correo, "Este campo es requerido.");
            errorTelefono.SetError(txt_telefono, "Este campo es requerido.");

            errorEstado.SetError(comboEstado, "Este campo es requerido.");

            txt_documento.BackColor = System.Drawing.Color.MistyRose;
            txt_correo.BackColor = System.Drawing.Color.MistyRose;
            txt_telefono.BackColor = System.Drawing.Color.MistyRose;
            comboEstado.BackColor = System.Drawing.Color.MistyRose;
        }

        private bool CorreoExiste()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                if (row.Cells["correo"].Value != null && row.Cells["correo"].Value.ToString() == txt_correo.Text)
                {
                    return true;
                }
            }
            return false;
        }


        private bool DocumentoExiste()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                if (row.Cells["nro_documento"].Value != null && row.Cells["nro_documento"].Value.ToString() == txt_documento.Text)
                {
                    return true;
                }
            }
            return false;
        }


        private bool TelefonoExiste()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                if (row.Cells["telefono"].Value != null && row.Cells["telefono"].Value.ToString() == txt_telefono.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            if (!verificar_campos_Modificar()) { return; } // si la verificación falla, salimos del método
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
                      MessageBox.Show("El Proveedor " + txt_razonSocial.Text + " Modificado correctamente", "Proveedor Modificado Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();// limpiar los campos del formulario
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); // mostrar el mensaje de error
                }
            }


        public bool verificar_campos_Modificar()
        {
            // Limpia errores y colores de todos los campos al inicio
            LimpiarErroresYColores();
            bool respuesta = true; // Bandera para indicar si hay algún campo vacío o algun error

            // Lista de todos los TextBoxes
            TextBox[] textboxes = { txt_razonSocial, txt_documento, txt_correo, txt_telefono };

            // Paso 1: Verificar si todos los campos están vacíos
            if (textboxes.All(tb => string.IsNullOrWhiteSpace(tb.Text)) && comboEstado.SelectedIndex == -1)
            {
                MarcarTodosLosCampos();
                MessageBox.Show("Todos los campos están vacíos. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool algúnCampoVacio = false;

            // Paso 2: Verificación de cada campo individualmente
            // Se valida cada campo y se activa la bandera si está vacío o no es válido



            // Verificación de razon social
            if (string.IsNullOrWhiteSpace(txt_razonSocial.Text))
            {
                errorRazonSocial.SetError(txt_razonSocial, "Ingrese el Razon Social.");
                txt_razonSocial.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_razonSocial.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s\.]+$"))
            {
                errorRazonSocial.SetError(txt_razonSocial, "El Razon Social solo debe contener letras y puntos.");
                txt_razonSocial.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El Razon Social solo debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }

            // Verificación de DNI
            if (string.IsNullOrWhiteSpace(txt_documento.Text))
            {
                errorDocumento.SetError(txt_documento, "Ingrese el Documento.");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (txt_documento.Text.Length > 8 || !int.TryParse(txt_documento.Text, out int documento) || documento < 15000000 || documento > 47000000)
            {
                errorDocumento.SetError(txt_documento, "El DNI no es válido o está fuera de rango.");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El DNI no es válido o está fuera de rango.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                respuesta = false;
            }
            else if (DocumentoExisteModificar())
            {


                errorDocumento.SetError(txt_documento, "Este Documento ya fue registrado por otro Usuario");
                txt_documento.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este Documento ya fue registrado por otro Usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                respuesta = false;

            }
            // Verificación de telefono
            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                errorTelefono.SetError(txt_telefono, "Ingrese el teléfono.");
                txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txt_telefono.Text, @"^\d{10}$"))
            {
                // Validar que sean exactamente 10 dígitos
                errorTelefono.SetError(txt_telefono, "El teléfono debe tener exactamente 10 dígitos numéricos.");
                txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El teléfono ingresado no es válido. Debe contener exactamente 10 dígitos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else
            {
                // Lista de algunos códigos de área válidos en Argentina (se puede extender con todos los de ENACOM)
                string[] codigosValidos = {
                                            "11","221","223","261","264","280","299",
                                            "351","362","370","379","381","383","385","387","388"
                                        };

                bool codigoValido = codigosValidos.Any(c => txt_telefono.Text.StartsWith(c));

                if (!codigoValido)
                {
                    errorTelefono.SetError(txt_telefono, "El código de área no es válido.");
                    txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("El código de área ingresado no corresponde a un número válido en Argentina.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    respuesta = false;
                }
                else if (TelefonoExisteModificar())
                {
                    errorTelefono.SetError(txt_telefono, "Este teléfono ya fue registrado por otro usuario.");
                    txt_telefono.BackColor = System.Drawing.Color.MistyRose;
                    MessageBox.Show("Este teléfono ya fue registrado por otro usuario.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    respuesta = false;
                }
            }






            // Verificación de Email y duplicados
            if (string.IsNullOrWhiteSpace(txt_correo.Text))
            {
                errorCorreo.SetError(txt_correo, "Ingrese el Gmail.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                algúnCampoVacio = true;
            }
            else if (!Regex.IsMatch(txt_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorCorreo.SetError(txt_correo, "El formato del correo es incorrecto.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("El formato del correo es incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
            }
            else if (CorreoExisteModificar()) // Método para verificar duplicado, si es necesario
            {
                errorCorreo.SetError(txt_correo, "Este correo ya existe en la base de datos.");
                txt_correo.BackColor = System.Drawing.Color.MistyRose;
                MessageBox.Show("Este correo ya existe en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                respuesta = false;
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




        private bool TelefonoExisteModificar()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {

                //si el telefono es igual al de la fila y el id es diferente al del textbox id (para que no se compare con el mismo registro)
                if (row.Cells["telefono"].Value != null && row.Cells["telefono"].Value.ToString() == txt_telefono.Text && (row.Cells["id"].Value.ToString() != txt_id.Text))
                {
                    return true;
                }
            }
            return false;
        }



        private bool CorreoExisteModificar()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                //si el gmail existe y el id es diferente al del usuario que se esta modificando
                if (row.Cells["correo"].Value != null && row.Cells["correo"].Value.ToString() == txt_correo.Text && row.Cells["id"].Value.ToString() != txt_id.Text)
                {
                    return true;
                }
            }
            return false;
        }



        private bool DocumentoExisteModificar()
        {
            foreach (DataGridViewRow row in dataGrid_listaProveedor.Rows)
            {
                //si el gmail existe y el id es diferente al del usuario que se esta modificando
                if (row.Cells["nro_documento"].Value != null && row.Cells["nro_documento"].Value.ToString() == txt_documento.Text && row.Cells["id"].Value.ToString() != txt_id.Text)
                {
                    return true;
                }
            }
            return false;
        }




    }
}
