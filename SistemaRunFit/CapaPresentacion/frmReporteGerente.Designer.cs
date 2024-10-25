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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvReporteGerente = new Guna.UI.WinForms.GunaDataGridView();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.cmbReporteGerente = new Guna.UI.WinForms.GunaComboBox();
            this.grbDetalleVta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.Controls.Add(this.dgvReporteGerente);
            this.grbDetalleVta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDetalleVta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleVta.ForeColor = System.Drawing.Color.White;
            this.grbDetalleVta.LineBottom = 2;
            this.grbDetalleVta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.LineLeft = 2;
            this.grbDetalleVta.LineRight = 2;
            this.grbDetalleVta.LineTop = 50;
            this.grbDetalleVta.Location = new System.Drawing.Point(0, 117);
            this.grbDetalleVta.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbDetalleVta.Name = "grbDetalleVta";
            this.grbDetalleVta.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbDetalleVta.Size = new System.Drawing.Size(800, 333);
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            this.dgvReporteGerente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReporteGerente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteGerente.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteGerente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteGerente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteGerente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteGerente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReporteGerente.ColumnHeadersHeight = 34;
            this.dgvReporteGerente.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteGerente.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReporteGerente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteGerente.EnableHeadersVisualStyles = false;
            this.dgvReporteGerente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteGerente.Location = new System.Drawing.Point(2, 50);
            this.dgvReporteGerente.MultiSelect = false;
            this.dgvReporteGerente.Name = "dgvReporteGerente";
            this.dgvReporteGerente.ReadOnly = true;
            this.dgvReporteGerente.RowHeadersVisible = false;
            this.dgvReporteGerente.RowHeadersWidth = 51;
            this.dgvReporteGerente.RowTemplate.Height = 30;
            this.dgvReporteGerente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteGerente.Size = new System.Drawing.Size(796, 281);
            this.dgvReporteGerente.TabIndex = 0;
            this.dgvReporteGerente.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvReporteGerente.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvReporteGerente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteGerente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteGerente.ThemeStyle.RowsStyle.Height = 30;
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
            this.lblBuscarPorUser.Location = new System.Drawing.Point(25, 88);
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
            "Productos mas vendidos por pto y vendedor"});
            this.cmbReporteGerente.Location = new System.Drawing.Point(168, 85);
            this.cmbReporteGerente.Margin = new System.Windows.Forms.Padding(1);
            this.cmbReporteGerente.Name = "cmbReporteGerente";
            this.cmbReporteGerente.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbReporteGerente.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbReporteGerente.Radius = 10;
            this.cmbReporteGerente.Size = new System.Drawing.Size(254, 24);
            this.cmbReporteGerente.TabIndex = 83;
            this.cmbReporteGerente.SelectedIndexChanged += new System.EventHandler(this.cmbReporteGerente_SelectedIndexChanged);
            // 
            // frmReporteGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBuscarPorUser);
            this.Controls.Add(this.cmbReporteGerente);
            this.Controls.Add(this.lblTituloReporte);
            this.Controls.Add(this.grbDetalleVta);
            this.Name = "frmReporteGerente";
            this.Text = "frmReporteGerente";
            this.grbDetalleVta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Guna.UI.WinForms.GunaDataGridView dgvReporteGerente;
        private System.Windows.Forms.Label lblTituloReporte;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private Guna.UI.WinForms.GunaComboBox cmbReporteGerente;
    }
}