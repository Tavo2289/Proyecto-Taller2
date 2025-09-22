namespace Proyecto_Taller2.Modales
{
    partial class MD_Venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.dataGrid_listaVenta = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(316, 67);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(140, 20);
            this.txt_busqueda.TabIndex = 97;
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Location = new System.Drawing.Point(170, 65);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(140, 21);
            this.comboBox_busqueda.TabIndex = 96;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(102, 68);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 13);
            this.lbl_buscar.TabIndex = 95;
            this.lbl_buscar.Text = "Buscar Por:";
            // 
            // dataGrid_listaVenta
            // 
            this.dataGrid_listaVenta.AllowUserToAddRows = false;
            this.dataGrid_listaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_listaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_listaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idUsuario,
            this.tipoDocumento,
            this.documento,
            this.documentoCliente,
            this.nombreCliente,
            this.montoPago,
            this.montoCambio,
            this.montoTotal,
            this.fechaRegistro});
            this.dataGrid_listaVenta.Location = new System.Drawing.Point(12, 123);
            this.dataGrid_listaVenta.MultiSelect = false;
            this.dataGrid_listaVenta.Name = "dataGrid_listaVenta";
            this.dataGrid_listaVenta.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_listaVenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid_listaVenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaVenta.RowTemplate.Height = 28;
            this.dataGrid_listaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_listaVenta.Size = new System.Drawing.Size(667, 273);
            this.dataGrid_listaVenta.TabIndex = 93;
            this.dataGrid_listaVenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_listaVenta_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(667, 92);
            this.label3.TabIndex = 94;
            this.label3.Text = "Lista de Ventas";
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
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(534, 65);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 99;
            this.btn_limpiarBusqueda.UseVisualStyleBackColor = false;
            this.btn_limpiarBusqueda.Click += new System.EventHandler(this.btn_limpiarBusqueda_Click_1);
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
            this.btn_busqueda.Location = new System.Drawing.Point(476, 65);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 98;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click_1);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 46;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "id Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 92;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Visible = false;
            this.tipoDocumento.Width = 127;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento Venta";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 123;
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "Documento Cliente";
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.ReadOnly = true;
            this.documentoCliente.Width = 129;
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Width = 112;
            // 
            // montoPago
            // 
            this.montoPago.HeaderText = "Monto Pago";
            this.montoPago.Name = "montoPago";
            this.montoPago.ReadOnly = true;
            this.montoPago.Visible = false;
            this.montoPago.Width = 95;
            // 
            // montoCambio
            // 
            this.montoCambio.HeaderText = "Monto Cambio";
            this.montoCambio.Name = "montoCambio";
            this.montoCambio.ReadOnly = true;
            this.montoCambio.Visible = false;
            this.montoCambio.Width = 108;
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Width = 93;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 110;
            // 
            // MD_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 407);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.dataGrid_listaVenta);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.label3);
            this.Name = "MD_Venta";
            this.Text = "MD_ventas";
            this.Load += new System.EventHandler(this.MD_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.DataGridView dataGrid_listaVenta;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
    }
}