namespace AppControlTraficoPorteria
{
    partial class CargaBrutoNeto
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
            this.btnCargar = new MaterialSkin.Controls.MaterialButton();
            this.txtPesoBruto1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPesoNeto1 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargar.Depth = 0;
            this.btnCargar.HighEmphasis = true;
            this.btnCargar.Icon = null;
            this.btnCargar.Location = new System.Drawing.Point(269, 215);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargar.Size = new System.Drawing.Size(79, 36);
            this.btnCargar.TabIndex = 107;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargar.UseAccentColor = false;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtPesoBruto1
            // 
            this.txtPesoBruto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoBruto1.AnimateReadOnly = false;
            this.txtPesoBruto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoBruto1.Depth = 0;
            this.txtPesoBruto1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesoBruto1.Hint = "Peso bruto";
            this.txtPesoBruto1.LeadingIcon = null;
            this.txtPesoBruto1.Location = new System.Drawing.Point(36, 100);
            this.txtPesoBruto1.MaxLength = 50;
            this.txtPesoBruto1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoBruto1.Multiline = false;
            this.txtPesoBruto1.Name = "txtPesoBruto1";
            this.txtPesoBruto1.Size = new System.Drawing.Size(312, 50);
            this.txtPesoBruto1.TabIndex = 4;
            this.txtPesoBruto1.Text = "";
            this.txtPesoBruto1.TrailingIcon = null;
            this.txtPesoBruto1.TextChanged += new System.EventHandler(this.txtPesoBruto1_TextChanged_1);
            this.txtPesoBruto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoBruto1_KeyPress);
            // 
            // txtPesoNeto1
            // 
            this.txtPesoNeto1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesoNeto1.AnimateReadOnly = false;
            this.txtPesoNeto1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoNeto1.Depth = 0;
            this.txtPesoNeto1.Enabled = false;
            this.txtPesoNeto1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesoNeto1.Hint = "Peso neto";
            this.txtPesoNeto1.LeadingIcon = null;
            this.txtPesoNeto1.Location = new System.Drawing.Point(36, 156);
            this.txtPesoNeto1.MaxLength = 50;
            this.txtPesoNeto1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPesoNeto1.Multiline = false;
            this.txtPesoNeto1.Name = "txtPesoNeto1";
            this.txtPesoNeto1.Size = new System.Drawing.Size(312, 50);
            this.txtPesoNeto1.TabIndex = 5;
            this.txtPesoNeto1.Text = "";
            this.txtPesoNeto1.TrailingIcon = null;
            // 
            // CargaBrutoNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 295);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtPesoNeto1);
            this.Controls.Add(this.txtPesoBruto1);
            this.Name = "CargaBrutoNeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga peso bruto y neto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnCargar;
        private MaterialSkin.Controls.MaterialTextBox txtPesoBruto1;
        private MaterialSkin.Controls.MaterialTextBox txtPesoNeto1;
    }
}