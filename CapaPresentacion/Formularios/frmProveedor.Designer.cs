namespace CapaPresentacion.Formularios
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mpnlFormProveedor = new MaterialSkin.Controls.MaterialCard();
            this.txtObservacion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblFormProveedor = new MaterialSkin.Controls.MaterialLabel();
            this.pnlListaProveedores = new MaterialSkin.Controls.MaterialCard();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbBuscar = new MaterialSkin.Controls.MaterialComboBox();
            this.mbtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.lblListaProveedores = new MaterialSkin.Controls.MaterialLabel();
            this.mpnlFormProveedor.SuspendLayout();
            this.pnlListaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // mpnlFormProveedor
            // 
            this.mpnlFormProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mpnlFormProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mpnlFormProveedor.Controls.Add(this.txtObservacion);
            this.mpnlFormProveedor.Controls.Add(this.btnCancelar);
            this.mpnlFormProveedor.Controls.Add(this.btnGuardar);
            this.mpnlFormProveedor.Controls.Add(this.txtTelefono);
            this.mpnlFormProveedor.Controls.Add(this.txtCorreo);
            this.mpnlFormProveedor.Controls.Add(this.txtRazonSocial);
            this.mpnlFormProveedor.Controls.Add(this.lblFormProveedor);
            this.mpnlFormProveedor.Depth = 0;
            this.mpnlFormProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mpnlFormProveedor.Location = new System.Drawing.Point(23, 20);
            this.mpnlFormProveedor.Margin = new System.Windows.Forms.Padding(14);
            this.mpnlFormProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mpnlFormProveedor.Name = "mpnlFormProveedor";
            this.mpnlFormProveedor.Padding = new System.Windows.Forms.Padding(14);
            this.mpnlFormProveedor.Size = new System.Drawing.Size(290, 484);
            this.mpnlFormProveedor.TabIndex = 294;
            // 
            // txtObservacion
            // 
            this.txtObservacion.AnimateReadOnly = false;
            this.txtObservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.Depth = 0;
            this.txtObservacion.HideSelection = true;
            this.txtObservacion.Hint = "Observación";
            this.txtObservacion.Location = new System.Drawing.Point(17, 134);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ReadOnly = false;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.ShortcutsEnabled = true;
            this.txtObservacion.Size = new System.Drawing.Size(257, 100);
            this.txtObservacion.TabIndex = 316;
            this.txtObservacion.TabStop = false;
            this.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacion.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(148, 394);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 315;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = global::CapaPresentacion.Properties.Resources.save_32;
            this.btnGuardar.Location = new System.Drawing.Point(17, 394);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 314;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.LeadingIcon = global::CapaPresentacion.Properties.Resources.cell_32;
            this.txtTelefono.Location = new System.Drawing.Point(18, 240);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(256, 48);
            this.txtTelefono.TabIndex = 308;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.Hint = "Correo";
            this.txtCorreo.LeadingIcon = global::CapaPresentacion.Properties.Resources.email_32;
            this.txtCorreo.Location = new System.Drawing.Point(18, 294);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(256, 48);
            this.txtCorreo.TabIndex = 312;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazonSocial.AnimateReadOnly = false;
            this.txtRazonSocial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazonSocial.HideSelection = true;
            this.txtRazonSocial.Hint = "Razon social";
            this.txtRazonSocial.LeadingIcon = null;
            this.txtRazonSocial.Location = new System.Drawing.Point(18, 80);
            this.txtRazonSocial.MaxLength = 8;
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.PrefixSuffixText = null;
            this.txtRazonSocial.ReadOnly = false;
            this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(255, 48);
            this.txtRazonSocial.TabIndex = 310;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            // 
            // lblFormProveedor
            // 
            this.lblFormProveedor.AutoSize = true;
            this.lblFormProveedor.Depth = 0;
            this.lblFormProveedor.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFormProveedor.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblFormProveedor.Location = new System.Drawing.Point(38, 14);
            this.lblFormProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFormProveedor.Name = "lblFormProveedor";
            this.lblFormProveedor.Size = new System.Drawing.Size(214, 29);
            this.lblFormProveedor.TabIndex = 311;
            this.lblFormProveedor.Text = "Datos de Proveedor";
            // 
            // pnlListaProveedores
            // 
            this.pnlListaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlListaProveedores.Controls.Add(this.dgvProveedores);
            this.pnlListaProveedores.Controls.Add(this.txtBuscar);
            this.pnlListaProveedores.Controls.Add(this.cbBuscar);
            this.pnlListaProveedores.Controls.Add(this.mbtnAgregar);
            this.pnlListaProveedores.Controls.Add(this.lblListaProveedores);
            this.pnlListaProveedores.Depth = 0;
            this.pnlListaProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListaProveedores.Location = new System.Drawing.Point(341, 20);
            this.pnlListaProveedores.Margin = new System.Windows.Forms.Padding(14);
            this.pnlListaProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlListaProveedores.Name = "pnlListaProveedores";
            this.pnlListaProveedores.Padding = new System.Windows.Forms.Padding(14);
            this.pnlListaProveedores.Size = new System.Drawing.Size(881, 484);
            this.pnlListaProveedores.TabIndex = 295;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.razonSocial,
            this.observacion,
            this.fechaCreacion,
            this.telefono,
            this.Correo,
            this.id_estado,
            this.estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProveedores.Location = new System.Drawing.Point(18, 138);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProveedores.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(846, 329);
            this.dgvProveedores.TabIndex = 313;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            this.dgvProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProveedores_CellPainting);
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "ID_Proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            this.id_proveedor.Visible = false;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observación";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // id_estado
            // 
            this.id_estado.HeaderText = "ID Estado";
            this.id_estado.Name = "id_estado";
            this.id_estado.ReadOnly = true;
            this.id_estado.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 30;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 30;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.AnimateReadOnly = false;
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.Hint = "Buscar";
            this.txtBuscar.LeadingIcon = null;
            this.txtBuscar.Location = new System.Drawing.Point(639, 80);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PrefixSuffixText = null;
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(225, 48);
            this.txtBuscar.TabIndex = 312;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtBuscar.TrailingIcon")));
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.TrailingIconClick += new System.EventHandler(this.txtBuscar_TrailingIconClick);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // cbBuscar
            // 
            this.cbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscar.AutoResize = false;
            this.cbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cbBuscar.Depth = 0;
            this.cbBuscar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBuscar.DropDownHeight = 174;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.DropDownWidth = 121;
            this.cbBuscar.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Hint = "Buscar por";
            this.cbBuscar.IntegralHeight = false;
            this.cbBuscar.ItemHeight = 43;
            this.cbBuscar.Location = new System.Drawing.Point(453, 79);
            this.cbBuscar.MaxDropDownItems = 4;
            this.cbBuscar.MouseState = MaterialSkin.MouseState.OUT;
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(180, 49);
            this.cbBuscar.StartIndex = 0;
            this.cbBuscar.TabIndex = 311;
            // 
            // mbtnAgregar
            // 
            this.mbtnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnAgregar.Depth = 0;
            this.mbtnAgregar.HighEmphasis = true;
            this.mbtnAgregar.Icon = global::CapaPresentacion.Properties.Resources.agregar_32;
            this.mbtnAgregar.Location = new System.Drawing.Point(18, 92);
            this.mbtnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAgregar.Name = "mbtnAgregar";
            this.mbtnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnAgregar.Size = new System.Drawing.Size(95, 36);
            this.mbtnAgregar.TabIndex = 310;
            this.mbtnAgregar.Text = "Crear";
            this.mbtnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnAgregar.UseAccentColor = false;
            this.mbtnAgregar.UseVisualStyleBackColor = true;
            this.mbtnAgregar.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Depth = 0;
            this.lblListaProveedores.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblListaProveedores.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblListaProveedores.Location = new System.Drawing.Point(326, 14);
            this.lblListaProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(228, 29);
            this.lblListaProveedores.TabIndex = 309;
            this.lblListaProveedores.Text = "Lista de Proveedores";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1245, 527);
            this.Controls.Add(this.pnlListaProveedores);
            this.Controls.Add(this.mpnlFormProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedor";
            this.Text = "Proveedores";
            this.mpnlFormProveedor.ResumeLayout(false);
            this.mpnlFormProveedor.PerformLayout();
            this.pnlListaProveedores.ResumeLayout(false);
            this.pnlListaProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard mpnlFormProveedor;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtRazonSocial;
        private MaterialSkin.Controls.MaterialLabel lblFormProveedor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacion;
        private MaterialSkin.Controls.MaterialCard pnlListaProveedores;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private MaterialSkin.Controls.MaterialComboBox cbBuscar;
        private MaterialSkin.Controls.MaterialButton mbtnAgregar;
        private MaterialSkin.Controls.MaterialLabel lblListaProveedores;
    }
}