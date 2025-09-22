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

namespace Proyecto_Taller2.Modales
{
    public partial class MD_Venta : Form
    {
        public Venta ventaSeleccionada { get; set; }

        public string NumeroDocumentoSeleccionado { get; set; }
        public int IdVentaSeleccionado { get; set; }

        public MD_Venta()
        {
            InitializeComponent();
        }

        private void MD_Venta_Load(object sender, EventArgs e)
        {
            // 🚀 Configurar el ComboBox para la búsqueda
            // Limpiar elementos existentes para evitar duplicados
            comboBox_busqueda.Items.Clear();

            // Recorrer las columnas del DataGridView para llenar el ComboBox
            foreach (DataGridViewColumn columna in dataGrid_listaVenta.Columns)
            {
                // Solo agregar columnas que sean visibles para la búsqueda
                if (columna.Visible)
                {
                    comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            // Asignar las propiedades de visualización y valor del ComboBox
            comboBox_busqueda.DisplayMember = "Texto";
            comboBox_busqueda.ValueMember = "Valor";
            comboBox_busqueda.SelectedIndex = 0; // Seleccionar el primer elemento por defecto

            /// Llenar el DataGridView con todas las ventas
            List<Venta> listaVenta = new CN_venta().Listar();

            foreach (Venta item in listaVenta)
            {
                dataGrid_listaVenta.Rows.Add(new object[]
                {
                            // Asignar los valores a las celdas del DataGridView en el orden correcto
                            item.IdVenta,
                            item.oUsuario.id_usuario,
                            item.TipoDocumento,

                            item.NumeroDocumento,
                            item.DocumentoCliente,
                            item.NombreCliente,
                            item.MontoPago,
                            item.MontoCambio,

                            item.MontoTotal,
                            item.FechaRegistro
                });
            }
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();
            string textoBusqueda = txt_busqueda.Text.Trim().ToUpper();

            if (dataGrid_listaVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaVenta.Rows)
                {
                    if (row.Cells[columnaFiltro].Value != null && row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoBusqueda))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ventas cargadas que pueda buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";
            foreach (DataGridViewRow row in dataGrid_listaVenta.Rows)
            {
                row.Visible = true;
            }
        }



        // (El código del MD_Venta es el mismo que en la respuesta anterior)
        // ...
        // Tu formulario MD_Venta ya devuelve el objeto Venta completo, lo cual es correcto.
        // ...
        private void dataGrid_listaVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                ventaSeleccionada = new Venta()
                {
                    // Asigna todos los datos de la fila a la venta seleccionada.
                    IdVenta = Convert.ToInt32(dataGrid_listaVenta.Rows[rowIndex].Cells["id"].Value),
                    oUsuario= new Usuario()
                    {
                        id_usuario = Convert.ToInt32(dataGrid_listaVenta.Rows[rowIndex].Cells["idUsuario"].Value)
                    },
                    TipoDocumento = dataGrid_listaVenta.Rows[rowIndex].Cells["tipoDocumento"].Value.ToString(),

                    NumeroDocumento = dataGrid_listaVenta.Rows[rowIndex].Cells["documento"].Value.ToString(),
                    DocumentoCliente = dataGrid_listaVenta.Rows[rowIndex].Cells["documentoCliente"].Value.ToString(),
                    NombreCliente = dataGrid_listaVenta.Rows[rowIndex].Cells["nombreCliente"].Value.ToString(),
                    MontoPago = Convert.ToDecimal(dataGrid_listaVenta.Rows[rowIndex].Cells["montoPago"].Value),
                    MontoCambio = Convert.ToDecimal(dataGrid_listaVenta.Rows[rowIndex].Cells["montoCambio"].Value),
                    MontoTotal = Convert.ToDecimal(dataGrid_listaVenta.Rows[rowIndex].Cells["montoTotal"].Value),
                    FechaRegistro = dataGrid_listaVenta.Rows[rowIndex].Cells["fechaRegistro"].Value.ToString(),
                    // ... y los demás campos que necesites
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btn_busqueda_Click_1(object sender, EventArgs e)
        {

            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();

            if (dataGrid_listaVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaVenta.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay Ventas cargadas que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click_1(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaVenta.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
        }
    }
}
