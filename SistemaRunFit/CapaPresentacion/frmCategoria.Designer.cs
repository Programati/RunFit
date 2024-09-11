namespace CapaPresentacion
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDatosCateg = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.txtCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.btnGuardarCategoria = new Guna.UI.WinForms.GunaButton();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCategoria = new Guna.UI.WinForms.GunaDataGridView();
            this.btnEditarDataGrid = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaCategoria = new Guna.UI.WinForms.GunaShadowPanel();
            this.pnlBuscarCateg = new System.Windows.Forms.Panel();
            this.btnLimpiarBuscarCategoria = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarCategoria = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarPorCateg = new Guna.UI.WinForms.GunaLabel();
            this.cmbBuscarCategoria = new Guna.UI.WinForms.GunaComboBox();
            this.txtBuscarCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.lblFormularioProveedor = new Guna.UI.WinForms.GunaLabel();
            this.btnLimpiarCategoria = new Guna.UI.WinForms.GunaButton();
            this.pnlDatosCateg.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.pnlBusquedaCategoria.SuspendLayout();
            this.pnlBuscarCateg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatosCateg
            // 
            this.pnlDatosCateg.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosCateg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlDatosCateg.Controls.Add(this.lblCategoriaProd);
            this.pnlDatosCateg.Controls.Add(this.txtCategoria);
            this.pnlDatosCateg.Location = new System.Drawing.Point(255, 92);
            this.pnlDatosCateg.Name = "pnlDatosCateg";
            this.pnlDatosCateg.Radius = 5;
            this.pnlDatosCateg.ShadowColor = System.Drawing.Color.Black;
            this.pnlDatosCateg.Size = new System.Drawing.Size(341, 70);
            this.pnlDatosCateg.TabIndex = 50;
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProd.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaProd.Location = new System.Drawing.Point(9, 25);
            this.lblCategoriaProd.Name = "lblCategoriaProd";
            this.lblCategoriaProd.Size = new System.Drawing.Size(77, 16);
            this.lblCategoriaProd.TabIndex = 37;
            this.lblCategoriaProd.Text = "Catergoria";
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
            this.txtCategoria.Location = new System.Drawing.Point(92, 20);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.Radius = 10;
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(228, 26);
            this.txtCategoria.TabIndex = 36;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnGuardarCategoria.Location = new System.Drawing.Point(12, 92);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarCategoria.OnHoverImage = null;
            this.btnGuardarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarCategoria.Radius = 10;
            this.btnGuardarCategoria.Size = new System.Drawing.Size(106, 41);
            this.btnGuardarCategoria.TabIndex = 66;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvCategoria);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(0, 184);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(800, 196);
            this.grbListaUsuarios.TabIndex = 55;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
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
            this.dgvCategoria.Size = new System.Drawing.Size(796, 164);
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
            this.dgvCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
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
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 96;
            // 
            // pnlBusquedaCategoria
            // 
            this.pnlBusquedaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCategoria.Controls.Add(this.pnlBuscarCateg);
            this.pnlBusquedaCategoria.Controls.Add(this.lblFormularioProveedor);
            this.pnlBusquedaCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaCategoria.Name = "pnlBusquedaCategoria";
            this.pnlBusquedaCategoria.Radius = 5;
            this.pnlBusquedaCategoria.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaCategoria.Size = new System.Drawing.Size(800, 86);
            this.pnlBusquedaCategoria.TabIndex = 56;
            // 
            // pnlBuscarCateg
            // 
            this.pnlBuscarCateg.Controls.Add(this.btnLimpiarBuscarCategoria);
            this.pnlBuscarCateg.Controls.Add(this.btnBuscarCategoria);
            this.pnlBuscarCateg.Controls.Add(this.lblBuscarPorCateg);
            this.pnlBuscarCateg.Controls.Add(this.cmbBuscarCategoria);
            this.pnlBuscarCateg.Controls.Add(this.txtBuscarCategoria);
            this.pnlBuscarCateg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBuscarCateg.Location = new System.Drawing.Point(163, 0);
            this.pnlBuscarCateg.Name = "pnlBuscarCateg";
            this.pnlBuscarCateg.Size = new System.Drawing.Size(637, 86);
            this.pnlBuscarCateg.TabIndex = 55;
            // 
            // btnLimpiarBuscarCategoria
            // 
            this.btnLimpiarBuscarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarBuscarCategoria.AnimationSpeed = 0.03F;
            this.btnLimpiarBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarCategoria.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarBuscarCategoria.BorderSize = 2;
            this.btnLimpiarBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarBuscarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscarCategoria.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarBuscarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarBuscarCategoria.Image")));
            this.btnLimpiarBuscarCategoria.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarBuscarCategoria.Location = new System.Drawing.Point(498, 31);
            this.btnLimpiarBuscarCategoria.Name = "btnLimpiarBuscarCategoria";
            this.btnLimpiarBuscarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarBuscarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarCategoria.OnHoverImage = null;
            this.btnLimpiarBuscarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarCategoria.Radius = 5;
            this.btnLimpiarBuscarCategoria.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarBuscarCategoria.TabIndex = 56;
            this.btnLimpiarBuscarCategoria.Click += new System.EventHandler(this.btnLimpiarBuscarCategoria_Click);
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
            this.btnBuscarCategoria.Location = new System.Drawing.Point(457, 31);
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
            // lblBuscarPorCateg
            // 
            this.lblBuscarPorCateg.AutoSize = true;
            this.lblBuscarPorCateg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCateg.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorCateg.Location = new System.Drawing.Point(7, 38);
            this.lblBuscarPorCateg.Name = "lblBuscarPorCateg";
            this.lblBuscarPorCateg.Size = new System.Drawing.Size(81, 16);
            this.lblBuscarPorCateg.TabIndex = 1;
            this.lblBuscarPorCateg.Text = "Buscar por:";
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarCategoria.BaseColor = System.Drawing.Color.White;
            this.cmbBuscarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBuscarCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Items.AddRange(new object[] {
            "Codigo",
            "Categoria"});
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(92, 34);
            this.cmbBuscarCategoria.Margin = new System.Windows.Forms.Padding(1);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbBuscarCategoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBuscarCategoria.Radius = 10;
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(169, 24);
            this.cmbBuscarCategoria.TabIndex = 45;
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
            this.txtBuscarCategoria.Location = new System.Drawing.Point(265, 33);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.Radius = 10;
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarCategoria.TabIndex = 52;
            this.txtBuscarCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormularioProveedor
            // 
            this.lblFormularioProveedor.AutoSize = true;
            this.lblFormularioProveedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioProveedor.ForeColor = System.Drawing.Color.White;
            this.lblFormularioProveedor.Location = new System.Drawing.Point(12, 29);
            this.lblFormularioProveedor.Name = "lblFormularioProveedor";
            this.lblFormularioProveedor.Size = new System.Drawing.Size(123, 25);
            this.lblFormularioProveedor.TabIndex = 0;
            this.lblFormularioProveedor.Text = "Categorias";
            // 
            // btnLimpiarCategoria
            // 
            this.btnLimpiarCategoria.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarCategoria.AnimationSpeed = 0.03F;
            this.btnLimpiarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCategoria.BaseColor = System.Drawing.Color.White;
            this.btnLimpiarCategoria.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarCategoria.BorderSize = 2;
            this.btnLimpiarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCategoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.btnLimpiarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCategoria.Image")));
            this.btnLimpiarCategoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarCategoria.Location = new System.Drawing.Point(145, 92);
            this.btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            this.btnLimpiarCategoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.btnLimpiarCategoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarCategoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarCategoria.OnHoverImage = null;
            this.btnLimpiarCategoria.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarCategoria.Radius = 10;
            this.btnLimpiarCategoria.Size = new System.Drawing.Size(106, 41);
            this.btnLimpiarCategoria.TabIndex = 70;
            this.btnLimpiarCategoria.Text = "Limpiar";
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.btnLimpiarCategoria);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.pnlBusquedaCategoria);
            this.Controls.Add(this.grbListaUsuarios);
            this.Controls.Add(this.pnlDatosCateg);
            this.Name = "frmCategoria";
            this.Text = "Categorias";
            this.pnlDatosCateg.ResumeLayout(false);
            this.pnlDatosCateg.PerformLayout();
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.pnlBusquedaCategoria.ResumeLayout(false);
            this.pnlBusquedaCategoria.PerformLayout();
            this.pnlBuscarCateg.ResumeLayout(false);
            this.pnlBuscarCateg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlDatosCateg;
        private System.Windows.Forms.Label lblCategoriaProd;
        private Guna.UI.WinForms.GunaTextBox txtCategoria;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvCategoria;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaCategoria;
        private System.Windows.Forms.Panel pnlBuscarCateg;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarBuscarCategoria;
        private Guna.UI.WinForms.GunaTileButton btnBuscarCategoria;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCateg;
        private Guna.UI.WinForms.GunaComboBox cmbBuscarCategoria;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCategoria;
        private Guna.UI.WinForms.GunaLabel lblFormularioProveedor;
        private Guna.UI.WinForms.GunaButton btnGuardarCategoria;
        private Guna.UI.WinForms.GunaButton btnLimpiarCategoria;
        private System.Windows.Forms.DataGridViewImageColumn btnEditarDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}