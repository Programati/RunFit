namespace CapaPresentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedorUser = new System.Windows.Forms.Panel();
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
            this.btnNuevoUser.FocusedColor = System.Drawing.Color.Empty;
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
            this.btnNuevoUser.TabIndex = 70;
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
            this.btnLimpiarUser.FocusedColor = System.Drawing.Color.Empty;
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
            this.btnLimpiarUser.TabIndex = 56;
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
            this.btnBuscarUser.FocusedColor = System.Drawing.Color.Empty;
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
            this.btnBuscarUser.TabIndex = 55;
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
            this.txtBuscarUser.TabIndex = 52;
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
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaUser.ColumnHeadersHeight = 18;
            this.dgvListaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Rol,
            this.Usuario,
            this.Apellido,
            this.Nombre});
            this.dgvListaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaUser.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaUser.EnableHeadersVisualStyles = false;
            this.dgvListaUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaUser.Location = new System.Drawing.Point(2, 30);
            this.dgvListaUser.Name = "dgvListaUser";
            this.dgvListaUser.ReadOnly = true;
            this.dgvListaUser.RowHeadersVisible = false;
            this.dgvListaUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUser.Size = new System.Drawing.Size(796, 279);
            this.dgvListaUser.TabIndex = 0;
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
            this.dgvListaUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaUser.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvListaUser.ThemeStyle.ReadOnly = true;
            this.dgvListaUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaUser.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.Editar.Width = 68;
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
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 78;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 86;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 82;
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
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.pnlContenedorUser);
            this.Name = "frmListarUsuario";
            this.Text = "frmListarUsuario";
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
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private Guna.UI.WinForms.GunaButton btnNuevoUser;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarUser;
        private Guna.UI.WinForms.GunaTileButton btnBuscarUser;
        private Guna.UI.WinForms.GunaTextBox txtBuscarUser;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private System.Windows.Forms.Panel pnlContenedorUser;
    }
}