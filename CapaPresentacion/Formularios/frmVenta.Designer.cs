namespace CapaPresentacion.Formularios
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbVenta = new System.Windows.Forms.GroupBox();
            this.cbTipoFactura = new MaterialSkin.Controls.MaterialComboBox();
            this.txtVentaFecha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtClienteNombreCompleto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtClienteDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlVenta = new MaterialSkin.Controls.MaterialCard();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPago = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtVuelto = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnRegistrarVenta = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtProductoStock = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.txtProductoCantidad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoCodigo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtProductoDescripcion = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbVenta.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlVenta.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVenta
            // 
            this.gbVenta.Controls.Add(this.cbTipoFactura);
            this.gbVenta.Controls.Add(this.txtVentaFecha);
            this.gbVenta.Controls.Add(this.dtpFechaVenta);
            this.gbVenta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVenta.ForeColor = System.Drawing.Color.DimGray;
            this.gbVenta.Location = new System.Drawing.Point(17, 102);
            this.gbVenta.Name = "gbVenta";
            this.gbVenta.Size = new System.Drawing.Size(339, 85);
            this.gbVenta.TabIndex = 295;
            this.gbVenta.TabStop = false;
            this.gbVenta.Text = "Venta";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.AutoResize = false;
            this.cbTipoFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTipoFactura.Depth = 0;
            this.cbTipoFactura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbTipoFactura.DropDownHeight = 174;
            this.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFactura.DropDownWidth = 121;
            this.cbTipoFactura.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbTipoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Hint = "Tipo de factura";
            this.cbTipoFactura.IntegralHeight = false;
            this.cbTipoFactura.ItemHeight = 43;
            this.cbTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbTipoFactura.Location = new System.Drawing.Point(170, 25);
            this.cbTipoFactura.MaxDropDownItems = 4;
            this.cbTipoFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(154, 49);
            this.cbTipoFactura.StartIndex = 0;
            this.cbTipoFactura.TabIndex = 329;
            // 
            // txtVentaFecha
            // 
            this.txtVentaFecha.AllowPromptAsInput = true;
            this.txtVentaFecha.AnimateReadOnly = false;
            this.txtVentaFecha.AsciiOnly = false;
            this.txtVentaFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVentaFecha.BeepOnError = false;
            this.txtVentaFecha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtVentaFecha.Depth = 0;
            this.txtVentaFecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVentaFecha.HidePromptOnLeave = false;
            this.txtVentaFecha.HideSelection = true;
            this.txtVentaFecha.Hint = "Fecha";
            this.txtVentaFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtVentaFecha.LeadingIcon = null;
            this.txtVentaFecha.Location = new System.Drawing.Point(6, 26);
            this.txtVentaFecha.Mask = "00/00/0000";
            this.txtVentaFecha.MaxLength = 32767;
            this.txtVentaFecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVentaFecha.Name = "txtVentaFecha";
            this.txtVentaFecha.PasswordChar = '\0';
            this.txtVentaFecha.PrefixSuffixText = null;
            this.txtVentaFecha.PromptChar = '_';
            this.txtVentaFecha.ReadOnly = false;
            this.txtVentaFecha.RejectInputOnFirstFailure = false;
            this.txtVentaFecha.ResetOnPrompt = true;
            this.txtVentaFecha.ResetOnSpace = true;
            this.txtVentaFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVentaFecha.SelectedText = "";
            this.txtVentaFecha.SelectionLength = 0;
            this.txtVentaFecha.SelectionStart = 0;
            this.txtVentaFecha.ShortcutsEnabled = true;
            this.txtVentaFecha.Size = new System.Drawing.Size(158, 48);
            this.txtVentaFecha.SkipLiterals = true;
            this.txtVentaFecha.TabIndex = 327;
            this.txtVentaFecha.TabStop = false;
            this.txtVentaFecha.Text = "  /  /";
            this.txtVentaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVentaFecha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtVentaFecha.TrailingIcon = global::CapaPresentacion.Properties.Resources.calendar_32;
            this.txtVentaFecha.UseSystemPasswordChar = false;
            this.txtVentaFecha.ValidatingType = null;
            this.txtVentaFecha.TrailingIconClick += new System.EventHandler(this.txtVentaFecha_TrailingIconClick);
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(6, 43);
            this.dtpFechaVenta.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(158, 31);
            this.dtpFechaVenta.TabIndex = 328;
            this.dtpFechaVenta.ValueChanged += new System.EventHandler(this.dtpVentaFecha_ValueChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtClienteNombreCompleto);
            this.gbCliente.Controls.Add(this.txtClienteDocumento);
            this.gbCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbCliente.Location = new System.Drawing.Point(364, 102);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(535, 85);
            this.gbCliente.TabIndex = 294;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtClienteNombreCompleto
            // 
            this.txtClienteNombreCompleto.AnimateReadOnly = false;
            this.txtClienteNombreCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClienteNombreCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClienteNombreCompleto.Depth = 0;
            this.txtClienteNombreCompleto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClienteNombreCompleto.HideSelection = true;
            this.txtClienteNombreCompleto.Hint = "Nombre completo";
            this.txtClienteNombreCompleto.LeadingIcon = null;
            this.txtClienteNombreCompleto.Location = new System.Drawing.Point(270, 26);
            this.txtClienteNombreCompleto.MaxLength = 50;
            this.txtClienteNombreCompleto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClienteNombreCompleto.Name = "txtClienteNombreCompleto";
            this.txtClienteNombreCompleto.PasswordChar = '\0';
            this.txtClienteNombreCompleto.PrefixSuffixText = null;
            this.txtClienteNombreCompleto.ReadOnly = false;
            this.txtClienteNombreCompleto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClienteNombreCompleto.SelectedText = "";
            this.txtClienteNombreCompleto.SelectionLength = 0;
            this.txtClienteNombreCompleto.SelectionStart = 0;
            this.txtClienteNombreCompleto.ShortcutsEnabled = true;
            this.txtClienteNombreCompleto.Size = new System.Drawing.Size(255, 48);
            this.txtClienteNombreCompleto.TabIndex = 332;
            this.txtClienteNombreCompleto.TabStop = false;
            this.txtClienteNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClienteNombreCompleto.TrailingIcon = null;
            this.txtClienteNombreCompleto.UseSystemPasswordChar = false;
            // 
            // txtClienteDocumento
            // 
            this.txtClienteDocumento.AnimateReadOnly = false;
            this.txtClienteDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClienteDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClienteDocumento.Depth = 0;
            this.txtClienteDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClienteDocumento.HideSelection = true;
            this.txtClienteDocumento.Hint = "Documento";
            this.txtClienteDocumento.LeadingIcon = null;
            this.txtClienteDocumento.Location = new System.Drawing.Point(9, 26);
            this.txtClienteDocumento.MaxLength = 50;
            this.txtClienteDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClienteDocumento.Name = "txtClienteDocumento";
            this.txtClienteDocumento.PasswordChar = '\0';
            this.txtClienteDocumento.PrefixSuffixText = null;
            this.txtClienteDocumento.ReadOnly = false;
            this.txtClienteDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClienteDocumento.SelectedText = "";
            this.txtClienteDocumento.SelectionLength = 0;
            this.txtClienteDocumento.SelectionStart = 0;
            this.txtClienteDocumento.ShortcutsEnabled = true;
            this.txtClienteDocumento.Size = new System.Drawing.Size(255, 48);
            this.txtClienteDocumento.TabIndex = 330;
            this.txtClienteDocumento.TabStop = false;
            this.txtClienteDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClienteDocumento.TrailingIcon = global::CapaPresentacion.Properties.Resources.search_32;
            this.txtClienteDocumento.UseSystemPasswordChar = false;
            this.txtClienteDocumento.TrailingIconClick += new System.EventHandler(this.txtClienteDocumento_TrailingIconClick);
            this.txtClienteDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteDocumento_KeyPress);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.descripcion,
            this.precio,
            this.cantidad,
            this.subtotal,
            this.btnEliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductos.Location = new System.Drawing.Point(17, 308);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(884, 214);
            this.dgvProductos.TabIndex = 292;
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
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(340, 14);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 41);
            this.lblTitulo.TabIndex = 325;
            this.lblTitulo.Text = "Registrar Venta";
            // 
            // pnlVenta
            // 
            this.pnlVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlVenta.Controls.Add(this.txtTotal);
            this.pnlVenta.Controls.Add(this.txtPago);
            this.pnlVenta.Controls.Add(this.txtVuelto);
            this.pnlVenta.Controls.Add(this.btnRegistrarVenta);
            this.pnlVenta.Controls.Add(this.materialDivider2);
            this.pnlVenta.Controls.Add(this.gbProducto);
            this.pnlVenta.Controls.Add(this.lblTitulo);
            this.pnlVenta.Controls.Add(this.gbCliente);
            this.pnlVenta.Controls.Add(this.gbVenta);
            this.pnlVenta.Controls.Add(this.dgvProductos);
            this.pnlVenta.Depth = 0;
            this.pnlVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlVenta.Location = new System.Drawing.Point(18, 23);
            this.pnlVenta.Margin = new System.Windows.Forms.Padding(14);
            this.pnlVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlVenta.Name = "pnlVenta";
            this.pnlVenta.Padding = new System.Windows.Forms.Padding(14);
            this.pnlVenta.Size = new System.Drawing.Size(918, 617);
            this.pnlVenta.TabIndex = 326;
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
            this.txtTotal.Location = new System.Drawing.Point(370, 552);
            this.txtTotal.MaxLength = 50;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtTotal.PrefixSuffixText = "$";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(128, 48);
            this.txtTotal.TabIndex = 337;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtPago
            // 
            this.txtPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPago.AnimateReadOnly = false;
            this.txtPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPago.Depth = 0;
            this.txtPago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPago.HideSelection = true;
            this.txtPago.Hint = "Pago";
            this.txtPago.LeadingIcon = null;
            this.txtPago.Location = new System.Drawing.Point(504, 552);
            this.txtPago.MaxLength = 50;
            this.txtPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPago.Name = "txtPago";
            this.txtPago.PasswordChar = '\0';
            this.txtPago.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtPago.PrefixSuffixText = "$";
            this.txtPago.ReadOnly = false;
            this.txtPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPago.SelectedText = "";
            this.txtPago.SelectionLength = 0;
            this.txtPago.SelectionStart = 0;
            this.txtPago.ShortcutsEnabled = true;
            this.txtPago.Size = new System.Drawing.Size(128, 48);
            this.txtPago.TabIndex = 336;
            this.txtPago.TabStop = false;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPago.TrailingIcon = null;
            this.txtPago.UseSystemPasswordChar = false;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtVuelto
            // 
            this.txtVuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVuelto.AnimateReadOnly = false;
            this.txtVuelto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVuelto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVuelto.Depth = 0;
            this.txtVuelto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVuelto.HideSelection = true;
            this.txtVuelto.Hint = "Vuelto";
            this.txtVuelto.LeadingIcon = null;
            this.txtVuelto.Location = new System.Drawing.Point(638, 552);
            this.txtVuelto.MaxLength = 50;
            this.txtVuelto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.PasswordChar = '\0';
            this.txtVuelto.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtVuelto.PrefixSuffixText = "$";
            this.txtVuelto.ReadOnly = false;
            this.txtVuelto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVuelto.SelectedText = "";
            this.txtVuelto.SelectionLength = 0;
            this.txtVuelto.SelectionStart = 0;
            this.txtVuelto.ShortcutsEnabled = true;
            this.txtVuelto.Size = new System.Drawing.Size(128, 48);
            this.txtVuelto.TabIndex = 335;
            this.txtVuelto.TabStop = false;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVuelto.TrailingIcon = null;
            this.txtVuelto.UseSystemPasswordChar = false;
            this.txtVuelto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVuelto_KeyPress);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarVenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrarVenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrarVenta.Depth = 0;
            this.btnRegistrarVenta.HighEmphasis = true;
            this.btnRegistrarVenta.Icon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(773, 558);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrarVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrarVenta.Size = new System.Drawing.Size(127, 36);
            this.btnRegistrarVenta.TabIndex = 335;
            this.btnRegistrarVenta.Text = "Registrar";
            this.btnRegistrarVenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrarVenta.UseAccentColor = false;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(17, 287);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(882, 12);
            this.materialDivider2.TabIndex = 331;
            this.materialDivider2.Text = "materialDivider3";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtProductoStock);
            this.gbProducto.Controls.Add(this.btnAgregar);
            this.gbProducto.Controls.Add(this.txtProductoCantidad);
            this.gbProducto.Controls.Add(this.txtProductoCodigo);
            this.gbProducto.Controls.Add(this.txtProductoPrecio);
            this.gbProducto.Controls.Add(this.txtProductoDescripcion);
            this.gbProducto.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.ForeColor = System.Drawing.Color.DimGray;
            this.gbProducto.Location = new System.Drawing.Point(17, 193);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(882, 85);
            this.gbProducto.TabIndex = 326;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto";
            // 
            // txtProductoStock
            // 
            this.txtProductoStock.AnimateReadOnly = false;
            this.txtProductoStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProductoStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductoStock.Depth = 0;
            this.txtProductoStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoStock.HideSelection = true;
            this.txtProductoStock.Hint = "Stock";
            this.txtProductoStock.LeadingIcon = null;
            this.txtProductoStock.Location = new System.Drawing.Point(652, 25);
            this.txtProductoStock.MaxLength = 32767;
            this.txtProductoStock.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProductoStock.Name = "txtProductoStock";
            this.txtProductoStock.PasswordChar = '\0';
            this.txtProductoStock.PrefixSuffixText = null;
            this.txtProductoStock.ReadOnly = false;
            this.txtProductoStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductoStock.SelectedText = "";
            this.txtProductoStock.SelectionLength = 0;
            this.txtProductoStock.SelectionStart = 0;
            this.txtProductoStock.ShortcutsEnabled = true;
            this.txtProductoStock.Size = new System.Drawing.Size(97, 48);
            this.txtProductoStock.TabIndex = 327;
            this.txtProductoStock.TabStop = false;
            this.txtProductoStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductoStock.TrailingIcon = null;
            this.txtProductoStock.UseSystemPasswordChar = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.btnAgregar.Location = new System.Drawing.Point(756, 29);
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
            this.txtProductoCantidad.Location = new System.Drawing.Point(535, 25);
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
            this.txtProductoCodigo.ErrorMessage = "No encontrado";
            this.txtProductoCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductoCodigo.HideSelection = true;
            this.txtProductoCodigo.Hint = "Codigo";
            this.txtProductoCodigo.LeadingIcon = null;
            this.txtProductoCodigo.Location = new System.Drawing.Point(6, 25);
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
            this.txtProductoPrecio.Location = new System.Drawing.Point(401, 25);
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
            this.txtProductoDescripcion.Location = new System.Drawing.Point(140, 25);
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
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(959, 663);
            this.Controls.Add(this.pnlVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.gbVenta.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlVenta.ResumeLayout(false);
            this.pnlVenta.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbVenta;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialCard pnlVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtVentaFecha;
        private MaterialSkin.Controls.MaterialComboBox cbTipoFactura;
        private MaterialSkin.Controls.MaterialTextBox2 txtClienteDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtClienteNombreCompleto;
        private System.Windows.Forms.GroupBox gbProducto;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoCantidad;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoCodigo;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoDescripcion;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductoStock;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton btnRegistrarVenta;
        private MaterialSkin.Controls.MaterialTextBox2 txtPago;
        private MaterialSkin.Controls.MaterialTextBox2 txtVuelto;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
    }
}