namespace AppControlTraficoLogistica
{
    partial class AsignacionDock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionDock));
            this.cmbDock1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAsignarDock1 = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // cmbDock1
            // 
            this.cmbDock1.AutoResize = false;
            this.cmbDock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbDock1.Depth = 0;
            this.cmbDock1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbDock1.DropDownHeight = 174;
            this.cmbDock1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDock1.DropDownWidth = 121;
            this.cmbDock1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbDock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbDock1.FormattingEnabled = true;
            this.cmbDock1.Hint = "Numero dock";
            this.cmbDock1.IntegralHeight = false;
            this.cmbDock1.ItemHeight = 43;
            this.cmbDock1.Items.AddRange(new object[] {
            "Dock 1",
            "Dock 2",
            "Dock 3",
            "Dock 4",
            "Dock 5",
            "Dock 6",
            "Dock 7",
            "Dock 8"});
            this.cmbDock1.Location = new System.Drawing.Point(109, 84);
            this.cmbDock1.MaxDropDownItems = 4;
            this.cmbDock1.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbDock1.Name = "cmbDock1";
            this.cmbDock1.Size = new System.Drawing.Size(139, 49);
            this.cmbDock1.StartIndex = 0;
            this.cmbDock1.TabIndex = 83;
            this.cmbDock1.SelectedIndexChanged += new System.EventHandler(this.cmbDock1_SelectedIndexChanged);
            // 
            // btnAsignarDock1
            // 
            this.btnAsignarDock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsignarDock1.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignarDock1.Depth = 0;
            this.btnAsignarDock1.HighEmphasis = true;
            this.btnAsignarDock1.Icon = null;
            this.btnAsignarDock1.Location = new System.Drawing.Point(134, 142);
            this.btnAsignarDock1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsignarDock1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnAsignarDock1.Name = "btnAsignarDock1";
            this.btnAsignarDock1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsignarDock1.Size = new System.Drawing.Size(83, 36);
            this.btnAsignarDock1.TabIndex = 84;
            this.btnAsignarDock1.Text = "Asignar";
            this.btnAsignarDock1.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsignarDock1.UseAccentColor = false;
            this.btnAsignarDock1.UseVisualStyleBackColor = true;
            this.btnAsignarDock1.Click += new System.EventHandler(this.btnAsignarDock1_Click);
            // 
            // AsignacionDock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 201);
            this.Controls.Add(this.btnAsignarDock1);
            this.Controls.Add(this.cmbDock1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AsignacionDock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion dock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsignacionDock_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cmbDock1;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAsignarDock1;
    }
}