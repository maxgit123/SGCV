namespace CapaPresentacion.Formularios.Clientes
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle100 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle101 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle106 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle107 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle108 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle102 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle103 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle104 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle105 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAdmCliente = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_RespIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsableIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblRespIVA = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbRespIVA = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.pnlFormCliente = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlFormCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmCliente
            // 
            this.lblAdmCliente.AutoSize = true;
            this.lblAdmCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmCliente.ForeColor = System.Drawing.Color.Black;
            this.lblAdmCliente.Location = new System.Drawing.Point(30, 15);
            this.lblAdmCliente.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblAdmCliente.Name = "lblAdmCliente";
            this.lblAdmCliente.Size = new System.Drawing.Size(206, 20);
            this.lblAdmCliente.TabIndex = 255;
            this.lblAdmCliente.Text = "Administrador de Cliente";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(15, 99);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(236, 26);
            this.txtDocumento.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(14, 152);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // cbBuscar
            // 
            this.cbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(849, 64);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(145, 26);
            this.cbBuscar.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(1000, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 26);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(15, 205);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(236, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(753, 70);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 238;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.BackColor = System.Drawing.SystemColors.Control;
            this.lblListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.ForeColor = System.Drawing.Color.Black;
            this.lblListaClientes.Location = new System.Drawing.Point(505, 18);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(143, 20);
            this.lblListaClientes.TabIndex = 237;
            this.lblListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle100.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle100.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle100.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle100;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle101.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle101.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle101.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle101.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle101.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle101.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle101.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle101.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle101;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cliente,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Correo,
            this.FechaCreacion,
            this.ID_RespIVA,
            this.ResponsableIVA,
            this.ID_Estado,
            this.Estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle106.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle106.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle106.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle106.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle106.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle106.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle106;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvClientes.Location = new System.Drawing.Point(285, 96);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle107.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle107.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle107.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle107.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle107.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle107.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle107;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle108.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle108.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle108.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle108;
            this.dgvClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(893, 408);
            this.dgvClientes.TabIndex = 236;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClientes_CellPainting);
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Visible = false;
            // 
            // Documento
            // 
            dataGridViewCellStyle102.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle102.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle102.SelectionForeColor = System.Drawing.Color.Black;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle102;
            this.Documento.HeaderText = "DNI";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle103.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle103.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle103.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle103;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle104.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle104.SelectionForeColor = System.Drawing.Color.Black;
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle104;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // ID_RespIVA
            // 
            this.ID_RespIVA.HeaderText = "ID_RespIVA";
            this.ID_RespIVA.Name = "ID_RespIVA";
            this.ID_RespIVA.ReadOnly = true;
            this.ID_RespIVA.Visible = false;
            // 
            // ResponsableIVA
            // 
            dataGridViewCellStyle105.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle105.SelectionForeColor = System.Drawing.Color.Black;
            this.ResponsableIVA.DefaultCellStyle = dataGridViewCellStyle105;
            this.ResponsableIVA.HeaderText = "Responsable IVA";
            this.ResponsableIVA.Name = "ResponsableIVA";
            this.ResponsableIVA.ReadOnly = true;
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
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(16, 80);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(33, 16);
            this.lblDocumento.TabIndex = 246;
            this.lblDocumento.Text = "DNI:";
            // 
            // lblRespIVA
            // 
            this.lblRespIVA.AutoSize = true;
            this.lblRespIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespIVA.Location = new System.Drawing.Point(16, 345);
            this.lblRespIVA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblRespIVA.Name = "lblRespIVA";
            this.lblRespIVA.Size = new System.Drawing.Size(116, 16);
            this.lblRespIVA.TabIndex = 252;
            this.lblRespIVA.Text = "Responsable IVA:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 133);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 248;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbRespIVA
            // 
            this.cbRespIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRespIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRespIVA.FormattingEnabled = true;
            this.cbRespIVA.Location = new System.Drawing.Point(15, 364);
            this.cbRespIVA.Name = "cbRespIVA";
            this.cbRespIVA.Size = new System.Drawing.Size(236, 24);
            this.cbRespIVA.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(16, 186);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 249;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84)))));
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscar.IconSize = 18;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(1141, 64);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(37, 26);
            this.btnLimpiarBuscar.TabIndex = 3;
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(142, 447);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 15, 30, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(132)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(30, 447);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(30, 15, 3, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnCrear.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrear.IconColor = System.Drawing.SystemColors.Control;
            this.btnCrear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCrear.IconSize = 20;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrear.Location = new System.Drawing.Point(285, 64);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(71, 26);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(16, 239);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 297;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(15, 258);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(236, 26);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(15, 311);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(236, 26);
            this.txtCorreo.TabIndex = 8;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(16, 292);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 16);
            this.lblCorreo.TabIndex = 295;
            this.lblCorreo.Text = "Correo:";
            // 
            // pnlFormCliente
            // 
            this.pnlFormCliente.BackColor = System.Drawing.Color.Lavender;
            this.pnlFormCliente.Controls.Add(this.lblAdmCliente);
            this.pnlFormCliente.Controls.Add(this.lblTelefono);
            this.pnlFormCliente.Controls.Add(this.txtDocumento);
            this.pnlFormCliente.Controls.Add(this.txtTelefono);
            this.pnlFormCliente.Controls.Add(this.lblApellido);
            this.pnlFormCliente.Controls.Add(this.txtCorreo);
            this.pnlFormCliente.Controls.Add(this.cbRespIVA);
            this.pnlFormCliente.Controls.Add(this.lblCorreo);
            this.pnlFormCliente.Controls.Add(this.lblNombre);
            this.pnlFormCliente.Controls.Add(this.lblRespIVA);
            this.pnlFormCliente.Controls.Add(this.lblDocumento);
            this.pnlFormCliente.Controls.Add(this.btnCancelar);
            this.pnlFormCliente.Controls.Add(this.btnGuardar);
            this.pnlFormCliente.Controls.Add(this.txtApellido);
            this.pnlFormCliente.Controls.Add(this.txtNombre);
            this.pnlFormCliente.Enabled = false;
            this.pnlFormCliente.Location = new System.Drawing.Point(12, 12);
            this.pnlFormCliente.Name = "pnlFormCliente";
            this.pnlFormCliente.Size = new System.Drawing.Size(266, 492);
            this.pnlFormCliente.TabIndex = 298;
            // 
            // frmClientes
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1190, 516);
            this.Controls.Add(this.pnlFormCliente);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlFormCliente.ResumeLayout(false);
            this.pnlFormCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label lblAdmCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblListaClientes;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblRespIVA;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbRespIVA;
        private System.Windows.Forms.Label lblApellido;
        private FontAwesome.Sharp.IconButton btnCrear;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RespIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsableIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Panel pnlFormCliente;
    }
}