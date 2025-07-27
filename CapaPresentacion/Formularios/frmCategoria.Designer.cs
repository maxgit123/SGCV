namespace CapaPresentacion.Formularios
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_alicuotaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicuotaIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFormCategoria = new MaterialSkin.Controls.MaterialCard();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.cbAlicuotaIva = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblFormUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.pnlListaCategorias = new MaterialSkin.Controls.MaterialCard();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbBuscar = new MaterialSkin.Controls.MaterialComboBox();
            this.mbtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.lblListaCategorias = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.pnlFormCategoria.SuspendLayout();
            this.pnlListaCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.nombre,
            this.fechaCreacion,
            this.id_alicuotaIVA,
            this.alicuotaIVA,
            this.id_estado,
            this.estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategorias.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCategorias.Location = new System.Drawing.Point(18, 137);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCategorias.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvCategorias.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCategorias.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategorias.RowTemplate.Height = 28;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(606, 337);
            this.dgvCategorias.TabIndex = 236;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            this.dgvCategorias.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCategorias_CellPainting);
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            this.id_categoria.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // id_alicuotaIVA
            // 
            this.id_alicuotaIVA.HeaderText = "ID AlicuotaIVA";
            this.id_alicuotaIVA.Name = "id_alicuotaIVA";
            this.id_alicuotaIVA.ReadOnly = true;
            this.id_alicuotaIVA.Visible = false;
            // 
            // alicuotaIVA
            // 
            this.alicuotaIVA.HeaderText = "Alicuota IVA";
            this.alicuotaIVA.Name = "alicuotaIVA";
            this.alicuotaIVA.ReadOnly = true;
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(367, -49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 20);
            this.panel2.TabIndex = 260;
            // 
            // pnlFormCategoria
            // 
            this.pnlFormCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFormCategoria.Controls.Add(this.btnCancelar);
            this.pnlFormCategoria.Controls.Add(this.cbAlicuotaIva);
            this.pnlFormCategoria.Controls.Add(this.btnGuardar);
            this.pnlFormCategoria.Controls.Add(this.txtNombre);
            this.pnlFormCategoria.Controls.Add(this.lblFormUsuario);
            this.pnlFormCategoria.Depth = 0;
            this.pnlFormCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlFormCategoria.Location = new System.Drawing.Point(23, 23);
            this.pnlFormCategoria.Margin = new System.Windows.Forms.Padding(14);
            this.pnlFormCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFormCategoria.Name = "pnlFormCategoria";
            this.pnlFormCategoria.Padding = new System.Windows.Forms.Padding(14);
            this.pnlFormCategoria.Size = new System.Drawing.Size(290, 491);
            this.pnlFormCategoria.TabIndex = 261;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(148, 234);
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
            // cbAlicuotaIva
            // 
            this.cbAlicuotaIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlicuotaIva.AutoResize = false;
            this.cbAlicuotaIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAlicuotaIva.Depth = 0;
            this.cbAlicuotaIva.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAlicuotaIva.DropDownHeight = 174;
            this.cbAlicuotaIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlicuotaIva.DropDownWidth = 121;
            this.cbAlicuotaIva.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbAlicuotaIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbAlicuotaIva.FormattingEnabled = true;
            this.cbAlicuotaIva.Hint = "Alicuota IVA";
            this.cbAlicuotaIva.IntegralHeight = false;
            this.cbAlicuotaIva.ItemHeight = 43;
            this.cbAlicuotaIva.Location = new System.Drawing.Point(18, 134);
            this.cbAlicuotaIva.MaxDropDownItems = 4;
            this.cbAlicuotaIva.MouseState = MaterialSkin.MouseState.OUT;
            this.cbAlicuotaIva.Name = "cbAlicuotaIva";
            this.cbAlicuotaIva.Size = new System.Drawing.Size(255, 49);
            this.cbAlicuotaIva.StartIndex = 0;
            this.cbAlicuotaIva.TabIndex = 313;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = global::CapaPresentacion.Properties.Resources.save_32;
            this.btnGuardar.Location = new System.Drawing.Point(16, 234);
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
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.Hint = "Categoria";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(18, 80);
            this.txtNombre.MaxLength = 8;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(255, 48);
            this.txtNombre.TabIndex = 310;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // lblFormUsuario
            // 
            this.lblFormUsuario.AutoSize = true;
            this.lblFormUsuario.Depth = 0;
            this.lblFormUsuario.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFormUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblFormUsuario.Location = new System.Drawing.Point(42, 14);
            this.lblFormUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFormUsuario.Name = "lblFormUsuario";
            this.lblFormUsuario.Size = new System.Drawing.Size(207, 29);
            this.lblFormUsuario.TabIndex = 311;
            this.lblFormUsuario.Text = "Datos de Categoria";
            // 
            // pnlListaCategorias
            // 
            this.pnlListaCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlListaCategorias.Controls.Add(this.txtBuscar);
            this.pnlListaCategorias.Controls.Add(this.cbBuscar);
            this.pnlListaCategorias.Controls.Add(this.dgvCategorias);
            this.pnlListaCategorias.Controls.Add(this.mbtnAgregar);
            this.pnlListaCategorias.Controls.Add(this.lblListaCategorias);
            this.pnlListaCategorias.Depth = 0;
            this.pnlListaCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListaCategorias.Location = new System.Drawing.Point(341, 23);
            this.pnlListaCategorias.Margin = new System.Windows.Forms.Padding(14);
            this.pnlListaCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlListaCategorias.Name = "pnlListaCategorias";
            this.pnlListaCategorias.Padding = new System.Windows.Forms.Padding(14);
            this.pnlListaCategorias.Size = new System.Drawing.Size(641, 491);
            this.pnlListaCategorias.TabIndex = 262;
            this.pnlListaCategorias.Resize += new System.EventHandler(this.pnlListaCategorias_Resize);
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
            this.txtBuscar.Location = new System.Drawing.Point(399, 80);
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
            this.cbBuscar.Location = new System.Drawing.Point(213, 79);
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
            // lblListaCategorias
            // 
            this.lblListaCategorias.AutoSize = true;
            this.lblListaCategorias.Depth = 0;
            this.lblListaCategorias.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblListaCategorias.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblListaCategorias.Location = new System.Drawing.Point(249, 14);
            this.lblListaCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblListaCategorias.Name = "lblListaCategorias";
            this.lblListaCategorias.Size = new System.Drawing.Size(208, 29);
            this.lblListaCategorias.TabIndex = 309;
            this.lblListaCategorias.Text = "Lista de Categorias";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1005, 537);
            this.Controls.Add(this.pnlListaCategorias);
            this.Controls.Add(this.pnlFormCategoria);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoria";
            this.Text = "Categorías";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.pnlFormCategoria.ResumeLayout(false);
            this.pnlFormCategoria.PerformLayout();
            this.pnlListaCategorias.ResumeLayout(false);
            this.pnlListaCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alicuotaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicuotaIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialCard pnlFormCategoria;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialComboBox cbAlicuotaIva;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel lblFormUsuario;
        private MaterialSkin.Controls.MaterialCard pnlListaCategorias;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private MaterialSkin.Controls.MaterialComboBox cbBuscar;
        private MaterialSkin.Controls.MaterialButton mbtnAgregar;
        private MaterialSkin.Controls.MaterialLabel lblListaCategorias;
    }
}