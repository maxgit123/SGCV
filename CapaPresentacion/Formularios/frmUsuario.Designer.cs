namespace CapaPresentacion.Formularios
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblFormUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.txtClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbRol = new MaterialSkin.Controls.MaterialComboBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.pnlFormUsuario = new MaterialSkin.Controls.MaterialCard();
            this.pnlListaUsuarios = new MaterialSkin.Controls.MaterialCard();
            this.txtBuscar = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbBuscar = new MaterialSkin.Controls.MaterialComboBox();
            this.mbtnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.lblListaUsuarios = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlFormUsuario.SuspendLayout();
            this.pnlListaUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.documento,
            this.nombre,
            this.apellido,
            this.clave,
            this.fechaCreacion,
            this.id_rol,
            this.rol,
            this.id_estado,
            this.estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 137);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(671, 333);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // documento
            // 
            this.documento.HeaderText = "DNI";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Visible = false;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.HeaderText = "Fecha de creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "ID_Rol";
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Visible = false;
            // 
            // rol
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.rol.DefaultCellStyle = dataGridViewCellStyle3;
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // id_estado
            // 
            this.id_estado.HeaderText = "ID_Estado";
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
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.HideSelection = true;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(18, 80);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.PrefixSuffixText = null;
            this.txtDocumento.ReadOnly = false;
            this.txtDocumento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.Size = new System.Drawing.Size(255, 48);
            this.txtDocumento.TabIndex = 310;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.UseSystemPasswordChar = false;
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
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(18, 134);
            this.txtNombre.MaxLength = 32767;
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
            this.txtNombre.Size = new System.Drawing.Size(256, 48);
            this.txtNombre.TabIndex = 309;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.HideSelection = true;
            this.txtApellido.Hint = "Apellido";
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(18, 188);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PrefixSuffixText = null;
            this.txtApellido.ReadOnly = false;
            this.txtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(256, 48);
            this.txtApellido.TabIndex = 308;
            this.txtApellido.TabStop = false;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // lblFormUsuario
            // 
            this.lblFormUsuario.AutoSize = true;
            this.lblFormUsuario.Depth = 0;
            this.lblFormUsuario.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFormUsuario.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblFormUsuario.Location = new System.Drawing.Point(53, 14);
            this.lblFormUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFormUsuario.Name = "lblFormUsuario";
            this.lblFormUsuario.Size = new System.Drawing.Size(185, 29);
            this.lblFormUsuario.TabIndex = 311;
            this.lblFormUsuario.Text = "Datos de Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClave.AnimateReadOnly = false;
            this.txtClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClave.Depth = 0;
            this.txtClave.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClave.HideSelection = true;
            this.txtClave.Hint = "Clave";
            this.txtClave.LeadingIcon = null;
            this.txtClave.Location = new System.Drawing.Point(18, 242);
            this.txtClave.MaxLength = 32767;
            this.txtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.PrefixSuffixText = null;
            this.txtClave.ReadOnly = false;
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.Size = new System.Drawing.Size(256, 48);
            this.txtClave.TabIndex = 312;
            this.txtClave.TabStop = false;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClave.TrailingIcon = null;
            this.txtClave.UseSystemPasswordChar = false;
            // 
            // cbRol
            // 
            this.cbRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRol.AutoResize = false;
            this.cbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbRol.Depth = 0;
            this.cbRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbRol.DropDownHeight = 174;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.DropDownWidth = 121;
            this.cbRol.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Hint = "Rol";
            this.cbRol.IntegralHeight = false;
            this.cbRol.ItemHeight = 43;
            this.cbRol.Location = new System.Drawing.Point(18, 296);
            this.cbRol.MaxDropDownItems = 4;
            this.cbRol.MouseState = MaterialSkin.MouseState.OUT;
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(256, 49);
            this.cbRol.StartIndex = 0;
            this.cbRol.TabIndex = 313;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(149, 396);
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
            this.btnGuardar.Location = new System.Drawing.Point(17, 396);
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
            // pnlFormUsuario
            // 
            this.pnlFormUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFormUsuario.Controls.Add(this.btnCancelar);
            this.pnlFormUsuario.Controls.Add(this.cbRol);
            this.pnlFormUsuario.Controls.Add(this.btnGuardar);
            this.pnlFormUsuario.Controls.Add(this.txtApellido);
            this.pnlFormUsuario.Controls.Add(this.txtNombre);
            this.pnlFormUsuario.Controls.Add(this.txtClave);
            this.pnlFormUsuario.Controls.Add(this.txtDocumento);
            this.pnlFormUsuario.Controls.Add(this.lblFormUsuario);
            this.pnlFormUsuario.Depth = 0;
            this.pnlFormUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlFormUsuario.Location = new System.Drawing.Point(23, 23);
            this.pnlFormUsuario.Margin = new System.Windows.Forms.Padding(14);
            this.pnlFormUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFormUsuario.Name = "pnlFormUsuario";
            this.pnlFormUsuario.Padding = new System.Windows.Forms.Padding(14);
            this.pnlFormUsuario.Size = new System.Drawing.Size(290, 484);
            this.pnlFormUsuario.TabIndex = 237;
            // 
            // pnlListaUsuarios
            // 
            this.pnlListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlListaUsuarios.Controls.Add(this.txtBuscar);
            this.pnlListaUsuarios.Controls.Add(this.cbBuscar);
            this.pnlListaUsuarios.Controls.Add(this.mbtnAgregar);
            this.pnlListaUsuarios.Controls.Add(this.lblListaUsuarios);
            this.pnlListaUsuarios.Depth = 0;
            this.pnlListaUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListaUsuarios.Location = new System.Drawing.Point(341, 23);
            this.pnlListaUsuarios.Margin = new System.Windows.Forms.Padding(14);
            this.pnlListaUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlListaUsuarios.Name = "pnlListaUsuarios";
            this.pnlListaUsuarios.Padding = new System.Windows.Forms.Padding(14);
            this.pnlListaUsuarios.Size = new System.Drawing.Size(706, 484);
            this.pnlListaUsuarios.TabIndex = 239;
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
            this.txtBuscar.Location = new System.Drawing.Point(464, 80);
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
            this.cbBuscar.Location = new System.Drawing.Point(278, 79);
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
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Depth = 0;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblListaUsuarios.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblListaUsuarios.Location = new System.Drawing.Point(260, 14);
            this.lblListaUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(186, 29);
            this.lblListaUsuarios.TabIndex = 309;
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1070, 530);
            this.Controls.Add(this.pnlListaUsuarios);
            this.Controls.Add(this.pnlFormUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Resize += new System.EventHandler(this.pnlListaUsuarios_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlFormUsuario.ResumeLayout(false);
            this.pnlFormUsuario.PerformLayout();
            this.pnlListaUsuarios.ResumeLayout(false);
            this.pnlListaUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocumento;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellido;
        private MaterialSkin.Controls.MaterialTextBox2 txtClave;
        private MaterialSkin.Controls.MaterialLabel lblFormUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbRol;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialCard pnlFormUsuario;
        private MaterialSkin.Controls.MaterialCard pnlListaUsuarios;
        private MaterialSkin.Controls.MaterialLabel lblListaUsuarios;
        private MaterialSkin.Controls.MaterialButton mbtnAgregar;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscar;
        private MaterialSkin.Controls.MaterialComboBox cbBuscar;
    }
}