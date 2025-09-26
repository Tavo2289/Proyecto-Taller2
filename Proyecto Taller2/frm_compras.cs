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
    public partial class frm_compras : Form
    {
        private Usuario usuario;
        public frm_compras(Usuario objUsuario = null)
        {
            usuario = objUsuario;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_compras_Load(object sender, EventArgs e)
        {
            ///desactivamos los text box para que no se puedan editar
            

            txt_idProveedor.Enabled = false;
            txt_razonSocial.Enabled = false;
            txt_documentoProveedor.Enabled = false;
            txt_idProducto.Enabled = false;
            txt_producto.Enabled = false;
            txt_totalPagar.Enabled = false;
            txt_fecha.Enabled = false;
            txt_codProducto.Enabled = false;




            //1 representa true y 0 representa false
            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });// agregar una opcion al combo con valor 1
            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboDocumento.DisplayMember = "Texto";// mostrar el texto en el combo
            comboDocumento.ValueMember = "Valor";// asociar el valor al texto
            comboDocumento.SelectedIndex = 0;// seleccionar la primera opcion del combo
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); // mostrar la fecha actual en el formato dd/MM/yyyy


            txt_idProveedor.Text = "0"; //inicializar el id del proveedor en 0
            txt_idProducto.Text = "0";



        }

        private void btn_busquedaProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_proveedor()) // crear una instancia del modal de busqueda de proveedor
            {
                var resultado = modal.ShowDialog(); // mostrar el modal de busqueda de proveedor
                if (resultado == DialogResult.OK) // si el resultado es OK
                {
                    txt_idProveedor.Text = modal.proveedorSeleccionado.id_proveedor.ToString(); // mostrar el id del proveedor seleccionado en el textbox
                    txt_razonSocial.Text = modal.proveedorSeleccionado.razon_social; // mostrar la razon social del proveedor seleccionado en el textbox
                    txt_documentoProveedor.Text = modal.proveedorSeleccionado.nro_documento; // mostrar el numero de documento del proveedor seleccionado en el textbox
                }
                else
                {

                    txt_documentoProveedor.Select(); // seleccionar el textbox del id del proveedor
                }
            }
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_producto()) // crear una instancia del modal de busqueda de producto
            {
                var resultado = modal.ShowDialog(); // mostrar el modal de busqueda de producto
                if (resultado == DialogResult.OK) // si el resultado es OK
                {
                    txt_idProducto.Text = modal.productoSeleccionado.id_producto.ToString(); // mostrar el id del producto seleccionado en el textbox
                    txt_codProducto.Text = modal.productoSeleccionado.codigo; // mostrar el codigo del producto seleccionado en el textbox
                    txt_producto.Text = modal.productoSeleccionado.nombre_producto; // mostrar el nombre del producto seleccionado en el textbox


                }
                else
                {

                    txt_idProducto.Select(); // seleccionar el textbox del id del producto  
                }
            }
        }

        private void txt_codProducto_KeyDown(object sender, KeyEventArgs e) // evento para detectar cuando se presiona la tecla enter
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
                    txt_precioCompra.Select();

                }
                else
                {
                    txt_codProducto.BackColor = Color.MistyRose; // cambiar el color de fondo del textbox a rosa claro
                    txt_idProducto.Text = "0";
                    txt_codProducto.Text = "";
                    txt_producto.Text = "";
                    txt_precioCompra.Text = "0.00";
                }
            }

        }
        private  void pintarErroresTodo() {

            txt_razonSocial.BackColor = Color.MistyRose;
            txt_documentoProveedor.BackColor = Color.MistyRose;
            txt_producto.BackColor = Color.MistyRose;
            txt_codProducto.BackColor = Color.MistyRose;
            txt_precioCompra.BackColor = Color.MistyRose;
            txt_precioVenta.BackColor = Color.MistyRose;

        }
       private void  limpiarErrores() {
            txt_razonSocial.BackColor = Color.White;
            txt_documentoProveedor.BackColor = Color.White;
            txt_producto.BackColor = Color.White;
            txt_codProducto.BackColor = Color.White;
            txt_precioCompra.BackColor = Color.White;
            txt_precioVenta.BackColor = Color.White;

        }



        private void btn_agregar_Click(object sender, EventArgs e)
        {
            limpiarErrores();
            decimal precioCompra = 0; //variable para almacenar el precio de compra
            decimal precioVenta = 0;
            bool producto_existe = false;

            //validaciones
            if (int.Parse(txt_idProducto.Text) == 0  && int.Parse(txt_idProveedor.Text)== 0)
            {
                MessageBox.Show("Debe seleccionar un Producto y Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pintarErroresTodo();
                return;
            }


            if (int.Parse(txt_idProducto.Text) == 0) {

                MessageBox.Show("Debe seleccionar un Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_producto.BackColor = Color.MistyRose;
                txt_codProducto.BackColor = Color.MistyRose;
                txt_precioCompra.BackColor = Color.MistyRose;
                txt_precioVenta.BackColor = Color.MistyRose;
                return;


            }


            if (int.Parse(txt_idProveedor.Text) == 0) {

                MessageBox.Show("Debe seleccionar un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_razonSocial.BackColor = Color.MistyRose;
                txt_documentoProveedor.BackColor = Color.MistyRose;
                return;

            }

            if (txt_precioCompra.Text == "" && txt_precioVenta.Text == "") {
                MessageBox.Show("Debe Ingresar el Precio de Compra y Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioCompra.BackColor = Color.MistyRose;
                txt_precioVenta.BackColor = Color.MistyRose;

                txt_precioCompra.Select();
                return;


            }

            if (txt_precioCompra.Text == "" )
            {
                MessageBox.Show("Debe Ingresar el Precio de Compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioCompra.BackColor = Color.MistyRose;

                txt_precioCompra.Select();
                return;


            }



            if (txt_precioVenta.Text == "")
            {
                MessageBox.Show("Debe Ingresar el Precio de Venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioVenta.BackColor = Color.MistyRose;

                txt_precioVenta.Select();
                return;


            }


            if (decimal.TryParse(txt_precioCompra.Text, out precioCompra) == false || precioCompra <= 0)
            {
                MessageBox.Show("El precio de compra debe ser un valor numerico mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioCompra.BackColor = Color.MistyRose;
                txt_precioCompra.Select();
                return;
            }

            if (decimal.TryParse(txt_precioVenta.Text, out precioVenta) == false || precioVenta <= 0)
            {
                MessageBox.Show("El precio de venta debe ser un valor numerico mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioVenta.BackColor = Color.MistyRose;

                txt_precioVenta.Select();
                return;
            }

            foreach (DataGridViewRow fila in dataGrid_detalleCompra.Rows) // recorrer las filas del datagridview
            {
                if (fila.Cells["id"].Value.ToString() == txt_idProducto.Text) // si el id del producto en la fila es igual al id del producto en el textbox
                {
                    producto_existe = true; // el producto ya existe en el detalle de la compra
                    break;
                }
            }


            if (!producto_existe) // si el producto no existe en el detalle de la compra
            {
                dataGrid_detalleCompra.Rows.Add(new object[] {
                txt_idProducto.Text,
                txt_producto.Text,
                precioCompra.ToString("0.00"),
                precioVenta.ToString("0.00"),
                numeric_cantidad.Value.ToString(), // accedor al valor del numericupdown
                (precioCompra * numeric_cantidad.Value).ToString("0.00")
                });
                calcularTotal(); // calcular el total de la compra
                limpiarProducto(); // limpiar los campos del producto
                txt_codProducto.Select(); // seleccionar el textbox del codigo del producto

            }
        }


        private void limpiarProducto()
        {
            limpiarErrores();
            txt_idProducto.Text = "0";
            txt_codProducto.Text = "";
            txt_producto.Text = "";
            txt_precioCompra.Text = "0.00";
            txt_precioVenta.Text = "0.00";
            numeric_cantidad.Value = 1;
            txt_codProducto.BackColor = Color.White;
            txt_codProducto.Select();
        }


        private void calcularTotal()
        {
            decimal total = 0; // variable para almacenar el total de la compra
            if (dataGrid_detalleCompra.Rows.Count > 0) // si hay filas en el datagridview
            {
                foreach (DataGridViewRow fila in dataGrid_detalleCompra.Rows) // recorrer las filas del datagridview
                {
                    total += Convert.ToDecimal(fila.Cells["subtotal"].Value.ToString()); // sumar el subtotal de cada fila al total
                }
            }
            txt_totalPagar.Text = total.ToString("0.00"); // mostrar el total en el textbox con 2 decimales
        }


        private void dataGrid_detalleCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) // si es la fila de los encabezados
                return;
            if (e.ColumnIndex == 6)// si es la columna del boton seleccionar
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

        private void dataGrid_detalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_detalleCompra.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {

                int indiceFila = e.RowIndex; // obtener el indice de la fila seleccionada

                if (indiceFila >= 0)
                {  // si el indice es mayor o igual a 0
                   dataGrid_detalleCompra.Rows.RemoveAt(indiceFila); // eliminar la fila del datagridview
                   calcularTotal(); // recalcular el total de la compra
                }
            }
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // si el caracter es un digito
            {
                e.Handled = false; // no manejar el evento
            }
            else
            {
                if (txt_precioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") // si el textbox esta vacio y se presiona el punto
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

        private void txt_precioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) // si el caracter es un digito
            {
                e.Handled = false; // no manejar el evento
            }
            else
            {
                if (txt_precioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".") // si el textbox esta vacio y se presiona el punto
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

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            // Valida si el ID del proveedor es 0.
            // Si es 0, muestra un mensaje de advertencia y detiene la ejecución del código.
           

            // Valida si la cantidad de filas en el DataGridView (dgvdata) es menor a 1.
            // Si no hay productos en la tabla, muestra un mensaje de advertencia y detiene la ejecución.
            if (dataGrid_detalleCompra.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Crea un nuevo objeto DataTable llamado 'detalle_compra'.
            DataTable detalle_compra = new DataTable();

            // Agrega columnas a la tabla 'detalle_compra' con los nombres y tipos de datos especificados.
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            // Itera a través de cada fila en el DataGridView 'dgvdata'.
            foreach (DataGridViewRow row in dataGrid_detalleCompra.Rows)
            {
                // Agrega una nueva fila al 'detalle_compra' DataTable.
                detalle_compra.Rows.Add(
                    new object[] {
            // Convierte el valor de la celda "IdProducto" a un entero y lo agrega a la fila.
            Convert.ToInt32(row.Cells["id"].Value.ToString()),
            // Agrega los valores de las siguientes celdas a la fila sin conversión explícita.
            row.Cells["precioCompra"].Value.ToString(),
            row.Cells["precioVenta"].Value.ToString(),
            row.Cells["cantidad"].Value.ToString(),
            row.Cells["subtotal"].Value.ToString()
                    }
                );
            }

            int idCorrelativo = new CN_compras().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);


            Compra oCompra = new Compra()
            {
                id_usuario = new Usuario() { id_usuario = usuario.id_usuario },
                id_proveedor = new Proveedor() { id_proveedor = Convert.ToInt32(txt_idProveedor.Text) },
                tipo_documento = ((OpcionCombo)comboDocumento.SelectedItem).Texto,
                nro_documento = numeroDocumento,
                monto_total = Convert.ToDecimal(txt_totalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_compras().Registrar(oCompra, detalle_compra, out mensaje);


            // Comprueba si la variable 'respuesta' es verdadera.
            // 'respuesta' probablemente indica si el registro de la compra fue exitoso.
            if (respuesta)
            {
                // Muestra un cuadro de diálogo con un mensaje de éxito.
                // El mensaje incluye el número de documento de la compra y pregunta al usuario si desea copiarlo al portapapeles.
                // Los botones son "Sí" y "No" con un ícono de información.
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // Si el usuario selecciona "Sí", copia el número de documento al portapapeles del sistema.
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }



                var generaComprobante = MessageBox.Show("Compra Registrada Exitosamente, Desea Generar el comprobante?", "Compra Registrada", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Muestra el mensaje de éxito.

                // Limpia los campos de texto del cliente y el DataGridView.
                limpiarTodo();
                limpiarErrores();

                if (generaComprobante == DialogResult.Yes)
                {
                    frm_detalleCompra detalleCompra = new frm_detalleCompra(numeroDocumento);

                    detalleCompra.Show(); // Muestra el formulario de detalles de la venta.
                }





               

                // Llama al método 'calcularTotal()' para recalcular el total, que probablemente será 0 después de limpiar el DataGridView.
                calcularTotal();
            }
            // Si la variable 'respuesta' es falsa (la compra no se registró correctamente).
            else
            {
                // Muestra un cuadro de diálogo con el mensaje de error que se obtuvo al intentar registrar la compra.
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void limpiarTodo() {
            // Limpia los campos de texto del proveedor y el DataGridView.
            txt_idProveedor.Text = "0";
            txt_documentoProveedor.Text = "";
            txt_razonSocial.Text = "";
            dataGrid_detalleCompra.Rows.Clear();
            txt_codProducto.Text = "";
            txt_precioCompra.Text = "";
            txt_precioVenta.Text = "";
            txt_producto.Text = "";
            numeric_cantidad.Value = 1;

        }


       




    }
}
