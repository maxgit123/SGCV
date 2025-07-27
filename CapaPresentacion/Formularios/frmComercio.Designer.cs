namespace CapaPresentacion.Formularios
{
    partial class frmComercio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComercio));
            this.btnCambiarLogo = new MaterialSkin.Controls.MaterialButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCuit = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtIngresosBrutos = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbCondicionIva = new MaterialSkin.Controls.MaterialComboBox();
            this.pnlComercioDatos = new MaterialSkin.Controls.MaterialCard();
            this.btnQuitarLogo = new MaterialSkin.Controls.MaterialButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.txtCodigoPostal = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cbProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.txtPuntoVenta = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCalleNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFechaActualizacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCalleNumero = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtInicioActividad = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlComercioDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCambiarLogo
            // 
            this.btnCambiarLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiarLogo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCambiarLogo.Depth = 0;
            this.btnCambiarLogo.HighEmphasis = true;
            this.btnCambiarLogo.Icon = global::CapaPresentacion.Properties.Resources.add_image_32;
            this.btnCambiarLogo.Location = new System.Drawing.Point(557, 267);
            this.btnCambiarLogo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCambiarLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambiarLogo.Name = "btnCambiarLogo";
            this.btnCambiarLogo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCambiarLogo.Size = new System.Drawing.Size(156, 36);
            this.btnCambiarLogo.TabIndex = 311;
            this.btnCambiarLogo.Text = "Cambiar logo";
            this.btnCambiarLogo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCambiarLogo.UseAccentColor = false;
            this.btnCambiarLogo.UseVisualStyleBackColor = true;
            this.btnCambiarLogo.Click += new System.EventHandler(this.btnCambiarLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::CapaPresentacion.Properties.Resources.image_logo_96;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(557, 102);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(156, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 258;
            this.picLogo.TabStop = false;
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
            this.txtRazonSocial.Location = new System.Drawing.Point(17, 102);
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
            this.txtRazonSocial.TabIndex = 312;
            this.txtRazonSocial.TabStop = false;
            this.txtRazonSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocial.TrailingIcon = null;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            // 
            // txtCuit
            // 
            this.txtCuit.AnimateReadOnly = false;
            this.txtCuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCuit.Depth = 0;
            this.txtCuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCuit.HideSelection = true;
            this.txtCuit.Hint = "C.U.I.T";
            this.txtCuit.LeadingIcon = null;
            this.txtCuit.Location = new System.Drawing.Point(278, 102);
            this.txtCuit.MaxLength = 8;
            this.txtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PasswordChar = '\0';
            this.txtCuit.PrefixSuffixText = null;
            this.txtCuit.ReadOnly = false;
            this.txtCuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCuit.SelectedText = "";
            this.txtCuit.SelectionLength = 0;
            this.txtCuit.SelectionStart = 0;
            this.txtCuit.ShortcutsEnabled = true;
            this.txtCuit.Size = new System.Drawing.Size(255, 48);
            this.txtCuit.TabIndex = 313;
            this.txtCuit.TabStop = false;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCuit.TrailingIcon = null;
            this.txtCuit.UseSystemPasswordChar = false;
            // 
            // txtIngresosBrutos
            // 
            this.txtIngresosBrutos.AnimateReadOnly = false;
            this.txtIngresosBrutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIngresosBrutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIngresosBrutos.Depth = 0;
            this.txtIngresosBrutos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIngresosBrutos.HideSelection = true;
            this.txtIngresosBrutos.Hint = "Ingresos brutos";
            this.txtIngresosBrutos.LeadingIcon = null;
            this.txtIngresosBrutos.Location = new System.Drawing.Point(17, 156);
            this.txtIngresosBrutos.MaxLength = 8;
            this.txtIngresosBrutos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIngresosBrutos.Name = "txtIngresosBrutos";
            this.txtIngresosBrutos.PasswordChar = '\0';
            this.txtIngresosBrutos.PrefixSuffixText = null;
            this.txtIngresosBrutos.ReadOnly = false;
            this.txtIngresosBrutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIngresosBrutos.SelectedText = "";
            this.txtIngresosBrutos.SelectionLength = 0;
            this.txtIngresosBrutos.SelectionStart = 0;
            this.txtIngresosBrutos.ShortcutsEnabled = true;
            this.txtIngresosBrutos.Size = new System.Drawing.Size(255, 48);
            this.txtIngresosBrutos.TabIndex = 314;
            this.txtIngresosBrutos.TabStop = false;
            this.txtIngresosBrutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIngresosBrutos.TrailingIcon = null;
            this.txtIngresosBrutos.UseSystemPasswordChar = false;
            // 
            // cbCondicionIva
            // 
            this.cbCondicionIva.AutoResize = false;
            this.cbCondicionIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCondicionIva.Depth = 0;
            this.cbCondicionIva.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCondicionIva.DropDownHeight = 174;
            this.cbCondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicionIva.DropDownWidth = 121;
            this.cbCondicionIva.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCondicionIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCondicionIva.FormattingEnabled = true;
            this.cbCondicionIva.Hint = "Condición IVA";
            this.cbCondicionIva.IntegralHeight = false;
            this.cbCondicionIva.ItemHeight = 43;
            this.cbCondicionIva.Location = new System.Drawing.Point(278, 155);
            this.cbCondicionIva.MaxDropDownItems = 4;
            this.cbCondicionIva.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCondicionIva.Name = "cbCondicionIva";
            this.cbCondicionIva.Size = new System.Drawing.Size(256, 49);
            this.cbCondicionIva.StartIndex = 0;
            this.cbCondicionIva.TabIndex = 315;
            // 
            // pnlComercioDatos
            // 
            this.pnlComercioDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlComercioDatos.Controls.Add(this.btnQuitarLogo);
            this.pnlComercioDatos.Controls.Add(this.lblTitulo);
            this.pnlComercioDatos.Controls.Add(this.btnCancelar);
            this.pnlComercioDatos.Controls.Add(this.txtTelefono);
            this.pnlComercioDatos.Controls.Add(this.btnCambiarLogo);
            this.pnlComercioDatos.Controls.Add(this.btnGuardar);
            this.pnlComercioDatos.Controls.Add(this.picLogo);
            this.pnlComercioDatos.Controls.Add(this.txtCorreo);
            this.pnlComercioDatos.Controls.Add(this.materialDivider2);
            this.pnlComercioDatos.Controls.Add(this.txtCodigoPostal);
            this.pnlComercioDatos.Controls.Add(this.materialDivider1);
            this.pnlComercioDatos.Controls.Add(this.cbProvincia);
            this.pnlComercioDatos.Controls.Add(this.txtPuntoVenta);
            this.pnlComercioDatos.Controls.Add(this.txtCalleNombre);
            this.pnlComercioDatos.Controls.Add(this.txtCiudad);
            this.pnlComercioDatos.Controls.Add(this.txtFechaActualizacion);
            this.pnlComercioDatos.Controls.Add(this.txtCalleNumero);
            this.pnlComercioDatos.Controls.Add(this.txtInicioActividad);
            this.pnlComercioDatos.Controls.Add(this.cbCondicionIva);
            this.pnlComercioDatos.Controls.Add(this.txtRazonSocial);
            this.pnlComercioDatos.Controls.Add(this.txtIngresosBrutos);
            this.pnlComercioDatos.Controls.Add(this.txtCuit);
            this.pnlComercioDatos.Depth = 0;
            this.pnlComercioDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlComercioDatos.Location = new System.Drawing.Point(23, 23);
            this.pnlComercioDatos.Margin = new System.Windows.Forms.Padding(14);
            this.pnlComercioDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlComercioDatos.Name = "pnlComercioDatos";
            this.pnlComercioDatos.Padding = new System.Windows.Forms.Padding(14);
            this.pnlComercioDatos.Size = new System.Drawing.Size(736, 690);
            this.pnlComercioDatos.TabIndex = 316;
            // 
            // btnQuitarLogo
            // 
            this.btnQuitarLogo.AutoSize = false;
            this.btnQuitarLogo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarLogo.Depth = 0;
            this.btnQuitarLogo.HighEmphasis = false;
            this.btnQuitarLogo.Icon = global::CapaPresentacion.Properties.Resources.remove_image_32;
            this.btnQuitarLogo.Location = new System.Drawing.Point(557, 315);
            this.btnQuitarLogo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarLogo.Name = "btnQuitarLogo";
            this.btnQuitarLogo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnQuitarLogo.Size = new System.Drawing.Size(156, 36);
            this.btnQuitarLogo.TabIndex = 322;
            this.btnQuitarLogo.Text = "Quitar Logo";
            this.btnQuitarLogo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnQuitarLogo.UseAccentColor = false;
            this.btnQuitarLogo.UseVisualStyleBackColor = true;
            this.btnQuitarLogo.Click += new System.EventHandler(this.btnQuitarLogo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitulo.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblTitulo.Location = new System.Drawing.Point(227, 14);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(284, 41);
            this.lblTitulo.TabIndex = 317;
            this.lblTitulo.Text = "Datos comerciales";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(298, 629);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 321;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.frmComercio_Load);
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
            this.txtTelefono.LeadingIcon = global::CapaPresentacion.Properties.Resources.cell_32;
            this.txtTelefono.Location = new System.Drawing.Point(17, 529);
            this.txtTelefono.MaxLength = 8;
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
            this.txtTelefono.Size = new System.Drawing.Size(255, 48);
            this.txtTelefono.TabIndex = 312;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = global::CapaPresentacion.Properties.Resources.save_32;
            this.btnGuardar.Location = new System.Drawing.Point(132, 629);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 320;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.txtCorreo.LeadingIcon = global::CapaPresentacion.Properties.Resources.email_32;
            this.txtCorreo.Location = new System.Drawing.Point(278, 529);
            this.txtCorreo.MaxLength = 8;
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
            this.txtCorreo.Size = new System.Drawing.Size(255, 48);
            this.txtCorreo.TabIndex = 313;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(17, 508);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(517, 12);
            this.materialDivider2.TabIndex = 320;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.AnimateReadOnly = false;
            this.txtCodigoPostal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodigoPostal.Depth = 0;
            this.txtCodigoPostal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigoPostal.HideSelection = true;
            this.txtCodigoPostal.Hint = "Código postal";
            this.txtCodigoPostal.LeadingIcon = null;
            this.txtCodigoPostal.Location = new System.Drawing.Point(279, 396);
            this.txtCodigoPostal.MaxLength = 8;
            this.txtCodigoPostal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.PrefixSuffixText = null;
            this.txtCodigoPostal.ReadOnly = false;
            this.txtCodigoPostal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigoPostal.SelectedText = "";
            this.txtCodigoPostal.SelectionLength = 0;
            this.txtCodigoPostal.SelectionStart = 0;
            this.txtCodigoPostal.ShortcutsEnabled = true;
            this.txtCodigoPostal.Size = new System.Drawing.Size(255, 48);
            this.txtCodigoPostal.TabIndex = 318;
            this.txtCodigoPostal.TabStop = false;
            this.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoPostal.TrailingIcon = null;
            this.txtCodigoPostal.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 321);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(517, 12);
            this.materialDivider1.TabIndex = 319;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cbProvincia
            // 
            this.cbProvincia.AutoResize = false;
            this.cbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbProvincia.Depth = 0;
            this.cbProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbProvincia.DropDownHeight = 174;
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.DropDownWidth = 121;
            this.cbProvincia.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Hint = "Provincia";
            this.cbProvincia.IntegralHeight = false;
            this.cbProvincia.ItemHeight = 43;
            this.cbProvincia.Location = new System.Drawing.Point(17, 450);
            this.cbProvincia.MaxDropDownItems = 4;
            this.cbProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(256, 49);
            this.cbProvincia.StartIndex = 0;
            this.cbProvincia.TabIndex = 315;
            // 
            // txtPuntoVenta
            // 
            this.txtPuntoVenta.AnimateReadOnly = false;
            this.txtPuntoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPuntoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPuntoVenta.Depth = 0;
            this.txtPuntoVenta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPuntoVenta.HideSelection = true;
            this.txtPuntoVenta.Hint = "Punto de venta";
            this.txtPuntoVenta.LeadingIcon = null;
            this.txtPuntoVenta.Location = new System.Drawing.Point(17, 264);
            this.txtPuntoVenta.MaxLength = 8;
            this.txtPuntoVenta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPuntoVenta.Name = "txtPuntoVenta";
            this.txtPuntoVenta.PasswordChar = '\0';
            this.txtPuntoVenta.PrefixSuffixText = null;
            this.txtPuntoVenta.ReadOnly = false;
            this.txtPuntoVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPuntoVenta.SelectedText = "";
            this.txtPuntoVenta.SelectionLength = 0;
            this.txtPuntoVenta.SelectionStart = 0;
            this.txtPuntoVenta.ShortcutsEnabled = true;
            this.txtPuntoVenta.Size = new System.Drawing.Size(255, 48);
            this.txtPuntoVenta.TabIndex = 318;
            this.txtPuntoVenta.TabStop = false;
            this.txtPuntoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPuntoVenta.TrailingIcon = null;
            this.txtPuntoVenta.UseSystemPasswordChar = false;
            this.txtPuntoVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntoVenta_KeyPress);
            // 
            // txtCalleNombre
            // 
            this.txtCalleNombre.AnimateReadOnly = false;
            this.txtCalleNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalleNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCalleNombre.Depth = 0;
            this.txtCalleNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalleNombre.HideSelection = true;
            this.txtCalleNombre.Hint = "Calle";
            this.txtCalleNombre.LeadingIcon = null;
            this.txtCalleNombre.Location = new System.Drawing.Point(17, 342);
            this.txtCalleNombre.MaxLength = 8;
            this.txtCalleNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalleNombre.Name = "txtCalleNombre";
            this.txtCalleNombre.PasswordChar = '\0';
            this.txtCalleNombre.PrefixSuffixText = null;
            this.txtCalleNombre.ReadOnly = false;
            this.txtCalleNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalleNombre.SelectedText = "";
            this.txtCalleNombre.SelectionLength = 0;
            this.txtCalleNombre.SelectionStart = 0;
            this.txtCalleNombre.ShortcutsEnabled = true;
            this.txtCalleNombre.Size = new System.Drawing.Size(255, 48);
            this.txtCalleNombre.TabIndex = 312;
            this.txtCalleNombre.TabStop = false;
            this.txtCalleNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalleNombre.TrailingIcon = null;
            this.txtCalleNombre.UseSystemPasswordChar = false;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.HideSelection = true;
            this.txtCiudad.Hint = "Localidad";
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(17, 396);
            this.txtCiudad.MaxLength = 8;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.PrefixSuffixText = null;
            this.txtCiudad.ReadOnly = false;
            this.txtCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(255, 48);
            this.txtCiudad.TabIndex = 314;
            this.txtCiudad.TabStop = false;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.TrailingIcon = null;
            this.txtCiudad.UseSystemPasswordChar = false;
            // 
            // txtFechaActualizacion
            // 
            this.txtFechaActualizacion.AnimateReadOnly = false;
            this.txtFechaActualizacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFechaActualizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFechaActualizacion.Depth = 0;
            this.txtFechaActualizacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaActualizacion.HideSelection = true;
            this.txtFechaActualizacion.Hint = "Fecha de actualización";
            this.txtFechaActualizacion.LeadingIcon = null;
            this.txtFechaActualizacion.Location = new System.Drawing.Point(278, 210);
            this.txtFechaActualizacion.MaxLength = 8;
            this.txtFechaActualizacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaActualizacion.Name = "txtFechaActualizacion";
            this.txtFechaActualizacion.PasswordChar = '\0';
            this.txtFechaActualizacion.PrefixSuffixText = null;
            this.txtFechaActualizacion.ReadOnly = true;
            this.txtFechaActualizacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFechaActualizacion.SelectedText = "";
            this.txtFechaActualizacion.SelectionLength = 0;
            this.txtFechaActualizacion.SelectionStart = 0;
            this.txtFechaActualizacion.ShortcutsEnabled = true;
            this.txtFechaActualizacion.Size = new System.Drawing.Size(255, 48);
            this.txtFechaActualizacion.TabIndex = 317;
            this.txtFechaActualizacion.TabStop = false;
            this.txtFechaActualizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFechaActualizacion.TrailingIcon = null;
            this.txtFechaActualizacion.UseSystemPasswordChar = false;
            // 
            // txtCalleNumero
            // 
            this.txtCalleNumero.AnimateReadOnly = false;
            this.txtCalleNumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalleNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCalleNumero.Depth = 0;
            this.txtCalleNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalleNumero.HideSelection = true;
            this.txtCalleNumero.Hint = "Número";
            this.txtCalleNumero.LeadingIcon = null;
            this.txtCalleNumero.Location = new System.Drawing.Point(278, 342);
            this.txtCalleNumero.MaxLength = 8;
            this.txtCalleNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalleNumero.Name = "txtCalleNumero";
            this.txtCalleNumero.PasswordChar = '\0';
            this.txtCalleNumero.PrefixSuffixText = null;
            this.txtCalleNumero.ReadOnly = false;
            this.txtCalleNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalleNumero.SelectedText = "";
            this.txtCalleNumero.SelectionLength = 0;
            this.txtCalleNumero.SelectionStart = 0;
            this.txtCalleNumero.ShortcutsEnabled = true;
            this.txtCalleNumero.Size = new System.Drawing.Size(255, 48);
            this.txtCalleNumero.TabIndex = 313;
            this.txtCalleNumero.TabStop = false;
            this.txtCalleNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalleNumero.TrailingIcon = null;
            this.txtCalleNumero.UseSystemPasswordChar = false;
            // 
            // txtInicioActividad
            // 
            this.txtInicioActividad.AllowPromptAsInput = true;
            this.txtInicioActividad.AnimateReadOnly = false;
            this.txtInicioActividad.AsciiOnly = false;
            this.txtInicioActividad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtInicioActividad.BeepOnError = false;
            this.txtInicioActividad.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInicioActividad.Depth = 0;
            this.txtInicioActividad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInicioActividad.HidePromptOnLeave = false;
            this.txtInicioActividad.HideSelection = true;
            this.txtInicioActividad.Hint = "Inicio de actividad";
            this.txtInicioActividad.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtInicioActividad.LeadingIcon = null;
            this.txtInicioActividad.Location = new System.Drawing.Point(17, 210);
            this.txtInicioActividad.Mask = "00/00/0000";
            this.txtInicioActividad.MaxLength = 32767;
            this.txtInicioActividad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInicioActividad.Name = "txtInicioActividad";
            this.txtInicioActividad.PasswordChar = '\0';
            this.txtInicioActividad.PrefixSuffixText = null;
            this.txtInicioActividad.PromptChar = '_';
            this.txtInicioActividad.ReadOnly = false;
            this.txtInicioActividad.RejectInputOnFirstFailure = false;
            this.txtInicioActividad.ResetOnPrompt = true;
            this.txtInicioActividad.ResetOnSpace = true;
            this.txtInicioActividad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInicioActividad.SelectedText = "";
            this.txtInicioActividad.SelectionLength = 0;
            this.txtInicioActividad.SelectionStart = 0;
            this.txtInicioActividad.ShortcutsEnabled = true;
            this.txtInicioActividad.Size = new System.Drawing.Size(255, 48);
            this.txtInicioActividad.SkipLiterals = true;
            this.txtInicioActividad.TabIndex = 316;
            this.txtInicioActividad.TabStop = false;
            this.txtInicioActividad.Text = "  /  /";
            this.txtInicioActividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInicioActividad.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtInicioActividad.TrailingIcon = null;
            this.txtInicioActividad.UseSystemPasswordChar = false;
            this.txtInicioActividad.ValidatingType = null;
            // 
            // frmComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(782, 736);
            this.Controls.Add(this.pnlComercioDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComercio";
            this.Text = "Comercio";
            this.Load += new System.EventHandler(this.frmComercio_Load);
            this.Resize += new System.EventHandler(this.frmComercio_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlComercioDatos.ResumeLayout(false);
            this.pnlComercioDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private MaterialSkin.Controls.MaterialButton btnCambiarLogo;
        private MaterialSkin.Controls.MaterialTextBox2 txtRazonSocial;
        private MaterialSkin.Controls.MaterialTextBox2 txtCuit;
        private MaterialSkin.Controls.MaterialTextBox2 txtIngresosBrutos;
        private MaterialSkin.Controls.MaterialComboBox cbCondicionIva;
        private MaterialSkin.Controls.MaterialCard pnlComercioDatos;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtInicioActividad;
        private MaterialSkin.Controls.MaterialTextBox2 txtFechaActualizacion;
        private MaterialSkin.Controls.MaterialComboBox cbProvincia;
        private MaterialSkin.Controls.MaterialTextBox2 txtCalleNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtCiudad;
        private MaterialSkin.Controls.MaterialTextBox2 txtCalleNumero;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodigoPostal;
        private MaterialSkin.Controls.MaterialTextBox2 txtPuntoVenta;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialButton btnQuitarLogo;
    }
}