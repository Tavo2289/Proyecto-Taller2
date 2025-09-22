namespace Proyecto_Taller2
{
    partial class frm_venta
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
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.btn_busquedaCliente = new FontAwesome.Sharp.IconButton();
            this.txt_nombreCompleto = new System.Windows.Forms.TextBox();
            this.txt_documentoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.Label();
            this.txt_totalPagar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_detalleVenta = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.numeric_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_idProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscarProducto = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_codProducto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pagaCon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.btn_registrar = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(812, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Total a Pagar:";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(357, 10);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(26, 20);
            this.txt_idCliente.TabIndex = 27;
            this.txt_idCliente.Visible = false;
            // 
            // btn_busquedaCliente
            // 
            this.btn_busquedaCliente.BackColor = System.Drawing.Color.White;
            this.btn_busquedaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busquedaCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_busquedaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busquedaCliente.ForeColor = System.Drawing.Color.White;
            this.btn_busquedaCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_busquedaCliente.IconColor = System.Drawing.Color.Black;
            this.btn_busquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_busquedaCliente.IconSize = 16;
            this.btn_busquedaCliente.Location = new System.Drawing.Point(135, 35);
            this.btn_busquedaCliente.Name = "btn_busquedaCliente";
            this.btn_busquedaCliente.Size = new System.Drawing.Size(40, 21);
            this.btn_busquedaCliente.TabIndex = 26;
            this.btn_busquedaCliente.UseVisualStyleBackColor = false;
            this.btn_busquedaCliente.Click += new System.EventHandler(this.btn_busquedaCliente_Click);
            // 
            // txt_nombreCompleto
            // 
            this.txt_nombreCompleto.Location = new System.Drawing.Point(195, 36);
            this.txt_nombreCompleto.Name = "txt_nombreCompleto";
            this.txt_nombreCompleto.Size = new System.Drawing.Size(188, 20);
            this.txt_nombreCompleto.TabIndex = 3;
            // 
            // txt_documentoCliente
            // 
            this.txt_documentoCliente.Location = new System.Drawing.Point(9, 36);
            this.txt_documentoCliente.Name = "txt_documentoCliente";
            this.txt_documentoCliente.Size = new System.Drawing.Size(120, 20);
            this.txt_documentoCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Completo";
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
            // txt_totalPagar
            // 
            this.txt_totalPagar.Location = new System.Drawing.Point(815, 362);
            this.txt_totalPagar.Name = "txt_totalPagar";
            this.txt_totalPagar.Size = new System.Drawing.Size(118, 20);
            this.txt_totalPagar.TabIndex = 80;
            this.txt_totalPagar.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_idCliente);
            this.groupBox2.Controls.Add(this.btn_busquedaCliente);
            this.groupBox2.Controls.Add(this.txt_nombreCompleto);
            this.groupBox2.Controls.Add(this.txt_documentoCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_documento);
            this.groupBox2.Location = new System.Drawing.Point(524, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 94);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
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
            this.txt_fecha.Size = new System.Drawing.Size(121, 20);
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
            // dataGrid_detalleVenta
            // 
            this.dataGrid_detalleVenta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_detalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_detalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_detalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.btn_eliminar});
            this.dataGrid_detalleVenta.Location = new System.Drawing.Point(174, 325);
            this.dataGrid_detalleVenta.MultiSelect = false;
            this.dataGrid_detalleVenta.Name = "dataGrid_detalleVenta";
            this.dataGrid_detalleVenta.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_detalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_detalleVenta.RowTemplate.Height = 28;
            this.dataGrid_detalleVenta.Size = new System.Drawing.Size(632, 188);
            this.dataGrid_detalleVenta.TabIndex = 78;
            this.dataGrid_detalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_detalleVenta_CellContentClick);
            this.dataGrid_detalleVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGrid_detalleVenta_CellPainting);
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
            // precio
            // 
            this.precio.HeaderText = "Precio Unitario";
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
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Width = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboDocumento);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(174, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 94);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 21);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(799, 509);
            this.label3.TabIndex = 75;
            this.label3.Text = "Registrar Venta";
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
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Stock:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(536, 51);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(79, 20);
            this.txt_stock.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(416, 51);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(79, 20);
            this.txt_precio.TabIndex = 35;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_idProducto
            // 
            this.txt_idProducto.Location = new System.Drawing.Point(95, 25);
            this.txt_idProducto.Name = "txt_idProducto";
            this.txt_idProducto.Size = new System.Drawing.Size(26, 20);
            this.txt_idProducto.TabIndex = 33;
            this.txt_idProducto.Visible = false;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btn_agregar);
            this.groupBox3.Controls.Add(this.numeric_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_stock);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_precio);
            this.groupBox3.Controls.Add(this.txt_idProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_buscarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_producto);
            this.groupBox3.Controls.Add(this.txt_codProducto);
            this.groupBox3.Location = new System.Drawing.Point(174, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 110);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(812, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Paga con:";
            // 
            // txt_pagaCon
            // 
            this.txt_pagaCon.Location = new System.Drawing.Point(815, 401);
            this.txt_pagaCon.Name = "txt_pagaCon";
            this.txt_pagaCon.Size = new System.Drawing.Size(118, 20);
            this.txt_pagaCon.TabIndex = 84;
            this.txt_pagaCon.Text = "0";
            this.txt_pagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pagaCon_KeyDown);
            this.txt_pagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pagaCon_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(812, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 85;
            this.label12.Text = "Cambio:";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(815, 440);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(118, 20);
            this.txt_cambio.TabIndex = 86;
            this.txt_cambio.Text = "0";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.White;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btn_registrar.IconColor = System.Drawing.Color.MediumTurquoise;
            this.btn_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrar.IconSize = 30;
            this.btn_registrar.Location = new System.Drawing.Point(815, 466);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(118, 46);
            this.btn_registrar.TabIndex = 87;
            this.btn_registrar.Text = "Crear Venta";
            this.btn_registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // frm_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_pagaCon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_totalPagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid_detalleVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "frm_venta";
            this.Text = "frm_venta";
            this.Load += new System.EventHandler(this.frm_venta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detalleVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_idCliente;
        private FontAwesome.Sharp.IconButton btn_busquedaCliente;
        private System.Windows.Forms.TextBox txt_nombreCompleto;
        private System.Windows.Forms.TextBox txt_documentoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_documento;
        private System.Windows.Forms.TextBox txt_totalPagar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboDocumento;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_detalleVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_agregar;
        private System.Windows.Forms.NumericUpDown numeric_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_idProducto;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btn_buscarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_codProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pagaCon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cambio;
        private FontAwesome.Sharp.IconButton btn_registrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
    }
}