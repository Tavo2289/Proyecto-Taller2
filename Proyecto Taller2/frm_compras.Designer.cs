namespace Proyecto_Taller2
{
    partial class frm_compras
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_idProveedor = new System.Windows.Forms.TextBox();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.txt_documentoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numeric_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_codProducto = new System.Windows.Forms.TextBox();
            this.dataGrid_detalleCompra = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_totalPagar = new System.Windows.Forms.TextBox();
            this.btn_registrar = new FontAwesome.Sharp.IconButton();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.btn_buscarProducto = new FontAwesome.Sharp.IconButton();
            this.btn_busquedaProveedor = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(799, 509);
            this.label3.TabIndex = 21;
            this.label3.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboDocumento);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(142, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 94);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Compra";
            // 
            // comboDocumento
            // 
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Location = new System.Drawing.Point(158, 36);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(157, 21);
            this.comboDocumento.TabIndex = 3;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(20, 35);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_idProveedor);
            this.groupBox2.Controls.Add(this.btn_busquedaProveedor);
            this.groupBox2.Controls.Add(this.txt_razonSocial);
            this.groupBox2.Controls.Add(this.txt_documentoProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_documento);
            this.groupBox2.Location = new System.Drawing.Point(492, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 94);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txt_idProveedor
            // 
            this.txt_idProveedor.Location = new System.Drawing.Point(357, 10);
            this.txt_idProveedor.Name = "txt_idProveedor";
            this.txt_idProveedor.Size = new System.Drawing.Size(26, 20);
            this.txt_idProveedor.TabIndex = 27;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.Location = new System.Drawing.Point(195, 36);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(188, 20);
            this.txt_razonSocial.TabIndex = 3;
            // 
            // txt_documentoProveedor
            // 
            this.txt_documentoProveedor.Location = new System.Drawing.Point(9, 36);
            this.txt_documentoProveedor.Name = "txt_documentoProveedor";
            this.txt_documentoProveedor.Size = new System.Drawing.Size(120, 20);
            this.txt_documentoProveedor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Razon Social";
            // 
            // txt_documento
            // 
            this.txt_documento.AutoSize = true;
            this.txt_documento.Location = new System.Drawing.Point(6, 20);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(82, 13);
            this.txt_documento.TabIndex = 0;
            this.txt_documento.Text = "Nro Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Controls.Add(this.numeric_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_precioVenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_precioCompra);
            this.groupBox3.Controls.Add(this.txt_idProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_buscarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_producto);
            this.groupBox3.Controls.Add(this.txt_codProducto);
            this.groupBox3.Location = new System.Drawing.Point(142, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 110);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // numeric_cantidad
            // 
            this.numeric_cantidad.Location = new System.Drawing.Point(641, 50);
            this.numeric_cantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_cantidad.Name = "numeric_cantidad";
            this.numeric_cantidad.Size = new System.Drawing.Size(79, 20);
            this.numeric_cantidad.TabIndex = 39;
            this.numeric_cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(638, 35);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Precio Venta:";
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.Location = new System.Drawing.Point(536, 51);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.Size = new System.Drawing.Size(79, 20);
            this.txt_precioVenta.TabIndex = 37;
            this.txt_precioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioVenta_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Precio Compra:";
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Location = new System.Drawing.Point(416, 51);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(79, 20);
            this.txt_precioCompra.TabIndex = 35;
            this.txt_precioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCompra_KeyPress);
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(95, 25);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(26, 20);
            this.txt_idProducto.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cod Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Producto";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(186, 51);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(186, 20);
            this.txt_producto.TabIndex = 31;
            // 
            // txt_codProducto
            // 
            this.txt_codProducto.Location = new System.Drawing.Point(20, 51);
            this.txt_codProducto.Name = "txt_codProducto";
            this.txt_codProducto.Size = new System.Drawing.Size(100, 20);
            this.txt_codProducto.TabIndex = 30;
            this.txt_codProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codProducto_KeyDown);
            // 
            // dataGrid_detalleCompra
            // 
            this.dataGrid_detalleCompra.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_detalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_detalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_detalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.precioCompra,
            this.precioVenta,
            this.cantidad,
            this.subtotal,
            this.btn_eliminar});
            this.dataGrid_detalleCompra.Location = new System.Drawing.Point(142, 324);
            this.dataGrid_detalleCompra.MultiSelect = false;
            this.dataGrid_detalleCompra.Name = "dataGrid_detalleCompra";
            this.dataGrid_detalleCompra.ReadOnly = true;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_detalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_detalleCompra.RowTemplate.Height = 28;
            this.dataGrid_detalleCompra.Size = new System.Drawing.Size(632, 188);
            this.dataGrid_detalleCompra.TabIndex = 50;
            this.dataGrid_detalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_detalleCompra_CellContentClick);
            this.dataGrid_detalleCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGrid_detalleCompra_CellPainting);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(780, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Total a Pagar:";
            // 
            // txt_totalPagar
            // 
            this.txt_totalPagar.Location = new System.Drawing.Point(783, 430);
            this.txt_totalPagar.Name = "txt_totalPagar";
            this.txt_totalPagar.Size = new System.Drawing.Size(118, 20);
            this.txt_totalPagar.TabIndex = 73;
            this.txt_totalPagar.Text = "0";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.White;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btn_registrar.IconColor = System.Drawing.Color.MediumTurquoise;
            this.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrar.IconSize = 30;
            this.btn_registrar.Location = new System.Drawing.Point(783, 456);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(118, 46);
            this.btn_registrar.TabIndex = 74;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_agregar.IconColor = System.Drawing.Color.White;
            this.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar.IconSize = 16;
            this.btn_agregar.Location = new System.Drawing.Point(641, 76);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(92, 23);
            this.btn_agregar.TabIndex = 71;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_buscarProducto
            // 
            this.btn_buscarProducto.BackColor = System.Drawing.Color.White;
            this.btn_buscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_buscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_buscarProducto.IconColor = System.Drawing.Color.Black;
            this.btn_buscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscarProducto.IconSize = 16;
            this.btn_buscarProducto.Location = new System.Drawing.Point(126, 49);
            this.btn_buscarProducto.Name = "btn_buscarProducto";
            this.btn_buscarProducto.Size = new System.Drawing.Size(34, 21);
            this.btn_buscarProducto.TabIndex = 32;
            this.btn_buscarProducto.UseVisualStyleBackColor = false;
            this.btn_buscarProducto.Click += new System.EventHandler(this.btn_buscarProducto_Click);
            // 
            // btn_busquedaProveedor
            // 
            this.btn_busquedaProveedor.BackColor = System.Drawing.Color.White;
            this.btn_busquedaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busquedaProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_busquedaProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busquedaProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_busquedaProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busquedaProveedor.IconColor = System.Drawing.Color.Black;
            this.btn_busquedaProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busquedaProveedor.IconSize = 16;
            this.btn_busquedaProveedor.Location = new System.Drawing.Point(135, 35);
            this.btn_busquedaProveedor.Name = "btn_busquedaProveedor";
            this.btn_busquedaProveedor.Size = new System.Drawing.Size(40, 21);
            this.btn_busquedaProveedor.TabIndex = 26;
            this.btn_busquedaProveedor.UseVisualStyleBackColor = false;
            this.btn_busquedaProveedor.Click += new System.EventHandler(this.btn_busquedaProveedor_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 180;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            this.precioCompra.Width = 150;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            this.precioVenta.Width = 150;
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
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Width = 30;
            // 
            // frm_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_totalPagar);
            this.Controls.Add(this.dataGrid_detalleCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "frm_compras";
            this.Text = "frm_compras";
            this.Load += new System.EventHandler(this.frm_compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboDocumento;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_documentoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_documento;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.TextBox txt_idProveedor;
        private FontAwesome.Sharp.IconButton btn_busquedaProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btn_buscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_codProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numeric_cantidad;
        private System.Windows.Forms.DataGridView dataGrid_detalleCompra;
        private FontAwesome.Sharp.IconButton btn_agregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_totalPagar;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
    }
}