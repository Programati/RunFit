﻿namespace CapaPresentacion
{
    partial class frmListarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBusquedaUser = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnNuevoUser = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiarUser = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarUser = new Guna.UI.WinForms.GunaTileButton();
            this.txtBuscarUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaUser = new Guna.UI.WinForms.GunaDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorUser = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBusquedaUser.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUser)).BeginInit();
            this.pnlContenedorUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBusquedaUser
            // 
            this.pnlBusquedaUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaUser.Controls.Add(this.btnNuevoUser);
            this.pnlBusquedaUser.Controls.Add(this.btnLimpiarUser);
            this.pnlBusquedaUser.Controls.Add(this.btnBuscarUser);
            this.pnlBusquedaUser.Controls.Add(this.txtBuscarUser);
            this.pnlBusquedaUser.Controls.Add(this.lblBuscarPorUser);
            this.pnlBusquedaUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaUser.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaUser.Name = "pnlBusquedaUser";
            this.pnlBusquedaUser.Radius = 5;
            this.pnlBusquedaUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaUser.Size = new System.Drawing.Size(800, 100);
            this.pnlBusquedaUser.TabIndex = 1;
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.AnimationHoverSpeed = 0.07F;
            this.btnNuevoUser.AnimationSpeed = 0.03F;
            this.btnNuevoUser.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoUser.BaseColor = System.Drawing.Color.White;
            this.btnNuevoUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnNuevoUser.BorderSize = 2;
            this.btnNuevoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoUser.FocusedColor = System.Drawing.Color.White;
            this.btnNuevoUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoUser.Image")));
            this.btnNuevoUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevoUser.Location = new System.Drawing.Point(20, 33);
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoUser.OnHoverImage = null;
            this.btnNuevoUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoUser.Radius = 10;
            this.btnNuevoUser.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoUser.TabIndex = 4;
            this.btnNuevoUser.Text = "Nuevo";
            this.btnNuevoUser.Click += new System.EventHandler(this.btnNuevoUser_Click);
            // 
            // btnLimpiarUser
            // 
            this.btnLimpiarUser.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarUser.AnimationSpeed = 0.03F;
            this.btnLimpiarUser.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarUser.BorderSize = 2;
            this.btnLimpiarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarUser.FocusedColor = System.Drawing.Color.White;
            this.btnLimpiarUser.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarUser.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarUser.Image")));
            this.btnLimpiarUser.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarUser.Location = new System.Drawing.Point(425, 35);
            this.btnLimpiarUser.Name = "btnLimpiarUser";
            this.btnLimpiarUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarUser.OnHoverImage = null;
            this.btnLimpiarUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarUser.Radius = 5;
            this.btnLimpiarUser.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarUser.TabIndex = 3;
            this.btnLimpiarUser.Click += new System.EventHandler(this.btnLimpiarUser_Click);
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.AnimationHoverSpeed = 0.07F;
            this.btnBuscarUser.AnimationSpeed = 0.03F;
            this.btnBuscarUser.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarUser.BorderSize = 2;
            this.btnBuscarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarUser.FocusedColor = System.Drawing.Color.White;
            this.btnBuscarUser.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarUser.ForeColor = System.Drawing.Color.White;
            this.btnBuscarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUser.Image")));
            this.btnBuscarUser.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarUser.Location = new System.Drawing.Point(384, 35);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarUser.OnHoverImage = null;
            this.btnBuscarUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarUser.Radius = 5;
            this.btnBuscarUser.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarUser.TabIndex = 2;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
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
            this.txtBuscarUser.Location = new System.Drawing.Point(193, 37);
            this.txtBuscarUser.MaxLength = 8;
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.PasswordChar = '\0';
            this.txtBuscarUser.Radius = 10;
            this.txtBuscarUser.SelectedText = "";
            this.txtBuscarUser.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarUser.TabIndex = 1;
            this.txtBuscarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarUser_KeyPress);
            // 
            // lblBuscarPorUser
            // 
            this.lblBuscarPorUser.AutoSize = true;
            this.lblBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorUser.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorUser.Location = new System.Drawing.Point(136, 42);
            this.lblBuscarPorUser.Name = "lblBuscarPorUser";
            this.lblBuscarPorUser.Size = new System.Drawing.Size(51, 16);
            this.lblBuscarPorUser.TabIndex = 1;
            this.lblBuscarPorUser.Text = "Buscar";
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvListaUser);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(0, 100);
            this.grbListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(800, 311);
            this.grbListaUsuarios.TabIndex = 55;
            this.grbListaUsuarios.Text = "Lista de Usuarios";
            this.grbListaUsuarios.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaUser
            // 
            this.dgvListaUser.AllowUserToAddRows = false;
            this.dgvListaUser.AllowUserToResizeColumns = false;
            this.dgvListaUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaUser.ColumnHeadersHeight = 34;
            this.dgvListaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.IdUsuario,
            this.IdRol,
            this.NombreRol,
            this.Usuario,
            this.Estado});
            this.dgvListaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaUser.EnableHeadersVisualStyles = false;
            this.dgvListaUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaUser.Location = new System.Drawing.Point(2, 30);
            this.dgvListaUser.MultiSelect = false;
            this.dgvListaUser.Name = "dgvListaUser";
            this.dgvListaUser.ReadOnly = true;
            this.dgvListaUser.RowHeadersVisible = false;
            this.dgvListaUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUser.Size = new System.Drawing.Size(796, 279);
            this.dgvListaUser.TabIndex = 5;
            this.dgvListaUser.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvListaUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvListaUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaUser.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvListaUser.ThemeStyle.ReadOnly = true;
            this.dgvListaUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvListaUser.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUser_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 98;
            // 
            // IdUsuario
            // 
            this.IdUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdUsuario.HeaderText = "ID";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Width = 51;
            // 
            // IdRol
            // 
            this.IdRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Width = 74;
            // 
            // NombreRol
            // 
            this.NombreRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NombreRol.HeaderText = "Rol";
            this.NombreRol.Name = "NombreRol";
            this.NombreRol.ReadOnly = true;
            this.NombreRol.Width = 59;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 92;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 86;
            // 
            // pnlContenedorUser
            // 
            this.pnlContenedorUser.AutoScroll = true;
            this.pnlContenedorUser.Controls.Add(this.grbListaUsuarios);
            this.pnlContenedorUser.Controls.Add(this.pnlBusquedaUser);
            this.pnlContenedorUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorUser.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorUser.Name = "pnlContenedorUser";
            this.pnlContenedorUser.Size = new System.Drawing.Size(800, 411);
            this.pnlContenedorUser.TabIndex = 56;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.pnlContenedorUser);
            this.Name = "frmListarUsuario";
            this.Text = "frmListarUsuario";
            this.Load += new System.EventHandler(this.frmListarUsuario_Load);
            this.pnlBusquedaUser.ResumeLayout(false);
            this.pnlBusquedaUser.PerformLayout();
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUser)).EndInit();
            this.pnlContenedorUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaUser;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvListaUser;
        private Guna.UI.WinForms.GunaButton btnNuevoUser;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarUser;
        private Guna.UI.WinForms.GunaTileButton btnBuscarUser;
        private Guna.UI.WinForms.GunaTextBox txtBuscarUser;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private System.Windows.Forms.Panel pnlContenedorUser;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}