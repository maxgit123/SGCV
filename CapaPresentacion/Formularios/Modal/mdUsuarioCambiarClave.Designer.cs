namespace CapaPresentacion.Formularios.Modal
{
    partial class mdUsuarioCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdUsuarioCambiarClave));
            this.txtClaveActual = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtClaveNueva2 = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtClaveNueva = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaveActual.AnimateReadOnly = false;
            this.txtClaveActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClaveActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClaveActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClaveActual.Depth = 0;
            this.txtClaveActual.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClaveActual.HideSelection = true;
            this.txtClaveActual.Hint = "Clave actual";
            this.txtClaveActual.LeadingIcon = null;
            this.txtClaveActual.Location = new System.Drawing.Point(17, 32);
            this.txtClaveActual.MaxLength = 32767;
            this.txtClaveActual.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '●';
            this.txtClaveActual.PrefixSuffixText = null;
            this.txtClaveActual.ReadOnly = false;
            this.txtClaveActual.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClaveActual.SelectedText = "";
            this.txtClaveActual.SelectionLength = 0;
            this.txtClaveActual.SelectionStart = 0;
            this.txtClaveActual.ShortcutsEnabled = true;
            this.txtClaveActual.Size = new System.Drawing.Size(256, 48);
            this.txtClaveActual.TabIndex = 0;
            this.txtClaveActual.TabStop = false;
            this.txtClaveActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClaveActual.TrailingIcon = global::CapaPresentacion.Properties.Resources.hide_32;
            this.txtClaveActual.UseSystemPasswordChar = true;
            this.txtClaveActual.TrailingIconClick += new System.EventHandler(this.txtClave_TrailingIconClick);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.txtClaveNueva2);
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnGuardar);
            this.materialCard1.Controls.Add(this.txtClaveNueva);
            this.materialCard1.Controls.Add(this.txtClaveActual);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(292, 311);
            this.materialCard1.TabIndex = 1;
            // 
            // txtClaveNueva2
            // 
            this.txtClaveNueva2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaveNueva2.AnimateReadOnly = false;
            this.txtClaveNueva2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClaveNueva2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClaveNueva2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClaveNueva2.Depth = 0;
            this.txtClaveNueva2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClaveNueva2.HideSelection = true;
            this.txtClaveNueva2.Hint = "Repetir clave nueva";
            this.txtClaveNueva2.LeadingIcon = null;
            this.txtClaveNueva2.Location = new System.Drawing.Point(17, 140);
            this.txtClaveNueva2.MaxLength = 32767;
            this.txtClaveNueva2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClaveNueva2.Name = "txtClaveNueva2";
            this.txtClaveNueva2.PasswordChar = '●';
            this.txtClaveNueva2.PrefixSuffixText = null;
            this.txtClaveNueva2.ReadOnly = false;
            this.txtClaveNueva2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClaveNueva2.SelectedText = "";
            this.txtClaveNueva2.SelectionLength = 0;
            this.txtClaveNueva2.SelectionStart = 0;
            this.txtClaveNueva2.ShortcutsEnabled = true;
            this.txtClaveNueva2.Size = new System.Drawing.Size(256, 48);
            this.txtClaveNueva2.TabIndex = 318;
            this.txtClaveNueva2.TabStop = false;
            this.txtClaveNueva2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClaveNueva2.TrailingIcon = global::CapaPresentacion.Properties.Resources.hide_32;
            this.txtClaveNueva2.UseSystemPasswordChar = true;
            this.txtClaveNueva2.TrailingIconClick += new System.EventHandler(this.txtClave_TrailingIconClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.HighEmphasis = false;
            this.btnCancelar.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Icon")));
            this.btnCancelar.Location = new System.Drawing.Point(149, 238);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 317;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = global::CapaPresentacion.Properties.Resources.save_32;
            this.btnGuardar.Location = new System.Drawing.Point(17, 238);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGuardar.Size = new System.Drawing.Size(116, 36);
            this.btnGuardar.TabIndex = 316;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClaveNueva.AnimateReadOnly = false;
            this.txtClaveNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClaveNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClaveNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClaveNueva.Depth = 0;
            this.txtClaveNueva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClaveNueva.HideSelection = true;
            this.txtClaveNueva.Hint = "Clave nueva";
            this.txtClaveNueva.LeadingIcon = null;
            this.txtClaveNueva.Location = new System.Drawing.Point(17, 86);
            this.txtClaveNueva.MaxLength = 32767;
            this.txtClaveNueva.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '●';
            this.txtClaveNueva.PrefixSuffixText = null;
            this.txtClaveNueva.ReadOnly = false;
            this.txtClaveNueva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClaveNueva.SelectedText = "";
            this.txtClaveNueva.SelectionLength = 0;
            this.txtClaveNueva.SelectionStart = 0;
            this.txtClaveNueva.ShortcutsEnabled = true;
            this.txtClaveNueva.Size = new System.Drawing.Size(256, 48);
            this.txtClaveNueva.TabIndex = 1;
            this.txtClaveNueva.TabStop = false;
            this.txtClaveNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClaveNueva.TrailingIcon = global::CapaPresentacion.Properties.Resources.hide_32;
            this.txtClaveNueva.UseSystemPasswordChar = true;
            this.txtClaveNueva.TrailingIconClick += new System.EventHandler(this.txtClave_TrailingIconClick);
            // 
            // mdUsuarioCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 375);
            this.Controls.Add(this.materialCard1);
            this.Name = "mdUsuarioCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar clave";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtClaveActual;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtClaveNueva;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtClaveNueva2;
    }
}