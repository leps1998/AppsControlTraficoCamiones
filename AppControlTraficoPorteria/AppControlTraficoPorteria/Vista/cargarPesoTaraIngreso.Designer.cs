namespace AppControlTraficoPorteria
{
    partial class cargarPesoTaraIngreso
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
            this.components = new System.ComponentModel.Container();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtPesoTara1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel4.Location = new System.Drawing.Point(50, 102);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 92;
            this.materialLabel4.Text = "Ingreso:";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(130, 99);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(173, 23);
            this.dtpIngreso.TabIndex = 91;
            this.dtpIngreso.Value = new System.DateTime(2022, 9, 8, 0, 0, 0, 0);
            // 
            // txtPesoTara1
            // 
            this.txtPesoTara1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoTara1.AnimateReadOnly = false;
            this.txtPesoTara1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoTara1.Depth = 0;
            this.txtPesoTara1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesoTara1.Hint = "Peso tara";
            this.txtPesoTara1.LeadingIcon = null;
            this.txtPesoTara1.Location = new System.Drawing.Point(50, 179);
            this.txtPesoTara1.MaxLength = 50;
            this.txtPesoTara1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoTara1.Multiline = false;
            this.txtPesoTara1.Name = "txtPesoTara1";
            this.txtPesoTara1.Size = new System.Drawing.Size(312, 50);
            this.txtPesoTara1.TabIndex = 93;
            this.txtPesoTara1.Text = "";
            this.txtPesoTara1.TrailingIcon = null;
            this.txtPesoTara1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoTara1_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = null;
            this.btnAgregar.Location = new System.Drawing.Point(274, 290);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar.Size = new System.Drawing.Size(88, 36);
            this.btnAgregar.TabIndex = 94;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cargarPesoTaraIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 382);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPesoTara1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dtpIngreso);
            this.Name = "cargarPesoTaraIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peso tara";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private MaterialSkin.Controls.MaterialTextBox txtPesoTara1;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}