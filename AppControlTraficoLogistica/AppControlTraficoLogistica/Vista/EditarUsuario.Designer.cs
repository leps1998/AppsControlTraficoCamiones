namespace AppControlTraficoLogistica
{
    partial class EditarUsuario
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar1 = new MaterialSkin.Controls.MaterialButton();
            this.btnElimi1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(57, 88);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowTemplate.Height = 25;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(441, 346);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(627, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 34);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar1
            // 
            this.btnEditar1.AutoSize = false;
            this.btnEditar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar1.Depth = 0;
            this.btnEditar1.HighEmphasis = true;
            this.btnEditar1.Icon = null;
            this.btnEditar1.Location = new System.Drawing.Point(284, 443);
            this.btnEditar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar1.Size = new System.Drawing.Size(102, 36);
            this.btnEditar1.TabIndex = 4;
            this.btnEditar1.Text = "Editar usuario";
            this.btnEditar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar1.UseAccentColor = false;
            this.btnEditar1.UseVisualStyleBackColor = true;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnElimi1
            // 
            this.btnElimi1.AutoSize = false;
            this.btnElimi1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElimi1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnElimi1.Depth = 0;
            this.btnElimi1.HighEmphasis = true;
            this.btnElimi1.Icon = null;
            this.btnElimi1.Location = new System.Drawing.Point(396, 443);
            this.btnElimi1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnElimi1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElimi1.Name = "btnElimi1";
            this.btnElimi1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnElimi1.Size = new System.Drawing.Size(102, 36);
            this.btnElimi1.TabIndex = 5;
            this.btnElimi1.Text = "Eliminar usuario";
            this.btnElimi1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnElimi1.UseAccentColor = false;
            this.btnElimi1.UseVisualStyleBackColor = true;
            this.btnElimi1.Click += new System.EventHandler(this.btnElimi1_Click);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 485);
            this.Controls.Add(this.btnElimi1);
            this.Controls.Add(this.btnEditar1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnEditar1;
        private MaterialSkin.Controls.MaterialButton btnElimi1;
    }
}