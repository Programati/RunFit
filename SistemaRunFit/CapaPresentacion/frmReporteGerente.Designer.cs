namespace CapaPresentacion
{
    partial class frmReporteGerente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteGerente));
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvReporteGerente = new Guna.UI.WinForms.GunaDataGridView();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.cmbReporteGerente = new Guna.UI.WinForms.GunaComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesdeReporte = new Guna.UI.WinForms.GunaLabel();
            this.lblReporteHasta = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartGerente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblVendedorSelector = new Guna.UI.WinForms.GunaLabel();
            this.cmbVendedorSelector = new Guna.UI.WinForms.GunaComboBox();
            this.btnExportarExcel = new Guna.UI.WinForms.GunaButton();
            this.grbDetalleVta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGerente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.Black;
            this.grbDetalleVta.Controls.Add(this.dgvReporteGerente);
            this.grbDetalleVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetalleVta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleVta.ForeColor = System.Drawing.Color.White;
            this.grbDetalleVta.LineBottom = 2;
            this.grbDetalleVta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.LineLeft = 2;
            this.grbDetalleVta.LineRight = 2;
            this.grbDetalleVta.LineTop = 50;
            this.grbDetalleVta.Location = new System.Drawing.Point(0, 0);
            this.grbDetalleVta.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbDetalleVta.Name = "grbDetalleVta";
            this.grbDetalleVta.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbDetalleVta.Size = new System.Drawing.Size(406, 420);
            this.grbDetalleVta.TabIndex = 81;
            this.grbDetalleVta.Text = "Detalle de reporte";
            this.grbDetalleVta.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvReporteGerente
            // 
            this.dgvReporteGerente.AllowUserToAddRows = false;
            this.dgvReporteGerente.AllowUserToDeleteRows = false;
            this.dgvReporteGerente.AllowUserToResizeColumns = false;
            this.dgvReporteGerente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dgvReporteGerente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteGerente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteGerente.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteGerente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteGerente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteGerente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteGerente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteGerente.ColumnHeadersHeight = 34;
            this.dgvReporteGerente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteGerente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteGerente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteGerente.EnableHeadersVisualStyles = false;
            this.dgvReporteGerente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteGerente.Location = new System.Drawing.Point(2, 50);
            this.dgvReporteGerente.MultiSelect = false;
            this.dgvReporteGerente.Name = "dgvReporteGerente";
            this.dgvReporteGerente.ReadOnly = true;
            this.dgvReporteGerente.RowHeadersVisible = false;
            this.dgvReporteGerente.RowHeadersWidth = 51;
            this.dgvReporteGerente.RowTemplate.Height = 35;
            this.dgvReporteGerente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteGerente.Size = new System.Drawing.Size(402, 368);
            this.dgvReporteGerente.TabIndex = 0;
            this.dgvReporteGerente.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReporteGerente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteGerente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReporteGerente.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvReporteGerente.ThemeStyle.ReadOnly = true;
            this.dgvReporteGerente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvReporteGerente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteGerente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteGerente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReporteGerente.ThemeStyle.RowsStyle.Height = 35;
            this.dgvReporteGerente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvReporteGerente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblTituloReporte
            // 
            this.lblTituloReporte.AutoSize = true;
            this.lblTituloReporte.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporte.Location = new System.Drawing.Point(200, 9);
            this.lblTituloReporte.Name = "lblTituloReporte";
            this.lblTituloReporte.Size = new System.Drawing.Size(401, 46);
            this.lblTituloReporte.TabIndex = 82;
            this.lblTituloReporte.Text = "REPORTE DEL GERENTE";
            // 
            // lblBuscarPorUser
            // 
            this.lblBuscarPorUser.AutoSize = true;
            this.lblBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorUser.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarPorUser.Location = new System.Drawing.Point(29, 111);
            this.lblBuscarPorUser.Name = "lblBuscarPorUser";
            this.lblBuscarPorUser.Size = new System.Drawing.Size(113, 16);
            this.lblBuscarPorUser.TabIndex = 84;
            this.lblBuscarPorUser.Text = "TIPO DE REPORTE";
            // 
            // cmbReporteGerente
            // 
            this.cmbReporteGerente.BackColor = System.Drawing.Color.Transparent;
            this.cmbReporteGerente.BaseColor = System.Drawing.Color.White;
            this.cmbReporteGerente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbReporteGerente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReporteGerente.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReporteGerente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporteGerente.FocusedColor = System.Drawing.Color.Empty;
            this.cmbReporteGerente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporteGerente.ForeColor = System.Drawing.Color.Black;
            this.cmbReporteGerente.FormattingEnabled = true;
            this.cmbReporteGerente.Items.AddRange(new object[] {
            "Mejor vendedor",
            "Productos mas vendidos por unidad",
            "Productos mas Rentables",
            "Ventas totales",
            "Productos proximos al punto de pedido"});
            this.cmbReporteGerente.Location = new System.Drawing.Point(146, 107);
            this.cmbReporteGerente.Margin = new System.Windows.Forms.Padding(1);
            this.cmbReporteGerente.Name = "cmbReporteGerente";
            this.cmbReporteGerente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbReporteGerente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbReporteGerente.Radius = 10;
            this.cmbReporteGerente.Size = new System.Drawing.Size(291, 24);
            this.cmbReporteGerente.TabIndex = 83;
            this.cmbReporteGerente.SelectedIndexChanged += new System.EventHandler(this.cmbReporteGerente_SelectedIndexChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(467, 107);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaDesde.TabIndex = 85;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(633, 107);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaHasta.TabIndex = 86;
            // 
            // lblDesdeReporte
            // 
            this.lblDesdeReporte.AutoSize = true;
            this.lblDesdeReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeReporte.ForeColor = System.Drawing.Color.Black;
            this.lblDesdeReporte.Location = new System.Drawing.Point(479, 88);
            this.lblDesdeReporte.Name = "lblDesdeReporte";
            this.lblDesdeReporte.Size = new System.Drawing.Size(50, 16);
            this.lblDesdeReporte.TabIndex = 87;
            this.lblDesdeReporte.Text = "DESDE:";
            // 
            // lblReporteHasta
            // 
            this.lblReporteHasta.AutoSize = true;
            this.lblReporteHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteHasta.ForeColor = System.Drawing.Color.Black;
            this.lblReporteHasta.Location = new System.Drawing.Point(641, 88);
            this.lblReporteHasta.Name = "lblReporteHasta";
            this.lblReporteHasta.Size = new System.Drawing.Size(53, 16);
            this.lblReporteHasta.TabIndex = 88;
            this.lblReporteHasta.Text = "HASTA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDetalleVta);
            this.panel1.Location = new System.Drawing.Point(-4, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 420);
            this.panel1.TabIndex = 89;
            // 
            // chartGerente
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGerente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGerente.Legends.Add(legend1);
            this.chartGerente.Location = new System.Drawing.Point(453, 195);
            this.chartGerente.Name = "chartGerente";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGerente.Series.Add(series1);
            this.chartGerente.Size = new System.Drawing.Size(430, 355);
            this.chartGerente.TabIndex = 90;
            this.chartGerente.Text = "chart1";
            // 
            // lblVendedorSelector
            // 
            this.lblVendedorSelector.AutoSize = true;
            this.lblVendedorSelector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorSelector.ForeColor = System.Drawing.Color.Black;
            this.lblVendedorSelector.Location = new System.Drawing.Point(484, 148);
            this.lblVendedorSelector.Name = "lblVendedorSelector";
            this.lblVendedorSelector.Size = new System.Drawing.Size(81, 16);
            this.lblVendedorSelector.TabIndex = 96;
            this.lblVendedorSelector.Text = "VENDEDOR:";
            // 
            // cmbVendedorSelector
            // 
            this.cmbVendedorSelector.BackColor = System.Drawing.Color.Transparent;
            this.cmbVendedorSelector.BaseColor = System.Drawing.Color.White;
            this.cmbVendedorSelector.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbVendedorSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVendedorSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVendedorSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedorSelector.FocusedColor = System.Drawing.Color.Empty;
            this.cmbVendedorSelector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendedorSelector.ForeColor = System.Drawing.Color.Black;
            this.cmbVendedorSelector.FormattingEnabled = true;
            this.cmbVendedorSelector.Location = new System.Drawing.Point(569, 143);
            this.cmbVendedorSelector.Margin = new System.Windows.Forms.Padding(1);
            this.cmbVendedorSelector.Name = "cmbVendedorSelector";
            this.cmbVendedorSelector.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbVendedorSelector.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbVendedorSelector.Radius = 10;
            this.cmbVendedorSelector.Size = new System.Drawing.Size(178, 24);
            this.cmbVendedorSelector.TabIndex = 95;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.AnimationHoverSpeed = 0.07F;
            this.btnExportarExcel.AnimationSpeed = 0.03F;
            this.btnExportarExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportarExcel.BaseColor = System.Drawing.Color.White;
            this.btnExportarExcel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnExportarExcel.BorderSize = 2;
            this.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportarExcel.FocusedColor = System.Drawing.Color.White;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExportarExcel.Location = new System.Drawing.Point(264, 155);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnExportarExcel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportarExcel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportarExcel.OnHoverImage = null;
            this.btnExportarExcel.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportarExcel.Radius = 10;
            this.btnExportarExcel.Size = new System.Drawing.Size(138, 34);
            this.btnExportarExcel.TabIndex = 97;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // frmReporteGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 627);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.lblVendedorSelector);
            this.Controls.Add(this.cmbVendedorSelector);
            this.Controls.Add(this.chartGerente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblReporteHasta);
            this.Controls.Add(this.lblDesdeReporte);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblBuscarPorUser);
            this.Controls.Add(this.cmbReporteGerente);
            this.Controls.Add(this.lblTituloReporte);
            this.Name = "frmReporteGerente";
            this.Text = "frmReporteGerente";
            this.grbDetalleVta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGerente)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Guna.UI.WinForms.GunaDataGridView dgvReporteGerente;
        private System.Windows.Forms.Label lblTituloReporte;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private Guna.UI.WinForms.GunaComboBox cmbReporteGerente;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Guna.UI.WinForms.GunaLabel lblDesdeReporte;
        private Guna.UI.WinForms.GunaLabel lblReporteHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGerente;
        private Guna.UI.WinForms.GunaLabel lblVendedorSelector;
        private Guna.UI.WinForms.GunaComboBox cmbVendedorSelector;
        private Guna.UI.WinForms.GunaButton btnExportarExcel;
    }
}