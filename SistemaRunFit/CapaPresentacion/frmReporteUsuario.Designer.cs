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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvReporteUsuario = new Guna.UI.WinForms.GunaDataGridView();
            this.cmbReporteUsuario = new Guna.UI.WinForms.GunaComboBox();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.grbDetalleVta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteUsuario)).BeginInit();
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
            this.grbDetalleVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.Controls.Add(this.dgvReporteUsuario);
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
            this.grbDetalleVta.Size = new System.Drawing.Size(775, 333);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dgvReporteUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteUsuario.ColumnHeadersHeight = 34;
            this.dgvReporteUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteUsuario.EnableHeadersVisualStyles = false;
            this.dgvReporteUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteUsuario.Location = new System.Drawing.Point(2, 50);
            this.dgvReporteUsuario.MultiSelect = false;
            this.dgvReporteUsuario.Name = "dgvReporteUsuario";
            this.dgvReporteUsuario.ReadOnly = true;
            this.dgvReporteUsuario.RowHeadersVisible = false;
            this.dgvReporteUsuario.RowHeadersWidth = 51;
            this.dgvReporteUsuario.RowTemplate.Height = 30;
            this.dgvReporteUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteUsuario.Size = new System.Drawing.Size(771, 281);
            this.dgvReporteUsuario.TabIndex = 0;
            this.dgvReporteUsuario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReporteUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReporteUsuario.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvReporteUsuario.ThemeStyle.ReadOnly = true;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteUsuario.ThemeStyle.RowsStyle.Height = 30;
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
            "Productos mas vendidos en dinero"});
            this.cmbReporteUsuario.Location = new System.Drawing.Point(171, 86);
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
            this.lblBuscarPorUser.Location = new System.Drawing.Point(28, 89);
            this.lblBuscarPorUser.Name = "lblBuscarPorUser";
            this.lblBuscarPorUser.Size = new System.Drawing.Size(113, 16);
            this.lblBuscarPorUser.TabIndex = 82;
            this.lblBuscarPorUser.Text = "TIPO DE REPORTE";
            // 
            // frmReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.lblBuscarPorUser);
            this.Controls.Add(this.cmbReporteUsuario);
            this.Controls.Add(this.grbDetalleVta);
            this.Controls.Add(this.lblTituloReporte);
            this.Name = "frmReporteUsuario";
            this.Text = "frmReportes";
            this.grbDetalleVta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloReporte;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Guna.UI.WinForms.GunaDataGridView dgvReporteUsuario;
        private Guna.UI.WinForms.GunaComboBox cmbReporteUsuario;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
    }
}