﻿namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.lblCategoriaProd = new System.Windows.Forms.Label();
            this.txtCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.grbListaCategorias = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvCategoria = new Guna.UI.WinForms.GunaDataGridView();
            this.pnlBusquedaCategoria = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.btnMenuMarca = new Guna.UI.WinForms.GunaButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnGuardarCategoria = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarCategoria = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarPorCateg = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarCategoria = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbListaCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.pnlBusquedaCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoriaProd
            // 
            this.lblCategoriaProd.AutoSize = true;
            this.lblCategoriaProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaProd.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaProd.Location = new System.Drawing.Point(12, 18);
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
            this.txtCategoria.Location = new System.Drawing.Point(95, 13);
            this.txtCategoria.MaxLength = 30;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.Radius = 10;
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(228, 26);
            this.txtCategoria.TabIndex = 3;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // grbListaCategorias
            // 
            this.grbListaCategorias.BackColor = System.Drawing.Color.Transparent;
            this.grbListaCategorias.BaseColor = System.Drawing.Color.White;
            this.grbListaCategorias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaCategorias.Controls.Add(this.dgvCategoria);
            this.grbListaCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaCategorias.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaCategorias.ForeColor = System.Drawing.Color.White;
            this.grbListaCategorias.LineBottom = 2;
            this.grbListaCategorias.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaCategorias.LineLeft = 2;
            this.grbListaCategorias.LineRight = 2;
            this.grbListaCategorias.LineTop = 50;
            this.grbListaCategorias.Location = new System.Drawing.Point(0, 100);
            this.grbListaCategorias.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbListaCategorias.Name = "grbListaCategorias";
            this.grbListaCategorias.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbListaCategorias.Size = new System.Drawing.Size(907, 234);
            this.grbListaCategorias.TabIndex = 55;
            this.grbListaCategorias.Text = "Lista de Categorias";
            this.grbListaCategorias.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeColumns = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoria.ColumnHeadersHeight = 34;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.ID_categoria,
            this.Estado,
            this.Categoria});
            this.dgvCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoria.EnableHeadersVisualStyles = false;
            this.dgvCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvCategoria.Location = new System.Drawing.Point(2, 50);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowTemplate.Height = 35;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(903, 182);
            this.dgvCategoria.TabIndex = 5;
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
            this.dgvCategoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCategoria.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvCategoria.ThemeStyle.ReadOnly = true;
            this.dgvCategoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvCategoria.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvCategoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
            // 
            // pnlBusquedaCategoria
            // 
            this.pnlBusquedaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCategoria.Controls.Add(this.txtIdCategoria);
            this.pnlBusquedaCategoria.Controls.Add(this.btnMenuMarca);
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
            this.pnlBusquedaCategoria.Size = new System.Drawing.Size(907, 100);
            this.pnlBusquedaCategoria.TabIndex = 56;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(406, 61);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtIdCategoria.TabIndex = 88;
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
            this.btnMenuMarca.Location = new System.Drawing.Point(26, 48);
            this.btnMenuMarca.Name = "btnMenuMarca";
            this.btnMenuMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnMenuMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuMarca.OnHoverImage = null;
            this.btnMenuMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuMarca.Radius = 10;
            this.btnMenuMarca.Size = new System.Drawing.Size(113, 37);
            this.btnMenuMarca.TabIndex = 87;
            this.btnMenuMarca.Text = "MENU";
            this.btnMenuMarca.Click += new System.EventHandler(this.btnMenuMarca_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(339, 10);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(22, 83);
            this.guna2VSeparator1.TabIndex = 67;
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
            this.btnGuardarCategoria.FocusedColor = System.Drawing.Color.White;
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
            this.btnGuardarCategoria.TabIndex = 4;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
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
            this.btnBuscarCategoria.FocusedColor = System.Drawing.Color.White;
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
            this.btnBuscarCategoria.TabIndex = 2;
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
            this.txtBuscarCategoria.MaxLength = 30;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.Radius = 10;
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarCategoria.TabIndex = 1;
            this.txtBuscarCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCategoria_KeyPress);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 38.07107F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.FillWeight = 38.07107F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 104;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 111;
            // 
            // ID_categoria
            // 
            this.ID_categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_categoria.FillWeight = 33.23971F;
            this.ID_categoria.HeaderText = "ID_categoria";
            this.ID_categoria.Name = "ID_categoria";
            this.ID_categoria.ReadOnly = true;
            this.ID_categoria.Visible = false;
            this.ID_categoria.Width = 189;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 116;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.FillWeight = 228.6892F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 157;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(907, 334);
            this.Controls.Add(this.grbListaCategorias);
            this.Controls.Add(this.pnlBusquedaCategoria);
            this.Name = "frmCategoria";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategoria_Load_1);
            this.grbListaCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.pnlBusquedaCategoria.ResumeLayout(false);
            this.pnlBusquedaCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCategoriaProd;
        private Guna.UI.WinForms.GunaTextBox txtCategoria;
        private Guna.UI.WinForms.GunaGroupBox grbListaCategorias;
        private Guna.UI.WinForms.GunaDataGridView dgvCategoria;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaCategoria;
        private Guna.UI.WinForms.GunaTileButton btnBuscarCategoria;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCateg;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCategoria;
        private Guna.UI.WinForms.GunaButton btnGuardarCategoria;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI.WinForms.GunaButton btnMenuMarca;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}