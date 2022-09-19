namespace AppControlTraficoPorteria
{
    partial class NuevoCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoCamion));
            this.dtpArribo = new System.Windows.Forms.DateTimePicker();
            this.txtTrasporte1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPatenteTractor1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPatenteSemi1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProveedor1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreChofer1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellidoChofer1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDniChofer1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAgregar1 = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar1 = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpArribo
            // 
            this.dtpArribo.CustomFormat = "";
            this.dtpArribo.Enabled = false;
            this.dtpArribo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpArribo.Location = new System.Drawing.Point(109, 444);
            this.dtpArribo.Name = "dtpArribo";
            this.dtpArribo.Size = new System.Drawing.Size(173, 23);
            this.dtpArribo.TabIndex = 73;
            this.dtpArribo.Value = new System.DateTime(2022, 9, 8, 12, 54, 40, 0);
            // 
            // txtTrasporte1
            // 
            this.txtTrasporte1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrasporte1.AnimateReadOnly = false;
            this.txtTrasporte1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrasporte1.Depth = 0;
            this.txtTrasporte1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrasporte1.Hint = "Trasporte";
            this.txtTrasporte1.LeadingIcon = null;
            this.txtTrasporte1.Location = new System.Drawing.Point(29, 129);
            this.txtTrasporte1.MaxLength = 50;
            this.txtTrasporte1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTrasporte1.Multiline = false;
            this.txtTrasporte1.Name = "txtTrasporte1";
            this.txtTrasporte1.Size = new System.Drawing.Size(253, 50);
            this.txtTrasporte1.TabIndex = 83;
            this.txtTrasporte1.Text = "";
            this.txtTrasporte1.TrailingIcon = null;
            // 
            // txtPatenteTractor1
            // 
            this.txtPatenteTractor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatenteTractor1.AnimateReadOnly = false;
            this.txtPatenteTractor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatenteTractor1.Depth = 0;
            this.txtPatenteTractor1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPatenteTractor1.Hint = "Patente tractor";
            this.txtPatenteTractor1.LeadingIcon = null;
            this.txtPatenteTractor1.Location = new System.Drawing.Point(29, 185);
            this.txtPatenteTractor1.MaxLength = 50;
            this.txtPatenteTractor1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPatenteTractor1.Multiline = false;
            this.txtPatenteTractor1.Name = "txtPatenteTractor1";
            this.txtPatenteTractor1.Size = new System.Drawing.Size(253, 50);
            this.txtPatenteTractor1.TabIndex = 84;
            this.txtPatenteTractor1.Text = "";
            this.txtPatenteTractor1.TrailingIcon = null;
            this.txtPatenteTractor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatenteTractor1_KeyPress);
            // 
            // txtPatenteSemi1
            // 
            this.txtPatenteSemi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatenteSemi1.AnimateReadOnly = false;
            this.txtPatenteSemi1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatenteSemi1.Depth = 0;
            this.txtPatenteSemi1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPatenteSemi1.Hint = "Patente semi";
            this.txtPatenteSemi1.LeadingIcon = null;
            this.txtPatenteSemi1.Location = new System.Drawing.Point(29, 241);
            this.txtPatenteSemi1.MaxLength = 50;
            this.txtPatenteSemi1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPatenteSemi1.Multiline = false;
            this.txtPatenteSemi1.Name = "txtPatenteSemi1";
            this.txtPatenteSemi1.Size = new System.Drawing.Size(253, 50);
            this.txtPatenteSemi1.TabIndex = 85;
            this.txtPatenteSemi1.Text = "";
            this.txtPatenteSemi1.TrailingIcon = null;
            this.txtPatenteSemi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatenteSemi1_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(29, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(155, 24);
            this.materialLabel1.TabIndex = 86;
            this.materialLabel1.Text = "Datos del camion";
            // 
            // txtProveedor1
            // 
            this.txtProveedor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProveedor1.AnimateReadOnly = false;
            this.txtProveedor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProveedor1.Depth = 0;
            this.txtProveedor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProveedor1.Hint = "Proveedor";
            this.txtProveedor1.LeadingIcon = null;
            this.txtProveedor1.Location = new System.Drawing.Point(29, 356);
            this.txtProveedor1.MaxLength = 50;
            this.txtProveedor1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProveedor1.Multiline = false;
            this.txtProveedor1.Name = "txtProveedor1";
            this.txtProveedor1.Size = new System.Drawing.Size(253, 50);
            this.txtProveedor1.TabIndex = 87;
            this.txtProveedor1.Text = "Berry global";
            this.txtProveedor1.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(29, 313);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 24);
            this.materialLabel2.TabIndex = 88;
            this.materialLabel2.Text = "Datos";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(29, 448);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(47, 19);
            this.materialLabel3.TabIndex = 89;
            this.materialLabel3.Text = "Arribo:";
            // 
            // txtNombreChofer1
            // 
            this.txtNombreChofer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreChofer1.AnimateReadOnly = false;
            this.txtNombreChofer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreChofer1.Depth = 0;
            this.txtNombreChofer1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreChofer1.Hint = "Nombre chofer";
            this.txtNombreChofer1.LeadingIcon = null;
            this.txtNombreChofer1.Location = new System.Drawing.Point(358, 129);
            this.txtNombreChofer1.MaxLength = 50;
            this.txtNombreChofer1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreChofer1.Multiline = false;
            this.txtNombreChofer1.Name = "txtNombreChofer1";
            this.txtNombreChofer1.Size = new System.Drawing.Size(253, 50);
            this.txtNombreChofer1.TabIndex = 91;
            this.txtNombreChofer1.Text = "";
            this.txtNombreChofer1.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(358, 86);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(184, 24);
            this.materialLabel5.TabIndex = 92;
            this.materialLabel5.Text = "Datos del camionero";
            // 
            // txtApellidoChofer1
            // 
            this.txtApellidoChofer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidoChofer1.AnimateReadOnly = false;
            this.txtApellidoChofer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoChofer1.Depth = 0;
            this.txtApellidoChofer1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoChofer1.Hint = "Apellido chofer";
            this.txtApellidoChofer1.LeadingIcon = null;
            this.txtApellidoChofer1.Location = new System.Drawing.Point(358, 185);
            this.txtApellidoChofer1.MaxLength = 50;
            this.txtApellidoChofer1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoChofer1.Multiline = false;
            this.txtApellidoChofer1.Name = "txtApellidoChofer1";
            this.txtApellidoChofer1.Size = new System.Drawing.Size(253, 50);
            this.txtApellidoChofer1.TabIndex = 93;
            this.txtApellidoChofer1.Text = "";
            this.txtApellidoChofer1.TrailingIcon = null;
            // 
            // txtDniChofer1
            // 
            this.txtDniChofer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDniChofer1.AnimateReadOnly = false;
            this.txtDniChofer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDniChofer1.Depth = 0;
            this.txtDniChofer1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDniChofer1.Hint = "Dni chofer";
            this.txtDniChofer1.LeadingIcon = null;
            this.txtDniChofer1.Location = new System.Drawing.Point(358, 241);
            this.txtDniChofer1.MaxLength = 50;
            this.txtDniChofer1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDniChofer1.Multiline = false;
            this.txtDniChofer1.Name = "txtDniChofer1";
            this.txtDniChofer1.Size = new System.Drawing.Size(253, 50);
            this.txtDniChofer1.TabIndex = 94;
            this.txtDniChofer1.Text = "";
            this.txtDniChofer1.TrailingIcon = null;
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar1.AutoSize = false;
            this.btnAgregar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar1.Depth = 0;
            this.btnAgregar1.HighEmphasis = true;
            this.btnAgregar1.Icon = null;
            this.btnAgregar1.Location = new System.Drawing.Point(358, 356);
            this.btnAgregar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAgregar1.Size = new System.Drawing.Size(129, 36);
            this.btnAgregar1.TabIndex = 95;
            this.btnAgregar1.Text = "Agregar camion";
            this.btnAgregar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar1.UseAccentColor = false;
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar1.AutoSize = false;
            this.btnCancelar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar1.Depth = 0;
            this.btnCancelar1.HighEmphasis = true;
            this.btnCancelar1.Icon = null;
            this.btnCancelar1.Location = new System.Drawing.Point(497, 356);
            this.btnCancelar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar1.Size = new System.Drawing.Size(114, 36);
            this.btnCancelar1.TabIndex = 96;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar1.UseAccentColor = false;
            this.btnCancelar1.UseVisualStyleBackColor = true;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.btnCancelar1);
            this.Controls.Add(this.btnAgregar1);
            this.Controls.Add(this.txtDniChofer1);
            this.Controls.Add(this.txtApellidoChofer1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtNombreChofer1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtProveedor1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPatenteSemi1);
            this.Controls.Add(this.txtPatenteTractor1);
            this.Controls.Add(this.txtTrasporte1);
            this.Controls.Add(this.dtpArribo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevoCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo camion";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpArribo;
        private MaterialSkin.Controls.MaterialTextBox txtTrasporte1;
        private MaterialSkin.Controls.MaterialTextBox txtPatenteTractor1;
        private MaterialSkin.Controls.MaterialTextBox txtPatenteSemi1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtProveedor1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtNombreChofer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoChofer1;
        private MaterialSkin.Controls.MaterialTextBox txtDniChofer1;
        private MaterialSkin.Controls.MaterialButton btnAgregar1;
        private MaterialSkin.Controls.MaterialButton btnCancelar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}