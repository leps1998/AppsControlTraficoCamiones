namespace AppControlTraficoPorteria
{
    partial class Camion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camion));
            this.dgvCamionesCurso = new System.Windows.Forms.DataGridView();
            this.lblCamionesCurso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtpBuscarDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.ptbBerry = new System.Windows.Forms.PictureBox();
            this.btnRefrescar1 = new MaterialSkin.Controls.MaterialButton();
            this.btnNuevoCamion1 = new MaterialSkin.Controls.MaterialButton();
            this.btnCompletarCamion1 = new MaterialSkin.Controls.MaterialButton();
            this.btnEditarCamion = new MaterialSkin.Controls.MaterialButton();
            this.btnLiberarCamion1 = new MaterialSkin.Controls.MaterialButton();
            this.cmbTipo1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblTipo1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpBuscarHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar1 = new MaterialSkin.Controls.MaterialButton();
            this.cargarPesoTara = new MaterialSkin.Controls.MaterialButton();
            this.btnCargarPesoBruto = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamionesCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCamionesCurso
            // 
            this.dgvCamionesCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamionesCurso.Location = new System.Drawing.Point(12, 156);
            this.dgvCamionesCurso.Name = "dgvCamionesCurso";
            this.dgvCamionesCurso.ReadOnly = true;
            this.dgvCamionesCurso.RowHeadersWidth = 123;
            this.dgvCamionesCurso.RowTemplate.Height = 25;
            this.dgvCamionesCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCamionesCurso.Size = new System.Drawing.Size(776, 238);
            this.dgvCamionesCurso.TabIndex = 0;
            // 
            // lblCamionesCurso
            // 
            this.lblCamionesCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCamionesCurso.AutoSize = true;
            this.lblCamionesCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCamionesCurso.Location = new System.Drawing.Point(306, 65);
            this.lblCamionesCurso.Name = "lblCamionesCurso";
            this.lblCamionesCurso.Size = new System.Drawing.Size(310, 37);
            this.lblCamionesCurso.TabIndex = 4;
            this.lblCamionesCurso.Text = "Camiones en curso";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(14, 100);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 24);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Datos:";
            this.lblBuscar.Visible = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(52, 100);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(235, 23);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.Visible = false;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // dtpBuscarDesde
            // 
            this.dtpBuscarDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarDesde.Location = new System.Drawing.Point(58, 101);
            this.dtpBuscarDesde.Name = "dtpBuscarDesde";
            this.dtpBuscarDesde.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarDesde.TabIndex = 13;
            this.dtpBuscarDesde.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarDesde.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(14, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 24);
            this.lblFecha.TabIndex = 16;
            this.lblFecha.Text = "Desde";
            this.lblFecha.Visible = false;
            // 
            // ptbBerry
            // 
            this.ptbBerry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbBerry.Image = ((System.Drawing.Image)(resources.GetObject("ptbBerry.Image")));
            this.ptbBerry.Location = new System.Drawing.Point(656, 52);
            this.ptbBerry.Name = "ptbBerry";
            this.ptbBerry.Size = new System.Drawing.Size(150, 73);
            this.ptbBerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbBerry.TabIndex = 17;
            this.ptbBerry.TabStop = false;
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
            this.btnRefrescar1.TabIndex = 18;
            this.btnRefrescar1.Text = "Refrescar tabla";
            this.btnRefrescar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefrescar1.UseAccentColor = false;
            this.btnRefrescar1.UseVisualStyleBackColor = true;
            this.btnRefrescar1.Click += new System.EventHandler(this.btnRefrescar1_Click);
            // 
            // btnNuevoCamion1
            // 
            this.btnNuevoCamion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevoCamion1.AutoSize = false;
            this.btnNuevoCamion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoCamion1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNuevoCamion1.Depth = 0;
            this.btnNuevoCamion1.HighEmphasis = true;
            this.btnNuevoCamion1.Icon = null;
            this.btnNuevoCamion1.Location = new System.Drawing.Point(237, 402);
            this.btnNuevoCamion1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevoCamion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCamion1.Name = "btnNuevoCamion1";
            this.btnNuevoCamion1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNuevoCamion1.Size = new System.Drawing.Size(85, 35);
            this.btnNuevoCamion1.TabIndex = 19;
            this.btnNuevoCamion1.Text = "Nuevo camion";
            this.btnNuevoCamion1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNuevoCamion1.UseAccentColor = false;
            this.btnNuevoCamion1.UseVisualStyleBackColor = true;
            this.btnNuevoCamion1.Click += new System.EventHandler(this.btnNuevoCamion1_Click);
            // 
            // btnCompletarCamion1
            // 
            this.btnCompletarCamion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompletarCamion1.AutoSize = false;
            this.btnCompletarCamion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompletarCamion1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCompletarCamion1.Depth = 0;
            this.btnCompletarCamion1.HighEmphasis = true;
            this.btnCompletarCamion1.Icon = null;
            this.btnCompletarCamion1.Location = new System.Drawing.Point(516, 402);
            this.btnCompletarCamion1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompletarCamion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompletarCamion1.Name = "btnCompletarCamion1";
            this.btnCompletarCamion1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompletarCamion1.Size = new System.Drawing.Size(85, 35);
            this.btnCompletarCamion1.TabIndex = 20;
            this.btnCompletarCamion1.Text = "Completar Camion";
            this.btnCompletarCamion1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompletarCamion1.UseAccentColor = false;
            this.btnCompletarCamion1.UseVisualStyleBackColor = true;
            this.btnCompletarCamion1.Click += new System.EventHandler(this.btnCompletarCamion1_Click);
            // 
            // btnEditarCamion
            // 
            this.btnEditarCamion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarCamion.AutoSize = false;
            this.btnEditarCamion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarCamion.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnEditarCamion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarCamion.Depth = 0;
            this.btnEditarCamion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarCamion.HighEmphasis = true;
            this.btnEditarCamion.Icon = null;
            this.btnEditarCamion.Location = new System.Drawing.Point(609, 402);
            this.btnEditarCamion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarCamion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCamion.Name = "btnEditarCamion";
            this.btnEditarCamion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditarCamion.Size = new System.Drawing.Size(85, 35);
            this.btnEditarCamion.TabIndex = 21;
            this.btnEditarCamion.Text = "Editar camion";
            this.btnEditarCamion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnEditarCamion.UseAccentColor = false;
            this.btnEditarCamion.UseVisualStyleBackColor = false;
            this.btnEditarCamion.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLiberarCamion1
            // 
            this.btnLiberarCamion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLiberarCamion1.AutoSize = false;
            this.btnLiberarCamion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLiberarCamion1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLiberarCamion1.Depth = 0;
            this.btnLiberarCamion1.HighEmphasis = true;
            this.btnLiberarCamion1.Icon = null;
            this.btnLiberarCamion1.Location = new System.Drawing.Point(702, 402);
            this.btnLiberarCamion1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLiberarCamion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLiberarCamion1.Name = "btnLiberarCamion1";
            this.btnLiberarCamion1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLiberarCamion1.Size = new System.Drawing.Size(85, 35);
            this.btnLiberarCamion1.TabIndex = 22;
            this.btnLiberarCamion1.Text = "Liberar camion";
            this.btnLiberarCamion1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLiberarCamion1.UseAccentColor = false;
            this.btnLiberarCamion1.UseVisualStyleBackColor = true;
            this.btnLiberarCamion1.Click += new System.EventHandler(this.btnLiberarCamion1_Click);
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
            this.cmbTipo1.TabIndex = 23;
            this.cmbTipo1.SelectedIndexChanged += new System.EventHandler(this.cmbTipo1_SelectedIndexChanged);
            // 
            // lblTipo1
            // 
            this.lblTipo1.AutoSize = true;
            this.lblTipo1.Depth = 0;
            this.lblTipo1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTipo1.Location = new System.Drawing.Point(20, 46);
            this.lblTipo1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo1.Name = "lblTipo1";
            this.lblTipo1.Size = new System.Drawing.Size(111, 19);
            this.lblTipo1.TabIndex = 24;
            this.lblTipo1.Text = "Buscar camion:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaHasta.Location = new System.Drawing.Point(15, 127);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(57, 24);
            this.lblFechaHasta.TabIndex = 55;
            this.lblFechaHasta.Text = "Hasta";
            this.lblFechaHasta.Visible = false;
            // 
            // dtpBuscarHasta
            // 
            this.dtpBuscarHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscarHasta.Location = new System.Drawing.Point(59, 127);
            this.dtpBuscarHasta.Name = "dtpBuscarHasta";
            this.dtpBuscarHasta.Size = new System.Drawing.Size(72, 23);
            this.dtpBuscarHasta.TabIndex = 54;
            this.dtpBuscarHasta.Value = new System.DateTime(2022, 9, 1, 0, 0, 0, 0);
            this.dtpBuscarHasta.Visible = false;
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
            this.btnBuscar1.TabIndex = 56;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar1.UseAccentColor = false;
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Visible = false;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // cargarPesoTara
            // 
            this.cargarPesoTara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cargarPesoTara.AutoSize = false;
            this.cargarPesoTara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cargarPesoTara.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cargarPesoTara.Depth = 0;
            this.cargarPesoTara.HighEmphasis = true;
            this.cargarPesoTara.Icon = null;
            this.cargarPesoTara.Location = new System.Drawing.Point(330, 402);
            this.cargarPesoTara.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cargarPesoTara.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargarPesoTara.Name = "cargarPesoTara";
            this.cargarPesoTara.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cargarPesoTara.Size = new System.Drawing.Size(85, 35);
            this.cargarPesoTara.TabIndex = 57;
            this.cargarPesoTara.Text = "Cargar peso tara";
            this.cargarPesoTara.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cargarPesoTara.UseAccentColor = false;
            this.cargarPesoTara.UseVisualStyleBackColor = true;
            this.cargarPesoTara.Click += new System.EventHandler(this.cargarPesoTara_Click);
            // 
            // btnCargarPesoBruto
            // 
            this.btnCargarPesoBruto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarPesoBruto.AutoSize = false;
            this.btnCargarPesoBruto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargarPesoBruto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargarPesoBruto.Depth = 0;
            this.btnCargarPesoBruto.HighEmphasis = true;
            this.btnCargarPesoBruto.Icon = null;
            this.btnCargarPesoBruto.Location = new System.Drawing.Point(423, 402);
            this.btnCargarPesoBruto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargarPesoBruto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarPesoBruto.Name = "btnCargarPesoBruto";
            this.btnCargarPesoBruto.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargarPesoBruto.Size = new System.Drawing.Size(85, 35);
            this.btnCargarPesoBruto.TabIndex = 58;
            this.btnCargarPesoBruto.Text = "Cargar peso bruto";
            this.btnCargarPesoBruto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargarPesoBruto.UseAccentColor = false;
            this.btnCargarPesoBruto.UseVisualStyleBackColor = true;
            this.btnCargarPesoBruto.Click += new System.EventHandler(this.btnCargarPesoBruto_Click);
            // 
            // Camion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarPesoBruto);
            this.Controls.Add(this.cargarPesoTara);
            this.Controls.Add(this.btnBuscar1);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpBuscarHasta);
            this.Controls.Add(this.lblTipo1);
            this.Controls.Add(this.cmbTipo1);
            this.Controls.Add(this.btnLiberarCamion1);
            this.Controls.Add(this.btnEditarCamion);
            this.Controls.Add(this.btnCompletarCamion1);
            this.Controls.Add(this.btnNuevoCamion1);
            this.Controls.Add(this.btnRefrescar1);
            this.Controls.Add(this.ptbBerry);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpBuscarDesde);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblCamionesCurso);
            this.Controls.Add(this.dgvCamionesCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Camion";
            this.Text = "Nuevo camion";
            this.Load += new System.EventHandler(this.NuevoCamion_Load);
            this.Resize += new System.EventHandler(this.Camion_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamionesCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBerry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamionesCurso;
        private System.Windows.Forms.Label lblCamionesCurso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dtpBuscarDesde;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox ptbBerry;
        private MaterialSkin.Controls.MaterialButton btnRefrescar1;
        private MaterialSkin.Controls.MaterialButton btnNuevoCamion1;
        private MaterialSkin.Controls.MaterialButton btnCompletarCamion1;
        private MaterialSkin.Controls.MaterialButton btnEditarCamion;
        private MaterialSkin.Controls.MaterialButton btnLiberarCamion1;
        private MaterialSkin.Controls.MaterialComboBox cmbTipo1;
        private MaterialSkin.Controls.MaterialLabel lblTipo1;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpBuscarHasta;
        private MaterialSkin.Controls.MaterialButton btnBuscar1;
        private MaterialSkin.Controls.MaterialButton cargarPesoTara;
        private MaterialSkin.Controls.MaterialButton btnCargarPesoBruto;
    }
}