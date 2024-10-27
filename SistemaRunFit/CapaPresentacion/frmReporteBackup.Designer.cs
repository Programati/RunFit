namespace CapaPresentacion
{
    partial class frmReporteBackup
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
            this.grbDetalleBackup = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvReporteBackup = new Guna.UI.WinForms.GunaDataGridView();
            this.btnComprobarBackup = new Guna.UI.WinForms.GunaButton();
            this.grbDetalleBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalleBackup
            // 
            this.grbDetalleBackup.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleBackup.BaseColor = System.Drawing.Color.White;
            this.grbDetalleBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBackup.Controls.Add(this.dgvReporteBackup);
            this.grbDetalleBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDetalleBackup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleBackup.ForeColor = System.Drawing.Color.White;
            this.grbDetalleBackup.LineBottom = 2;
            this.grbDetalleBackup.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleBackup.LineLeft = 2;
            this.grbDetalleBackup.LineRight = 2;
            this.grbDetalleBackup.LineTop = 50;
            this.grbDetalleBackup.Location = new System.Drawing.Point(0, 117);
            this.grbDetalleBackup.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbDetalleBackup.Name = "grbDetalleBackup";
            this.grbDetalleBackup.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbDetalleBackup.Size = new System.Drawing.Size(800, 333);
            this.grbDetalleBackup.TabIndex = 81;
            this.grbDetalleBackup.Text = "Detalle de  Backup";
            this.grbDetalleBackup.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvReporteBackup
            // 
            this.dgvReporteBackup.AllowUserToAddRows = false;
            this.dgvReporteBackup.AllowUserToDeleteRows = false;
            this.dgvReporteBackup.AllowUserToResizeColumns = false;
            this.dgvReporteBackup.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.dgvReporteBackup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReporteBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteBackup.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteBackup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteBackup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteBackup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteBackup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReporteBackup.ColumnHeadersHeight = 34;
            this.dgvReporteBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteBackup.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReporteBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporteBackup.EnableHeadersVisualStyles = false;
            this.dgvReporteBackup.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteBackup.Location = new System.Drawing.Point(2, 50);
            this.dgvReporteBackup.MultiSelect = false;
            this.dgvReporteBackup.Name = "dgvReporteBackup";
            this.dgvReporteBackup.ReadOnly = true;
            this.dgvReporteBackup.RowHeadersVisible = false;
            this.dgvReporteBackup.RowHeadersWidth = 51;
            this.dgvReporteBackup.RowTemplate.Height = 30;
            this.dgvReporteBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteBackup.Size = new System.Drawing.Size(796, 281);
            this.dgvReporteBackup.TabIndex = 0;
            this.dgvReporteBackup.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvReporteBackup.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvReporteBackup.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteBackup.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReporteBackup.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReporteBackup.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReporteBackup.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReporteBackup.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReporteBackup.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvReporteBackup.ThemeStyle.ReadOnly = true;
            this.dgvReporteBackup.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvReporteBackup.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReporteBackup.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReporteBackup.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReporteBackup.ThemeStyle.RowsStyle.Height = 30;
            this.dgvReporteBackup.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvReporteBackup.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnComprobarBackup
            // 
            this.btnComprobarBackup.AnimationHoverSpeed = 0.07F;
            this.btnComprobarBackup.AnimationSpeed = 0.03F;
            this.btnComprobarBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnComprobarBackup.BaseColor = System.Drawing.Color.White;
            this.btnComprobarBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnComprobarBackup.BorderSize = 2;
            this.btnComprobarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobarBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComprobarBackup.FocusedColor = System.Drawing.Color.Red;
            this.btnComprobarBackup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobarBackup.ForeColor = System.Drawing.Color.Red;
            this.btnComprobarBackup.Image = null;
            this.btnComprobarBackup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprobarBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnComprobarBackup.Location = new System.Drawing.Point(329, 74);
            this.btnComprobarBackup.Name = "btnComprobarBackup";
            this.btnComprobarBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnComprobarBackup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnComprobarBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnComprobarBackup.OnHoverImage = null;
            this.btnComprobarBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnComprobarBackup.Radius = 10;
            this.btnComprobarBackup.Size = new System.Drawing.Size(140, 37);
            this.btnComprobarBackup.TabIndex = 86;
            this.btnComprobarBackup.Text = "Comprobar";
            this.btnComprobarBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComprobarBackup.Click += new System.EventHandler(this.btnComprobarBackup_Click);
            // 
            // frmReporteBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComprobarBackup);
            this.Controls.Add(this.grbDetalleBackup);
            this.Name = "frmReporteBackup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmReporteBackup_Load);
            this.grbDetalleBackup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grbDetalleBackup;
        private Guna.UI.WinForms.GunaDataGridView dgvReporteBackup;
        private Guna.UI.WinForms.GunaButton btnComprobarBackup;
    }
}