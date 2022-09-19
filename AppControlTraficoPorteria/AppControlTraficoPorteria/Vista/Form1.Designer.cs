namespace AppControlTraficoPorteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCamion1 = new MaterialSkin.Controls.MaterialButton();
            this.btnHistorialCamines1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnCamion1
            // 
            this.btnCamion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCamion1.AutoSize = false;
            this.btnCamion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCamion1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCamion1.Depth = 0;
            this.btnCamion1.HighEmphasis = true;
            this.btnCamion1.Icon = null;
            this.btnCamion1.Location = new System.Drawing.Point(162, 217);
            this.btnCamion1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCamion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCamion1.Name = "btnCamion1";
            this.btnCamion1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCamion1.Size = new System.Drawing.Size(242, 58);
            this.btnCamion1.TabIndex = 4;
            this.btnCamion1.Text = "Camion";
            this.btnCamion1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCamion1.UseAccentColor = false;
            this.btnCamion1.UseVisualStyleBackColor = true;
            this.btnCamion1.Click += new System.EventHandler(this.btnCamion1_Click);
            // 
            // btnHistorialCamines1
            // 
            this.btnHistorialCamines1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorialCamines1.AutoSize = false;
            this.btnHistorialCamines1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistorialCamines1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHistorialCamines1.Depth = 0;
            this.btnHistorialCamines1.HighEmphasis = true;
            this.btnHistorialCamines1.Icon = null;
            this.btnHistorialCamines1.Location = new System.Drawing.Point(473, 217);
            this.btnHistorialCamines1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistorialCamines1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistorialCamines1.Name = "btnHistorialCamines1";
            this.btnHistorialCamines1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHistorialCamines1.Size = new System.Drawing.Size(242, 58);
            this.btnHistorialCamines1.TabIndex = 5;
            this.btnHistorialCamines1.Text = "Historial de camiones";
            this.btnHistorialCamines1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnHistorialCamines1.UseAccentColor = false;
            this.btnHistorialCamines1.UseVisualStyleBackColor = true;
            this.btnHistorialCamines1.Click += new System.EventHandler(this.btnHistorialCamines1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(298, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(270, 29);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Control tráfico Camiones";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Depth = 0;
            this.label.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label.Location = new System.Drawing.Point(46, 383);
            this.label.MouseState = MaterialSkin.MouseState.HOVER;
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 19);
            this.label.TabIndex = 16;
            this.label.Text = "materialLabel2";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.AutoSize = false;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(750, 393);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Size = new System.Drawing.Size(124, 36);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(886, 439);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnHistorialCamines1);
            this.Controls.Add(this.btnCamion1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porteria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnCamion1;
        private MaterialSkin.Controls.MaterialButton btnHistorialCamines1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel label;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
    }
}
