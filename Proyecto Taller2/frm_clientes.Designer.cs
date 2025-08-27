namespace Proyecto_Taller2
{
    partial class frm_clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.brt_editar = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nombeCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreApellido = new System.Windows.Forms.TextBox();
            this.txt_documentoApellido = new System.Windows.Forms.TextBox();
            this.txt_telefonoCliente = new System.Windows.Forms.TextBox();
            this.txt_direccionCliente = new System.Windows.Forms.TextBox();
            this.txt_correoCliente = new System.Windows.Forms.TextBox();
            this.lbl_estadoCliente = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_tituloLista = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 550);
            this.label1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(33, 428);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(191, 23);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Guardar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // brt_editar
            // 
            this.brt_editar.BackColor = System.Drawing.Color.RoyalBlue;
            this.brt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brt_editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brt_editar.ForeColor = System.Drawing.Color.White;
            this.brt_editar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.brt_editar.IconColor = System.Drawing.Color.White;
            this.brt_editar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brt_editar.IconSize = 16;
            this.brt_editar.Location = new System.Drawing.Point(33, 466);
            this.brt_editar.Name = "brt_editar";
            this.brt_editar.Size = new System.Drawing.Size(191, 23);
            this.brt_editar.TabIndex = 32;
            this.brt_editar.Text = "Editar";
            this.brt_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brt_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brt_editar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_eliminar.IconColor = System.Drawing.Color.White;
            this.btn_eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_eliminar.IconSize = 16;
            this.btn_eliminar.Location = new System.Drawing.Point(33, 506);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(191, 23);
            this.btn_eliminar.TabIndex = 33;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Detalle Cliente";
            // 
            // lbl_nombeCliente
            // 
            this.lbl_nombeCliente.AutoSize = true;
            this.lbl_nombeCliente.BackColor = System.Drawing.Color.White;
            this.lbl_nombeCliente.Location = new System.Drawing.Point(33, 81);
            this.lbl_nombeCliente.Name = "lbl_nombeCliente";
            this.lbl_nombeCliente.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombeCliente.TabIndex = 35;
            this.lbl_nombeCliente.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nro Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(33, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Correo";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(33, 97);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_nombreCliente.TabIndex = 41;
            // 
            // txt_nombreApellido
            // 
            this.txt_nombreApellido.Location = new System.Drawing.Point(33, 145);
            this.txt_nombreApellido.Name = "txt_nombreApellido";
            this.txt_nombreApellido.Size = new System.Drawing.Size(191, 20);
            this.txt_nombreApellido.TabIndex = 42;
            // 
            // txt_documentoApellido
            // 
            this.txt_documentoApellido.Location = new System.Drawing.Point(33, 197);
            this.txt_documentoApellido.Name = "txt_documentoApellido";
            this.txt_documentoApellido.Size = new System.Drawing.Size(191, 20);
            this.txt_documentoApellido.TabIndex = 43;
            // 
            // txt_telefonoCliente
            // 
            this.txt_telefonoCliente.Location = new System.Drawing.Point(33, 243);
            this.txt_telefonoCliente.Name = "txt_telefonoCliente";
            this.txt_telefonoCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_telefonoCliente.TabIndex = 44;
            // 
            // txt_direccionCliente
            // 
            this.txt_direccionCliente.Location = new System.Drawing.Point(33, 294);
            this.txt_direccionCliente.Name = "txt_direccionCliente";
            this.txt_direccionCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_direccionCliente.TabIndex = 45;
            // 
            // txt_correoCliente
            // 
            this.txt_correoCliente.Location = new System.Drawing.Point(33, 339);
            this.txt_correoCliente.Name = "txt_correoCliente";
            this.txt_correoCliente.Size = new System.Drawing.Size(191, 20);
            this.txt_correoCliente.TabIndex = 46;
            // 
            // lbl_estadoCliente
            // 
            this.lbl_estadoCliente.AutoSize = true;
            this.lbl_estadoCliente.BackColor = System.Drawing.Color.White;
            this.lbl_estadoCliente.Location = new System.Drawing.Point(33, 376);
            this.lbl_estadoCliente.Name = "lbl_estadoCliente";
            this.lbl_estadoCliente.Size = new System.Drawing.Size(40, 13);
            this.lbl_estadoCliente.TabIndex = 47;
            this.lbl_estadoCliente.Text = "Estado";
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(36, 393);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(188, 21);
            this.comboBox_cliente.TabIndex = 48;
            // 
            // lbl_tituloLista
            // 
            this.lbl_tituloLista.BackColor = System.Drawing.Color.White;
            this.lbl_tituloLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloLista.Location = new System.Drawing.Point(304, 24);
            this.lbl_tituloLista.Name = "lbl_tituloLista";
            this.lbl_tituloLista.Size = new System.Drawing.Size(799, 49);
            this.lbl_tituloLista.TabIndex = 49;
            this.lbl_tituloLista.Text = "Lista de Cliente";
            this.lbl_tituloLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.idCliente,
            this.nombre,
            this.apellido,
            this.nro_documento,
            this.telefono,
            this.direccion,
            this.correo,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(298, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 458);
            this.dataGridView1.TabIndex = 19;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Width = 30;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "id_cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nro_documento
            // 
            this.nro_documento.HeaderText = "Numero Documento";
            this.nro_documento.Name = "nro_documento";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_tituloLista);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.lbl_estadoCliente);
            this.Controls.Add(this.txt_correoCliente);
            this.Controls.Add(this.txt_direccionCliente);
            this.Controls.Add(this.txt_telefonoCliente);
            this.Controls.Add(this.txt_documentoApellido);
            this.Controls.Add(this.txt_nombreApellido);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nombeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.brt_editar);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Name = "frm_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton brt_editar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nombeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_nombreApellido;
        private System.Windows.Forms.TextBox txt_documentoApellido;
        private System.Windows.Forms.TextBox txt_telefonoCliente;
        private System.Windows.Forms.TextBox txt_direccionCliente;
        private System.Windows.Forms.TextBox txt_correoCliente;
        private System.Windows.Forms.Label lbl_estadoCliente;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Label lbl_tituloLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}