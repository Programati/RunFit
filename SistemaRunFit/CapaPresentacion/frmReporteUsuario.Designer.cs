namespace CapaPresentacion
{
    partial class frmReporteUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvReporteUsuario = new Guna.UI.WinForms.GunaDataGridView();
            this.cmbReporteUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReporteHasta = new Guna.UI.WinForms.GunaLabel();
            this.lblDesdeReporte = new Guna.UI.WinForms.GunaLabel();
            this.dtpFechaHastaUsuario = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdeUsuario = new System.Windows.Forms.DateTimePicker();
            this.grbDetalleVta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloReporte
            // 
            this.lblTituloReporte.AutoSize = true;
            this.lblTituloReporte.Font = new System.Drawing.Font("Century Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporte.Location = new System.Drawing.Point(174, 9);
            this.lblTituloReporte.Name = "lblTituloReporte";
            this.lblTituloReporte.Size = new System.Drawing.Size(367, 46);
            this.lblTituloReporte.TabIndex = 1;
            this.lblTituloReporte.Text = "REPORTE DE VENTAS";
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.Black;
            this.grbDetalleVta.Controls.Add(this.dgvReporteUsuario);
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
            this.grbDetalleVta.Size = new System.Drawing.Size(772, 500);
            this.grbDetalleVta.TabIndex = 80;
            this.grbDetalleVta.Text = "Detalle de venta";
            this.grbDetalleVta.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvReporteUsuario
            // 
            this.dgvReporteUsuario.AllowUserToAddRows = false;
            this.dgvReporteUsuario.AllowUserToDeleteRows = false;
            this.dgvReporteUsuario.AllowUserToResizeColumns = false;
            this.dgvReporteUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            this.dgvReporteUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvReporteUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReporteUsuario.ColumnHeadersHeight = 34;
            this.dgvReporteUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteUsuario.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvReporteUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteUsuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvReporteUsuario.EnableHeadersVisualStyles = false;
            this.dgvReporteUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteUsuario.Location = new System.Drawing.Point(2, 50);
            this.dgvReporteUsuario.MultiSelect = false;
            this.dgvReporteUsuario.Name = "dgvReporteUsuario";
            this.dgvReporteUsuario.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReporteUsuario.RowHeadersVisible = false;
            this.dgvReporteUsuario.RowHeadersWidth = 51;
            this.dgvReporteUsuario.RowTemplate.Height = 35;
            this.dgvReporteUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteUsuario.Size = new System.Drawing.Size(768, 448);
            this.dgvReporteUsuario.TabIndex = 0;
            this.dgvReporteUsuario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvReporteUsuario.ThemeStyle.ReadOnly = true;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.Height = 35;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmbReporteUsuario
            // 
            this.cmbReporteUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbReporteUsuario.BaseColor = System.Drawing.Color.White;
            this.cmbReporteUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbReporteUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbReporteUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbReporteUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporteUsuario.FocusedColor = System.Drawing.Color.Empty;
            this.cmbReporteUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporteUsuario.ForeColor = System.Drawing.Color.Black;
            this.cmbReporteUsuario.FormattingEnabled = true;
            this.cmbReporteUsuario.Items.AddRange(new object[] {
            "Ventas cronologico",
            "Productos mas vendidos por unidad",
            "Productos mas Rentables"});
            this.cmbReporteUsuario.Location = new System.Drawing.Point(173, 77);
            this.cmbReporteUsuario.Margin = new System.Windows.Forms.Padding(1);
            this.cmbReporteUsuario.Name = "cmbReporteUsuario";
            this.cmbReporteUsuario.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbReporteUsuario.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbReporteUsuario.Radius = 10;
            this.cmbReporteUsuario.Size = new System.Drawing.Size(254, 24);
            this.cmbReporteUsuario.TabIndex = 81;
            this.cmbReporteUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbReporteUsuario_SelectedIndexChanged);
            // 
            // lblBuscarPorUser
            // 
            this.lblBuscarPorUser.AutoSize = true;
            this.lblBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorUser.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarPorUser.Location = new System.Drawing.Point(30, 80);
            this.lblBuscarPorUser.Name = "lblBuscarPorUser";
            this.lblBuscarPorUser.Size = new System.Drawing.Size(113, 16);
            this.lblBuscarPorUser.TabIndex = 82;
            this.lblBuscarPorUser.Text = "TIPO DE REPORTE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbDetalleVta);
            this.panel1.Location = new System.Drawing.Point(2, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 500);
            this.panel1.TabIndex = 83;
            // 
            // lblReporteHasta
            // 
            this.lblReporteHasta.AutoSize = true;
            this.lblReporteHasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteHasta.ForeColor = System.Drawing.Color.Black;
            this.lblReporteHasta.Location = new System.Drawing.Point(622, 61);
            this.lblReporteHasta.Name = "lblReporteHasta";
            this.lblReporteHasta.Size = new System.Drawing.Size(53, 16);
            this.lblReporteHasta.TabIndex = 92;
            this.lblReporteHasta.Text = "HASTA:";
            // 
            // lblDesdeReporte
            // 
            this.lblDesdeReporte.AutoSize = true;
            this.lblDesdeReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeReporte.ForeColor = System.Drawing.Color.Black;
            this.lblDesdeReporte.Location = new System.Drawing.Point(460, 61);
            this.lblDesdeReporte.Name = "lblDesdeReporte";
            this.lblDesdeReporte.Size = new System.Drawing.Size(50, 16);
            this.lblDesdeReporte.TabIndex = 91;
            this.lblDesdeReporte.Text = "DESDE:";
            // 
            // dtpFechaHastaUsuario
            // 
            this.dtpFechaHastaUsuario.Location = new System.Drawing.Point(614, 80);
            this.dtpFechaHastaUsuario.Name = "dtpFechaHastaUsuario";
            this.dtpFechaHastaUsuario.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaHastaUsuario.TabIndex = 90;
            // 
            // dtpFechaDesdeUsuario
            // 
            this.dtpFechaDesdeUsuario.Location = new System.Drawing.Point(448, 80);
            this.dtpFechaDesdeUsuario.Name = "dtpFechaDesdeUsuario";
            this.dtpFechaDesdeUsuario.Size = new System.Drawing.Size(134, 20);
            this.dtpFechaDesdeUsuario.TabIndex = 89;
            // 
            // frmReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.lblReporteHasta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDesdeReporte);
            this.Controls.Add(this.lblBuscarPorUser);
            this.Controls.Add(this.dtpFechaHastaUsuario);
            this.Controls.Add(this.cmbReporteUsuario);
            this.Controls.Add(this.dtpFechaDesdeUsuario);
            this.Controls.Add(this.lblTituloReporte);
            this.Name = "frmReporteUsuario";
            this.Text = "frmReportes";
            this.grbDetalleVta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloReporte;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Guna.UI.WinForms.GunaDataGridView dgvReporteUsuario;
        private Guna.UI.WinForms.GunaComboBox cmbReporteUsuario;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel lblReporteHasta;
        private Guna.UI.WinForms.GunaLabel lblDesdeReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeUsuario;
    }
}