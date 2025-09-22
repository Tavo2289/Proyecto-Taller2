namespace Proyecto_Taller2
{
    partial class frm_negocio
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
            this.lbl_detallaUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new FontAwesome.Sharp.IconButton();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_subirLogo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_detallaUsuario
            // 
            this.lbl_detallaUsuario.AutoSize = true;
            this.lbl_detallaUsuario.BackColor = System.Drawing.Color.White;
            this.lbl_detallaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detallaUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_detallaUsuario.Location = new System.Drawing.Point(62, 34);
            this.lbl_detallaUsuario.Name = "lbl_detallaUsuario";
            this.lbl_detallaUsuario.Size = new System.Drawing.Size(149, 25);
            this.lbl_detallaUsuario.TabIndex = 20;
            this.lbl_detallaUsuario.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 550);
            this.label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ruc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_subirLogo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pic_logo);
            this.groupBox1.Location = new System.Drawing.Point(23, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 444);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.White;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_guardar.IconColor = System.Drawing.Color.Black;
            this.btn_guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_guardar.IconSize = 16;
            this.btn_guardar.Location = new System.Drawing.Point(291, 187);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_guardar.Size = new System.Drawing.Size(293, 25);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar Cambios";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(291, 145);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(293, 20);
            this.txt_direccion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(291, 97);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(293, 20);
            this.txt_ruc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "R.U.C";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(291, 48);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(300, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Negocio";
            // 
            // btn_subirLogo
            // 
            this.btn_subirLogo.BackColor = System.Drawing.Color.White;
            this.btn_subirLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_subirLogo.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_subirLogo.IconColor = System.Drawing.Color.Black;
            this.btn_subirLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_subirLogo.IconSize = 16;
            this.btn_subirLogo.Location = new System.Drawing.Point(34, 187);
            this.btn_subirLogo.Name = "btn_subirLogo";
            this.btn_subirLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_subirLogo.Size = new System.Drawing.Size(154, 25);
            this.btn_subirLogo.TabIndex = 2;
            this.btn_subirLogo.Text = "Subir";
            this.btn_subirLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_subirLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_subirLogo.UseVisualStyleBackColor = false;
            this.btn_subirLogo.Click += new System.EventHandler(this.btn_subirLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // pic_logo
            // 
            this.pic_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_logo.Location = new System.Drawing.Point(31, 32);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(157, 142);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // frm_negocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_detallaUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frm_negocio";
            this.Text = "frm_negocio";
            this.Load += new System.EventHandler(this.frm_negocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_detallaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btn_subirLogo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ruc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_guardar;
    }
}