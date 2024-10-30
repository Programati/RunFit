namespace CapaPresentacion
{
    partial class frmBuscarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarVenta));
            this.pnlBusquedaVta = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblBuscarPorVta = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarFactura = new Guna.UI.WinForms.GunaTextBox();
            this.grbDetalleBusqueda = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvVentas = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnMenuMarca = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiarBuscarVta = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarBuscarVta = new Guna.UI.WinForms.GunaTileButton();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnFechaBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnClienteBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnMtoTotalBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBusquedaVta.SuspendLayout();
            this.grbDetalleBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaVta
            // 
            this.pnlBusquedaVta.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaVta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaVta.Controls.Add(this.btnMenuMarca);
            this.pnlBusquedaVta.Controls.Add(this.btnLimpiarBuscarVta);
            this.pnlBusquedaVta.Controls.Add(this.btnBuscarBuscarVta);
            this.pnlBusquedaVta.Controls.Add(this.lblBuscarPorVta);
            this.pnlBusquedaVta.Controls.Add(this.txtBuscarFactura);
            this.pnlBusquedaVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaVta.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaVta.Name = "pnlBusquedaVta";
            this.pnlBusquedaVta.Radius = 5;
            this.pnlBusquedaVta.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaVta.Size = new System.Drawing.Size(607, 109);
            this.pnlBusquedaVta.TabIndex = 1;
            // 
            // lblBuscarPorVta
            // 
            this.lblBuscarPorVta.AutoSize = true;
            this.lblBuscarPorVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorVta.Location = new System.Drawing.Point(16, 28);
            this.lblBuscarPorVta.Name = "lblBuscarPorVta";
            this.lblBuscarPorVta.Size = new System.Drawing.Size(170, 16);
            this.lblBuscarPorVta.TabIndex = 1;
            this.lblBuscarPorVta.Text = "Buscar por N° de Factura";
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarFactura.BaseColor = System.Drawing.Color.White;
            this.txtBuscarFactura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarFactura.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarFactura.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarFactura.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFactura.Location = new System.Drawing.Point(192, 23);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.PasswordChar = '\0';
            this.txtBuscarFactura.Radius = 10;
            this.txtBuscarFactura.SelectedText = "";
            this.txtBuscarFactura.Size = new System.Drawing.Size(100, 26);
            this.txtBuscarFactura.TabIndex = 2;
            this.txtBuscarFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbDetalleBusqueda
            // 
            this.grbDetalleBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleBusqueda.BaseColor = System.Drawing.Color.White;
            this.grbDetalleBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBusqueda.Controls.Add(this.dgvVentas);
            this.grbDetalleBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetalleBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleBusqueda.ForeColor = System.Drawing.Color.White;
            this.grbDetalleBusqueda.LineBottom = 2;
            this.grbDetalleBusqueda.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBusqueda.LineLeft = 2;
            this.grbDetalleBusqueda.LineRight = 2;
            this.grbDetalleBusqueda.Location = new System.Drawing.Point(0, 109);
            this.grbDetalleBusqueda.Name = "grbDetalleBusqueda";
            this.grbDetalleBusqueda.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbDetalleBusqueda.Size = new System.Drawing.Size(607, 199);
            this.grbDetalleBusqueda.TabIndex = 56;
            this.grbDetalleBusqueda.Text = "Detalle de Busqueda";
            this.grbDetalleBusqueda.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.ColumnHeadersHeight = 34;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.dgvcolumnFechaBuscarVta,
            this.dgvcolumnClienteBuscarVta,
            this.dgvcolumnMtoTotalBuscarVta,
            this.Vendedor,
            this.Ver});
            this.dgvVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvVentas.Location = new System.Drawing.Point(2, 30);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 35;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(603, 167);
            this.dgvVentas.TabIndex = 5;
            this.dgvVentas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVentas.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvVentas.ThemeStyle.ReadOnly = true;
            this.dgvVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvVentas.ThemeStyle.RowsStyle.Height = 35;
            this.dgvVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Ver";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.ver;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 52;
            // 
            // btnMenuMarca
            // 
            this.btnMenuMarca.AnimationHoverSpeed = 0.07F;
            this.btnMenuMarca.AnimationSpeed = 0.03F;
            this.btnMenuMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMarca.BaseColor = System.Drawing.Color.White;
            this.btnMenuMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnMenuMarca.BorderSize = 2;
            this.btnMenuMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuMarca.FocusedColor = System.Drawing.Color.Red;
            this.btnMenuMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMarca.ForeColor = System.Drawing.Color.Red;
            this.btnMenuMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMarca.Image")));
            this.btnMenuMarca.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMenuMarca.Location = new System.Drawing.Point(19, 56);
            this.btnMenuMarca.Name = "btnMenuMarca";
            this.btnMenuMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnMenuMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuMarca.OnHoverImage = null;
            this.btnMenuMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuMarca.Radius = 10;
            this.btnMenuMarca.Size = new System.Drawing.Size(113, 37);
            this.btnMenuMarca.TabIndex = 89;
            this.btnMenuMarca.Text = "MENU";
            this.btnMenuMarca.Click += new System.EventHandler(this.btnMenuMarca_Click);
            // 
            // btnLimpiarBuscarVta
            // 
            this.btnLimpiarBuscarVta.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarBuscarVta.AnimationSpeed = 0.03F;
            this.btnLimpiarBuscarVta.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarVta.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarBuscarVta.BorderSize = 2;
            this.btnLimpiarBuscarVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscarVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarBuscarVta.FocusedColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarBuscarVta.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarBuscarVta.Image")));
            this.btnLimpiarBuscarVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarBuscarVta.Location = new System.Drawing.Point(339, 21);
            this.btnLimpiarBuscarVta.Name = "btnLimpiarBuscarVta";
            this.btnLimpiarBuscarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarBuscarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarVta.OnHoverImage = null;
            this.btnLimpiarBuscarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarVta.Radius = 5;
            this.btnLimpiarBuscarVta.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarBuscarVta.TabIndex = 4;
            this.btnLimpiarBuscarVta.Click += new System.EventHandler(this.btnLimpiarBuscarVta_Click);
            // 
            // btnBuscarBuscarVta
            // 
            this.btnBuscarBuscarVta.AnimationHoverSpeed = 0.07F;
            this.btnBuscarBuscarVta.AnimationSpeed = 0.03F;
            this.btnBuscarBuscarVta.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarBuscarVta.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarBuscarVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarBuscarVta.BorderSize = 2;
            this.btnBuscarBuscarVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarBuscarVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarBuscarVta.FocusedColor = System.Drawing.Color.White;
            this.btnBuscarBuscarVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarBuscarVta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBuscarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarBuscarVta.Image")));
            this.btnBuscarBuscarVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarBuscarVta.Location = new System.Drawing.Point(298, 21);
            this.btnBuscarBuscarVta.Name = "btnBuscarBuscarVta";
            this.btnBuscarBuscarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarBuscarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarBuscarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarBuscarVta.OnHoverImage = null;
            this.btnBuscarBuscarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarBuscarVta.Radius = 5;
            this.btnBuscarBuscarVta.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarBuscarVta.TabIndex = 3;
            this.btnBuscarBuscarVta.Click += new System.EventHandler(this.btnBuscarBuscarVta_Click);
            // 
            // Factura
            // 
            this.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Factura.HeaderText = "N° de Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 138;
            // 
            // dgvcolumnFechaBuscarVta
            // 
            this.dgvcolumnFechaBuscarVta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcolumnFechaBuscarVta.HeaderText = "Fecha de venta";
            this.dgvcolumnFechaBuscarVta.Name = "dgvcolumnFechaBuscarVta";
            this.dgvcolumnFechaBuscarVta.ReadOnly = true;
            this.dgvcolumnFechaBuscarVta.Width = 154;
            // 
            // dgvcolumnClienteBuscarVta
            // 
            this.dgvcolumnClienteBuscarVta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcolumnClienteBuscarVta.HeaderText = "Cliente";
            this.dgvcolumnClienteBuscarVta.Name = "dgvcolumnClienteBuscarVta";
            this.dgvcolumnClienteBuscarVta.ReadOnly = true;
            this.dgvcolumnClienteBuscarVta.Width = 86;
            // 
            // dgvcolumnMtoTotalBuscarVta
            // 
            this.dgvcolumnMtoTotalBuscarVta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcolumnMtoTotalBuscarVta.HeaderText = "Total";
            this.dgvcolumnMtoTotalBuscarVta.Name = "dgvcolumnMtoTotalBuscarVta";
            this.dgvcolumnMtoTotalBuscarVta.ReadOnly = true;
            this.dgvcolumnMtoTotalBuscarVta.Width = 68;
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            this.Vendedor.Width = 110;
            // 
            // Ver
            // 
            this.Ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ver.HeaderText = "Ver";
            this.Ver.Image = global::CapaPresentacion.Properties.Resources.ver;
            this.Ver.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ver.Width = 58;
            // 
            // frmBuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 308);
            this.Controls.Add(this.grbDetalleBusqueda);
            this.Controls.Add(this.pnlBusquedaVta);
            this.Name = "frmBuscarVenta";
            this.Text = "Buscar Ventas";
            this.Load += new System.EventHandler(this.frmBuscarVenta_Load);
            this.pnlBusquedaVta.ResumeLayout(false);
            this.pnlBusquedaVta.PerformLayout();
            this.grbDetalleBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaVta;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarBuscarVta;
        private Guna.UI.WinForms.GunaTileButton btnBuscarBuscarVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarFactura;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleBusqueda;
        private Guna.UI.WinForms.GunaDataGridView dgvVentas;
        private Guna.UI.WinForms.GunaButton btnMenuMarca;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnFechaBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnClienteBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnMtoTotalBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewImageColumn Ver;
    }
}