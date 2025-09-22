using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Proyecto_Taller2.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller2
{
    public partial class frm_detalleVenta : Form
    {
        public frm_detalleVenta()
        {
            InitializeComponent();
        }

        private void frm_detalleVenta_Load(object sender, EventArgs e)

        {
            //desactivamos los textbox para que no se puedan editar
            txt_idVenta.Enabled = false;

            txt_documentoBuscado.Enabled = false;
            txt_fecha.Enabled = false;
            txt_tipoDocumento.Enabled = false;
            txt_usuario.Enabled = false;
            txt_documentoCliente.Enabled = false;
            txt_nombreCliente.Enabled = false;
            txt_montoTotal.Enabled = false;
            txt_montoPago.Enabled = false;
            txt_montoCambio.Enabled = false;



            txt_nroDocumento.Select();

        }
        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            txt_nroDocumento.BackColor = Color.White;

            if (txt_nroDocumento.Text == "") { 
            
            
                MessageBox.Show("Debe ingresar un numero de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nroDocumento.BackColor = Color.MistyRose;
                txt_nroDocumento.Focus();

                return;


            }



            Venta oVenta = new CN_venta().ObtenerVenta(txt_nroDocumento.Text);

            if (oVenta.IdVenta != 0)
            {
                txt_documentoBuscado.Text = oVenta.NumeroDocumento;
                txt_fecha.Text = oVenta.FechaRegistro;
                txt_tipoDocumento.Text = oVenta.TipoDocumento;
                txt_usuario.Text = oVenta.oUsuario.nombre + " " + oVenta.oUsuario.apellido;
                txt_documentoCliente.Text = oVenta.DocumentoCliente;
                txt_nombreCliente.Text = oVenta.NombreCliente;

                dataGrid_detalleVenta.Rows.Clear();
                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dataGrid_detalleVenta.Rows.Add(new object[] { dv.id_producto.nombre_producto, dv.precioVenta, dv.cantidad, dv.subtotal });
                }

                txt_montoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                txt_montoPago.Text = oVenta.MontoPago.ToString("0.00");
                txt_montoCambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
            else
            {

                MessageBox.Show("No hay un producto con ese numero de documento", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_nroDocumento.BackColor = Color.MistyRose;
                txt_nroDocumento.Focus();
                txt_documentoBuscado.Text = "";
            }
            txt_nroDocumento.BackColor = Color.White;

        }



        //private void btn_buscarVenta_Click(object sender, EventArgs e)
        //{
        //    // Crear una instancia del subformulario de búsqueda de ventas
        //    using (var modal = new MD_Venta())
        //    {
        //        // Mostrar el formulario modal
        //        var resultado = modal.ShowDialog();

        //        // Si el usuario seleccionó una venta y cerró el formulario con DialogResult.OK
        //        if (resultado == DialogResult.OK)
        //        {
        //            // Limpiar los campos de texto actuales antes de rellenar
        //            LimpiarCampos();

        //            // Rellenar los campos del formulario principal con los datos de la venta seleccionada
        //            txt_idVenta.Text = modal.ventaSeleccionada.IdVenta.ToString();
        //            txt_nroDocumento.Text = modal.ventaSeleccionada.NumeroDocumento;
        //            txt_documentoCliente.Text = modal.ventaSeleccionada.DocumentoCliente;
        //            txt_nombreCliente.Text = modal.ventaSeleccionada.NombreCliente;
        //            txt_montoTotal.Text = modal.ventaSeleccionada.MontoTotal.ToString("0.00");
        //            txt_montoPago.Text = modal.ventaSeleccionada.MontoPago.ToString("0.00");
        //            txt_montoCambio.Text = modal.ventaSeleccionada.MontoCambio.ToString("0.00");

        //            // Para la fecha y usuario, necesitarás hacer una búsqueda adicional
        //            // o cargar el objeto completo de Venta en el modal si quieres evitar otra llamada
        //            // a la base de datos.

        //            // Ejemplo para cargar los detalles de la venta en el DataGridView
        //            // (Esta es una función que necesitarás implementar)
        //            CargarDetalleVenta(txt_idVenta.Text);

        //            MessageBox.Show("Venta cargada con éxito.", "Venta Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            // El usuario canceló la búsqueda o cerró el formulario.
        //            MessageBox.Show("Búsqueda de venta cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }



        //}



        // Esta es una función de ejemplo que necesitarías implementar
        private void CargarDetalleVenta(string idVenta)
        {
            //1.Obtener los detalles de la venta por su ID.
            List<DetalleVenta> listaDetalle = new CN_venta().ObtenerDetalleVenta(idVenta);

            //2.Limpiar el DataGridView actual.
            dataGrid_detalleVenta.Rows.Clear();

            //3.Recorrer la lista y agregar las filas al DataGridView.
             foreach (var detalle in listaDetalle)
            {
                dataGrid_detalleVenta.Rows.Add(new object[] {
                    detalle.id_producto.nombre_producto,
                    detalle.precioVenta.ToString("0.00"),
                    detalle.cantidad,
                    detalle.subtotal.ToString("0.00")
                });
            }
        }

        // Esta es una función de ejemplo para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txt_nroDocumento.Text = string.Empty;
            txt_documentoCliente.Text = string.Empty;
            txt_nombreCliente.Text = string.Empty;
            txt_montoTotal.Text = "0.00";
            txt_montoPago.Text = "0.00";
            txt_montoCambio.Text = "0.00";
            dataGrid_detalleVenta.Rows.Clear();
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = "";
            txt_tipoDocumento.Text = "";
            txt_usuario.Text = "";
            txt_documentoCliente.Text = "";
            txt_nombreCliente.Text = "";

            dataGrid_detalleVenta.Rows.Clear();
            txt_montoTotal.Text = "0.00";
            txt_montoPago.Text = "0.00";
            txt_montoCambio.Text = "0.00";
            txt_nroDocumento.Text = "";
            txt_nroDocumento.Select();
        }

        private void btn_descargarPDF_Click(object sender, EventArgs e)
        {
            if (txt_tipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.ruc);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txt_tipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txt_documentoBuscado.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txt_documentoCliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txt_nombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txt_fecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txt_usuario.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGrid_detalleVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txt_montoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txt_montoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txt_montoCambio.Text); 


            // Crea una nueva instancia de SaveFileDialog para guardar el archivo.
            SaveFileDialog savefile = new SaveFileDialog();

            // Establece el nombre de archivo predeterminado usando el número de documento de la compra.
            savefile.FileName = string.Format("Venta_{0}.pdf", txt_nroDocumento.Text);

            // Establece el filtro de archivo para que solo se muestren archivos PDF.
            savefile.Filter = "Pdf Files|*.pdf";

            // Muestra el cuadro de diálogo para guardar el archivo. Si el usuario hace clic en OK, el código continúa.
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                // Usa un FileStream para crear y escribir en el archivo PDF.
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Crea un nuevo documento PDF con un tamaño de página A4 y márgenes de 25 en todos los lados.
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    // Crea una instancia de PdfWriter para escribir el documento en el stream.
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    // Abre el documento para empezar a escribir contenido.
                    pdfDoc.Open();

                    // Variable para verificar si se obtuvo el logo.
                    bool obtenido = true;

                    // Llama a un método para obtener el logo del negocio como un array de bytes.
                    byte[] byteImage = new CN_negocio().ObtenerLogo(out obtenido);

                    // Si se obtuvo el logo correctamente...
                    if (obtenido)
                    {
                        // Crea una instancia de iTextSharp.Image a partir del array de bytes.
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);

                        // Ajusta la escala de la imagen para que su tamaño sea de 60x60.
                        img.ScaleToFit(60, 60);

                        // Establece la alineación de la imagen. UNDERLYING la coloca detrás del texto.
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        // Establece la posición absoluta de la imagen en la página.
                        // Se coloca en la esquina superior izquierda (pdfDoc.Left) con un margen superior de 51.
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));

                        // Agrega la imagen al documento PDF.
                        pdfDoc.Add(img);
                    }

                    // Crea un StringReader para leer el contenido del HTML de la compra.
                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        // Utiliza la clase XMLWorkerHelper de iTextSharp para analizar el HTML y convertirlo en un documento PDF.
                        // 'writer' es el PdfWriter que escribe en el stream del archivo.
                        // 'pdfDoc' es el Documento PDF donde se agrega el contenido.
                        // 'sr' es el StringReader que proporciona el contenido HTML.
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    // Cierra el documento PDF, lo que finaliza la escritura.
                    pdfDoc.Close();

                    // Cierra el FileStream, liberando los recursos del archivo.
                    stream.Close();

                    // Muestra un mensaje de éxito al usuario, indicando que el documento ha sido generado.
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
        }
    }

}
