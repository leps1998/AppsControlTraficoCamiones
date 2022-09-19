namespace AppControlTraficoPorteria
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpBuscarDesde = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblHistorial1 = new System.Windows.Forms.Label();
            this.ptbBerry1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar1 = new MaterialSkin.Controls.MaterialButton();
            this.cmbTipo1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTipo1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar1 = new MaterialSkin.Controls.MaterialButton();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpBuscarHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCamiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialCamiones
            // 
            this.dgvHistorialCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialCamiones.Location = new System.Drawing.Point(12, 156);
            this.dgvHistorialCamiones.Name = "dgvHistorialCamiones";
            this.dgvHistorialCamiones.RowHeadersWidth = 123;
            this.dgvHistorialCamiones.RowTemplate.Height = 25;
            this.dgvHistorialCamiones.Size = new System.Drawing.Size(776, 238);
            this.dgvHistorialCamiones.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(14, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 24);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Desde";
            this.lblFecha.Visible = false;
            // 
            // dtpBuscarDesde
            // 
            this.dtpBuscarDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarDesde.Location = new System.Drawing.Point(58, 101);
            this.dtpBuscarDesde.Name = "dtpBuscarDesde";
            this.dtpBuscarDesde.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarDesde.TabIndex = 21;
            this.dtpBuscarDesde.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarDesde.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(52, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(235, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.Visible = false;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(14, 96);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 24);
            this.lblBuscar.TabIndex = 17;
            this.lblBuscar.Text = "Datos:";
            this.lblBuscar.Visible = false;
            // 
            // lblHistorial1
            // 
            this.lblHistorial1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHistorial1.AutoSize = true;
            this.lblHistorial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial1.Location = new System.Drawing.Point(293, 64);
            this.lblHistorial1.Name = "lblHistorial1";
            this.lblHistorial1.Size = new System.Drawing.Size(354, 37);
            this.lblHistorial1.TabIndex = 26;
            this.lblHistorial1.Text = "Historial de camiones ";
            // 
            // ptbBerry1
            // 
            this.ptbBerry1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbBerry1.Image = ((System.Drawing.Image)(resources.GetObject("ptbBerry1.Image")));
            this.ptbBerry1.Location = new System.Drawing.Point(656, 52);
            this.ptbBerry1.Name = "ptbBerry1";
            this.ptbBerry1.Size = new System.Drawing.Size(150, 73);
            this.ptbBerry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBerry1.TabIndex = 27;
            this.ptbBerry1.TabStop = false;
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
            this.btnRefrescar1.Location = new System.Drawing.Point(14, 405);
            this.btnRefrescar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefrescar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefrescar1.Name = "btnRefrescar1";
            this.btnRefrescar1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefrescar1.Size = new System.Drawing.Size(99, 36);
            this.btnRefrescar1.TabIndex = 28;
            this.btnRefrescar1.Text = "Refrescar tabla";
            this.btnRefrescar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefrescar1.UseAccentColor = false;
            this.btnRefrescar1.UseVisualStyleBackColor = true;
            this.btnRefrescar1.Click += new System.EventHandler(this.btnRefrescar1_Click);
            // 
            // cmbTipo1
            // 
            this.cmbTipo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo1.AutoResize = false;
            this.cmbTipo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTipo1.Depth = 0;
            this.cmbTipo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTipo1.DropDownHeight = 174;
            this.cmbTipo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo1.DropDownWidth = 121;
            this.cmbTipo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbTipo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTipo1.FormattingEnabled = true;
            this.cmbTipo1.Hint = "Tipo de busqueda";
            this.cmbTipo1.IntegralHeight = false;
            this.cmbTipo1.ItemHeight = 43;
            this.cmbTipo1.Items.AddRange(new object[] {
            "",
            "Transporte",
            "Patente Tractor",
            "Patente Semi",
            "Destino",
            "Numero de remito",
            "Arribo",
            "Salida"});
            this.cmbTipo1.Location = new System.Drawing.Point(20, 65);
            this.cmbTipo1.MaxDropDownItems = 4;
            this.cmbTipo1.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbTipo1.Name = "cmbTipo1";
            this.cmbTipo1.Size = new System.Drawing.Size(163, 49);
            this.cmbTipo1.StartIndex = 0;
            this.cmbTipo1.TabIndex = 29;
            this.cmbTipo1.SelectedIndexChanged += new System.EventHandler(this.cmbTipo1_SelectedIndexChanged);
            // 
            // lblTipo1
            // 
            this.lblTipo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Depth = 0;
            this.lblTipo1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipo1.Location = new System.Drawing.Point(20, 46);
            this.lblTipo1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(111, 19);
            this.lblTipo1.TabIndex = 30;
            this.lblTipo1.Text = "Buscar camion:";
            // 
            // btnBuscar1
            // 
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
            this.btnBuscar1.TabIndex = 57;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar1.UseAccentColor = false;
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Visible = false;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHasta.Location = new System.Drawing.Point(15, 127);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(57, 24);
            this.lblFechaHasta.TabIndex = 59;
            this.lblFechaHasta.Text = "Hasta";
            this.lblFechaHasta.Visible = false;
            // 
            // dtpBuscarHasta
            // 
            this.dtpBuscarHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarHasta.Location = new System.Drawing.Point(59, 127);
            this.dtpBuscarHasta.Name = "dtpBuscarHasta";
            this.dtpBuscarHasta.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarHasta.TabIndex = 58;
            this.dtpBuscarHasta.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarHasta.Visible = false;
            // 
            // HistorialCamiones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpBuscarHasta);
            this.Controls.Add(this.btnBuscar1);
            this.Controls.Add(this.lblTipo1);
            this.Controls.Add(this.cmbTipo1);
            this.Controls.Add(this.btnRefrescar1);
            this.Controls.Add(this.ptbBerry1);
            this.Controls.Add(this.lblHistorial1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpBuscarDesde);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvHistorialCamiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistorialCamiones";
            this.Text = "HistorialCamiones";
            this.Load += new System.EventHandler(this.HistorialCamiones_Load);
            this.Resize += new System.EventHandler(this.HistorialCamiones_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCamiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistorialCamiones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpBuscarDesde;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblHistorial1;
        private System.Windows.Forms.PictureBox ptbBerry1;
        private MaterialSkin.Controls.MaterialButton btnRefrescar1;
        private MaterialSkin.Controls.MaterialComboBox cmbTipo1;
        private MaterialSkin.Controls.MaterialLabel lblTipo1;
        private MaterialSkin.Controls.MaterialButton btnBuscar1;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpBuscarHasta;
    }
}