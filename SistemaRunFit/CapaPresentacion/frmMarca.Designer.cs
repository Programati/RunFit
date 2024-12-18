﻿namespace CapaPresentacion
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
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.btnMenuMarca = new Guna.UI.WinForms.GunaButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.txtMarca = new Guna.UI.WinForms.GunaTextBox();
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.btnGuardarMarca = new Guna.UI.WinForms.GunaButton();
            this.lblBuscarPorCateg = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarMarca = new Guna.UI.WinForms.GunaTextBox();
            this.grbListaMarcas = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvMarca = new Guna.UI.WinForms.GunaDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaCategoria.SuspendLayout();
            this.grbListaMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaCategoria
            // 
            this.pnlBusquedaCategoria.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCategoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCategoria.Controls.Add(this.txtIdMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.btnMenuMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.guna2VSeparator1);
            this.pnlBusquedaCategoria.Controls.Add(this.txtMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.lblNuevaMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.btnGuardarMarca);
            this.pnlBusquedaCategoria.Controls.Add(this.lblBuscarPorCateg);
            this.pnlBusquedaCategoria.Controls.Add(this.txtBuscarMarca);
            this.pnlBusquedaCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaCategoria.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaCategoria.Name = "pnlBusquedaCategoria";
            this.pnlBusquedaCategoria.Radius = 5;
            this.pnlBusquedaCategoria.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaCategoria.Size = new System.Drawing.Size(957, 100);
            this.pnlBusquedaCategoria.TabIndex = 57;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(491, 56);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txtIdMarca.TabIndex = 87;
            this.txtIdMarca.Visible = false;
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
            this.btnMenuMarca.Location = new System.Drawing.Point(15, 48);
            this.btnMenuMarca.Name = "btnMenuMarca";
            this.btnMenuMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnMenuMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuMarca.OnHoverImage = null;
            this.btnMenuMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuMarca.Radius = 10;
            this.btnMenuMarca.Size = new System.Drawing.Size(113, 37);
            this.btnMenuMarca.TabIndex = 86;
            this.btnMenuMarca.Text = "MENU";
            this.btnMenuMarca.Click += new System.EventHandler(this.btnMenuMarca_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(394, 7);
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
            this.txtMarca.Location = new System.Drawing.Point(143, 13);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.Radius = 10;
            this.txtMarca.SelectedText = "";
            this.txtMarca.Size = new System.Drawing.Size(228, 26);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMarca.ForeColor = System.Drawing.Color.White;
            this.lblNuevaMarca.Location = new System.Drawing.Point(12, 18);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(96, 16);
            this.lblNuevaMarca.TabIndex = 37;
            this.lblNuevaMarca.Text = "Nueva Marca";
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
            this.btnGuardarMarca.Location = new System.Drawing.Point(258, 48);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarMarca.OnHoverImage = null;
            this.btnGuardarMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarMarca.Radius = 10;
            this.btnGuardarMarca.Size = new System.Drawing.Size(113, 37);
            this.btnGuardarMarca.TabIndex = 66;
            this.btnGuardarMarca.Text = "Guardar";
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // lblBuscarPorCateg
            // 
            this.lblBuscarPorCateg.AutoSize = true;
            this.lblBuscarPorCateg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCateg.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorCateg.Location = new System.Drawing.Point(457, 18);
            this.lblBuscarPorCateg.Name = "lblBuscarPorCateg";
            this.lblBuscarPorCateg.Size = new System.Drawing.Size(124, 16);
            this.lblBuscarPorCateg.TabIndex = 1;
            this.lblBuscarPorCateg.Text = "Buscar por marca";
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
            this.txtBuscarMarca.Location = new System.Drawing.Point(589, 13);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.PasswordChar = '\0';
            this.txtBuscarMarca.Radius = 10;
            this.txtBuscarMarca.SelectedText = "";
            this.txtBuscarMarca.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarMarca.TabIndex = 52;
            this.txtBuscarMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMarca_KeyPress);
            // 
            // grbListaMarcas
            // 
            this.grbListaMarcas.BackColor = System.Drawing.Color.Transparent;
            this.grbListaMarcas.BaseColor = System.Drawing.Color.White;
            this.grbListaMarcas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaMarcas.Controls.Add(this.dgvMarca);
            this.grbListaMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaMarcas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaMarcas.ForeColor = System.Drawing.Color.White;
            this.grbListaMarcas.LineBottom = 2;
            this.grbListaMarcas.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaMarcas.LineLeft = 2;
            this.grbListaMarcas.LineRight = 2;
            this.grbListaMarcas.LineTop = 50;
            this.grbListaMarcas.Location = new System.Drawing.Point(0, 100);
            this.grbListaMarcas.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbListaMarcas.Name = "grbListaMarcas";
            this.grbListaMarcas.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbListaMarcas.Size = new System.Drawing.Size(957, 350);
            this.grbListaMarcas.TabIndex = 58;
            this.grbListaMarcas.Text = "Lista de Marcas";
            this.grbListaMarcas.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.AllowUserToResizeColumns = false;
            this.dgvMarca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarca.ColumnHeadersHeight = 34;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.ID_marca,
            this.Estado,
            this.nombre_marca});
            this.dgvMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarca.EnableHeadersVisualStyles = false;
            this.dgvMarca.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvMarca.Location = new System.Drawing.Point(2, 50);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.RowTemplate.Height = 35;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(953, 298);
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
            this.dgvMarca.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMarca.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMarca.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMarca.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvMarca.ThemeStyle.ReadOnly = true;
            this.dgvMarca.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvMarca.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarca.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMarca.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvMarca.ThemeStyle.RowsStyle.Height = 35;
            this.dgvMarca.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvMarca.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMarca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarca_CellContentClick);
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
            this.Editar.Width = 79;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Accion";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 73;
            // 
            // ID_marca
            // 
            this.ID_marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_marca.FillWeight = 33.23971F;
            this.ID_marca.HeaderText = "ID";
            this.ID_marca.Name = "ID_marca";
            this.ID_marca.ReadOnly = true;
            this.ID_marca.Visible = false;
            this.ID_marca.Width = 51;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 86;
            // 
            // nombre_marca
            // 
            this.nombre_marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_marca.FillWeight = 228.6892F;
            this.nombre_marca.HeaderText = "Marca";
            this.nombre_marca.Name = "nombre_marca";
            this.nombre_marca.ReadOnly = true;
            this.nombre_marca.Width = 87;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
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
        private System.Windows.Forms.Label lblNuevaMarca;
        private Guna.UI.WinForms.GunaButton btnGuardarMarca;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCateg;
        private Guna.UI.WinForms.GunaTextBox txtBuscarMarca;
        private Guna.UI.WinForms.GunaGroupBox grbListaMarcas;
        private Guna.UI.WinForms.GunaDataGridView dgvMarca;
        private Guna.UI.WinForms.GunaButton btnMenuMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_marca;
    }
}