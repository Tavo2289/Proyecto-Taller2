namespace Proyecto_Taller2
{
    partial class frm_detalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_descargarPDF = new FontAwesome.Sharp.IconButton();
            this.txt_montoTotal = new System.Windows.Forms.TextBox();
            this.dataGrid_detalleVenta = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_documentoBuscado = new System.Windows.Forms.TextBox();
            this.txt_documentoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tipoDocumento = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.txt_nroDocumento = new System.Windows.Forms.TextBox();
            this.lbl_nroDocumento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_montoPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_montoCambio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_descargarPDF
            // 
            this.btn_descargarPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btn_descargarPDF.IconColor = System.Drawing.Color.Black;
            this.btn_descargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_descargarPDF.IconSize = 18;
            this.btn_descargarPDF.Location = new System.Drawing.Point(661, 496);
            this.btn_descargarPDF.Name = "btn_descargarPDF";
            this.btn_descargarPDF.Size = new System.Drawing.Size(155, 27);
            this.btn_descargarPDF.TabIndex = 64;
            this.btn_descargarPDF.Text = "Descargar en PDF";
            this.btn_descargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_descargarPDF.UseVisualStyleBackColor = true;
            this.btn_descargarPDF.Click += new System.EventHandler(this.btn_descargarPDF_Click);
            // 
            // txt_montoTotal
            // 
            this.txt_montoTotal.Location = new System.Drawing.Point(290, 496);
            this.txt_montoTotal.Name = "txt_montoTotal";
            this.txt_montoTotal.Size = new System.Drawing.Size(52, 20);
            this.txt_montoTotal.TabIndex = 56;
            this.txt_montoTotal.Text = "0";
            // 
            // dataGrid_detalleVenta
            // 
            this.dataGrid_detalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_detalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGrid_detalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_detalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.dataGrid_detalleVenta.Location = new System.Drawing.Point(204, 299);
            this.dataGrid_detalleVenta.MultiSelect = false;
            this.dataGrid_detalleVenta.Name = "dataGrid_detalleVenta";
            this.dataGrid_detalleVenta.ReadOnly = true;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_detalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGrid_detalleVenta.RowTemplate.Height = 28;
            this.dataGrid_detalleVenta.Size = new System.Drawing.Size(612, 188);
            this.dataGrid_detalleVenta.TabIndex = 63;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 180;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio Venta";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(201, 35);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(165, 20);
            this.txt_nombreCliente.TabIndex = 6;
            // 
            // txt_documentoBuscado
            // 
            this.txt_documentoBuscado.Location = new System.Drawing.Point(438, 35);
            this.txt_documentoBuscado.Name = "txt_documentoBuscado";
            this.txt_documentoBuscado.Size = new System.Drawing.Size(114, 20);
            this.txt_documentoBuscado.TabIndex = 5;
            this.txt_documentoBuscado.Visible = false;
            // 
            // txt_documentoCliente
            // 
            this.txt_documentoCliente.Location = new System.Drawing.Point(20, 35);
            this.txt_documentoCliente.Name = "txt_documentoCliente";
            this.txt_documentoCliente.Size = new System.Drawing.Size(165, 20);
            this.txt_documentoCliente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(220, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Monto Total";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_nombreCliente);
            this.groupBox2.Controls.Add(this.txt_documentoBuscado);
            this.groupBox2.Controls.Add(this.txt_documentoCliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(223, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 94);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // txt_tipoDocumento
            // 
            this.txt_tipoDocumento.Location = new System.Drawing.Point(201, 35);
            this.txt_tipoDocumento.Name = "txt_tipoDocumento";
            this.txt_tipoDocumento.Size = new System.Drawing.Size(165, 20);
            this.txt_tipoDocumento.TabIndex = 6;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(387, 35);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(165, 20);
            this.txt_usuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(20, 35);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(165, 20);
            this.txt_fecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Documento";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_tipoDocumento);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(223, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 94);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // btn_limpiarBusqueda
            // 
            this.btn_limpiarBusqueda.BackColor = System.Drawing.Color.White;
            this.btn_limpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiarBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiarBusqueda.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiarBusqueda.IconColor = System.Drawing.Color.Black;
            this.btn_limpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiarBusqueda.IconSize = 19;
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(776, 50);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 60;
            this.btn_limpiarBusqueda.UseVisualStyleBackColor = false;
            this.btn_limpiarBusqueda.Click += new System.EventHandler(this.btn_limpiarBusqueda_Click);
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackColor = System.Drawing.Color.White;
            this.btn_busqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busqueda.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_busqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busqueda.IconColor = System.Drawing.Color.Black;
            this.btn_busqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busqueda.IconSize = 16;
            this.btn_busqueda.Location = new System.Drawing.Point(718, 50);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 59;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // txt_nroDocumento
            // 
            this.txt_nroDocumento.Location = new System.Drawing.Point(558, 52);
            this.txt_nroDocumento.Name = "txt_nroDocumento";
            this.txt_nroDocumento.Size = new System.Drawing.Size(140, 20);
            this.txt_nroDocumento.TabIndex = 58;
            // 
            // lbl_nroDocumento
            // 
            this.lbl_nroDocumento.AutoSize = true;
            this.lbl_nroDocumento.BackColor = System.Drawing.Color.White;
            this.lbl_nroDocumento.Location = new System.Drawing.Point(462, 55);
            this.lbl_nroDocumento.Name = "lbl_nroDocumento";
            this.lbl_nroDocumento.Size = new System.Drawing.Size(75, 13);
            this.lbl_nroDocumento.TabIndex = 57;
            this.lbl_nroDocumento.Text = "Numero Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Detalle Venta";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(799, 519);
            this.label1.TabIndex = 53;
            // 
            // txt_montoPago
            // 
            this.txt_montoPago.Location = new System.Drawing.Point(414, 496);
            this.txt_montoPago.Name = "txt_montoPago";
            this.txt_montoPago.Size = new System.Drawing.Size(56, 20);
            this.txt_montoPago.TabIndex = 66;
            this.txt_montoPago.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(344, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Monto Pago";
            // 
            // txt_montoCambio
            // 
            this.txt_montoCambio.Location = new System.Drawing.Point(558, 496);
            this.txt_montoCambio.Name = "txt_montoCambio";
            this.txt_montoCambio.Size = new System.Drawing.Size(57, 20);
            this.txt_montoCambio.TabIndex = 68;
            this.txt_montoCambio.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(476, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Monto Cambio";
            // 
            // txt_idVenta
            // 
            this.txt_idVenta.Location = new System.Drawing.Point(364, 50);
            this.txt_idVenta.Name = "txt_idVenta";
            this.txt_idVenta.Size = new System.Drawing.Size(30, 20);
            this.txt_idVenta.TabIndex = 7;
            this.txt_idVenta.Visible = false;
            // 
            // frm_detalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.txt_idVenta);
            this.Controls.Add(this.txt_montoCambio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_montoPago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_descargarPDF);
            this.Controls.Add(this.txt_montoTotal);
            this.Controls.Add(this.dataGrid_detalleVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_nroDocumento);
            this.Controls.Add(this.lbl_nroDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_detalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_detalleVenta";
            this.Load += new System.EventHandler(this.frm_detalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_descargarPDF;
        private System.Windows.Forms.TextBox txt_montoTotal;
        private System.Windows.Forms.DataGridView dataGrid_detalleVenta;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_documentoBuscado;
        private System.Windows.Forms.TextBox txt_documentoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tipoDocumento;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox txt_nroDocumento;
        private System.Windows.Forms.Label lbl_nroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_montoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_montoCambio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.TextBox txt_idVenta;
    }
}