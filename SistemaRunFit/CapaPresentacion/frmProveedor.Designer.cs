namespace CapaPresentacion
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorDatosProveedor = new System.Windows.Forms.Panel();
            this.btnLimpiarCamposUser = new Guna.UI.WinForms.GunaButton();
            this.btnGuardarProveedor = new Guna.UI.WinForms.GunaButton();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaProveedor = new Guna.UI.WinForms.GunaDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cuit_Prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBusquedaProv = new Guna.UI.WinForms.GunaShadowPanel();
            this.pnlBuscarProveedor = new System.Windows.Forms.Panel();
            this.btnLimpiarPorProveedor = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarPorProveedor = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarProv = new Guna.UI.WinForms.GunaLabel();
            this.cmbBuscarPorProveedor = new Guna.UI.WinForms.GunaComboBox();
            this.txtBuscarPorProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.lblFormularioProveedor = new Guna.UI.WinForms.GunaLabel();
            this.pnlDatosUsuarioUser = new Guna.UI.WinForms.GunaShadowPanel();
            this.txtDescripcionProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.lblDescripProv = new System.Windows.Forms.Label();
            this.lblCuitProv = new System.Windows.Forms.Label();
            this.txtCuitProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.lblNombreProv = new System.Windows.Forms.Label();
            this.txtProveedor = new Guna.UI.WinForms.GunaTextBox();
            this.pnlContenedorDatosProveedor.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).BeginInit();
            this.pnlBusquedaProv.SuspendLayout();
            this.pnlBuscarProveedor.SuspendLayout();
            this.pnlDatosUsuarioUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorDatosProveedor
            // 
            this.pnlContenedorDatosProveedor.AutoScroll = true;
            this.pnlContenedorDatosProveedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedorDatosProveedor.Controls.Add(this.btnLimpiarCamposUser);
            this.pnlContenedorDatosProveedor.Controls.Add(this.btnGuardarProveedor);
            this.pnlContenedorDatosProveedor.Controls.Add(this.grbListaUsuarios);
            this.pnlContenedorDatosProveedor.Controls.Add(this.pnlBusquedaProv);
            this.pnlContenedorDatosProveedor.Controls.Add(this.pnlDatosUsuarioUser);
            this.pnlContenedorDatosProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDatosProveedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorDatosProveedor.Name = "pnlContenedorDatosProveedor";
            this.pnlContenedorDatosProveedor.Size = new System.Drawing.Size(929, 438);
            this.pnlContenedorDatosProveedor.TabIndex = 53;
            // 
            // btnLimpiarCamposUser
            // 
            this.btnLimpiarCamposUser.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarCamposUser.AnimationSpeed = 0.03F;
            this.btnLimpiarCamposUser.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCamposUser.BaseColor = System.Drawing.Color.White;
            this.btnLimpiarCamposUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarCamposUser.BorderSize = 2;
            this.btnLimpiarCamposUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCamposUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarCamposUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarCamposUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCamposUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.btnLimpiarCamposUser.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCamposUser.Image")));
            this.btnLimpiarCamposUser.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarCamposUser.Location = new System.Drawing.Point(212, 100);
            this.btnLimpiarCamposUser.Name = "btnLimpiarCamposUser";
            this.btnLimpiarCamposUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.btnLimpiarCamposUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarCamposUser.OnHoverImage = null;
            this.btnLimpiarCamposUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposUser.Radius = 10;
            this.btnLimpiarCamposUser.Size = new System.Drawing.Size(106, 41);
            this.btnLimpiarCamposUser.TabIndex = 69;
            this.btnLimpiarCamposUser.Text = "Limpiar";
            this.btnLimpiarCamposUser.Click += new System.EventHandler(this.btnLimpiarCamposUser_Click);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.AnimationHoverSpeed = 0.07F;
            this.btnGuardarProveedor.AnimationSpeed = 0.03F;
            this.btnGuardarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarProveedor.BaseColor = System.Drawing.Color.White;
            this.btnGuardarProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnGuardarProveedor.BorderSize = 2;
            this.btnGuardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProveedor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProveedor.Image")));
            this.btnGuardarProveedor.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardarProveedor.Location = new System.Drawing.Point(3, 100);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarProveedor.OnHoverImage = null;
            this.btnGuardarProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarProveedor.Radius = 10;
            this.btnGuardarProveedor.Size = new System.Drawing.Size(106, 41);
            this.btnGuardarProveedor.TabIndex = 68;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click);
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvListaProveedor);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(339, 86);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(590, 352);
            this.grbListaUsuarios.TabIndex = 54;
            this.grbListaUsuarios.Text = "Lista de Proveedores";
            this.grbListaUsuarios.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaProveedor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProveedor.ColumnHeadersHeight = 18;
            this.dgvListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Cuit_Prev,
            this.Nombre_Prov,
            this.Descrip_Proveedor});
            this.dgvListaProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProveedor.EnableHeadersVisualStyles = false;
            this.dgvListaProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaProveedor.Location = new System.Drawing.Point(2, 30);
            this.dgvListaProveedor.Name = "dgvListaProveedor";
            this.dgvListaProveedor.ReadOnly = true;
            this.dgvListaProveedor.RowHeadersVisible = false;
            this.dgvListaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProveedor.Size = new System.Drawing.Size(586, 320);
            this.dgvListaProveedor.TabIndex = 0;
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
            this.dgvListaProveedor.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvListaProveedor.ThemeStyle.ReadOnly = true;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaProveedor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaProveedor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 49;
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
            // Cuit_Prev
            // 
            this.Cuit_Prev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cuit_Prev.HeaderText = "CUIT";
            this.Cuit_Prev.Name = "Cuit_Prev";
            this.Cuit_Prev.ReadOnly = true;
            this.Cuit_Prev.Width = 58;
            // 
            // Nombre_Prov
            // 
            this.Nombre_Prov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre_Prov.HeaderText = "Nombre";
            this.Nombre_Prov.Name = "Nombre_Prov";
            this.Nombre_Prov.ReadOnly = true;
            this.Nombre_Prov.Width = 82;
            // 
            // Descrip_Proveedor
            // 
            this.Descrip_Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descrip_Proveedor.HeaderText = "Descripcion";
            this.Descrip_Proveedor.Name = "Descrip_Proveedor";
            this.Descrip_Proveedor.ReadOnly = true;
            this.Descrip_Proveedor.Width = 107;
            // 
            // pnlBusquedaProv
            // 
            this.pnlBusquedaProv.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaProv.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaProv.Controls.Add(this.pnlBuscarProveedor);
            this.pnlBusquedaProv.Controls.Add(this.lblFormularioProveedor);
            this.pnlBusquedaProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaProv.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaProv.Name = "pnlBusquedaProv";
            this.pnlBusquedaProv.Radius = 5;
            this.pnlBusquedaProv.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaProv.Size = new System.Drawing.Size(929, 86);
            this.pnlBusquedaProv.TabIndex = 0;
            // 
            // pnlBuscarProveedor
            // 
            this.pnlBuscarProveedor.Controls.Add(this.btnLimpiarPorProveedor);
            this.pnlBuscarProveedor.Controls.Add(this.btnBuscarPorProveedor);
            this.pnlBuscarProveedor.Controls.Add(this.lblBuscarProv);
            this.pnlBuscarProveedor.Controls.Add(this.cmbBuscarPorProveedor);
            this.pnlBuscarProveedor.Controls.Add(this.txtBuscarPorProveedor);
            this.pnlBuscarProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBuscarProveedor.Location = new System.Drawing.Point(364, 0);
            this.pnlBuscarProveedor.Name = "pnlBuscarProveedor";
            this.pnlBuscarProveedor.Size = new System.Drawing.Size(565, 86);
            this.pnlBuscarProveedor.TabIndex = 55;
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
            this.btnLimpiarPorProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarPorProveedor.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarPorProveedor.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarPorProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarPorProveedor.Image")));
            this.btnLimpiarPorProveedor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarPorProveedor.Location = new System.Drawing.Point(498, 31);
            this.btnLimpiarPorProveedor.Name = "btnLimpiarPorProveedor";
            this.btnLimpiarPorProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarPorProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarPorProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarPorProveedor.OnHoverImage = null;
            this.btnLimpiarPorProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarPorProveedor.Radius = 5;
            this.btnLimpiarPorProveedor.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarPorProveedor.TabIndex = 56;
            this.btnLimpiarPorProveedor.Click += new System.EventHandler(this.btnLimpiarPorProveedor_Click);
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
            this.btnBuscarPorProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarPorProveedor.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarPorProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPorProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarPorProveedor.Image")));
            this.btnBuscarPorProveedor.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarPorProveedor.Location = new System.Drawing.Point(457, 31);
            this.btnBuscarPorProveedor.Name = "btnBuscarPorProveedor";
            this.btnBuscarPorProveedor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarPorProveedor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarPorProveedor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarPorProveedor.OnHoverImage = null;
            this.btnBuscarPorProveedor.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarPorProveedor.Radius = 5;
            this.btnBuscarPorProveedor.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarPorProveedor.TabIndex = 55;
            // 
            // lblBuscarProv
            // 
            this.lblBuscarProv.AutoSize = true;
            this.lblBuscarProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProv.ForeColor = System.Drawing.Color.White;
            this.lblBuscarProv.Location = new System.Drawing.Point(7, 38);
            this.lblBuscarProv.Name = "lblBuscarProv";
            this.lblBuscarProv.Size = new System.Drawing.Size(81, 16);
            this.lblBuscarProv.TabIndex = 1;
            this.lblBuscarProv.Text = "Buscar por:";
            // 
            // cmbBuscarPorProveedor
            // 
            this.cmbBuscarPorProveedor.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarPorProveedor.BaseColor = System.Drawing.Color.White;
            this.cmbBuscarPorProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbBuscarPorProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBuscarPorProveedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarPorProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPorProveedor.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarPorProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorProveedor.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarPorProveedor.FormattingEnabled = true;
            this.cmbBuscarPorProveedor.Items.AddRange(new object[] {
            "CUIT",
            "Nombre"});
            this.cmbBuscarPorProveedor.Location = new System.Drawing.Point(92, 34);
            this.cmbBuscarPorProveedor.Margin = new System.Windows.Forms.Padding(1);
            this.cmbBuscarPorProveedor.Name = "cmbBuscarPorProveedor";
            this.cmbBuscarPorProveedor.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbBuscarPorProveedor.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorProveedor.Radius = 10;
            this.cmbBuscarPorProveedor.Size = new System.Drawing.Size(169, 24);
            this.cmbBuscarPorProveedor.TabIndex = 45;
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
            this.txtBuscarPorProveedor.Location = new System.Drawing.Point(265, 33);
            this.txtBuscarPorProveedor.Name = "txtBuscarPorProveedor";
            this.txtBuscarPorProveedor.PasswordChar = '\0';
            this.txtBuscarPorProveedor.Radius = 10;
            this.txtBuscarPorProveedor.SelectedText = "";
            this.txtBuscarPorProveedor.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarPorProveedor.TabIndex = 52;
            this.txtBuscarPorProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormularioProveedor
            // 
            this.lblFormularioProveedor.AutoSize = true;
            this.lblFormularioProveedor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioProveedor.ForeColor = System.Drawing.Color.White;
            this.lblFormularioProveedor.Location = new System.Drawing.Point(12, 29);
            this.lblFormularioProveedor.Name = "lblFormularioProveedor";
            this.lblFormularioProveedor.Size = new System.Drawing.Size(242, 25);
            this.lblFormularioProveedor.TabIndex = 0;
            this.lblFormularioProveedor.Text = "Gestionar Proveedores";
            // 
            // pnlDatosUsuarioUser
            // 
            this.pnlDatosUsuarioUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosUsuarioUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlDatosUsuarioUser.Controls.Add(this.txtDescripcionProveedor);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblDescripProv);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblCuitProv);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtCuitProveedor);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblNombreProv);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtProveedor);
            this.pnlDatosUsuarioUser.Location = new System.Drawing.Point(3, 157);
            this.pnlDatosUsuarioUser.Name = "pnlDatosUsuarioUser";
            this.pnlDatosUsuarioUser.Radius = 5;
            this.pnlDatosUsuarioUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlDatosUsuarioUser.Size = new System.Drawing.Size(315, 269);
            this.pnlDatosUsuarioUser.TabIndex = 49;
            // 
            // txtDescripcionProveedor
            // 
            this.txtDescripcionProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcionProveedor.BaseColor = System.Drawing.Color.White;
            this.txtDescripcionProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtDescripcionProveedor.BorderSize = 1;
            this.txtDescripcionProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcionProveedor.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtDescripcionProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcionProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProveedor.Location = new System.Drawing.Point(108, 137);
            this.txtDescripcionProveedor.Name = "txtDescripcionProveedor";
            this.txtDescripcionProveedor.PasswordChar = '\0';
            this.txtDescripcionProveedor.Radius = 10;
            this.txtDescripcionProveedor.SelectedText = "";
            this.txtDescripcionProveedor.Size = new System.Drawing.Size(183, 114);
            this.txtDescripcionProveedor.TabIndex = 43;
            // 
            // lblDescripProv
            // 
            this.lblDescripProv.AutoSize = true;
            this.lblDescripProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripProv.ForeColor = System.Drawing.Color.White;
            this.lblDescripProv.Location = new System.Drawing.Point(20, 137);
            this.lblDescripProv.Name = "lblDescripProv";
            this.lblDescripProv.Size = new System.Drawing.Size(82, 16);
            this.lblDescripProv.TabIndex = 42;
            this.lblDescripProv.Text = "Descripcion";
            // 
            // lblCuitProv
            // 
            this.lblCuitProv.AutoSize = true;
            this.lblCuitProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuitProv.ForeColor = System.Drawing.Color.White;
            this.lblCuitProv.Location = new System.Drawing.Point(20, 83);
            this.lblCuitProv.Name = "lblCuitProv";
            this.lblCuitProv.Size = new System.Drawing.Size(34, 16);
            this.lblCuitProv.TabIndex = 41;
            this.lblCuitProv.Text = "CUIT";
            // 
            // txtCuitProveedor
            // 
            this.txtCuitProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtCuitProveedor.BaseColor = System.Drawing.Color.White;
            this.txtCuitProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtCuitProveedor.BorderSize = 1;
            this.txtCuitProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCuitProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCuitProveedor.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtCuitProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCuitProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuitProveedor.Location = new System.Drawing.Point(108, 78);
            this.txtCuitProveedor.MaxLength = 12;
            this.txtCuitProveedor.Name = "txtCuitProveedor";
            this.txtCuitProveedor.PasswordChar = '\0';
            this.txtCuitProveedor.Radius = 10;
            this.txtCuitProveedor.SelectedText = "";
            this.txtCuitProveedor.Size = new System.Drawing.Size(183, 26);
            this.txtCuitProveedor.TabIndex = 40;
            this.txtCuitProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreProv
            // 
            this.lblNombreProv.AutoSize = true;
            this.lblNombreProv.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProv.ForeColor = System.Drawing.Color.White;
            this.lblNombreProv.Location = new System.Drawing.Point(20, 34);
            this.lblNombreProv.Name = "lblNombreProv";
            this.lblNombreProv.Size = new System.Drawing.Size(59, 16);
            this.lblNombreProv.TabIndex = 37;
            this.lblNombreProv.Text = "Nombre";
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.Transparent;
            this.txtProveedor.BaseColor = System.Drawing.Color.White;
            this.txtProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtProveedor.BorderSize = 1;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProveedor.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtProveedor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(108, 29);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.Radius = 10;
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.Size = new System.Drawing.Size(183, 26);
            this.txtProveedor.TabIndex = 36;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 438);
            this.Controls.Add(this.pnlContenedorDatosProveedor);
            this.Name = "frmProveedor";
            this.Text = "Proveedores";
            this.pnlContenedorDatosProveedor.ResumeLayout(false);
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedor)).EndInit();
            this.pnlBusquedaProv.ResumeLayout(false);
            this.pnlBusquedaProv.PerformLayout();
            this.pnlBuscarProveedor.ResumeLayout(false);
            this.pnlBuscarProveedor.PerformLayout();
            this.pnlDatosUsuarioUser.ResumeLayout(false);
            this.pnlDatosUsuarioUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorDatosProveedor;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvListaProveedor;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaProv;
        private System.Windows.Forms.Panel pnlBuscarProveedor;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarPorProveedor;
        private Guna.UI.WinForms.GunaTileButton btnBuscarPorProveedor;
        private Guna.UI.WinForms.GunaLabel lblBuscarProv;
        private Guna.UI.WinForms.GunaComboBox cmbBuscarPorProveedor;
        private Guna.UI.WinForms.GunaTextBox txtBuscarPorProveedor;
        private Guna.UI.WinForms.GunaLabel lblFormularioProveedor;
        private Guna.UI.WinForms.GunaShadowPanel pnlDatosUsuarioUser;
        private System.Windows.Forms.Label lblDescripProv;
        private System.Windows.Forms.Label lblCuitProv;
        private Guna.UI.WinForms.GunaTextBox txtCuitProveedor;
        private System.Windows.Forms.Label lblNombreProv;
        private Guna.UI.WinForms.GunaTextBox txtProveedor;
        private Guna.UI.WinForms.GunaTextBox txtDescripcionProveedor;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_Prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip_Proveedor;
        private Guna.UI.WinForms.GunaButton btnGuardarProveedor;
        private Guna.UI.WinForms.GunaButton btnLimpiarCamposUser;
    }
}