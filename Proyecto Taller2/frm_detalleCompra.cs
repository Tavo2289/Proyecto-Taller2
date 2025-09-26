using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
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
    public partial class frm_detalleCompra : Form
    {
        public frm_detalleCompra(string numeroDocumento)
        {
            InitializeComponent();
            if (numeroDocumento == "")
            {
                txt_nroDocumento.Text = "";
            }
            else
            {
                txt_nroDocumento.Text = numeroDocumento;
            }
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


            Compra oCompra = new CN_compras().ObtenerCompra(txt_nroDocumento.Text);

            if (oCompra.id_compra != 0)
            {
                txt_nroDocumento.Text = oCompra.nro_documento;
                txt_fecha.Text = oCompra.fecha_compra;
                txt_tipoDocumento.Text = oCompra.tipo_documento;
                txt_usuario.Text = oCompra.id_usuario.nombre +" "+oCompra.id_usuario.apellido;
                txt_documentoProveedor.Text = oCompra.id_proveedor.nro_documento;
                txt_razonSocial.Text = oCompra.id_proveedor.razon_social;

                dataGrid_detalleCompra.Rows.Clear();
                foreach (DetalleCompra dc in oCompra.detalleCompras)
                {
                    dataGrid_detalleCompra.Rows.Add(new object[] {
                        dc.id_producto.nombre_producto,
                        dc.precioCompra,
                        dc.cantidad,
                        dc.montoTotal
                    });
                }
                txt_montoTotal.Text = oCompra.monto_total.ToString("0.00");

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

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_nroDocumento.Text = "";
            txt_fecha.Text = "";
            txt_tipoDocumento.Text = "";
            txt_usuario.Text = "";
            txt_documentoProveedor.Text = "";
            txt_razonSocial.Text = "";

            dataGrid_detalleCompra.Rows.Clear();
            txt_montoTotal.Text = "0.00";
            txt_nroDocumento.Focus();
        
    }

        private void btn_descargarPDF_Click(object sender, EventArgs e)
        {
            if (txt_tipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.ruc);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txt_tipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txt_nroDocumento.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", txt_documentoProveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txt_razonSocial.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txt_fecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txt_usuario.Text);


            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGrid_detalleCompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["precioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["subtotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txt_montoTotal.Text);


            // Crea una nueva instancia de SaveFileDialog para guardar el archivo.
            SaveFileDialog savefile = new SaveFileDialog();

            // Establece el nombre de archivo predeterminado usando el número de documento de la compra.
            savefile.FileName = string.Format("Compra_{0}.pdf", txt_nroDocumento.Text);

            // Establece el filtro de archivo para que solo se muestren archivos PDF.
            savefile.Filter = "Pdf Files|*.pdf";

            // Muestra el cuadro de diálogo para guardar el archivo. Si el usuario hace clic en OK, el código continúa.
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                // Usa un FileStream para crear y escribir en el archivo PDF.
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Crea un nuevo documento PDF con un tamaño de página A4 y márgenes de 25 en todos los lados.
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

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

        private void frm_detalleCompra_Load(object sender, EventArgs e)
        {
            //desactimos los textbox para que no se puedan editar
            txt_fecha.Enabled = false;
            txt_tipoDocumento.Enabled = false;
            txt_usuario.Enabled = false;
            txt_documentoProveedor.Enabled = false;
            txt_razonSocial.Enabled = false;
            txt_montoTotal.Enabled = false;

            txt_nroDocumento.Focus();

        }
    }
}
