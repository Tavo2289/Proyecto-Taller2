namespace Proyecto_Taller2
{
    partial class Login
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
            this.lbl_tituloLogin = new System.Windows.Forms.Label();
            this.iconLogin = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_domentoLogin = new System.Windows.Forms.Label();
            this.lbl_contraseñaLogin = new System.Windows.Forms.Label();
            this.txt_NroDocumento = new System.Windows.Forms.TextBox();
            this.txt_contraseñaLogin = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 272);
            this.label1.TabIndex = 0;
            // 
            // lbl_tituloLogin
            // 
            this.lbl_tituloLogin.AutoSize = true;
            this.lbl_tituloLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.lbl_tituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloLogin.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloLogin.Location = new System.Drawing.Point(12, 210);
            this.lbl_tituloLogin.Name = "lbl_tituloLogin";
            this.lbl_tituloLogin.Size = new System.Drawing.Size(225, 29);
            this.lbl_tituloLogin.TabIndex = 1;
            this.lbl_tituloLogin.Text = "Sistemas de Ventas";
            // 
            // iconLogin
            // 
            this.iconLogin.BackColor = System.Drawing.Color.SlateBlue;
            this.iconLogin.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconLogin.IconColor = System.Drawing.Color.White;
            this.iconLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogin.IconSize = 139;
            this.iconLogin.Location = new System.Drawing.Point(56, 42);
            this.iconLogin.Name = "iconLogin";
            this.iconLogin.Size = new System.Drawing.Size(142, 139);
            this.iconLogin.TabIndex = 2;
            this.iconLogin.TabStop = false;
            // 
            // lbl_domentoLogin
            // 
            this.lbl_domentoLogin.AutoSize = true;
            this.lbl_domentoLogin.Location = new System.Drawing.Point(309, 55);
            this.lbl_domentoLogin.Name = "lbl_domentoLogin";
            this.lbl_domentoLogin.Size = new System.Drawing.Size(82, 13);
            this.lbl_domentoLogin.TabIndex = 3;
            this.lbl_domentoLogin.Text = "Nro Documento";
            // 
            // lbl_contraseñaLogin
            // 
            this.lbl_contraseñaLogin.AutoSize = true;
            this.lbl_contraseñaLogin.Location = new System.Drawing.Point(309, 133);
            this.lbl_contraseñaLogin.Name = "lbl_contraseñaLogin";
            this.lbl_contraseñaLogin.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseñaLogin.TabIndex = 4;
            this.lbl_contraseñaLogin.Text = "Contraseña";
            // 
            // txt_NroDocumento
            // 
            this.txt_NroDocumento.Location = new System.Drawing.Point(299, 82);
            this.txt_NroDocumento.Name = "txt_NroDocumento";
            this.txt_NroDocumento.Size = new System.Drawing.Size(189, 20);
            this.txt_NroDocumento.TabIndex = 5;
            // 
            // txt_contraseñaLogin
            // 
            this.txt_contraseñaLogin.Location = new System.Drawing.Point(299, 161);
            this.txt_contraseñaLogin.Name = "txt_contraseñaLogin";
            this.txt_contraseñaLogin.PasswordChar = '*';
            this.txt_contraseñaLogin.Size = new System.Drawing.Size(189, 20);
            this.txt_contraseñaLogin.TabIndex = 6;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_ingresar.IconColor = System.Drawing.Color.White;
            this.btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ingresar.IconSize = 21;
            this.btn_ingresar.Location = new System.Drawing.Point(289, 225);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(93, 35);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btn_cancelar.IconColor = System.Drawing.Color.White;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 21;
            this.btn_cancelar.Location = new System.Drawing.Point(407, 225);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 35);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 272);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_contraseñaLogin);
            this.Controls.Add(this.txt_NroDocumento);
            this.Controls.Add(this.lbl_contraseñaLogin);
            this.Controls.Add(this.lbl_domentoLogin);
            this.Controls.Add(this.iconLogin);
            this.Controls.Add(this.lbl_tituloLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.iconLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tituloLogin;
        private FontAwesome.Sharp.IconPictureBox iconLogin;
        private System.Windows.Forms.Label lbl_domentoLogin;
        private System.Windows.Forms.Label lbl_contraseñaLogin;
        private System.Windows.Forms.TextBox txt_NroDocumento;
        private System.Windows.Forms.TextBox txt_contraseñaLogin;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
    }
}