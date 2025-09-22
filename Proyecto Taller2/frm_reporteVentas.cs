using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
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
    public partial class frm_reporteVentas : Form
    {
        public frm_reporteVentas()
        {
            InitializeComponent();
        }

        private void frm_reporteVentas_Load(object sender, EventArgs e)
        {
            // Configurar la fecha máxima para ambos DateTimePicker para evitar fechas futuras
            txt_fechaInicio.MaxDate = DateTime.Today;
            txt_fechaFin.MaxDate = DateTime.Today;

            // Configurar la fecha mínima para el DateTimePicker de inicio
            txt_fechaInicio.MinDate = DateTime.Today.AddYears(-1);

            foreach (DataGridViewColumn columna in dataGrid.Columns)
            {
                comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            comboBox_busqueda.DisplayMember = "Texto";
            comboBox_busqueda.ValueMember = "Valor";
            comboBox_busqueda.SelectedIndex = 0;
        }

        private void btn_busquedaVenta_Click(object sender, EventArgs e)
        {
            // Validar el rango de fechas
            DateTime fechaInicio = txt_fechaInicio.Value.Date;
            DateTime fechaFin = txt_fechaFin.Value.Date;

            // 1. Validación principal: fecha de inicio no puede ser posterior a la fecha de fin
            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser superior a la fecha de fin.", "Error de Rango de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validación de rango excesivamente amplio (opcional)
            // Por ejemplo, si el rango de búsqueda es mayor a un año
            if ((fechaFin - fechaInicio).TotalDays > 365)
            {
                MessageBox.Show("El rango de fechas es demasiado amplio. Por favor, seleccione un rango de búsqueda menor a un año.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validación de fechas futuras (si aplica)
            if (fechaInicio > DateTime.Today || fechaFin > DateTime.Today)
            {
                MessageBox.Show("No se pueden buscar ventas en fechas futuras.", "Error de Fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<ReporteVenta> lista = new List<ReporteVenta>();

            lista = new CN_reportes().Venta(txt_fechaInicio.Value.ToString(), txt_fechaFin.Value.ToString());

            dataGrid.Rows.Clear();

            if (lista.Count < 1)
            {
                MessageBox.Show("No se encontraron ventas en el rango de fechas. Verifique que haya ventas cargadas.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (ReporteVenta rv in lista)
            {
                dataGrid.Rows.Add(new object[] {
                rv.FechaRegistro,
                rv.TipoDocumento,
                rv.NumeroDocumento,
                rv.MontoTotal,
                rv.UsuarioRegistro,
                rv.DocumentoCliente,
                rv.NombreCliente,
                rv.CodigoProducto,
                rv.NombreProducto,
                rv.Categoria,
                rv.PrecioVenta,
                rv.Cantidad,
                rv.SubTotal
    });
            }
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();

            if (dataGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay ventas cargadas para buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {

            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dataGrid.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {



                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dataGrid.Columns) // recorrer las columnas del datagrid
                {

                    dt.Columns.Add(column.HeaderText, typeof(string)); // agregar la columna al datatable
                }
                foreach (DataGridViewRow row in dataGrid.Rows) // recorrer las filas del datagrid
                {
                    if (row.Visible) // si la fila es visible
                    {
                        dt.Rows.Add(new object[] // agregar la fila al datatable
                            {

                                row.Cells[0].Value.ToString(), // omitir la columna del boton seleccionar
                                row.Cells[1].Value.ToString(),
                                row.Cells[2].Value.ToString(),
                                row.Cells[3].Value.ToString(),
                                row.Cells[4].Value.ToString(),
                                row.Cells[5].Value.ToString(),

                                row.Cells[6].Value.ToString(),
                                row.Cells[7].Value.ToString(),
                                row.Cells[8].Value.ToString(),
                                row.Cells[9].Value.ToString(),
                                row.Cells[10].Value.ToString(),
                                row.Cells[11].Value.ToString(),
                                row.Cells[12].Value.ToString(),


                            });



                    }
                }

                SaveFileDialog savefile = new SaveFileDialog(); // crear un cuadro de dialogo para guardar el archivo
                savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));// nombre del archivo
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
    }
}
