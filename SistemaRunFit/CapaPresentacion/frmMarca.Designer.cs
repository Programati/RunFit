namespace CapaPresentacion
{
    partial class frmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBusquedaCategoria = new Guna.UI.WinForms.GunaShadowPanel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.txtMarca = new Guna.UI.WinForms.GunaTextBox();
            this.lblMarcaNombreProd = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarMarca = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarPorCateg = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarMarca = new Guna.UI.WinForms.GunaTextBox();
            this.grbListaMarcas = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvMarca = new Guna.UI.WinForms.GunaDataGridView();
            this.btnEditarDataGrid = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaCategoria.SuspendLayout();
            this.grbListaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaCategoria
            // 
            this.pnlBusquedaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCategoria.Controls.Add(this.guna2VSeparator1);
            this.pnlBusquedaCategoria.Controls.Add(this.txtMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.lblMarcaNombreProd);
            this.pnlBusquedaCategoria.Controls.Add(this.btnGuardarMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.btnBuscarMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.lblBuscarPorCateg);
            this.pnlBusquedaCategoria.Controls.Add(this.txtBuscarMarca);
            this.pnlBusquedaCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaCategoria.Name = "pnlBusquedaCategoria";
            this.pnlBusquedaCategoria.Radius = 5;
            this.pnlBusquedaCategoria.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaCategoria.Size = new System.Drawing.Size(800, 100);
            this.pnlBusquedaCategoria.TabIndex = 57;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(339, 10);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(22, 83);
            this.guna2VSeparator1.TabIndex = 67;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.Transparent;
            this.txtMarca.BaseColor = System.Drawing.Color.White;
            this.txtMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtMarca.BorderSize = 1;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMarca.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtMarca.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(95, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.Radius = 10;
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(228, 26);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMarcaNombreProd
            // 
            this.lblMarcaNombreProd.AutoSize = true;
            this.lblMarcaNombreProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaNombreProd.ForeColor = System.Drawing.Color.White;
            this.lblMarcaNombreProd.Location = new System.Drawing.Point(12, 18);
            this.lblMarcaNombreProd.Name = "lblMarcaNombreProd";
            this.lblMarcaNombreProd.Size = new System.Drawing.Size(84, 32);
            this.lblMarcaNombreProd.TabIndex = 37;
            this.lblMarcaNombreProd.Text = "Nombre de \r\nla Marca";
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.AnimationHoverSpeed = 0.07F;
            this.btnGuardarMarca.AnimationSpeed = 0.03F;
            this.btnGuardarMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarMarca.BaseColor = System.Drawing.Color.White;
            this.btnGuardarMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnGuardarMarca.BorderSize = 2;
            this.btnGuardarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarMarca.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMarca.Image")));
            this.btnGuardarMarca.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardarMarca.Location = new System.Drawing.Point(223, 45);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarMarca.OnHoverImage = null;
            this.btnGuardarMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.Radius = 10;
            this.btnGuardarMarca.Size = new System.Drawing.Size(100, 34);
            this.btnGuardarMarca.TabIndex = 66;
            this.btnGuardarMarca.Text = "Guardar";
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.AnimationHoverSpeed = 0.07F;
            this.btnBuscarMarca.AnimationSpeed = 0.03F;
            this.btnBuscarMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMarca.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarMarca.BorderSize = 2;
            this.btnBuscarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarMarca.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarMarca.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarMarca.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMarca.Image")));
            this.btnBuscarMarca.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarMarca.Location = new System.Drawing.Point(639, 11);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarMarca.OnHoverImage = null;
            this.btnBuscarMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarMarca.Radius = 5;
            this.btnBuscarMarca.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarMarca.TabIndex = 55;
            // 
            // lblBuscarPorCateg
            // 
            this.lblBuscarPorCateg.AutoSize = true;
            this.lblBuscarPorCateg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCateg.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorCateg.Location = new System.Drawing.Point(384, 18);
            this.lblBuscarPorCateg.Name = "lblBuscarPorCateg";
            this.lblBuscarPorCateg.Size = new System.Drawing.Size(51, 16);
            this.lblBuscarPorCateg.TabIndex = 1;
            this.lblBuscarPorCateg.Text = "Buscar";
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarMarca.BaseColor = System.Drawing.Color.White;
            this.txtBuscarMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarMarca.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarMarca.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarMarca.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarMarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.Location = new System.Drawing.Point(450, 13);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.PasswordChar = '\0';
            this.txtBuscarMarca.Radius = 10;
            this.txtBuscarMarca.SelectedText = "";
            this.txtBuscarMarca.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarMarca.TabIndex = 52;
            this.txtBuscarMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbListaMarcas
            // 
            this.grbListaMarcas.BackColor = System.Drawing.Color.Transparent;
            this.grbListaMarcas.BaseColor = System.Drawing.Color.White;
            this.grbListaMarcas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaMarcas.Controls.Add(this.dgvMarca);
            this.grbListaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaMarcas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaMarcas.ForeColor = System.Drawing.Color.White;
            this.grbListaMarcas.LineBottom = 2;
            this.grbListaMarcas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaMarcas.LineLeft = 2;
            this.grbListaMarcas.LineRight = 2;
            this.grbListaMarcas.Location = new System.Drawing.Point(0, 100);
            this.grbListaMarcas.Name = "grbListaMarcas";
            this.grbListaMarcas.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaMarcas.Size = new System.Drawing.Size(800, 350);
            this.grbListaMarcas.TabIndex = 58;
            this.grbListaMarcas.Text = "Lista de Marcas";
            this.grbListaMarcas.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarca.ColumnHeadersHeight = 34;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditarDataGrid,
            this.Eliminar,
            this.ID,
            this.Categoria});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarca.EnableHeadersVisualStyles = false;
            this.dgvMarca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvMarca.Location = new System.Drawing.Point(2, 30);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(796, 318);
            this.dgvMarca.TabIndex = 0;
            this.dgvMarca.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvMarca.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvMarca.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMarca.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMarca.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMarca.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMarca.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMarca.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvMarca.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvMarca.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarca.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMarca.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMarca.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMarca.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvMarca.ThemeStyle.ReadOnly = true;
            this.dgvMarca.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvMarca.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarca.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMarca.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMarca.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMarca.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvMarca.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnEditarDataGrid
            // 
            this.btnEditarDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnEditarDataGrid.FillWeight = 38.07107F;
            this.btnEditarDataGrid.HeaderText = "Editar";
            this.btnEditarDataGrid.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.btnEditarDataGrid.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditarDataGrid.Name = "btnEditarDataGrid";
            this.btnEditarDataGrid.ReadOnly = true;
            this.btnEditarDataGrid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditarDataGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditarDataGrid.Width = 72;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 68;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.FillWeight = 33.23971F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 47;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.FillWeight = 228.6892F;
            this.Categoria.HeaderText = "Nombre de Marca";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 154;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbListaMarcas);
            this.Controls.Add(this.pnlBusquedaCategoria);
            this.Name = "frmMarca";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.pnlBusquedaCategoria.ResumeLayout(false);
            this.pnlBusquedaCategoria.PerformLayout();
            this.grbListaMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaCategoria;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI.WinForms.GunaTextBox txtMarca;
        private System.Windows.Forms.Label lblMarcaNombreProd;
        private Guna.UI.WinForms.GunaButton btnGuardarMarca;
        private Guna.UI.WinForms.GunaTileButton btnBuscarMarca;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCateg;
        private Guna.UI.WinForms.GunaTextBox txtBuscarMarca;
        private Guna.UI.WinForms.GunaGroupBox grbListaMarcas;
        private Guna.UI.WinForms.GunaDataGridView dgvMarca;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}