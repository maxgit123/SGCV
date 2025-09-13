namespace CapaPresentacion.Formularios
{
    partial class frmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.txtProductoCantidad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlFormCompra = new MaterialSkin.Controls.MaterialCard();
            this.btnRegistrarCompra = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtProveedor = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFechaEntrega = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtFechaPedido = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbInfoProducto.SuspendLayout();
            this.pnlFormCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeight = 28;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.descripcion,
            this.precioCompra,
            this.cantidad,
            this.subTotal,
            this.btnEliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductos.Location = new System.Drawing.Point(17, 312);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(777, 214);
            this.dgvProductos.TabIndex = 258;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductos_CellPainting);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID Producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.btnAgregar);
            this.gbInfoProducto.Controls.Add(this.txtProductoCantidad);
            this.gbInfoProducto.Controls.Add(this.txtProductoCodigo);
            this.gbInfoProducto.Controls.Add(this.txtProductoPrecio);
            this.gbInfoProducto.Controls.Add(this.txtProductoDescripcion);
            this.gbInfoProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProducto.ForeColor = System.Drawing.Color.DimGray;
            this.gbInfoProducto.Location = new System.Drawing.Point(17, 177);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(777, 103);
            this.gbInfoProducto.TabIndex = 284;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.btnAgregar.Location = new System.Drawing.Point(654, 42);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(116, 36);
            this.btnAgregar.TabIndex = 334;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtProductoCantidad
            // 
            this.txtProductoCantidad.AnimateReadOnly = false;
            this.txtProductoCantidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductoCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductoCantidad.Depth = 0;
            this.txtProductoCantidad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoCantidad.HideSelection = true;
            this.txtProductoCantidad.LeadingIcon = global::CapaPresentacion.Properties.Resources.subtract_32;
            this.txtProductoCantidad.Location = new System.Drawing.Point(536, 36);
            this.txtProductoCantidad.MaxLength = 50;
            this.txtProductoCantidad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductoCantidad.Name = "txtProductoCantidad";
            this.txtProductoCantidad.PasswordChar = '\0';
            this.txtProductoCantidad.PrefixSuffixText = null;
            this.txtProductoCantidad.ReadOnly = true;
            this.txtProductoCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductoCantidad.SelectedText = "";
            this.txtProductoCantidad.SelectionLength = 0;
            this.txtProductoCantidad.SelectionStart = 0;
            this.txtProductoCantidad.ShortcutsEnabled = true;
            this.txtProductoCantidad.Size = new System.Drawing.Size(111, 48);
            this.txtProductoCantidad.TabIndex = 333;
            this.txtProductoCantidad.TabStop = false;
            this.txtProductoCantidad.Text = "1";
            this.txtProductoCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductoCantidad.TrailingIcon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.txtProductoCantidad.UseSystemPasswordChar = false;
            this.txtProductoCantidad.LeadingIconClick += new System.EventHandler(this.txtProductoCantidad_LeadingIconClick);
            this.txtProductoCantidad.TrailingIconClick += new System.EventHandler(this.txtProductoCantidad_TrailingIconClick);
            // 
            // txtProductoCodigo
            // 
            this.txtProductoCodigo.AnimateReadOnly = false;
            this.txtProductoCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductoCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductoCodigo.Depth = 0;
            this.txtProductoCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoCodigo.HideSelection = true;
            this.txtProductoCodigo.Hint = "Codigo";
            this.txtProductoCodigo.LeadingIcon = null;
            this.txtProductoCodigo.Location = new System.Drawing.Point(7, 36);
            this.txtProductoCodigo.MaxLength = 50;
            this.txtProductoCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.PasswordChar = '\0';
            this.txtProductoCodigo.PrefixSuffixText = null;
            this.txtProductoCodigo.ReadOnly = false;
            this.txtProductoCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductoCodigo.SelectedText = "";
            this.txtProductoCodigo.SelectionLength = 0;
            this.txtProductoCodigo.SelectionStart = 0;
            this.txtProductoCodigo.ShortcutsEnabled = true;
            this.txtProductoCodigo.Size = new System.Drawing.Size(128, 48);
            this.txtProductoCodigo.TabIndex = 330;
            this.txtProductoCodigo.TabStop = false;
            this.txtProductoCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductoCodigo.TrailingIcon = global::CapaPresentacion.Properties.Resources.search_32;
            this.txtProductoCodigo.UseSystemPasswordChar = false;
            this.txtProductoCodigo.TrailingIconClick += new System.EventHandler(this.txtProductoCodigo_TrailingIconClick);
            this.txtProductoCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductoCodigo_KeyDown);
            // 
            // txtProductoPrecio
            // 
            this.txtProductoPrecio.AnimateReadOnly = false;
            this.txtProductoPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductoPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductoPrecio.Depth = 0;
            this.txtProductoPrecio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoPrecio.HideSelection = true;
            this.txtProductoPrecio.Hint = "Precio";
            this.txtProductoPrecio.LeadingIcon = null;
            this.txtProductoPrecio.Location = new System.Drawing.Point(402, 36);
            this.txtProductoPrecio.MaxLength = 50;
            this.txtProductoPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductoPrecio.Name = "txtProductoPrecio";
            this.txtProductoPrecio.PasswordChar = '\0';
            this.txtProductoPrecio.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtProductoPrecio.PrefixSuffixText = "$";
            this.txtProductoPrecio.ReadOnly = false;
            this.txtProductoPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductoPrecio.SelectedText = "";
            this.txtProductoPrecio.SelectionLength = 0;
            this.txtProductoPrecio.SelectionStart = 0;
            this.txtProductoPrecio.ShortcutsEnabled = true;
            this.txtProductoPrecio.Size = new System.Drawing.Size(128, 48);
            this.txtProductoPrecio.TabIndex = 332;
            this.txtProductoPrecio.TabStop = false;
            this.txtProductoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtProductoPrecio.TrailingIcon = null;
            this.txtProductoPrecio.UseSystemPasswordChar = false;
            this.txtProductoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtProductoDescripcion
            // 
            this.txtProductoDescripcion.AnimateReadOnly = false;
            this.txtProductoDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductoDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductoDescripcion.Depth = 0;
            this.txtProductoDescripcion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoDescripcion.HideSelection = true;
            this.txtProductoDescripcion.Hint = "Descripción";
            this.txtProductoDescripcion.LeadingIcon = null;
            this.txtProductoDescripcion.Location = new System.Drawing.Point(141, 36);
            this.txtProductoDescripcion.MaxLength = 50;
            this.txtProductoDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductoDescripcion.Name = "txtProductoDescripcion";
            this.txtProductoDescripcion.PasswordChar = '\0';
            this.txtProductoDescripcion.PrefixSuffixText = null;
            this.txtProductoDescripcion.ReadOnly = false;
            this.txtProductoDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductoDescripcion.SelectedText = "";
            this.txtProductoDescripcion.SelectionLength = 0;
            this.txtProductoDescripcion.SelectionStart = 0;
            this.txtProductoDescripcion.ShortcutsEnabled = true;
            this.txtProductoDescripcion.Size = new System.Drawing.Size(255, 48);
            this.txtProductoDescripcion.TabIndex = 331;
            this.txtProductoDescripcion.TabStop = false;
            this.txtProductoDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductoDescripcion.TrailingIcon = null;
            this.txtProductoDescripcion.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(271, 14);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 41);
            this.lblTitulo.TabIndex = 324;
            this.lblTitulo.Text = "Registrar Compra";
            // 
            // pnlFormCompra
            // 
            this.pnlFormCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlFormCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFormCompra.Controls.Add(this.btnRegistrarCompra);
            this.pnlFormCompra.Controls.Add(this.txtTotal);
            this.pnlFormCompra.Controls.Add(this.materialDivider2);
            this.pnlFormCompra.Controls.Add(this.materialDivider1);
            this.pnlFormCompra.Controls.Add(this.gbInfoProducto);
            this.pnlFormCompra.Controls.Add(this.txtProveedor);
            this.pnlFormCompra.Controls.Add(this.dgvProductos);
            this.pnlFormCompra.Controls.Add(this.lblTitulo);
            this.pnlFormCompra.Controls.Add(this.txtFechaEntrega);
            this.pnlFormCompra.Controls.Add(this.dtpFechaEntrega);
            this.pnlFormCompra.Controls.Add(this.txtFechaPedido);
            this.pnlFormCompra.Controls.Add(this.dtpFechaPedido);
            this.pnlFormCompra.Depth = 0;
            this.pnlFormCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlFormCompra.Location = new System.Drawing.Point(23, 23);
            this.pnlFormCompra.Margin = new System.Windows.Forms.Padding(14);
            this.pnlFormCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFormCompra.Name = "pnlFormCompra";
            this.pnlFormCompra.Padding = new System.Windows.Forms.Padding(14);
            this.pnlFormCompra.Size = new System.Drawing.Size(811, 597);
            this.pnlFormCompra.TabIndex = 325;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCompra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarCompra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarCompra.Depth = 0;
            this.btnRegistrarCompra.HighEmphasis = true;
            this.btnRegistrarCompra.Icon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(668, 538);
            this.btnRegistrarCompra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarCompra.Size = new System.Drawing.Size(127, 36);
            this.btnRegistrarCompra.TabIndex = 335;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarCompra.UseAccentColor = false;
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.AnimateReadOnly = false;
            this.txtTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTotal.Depth = 0;
            this.txtTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.HideSelection = true;
            this.txtTotal.Hint = "Total";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(533, 532);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtTotal.PrefixSuffixText = "$";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(128, 48);
            this.txtTotal.TabIndex = 335;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(17, 289);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(778, 14);
            this.materialDivider2.TabIndex = 330;
            this.materialDivider2.Text = "materialDivider3";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 154);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(778, 14);
            this.materialDivider1.TabIndex = 324;
            this.materialDivider1.Text = "materialDivider3";
            // 
            // txtProveedor
            // 
            this.txtProveedor.AnimateReadOnly = false;
            this.txtProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProveedor.Depth = 0;
            this.txtProveedor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProveedor.HideSelection = true;
            this.txtProveedor.Hint = "Proveedor";
            this.txtProveedor.LeadingIcon = null;
            this.txtProveedor.Location = new System.Drawing.Point(539, 97);
            this.txtProveedor.MaxLength = 50;
            this.txtProveedor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.PrefixSuffixText = null;
            this.txtProveedor.ReadOnly = false;
            this.txtProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.SelectionLength = 0;
            this.txtProveedor.SelectionStart = 0;
            this.txtProveedor.ShortcutsEnabled = true;
            this.txtProveedor.Size = new System.Drawing.Size(255, 48);
            this.txtProveedor.TabIndex = 329;
            this.txtProveedor.TabStop = false;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProveedor.TrailingIcon = global::CapaPresentacion.Properties.Resources.search_32;
            this.txtProveedor.UseSystemPasswordChar = false;
            this.txtProveedor.TrailingIconClick += new System.EventHandler(this.txtProveedor_TrailingIconClick);
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.AllowPromptAsInput = true;
            this.txtFechaEntrega.AnimateReadOnly = false;
            this.txtFechaEntrega.AsciiOnly = false;
            this.txtFechaEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaEntrega.BeepOnError = false;
            this.txtFechaEntrega.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFechaEntrega.Depth = 0;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaEntrega.HidePromptOnLeave = false;
            this.txtFechaEntrega.HideSelection = true;
            this.txtFechaEntrega.Hint = "Fecha de entrega";
            this.txtFechaEntrega.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFechaEntrega.LeadingIcon = null;
            this.txtFechaEntrega.Location = new System.Drawing.Point(278, 97);
            this.txtFechaEntrega.Mask = "00/00/0000";
            this.txtFechaEntrega.MaxLength = 32767;
            this.txtFechaEntrega.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.PasswordChar = '\0';
            this.txtFechaEntrega.PrefixSuffixText = null;
            this.txtFechaEntrega.PromptChar = '_';
            this.txtFechaEntrega.ReadOnly = false;
            this.txtFechaEntrega.RejectInputOnFirstFailure = false;
            this.txtFechaEntrega.ResetOnPrompt = true;
            this.txtFechaEntrega.ResetOnSpace = true;
            this.txtFechaEntrega.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaEntrega.SelectedText = "";
            this.txtFechaEntrega.SelectionLength = 0;
            this.txtFechaEntrega.SelectionStart = 0;
            this.txtFechaEntrega.ShortcutsEnabled = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(255, 48);
            this.txtFechaEntrega.SkipLiterals = true;
            this.txtFechaEntrega.TabIndex = 327;
            this.txtFechaEntrega.TabStop = false;
            this.txtFechaEntrega.Text = "  /  /";
            this.txtFechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaEntrega.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFechaEntrega.TrailingIcon = global::CapaPresentacion.Properties.Resources.calendar_32;
            this.txtFechaEntrega.UseSystemPasswordChar = false;
            this.txtFechaEntrega.ValidatingType = null;
            this.txtFechaEntrega.TrailingIconClick += new System.EventHandler(this.txtFechaEntrega_TrailingIconClick);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(278, 114);
            this.dtpFechaEntrega.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(255, 31);
            this.dtpFechaEntrega.TabIndex = 328;
            this.dtpFechaEntrega.ValueChanged += new System.EventHandler(this.dtpFechaEntrega_ValueChanged);
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.AllowPromptAsInput = true;
            this.txtFechaPedido.AnimateReadOnly = false;
            this.txtFechaPedido.AsciiOnly = false;
            this.txtFechaPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaPedido.BeepOnError = false;
            this.txtFechaPedido.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFechaPedido.Depth = 0;
            this.txtFechaPedido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaPedido.HidePromptOnLeave = false;
            this.txtFechaPedido.HideSelection = true;
            this.txtFechaPedido.Hint = "Fecha de pedido";
            this.txtFechaPedido.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFechaPedido.LeadingIcon = null;
            this.txtFechaPedido.Location = new System.Drawing.Point(17, 97);
            this.txtFechaPedido.Mask = "00/00/0000";
            this.txtFechaPedido.MaxLength = 32767;
            this.txtFechaPedido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.PasswordChar = '\0';
            this.txtFechaPedido.PrefixSuffixText = null;
            this.txtFechaPedido.PromptChar = '_';
            this.txtFechaPedido.ReadOnly = false;
            this.txtFechaPedido.RejectInputOnFirstFailure = false;
            this.txtFechaPedido.ResetOnPrompt = true;
            this.txtFechaPedido.ResetOnSpace = true;
            this.txtFechaPedido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaPedido.SelectedText = "";
            this.txtFechaPedido.SelectionLength = 0;
            this.txtFechaPedido.SelectionStart = 0;
            this.txtFechaPedido.ShortcutsEnabled = true;
            this.txtFechaPedido.Size = new System.Drawing.Size(255, 48);
            this.txtFechaPedido.SkipLiterals = true;
            this.txtFechaPedido.TabIndex = 325;
            this.txtFechaPedido.TabStop = false;
            this.txtFechaPedido.Text = "  /  /";
            this.txtFechaPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaPedido.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFechaPedido.TrailingIcon = global::CapaPresentacion.Properties.Resources.calendar_32;
            this.txtFechaPedido.UseSystemPasswordChar = false;
            this.txtFechaPedido.ValidatingType = null;
            this.txtFechaPedido.TrailingIconClick += new System.EventHandler(this.txtFechaPedido_TrailingIconClick);
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(17, 114);
            this.dtpFechaPedido.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(255, 31);
            this.dtpFechaPedido.TabIndex = 326;
            this.dtpFechaPedido.ValueChanged += new System.EventHandler(this.dtpFechaPedido_ValueChanged);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(857, 643);
            this.Controls.Add(this.pnlFormCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            this.pnlFormCompra.ResumeLayout(false);
            this.pnlFormCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialCard pnlFormCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtFechaPedido;
        private MaterialSkin.Controls.MaterialTextBox2 txtProveedor;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoCodigo;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoDescripcion;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoCantidad;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialButton btnRegistrarCompra;
    }
}