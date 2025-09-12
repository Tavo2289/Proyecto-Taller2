namespace Proyecto_Taller2.Modales
{
    partial class MD_proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_listaProveedor = new System.Windows.Forms.DataGridView();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.lbl_tituloLista = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_listaProveedor
            // 
            this.dataGrid_listaProveedor.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_listaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_listaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nro_documento,
            this.razon_social});
            this.dataGrid_listaProveedor.Location = new System.Drawing.Point(36, 132);
            this.dataGrid_listaProveedor.MultiSelect = false;
            this.dataGrid_listaProveedor.Name = "dataGrid_listaProveedor";
            this.dataGrid_listaProveedor.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaProveedor.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_listaProveedor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid_listaProveedor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaProveedor.RowTemplate.Height = 28;
            this.dataGrid_listaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_listaProveedor.Size = new System.Drawing.Size(538, 263);
            this.dataGrid_listaProveedor.TabIndex = 92;
            this.dataGrid_listaProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_listaProveedor_CellDoubleClick);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(307, 65);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(140, 20);
            this.txt_busqueda.TabIndex = 89;
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Location = new System.Drawing.Point(161, 63);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(140, 21);
            this.comboBox_busqueda.TabIndex = 88;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(93, 66);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 13);
            this.lbl_buscar.TabIndex = 87;
            this.lbl_buscar.Text = "Buscar Por:";
            // 
            // lbl_tituloLista
            // 
            this.lbl_tituloLista.BackColor = System.Drawing.Color.White;
            this.lbl_tituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloLista.Location = new System.Drawing.Point(31, 9);
            this.lbl_tituloLista.Name = "lbl_tituloLista";
            this.lbl_tituloLista.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbl_tituloLista.Size = new System.Drawing.Size(543, 96);
            this.lbl_tituloLista.TabIndex = 86;
            this.lbl_tituloLista.Text = "Lista de Proveedores";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nro_documento
            // 
            this.nro_documento.HeaderText = "Numero Documento";
            this.nro_documento.Name = "nro_documento";
            this.nro_documento.ReadOnly = true;
            this.nro_documento.Width = 150;
            // 
            // razon_social
            // 
            this.razon_social.HeaderText = "Razon Social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            this.razon_social.Width = 150;
            // 
            // btn_limpiarBusqueda
            // 
            this.btn_limpiarBusqueda.BackColor = System.Drawing.Color.White;
            this.btn_limpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarBusqueda.ForeColor = System.Drawing.Color.White;
            this.btn_limpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiarBusqueda.IconColor = System.Drawing.Color.Black;
            this.btn_limpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiarBusqueda.IconSize = 19;
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(525, 63);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 91;
            this.btn_limpiarBusqueda.UseVisualStyleBackColor = false;
            this.btn_limpiarBusqueda.Click += new System.EventHandler(this.btn_limpiarBusqueda_Click);
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackColor = System.Drawing.Color.White;
            this.btn_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busqueda.ForeColor = System.Drawing.Color.White;
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.IconSize = 16;
            this.btn_busqueda.Location = new System.Drawing.Point(467, 63);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 90;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // MD_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 407);
            this.Controls.Add(this.dataGrid_listaProveedor);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.lbl_tituloLista);
            this.Name = "MD_proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD_proveedor";
            this.Load += new System.EventHandler(this.MD_proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_listaProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label lbl_tituloLista;
    }
}