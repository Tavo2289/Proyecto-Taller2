using CapaEntidad;
using CapaNegocio;
using Proyecto_Taller2.Modales;
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
    public partial class frm_venta : Form
    {
        private Usuario _usuario;
        public frm_venta(Usuario oUsuario = null)
        {
            _usuario = oUsuario;
            InitializeComponent();
        }

        private void frm_venta_Load(object sender, EventArgs e)
        {
            //desactivar los textbox que no se deben editar
            txt_precio.Enabled = false;
            txt_stock.Enabled = false;
            txt_cambio.Enabled = false;
            txt_totalPagar.Enabled = false;


            //texbox de cliente
            txt_documentoCliente.Enabled = false;
            txt_nombreCompleto.Enabled = false;

            //texbox de producto
            txt_codProducto.Enabled = false;
            txt_producto.Enabled = false;
            txt_idProducto.Enabled = false;

            //texbox fecha
            txt_fecha.Enabled = false;
            txt_fecha.BackColor = Color.White;



            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });// agregar una opcion al combo con valor 1
            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboDocumento.DisplayMember = "Texto";// mostrar el texto en el combo
            comboDocumento.ValueMember = "Valor";// asociar el valor al texto
            comboDocumento.SelectedIndex = 0;// seleccionar la primera opcion del combo
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // mostrar la fecha actual en el formato dd/MM/yyyy


            txt_idCliente.Text = "0"; //inicializar el id del Clientes en 0
            txt_cambio.Text = "";
            txt_pagaCon.Text = "";
            txt_idProducto.Text = "0";

        }

        private void btn_busquedaCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_clientes()) // crear una instancia del modal de busqueda de Clientes
            {
                var resultado = modal.ShowDialog(); // mostrar el modal de busqueda de Clientes
                if (resultado == DialogResult.OK) // si el resultado es OK
                {
                    
                    string nombreCompleto = modal._cliente.nombre + " " + modal._cliente.apellido;
                    txt_nombreCompleto.Text = nombreCompleto; // mostrar la razon social del Clientes seleccionado en el textbox
                    txt_documentoCliente.Text = modal._cliente.nro_documento; // mostrar el numero de documento del Clientes seleccionado en el textbox
                    txt_codProducto.Select();
                }
                else
                {

                    txt_documentoCliente.Select(); // seleccionar el textbox del id del Clientes
                }
            }
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_productoVentas()) // crear una instancia del modal de busqueda de producto
            {
                var resultado = modal.ShowDialog(); // mostrar el modal de busqueda de producto
                if (resultado == DialogResult.OK) // si el resultado es OK
                {
                    txt_idProducto.Text = modal.productoSeleccionado.id_producto.ToString(); // mostrar el id del producto seleccionado en el textbox
                    txt_codProducto.Text = modal.productoSeleccionado.codigo; // mostrar el codigo del producto seleccionado en el textbox
                    txt_producto.Text = modal.productoSeleccionado.nombre_producto; // mostrar el nombre del producto seleccionado en el textbox
                    txt_precio.Text = modal.productoSeleccionado.precio_venta.ToString("0.00");
                    txt_stock.Text = modal.productoSeleccionado.stock.ToString();

                    numeric_cantidad.Select();
                }
                else
                {

                    txt_codProducto.Select(); // seleccionar el textbox del id del producto  
                }
            }
        }

        private void txt_codProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto producto = new CN_producto().Listar().Where(                               // p representa cada producto en la lista de productos
                    p => p.codigo == txt_codProducto.Text && p.estado == true).FirstOrDefault(); // buscar el producto por su codigo y que este activo
                if (producto != null)
                {

                    txt_codProducto.BackColor = Color.Honeydew; // cambiar el color de fondo del textbox a verde claro
                    txt_idProducto.Text = producto.id_producto.ToString();
                    txt_codProducto.Text = producto.codigo;
                    txt_producto.Text = producto.nombre_producto;
                    txt_stock.Text = producto.stock.ToString();
                    txt_precio.Select();

                }
                else
                {
                    txt_codProducto.BackColor = Color.MistyRose; // cambiar el color de fondo del textbox a rosa claro
                    txt_idProducto.Text = "0";
                    txt_codProducto.Text = "";
                    txt_producto.Text = "";
                    txt_stock.Text = "";
                    txt_precio.Text = "0.00";
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            limpiarColores(); // se limpia los colores de los textbox}
            decimal precio = 0;

            if (txt_precio.Text != "") {

                 precio = Convert.ToDecimal(txt_precio.Text); // convertir el precio a decimal


            }
            bool producto_existe = false;
            //validaciones
            if (int.Parse(txt_idProducto.Text) == 0 && txt_documentoCliente.Text == "")
            {



                    txt_documentoCliente.BackColor = Color.MistyRose ;
                    txt_nombreCompleto.BackColor = Color.MistyRose;
                    txt_codProducto.BackColor = Color.MistyRose;
                    txt_producto.BackColor = Color.MistyRose;
                    txt_precio.BackColor = Color.MistyRose;
                     txt_stock.BackColor= Color.MistyRose;




                MessageBox.Show("Debe seleccionar un Cliente y Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                return;
            }

            if (int.Parse(txt_idProducto.Text) == 0 )
            {



              
                txt_codProducto.BackColor = Color.MistyRose;
                txt_producto.BackColor = Color.MistyRose;
                txt_precio.BackColor = Color.MistyRose;
                txt_stock.BackColor = Color.MistyRose;




                MessageBox.Show("Debe seleccionar un Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
              
            }

            if (txt_documentoCliente.Text == "")
            {



                txt_documentoCliente.BackColor = Color.MistyRose;
                txt_nombreCompleto.BackColor = Color.MistyRose;
               



                MessageBox.Show("Debe seleccionar un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }

















            if (Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(numeric_cantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numeric_cantidad.BackColor = Color.MistyRose; 
                numeric_cantidad.Select();
                return;
            }

          
            foreach (DataGridViewRow fila in dataGrid_detalleVenta.Rows) // recorrer las filas del datagridview
            {
                if (fila.Cells["id"].Value.ToString() == txt_idProducto.Text) // si el id del producto en la fila es igual al id del producto en el textbox
                {
                    producto_existe = true; // el producto ya existe en el detalle de la compra
                    MessageBox.Show("Solo se permite agregar un producto del mismo codigo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;
                }
            }


            if (!producto_existe) // si el producto no existe en el detalle de la compra
            {

                //bool respuesta = new CN_venta().RestarStock(
                //    Convert.ToInt32(txt_idProducto.Text),
                //    Convert.ToInt32(numeric_cantidad.Value.ToString())
                //);


                dataGrid_detalleVenta.Rows.Add(new object[] {
                    txt_idProducto.Text,
                    txt_producto.Text,
                    precio.ToString("0.00"),
                    numeric_cantidad.Value.ToString(), // accedor al valor del numericupdown
                    (precio * numeric_cantidad.Value).ToString("0.00")
                            });

              
               
                calcularTotal(); // calcular el total de la compra
                limpiarProducto(); // limpiar los campos del producto
                txt_codProducto.Select(); // seleccionar el textbox del codigo del producto

            }
        }

        private void calcularTotal()
        {
            decimal total = 0; // variable para almacenar el total de la compra
            if (dataGrid_detalleVenta.Rows.Count > 0) // si hay filas en el datagridview
            {
                foreach (DataGridViewRow fila in dataGrid_detalleVenta.Rows) // recorrer las filas del datagridview
                {
                    total += Convert.ToDecimal(fila.Cells["subtotal"].Value.ToString()); // sumar el subtotal de cada fila al total
                }
            }
            txt_totalPagar.Text = total.ToString("0.00"); // mostrar el total en el textbox con 2 decimales
        }

        private void limpiarColores() {
            txt_documentoCliente.BackColor = Color.White;
            txt_nombreCompleto.BackColor = Color.White;
            txt_codProducto.BackColor = Color.White;
            txt_producto.BackColor = Color.White;
            txt_precio.BackColor = Color.White;
            txt_stock.BackColor = Color.White;
            txt_pagaCon.BackColor = Color.White;
            txt_cambio.BackColor = Color.White;
            numeric_cantidad.BackColor = Color.White;


        }
        private void limpiarProducto()
        {






            limpiarColores();

            txt_idProducto.Text = "0";
            txt_codProducto.Text = "";
            txt_producto.Text = "";
            txt_precio.Text = "0.00";
            numeric_cantidad.Value = 1;
            txt_stock.Text = "";
            txt_codProducto.BackColor = Color.White;
            txt_codProducto.Select();
        }

        private void dataGrid_detalleVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // si es la fila de los encabezados
                return;
            if (e.ColumnIndex == 5)// si es la columna del boton seleccionar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); // pintar la celda
                var w = Properties.Resources.delete32.Width;// obtener el ancho de la imagen
                var h = Properties.Resources.delete32.Height;// obtener el alto de la imagen
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;// centrar la imagen en la celda
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;// centrar la imagen en la celda

                e.Graphics.DrawImage(Properties.Resources.delete32, new Rectangle(x, y, w, h));// dibujar la imagen
                e.Handled = true;// indicar que se ha manejado el evento
            }
        }

        private void dataGrid_detalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_detalleVenta.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0




                    dataGrid_detalleVenta.Rows.RemoveAt(indiceFila);
                    calcularTotal();
                }


                    
                }
            }
        

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // si el caracter es un digito
            {
                e.Handled = false; // no manejar el evento
            }
            else
            {
                if (txt_precio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") // si el textbox esta vacio y se presiona el punto
                {
                    e.Handled = true; // manejar el evento
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") // si el caracter es un caracter de control o es un punto
                    {
                        e.Handled = false; // no manejar el evento
                    }
                    else
                    {
                        e.Handled = true; // manejar el evento
                    }


                }

            }
        }

        private void txt_pagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // si el caracter es un digito
            {
                e.Handled = false; // no manejar el evento
            }
            else
            {
                if (txt_pagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") // si el textbox esta vacio y se presiona el punto
                {
                    e.Handled = true; // manejar el evento
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".") // si el caracter es un caracter de control o es un punto
                    {
                        e.Handled = false; // no manejar el evento
                    }
                    else
                    {
                        e.Handled = true; // manejar el evento
                    }


                }
            }
        }


        private void calcularCambio() {
            if (txt_totalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txt_totalPagar.Text);

            if (txt_pagaCon.Text.Trim() == "")
            {
                txt_pagaCon.Text = "0";
            }

            if (decimal.TryParse(txt_pagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txt_cambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txt_cambio.Text = cambio.ToString("0.00");
                }
            }

        }

        private void txt_pagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                calcularCambio();
            }
        }


        private void validadCampos() {

            limpiarColores(); // se limpia los colores de los textbox

            
            if (int.Parse(txt_idProducto.Text) == 0 && txt_documentoCliente.Text == "")
            {
                txt_documentoCliente.BackColor = Color.MistyRose;
                txt_nombreCompleto.BackColor = Color.MistyRose;
                txt_codProducto.BackColor = Color.MistyRose;
                txt_producto.BackColor = Color.MistyRose;
                txt_precio.BackColor = Color.MistyRose;
                txt_stock.BackColor = Color.MistyRose;
                MessageBox.Show("Debe seleccionar un Cliente y Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (int.Parse(txt_idProducto.Text) == 0)
            {

                txt_codProducto.BackColor = Color.MistyRose;
                txt_producto.BackColor = Color.MistyRose;
                txt_precio.BackColor = Color.MistyRose;
                txt_stock.BackColor = Color.MistyRose;
                MessageBox.Show("Debe seleccionar un Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }

            if (txt_documentoCliente.Text == "")
            {

                txt_documentoCliente.BackColor = Color.MistyRose;
                txt_nombreCompleto.BackColor = Color.MistyRose;


                MessageBox.Show("Debe seleccionar un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }


            if (Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(numeric_cantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                numeric_cantidad.BackColor = Color.MistyRose;
                numeric_cantidad.Select();
                return;
            }

          

        }

        private void btn_registrar_Click(object sender, EventArgs e)

        {

            //validadCampos(); // se validan los campos

            limpiarColores();


            

            if (dataGrid_detalleVenta.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (txt_pagaCon.Text == "")
            {
                txt_pagaCon.BackColor = Color.MistyRose;
                txt_pagaCon.Select();

                MessageBox.Show("Debe ingresar con cuanto paga el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            if (txt_cambio.Text == "")
            {
                txt_cambio.BackColor = Color.MistyRose;
                txt_cambio.Select();

                MessageBox.Show("Debe ingresar el cambio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in dataGrid_detalleVenta.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
               row.Cells["id"].Value.ToString(),
               row.Cells["precio"].Value.ToString(),
               row.Cells["cantidad"].Value.ToString(),
               row.Cells["subtotal"].Value.ToString()
              });
            }

            int idCorrelativo = new CN_venta().ObtenerCorrelativo(); // Obtiene un número correlativo para la venta desde la capa de negocio.
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo); // Formatea el número correlativo a 5 dígitos, rellenando con ceros a la izquierda.
            calcularCambio(); // Llama a una función para calcular el cambio de la venta.

            Venta oVenta = new Venta() // Crea una nueva instancia de la clase Venta.
            { 

                // Asigna el usuario actual a la venta.

                oUsuario = new Usuario() { id_usuario = _usuario.id_usuario },
                // Asigna el tipo de documento seleccionado en el ComboBox.
                TipoDocumento = ((OpcionCombo)comboDocumento.SelectedItem).Texto,  
                // Asigna el número de documento formateado.
                NumeroDocumento = numeroDocumento,
                // Asigna el documento del cliente desde el campo de texto.
                DocumentoCliente = txt_documentoCliente.Text,
                // Asigna el nombre del cliente desde el campo de texto.
                NombreCliente = txt_nombreCompleto.Text,
                // Convierte y asigna el monto pagado por el cliente.
                MontoPago = Convert.ToDecimal(txt_pagaCon.Text),
                // Convierte y asigna el monto del cambio.
                MontoCambio = Convert.ToDecimal(txt_cambio.Text),
                // Convierte y asigna el monto total de la venta.
                MontoTotal = Convert.ToDecimal(txt_totalPagar.Text),

            };

            string mensaje = string.Empty; // Variable para almacenar el mensaje de resultado.
                                           // Llama al método Registrar de la capa de negocio para guardar la venta y sus detalles.
            bool respuesta = new CN_venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta) // Si la operación de registro fue exitosa...
            {
                foreach (DataRow row in detalle_venta.Rows)
                {
                    new CN_venta().RestarStock(
                        Convert.ToInt32(row["IdProducto"]),
                        Convert.ToInt32(row["Cantidad"])
                    );
                }



                // Muestra un cuadro de diálogo con el número de venta generado y pregunta si el usuario quiere copiarlo.
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes) // Si el usuario elige "Sí"...
                {
                    Clipboard.SetText(numeroDocumento); // Copia el número de documento al portapapeles.
                }


                MessageBox.Show("Venta Registrada Exitosamente", "Venta Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra el mensaje de éxito.

                // Limpia los campos de texto del cliente y el DataGridView.
                limpiarTodo();
                limpiarColores();
            }
            else // Si la operación de registro falló...
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // Muestra el mensaje de error.
            }







        }

        private void limpiarTodo()
        {
            txt_documento.Text ="";
            txt_nombreCompleto.Text = "";
            txt_idCliente.Text = "0";
            txt_idProducto.Text = "0";
            txt_codProducto.Text = "";
            txt_producto.Text = "";
            txt_precio.Text = "0.00";
            txt_stock.Text = "";
            numeric_cantidad.Value = 1;
            txt_pagaCon.Text = "";
            txt_totalPagar.Text = "0.00";
            txt_cambio.Text = "0.00";
            dataGrid_detalleVenta.Rows.Clear();
        }
    

    }
}
