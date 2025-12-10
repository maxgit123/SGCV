namespace CapaPresentacion.Formularios
{
    partial class frmVentaDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUsuarioDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.gbInfoCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtClienteDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtClienteNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtTipoFactura = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFechaVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGenerarPdf = new MaterialSkin.Controls.MaterialButton();
            this.txtNroVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.txtFechaCreacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBorrarCampos = new MaterialSkin.Controls.MaterialButton();
            this.txtVuelto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPago = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlInfoVenta = new MaterialSkin.Controls.MaterialCard();
            this.gbInfoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlInfoVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuarioDocumento
            // 
            this.txtUsuarioDocumento.AnimateReadOnly = false;
            this.txtUsuarioDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuarioDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuarioDocumento.Depth = 0;
            this.txtUsuarioDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioDocumento.HideSelection = true;
            this.txtUsuarioDocumento.Hint = "Documento";
            this.txtUsuarioDocumento.LeadingIcon = null;
            this.txtUsuarioDocumento.Location = new System.Drawing.Point(277, 177);
            this.txtUsuarioDocumento.MaxLength = 32767;
            this.txtUsuarioDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuarioDocumento.Name = "txtUsuarioDocumento";
            this.txtUsuarioDocumento.PasswordChar = '\0';
            this.txtUsuarioDocumento.PrefixSuffixText = null;
            this.txtUsuarioDocumento.ReadOnly = true;
            this.txtUsuarioDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuarioDocumento.SelectedText = "";
            this.txtUsuarioDocumento.SelectionLength = 0;
            this.txtUsuarioDocumento.SelectionStart = 0;
            this.txtUsuarioDocumento.ShortcutsEnabled = true;
            this.txtUsuarioDocumento.Size = new System.Drawing.Size(255, 48);
            this.txtUsuarioDocumento.TabIndex = 336;
            this.txtUsuarioDocumento.TabStop = false;
            this.txtUsuarioDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuarioDocumento.TrailingIcon = null;
            this.txtUsuarioDocumento.UseSystemPasswordChar = false;
            // 
            // gbInfoCliente
            // 
            this.gbInfoCliente.Controls.Add(this.txtClienteNombre);
            this.gbInfoCliente.Controls.Add(this.txtCorreo);
            this.gbInfoCliente.Controls.Add(this.txtClienteDocumento);
            this.gbInfoCliente.Controls.Add(this.txtTelefono);
            this.gbInfoCliente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoCliente.ForeColor = System.Drawing.Color.DimGray;
            this.gbInfoCliente.Location = new System.Drawing.Point(17, 257);
            this.gbInfoCliente.Name = "gbInfoCliente";
            this.gbInfoCliente.Size = new System.Drawing.Size(1062, 90);
            this.gbInfoCliente.TabIndex = 242;
            this.gbInfoCliente.TabStop = false;
            this.gbInfoCliente.Text = "Cliente";
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
            this.txtTelefono.Location = new System.Drawing.Point(532, 26);
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
            this.txtClienteDocumento.Location = new System.Drawing.Point(10, 26);
            this.txtClienteDocumento.MaxLength = 32767;
            this.txtClienteDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClienteDocumento.Name = "txtClienteDocumento";
            this.txtClienteDocumento.PasswordChar = '\0';
            this.txtClienteDocumento.PrefixSuffixText = null;
            this.txtClienteDocumento.ReadOnly = true;
            this.txtClienteDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClienteDocumento.SelectedText = "";
            this.txtClienteDocumento.SelectionLength = 0;
            this.txtClienteDocumento.SelectionStart = 0;
            this.txtClienteDocumento.ShortcutsEnabled = true;
            this.txtClienteDocumento.Size = new System.Drawing.Size(255, 48);
            this.txtClienteDocumento.TabIndex = 337;
            this.txtClienteDocumento.TabStop = false;
            this.txtClienteDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClienteDocumento.TrailingIcon = null;
            this.txtClienteDocumento.UseSystemPasswordChar = false;
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
            this.txtCorreo.Location = new System.Drawing.Point(793, 26);
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
            // txtClienteNombre
            // 
            this.txtClienteNombre.AnimateReadOnly = false;
            this.txtClienteNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClienteNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClienteNombre.Depth = 0;
            this.txtClienteNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClienteNombre.HideSelection = true;
            this.txtClienteNombre.Hint = "Nombre completo";
            this.txtClienteNombre.LeadingIcon = null;
            this.txtClienteNombre.Location = new System.Drawing.Point(271, 26);
            this.txtClienteNombre.MaxLength = 32767;
            this.txtClienteNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.PasswordChar = '\0';
            this.txtClienteNombre.PrefixSuffixText = null;
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClienteNombre.SelectedText = "";
            this.txtClienteNombre.SelectionLength = 0;
            this.txtClienteNombre.SelectionStart = 0;
            this.txtClienteNombre.ShortcutsEnabled = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(255, 48);
            this.txtClienteNombre.TabIndex = 348;
            this.txtClienteNombre.TabStop = false;
            this.txtClienteNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClienteNombre.TrailingIcon = null;
            this.txtClienteNombre.UseSystemPasswordChar = false;
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
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 234);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1063, 14);
            this.materialDivider1.TabIndex = 332;
            this.materialDivider1.Text = "materialDivider3";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(372, 14);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 41);
            this.lblTitulo.TabIndex = 332;
            this.lblTitulo.Text = "Información de Venta";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura.AnimateReadOnly = false;
            this.txtTipoFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTipoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTipoFactura.Depth = 0;
            this.txtTipoFactura.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipoFactura.HideSelection = true;
            this.txtTipoFactura.Hint = "Tipo de factura";
            this.txtTipoFactura.LeadingIcon = null;
            this.txtTipoFactura.Location = new System.Drawing.Point(539, 97);
            this.txtTipoFactura.MaxLength = 32767;
            this.txtTipoFactura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.PasswordChar = '\0';
            this.txtTipoFactura.PrefixSuffixText = null;
            this.txtTipoFactura.ReadOnly = true;
            this.txtTipoFactura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTipoFactura.SelectedText = "";
            this.txtTipoFactura.SelectionLength = 0;
            this.txtTipoFactura.SelectionStart = 0;
            this.txtTipoFactura.ShortcutsEnabled = true;
            this.txtTipoFactura.Size = new System.Drawing.Size(255, 48);
            this.txtTipoFactura.TabIndex = 334;
            this.txtTipoFactura.TabStop = false;
            this.txtTipoFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipoFactura.TrailingIcon = null;
            this.txtTipoFactura.UseSystemPasswordChar = false;
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.AnimateReadOnly = false;
            this.txtFechaVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFechaVenta.Depth = 0;
            this.txtFechaVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaVenta.HideSelection = true;
            this.txtFechaVenta.Hint = "Fecha de venta";
            this.txtFechaVenta.LeadingIcon = null;
            this.txtFechaVenta.Location = new System.Drawing.Point(278, 97);
            this.txtFechaVenta.MaxLength = 32767;
            this.txtFechaVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.PasswordChar = '\0';
            this.txtFechaVenta.PrefixSuffixText = null;
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaVenta.SelectedText = "";
            this.txtFechaVenta.SelectionLength = 0;
            this.txtFechaVenta.SelectionStart = 0;
            this.txtFechaVenta.ShortcutsEnabled = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(255, 48);
            this.txtFechaVenta.TabIndex = 333;
            this.txtFechaVenta.TabStop = false;
            this.txtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaVenta.TrailingIcon = null;
            this.txtFechaVenta.UseSystemPasswordChar = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(16, 154);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1063, 14);
            this.materialDivider3.TabIndex = 338;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precioUnit,
            this.subtotal});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductos.Location = new System.Drawing.Point(17, 379);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1062, 317);
            this.dgvProductos.TabIndex = 243;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // precioUnit
            // 
            this.precioUnit.HeaderText = "Precio Unit.";
            this.precioUnit.Name = "precioUnit";
            this.precioUnit.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
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
            this.txtTotal.Location = new System.Drawing.Point(377, 702);
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
            this.txtTotal.Size = new System.Drawing.Size(230, 48);
            this.txtTotal.TabIndex = 340;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.TrailingIcon = null;
            this.txtTotal.UseSystemPasswordChar = false;
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
            // txtNroVenta
            // 
            this.txtNroVenta.AnimateReadOnly = false;
            this.txtNroVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNroVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNroVenta.Depth = 0;
            this.txtNroVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroVenta.HideSelection = true;
            this.txtNroVenta.Hint = "Nro de venta";
            this.txtNroVenta.LeadingIcon = null;
            this.txtNroVenta.Location = new System.Drawing.Point(17, 97);
            this.txtNroVenta.MaxLength = 50;
            this.txtNroVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNroVenta.Name = "txtNroVenta";
            this.txtNroVenta.PasswordChar = '\0';
            this.txtNroVenta.PrefixSuffixText = null;
            this.txtNroVenta.ReadOnly = false;
            this.txtNroVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNroVenta.SelectedText = "";
            this.txtNroVenta.SelectionLength = 0;
            this.txtNroVenta.SelectionStart = 0;
            this.txtNroVenta.ShortcutsEnabled = true;
            this.txtNroVenta.Size = new System.Drawing.Size(255, 48);
            this.txtNroVenta.TabIndex = 342;
            this.txtNroVenta.TabStop = false;
            this.txtNroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNroVenta.TrailingIcon = global::CapaPresentacion.Properties.Resources.search_32;
            this.txtNroVenta.UseSystemPasswordChar = false;
            this.txtNroVenta.TrailingIconClick += new System.EventHandler(this.txtNroVenta_TrailingIconClick);
            this.txtNroVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroVenta_KeyDown);
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(17, 356);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1062, 14);
            this.materialDivider4.TabIndex = 343;
            this.materialDivider4.Text = "materialDivider3";
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
            // txtVuelto
            // 
            this.txtVuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVuelto.AnimateReadOnly = false;
            this.txtVuelto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtVuelto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVuelto.Depth = 0;
            this.txtVuelto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtVuelto.HideSelection = true;
            this.txtVuelto.Hint = "VUELTO";
            this.txtVuelto.LeadingIcon = null;
            this.txtVuelto.Location = new System.Drawing.Point(849, 702);
            this.txtVuelto.MaxLength = 32767;
            this.txtVuelto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.PasswordChar = '\0';
            this.txtVuelto.PrefixSuffixText = null;
            this.txtVuelto.ReadOnly = false;
            this.txtVuelto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVuelto.SelectedText = "";
            this.txtVuelto.SelectionLength = 0;
            this.txtVuelto.SelectionStart = 0;
            this.txtVuelto.ShortcutsEnabled = true;
            this.txtVuelto.Size = new System.Drawing.Size(230, 48);
            this.txtVuelto.TabIndex = 346;
            this.txtVuelto.TabStop = false;
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVuelto.TrailingIcon = null;
            this.txtVuelto.UseSystemPasswordChar = false;
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
            this.txtPago.Hint = "PAGO";
            this.txtPago.LeadingIcon = null;
            this.txtPago.Location = new System.Drawing.Point(613, 702);
            this.txtPago.MaxLength = 32767;
            this.txtPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPago.Name = "txtPago";
            this.txtPago.PasswordChar = '\0';
            this.txtPago.PrefixSuffixText = null;
            this.txtPago.ReadOnly = false;
            this.txtPago.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPago.SelectedText = "";
            this.txtPago.SelectionLength = 0;
            this.txtPago.SelectionStart = 0;
            this.txtPago.ShortcutsEnabled = true;
            this.txtPago.Size = new System.Drawing.Size(230, 48);
            this.txtPago.TabIndex = 347;
            this.txtPago.TabStop = false;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPago.TrailingIcon = null;
            this.txtPago.UseSystemPasswordChar = false;
            // 
            // pnlInfoVenta
            // 
            this.pnlInfoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlInfoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlInfoVenta.Controls.Add(this.txtPago);
            this.pnlInfoVenta.Controls.Add(this.txtVuelto);
            this.pnlInfoVenta.Controls.Add(this.btnBorrarCampos);
            this.pnlInfoVenta.Controls.Add(this.txtFechaCreacion);
            this.pnlInfoVenta.Controls.Add(this.materialDivider4);
            this.pnlInfoVenta.Controls.Add(this.txtNroVenta);
            this.pnlInfoVenta.Controls.Add(this.btnGenerarPdf);
            this.pnlInfoVenta.Controls.Add(this.txtTotal);
            this.pnlInfoVenta.Controls.Add(this.dgvProductos);
            this.pnlInfoVenta.Controls.Add(this.materialDivider3);
            this.pnlInfoVenta.Controls.Add(this.txtFechaVenta);
            this.pnlInfoVenta.Controls.Add(this.txtTipoFactura);
            this.pnlInfoVenta.Controls.Add(this.lblTitulo);
            this.pnlInfoVenta.Controls.Add(this.materialDivider1);
            this.pnlInfoVenta.Controls.Add(this.txtUsuario);
            this.pnlInfoVenta.Controls.Add(this.gbInfoCliente);
            this.pnlInfoVenta.Controls.Add(this.txtUsuarioDocumento);
            this.pnlInfoVenta.Depth = 0;
            this.pnlInfoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlInfoVenta.Location = new System.Drawing.Point(27, 23);
            this.pnlInfoVenta.Margin = new System.Windows.Forms.Padding(14);
            this.pnlInfoVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlInfoVenta.Name = "pnlInfoVenta";
            this.pnlInfoVenta.Padding = new System.Windows.Forms.Padding(14);
            this.pnlInfoVenta.Size = new System.Drawing.Size(1096, 767);
            this.pnlInfoVenta.TabIndex = 332;
            // 
            // frmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1146, 803);
            this.Controls.Add(this.pnlInfoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentaDetalle";
            this.Text = "Detalle de Venta";
            this.gbInfoCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlInfoVenta.ResumeLayout(false);
            this.pnlInfoVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtUsuarioDocumento;
        private System.Windows.Forms.GroupBox gbInfoCliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtClienteNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtClienteDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTipoFactura;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaVenta;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private MaterialSkin.Controls.MaterialTextBox2 txtTotal;
        private MaterialSkin.Controls.MaterialButton btnGenerarPdf;
        private MaterialSkin.Controls.MaterialTextBox2 txtNroVenta;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaCreacion;
        private MaterialSkin.Controls.MaterialButton btnBorrarCampos;
        private MaterialSkin.Controls.MaterialTextBox2 txtVuelto;
        private MaterialSkin.Controls.MaterialTextBox2 txtPago;
        private MaterialSkin.Controls.MaterialCard pnlInfoVenta;
    }
}