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
    public partial class MD_clientes : Form
    {   
        public Cliente _cliente { get; set; }
        public MD_clientes()
        {
            InitializeComponent();
        }

        private void MD_clientes_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dataGrid_listaClientes.Columns) //recorre todas las columnas del datagridview
            {
               //si la columna es visible y no es la columna de seleccionar
                
                    comboBox_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText }); //agrega una opcion al combo con el nombre de la columna y el texto del encabezado
                
            }
            comboBox_busqueda.DisplayMember = "Texto"; //muestra el texto en el combo
            comboBox_busqueda.ValueMember = "Valor"; //asocia el valor al texto
            comboBox_busqueda.SelectedIndex = 0; //selecciona la primera opcion del combo
            txt_busqueda.Select(); //selecciona el cuadro de texto de buscar

            string nombreCompleto;
            List<Cliente> listaClientes = new CN_clientes().Listar(); //se obtiene la lista de Clientees
            foreach (Cliente item in listaClientes) //recorre la lista de Clientees
            {
                if (item.estado) //si el estado esta activo
                {
                    
                    dataGrid_listaClientes.Rows.Add(new object[] { item.nro_documento, item.nombre, item.apellido }); //agrega una fila al datagridview con los datos del Cliente
                }
            }
        }

        private void dataGrid_listaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex; //obtiene el indice de la fila seleccionada
            int columnIndex = e.ColumnIndex; //obtiene el indice de la columna seleccionada


            if (rowIndex >= 0 && columnIndex > 0) //si el indice de la fila es mayor o igual a 0 y el indice de la columna es mayor a 0 (para evitar que se seleccione la fila de encabezado o la columna de seleccionar)
            {
                _cliente = new Cliente()
                {
                    nro_documento = dataGrid_listaClientes.Rows[rowIndex].Cells["nro_documento"].Value.ToString(),
                    nombre = dataGrid_listaClientes.Rows[rowIndex].Cells["nombre"].Value.ToString(),
                    apellido = dataGrid_listaClientes.Rows[rowIndex].Cells["apellido"].Value.ToString(),

                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)comboBox_busqueda.SelectedItem).Valor.ToString();

            if (dataGrid_listaClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid_listaClientes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;//si la celda contiene el texto de busqueda, se muestra la fila
                    else
                        row.Visible = false;//si no, se oculta la fila
                }
            }
            else
            {
                MessageBox.Show("No hay Clientes cargados que pueda buscar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiarBusqueda_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = ""; // limpiar el textbox de busqueda
            foreach (DataGridViewRow row in dataGrid_listaClientes.Rows)
            {
                row.Visible = true;// mostrar todas las filas
            }
        }
    }
}
