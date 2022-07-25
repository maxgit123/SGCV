namespace CapaPresentacion.Formularios.Usuarios
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblID_Usuario = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAdmUsuario = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ID_Usuario,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Clave,
            this.FechaCreacion,
            this.ID_Rol,
            this.Rol,
            this.ID_Estado,
            this.Estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsuarios.Location = new System.Drawing.Point(287, 98);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(734, 295);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUsuarios_CellPainting);
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.HeaderText = "ID";
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.ReadOnly = true;
            this.ID_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Usuario.Visible = false;
            // 
            // Documento
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Documento.HeaderText = "DNI";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Documento.Width = 70;
            // 
            // Nombre
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 150;
            // 
            // ID_Rol
            // 
            this.ID_Rol.HeaderText = "ID_Rol";
            this.ID_Rol.Name = "ID_Rol";
            this.ID_Rol.ReadOnly = true;
            this.ID_Rol.Visible = false;
            // 
            // Rol
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Rol.DefaultCellStyle = dataGridViewCellStyle6;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 150;
            // 
            // ID_Estado
            // 
            this.ID_Estado.HeaderText = "ID_Estado";
            this.ID_Estado.Name = "ID_Estado";
            this.ID_Estado.ReadOnly = true;
            this.ID_Estado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEditar.Width = 30;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.Width = 30;
            // 
            // cbBuscar
            // 
            this.cbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(692, 66);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(145, 26);
            this.cbBuscar.TabIndex = 211;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(843, 66);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 26);
            this.txtBuscar.TabIndex = 212;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(596, 72);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 210;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblListaUsuarios.Location = new System.Drawing.Point(580, 20);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(149, 20);
            this.lblListaUsuarios.TabIndex = 209;
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(13, 239);
            this.lblClave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(45, 16);
            this.lblClave.TabIndex = 225;
            this.lblClave.Text = "Clave:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(13, 186);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 223;
            this.lblApellido.Text = "Apellido:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Enabled = false;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(16, 311);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(205, 28);
            this.cbRol.TabIndex = 220;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(13, 292);
            this.lblRol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 16);
            this.lblRol.TabIndex = 228;
            this.lblRol.Text = "Rol:";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(16, 258);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(206, 26);
            this.txtClave.TabIndex = 217;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(16, 205);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(206, 26);
            this.txtApellido.TabIndex = 216;
            // 
            // lblID_Usuario
            // 
            this.lblID_Usuario.AutoSize = true;
            this.lblID_Usuario.Location = new System.Drawing.Point(187, 83);
            this.lblID_Usuario.Name = "lblID_Usuario";
            this.lblID_Usuario.Size = new System.Drawing.Size(13, 13);
            this.lblID_Usuario.TabIndex = 230;
            this.lblID_Usuario.Text = "0";
            this.lblID_Usuario.Visible = false;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(206, 83);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(16, 13);
            this.lblIndice.TabIndex = 231;
            this.lblIndice.Text = "-1";
            this.lblIndice.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(160)))), ((int)(((byte)(189)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(132)))), ((int)(((byte)(170)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrear.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCrear.IconColor = System.Drawing.SystemColors.Control;
            this.btnCrear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCrear.IconSize = 20;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.Location = new System.Drawing.Point(287, 66);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(71, 26);
            this.btnCrear.TabIndex = 236;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscar.IconSize = 18;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(984, 66);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(37, 26);
            this.btnLimpiarBuscar.TabIndex = 235;
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnCancelar);
            this.pnlUsuario.Controls.Add(this.lblApellido);
            this.pnlUsuario.Controls.Add(this.cbRol);
            this.pnlUsuario.Controls.Add(this.lblNombre);
            this.pnlUsuario.Controls.Add(this.lblAdmUsuario);
            this.pnlUsuario.Controls.Add(this.lblClave);
            this.pnlUsuario.Controls.Add(this.txtDocumento);
            this.pnlUsuario.Controls.Add(this.lblRol);
            this.pnlUsuario.Controls.Add(this.lblIndice);
            this.pnlUsuario.Controls.Add(this.lblDocumento);
            this.pnlUsuario.Controls.Add(this.btnGuardar);
            this.pnlUsuario.Controls.Add(this.txtNombre);
            this.pnlUsuario.Controls.Add(this.txtClave);
            this.pnlUsuario.Controls.Add(this.txtApellido);
            this.pnlUsuario.Controls.Add(this.lblID_Usuario);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(239, 405);
            this.pnlUsuario.TabIndex = 237;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(127, 357);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 31);
            this.btnCancelar.TabIndex = 234;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 133);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 221;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAdmUsuario
            // 
            this.lblAdmUsuario.AutoSize = true;
            this.lblAdmUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdmUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblAdmUsuario.Location = new System.Drawing.Point(12, 20);
            this.lblAdmUsuario.Name = "lblAdmUsuario";
            this.lblAdmUsuario.Size = new System.Drawing.Size(212, 20);
            this.lblAdmUsuario.TabIndex = 233;
            this.lblAdmUsuario.Text = "Administrador de Usuario";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(16, 99);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(206, 26);
            this.txtDocumento.TabIndex = 214;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(13, 80);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(33, 16);
            this.lblDocumento.TabIndex = 219;
            this.lblDocumento.Text = "DNI:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(16, 357);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 31);
            this.btnGuardar.TabIndex = 224;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(16, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 26);
            this.txtNombre.TabIndex = 215;
            // 
            // frmUsuarios
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1033, 405);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblID_Usuario;
        private System.Windows.Forms.Label lblIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Panel pnlUsuario;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAdmUsuario;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}