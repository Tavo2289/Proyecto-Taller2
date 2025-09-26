namespace Proyecto_Taller2
{
    partial class frm_copiaSeguridad
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new FontAwesome.Sharp.IconButton();
            this.btn_ruta = new FontAwesome.Sharp.IconButton();
            this.btn_backup = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombreArchivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombreServidor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copia de Seguridad de Base de Datos SQL Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(48, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruta Destino";
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(142, 33);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(450, 20);
            this.txt_ruta.TabIndex = 3;
            // 
            // cmbBaseDatos
            // 
            this.cmbBaseDatos.FormattingEnabled = true;
            this.cmbBaseDatos.Location = new System.Drawing.Point(17, 78);
            this.cmbBaseDatos.Name = "cmbBaseDatos";
            this.cmbBaseDatos.Size = new System.Drawing.Size(235, 21);
            this.cmbBaseDatos.TabIndex = 4;
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.White;
            this.btn_conectar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_conectar.IconColor = System.Drawing.Color.Black;
            this.btn_conectar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_conectar.Location = new System.Drawing.Point(190, 118);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(118, 42);
            this.btn_conectar.TabIndex = 5;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btn_ruta
            // 
            this.btn_ruta.BackColor = System.Drawing.Color.White;
            this.btn_ruta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ruta.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_ruta.IconColor = System.Drawing.Color.Black;
            this.btn_ruta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ruta.IconSize = 20;
            this.btn_ruta.Location = new System.Drawing.Point(606, 29);
            this.btn_ruta.Name = "btn_ruta";
            this.btn_ruta.Size = new System.Drawing.Size(118, 24);
            this.btn_ruta.TabIndex = 6;
            this.btn_ruta.Text = "Ruta";
            this.btn_ruta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ruta.UseVisualStyleBackColor = false;
            this.btn_ruta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.White;
            this.btn_backup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.btn_backup.IconColor = System.Drawing.Color.Black;
            this.btn_backup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_backup.IconSize = 35;
            this.btn_backup.Location = new System.Drawing.Point(606, 130);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(118, 42);
            this.btn_backup.TabIndex = 7;
            this.btn_backup.Text = "Backup";
            this.btn_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(26, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del Archivo";
            // 
            // txt_nombreArchivo
            // 
            this.txt_nombreArchivo.Location = new System.Drawing.Point(142, 78);
            this.txt_nombreArchivo.Name = "txt_nombreArchivo";
            this.txt_nombreArchivo.Size = new System.Drawing.Size(451, 20);
            this.txt_nombreArchivo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(218, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(795, 434);
            this.label5.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.cmbBaseDatos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_conectar);
            this.groupBox1.Location = new System.Drawing.Point(644, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 195);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión y Selección de Base de Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.txt_contraseña);
            this.groupBox2.Controls.Add(this.txt_nombreUsuario);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_nombreServidor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(228, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 195);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion de Servidor y Autentificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre Servidor";
            // 
            // txt_nombreServidor
            // 
            this.txt_nombreServidor.Location = new System.Drawing.Point(110, 48);
            this.txt_nombreServidor.Name = "txt_nombreServidor";
            this.txt_nombreServidor.Size = new System.Drawing.Size(182, 20);
            this.txt_nombreServidor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(59, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(43, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contraseña";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(110, 83);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(182, 20);
            this.txt_nombreUsuario.TabIndex = 16;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(110, 115);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(182, 20);
            this.txt_contraseña.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.btn_ruta);
            this.groupBox3.Controls.Add(this.btn_limpiar);
            this.groupBox3.Controls.Add(this.txt_ruta);
            this.groupBox3.Controls.Add(this.btn_backup);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_nombreArchivo);
            this.groupBox3.Location = new System.Drawing.Point(228, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 204);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccion de Ruta";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.White;
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiar.IconColor = System.Drawing.Color.Black;
            this.btn_limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar.IconSize = 35;
            this.btn_limpiar.Location = new System.Drawing.Point(455, 130);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(118, 42);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 162);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(533, 175);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // frm_copiaSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "frm_copiaSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_copiaSeguridad";
            this.Load += new System.EventHandler(this.frm_copiaSeguridad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.ComboBox cmbBaseDatos;
        private FontAwesome.Sharp.IconButton btn_conectar;
        private FontAwesome.Sharp.IconButton btn_ruta;
        private FontAwesome.Sharp.IconButton btn_backup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombreArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombreServidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btn_limpiar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}