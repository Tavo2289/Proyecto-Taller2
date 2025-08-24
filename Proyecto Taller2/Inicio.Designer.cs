namespace Proyecto_Taller2
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPrinciapl = new System.Windows.Forms.MenuStrip();
            this.iconUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.menuPrinciapl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrinciapl
            // 
            this.menuPrinciapl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconUsuario,
            this.iconMantenedor,
            this.iconVentas,
            this.iconCompras,
            this.iconProveedores,
            this.iconClientes,
            this.iconReportes,
            this.iconAcercaDe});
            this.menuPrinciapl.Location = new System.Drawing.Point(0, 62);
            this.menuPrinciapl.Name = "menuPrinciapl";
            this.menuPrinciapl.Size = new System.Drawing.Size(1012, 73);
            this.menuPrinciapl.TabIndex = 0;
            this.menuPrinciapl.Text = "menuPrincipal";
            // 
            // iconUsuario
            // 
            this.iconUsuario.AutoSize = false;
            this.iconUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconUsuario.IconColor = System.Drawing.Color.Black;
            this.iconUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsuario.IconSize = 50;
            this.iconUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconUsuario.Name = "iconUsuario";
            this.iconUsuario.Size = new System.Drawing.Size(122, 69);
            this.iconUsuario.Text = "Usuarios";
            this.iconUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMantenedor
            // 
            this.iconMantenedor.AutoSize = false;
            this.iconMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iconMantenedor.IconColor = System.Drawing.Color.Black;
            this.iconMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMantenedor.IconSize = 50;
            this.iconMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMantenedor.Name = "iconMantenedor";
            this.iconMantenedor.Size = new System.Drawing.Size(122, 69);
            this.iconMantenedor.Text = "Mantenedor";
            this.iconMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconVentas.IconColor = System.Drawing.Color.Black;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.IconSize = 50;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(122, 69);
            this.iconVentas.Text = "Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconCompras
            // 
            this.iconCompras.AutoSize = false;
            this.iconCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iconCompras.IconColor = System.Drawing.Color.Black;
            this.iconCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCompras.IconSize = 50;
            this.iconCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCompras.Name = "iconCompras";
            this.iconCompras.Size = new System.Drawing.Size(122, 69);
            this.iconCompras.Text = "Compras";
            this.iconCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconProveedores
            // 
            this.iconProveedores.AutoSize = false;
            this.iconProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconProveedores.IconColor = System.Drawing.Color.Black;
            this.iconProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedores.IconSize = 50;
            this.iconProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedores.Name = "iconProveedores";
            this.iconProveedores.Size = new System.Drawing.Size(122, 69);
            this.iconProveedores.Text = "Proveedores";
            this.iconProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconClientes
            // 
            this.iconClientes.AutoSize = false;
            this.iconClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconClientes.IconColor = System.Drawing.Color.Black;
            this.iconClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClientes.IconSize = 50;
            this.iconClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconClientes.Name = "iconClientes";
            this.iconClientes.Size = new System.Drawing.Size(122, 69);
            this.iconClientes.Text = "Clientes";
            this.iconClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconReportes
            // 
            this.iconReportes.AutoSize = false;
            this.iconReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconReportes.IconColor = System.Drawing.Color.Black;
            this.iconReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReportes.IconSize = 50;
            this.iconReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconReportes.Name = "iconReportes";
            this.iconReportes.Size = new System.Drawing.Size(122, 69);
            this.iconReportes.Text = "Reportes";
            this.iconReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconAcercaDe
            // 
            this.iconAcercaDe.AutoSize = false;
            this.iconAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconAcercaDe.IconColor = System.Drawing.Color.Black;
            this.iconAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAcercaDe.IconSize = 50;
            this.iconAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconAcercaDe.Name = "iconAcercaDe";
            this.iconAcercaDe.Size = new System.Drawing.Size(122, 69);
            this.iconAcercaDe.Text = "Acerca De";
            this.iconAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1012, 62);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuTitulo";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.SlateBlue;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(26, 13);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(260, 31);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Sistemas De Ventas";
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 135);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1012, 315);
            this.panel_contenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.menuPrinciapl);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPrinciapl;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuPrinciapl.ResumeLayout(false);
            this.menuPrinciapl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrinciapl;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private FontAwesome.Sharp.IconMenuItem iconAcercaDe;
        private FontAwesome.Sharp.IconMenuItem iconUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMantenedor;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private FontAwesome.Sharp.IconMenuItem iconCompras;
        private FontAwesome.Sharp.IconMenuItem iconProveedores;
        private FontAwesome.Sharp.IconMenuItem iconClientes;
        private FontAwesome.Sharp.IconMenuItem iconReportes;
        private System.Windows.Forms.Panel panel_contenedor;
    }
}

