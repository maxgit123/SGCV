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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.pnlFormUsuario = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAdmUsuario = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlListaUsuarios = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pnlFormUsuario.SuspendLayout();
            this.pnlListaUsuarios.SuspendLayout();
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
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 98);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
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
            this.dgvUsuarios.Size = new System.Drawing.Size(856, 314);
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
            // cbBuscar
            // 
            this.cbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(549, 64);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(145, 26);
            this.cbBuscar.TabIndex = 211;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(700, 64);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 26);
            this.txtBuscar.TabIndex = 212;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(453, 70);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 210;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblListaUsuarios.Location = new System.Drawing.Point(369, 15);
            this.lblListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(149, 20);
            this.lblListaUsuarios.TabIndex = 209;
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(16, 239);
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
            this.lblApellido.Location = new System.Drawing.Point(16, 186);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 223;
            this.lblApellido.Text = "Apellido:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(15, 311);
            this.cbRol.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(236, 28);
            this.cbRol.TabIndex = 220;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(18, 292);
            this.lblRol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 16);
            this.lblRol.TabIndex = 228;
            this.lblRol.Text = "Rol:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(15, 258);
            this.txtClave.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(236, 26);
            this.txtClave.TabIndex = 217;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(15, 205);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(236, 26);
            this.txtApellido.TabIndex = 216;
            // 
            // btnCrear
            // 
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrear.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnCrear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCrear.IconSize = 20;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.Location = new System.Drawing.Point(15, 64);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(15, 15, 3, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 26);
            this.btnCrear.TabIndex = 236;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscar.IconSize = 20;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(834, 64);
            this.btnLimpiarBuscar.Margin = new System.Windows.Forms.Padding(3, 15, 15, 5);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(37, 26);
            this.btnLimpiarBuscar.TabIndex = 235;
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // pnlFormUsuario
            // 
            this.pnlFormUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormUsuario.BackColor = System.Drawing.Color.Lavender;
            this.pnlFormUsuario.Controls.Add(this.btnCancelar);
            this.pnlFormUsuario.Controls.Add(this.lblApellido);
            this.pnlFormUsuario.Controls.Add(this.cbRol);
            this.pnlFormUsuario.Controls.Add(this.lblNombre);
            this.pnlFormUsuario.Controls.Add(this.lblAdmUsuario);
            this.pnlFormUsuario.Controls.Add(this.lblClave);
            this.pnlFormUsuario.Controls.Add(this.txtDocumento);
            this.pnlFormUsuario.Controls.Add(this.lblRol);
            this.pnlFormUsuario.Controls.Add(this.lblDocumento);
            this.pnlFormUsuario.Controls.Add(this.btnGuardar);
            this.pnlFormUsuario.Controls.Add(this.txtNombre);
            this.pnlFormUsuario.Controls.Add(this.txtClave);
            this.pnlFormUsuario.Controls.Add(this.txtApellido);
            this.pnlFormUsuario.Enabled = false;
            this.pnlFormUsuario.Location = new System.Drawing.Point(12, 12);
            this.pnlFormUsuario.Name = "pnlFormUsuario";
            this.pnlFormUsuario.Size = new System.Drawing.Size(266, 429);
            this.pnlFormUsuario.TabIndex = 237;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(141, 384);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 15, 30, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 30);
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
            this.lblNombre.Location = new System.Drawing.Point(16, 133);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 221;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblAdmUsuario
            // 
            this.lblAdmUsuario.AutoSize = true;
            this.lblAdmUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblAdmUsuario.Location = new System.Drawing.Point(27, 15);
            this.lblAdmUsuario.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblAdmUsuario.Name = "lblAdmUsuario";
            this.lblAdmUsuario.Size = new System.Drawing.Size(212, 20);
            this.lblAdmUsuario.TabIndex = 233;
            this.lblAdmUsuario.Text = "Administrador de Usuario";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(15, 99);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(236, 26);
            this.txtDocumento.TabIndex = 214;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(16, 80);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(33, 16);
            this.lblDocumento.TabIndex = 219;
            this.lblDocumento.Text = "DNI:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(30, 384);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(30, 15, 3, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 30);
            this.btnGuardar.TabIndex = 224;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 152);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 26);
            this.txtNombre.TabIndex = 215;
            // 
            // pnlListaUsuarios
            // 
            this.pnlListaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListaUsuarios.Controls.Add(this.lblListaUsuarios);
            this.pnlListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.pnlListaUsuarios.Controls.Add(this.btnCrear);
            this.pnlListaUsuarios.Controls.Add(this.lblBuscar);
            this.pnlListaUsuarios.Controls.Add(this.btnLimpiarBuscar);
            this.pnlListaUsuarios.Controls.Add(this.txtBuscar);
            this.pnlListaUsuarios.Controls.Add(this.cbBuscar);
            this.pnlListaUsuarios.Location = new System.Drawing.Point(284, 12);
            this.pnlListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 5, 15, 15);
            this.pnlListaUsuarios.Name = "pnlListaUsuarios";
            this.pnlListaUsuarios.Size = new System.Drawing.Size(888, 429);
            this.pnlListaUsuarios.TabIndex = 238;
            this.pnlListaUsuarios.Resize += new System.EventHandler(this.pnlListaUsuarios_Resize);
            // 
            // frmUsuarios
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1184, 453);
            this.Controls.Add(this.pnlListaUsuarios);
            this.Controls.Add(this.pnlFormUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pnlFormUsuario.ResumeLayout(false);
            this.pnlFormUsuario.PerformLayout();
            this.pnlListaUsuarios.ResumeLayout(false);
            this.pnlListaUsuarios.PerformLayout();
            this.ResumeLayout(false);

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
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnCrear;
        private System.Windows.Forms.Panel pnlFormUsuario;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAdmUsuario;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlListaUsuarios;
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
    }
}