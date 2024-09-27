namespace CapaPresentacion
{
    partial class frmListarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProveedor));
            this.pnlContenedorDatosProveedor = new System.Windows.Forms.Panel();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaProveedor = new Guna.UI.WinForms.GunaDataGridView();
            this.Nombre_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_Prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBusquedaProv = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiarPorProveedor = new Guna.UI.WinForms.GunaTileButton();
            this.btnNuevoProveedor = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarPorProveedor = new Guna.UI.WinForms.GunaTileButton();
            this.txtBuscarPorProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarProv = new Guna.UI.WinForms.GunaLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlContenedorDatosProveedor.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).BeginInit();
            this.pnlBusquedaProv.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorDatosProveedor
            // 
            this.pnlContenedorDatosProveedor.AutoScroll = true;
            this.pnlContenedorDatosProveedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedorDatosProveedor.Controls.Add(this.grbListaUsuarios);
            this.pnlContenedorDatosProveedor.Controls.Add(this.pnlBusquedaProv);
            this.pnlContenedorDatosProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDatosProveedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorDatosProveedor.Name = "pnlContenedorDatosProveedor";
            this.pnlContenedorDatosProveedor.Size = new System.Drawing.Size(692, 465);
            this.pnlContenedorDatosProveedor.TabIndex = 54;
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvListaProveedor);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(0, 100);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(692, 365);
            this.grbListaUsuarios.TabIndex = 54;
            this.grbListaUsuarios.Text = "Lista de Proveedores";
            this.grbListaUsuarios.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaProveedor
            // 
            this.dgvListaProveedor.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaProveedor.ColumnHeadersHeight = 34;
            this.dgvListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Prov,
            this.Cuit_Prev,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Descrip_Proveedor,
            this.Editar,
            this.Eliminar});
            this.dgvListaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProveedor.EnableHeadersVisualStyles = false;
            this.dgvListaProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaProveedor.Location = new System.Drawing.Point(2, 30);
            this.dgvListaProveedor.MultiSelect = false;
            this.dgvListaProveedor.Name = "dgvListaProveedor";
            this.dgvListaProveedor.ReadOnly = true;
            this.dgvListaProveedor.RowHeadersVisible = false;
            this.dgvListaProveedor.RowHeadersWidth = 51;
            this.dgvListaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProveedor.Size = new System.Drawing.Size(688, 333);
            this.dgvListaProveedor.TabIndex = 5;
            this.dgvListaProveedor.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvListaProveedor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaProveedor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaProveedor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaProveedor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaProveedor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaProveedor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaProveedor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvListaProveedor.ThemeStyle.ReadOnly = true;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Nombre_Prov
            // 
            this.Nombre_Prov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_Prov.HeaderText = "Razon Social";
            this.Nombre_Prov.MinimumWidth = 6;
            this.Nombre_Prov.Name = "Nombre_Prov";
            this.Nombre_Prov.ReadOnly = true;
            this.Nombre_Prov.Width = 117;
            // 
            // Cuit_Prev
            // 
            this.Cuit_Prev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cuit_Prev.HeaderText = "CUIT";
            this.Cuit_Prev.MinimumWidth = 6;
            this.Cuit_Prev.Name = "Cuit_Prev";
            this.Cuit_Prev.ReadOnly = true;
            this.Cuit_Prev.Width = 62;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Direccion.HeaderText = "Direccioin";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 88;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 70;
            // 
            // Descrip_Proveedor
            // 
            this.Descrip_Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descrip_Proveedor.HeaderText = "Descripcion";
            this.Descrip_Proveedor.MinimumWidth = 6;
            this.Descrip_Proveedor.Name = "Descrip_Proveedor";
            this.Descrip_Proveedor.ReadOnly = true;
            this.Descrip_Proveedor.Width = 111;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 53;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 68;
            // 
            // pnlBusquedaProv
            // 
            this.pnlBusquedaProv.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaProv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaProv.Controls.Add(this.btnCancelar);
            this.pnlBusquedaProv.Controls.Add(this.btnLimpiarPorProveedor);
            this.pnlBusquedaProv.Controls.Add(this.btnNuevoProveedor);
            this.pnlBusquedaProv.Controls.Add(this.btnBuscarPorProveedor);
            this.pnlBusquedaProv.Controls.Add(this.txtBuscarPorProveedor);
            this.pnlBusquedaProv.Controls.Add(this.lblBuscarProv);
            this.pnlBusquedaProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaProv.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaProv.Name = "pnlBusquedaProv";
            this.pnlBusquedaProv.Radius = 5;
            this.pnlBusquedaProv.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaProv.Size = new System.Drawing.Size(692, 100);
            this.pnlBusquedaProv.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.White;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnCancelar.BorderSize = 2;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(17, 34);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(113, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "MENU";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarPorProveedor
            // 
            this.btnLimpiarPorProveedor.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarPorProveedor.AnimationSpeed = 0.03F;
            this.btnLimpiarPorProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarPorProveedor.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarPorProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarPorProveedor.BorderSize = 2;
            this.btnLimpiarPorProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarPorProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarPorProveedor.FocusedColor = System.Drawing.Color.White;
            this.btnLimpiarPorProveedor.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarPorProveedor.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPorProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarPorProveedor.Image")));
            this.btnLimpiarPorProveedor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarPorProveedor.Location = new System.Drawing.Point(423, 35);
            this.btnLimpiarPorProveedor.Name = "btnLimpiarPorProveedor";
            this.btnLimpiarPorProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarPorProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarPorProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarPorProveedor.OnHoverImage = null;
            this.btnLimpiarPorProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarPorProveedor.Radius = 5;
            this.btnLimpiarPorProveedor.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarPorProveedor.TabIndex = 3;
            this.btnLimpiarPorProveedor.Click += new System.EventHandler(this.btnLimpiarPorProveedor_Click_1);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.AnimationHoverSpeed = 0.07F;
            this.btnNuevoProveedor.AnimationSpeed = 0.03F;
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoProveedor.BaseColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnNuevoProveedor.BorderSize = 2;
            this.btnNuevoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoProveedor.FocusedColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProveedor.Image")));
            this.btnNuevoProveedor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuevoProveedor.Location = new System.Drawing.Point(482, 33);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoProveedor.OnHoverImage = null;
            this.btnNuevoProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoProveedor.Radius = 10;
            this.btnNuevoProveedor.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoProveedor.TabIndex = 4;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnBuscarPorProveedor
            // 
            this.btnBuscarPorProveedor.AnimationHoverSpeed = 0.07F;
            this.btnBuscarPorProveedor.AnimationSpeed = 0.03F;
            this.btnBuscarPorProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPorProveedor.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarPorProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarPorProveedor.BorderSize = 2;
            this.btnBuscarPorProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPorProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarPorProveedor.FocusedColor = System.Drawing.Color.White;
            this.btnBuscarPorProveedor.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarPorProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPorProveedor.Image")));
            this.btnBuscarPorProveedor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarPorProveedor.Location = new System.Drawing.Point(382, 35);
            this.btnBuscarPorProveedor.Name = "btnBuscarPorProveedor";
            this.btnBuscarPorProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarPorProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarPorProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarPorProveedor.OnHoverImage = null;
            this.btnBuscarPorProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarPorProveedor.Radius = 5;
            this.btnBuscarPorProveedor.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarPorProveedor.TabIndex = 2;
            this.btnBuscarPorProveedor.Click += new System.EventHandler(this.btnBuscarPorProveedor_Click);
            // 
            // txtBuscarPorProveedor
            // 
            this.txtBuscarPorProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarPorProveedor.BaseColor = System.Drawing.Color.White;
            this.txtBuscarPorProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarPorProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPorProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarPorProveedor.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarPorProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarPorProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPorProveedor.Location = new System.Drawing.Point(193, 37);
            this.txtBuscarPorProveedor.MaxLength = 11;
            this.txtBuscarPorProveedor.Name = "txtBuscarPorProveedor";
            this.txtBuscarPorProveedor.PasswordChar = '\0';
            this.txtBuscarPorProveedor.Radius = 10;
            this.txtBuscarPorProveedor.SelectedText = "";
            this.txtBuscarPorProveedor.Size = new System.Drawing.Size(183, 29);
            this.txtBuscarPorProveedor.TabIndex = 1;
            this.txtBuscarPorProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarPorProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPorProveedor_KeyPress);
            // 
            // lblBuscarProv
            // 
            this.lblBuscarProv.AutoSize = true;
            this.lblBuscarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProv.ForeColor = System.Drawing.Color.White;
            this.lblBuscarProv.Location = new System.Drawing.Point(136, 42);
            this.lblBuscarProv.Name = "lblBuscarProv";
            this.lblBuscarProv.Size = new System.Drawing.Size(51, 16);
            this.lblBuscarProv.TabIndex = 1;
            this.lblBuscarProv.Text = "Buscar";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frmListarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 465);
            this.Controls.Add(this.pnlContenedorDatosProveedor);
            this.Name = "frmListarProveedor";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.frmListarProveedor_Load_1);
            this.pnlContenedorDatosProveedor.ResumeLayout(false);
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).EndInit();
            this.pnlBusquedaProv.ResumeLayout(false);
            this.pnlBusquedaProv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorDatosProveedor;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvListaProveedor;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaProv;
        private Guna.UI.WinForms.GunaButton btnNuevoProveedor;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarPorProveedor;
        private Guna.UI.WinForms.GunaTileButton btnBuscarPorProveedor;
        private Guna.UI.WinForms.GunaLabel lblBuscarProv;
        private Guna.UI.WinForms.GunaTextBox txtBuscarPorProveedor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_Prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Proveedor;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Guna.UI.WinForms.GunaButton btnCancelar;
    }
}