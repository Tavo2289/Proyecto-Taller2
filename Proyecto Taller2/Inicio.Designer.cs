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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.iconUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.iconMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenu_categoria = new FontAwesome.Sharp.IconMenuItem();
            this.subMenu_producto = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iconClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iconReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.lbl_tituloUsuario = new System.Windows.Forms.Label();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.subMenu_registrar = new FontAwesome.Sharp.IconMenuItem();
            this.subMenu_verDetalles = new FontAwesome.Sharp.IconMenuItem();
            this.subMenu_registrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMenu_verDetallesCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconUsuario,
            this.iconMantenedor,
            this.iconVentas,
            this.iconCompras,
            this.iconProveedores,
            this.iconClientes,
            this.iconReportes,
            this.iconAcercaDe});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 62);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1003, 73);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
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
            this.iconUsuario.Click += new System.EventHandler(this.iconUsuario_Click);
            // 
            // iconMantenedor
            // 
            this.iconMantenedor.AutoSize = false;
            this.iconMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_categoria,
            this.subMenu_producto});
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
            // subMenu_categoria
            // 
            this.subMenu_categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_categoria.IconColor = System.Drawing.Color.Black;
            this.subMenu_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_categoria.Name = "subMenu_categoria";
            this.subMenu_categoria.Size = new System.Drawing.Size(180, 22);
            this.subMenu_categoria.Text = "Categoria";
            this.subMenu_categoria.Click += new System.EventHandler(this.subMenu_categoria_Click);
            // 
            // subMenu_producto
            // 
            this.subMenu_producto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_producto.IconColor = System.Drawing.Color.Black;
            this.subMenu_producto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_producto.Name = "subMenu_producto";
            this.subMenu_producto.Size = new System.Drawing.Size(180, 22);
            this.subMenu_producto.Text = "Producto";
            this.subMenu_producto.Click += new System.EventHandler(this.subMenu_producto_Click);
            // 
            // iconVentas
            // 
            this.iconVentas.AutoSize = false;
            this.iconVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_registrar,
            this.subMenu_verDetalles});
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
            this.iconCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_registrarCompra,
            this.subMenu_verDetallesCompra});
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
            this.iconProveedores.Click += new System.EventHandler(this.iconProveedores_Click);
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
            this.iconClientes.Click += new System.EventHandler(this.iconClientes_Click);
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
            this.iconReportes.Click += new System.EventHandler(this.iconReportes_Click);
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
            this.menuTitulo.Size = new System.Drawing.Size(1003, 62);
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
            this.panel_contenedor.Size = new System.Drawing.Size(1003, 338);
            this.panel_contenedor.TabIndex = 3;
            // 
            // lbl_tituloUsuario
            // 
            this.lbl_tituloUsuario.AutoSize = true;
            this.lbl_tituloUsuario.BackColor = System.Drawing.Color.SlateBlue;
            this.lbl_tituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_tituloUsuario.Location = new System.Drawing.Point(806, 13);
            this.lbl_tituloUsuario.Name = "lbl_tituloUsuario";
            this.lbl_tituloUsuario.Size = new System.Drawing.Size(68, 18);
            this.lbl_tituloUsuario.TabIndex = 4;
            this.lbl_tituloUsuario.Text = "Usuario: ";
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.BackColor = System.Drawing.Color.SlateBlue;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(868, 13);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(82, 18);
            this.lbl_nombreUsuario.TabIndex = 5;
            this.lbl_nombreUsuario.Text = "lbl_Usuario";
            this.lbl_nombreUsuario.Click += new System.EventHandler(this.lbl_nombreUsuario_Click);
            // 
            // subMenu_registrar
            // 
            this.subMenu_registrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_registrar.IconColor = System.Drawing.Color.Black;
            this.subMenu_registrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_registrar.Name = "subMenu_registrar";
            this.subMenu_registrar.Size = new System.Drawing.Size(180, 22);
            this.subMenu_registrar.Text = "Registrar";
            this.subMenu_registrar.Click += new System.EventHandler(this.subMenu_registrar_Click);
            // 
            // subMenu_verDetalles
            // 
            this.subMenu_verDetalles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_verDetalles.IconColor = System.Drawing.Color.Black;
            this.subMenu_verDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_verDetalles.Name = "subMenu_verDetalles";
            this.subMenu_verDetalles.Size = new System.Drawing.Size(180, 22);
            this.subMenu_verDetalles.Text = "Ver Detalles";
            this.subMenu_verDetalles.Click += new System.EventHandler(this.subMenu_verDetalles_Click);
            // 
            // subMenu_registrarCompra
            // 
            this.subMenu_registrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_registrarCompra.IconColor = System.Drawing.Color.Black;
            this.subMenu_registrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_registrarCompra.Name = "subMenu_registrarCompra";
            this.subMenu_registrarCompra.Size = new System.Drawing.Size(180, 22);
            this.subMenu_registrarCompra.Text = "Registrar ";
            this.subMenu_registrarCompra.Click += new System.EventHandler(this.subMenu_registrarCompra_Click);
            // 
            // subMenu_verDetallesCompra
            // 
            this.subMenu_verDetallesCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenu_verDetallesCompra.IconColor = System.Drawing.Color.Black;
            this.subMenu_verDetallesCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenu_verDetallesCompra.Name = "subMenu_verDetallesCompra";
            this.subMenu_verDetallesCompra.Size = new System.Drawing.Size(180, 22);
            this.subMenu_verDetallesCompra.Text = "Ver Detalles";
            this.subMenu_verDetallesCompra.Click += new System.EventHandler(this.subMenu_verDetallesCompra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 473);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.lbl_tituloUsuario);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
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
        private System.Windows.Forms.Label lbl_tituloUsuario;
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private FontAwesome.Sharp.IconMenuItem subMenu_categoria;
        private FontAwesome.Sharp.IconMenuItem subMenu_producto;
        private FontAwesome.Sharp.IconMenuItem subMenu_registrar;
        private FontAwesome.Sharp.IconMenuItem subMenu_verDetalles;
        private FontAwesome.Sharp.IconMenuItem subMenu_registrarCompra;
        private FontAwesome.Sharp.IconMenuItem subMenu_verDetallesCompra;
    }
}

