namespace AppControlTraficoLogistica
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCamion = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnHistorialCamiones = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.btnCerrarSesion = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.holaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.editarEliminarUsuarioToolStripMenuItem});
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.holaToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click_1);
            // 
            // editarEliminarUsuarioToolStripMenuItem
            // 
            this.editarEliminarUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editarEliminarUsuarioToolStripMenuItem.Name = "editarEliminarUsuarioToolStripMenuItem";
            this.editarEliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.editarEliminarUsuarioToolStripMenuItem.Text = "Editar/Eliminar Usuario";
            this.editarEliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarEliminarUsuarioToolStripMenuItem_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCamion.AutoSize = false;
            this.btnCamion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCamion.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCamion.Depth = 0;
            this.btnCamion.HighEmphasis = true;
            this.btnCamion.Icon = null;
            this.btnCamion.Location = new System.Drawing.Point(162, 217);
            this.btnCamion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCamion.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCamion.Size = new System.Drawing.Size(242, 58);
            this.btnCamion.TabIndex = 10;
            this.btnCamion.Text = "Camion";
            this.btnCamion.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCamion.UseAccentColor = false;
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion1_Click);
            // 
            // btnHistorialCamiones
            // 
            this.btnHistorialCamiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistorialCamiones.AutoSize = false;
            this.btnHistorialCamiones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistorialCamiones.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHistorialCamiones.Depth = 0;
            this.btnHistorialCamiones.HighEmphasis = true;
            this.btnHistorialCamiones.Icon = null;
            this.btnHistorialCamiones.Location = new System.Drawing.Point(473, 217);
            this.btnHistorialCamiones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistorialCamiones.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnHistorialCamiones.Name = "btnHistorialCamiones";
            this.btnHistorialCamiones.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHistorialCamiones.Size = new System.Drawing.Size(242, 58);
            this.btnHistorialCamiones.TabIndex = 11;
            this.btnHistorialCamiones.Text = "Historial de camiones";
            this.btnHistorialCamiones.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnHistorialCamiones.UseAccentColor = false;
            this.btnHistorialCamiones.UseVisualStyleBackColor = true;
            this.btnHistorialCamiones.Click += new System.EventHandler(this.btnHistorialCamiones_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.AutoSize = false;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(750, 393);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Size = new System.Drawing.Size(124, 36);
            this.btnCerrarSesion.TabIndex = 12;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(301, 118);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(270, 29);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Control tráfico Camiones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 439);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnHistorialCamiones);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEliminarUsuarioToolStripMenuItem;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCamion;
        private MaterialSkin2DotNet.Controls.MaterialButton btnHistorialCamiones;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
