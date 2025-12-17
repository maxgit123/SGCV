namespace CapaPresentacion.Formularios
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDocumento = new MaterialSkin.Controls.MaterialTextBox();
            this.btnIngrsar = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.lblSGCV = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.lblSGCV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 326);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.shop_100;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtClave);
            this.materialCard1.Controls.Add(this.txtDocumento);
            this.materialCard1.Controls.Add(this.btnIngrsar);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(203, 27);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(253, 280);
            this.materialCard1.TabIndex = 12;
            // 
            // txtClave
            // 
            this.txtClave.AnimateReadOnly = false;
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClave.Depth = 0;
            this.txtClave.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClave.HideSelection = true;
            this.txtClave.Hint = "Clave";
            this.txtClave.LeadingIcon = null;
            this.txtClave.Location = new System.Drawing.Point(18, 73);
            this.txtClave.MaxLength = 200;
            this.txtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '●';
            this.txtClave.PrefixSuffixText = null;
            this.txtClave.ReadOnly = false;
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.Size = new System.Drawing.Size(219, 48);
            this.txtClave.TabIndex = 2;
            this.txtClave.TabStop = false;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClave.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("txtClave.TrailingIcon")));
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TrailingIconClick += new System.EventHandler(this.txtClave_TrailingIconClick);
            // 
            // txtDocumento
            // 
            this.txtDocumento.AnimateReadOnly = false;
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.LeadingIcon = null;
            this.txtDocumento.Location = new System.Drawing.Point(17, 17);
            this.txtDocumento.MaxLength = 8;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDocumento.Multiline = false;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(219, 50);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.Text = "";
            this.txtDocumento.TrailingIcon = null;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // btnIngrsar
            // 
            this.btnIngrsar.AutoSize = false;
            this.btnIngrsar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngrsar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnIngrsar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIngrsar.Depth = 0;
            this.btnIngrsar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnIngrsar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngrsar.HighEmphasis = true;
            this.btnIngrsar.Icon = null;
            this.btnIngrsar.Location = new System.Drawing.Point(18, 165);
            this.btnIngrsar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngrsar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngrsar.Name = "btnIngrsar";
            this.btnIngrsar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIngrsar.Size = new System.Drawing.Size(219, 36);
            this.btnIngrsar.TabIndex = 3;
            this.btnIngrsar.Text = "Ingresar";
            this.btnIngrsar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIngrsar.UseAccentColor = false;
            this.btnIngrsar.UseVisualStyleBackColor = false;
            this.btnIngrsar.Click += new System.EventHandler(this.btnIngrsar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(18, 213);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(219, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSGCV
            // 
            this.lblSGCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSGCV.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSGCV.Location = new System.Drawing.Point(18, 192);
            this.lblSGCV.Name = "lblSGCV";
            this.lblSGCV.Size = new System.Drawing.Size(168, 44);
            this.lblSGCV.TabIndex = 1;
            this.lblSGCV.Text = "Sistema de Gestion de Compra y Venta";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngrsar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(476, 390);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSGCV;
        private MaterialSkin.Controls.MaterialButton btnIngrsar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtDocumento;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtClave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

