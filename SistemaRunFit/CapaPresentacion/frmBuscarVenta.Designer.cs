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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBusquedaVta = new Guna.UI.WinForms.GunaShadowPanel();
            this.pnlBuscarVtaDerecha = new System.Windows.Forms.Panel();
            this.btnLimpiarBuscarVta = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarBuscarVta = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarPorVta = new Guna.UI.WinForms.GunaLabel();
            this.cmbBuscarPorUser = new Guna.UI.WinForms.GunaComboBox();
            this.txtBuscarUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblPnlBuscarVta = new Guna.UI.WinForms.GunaLabel();
            this.grbDetalleBusqueda = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvDetalleVta = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvcolumnNumFactBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnFechaBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnClienteBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcolumnMtoTotalBuscarVta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBusquedaVta.SuspendLayout();
            this.pnlBuscarVtaDerecha.SuspendLayout();
            this.grbDetalleBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaVta
            // 
            this.pnlBusquedaVta.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaVta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaVta.Controls.Add(this.pnlBuscarVtaDerecha);
            this.pnlBusquedaVta.Controls.Add(this.lblPnlBuscarVta);
            this.pnlBusquedaVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaVta.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaVta.Name = "pnlBusquedaVta";
            this.pnlBusquedaVta.Radius = 5;
            this.pnlBusquedaVta.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaVta.Size = new System.Drawing.Size(888, 110);
            this.pnlBusquedaVta.TabIndex = 1;
            // 
            // pnlBuscarVtaDerecha
            // 
            this.pnlBuscarVtaDerecha.Controls.Add(this.btnLimpiarBuscarVta);
            this.pnlBuscarVtaDerecha.Controls.Add(this.btnBuscarBuscarVta);
            this.pnlBuscarVtaDerecha.Controls.Add(this.lblBuscarPorVta);
            this.pnlBuscarVtaDerecha.Controls.Add(this.cmbBuscarPorUser);
            this.pnlBuscarVtaDerecha.Controls.Add(this.txtBuscarUser);
            this.pnlBuscarVtaDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBuscarVtaDerecha.Location = new System.Drawing.Point(306, 0);
            this.pnlBuscarVtaDerecha.Name = "pnlBuscarVtaDerecha";
            this.pnlBuscarVtaDerecha.Size = new System.Drawing.Size(582, 110);
            this.pnlBuscarVtaDerecha.TabIndex = 55;
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
            this.btnLimpiarBuscarVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscarVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarBuscarVta.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarBuscarVta.Image")));
            this.btnLimpiarBuscarVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarBuscarVta.Location = new System.Drawing.Point(498, 31);
            this.btnLimpiarBuscarVta.Name = "btnLimpiarBuscarVta";
            this.btnLimpiarBuscarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarBuscarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarVta.OnHoverImage = null;
            this.btnLimpiarBuscarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarVta.Radius = 5;
            this.btnLimpiarBuscarVta.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarBuscarVta.TabIndex = 56;
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
            this.btnBuscarBuscarVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarBuscarVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarBuscarVta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBuscarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarBuscarVta.Image")));
            this.btnBuscarBuscarVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarBuscarVta.Location = new System.Drawing.Point(457, 31);
            this.btnBuscarBuscarVta.Name = "btnBuscarBuscarVta";
            this.btnBuscarBuscarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarBuscarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarBuscarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarBuscarVta.OnHoverImage = null;
            this.btnBuscarBuscarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarBuscarVta.Radius = 5;
            this.btnBuscarBuscarVta.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarBuscarVta.TabIndex = 55;
            // 
            // lblBuscarPorVta
            // 
            this.lblBuscarPorVta.AutoSize = true;
            this.lblBuscarPorVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorVta.Location = new System.Drawing.Point(7, 38);
            this.lblBuscarPorVta.Name = "lblBuscarPorVta";
            this.lblBuscarPorVta.Size = new System.Drawing.Size(81, 16);
            this.lblBuscarPorVta.TabIndex = 1;
            this.lblBuscarPorVta.Text = "Buscar por:";
            // 
            // cmbBuscarPorUser
            // 
            this.cmbBuscarPorUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarPorUser.BaseColor = System.Drawing.Color.White;
            this.cmbBuscarPorUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbBuscarPorUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBuscarPorUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarPorUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPorUser.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorUser.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarPorUser.FormattingEnabled = true;
            this.cmbBuscarPorUser.Items.AddRange(new object[] {
            "N° de Factura",
            "Cliente",
            "Fecha"});
            this.cmbBuscarPorUser.Location = new System.Drawing.Point(92, 34);
            this.cmbBuscarPorUser.Margin = new System.Windows.Forms.Padding(1);
            this.cmbBuscarPorUser.Name = "cmbBuscarPorUser";
            this.cmbBuscarPorUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbBuscarPorUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorUser.Radius = 10;
            this.cmbBuscarPorUser.Size = new System.Drawing.Size(169, 24);
            this.cmbBuscarPorUser.TabIndex = 45;
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarUser.BaseColor = System.Drawing.Color.White;
            this.txtBuscarUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarUser.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUser.Location = new System.Drawing.Point(265, 33);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.PasswordChar = '\0';
            this.txtBuscarUser.Radius = 10;
            this.txtBuscarUser.SelectedText = "";
            this.txtBuscarUser.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarUser.TabIndex = 52;
            this.txtBuscarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPnlBuscarVta
            // 
            this.lblPnlBuscarVta.AutoSize = true;
            this.lblPnlBuscarVta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnlBuscarVta.ForeColor = System.Drawing.Color.White;
            this.lblPnlBuscarVta.Location = new System.Drawing.Point(24, 20);
            this.lblPnlBuscarVta.Name = "lblPnlBuscarVta";
            this.lblPnlBuscarVta.Size = new System.Drawing.Size(146, 50);
            this.lblPnlBuscarVta.TabIndex = 0;
            this.lblPnlBuscarVta.Text = "Buscador de \r\n    Ventas";
            // 
            // grbDetalleBusqueda
            // 
            this.grbDetalleBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleBusqueda.BaseColor = System.Drawing.Color.White;
            this.grbDetalleBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBusqueda.Controls.Add(this.dgvDetalleVta);
            this.grbDetalleBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleBusqueda.ForeColor = System.Drawing.Color.White;
            this.grbDetalleBusqueda.LineBottom = 2;
            this.grbDetalleBusqueda.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBusqueda.LineLeft = 2;
            this.grbDetalleBusqueda.LineRight = 2;
            this.grbDetalleBusqueda.Location = new System.Drawing.Point(3, 106);
            this.grbDetalleBusqueda.Name = "grbDetalleBusqueda";
            this.grbDetalleBusqueda.Size = new System.Drawing.Size(885, 356);
            this.grbDetalleBusqueda.TabIndex = 56;
            this.grbDetalleBusqueda.Text = "Detalle de Busqueda";
            this.grbDetalleBusqueda.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvDetalleVta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDetalleVta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVta.ColumnHeadersHeight = 18;
            this.dgvDetalleVta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcolumnNumFactBuscarVta,
            this.dgvcolumnFechaBuscarVta,
            this.dgvcolumnClienteBuscarVta,
            this.dgvcolumnMtoTotalBuscarVta,
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.Location = new System.Drawing.Point(3, 29);
            this.dgvDetalleVta.Name = "dgvDetalleVta";
            this.dgvDetalleVta.RowHeadersVisible = false;
            this.dgvDetalleVta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVta.Size = new System.Drawing.Size(870, 324);
            this.dgvDetalleVta.TabIndex = 0;
            this.dgvDetalleVta.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvDetalleVta.ThemeStyle.ReadOnly = false;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dgvcolumnNumFactBuscarVta
            // 
            this.dgvcolumnNumFactBuscarVta.HeaderText = "N° de Factura";
            this.dgvcolumnNumFactBuscarVta.Name = "dgvcolumnNumFactBuscarVta";
            // 
            // dgvcolumnFechaBuscarVta
            // 
            this.dgvcolumnFechaBuscarVta.HeaderText = "Fecha de venta";
            this.dgvcolumnFechaBuscarVta.Name = "dgvcolumnFechaBuscarVta";
            // 
            // dgvcolumnClienteBuscarVta
            // 
            this.dgvcolumnClienteBuscarVta.HeaderText = "Cliente";
            this.dgvcolumnClienteBuscarVta.Name = "dgvcolumnClienteBuscarVta";
            // 
            // dgvcolumnMtoTotalBuscarVta
            // 
            this.dgvcolumnMtoTotalBuscarVta.HeaderText = "Monto Total";
            this.dgvcolumnMtoTotalBuscarVta.Name = "dgvcolumnMtoTotalBuscarVta";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "VerDetalle";
            this.Accion.Name = "Accion";
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmBuscarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 474);
            this.Controls.Add(this.grbDetalleBusqueda);
            this.Controls.Add(this.pnlBusquedaVta);
            this.Name = "frmBuscarVenta";
            this.Text = "Buscar Ventas";
            this.pnlBusquedaVta.ResumeLayout(false);
            this.pnlBusquedaVta.PerformLayout();
            this.pnlBuscarVtaDerecha.ResumeLayout(false);
            this.pnlBuscarVtaDerecha.PerformLayout();
            this.grbDetalleBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaVta;
        private System.Windows.Forms.Panel pnlBuscarVtaDerecha;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarBuscarVta;
        private Guna.UI.WinForms.GunaTileButton btnBuscarBuscarVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorVta;
        private Guna.UI.WinForms.GunaComboBox cmbBuscarPorUser;
        private Guna.UI.WinForms.GunaTextBox txtBuscarUser;
        private Guna.UI.WinForms.GunaLabel lblPnlBuscarVta;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleBusqueda;
        private Guna.UI.WinForms.GunaDataGridView dgvDetalleVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnNumFactBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnFechaBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnClienteBuscarVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcolumnMtoTotalBuscarVta;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}