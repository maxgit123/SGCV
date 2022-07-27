namespace CapaPresentacion.Formularios.Productos
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAdmUsuario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblID_Producto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblQuiebreStock = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtQuiebreStock = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCrear = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuiebreStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmUsuario
            // 
            this.lblAdmUsuario.AutoSize = true;
            this.lblAdmUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblAdmUsuario.Location = new System.Drawing.Point(8, 20);
            this.lblAdmUsuario.Name = "lblAdmUsuario";
            this.lblAdmUsuario.Size = new System.Drawing.Size(222, 20);
            this.lblAdmUsuario.TabIndex = 255;
            this.lblAdmUsuario.Text = "Administrador de Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(15, 99);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(206, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(205, 82);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(16, 13);
            this.lblIndice.TabIndex = 254;
            this.lblIndice.Text = "-1";
            this.lblIndice.Visible = false;
            // 
            // lblID_Producto
            // 
            this.lblID_Producto.AutoSize = true;
            this.lblID_Producto.Location = new System.Drawing.Point(186, 82);
            this.lblID_Producto.Name = "lblID_Producto";
            this.lblID_Producto.Size = new System.Drawing.Size(13, 13);
            this.lblID_Producto.TabIndex = 253;
            this.lblID_Producto.Text = "0";
            this.lblID_Producto.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 245;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 239);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 252;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblQuiebreStock
            // 
            this.lblQuiebreStock.AutoSize = true;
            this.lblQuiebreStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiebreStock.Location = new System.Drawing.Point(12, 186);
            this.lblQuiebreStock.Name = "lblQuiebreStock";
            this.lblQuiebreStock.Size = new System.Drawing.Size(114, 16);
            this.lblQuiebreStock.TabIndex = 251;
            this.lblQuiebreStock.Text = "Quiebre de Stock:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(15, 258);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(206, 28);
            this.cbCategoria.TabIndex = 5;
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
            this.btnCancelar.Location = new System.Drawing.Point(126, 311);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 31);
            this.btnCancelar.TabIndex = 259;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(15, 311);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 31);
            this.btnGuardar.TabIndex = 258;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtQuiebreStock
            // 
            this.txtQuiebreStock.Enabled = false;
            this.txtQuiebreStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiebreStock.Location = new System.Drawing.Point(15, 205);
            this.txtQuiebreStock.Name = "txtQuiebreStock";
            this.txtQuiebreStock.Size = new System.Drawing.Size(206, 26);
            this.txtQuiebreStock.TabIndex = 261;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Codigo,
            this.Descripcion,
            this.Costo,
            this.Precio,
            this.Stock,
            this.QuiebreStock,
            this.FechaCreacion,
            this.ID_Categoria,
            this.Categoria,
            this.ID_Estado,
            this.Estado,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProductos.Location = new System.Drawing.Point(296, 99);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(852, 335);
            this.dgvProductos.TabIndex = 234;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProductos_CellPainting);
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.BackColor = System.Drawing.SystemColors.Control;
            this.lblListaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProductos.ForeColor = System.Drawing.Color.Black;
            this.lblListaProductos.Location = new System.Drawing.Point(643, 20);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(159, 20);
            this.lblListaProductos.TabIndex = 235;
            this.lblListaProductos.Text = "Lista de Productos";
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(723, 73);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(90, 20);
            this.lblBuscar.TabIndex = 236;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(970, 67);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(135, 26);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // cbBuscar
            // 
            this.cbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Location = new System.Drawing.Point(819, 67);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(145, 26);
            this.cbBuscar.TabIndex = 7;
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
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(1111, 67);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(37, 26);
            this.btnLimpiarBuscar.TabIndex = 260;
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(15, 152);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 26);
            this.txtDescripcion.TabIndex = 262;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 263;
            this.lblDescripcion.Text = "Descripción:";
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
            this.btnCrear.Location = new System.Drawing.Point(296, 67);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(71, 26);
            this.btnCrear.TabIndex = 292;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblAdmUsuario);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblQuiebreStock);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.txtQuiebreStock);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.lblID_Producto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblIndice);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 446);
            this.panel1.TabIndex = 293;
            // 
            // ID_Producto
            // 
            this.ID_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Producto.HeaderText = "ID Producto";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            this.ID_Producto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Producto.Visible = false;
            this.ID_Producto.Width = 99;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 74;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.Descripcion.DefaultCellStyle = dataGridViewCellStyle14;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.Costo.DefaultCellStyle = dataGridViewCellStyle15;
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 66;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle16;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle17;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stock.Width = 65;
            // 
            // QuiebreStock
            // 
            this.QuiebreStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.QuiebreStock.DefaultCellStyle = dataGridViewCellStyle18;
            this.QuiebreStock.HeaderText = "Quiebre de Stock";
            this.QuiebreStock.Name = "QuiebreStock";
            this.QuiebreStock.ReadOnly = true;
            this.QuiebreStock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuiebreStock.Width = 129;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaCreacion.HeaderText = "Fecha Creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Width = 121;
            // 
            // ID_Categoria
            // 
            this.ID_Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Categoria.HeaderText = "ID Categoria";
            this.ID_Categoria.Name = "ID_Categoria";
            this.ID_Categoria.ReadOnly = true;
            this.ID_Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_Categoria.Visible = false;
            this.ID_Categoria.Width = 103;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle19;
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 88;
            // 
            // ID_Estado
            // 
            this.ID_Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_Estado.HeaderText = "ID Estado";
            this.ID_Estado.Name = "ID_Estado";
            this.ID_Estado.ReadOnly = true;
            this.ID_Estado.Visible = false;
            this.ID_Estado.Width = 88;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 73;
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
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.Width = 30;
            // 
            // frmProductos
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1160, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmUsuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblID_Producto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblQuiebreStock;
        private System.Windows.Forms.ComboBox cbCategoria;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.TextBox txtQuiebreStock;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private FontAwesome.Sharp.IconButton btnCrear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuiebreStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}