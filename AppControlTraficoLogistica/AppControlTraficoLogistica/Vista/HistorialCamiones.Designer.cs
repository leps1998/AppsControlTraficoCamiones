namespace AppControlTraficoLogistica
{
    partial class HistorialCamiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCamiones));
            this.dgvHistorialCamiones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbBerry = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpBuscarDesde = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnRefrescar1 = new MaterialSkin.Controls.MaterialButton();
            this.cmbTipoBusqueda = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpBuscarHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar1 = new MaterialSkin.Controls.MaterialButton();
            this.lblBuscarCamion = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialCamiones
            // 
            this.dgvHistorialCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCamiones.Location = new System.Drawing.Point(12, 156);
            this.dgvHistorialCamiones.Name = "dgvHistorialCamiones";
            this.dgvHistorialCamiones.RowTemplate.Height = 25;
            this.dgvHistorialCamiones.Size = new System.Drawing.Size(776, 238);
            this.dgvHistorialCamiones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Historial de camiones";
            // 
            // ptbBerry
            // 
            this.ptbBerry.Image = ((System.Drawing.Image)(resources.GetObject("ptbBerry.Image")));
            this.ptbBerry.Location = new System.Drawing.Point(656, 52);
            this.ptbBerry.Name = "ptbBerry";
            this.ptbBerry.Size = new System.Drawing.Size(150, 73);
            this.ptbBerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBerry.TabIndex = 32;
            this.ptbBerry.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(15, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 24);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Desde";
            this.lblFecha.Visible = false;
            // 
            // dtpBuscarDesde
            // 
            this.dtpBuscarDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarDesde.Location = new System.Drawing.Point(59, 101);
            this.dtpBuscarDesde.Name = "dtpBuscarDesde";
            this.dtpBuscarDesde.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarDesde.TabIndex = 29;
            this.dtpBuscarDesde.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarDesde.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(53, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(235, 23);
            this.txtBuscar.TabIndex = 26;
            this.txtBuscar.Visible = false;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(15, 100);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 24);
            this.lblBuscar.TabIndex = 25;
            this.lblBuscar.Text = "Datos:";
            this.lblBuscar.Visible = false;
            // 
            // btnRefrescar1
            // 
            this.btnRefrescar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefrescar1.AutoSize = false;
            this.btnRefrescar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefrescar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefrescar1.Depth = 0;
            this.btnRefrescar1.HighEmphasis = true;
            this.btnRefrescar1.Icon = null;
            this.btnRefrescar1.Location = new System.Drawing.Point(13, 402);
            this.btnRefrescar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefrescar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefrescar1.Name = "btnRefrescar1";
            this.btnRefrescar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefrescar1.Size = new System.Drawing.Size(103, 36);
            this.btnRefrescar1.TabIndex = 47;
            this.btnRefrescar1.Text = "Refrescar tabla";
            this.btnRefrescar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefrescar1.UseAccentColor = false;
            this.btnRefrescar1.UseVisualStyleBackColor = true;
            this.btnRefrescar1.Click += new System.EventHandler(this.btnRefrescar1_Click);
            // 
            // cmbTipoBusqueda
            // 
            this.cmbTipoBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipoBusqueda.AutoResize = false;
            this.cmbTipoBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipoBusqueda.Depth = 0;
            this.cmbTipoBusqueda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipoBusqueda.DropDownHeight = 174;
            this.cmbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda.DropDownWidth = 185;
            this.cmbTipoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipoBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipoBusqueda.FormattingEnabled = true;
            this.cmbTipoBusqueda.Hint = "Tipo de busqueda";
            this.cmbTipoBusqueda.IntegralHeight = false;
            this.cmbTipoBusqueda.ItemHeight = 43;
            this.cmbTipoBusqueda.Items.AddRange(new object[] {
            "",
            "Arribo",
            "Salida",
            "Destino",
            "Numero de remito",
            "Patente Semi",
            "Patente Tractor",
            "Transporte"});
            this.cmbTipoBusqueda.Location = new System.Drawing.Point(20, 65);
            this.cmbTipoBusqueda.MaxDropDownItems = 4;
            this.cmbTipoBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipoBusqueda.Name = "cmbTipoBusqueda";
            this.cmbTipoBusqueda.Size = new System.Drawing.Size(163, 49);
            this.cmbTipoBusqueda.StartIndex = 0;
            this.cmbTipoBusqueda.TabIndex = 48;
            this.cmbTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbTipoBusqueda_SelectedIndexChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHasta.Location = new System.Drawing.Point(15, 127);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(57, 24);
            this.lblFechaHasta.TabIndex = 53;
            this.lblFechaHasta.Text = "Hasta";
            this.lblFechaHasta.Visible = false;
            // 
            // dtpBuscarHasta
            // 
            this.dtpBuscarHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarHasta.Location = new System.Drawing.Point(59, 127);
            this.dtpBuscarHasta.Name = "dtpBuscarHasta";
            this.dtpBuscarHasta.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarHasta.TabIndex = 52;
            this.dtpBuscarHasta.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarHasta.Visible = false;
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar1.AutoSize = false;
            this.btnBuscar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar1.Depth = 0;
            this.btnBuscar1.HighEmphasis = true;
            this.btnBuscar1.Icon = null;
            this.btnBuscar1.Location = new System.Drawing.Point(138, 104);
            this.btnBuscar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar1.Size = new System.Drawing.Size(104, 35);
            this.btnBuscar1.TabIndex = 51;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar1.UseAccentColor = false;
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Visible = false;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // lblBuscarCamion
            // 
            this.lblBuscarCamion.AutoSize = true;
            this.lblBuscarCamion.Depth = 0;
            this.lblBuscarCamion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblBuscarCamion.Location = new System.Drawing.Point(20, 46);
            this.lblBuscarCamion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBuscarCamion.Name = "lblBuscarCamion";
            this.lblBuscarCamion.Size = new System.Drawing.Size(111, 19);
            this.lblBuscarCamion.TabIndex = 54;
            this.lblBuscarCamion.Text = "Buscar camion:";
            // 
            // HistorialCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscarCamion);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpBuscarHasta);
            this.Controls.Add(this.btnBuscar1);
            this.Controls.Add(this.cmbTipoBusqueda);
            this.Controls.Add(this.btnRefrescar1);
            this.Controls.Add(this.ptbBerry);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpBuscarDesde);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistorialCamiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialCamiones";
            this.Text = "Historial camiones";
            this.Load += new System.EventHandler(this.HistorialCamiones_Load);
            this.Resize += new System.EventHandler(this.HistorialCamiones_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialCamiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbBerry;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpBuscarDesde;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private MaterialSkin.Controls.MaterialButton btnRefrescar1;
        private MaterialSkin.Controls.MaterialComboBox cmbTipoBusqueda;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpBuscarHasta;
        private MaterialSkin.Controls.MaterialButton btnBuscar1;
        private MaterialSkin.Controls.MaterialLabel lblBuscarCamion;
    }
}