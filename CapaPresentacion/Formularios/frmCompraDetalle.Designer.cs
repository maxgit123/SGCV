namespace CapaPresentacion.Formularios
{
    partial class frmCompraDetalle
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
            this.gbInfoProveedor = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicuotaIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalconIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfoCompra = new MaterialSkin.Controls.MaterialCard();
            this.btnBorrarCampos = new MaterialSkin.Controls.MaterialButton();
            this.txtFechaCreacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.txtNroCompra = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGenerarPdf = new MaterialSkin.Controls.MaterialButton();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.txtFechaPedido = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFechaEntrega = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbInfoProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlInfoCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoProveedor
            // 
            this.gbInfoProveedor.Controls.Add(this.txtCorreo);
            this.gbInfoProveedor.Controls.Add(this.txtRazonSocial);
            this.gbInfoProveedor.Controls.Add(this.txtTelefono);
            this.gbInfoProveedor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.gbInfoProveedor.Location = new System.Drawing.Point(16, 257);
            this.gbInfoProveedor.Name = "gbInfoProveedor";
            this.gbInfoProveedor.Size = new System.Drawing.Size(1038, 90);
            this.gbInfoProveedor.TabIndex = 242;
            this.gbInfoProveedor.TabStop = false;
            this.gbInfoProveedor.Text = "Proveedor";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(532, 26);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(255, 48);
            this.txtCorreo.TabIndex = 339;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.AnimateReadOnly = false;
            this.txtRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazonSocial.HideSelection = true;
            this.txtRazonSocial.Hint = "Razon social";
            this.txtRazonSocial.LeadingIcon = null;
            this.txtRazonSocial.Location = new System.Drawing.Point(10, 26);
            this.txtRazonSocial.MaxLength = 32767;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.PrefixSuffixText = null;
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(255, 48);
            this.txtRazonSocial.TabIndex = 337;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(271, 26);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(255, 48);
            this.txtTelefono.TabIndex = 338;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
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
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precioUnit,
            this.subtotal,
            this.alicuotaIva,
            this.subtotalconIva});
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
            this.dgvProductos.Location = new System.Drawing.Point(17, 379);
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
            this.dgvProductos.Size = new System.Drawing.Size(1037, 317);
            this.dgvProductos.TabIndex = 243;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioUnit
            // 
            this.precioUnit.HeaderText = "Precio Unit.";
            this.precioUnit.Name = "precioUnit";
            this.precioUnit.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // alicuotaIva
            // 
            this.alicuotaIva.HeaderText = "Alicuota IVA";
            this.alicuotaIva.Name = "alicuotaIva";
            this.alicuotaIva.ReadOnly = true;
            // 
            // subtotalconIva
            // 
            this.subtotalconIva.HeaderText = "Subtotal c/ IVA";
            this.subtotalconIva.Name = "subtotalconIva";
            this.subtotalconIva.ReadOnly = true;
            // 
            // pnlInfoCompra
            // 
            this.pnlInfoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlInfoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInfoCompra.Controls.Add(this.btnBorrarCampos);
            this.pnlInfoCompra.Controls.Add(this.txtFechaCreacion);
            this.pnlInfoCompra.Controls.Add(this.materialDivider4);
            this.pnlInfoCompra.Controls.Add(this.txtNroCompra);
            this.pnlInfoCompra.Controls.Add(this.btnGenerarPdf);
            this.pnlInfoCompra.Controls.Add(this.txtTotal);
            this.pnlInfoCompra.Controls.Add(this.dgvProductos);
            this.pnlInfoCompra.Controls.Add(this.materialDivider3);
            this.pnlInfoCompra.Controls.Add(this.txtFechaPedido);
            this.pnlInfoCompra.Controls.Add(this.txtFechaEntrega);
            this.pnlInfoCompra.Controls.Add(this.lblTitulo);
            this.pnlInfoCompra.Controls.Add(this.materialDivider1);
            this.pnlInfoCompra.Controls.Add(this.txtUsuario);
            this.pnlInfoCompra.Controls.Add(this.gbInfoProveedor);
            this.pnlInfoCompra.Controls.Add(this.txtDocumento);
            this.pnlInfoCompra.Depth = 0;
            this.pnlInfoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlInfoCompra.Location = new System.Drawing.Point(23, 23);
            this.pnlInfoCompra.Margin = new System.Windows.Forms.Padding(14);
            this.pnlInfoCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlInfoCompra.Name = "pnlInfoCompra";
            this.pnlInfoCompra.Padding = new System.Windows.Forms.Padding(14);
            this.pnlInfoCompra.Size = new System.Drawing.Size(1071, 767);
            this.pnlInfoCompra.TabIndex = 331;
            // 
            // btnBorrarCampos
            // 
            this.btnBorrarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrarCampos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBorrarCampos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBorrarCampos.Depth = 0;
            this.btnBorrarCampos.HighEmphasis = true;
            this.btnBorrarCampos.Icon = null;
            this.btnBorrarCampos.Location = new System.Drawing.Point(171, 708);
            this.btnBorrarCampos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBorrarCampos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBorrarCampos.Name = "btnBorrarCampos";
            this.btnBorrarCampos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBorrarCampos.Size = new System.Drawing.Size(142, 36);
            this.btnBorrarCampos.TabIndex = 345;
            this.btnBorrarCampos.Text = "Borrar campos";
            this.btnBorrarCampos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBorrarCampos.UseAccentColor = true;
            this.btnBorrarCampos.UseVisualStyleBackColor = true;
            this.btnBorrarCampos.Click += new System.EventHandler(this.btnBorrarCampos_Click);
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.AnimateReadOnly = false;
            this.txtFechaCreacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaCreacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFechaCreacion.Depth = 0;
            this.txtFechaCreacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaCreacion.HideSelection = true;
            this.txtFechaCreacion.Hint = "Fecha y hora";
            this.txtFechaCreacion.LeadingIcon = null;
            this.txtFechaCreacion.Location = new System.Drawing.Point(538, 177);
            this.txtFechaCreacion.MaxLength = 32767;
            this.txtFechaCreacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.PasswordChar = '\0';
            this.txtFechaCreacion.PrefixSuffixText = null;
            this.txtFechaCreacion.ReadOnly = true;
            this.txtFechaCreacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaCreacion.SelectedText = "";
            this.txtFechaCreacion.SelectionLength = 0;
            this.txtFechaCreacion.SelectionStart = 0;
            this.txtFechaCreacion.ShortcutsEnabled = true;
            this.txtFechaCreacion.Size = new System.Drawing.Size(255, 48);
            this.txtFechaCreacion.TabIndex = 344;
            this.txtFechaCreacion.TabStop = false;
            this.txtFechaCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaCreacion.TrailingIcon = null;
            this.txtFechaCreacion.UseSystemPasswordChar = false;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(16, 356);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1038, 14);
            this.materialDivider4.TabIndex = 343;
            this.materialDivider4.Text = "materialDivider3";
            // 
            // txtNroCompra
            // 
            this.txtNroCompra.AnimateReadOnly = false;
            this.txtNroCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNroCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNroCompra.Depth = 0;
            this.txtNroCompra.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroCompra.HideSelection = true;
            this.txtNroCompra.Hint = "Nro de compra";
            this.txtNroCompra.LeadingIcon = null;
            this.txtNroCompra.Location = new System.Drawing.Point(16, 97);
            this.txtNroCompra.MaxLength = 50;
            this.txtNroCompra.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroCompra.Name = "txtNroCompra";
            this.txtNroCompra.PasswordChar = '\0';
            this.txtNroCompra.PrefixSuffixText = null;
            this.txtNroCompra.ReadOnly = false;
            this.txtNroCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNroCompra.SelectedText = "";
            this.txtNroCompra.SelectionLength = 0;
            this.txtNroCompra.SelectionStart = 0;
            this.txtNroCompra.ShortcutsEnabled = true;
            this.txtNroCompra.Size = new System.Drawing.Size(255, 48);
            this.txtNroCompra.TabIndex = 342;
            this.txtNroCompra.TabStop = false;
            this.txtNroCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNroCompra.TrailingIcon = global::CapaPresentacion.Properties.Resources.search_32;
            this.txtNroCompra.UseSystemPasswordChar = false;
            this.txtNroCompra.TrailingIconClick += new System.EventHandler(this.txtNroCompra_TrailingIconClick);
            this.txtNroCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroCompra_KeyDown);
            // 
            // btnGenerarPdf
            // 
            this.btnGenerarPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarPdf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerarPdf.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerarPdf.Depth = 0;
            this.btnGenerarPdf.HighEmphasis = true;
            this.btnGenerarPdf.Icon = global::CapaPresentacion.Properties.Resources.pdf_32;
            this.btnGenerarPdf.Location = new System.Drawing.Point(17, 708);
            this.btnGenerarPdf.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerarPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarPdf.Name = "btnGenerarPdf";
            this.btnGenerarPdf.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerarPdf.Size = new System.Drawing.Size(146, 36);
            this.btnGenerarPdf.TabIndex = 341;
            this.btnGenerarPdf.Text = "Generar PDF";
            this.btnGenerarPdf.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerarPdf.UseAccentColor = false;
            this.btnGenerarPdf.UseVisualStyleBackColor = true;
            this.btnGenerarPdf.Click += new System.EventHandler(this.btnGenerarPdf_Click);
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
            this.txtTotal.Hint = "TOTAL";
            this.txtTotal.LeadingIcon = null;
            this.txtTotal.Location = new System.Drawing.Point(799, 702);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PrefixSuffixText = null;
            this.txtTotal.ReadOnly = false;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(255, 48);
            this.txtTotal.TabIndex = 340;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(16, 154);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1038, 14);
            this.materialDivider3.TabIndex = 338;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.AnimateReadOnly = false;
            this.txtFechaPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFechaPedido.Depth = 0;
            this.txtFechaPedido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaPedido.HideSelection = true;
            this.txtFechaPedido.Hint = "Fecha de pedido";
            this.txtFechaPedido.LeadingIcon = null;
            this.txtFechaPedido.Location = new System.Drawing.Point(277, 97);
            this.txtFechaPedido.MaxLength = 32767;
            this.txtFechaPedido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.PasswordChar = '\0';
            this.txtFechaPedido.PrefixSuffixText = null;
            this.txtFechaPedido.ReadOnly = true;
            this.txtFechaPedido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaPedido.SelectedText = "";
            this.txtFechaPedido.SelectionLength = 0;
            this.txtFechaPedido.SelectionStart = 0;
            this.txtFechaPedido.ShortcutsEnabled = true;
            this.txtFechaPedido.Size = new System.Drawing.Size(255, 48);
            this.txtFechaPedido.TabIndex = 333;
            this.txtFechaPedido.TabStop = false;
            this.txtFechaPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaPedido.TrailingIcon = null;
            this.txtFechaPedido.UseSystemPasswordChar = false;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.AnimateReadOnly = false;
            this.txtFechaEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFechaEntrega.Depth = 0;
            this.txtFechaEntrega.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaEntrega.HideSelection = true;
            this.txtFechaEntrega.Hint = "Fecha de entrega";
            this.txtFechaEntrega.LeadingIcon = null;
            this.txtFechaEntrega.Location = new System.Drawing.Point(538, 97);
            this.txtFechaEntrega.MaxLength = 32767;
            this.txtFechaEntrega.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.PasswordChar = '\0';
            this.txtFechaEntrega.PrefixSuffixText = null;
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaEntrega.SelectedText = "";
            this.txtFechaEntrega.SelectionLength = 0;
            this.txtFechaEntrega.SelectionStart = 0;
            this.txtFechaEntrega.ShortcutsEnabled = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(255, 48);
            this.txtFechaEntrega.TabIndex = 334;
            this.txtFechaEntrega.TabStop = false;
            this.txtFechaEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaEntrega.TrailingIcon = null;
            this.txtFechaEntrega.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(356, 14);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(359, 41);
            this.lblTitulo.TabIndex = 332;
            this.lblTitulo.Text = "Información de Compra";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 234);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1038, 14);
            this.materialDivider1.TabIndex = 332;
            this.materialDivider1.Text = "materialDivider3";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(16, 177);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffixText = null;
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(255, 48);
            this.txtUsuario.TabIndex = 335;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.HideSelection = true;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(277, 177);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PrefixSuffixText = null;
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(255, 48);
            this.txtDocumento.TabIndex = 336;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // frmCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1120, 803);
            this.Controls.Add(this.pnlInfoCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraDetalle";
            this.Text = "Detalle de Compra";
            this.gbInfoProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlInfoCompra.ResumeLayout(false);
            this.pnlInfoCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInfoProveedor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private MaterialSkin.Controls.MaterialCard pnlInfoCompra;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaPedido;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaEntrega;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtRazonSocial;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialButton btnGenerarPdf;
        private MaterialSkin.Controls.MaterialTextBox2 txtNroCompra;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaCreacion;
        private MaterialSkin.Controls.MaterialButton btnBorrarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicuotaIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalconIva;
    }
}