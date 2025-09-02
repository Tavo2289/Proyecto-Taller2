namespace Proyecto_Taller2
{
    partial class frm_usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_documentoUsuario = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_contraseñaUsuario = new System.Windows.Forms.Label();
            this.txt_documentoUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellidoUsuario = new System.Windows.Forms.TextBox();
            this.txt_confirmarContraseña = new System.Windows.Forms.TextBox();
            this.lbl_confirmarContraseña = new System.Windows.Forms.Label();
            this.lbl_rolUsuario = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lbl_estadoUsuario = new System.Windows.Forms.Label();
            this.lbl_detallaUsuario = new System.Windows.Forms.Label();
            this.dataGrid_listaUsuario = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.txt_gmail = new System.Windows.Forms.TextBox();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.txt_indice = new System.Windows.Forms.TextBox();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.brt_limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaUsuario)).BeginInit();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_documentoUsuario
            // 
            this.lbl_documentoUsuario.AutoSize = true;
            this.lbl_documentoUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_documentoUsuario.Location = new System.Drawing.Point(52, 148);
            this.lbl_documentoUsuario.Name = "lbl_documentoUsuario";
            this.lbl_documentoUsuario.Size = new System.Drawing.Size(82, 13);
            this.lbl_documentoUsuario.TabIndex = 1;
            this.lbl_documentoUsuario.Text = "Nro Documento";
            this.lbl_documentoUsuario.Click += new System.EventHandler(this.lbl_documentoUsuario_Click);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(52, 63);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "Nombre";
            this.lbl_nombreUsuario.Click += new System.EventHandler(this.lbl_nombreUsuario_Click);
            // 
            // lbl_contraseñaUsuario
            // 
            this.lbl_contraseñaUsuario.AutoSize = true;
            this.lbl_contraseñaUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_contraseñaUsuario.Location = new System.Drawing.Point(53, 236);
            this.lbl_contraseñaUsuario.Name = "lbl_contraseñaUsuario";
            this.lbl_contraseñaUsuario.Size = new System.Drawing.Size(66, 13);
            this.lbl_contraseñaUsuario.TabIndex = 3;
            this.lbl_contraseñaUsuario.Text = "Constraseña";
            this.lbl_contraseñaUsuario.Click += new System.EventHandler(this.lbl_contraseñaUsuario_Click);
            // 
            // txt_documentoUsuario
            // 
            this.txt_documentoUsuario.Location = new System.Drawing.Point(55, 164);
            this.txt_documentoUsuario.Name = "txt_documentoUsuario";
            this.txt_documentoUsuario.Size = new System.Drawing.Size(191, 20);
            this.txt_documentoUsuario.TabIndex = 4;
            this.txt_documentoUsuario.TextChanged += new System.EventHandler(this.txt_documentoUsuario_TextChanged);
            this.txt_documentoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soloNumeros_KeyPress);
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(55, 79);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(191, 20);
            this.txt_nombreUsuario.TabIndex = 5;
            this.txt_nombreUsuario.TextChanged += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            this.txt_nombreUsuario.Leave += new System.EventHandler(this.txtnombreUsuario_Leave);
            // 
            // txt_contraseñaUsuario
            // 
            this.txt_contraseñaUsuario.Location = new System.Drawing.Point(56, 252);
            this.txt_contraseñaUsuario.Name = "txt_contraseñaUsuario";
            this.txt_contraseñaUsuario.PasswordChar = '*';
            this.txt_contraseñaUsuario.Size = new System.Drawing.Size(191, 20);
            this.txt_contraseñaUsuario.TabIndex = 6;
            this.txt_contraseñaUsuario.TextChanged += new System.EventHandler(this.txt_contraseñaUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_apellidoUsuario
            // 
            this.txt_apellidoUsuario.Location = new System.Drawing.Point(55, 118);
            this.txt_apellidoUsuario.Name = "txt_apellidoUsuario";
            this.txt_apellidoUsuario.Size = new System.Drawing.Size(191, 20);
            this.txt_apellidoUsuario.TabIndex = 8;
            this.txt_apellidoUsuario.TextChanged += new System.EventHandler(this.txt_apellidoUsuario_TextChanged);
            this.txt_apellidoUsuario.Leave += new System.EventHandler(this.txtapellidoUsuario_Leave);
            // 
            // txt_confirmarContraseña
            // 
            this.txt_confirmarContraseña.Location = new System.Drawing.Point(56, 303);
            this.txt_confirmarContraseña.Name = "txt_confirmarContraseña";
            this.txt_confirmarContraseña.PasswordChar = '*';
            this.txt_confirmarContraseña.Size = new System.Drawing.Size(191, 20);
            this.txt_confirmarContraseña.TabIndex = 10;
            this.txt_confirmarContraseña.TextChanged += new System.EventHandler(this.txt_confirmarContraseña_TextChanged);
            // 
            // lbl_confirmarContraseña
            // 
            this.lbl_confirmarContraseña.AutoSize = true;
            this.lbl_confirmarContraseña.BackColor = System.Drawing.Color.White;
            this.lbl_confirmarContraseña.Location = new System.Drawing.Point(53, 287);
            this.lbl_confirmarContraseña.Name = "lbl_confirmarContraseña";
            this.lbl_confirmarContraseña.Size = new System.Drawing.Size(113, 13);
            this.lbl_confirmarContraseña.TabIndex = 9;
            this.lbl_confirmarContraseña.Text = "Confirmar Constraseña";
            this.lbl_confirmarContraseña.Click += new System.EventHandler(this.lbl_confirmarContraseña_Click);
            // 
            // lbl_rolUsuario
            // 
            this.lbl_rolUsuario.AutoSize = true;
            this.lbl_rolUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_rolUsuario.Location = new System.Drawing.Point(53, 325);
            this.lbl_rolUsuario.Name = "lbl_rolUsuario";
            this.lbl_rolUsuario.Size = new System.Drawing.Size(23, 13);
            this.lbl_rolUsuario.TabIndex = 11;
            this.lbl_rolUsuario.Text = "Rol";
            this.lbl_rolUsuario.Click += new System.EventHandler(this.lbl_rolUsuario_Click);
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(56, 341);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(191, 21);
            this.comboRol.TabIndex = 12;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.comboRol_SelectedIndexChanged);
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(56, 401);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(191, 21);
            this.comboEstado.TabIndex = 14;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // lbl_estadoUsuario
            // 
            this.lbl_estadoUsuario.AutoSize = true;
            this.lbl_estadoUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_estadoUsuario.Location = new System.Drawing.Point(53, 385);
            this.lbl_estadoUsuario.Name = "lbl_estadoUsuario";
            this.lbl_estadoUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbl_estadoUsuario.TabIndex = 13;
            this.lbl_estadoUsuario.Text = "Estado";
            this.lbl_estadoUsuario.Click += new System.EventHandler(this.lbl_estadoUsuario_Click);
            // 
            // lbl_detallaUsuario
            // 
            this.lbl_detallaUsuario.AutoSize = true;
            this.lbl_detallaUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_detallaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detallaUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_detallaUsuario.Location = new System.Drawing.Point(62, 24);
            this.lbl_detallaUsuario.Name = "lbl_detallaUsuario";
            this.lbl_detallaUsuario.Size = new System.Drawing.Size(144, 25);
            this.lbl_detallaUsuario.TabIndex = 18;
            this.lbl_detallaUsuario.Text = "Detalle Usuario";
            this.lbl_detallaUsuario.Click += new System.EventHandler(this.lbl_detallaUsuario_Click);
            // 
            // dataGrid_listaUsuario
            // 
            this.dataGrid_listaUsuario.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_listaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_listaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.id,
            this.documento,
            this.nombre,
            this.apellido,
            this.gmail,
            this.contraseña,
            this.id_rol,
            this.rol,
            this.estadoValor,
            this.estado});
            this.dataGrid_listaUsuario.Location = new System.Drawing.Point(298, 80);
            this.dataGrid_listaUsuario.MultiSelect = false;
            this.dataGrid_listaUsuario.Name = "dataGrid_listaUsuario";
            this.dataGrid_listaUsuario.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_listaUsuario.RowTemplate.Height = 28;
            this.dataGrid_listaUsuario.Size = new System.Drawing.Size(805, 458);
            this.dataGrid_listaUsuario.TabIndex = 19;
            this.dataGrid_listaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_listaUsuario_CellContentClick);
            this.dataGrid_listaUsuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGrid_listaUsuario_CellPainting);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.HeaderText = "";
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.ReadOnly = true;
            this.btn_seleccionar.Width = 30;
            // 
            // id
            // 
            this.id.HeaderText = "IdUsuario";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // documento
            // 
            this.documento.HeaderText = "Numero Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // gmail
            // 
            this.gmail.HeaderText = "Correo Electronico";
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            this.gmail.Width = 180;
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            this.contraseña.Visible = false;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "IdRol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "Estado Valor";
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 24);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(799, 49);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lista de Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(213, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(33, 20);
            this.txt_id.TabIndex = 21;
            this.txt_id.Text = "0";
            this.txt_id.Visible = false;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(610, 37);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 13);
            this.lbl_buscar.TabIndex = 22;
            this.lbl_buscar.Text = "Buscar Por:";
            this.lbl_buscar.Click += new System.EventHandler(this.lbl_buscar_Click);
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Location = new System.Drawing.Point(678, 34);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(140, 21);
            this.comboBox_busqueda.TabIndex = 23;
            this.comboBox_busqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox_busqueda_SelectedIndexChanged);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(824, 36);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(140, 20);
            this.txt_busqueda.TabIndex = 24;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // txt_gmail
            // 
            this.txt_gmail.Location = new System.Drawing.Point(56, 212);
            this.txt_gmail.Name = "txt_gmail";
            this.txt_gmail.Size = new System.Drawing.Size(191, 20);
            this.txt_gmail.TabIndex = 28;
            this.txt_gmail.TextChanged += new System.EventHandler(this.txt_gmail_TextChanged);
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.BackColor = System.Drawing.Color.White;
            this.lbl_gmail.Location = new System.Drawing.Point(53, 196);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(94, 13);
            this.lbl_gmail.TabIndex = 27;
            this.lbl_gmail.Text = "Correo Electronico";
            this.lbl_gmail.Click += new System.EventHandler(this.lbl_gmail_Click);
            // 
            // txt_indice
            // 
            this.txt_indice.Location = new System.Drawing.Point(173, 52);
            this.txt_indice.Name = "txt_indice";
            this.txt_indice.Size = new System.Drawing.Size(33, 20);
            this.txt_indice.TabIndex = 29;
            this.txt_indice.Text = "0";
            this.txt_indice.Visible = false;
            this.txt_indice.TextChanged += new System.EventHandler(this.txt_indice_TextChanged);
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
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(1042, 34);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 26;
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
            this.btn_busqueda.Location = new System.Drawing.Point(984, 34);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 25;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
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
            this.btn_eliminar.Location = new System.Drawing.Point(56, 514);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(191, 23);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // brt_limpiar
            // 
            this.brt_limpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.brt_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brt_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.brt_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brt_limpiar.ForeColor = System.Drawing.Color.White;
            this.brt_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.brt_limpiar.IconColor = System.Drawing.Color.White;
            this.brt_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.brt_limpiar.IconSize = 18;
            this.brt_limpiar.Location = new System.Drawing.Point(56, 485);
            this.brt_limpiar.Name = "brt_limpiar";
            this.brt_limpiar.Size = new System.Drawing.Size(191, 23);
            this.brt_limpiar.TabIndex = 16;
            this.brt_limpiar.Text = "Limpiar";
            this.brt_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brt_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brt_limpiar.UseVisualStyleBackColor = false;
            this.brt_limpiar.Click += new System.EventHandler(this.brt_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_guardar.IconColor = System.Drawing.Color.White;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 16;
            this.btn_guardar.Location = new System.Drawing.Point(56, 456);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(191, 23);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.txt_indice);
            this.Controls.Add(this.txt_gmail);
            this.Controls.Add(this.lbl_gmail);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid_listaUsuario);
            this.Controls.Add(this.lbl_detallaUsuario);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.brt_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.lbl_estadoUsuario);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.lbl_rolUsuario);
            this.Controls.Add(this.txt_confirmarContraseña);
            this.Controls.Add(this.lbl_confirmarContraseña);
            this.Controls.Add(this.txt_apellidoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_contraseñaUsuario);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.txt_documentoUsuario);
            this.Controls.Add(this.lbl_contraseñaUsuario);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_documentoUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frm_usuarios";
            this.Text = "Formulario Usuario";
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_documentoUsuario;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label lbl_contraseñaUsuario;
        private System.Windows.Forms.TextBox txt_documentoUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.TextBox txt_contraseñaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellidoUsuario;
        private System.Windows.Forms.TextBox txt_confirmarContraseña;
        private System.Windows.Forms.Label lbl_confirmarContraseña;
        private System.Windows.Forms.Label lbl_rolUsuario;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lbl_estadoUsuario;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private FontAwesome.Sharp.IconButton brt_limpiar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.Label lbl_detallaUsuario;
        private System.Windows.Forms.DataGridView dataGrid_listaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox txt_gmail;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.TextBox txt_indice;
    }
}