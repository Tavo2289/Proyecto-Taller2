namespace Proyecto_Taller2
{
    partial class frm_reporteVentas
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
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btn_busquedaVenta = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioRegistrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.White;
            this.btn_exportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exportar.Image = global::Proyecto_Taller2.Properties.Resources.excel___copia___copia;
            this.btn_exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exportar.Location = new System.Drawing.Point(94, 119);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(115, 25);
            this.btn_exportar.TabIndex = 101;
            this.btn_exportar.Text = "Descargar Excel";
            this.btn_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
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
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(1062, 123);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 100;
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
            this.btn_busqueda.Location = new System.Drawing.Point(1006, 123);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 99;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(843, 124);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(157, 20);
            this.txt_busqueda.TabIndex = 98;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(619, 128);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 13);
            this.lbl_buscar.TabIndex = 96;
            this.lbl_buscar.Text = "Buscar Por:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(18, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1104, 401);
            this.label6.TabIndex = 95;
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Location = new System.Drawing.Point(687, 125);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(140, 21);
            this.comboBox_busqueda.TabIndex = 97;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaRegistro,
            this.tipoDocumento,
            this.documento,
            this.montoTotal,
            this.usuarioRegistrado,
            this.documentoCliente,
            this.nombreCliente,
            this.codProducto,
            this.nombreProducto,
            this.categoria,
            this.precioVenta,
            this.cantidad,
            this.subtotal});
            this.dataGrid.Location = new System.Drawing.Point(31, 152);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1079, 351);
            this.dataGrid.TabIndex = 94;
            // 
            // btn_busquedaVenta
            // 
            this.btn_busquedaVenta.BackColor = System.Drawing.Color.White;
            this.btn_busquedaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busquedaVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_busquedaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busquedaVenta.ForeColor = System.Drawing.Color.White;
            this.btn_busquedaVenta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busquedaVenta.IconColor = System.Drawing.Color.Black;
            this.btn_busquedaVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busquedaVenta.IconSize = 16;
            this.btn_busquedaVenta.Location = new System.Drawing.Point(507, 67);
            this.btn_busquedaVenta.Name = "btn_busquedaVenta";
            this.btn_busquedaVenta.Size = new System.Drawing.Size(40, 21);
            this.btn_busquedaVenta.TabIndex = 93;
            this.btn_busquedaVenta.UseVisualStyleBackColor = false;
            this.btn_busquedaVenta.Click += new System.EventHandler(this.btn_busquedaVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(269, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha inicio:";
            // 
            // txt_fechaFin
            // 
            this.txt_fechaFin.CustomFormat = "dd/MM/yyyy";
            this.txt_fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaFin.Location = new System.Drawing.Point(344, 65);
            this.txt_fechaFin.Name = "txt_fechaFin";
            this.txt_fechaFin.Size = new System.Drawing.Size(123, 20);
            this.txt_fechaFin.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Reporte Ventas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1104, 85);
            this.label1.TabIndex = 86;
            // 
            // txt_fechaInicio
            // 
            this.txt_fechaInicio.CustomFormat = "dd/MM/yyyy";
            this.txt_fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fechaInicio.Location = new System.Drawing.Point(127, 65);
            this.txt_fechaInicio.Name = "txt_fechaInicio";
            this.txt_fechaInicio.Size = new System.Drawing.Size(123, 20);
            this.txt_fechaInicio.TabIndex = 85;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.HeaderText = "Fecha Registro";
            this.fechaRegistro.Name = "fechaRegistro";
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.HeaderText = "Tipo Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            // 
            // documento
            // 
            this.documento.HeaderText = "Numero Documento";
            this.documento.Name = "documento";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "Monto Total";
            this.montoTotal.Name = "montoTotal";
            // 
            // usuarioRegistrado
            // 
            this.usuarioRegistrado.HeaderText = "Usuario Registrado";
            this.usuarioRegistrado.Name = "usuarioRegistrado";
            // 
            // documentoCliente
            // 
            this.documentoCliente.HeaderText = "Documento Cliente";
            this.documentoCliente.Name = "documentoCliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre Cliente";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // codProducto
            // 
            this.codProducto.HeaderText = "Codigo Producto";
            this.codProducto.Name = "codProducto";
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.Name = "nombreProducto";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.Name = "subtotal";
            // 
            // frm_reporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 528);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_busquedaVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fechaInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frm_reporteVentas";
            this.Text = "frm_reporteVentas";
            this.Load += new System.EventHandler(this.frm_reporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exportar;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        private System.Windows.Forms.DataGridView dataGrid;
        private FontAwesome.Sharp.IconButton btn_busquedaVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_fechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioRegistrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}