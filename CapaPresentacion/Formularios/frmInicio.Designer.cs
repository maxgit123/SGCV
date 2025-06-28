namespace CapaPresentacion.Formularios
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuComercio = new FontAwesome.Sharp.IconMenuItem();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.smenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.smenuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.smenuRegistCompra = new FontAwesome.Sharp.IconMenuItem();
            this.smenuDetalleCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.smenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.smenuDetalleVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menuTituloUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuRol = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.menuPrincipal.SuspendLayout();
            this.menuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuComercio,
            this.menuUsuarios,
            this.menuProductos,
            this.menuProveedores,
            this.menuCompras,
            this.menuVentas,
            this.menuClientes});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 48);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1008, 61);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu";
            // 
            // menuComercio
            // 
            this.menuComercio.AutoSize = false;
            this.menuComercio.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuComercio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuComercio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuComercio.IconSize = 38;
            this.menuComercio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuComercio.Name = "menuComercio";
            this.menuComercio.Size = new System.Drawing.Size(80, 57);
            this.menuComercio.Text = "Comercio";
            this.menuComercio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuComercio.Click += new System.EventHandler(this.menuComercio_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.menuUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 38;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(80, 57);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.AutoSize = false;
            this.menuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuProductos,
            this.smenuCategorias});
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked;
            this.menuProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.IconSize = 38;
            this.menuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(80, 57);
            this.menuProductos.Text = "Productos";
            this.menuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // smenuProductos
            // 
            this.smenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.smenuProductos.IconColor = System.Drawing.Color.Black;
            this.smenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.smenuProductos.Name = "smenuProductos";
            this.smenuProductos.Size = new System.Drawing.Size(130, 22);
            this.smenuProductos.Text = "Productos";
            this.smenuProductos.Click += new System.EventHandler(this.smenuProductos_Click);
            // 
            // smenuCategorias
            // 
            this.smenuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.smenuCategorias.IconColor = System.Drawing.Color.Black;
            this.smenuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.smenuCategorias.Name = "smenuCategorias";
            this.smenuCategorias.Size = new System.Drawing.Size(130, 22);
            this.smenuCategorias.Text = "Categorias";
            this.smenuCategorias.Click += new System.EventHandler(this.smenuCategorias_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.AutoSize = false;
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menuProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 38;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(80, 57);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuRegistCompra,
            this.smenuDetalleCompras});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 38;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(80, 57);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // smenuRegistCompra
            // 
            this.smenuRegistCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.smenuRegistCompra.IconColor = System.Drawing.Color.Black;
            this.smenuRegistCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.smenuRegistCompra.Name = "smenuRegistCompra";
            this.smenuRegistCompra.Size = new System.Drawing.Size(166, 22);
            this.smenuRegistCompra.Text = "Registrar Compra";
            this.smenuRegistCompra.Click += new System.EventHandler(this.smenuRegistCompra_Click);
            // 
            // smenuDetalleCompras
            // 
            this.smenuDetalleCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.smenuDetalleCompras.IconColor = System.Drawing.Color.Black;
            this.smenuDetalleCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.smenuDetalleCompras.Name = "smenuDetalleCompras";
            this.smenuDetalleCompras.Size = new System.Drawing.Size(166, 22);
            this.smenuDetalleCompras.Text = "Detalle Compras";
            this.smenuDetalleCompras.Click += new System.EventHandler(this.smenuDetalleCompras_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.AutoSize = false;
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuRegistrarVenta,
            this.smenuDetalleVentas});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.menuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 38;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(80, 57);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // smenuRegistrarVenta
            // 
            this.smenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.smenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.smenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.smenuRegistrarVenta.Name = "smenuRegistrarVenta";
            this.smenuRegistrarVenta.Size = new System.Drawing.Size(180, 22);
            this.smenuRegistrarVenta.Text = "Registrar Venta";
            this.smenuRegistrarVenta.Click += new System.EventHandler(this.smenuRegistrarVenta_Click);
            // 
            // smenuDetalleVentas
            // 
            this.smenuDetalleVentas.Name = "smenuDetalleVentas";
            this.smenuDetalleVentas.Size = new System.Drawing.Size(180, 22);
            this.smenuDetalleVentas.Text = "Lista de Ventas";
            this.smenuDetalleVentas.Click += new System.EventHandler(this.smenuDetalleVentas_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 38;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(80, 57);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTituloUsuario});
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1008, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // menuTituloUsuario
            // 
            this.menuTituloUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuRol,
            this.cambiarClaveToolStripMenuItem,
            this.smenuCerrarSesion});
            this.menuTituloUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTituloUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.menuTituloUsuario.Name = "menuTituloUsuario";
            this.menuTituloUsuario.Size = new System.Drawing.Size(76, 44);
            this.menuTituloUsuario.Text = "Usuario";
            // 
            // smenuRol
            // 
            this.smenuRol.Name = "smenuRol";
            this.smenuRol.Size = new System.Drawing.Size(178, 26);
            this.smenuRol.Text = "Rol";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // smenuCerrarSesion
            // 
            this.smenuCerrarSesion.Name = "smenuCerrarSesion";
            this.smenuCerrarSesion.Size = new System.Drawing.Size(178, 26);
            this.smenuCerrarSesion.Text = "Cerrar sesion";
            this.smenuCerrarSesion.Click += new System.EventHandler(this.smenuCerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de Gestion de Compra y Venta";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.SystemColors.Control;
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(0, 109);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1008, 452);
            this.panelDashboard.TabIndex = 3;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCV";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.menuTitulo.ResumeLayout(false);
            this.menuTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelDashboard;
        private FontAwesome.Sharp.IconMenuItem menuComercio;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuTituloUsuario;
        private System.Windows.Forms.ToolStripMenuItem smenuCerrarSesion;
        private FontAwesome.Sharp.IconMenuItem smenuCategorias;
        private FontAwesome.Sharp.IconMenuItem smenuRegistCompra;
        private System.Windows.Forms.ToolStripMenuItem smenuDetalleVentas;
        private FontAwesome.Sharp.IconMenuItem smenuProductos;
        private System.Windows.Forms.ToolStripMenuItem smenuRol;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem smenuDetalleCompras;
        private FontAwesome.Sharp.IconMenuItem smenuRegistrarVenta;
    }
}