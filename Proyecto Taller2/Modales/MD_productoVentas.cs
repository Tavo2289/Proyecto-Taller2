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
    public partial class MD_productoVentas : Form
    {

        public Producto productoSeleccionado { get; set; }
        public MD_productoVentas()
        {
            InitializeComponent();
        }

        private void MD_productoVentas_Load(object sender, EventArgs e)
        {





            foreach (DataGridViewColumn columna in dataGrid_listaProducto.Columns)
            {  // recorrer las columnas del datagrid

                if (columna.Visible == true)
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
                 {   item.id_producto,
                     item.codigo,
                     item.nombre_producto,
                     item.id_categoria.nombre_categoria,
                     item.stock,
                     item.precio_compra,
                     item.precio_venta,

                    });


            }
        }

        private void dataGrid_listaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            // Solo si se hace doble clic en una celda válida (no en el encabezado)
            if (rowIndex >= 0 && columnIndex >= 0)
            {
                // Obtener el valor del stock de la fila seleccionada
                int stockProducto = Convert.ToInt32(dataGrid_listaProducto.Rows[rowIndex].Cells["stock"].Value.ToString());

                // Validar si el stock es mayor a 0
                if (stockProducto > 0)
                {
                    // Si hay stock, cargar los datos en el nuevo objeto y cerrar el formulario
                    productoSeleccionado = new Producto()
                    {
                        id_producto = Convert.ToInt32(dataGrid_listaProducto.Rows[rowIndex].Cells["id"].Value.ToString()),
                        codigo = dataGrid_listaProducto.Rows[rowIndex].Cells["codigo"].Value.ToString(),
                        nombre_producto = dataGrid_listaProducto.Rows[rowIndex].Cells["nombre"].Value.ToString(),
                        stock = stockProducto,
                        precio_compra = Convert.ToDecimal(dataGrid_listaProducto.Rows[rowIndex].Cells["precio_compra"].Value.ToString()),
                        precio_venta = Convert.ToDecimal(dataGrid_listaProducto.Rows[rowIndex].Cells["precio_venta"].Value.ToString())
                    };
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Si el stock es 0, mostrar un mensaje de advertencia
                    MessageBox.Show("El producto seleccionado no tiene stock disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                MessageBox.Show("No hay Productos cargados que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaProducto.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
        }
    }
}
