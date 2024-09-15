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
            this.txtCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.lblBuscarPorCateg = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.btnGuardarCategoria = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarCategoria = new Guna.UI.WinForms.GunaTileButton();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCategoria = new Guna.UI.WinForms.GunaDataGridView();
            this.btnEditarDataGrid = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaCategoria.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaCategoria
            // 
            this.pnlBusquedaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCategoria.Controls.Add(this.guna2VSeparator1);
            this.pnlBusquedaCategoria.Controls.Add(this.txtCategoria);
            this.pnlBusquedaCategoria.Controls.Add(this.lblCategoriaProd);
            this.pnlBusquedaCategoria.Controls.Add(this.btnGuardarCategoria);
            this.pnlBusquedaCategoria.Controls.Add(this.btnBuscarCategoria);
            this.pnlBusquedaCategoria.Controls.Add(this.lblBuscarPorCateg);
            this.pnlBusquedaCategoria.Controls.Add(this.txtBuscarCategoria);
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
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoria.BaseColor = System.Drawing.Color.White;
            this.txtCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtCategoria.BorderSize = 1;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategoria.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtCategoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(95, 13);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.Radius = 10;
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(228, 26);
            this.txtCategoria.TabIndex = 36;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProd.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaProd.Location = new System.Drawing.Point(12, 18);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(84, 32);
            this.lblCategoriaProd.TabIndex = 37;
            this.lblCategoriaProd.Text = "Nombre de \r\nla Marca";
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
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarCategoria.BaseColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCategoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarCategoria.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarCategoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(450, 13);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.Radius = 10;
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarCategoria.TabIndex = 52;
            this.txtBuscarCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnGuardarCategoria.AnimationSpeed = 0.03F;
            this.btnGuardarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCategoria.BaseColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnGuardarCategoria.BorderSize = 2;
            this.btnGuardarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCategoria.Image")));
            this.btnGuardarCategoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardarCategoria.Location = new System.Drawing.Point(223, 45);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.OnHoverImage = null;
            this.btnGuardarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarCategoria.Radius = 10;
            this.btnGuardarCategoria.Size = new System.Drawing.Size(100, 34);
            this.btnGuardarCategoria.TabIndex = 66;
            this.btnGuardarCategoria.Text = "Guardar";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnBuscarCategoria.AnimationSpeed = 0.03F;
            this.btnBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCategoria.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarCategoria.BorderSize = 2;
            this.btnBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCategoria.Image")));
            this.btnBuscarCategoria.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarCategoria.Location = new System.Drawing.Point(639, 11);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarCategoria.OnHoverImage = null;
            this.btnBuscarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarCategoria.Radius = 5;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarCategoria.TabIndex = 55;
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvCategoria);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(0, 100);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(800, 350);
            this.grbListaUsuarios.TabIndex = 58;
            this.grbListaUsuarios.Text = "Lista de Categorias";
            this.grbListaUsuarios.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvCategoria
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoria.ColumnHeadersHeight = 18;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoria.EnableHeadersVisualStyles = false;
            this.dgvCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvCategoria.Location = new System.Drawing.Point(2, 30);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(796, 318);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCategoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvCategoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvCategoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategoria.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvCategoria.ThemeStyle.ReadOnly = true;
            this.dgvCategoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.btnEditarDataGrid.Width = 68;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 64;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.FillWeight = 33.23971F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.FillWeight = 228.6892F;
            this.Categoria.HeaderText = "Nombre de Marca";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbListaUsuarios);
            this.Controls.Add(this.pnlBusquedaCategoria);
            this.Name = "frmMarca";
            this.Text = "Form1";
            this.pnlBusquedaCategoria.ResumeLayout(false);
            this.pnlBusquedaCategoria.PerformLayout();
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaCategoria;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI.WinForms.GunaTextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoriaProd;
        private Guna.UI.WinForms.GunaButton btnGuardarCategoria;
        private Guna.UI.WinForms.GunaTileButton btnBuscarCategoria;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCateg;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCategoria;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvCategoria;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}