namespace Proyecto_Taller2
{
    partial class frm_categoria
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
            this.txt_indice = new System.Windows.Forms.TextBox();
            this.btn_limpiarBusqueda = new FontAwesome.Sharp.IconButton();
            this.btn_busqueda = new FontAwesome.Sharp.IconButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.comboBox_busqueda = new System.Windows.Forms.ComboBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.btn_eliminar = new FontAwesome.Sharp.IconButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lblListaCategorias = new System.Windows.Forms.Label();
            this.btn_limpiar = new FontAwesome.Sharp.IconButton();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.dataGrid_listaCategoria = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_detalleCategoria = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lbl_estadoUsuario = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_indice
            // 
            this.txt_indice.Location = new System.Drawing.Point(163, 52);
            this.txt_indice.Name = "txt_indice";
            this.txt_indice.Size = new System.Drawing.Size(33, 20);
            this.txt_indice.TabIndex = 59;
            this.txt_indice.Text = "0";
            this.txt_indice.Visible = false;
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
            this.btn_limpiarBusqueda.Location = new System.Drawing.Point(1048, 34);
            this.btn_limpiarBusqueda.Name = "btn_limpiarBusqueda";
            this.btn_limpiarBusqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_limpiarBusqueda.TabIndex = 56;
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
            this.btn_busqueda.Location = new System.Drawing.Point(990, 34);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(40, 23);
            this.btn_busqueda.TabIndex = 55;
            this.btn_busqueda.UseVisualStyleBackColor = false;
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(830, 36);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(140, 20);
            this.txt_busqueda.TabIndex = 54;
            // 
            // comboBox_busqueda
            // 
            this.comboBox_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_busqueda.FormattingEnabled = true;
            this.comboBox_busqueda.Location = new System.Drawing.Point(684, 34);
            this.comboBox_busqueda.Name = "comboBox_busqueda";
            this.comboBox_busqueda.Size = new System.Drawing.Size(140, 21);
            this.comboBox_busqueda.TabIndex = 53;
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(616, 37);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(62, 13);
            this.lbl_buscar.TabIndex = 52;
            this.lbl_buscar.Text = "Buscar Por:";
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
            this.btn_eliminar.Location = new System.Drawing.Point(45, 243);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(191, 23);
            this.btn_eliminar.TabIndex = 47;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(203, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(33, 20);
            this.txt_id.TabIndex = 51;
            this.txt_id.Text = "0";
            this.txt_id.Visible = false;
            // 
            // lblListaCategorias
            // 
            this.lblListaCategorias.BackColor = System.Drawing.Color.White;
            this.lblListaCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListaCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCategorias.Location = new System.Drawing.Point(310, 24);
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblListaCategorias.Size = new System.Drawing.Size(799, 49);
            this.lblListaCategorias.TabIndex = 50;
            this.lblListaCategorias.Text = "Lista de Categorias";
            this.lblListaCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiar.IconColor = System.Drawing.Color.White;
            this.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar.IconSize = 18;
            this.btn_limpiar.Location = new System.Drawing.Point(45, 214);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(191, 23);
            this.btn_limpiar.TabIndex = 46;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
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
            this.btn_guardar.Location = new System.Drawing.Point(45, 185);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(191, 23);
            this.btn_guardar.TabIndex = 45;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dataGrid_listaCategoria
            // 
            this.dataGrid_listaCategoria.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_listaCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_listaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_listaCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_seleccionar,
            this.id,
            this.Descripcion,
            this.estadoValor,
            this.estado});
            this.dataGrid_listaCategoria.Location = new System.Drawing.Point(310, 80);
            this.dataGrid_listaCategoria.MultiSelect = false;
            this.dataGrid_listaCategoria.Name = "dataGrid_listaCategoria";
            this.dataGrid_listaCategoria.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid_listaCategoria.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_listaCategoria.RowTemplate.Height = 28;
            this.dataGrid_listaCategoria.Size = new System.Drawing.Size(799, 298);
            this.dataGrid_listaCategoria.TabIndex = 49;
            this.dataGrid_listaCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_lista_CellContentClick);
            this.dataGrid_listaCategoria.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGrid_lista_CellPainting);
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
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 180;
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
            // lbl_detalleCategoria
            // 
            this.lbl_detalleCategoria.AutoSize = true;
            this.lbl_detalleCategoria.BackColor = System.Drawing.Color.White;
            this.lbl_detalleCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalleCategoria.ForeColor = System.Drawing.Color.Black;
            this.lbl_detalleCategoria.Location = new System.Drawing.Point(52, 24);
            this.lbl_detalleCategoria.Name = "lbl_detalleCategoria";
            this.lbl_detalleCategoria.Size = new System.Drawing.Size(162, 25);
            this.lbl_detalleCategoria.TabIndex = 48;
            this.lbl_detalleCategoria.Text = "Detalle Categoria";
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(45, 130);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(191, 21);
            this.comboEstado.TabIndex = 44;
            // 
            // lbl_estadoUsuario
            // 
            this.lbl_estadoUsuario.AutoSize = true;
            this.lbl_estadoUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_estadoUsuario.Location = new System.Drawing.Point(42, 114);
            this.lbl_estadoUsuario.Name = "lbl_estadoUsuario";
            this.lbl_estadoUsuario.Size = new System.Drawing.Size(40, 13);
            this.lbl_estadoUsuario.TabIndex = 43;
            this.lbl_estadoUsuario.Text = "Estado";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(45, 80);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(191, 20);
            this.txt_descripcion.TabIndex = 35;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(42, 63);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 406);
            this.label1.TabIndex = 30;
            // 
            // frm_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 406);
            this.Controls.Add(this.txt_indice);
            this.Controls.Add(this.btn_limpiarBusqueda);
            this.Controls.Add(this.btn_busqueda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.comboBox_busqueda);
            this.Controls.Add(this.lbl_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lblListaCategorias);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.dataGrid_listaCategoria);
            this.Controls.Add(this.lbl_detalleCategoria);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.lbl_estadoUsuario);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "frm_categoria";
            this.Text = "Formulario Categoria";
            this.Load += new System.EventHandler(this.frm_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_listaCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_indice;
        private FontAwesome.Sharp.IconButton btn_limpiarBusqueda;
        private FontAwesome.Sharp.IconButton btn_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.ComboBox comboBox_busqueda;
        private System.Windows.Forms.Label lbl_buscar;
        private FontAwesome.Sharp.IconButton btn_eliminar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lblListaCategorias;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private FontAwesome.Sharp.IconButton btn_guardar;
        private System.Windows.Forms.DataGridView dataGrid_listaCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label lbl_detalleCategoria;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label lbl_estadoUsuario;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label1;
    }
}