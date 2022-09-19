namespace AppControlTraficoPorteria
{
    partial class CompletarInfoCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletarInfoCamion));
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtNRemito1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtHojaRuta1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrecintos1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDestino1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtObservaciones1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCompletar1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // dtpSalida
            // 
            this.dtpSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(139, 406);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(148, 23);
            this.dtpSalida.TabIndex = 72;
            this.dtpSalida.Value = new System.DateTime(2022, 9, 1, 10, 15, 5, 0);
            // 
            // lblSalida
            // 
            this.lblSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalida.Location = new System.Drawing.Point(84, 408);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(49, 16);
            this.lblSalida.TabIndex = 71;
            this.lblSalida.Text = "Salida:";
            // 
            // txtNRemito1
            // 
            this.txtNRemito1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNRemito1.AnimateReadOnly = false;
            this.txtNRemito1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNRemito1.Depth = 0;
            this.txtNRemito1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNRemito1.Hint = "N° de remito";
            this.txtNRemito1.LeadingIcon = null;
            this.txtNRemito1.Location = new System.Drawing.Point(80, 105);
            this.txtNRemito1.MaxLength = 50;
            this.txtNRemito1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNRemito1.Multiline = false;
            this.txtNRemito1.Name = "txtNRemito1";
            this.txtNRemito1.Size = new System.Drawing.Size(312, 50);
            this.txtNRemito1.TabIndex = 4;
            this.txtNRemito1.Text = "";
            this.txtNRemito1.TrailingIcon = null;
            // 
            // txtHojaRuta1
            // 
            this.txtHojaRuta1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHojaRuta1.AnimateReadOnly = false;
            this.txtHojaRuta1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHojaRuta1.Depth = 0;
            this.txtHojaRuta1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHojaRuta1.Hint = "Hoja de ruta";
            this.txtHojaRuta1.LeadingIcon = null;
            this.txtHojaRuta1.Location = new System.Drawing.Point(80, 161);
            this.txtHojaRuta1.MaxLength = 50;
            this.txtHojaRuta1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHojaRuta1.Multiline = false;
            this.txtHojaRuta1.Name = "txtHojaRuta1";
            this.txtHojaRuta1.Size = new System.Drawing.Size(312, 50);
            this.txtHojaRuta1.TabIndex = 5;
            this.txtHojaRuta1.Text = "";
            this.txtHojaRuta1.TrailingIcon = null;
            // 
            // txtPrecintos1
            // 
            this.txtPrecintos1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecintos1.AnimateReadOnly = false;
            this.txtPrecintos1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecintos1.Depth = 0;
            this.txtPrecintos1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecintos1.Hint = "Precintos";
            this.txtPrecintos1.LeadingIcon = null;
            this.txtPrecintos1.Location = new System.Drawing.Point(80, 217);
            this.txtPrecintos1.MaxLength = 50;
            this.txtPrecintos1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrecintos1.Multiline = false;
            this.txtPrecintos1.Name = "txtPrecintos1";
            this.txtPrecintos1.Size = new System.Drawing.Size(312, 50);
            this.txtPrecintos1.TabIndex = 6;
            this.txtPrecintos1.Text = "";
            this.txtPrecintos1.TrailingIcon = null;
            // 
            // txtDestino1
            // 
            this.txtDestino1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDestino1.AnimateReadOnly = false;
            this.txtDestino1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestino1.Depth = 0;
            this.txtDestino1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDestino1.Hint = "Destino";
            this.txtDestino1.LeadingIcon = null;
            this.txtDestino1.Location = new System.Drawing.Point(80, 273);
            this.txtDestino1.MaxLength = 50;
            this.txtDestino1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDestino1.Multiline = false;
            this.txtDestino1.Name = "txtDestino1";
            this.txtDestino1.Size = new System.Drawing.Size(312, 50);
            this.txtDestino1.TabIndex = 7;
            this.txtDestino1.Text = "";
            this.txtDestino1.TrailingIcon = null;
            // 
            // txtObservaciones1
            // 
            this.txtObservaciones1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObservaciones1.AnimateReadOnly = false;
            this.txtObservaciones1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones1.Depth = 0;
            this.txtObservaciones1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservaciones1.Hint = "Observaciones";
            this.txtObservaciones1.LeadingIcon = null;
            this.txtObservaciones1.Location = new System.Drawing.Point(80, 329);
            this.txtObservaciones1.MaxLength = 50;
            this.txtObservaciones1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservaciones1.Multiline = false;
            this.txtObservaciones1.Name = "txtObservaciones1";
            this.txtObservaciones1.Size = new System.Drawing.Size(312, 50);
            this.txtObservaciones1.TabIndex = 8;
            this.txtObservaciones1.Text = "";
            this.txtObservaciones1.TrailingIcon = null;
            // 
            // btnCompletar1
            // 
            this.btnCompletar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompletar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompletar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompletar1.Depth = 0;
            this.btnCompletar1.HighEmphasis = true;
            this.btnCompletar1.Icon = null;
            this.btnCompletar1.Location = new System.Drawing.Point(284, 458);
            this.btnCompletar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompletar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompletar1.Name = "btnCompletar1";
            this.btnCompletar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompletar1.Size = new System.Drawing.Size(108, 36);
            this.btnCompletar1.TabIndex = 106;
            this.btnCompletar1.Text = "Completar";
            this.btnCompletar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompletar1.UseAccentColor = false;
            this.btnCompletar1.UseVisualStyleBackColor = true;
            this.btnCompletar1.Click += new System.EventHandler(this.btnCompletar1_Click);
            // 
            // CompletarInfoCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 525);
            this.Controls.Add(this.btnCompletar1);
            this.Controls.Add(this.txtObservaciones1);
            this.Controls.Add(this.txtDestino1);
            this.Controls.Add(this.txtPrecintos1);
            this.Controls.Add(this.txtHojaRuta1);
            this.Controls.Add(this.txtNRemito1);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblSalida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompletarInfoCamion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Completar camion";
            this.Load += new System.EventHandler(this.CompletarInfoCamion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblSalida;
        private MaterialSkin.Controls.MaterialTextBox txtNRemito1;
        private MaterialSkin.Controls.MaterialTextBox txtHojaRuta1;
        private MaterialSkin.Controls.MaterialTextBox txtPrecintos1;
        private MaterialSkin.Controls.MaterialTextBox txtDestino1;
        private MaterialSkin.Controls.MaterialTextBox txtObservaciones1;
        private MaterialSkin.Controls.MaterialButton btnCompletar1;
    }
}