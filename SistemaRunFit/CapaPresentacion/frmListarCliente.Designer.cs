namespace CapaPresentacion
{
    partial class frmListarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarCliente));
            this.grbListaCliente = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.pnlBusquedaCliente = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnLimpiarCliente = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarCliente = new Guna.UI.WinForms.GunaTileButton();
            this.btnNuevoCliente = new Guna.UI.WinForms.GunaButton();
            this.lblBuscarPorCliente = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarCliente = new Guna.UI.WinForms.GunaTextBox();
            this.pnlContenedorCliente = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manzana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.pnlBusquedaCliente.SuspendLayout();
            this.pnlContenedorCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbListaCliente
            // 
            this.grbListaCliente.BackColor = System.Drawing.Color.Transparent;
            this.grbListaCliente.BaseColor = System.Drawing.Color.White;
            this.grbListaCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaCliente.Controls.Add(this.dgvListaClientes);
            this.grbListaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaCliente.ForeColor = System.Drawing.Color.White;
            this.grbListaCliente.LineBottom = 2;
            this.grbListaCliente.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaCliente.LineLeft = 2;
            this.grbListaCliente.LineRight = 2;
            this.grbListaCliente.Location = new System.Drawing.Point(0, 100);
            this.grbListaCliente.Name = "grbListaCliente";
            this.grbListaCliente.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaCliente.Size = new System.Drawing.Size(992, 311);
            this.grbListaCliente.TabIndex = 10;
            this.grbListaCliente.Text = "Lista de Clientes";
            this.grbListaCliente.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaClientes.ColumnHeadersHeight = 34;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.idPersona,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Email,
            this.Telefono,
            this.FechaNacimiento,
            this.Sexo,
            this.idDomicilio,
            this.Calle,
            this.Altura,
            this.Casa,
            this.Manzana,
            this.Departamento,
            this.Piso});
            this.dgvListaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaClientes.EnableHeadersVisualStyles = false;
            this.dgvListaClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaClientes.Location = new System.Drawing.Point(2, 30);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersVisible = false;
            this.dgvListaClientes.RowTemplate.Height = 28;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(988, 279);
            this.dgvListaClientes.TabIndex = 0;
            this.dgvListaClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaClientes.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvListaClientes.ThemeStyle.ReadOnly = true;
            this.dgvListaClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaClientes.ThemeStyle.RowsStyle.Height = 28;
            this.dgvListaClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaClientes_CellContentClick);
            // 
            // pnlBusquedaCliente
            // 
            this.pnlBusquedaCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaCliente.Controls.Add(this.btnLimpiarCliente);
            this.pnlBusquedaCliente.Controls.Add(this.btnBuscarCliente);
            this.pnlBusquedaCliente.Controls.Add(this.btnNuevoCliente);
            this.pnlBusquedaCliente.Controls.Add(this.lblBuscarPorCliente);
            this.pnlBusquedaCliente.Controls.Add(this.txtBuscarCliente);
            this.pnlBusquedaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaCliente.Name = "pnlBusquedaCliente";
            this.pnlBusquedaCliente.Radius = 5;
            this.pnlBusquedaCliente.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaCliente.Size = new System.Drawing.Size(992, 100);
            this.pnlBusquedaCliente.TabIndex = 11;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarCliente.AnimationSpeed = 0.03F;
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCliente.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarCliente.BorderSize = 2;
            this.btnLimpiarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarCliente.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarCliente.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCliente.Image")));
            this.btnLimpiarCliente.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarCliente.Location = new System.Drawing.Point(423, 36);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarCliente.OnHoverImage = null;
            this.btnLimpiarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarCliente.Radius = 5;
            this.btnLimpiarCliente.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarCliente.TabIndex = 56;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.AnimationHoverSpeed = 0.07F;
            this.btnBuscarCliente.AnimationSpeed = 0.03F;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarCliente.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarCliente.BorderSize = 2;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarCliente.Location = new System.Drawing.Point(382, 36);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.OnHoverImage = null;
            this.btnBuscarCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.Radius = 5;
            this.btnBuscarCliente.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarCliente.TabIndex = 55;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.AnimationHoverSpeed = 0.07F;
            this.btnNuevoCliente.AnimationSpeed = 0.03F;
            this.btnNuevoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoCliente.BaseColor = System.Drawing.Color.White;
            this.btnNuevoCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnNuevoCliente.BorderSize = 2;
            this.btnNuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCliente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoCliente.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevoCliente.Location = new System.Drawing.Point(19, 34);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoCliente.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.OnHoverImage = null;
            this.btnNuevoCliente.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoCliente.Radius = 10;
            this.btnNuevoCliente.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoCliente.TabIndex = 69;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // lblBuscarPorCliente
            // 
            this.lblBuscarPorCliente.AutoSize = true;
            this.lblBuscarPorCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCliente.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorCliente.Location = new System.Drawing.Point(136, 43);
            this.lblBuscarPorCliente.Name = "lblBuscarPorCliente";
            this.lblBuscarPorCliente.Size = new System.Drawing.Size(51, 16);
            this.lblBuscarPorCliente.TabIndex = 1;
            this.lblBuscarPorCliente.Text = "Buscar";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarCliente.BaseColor = System.Drawing.Color.White;
            this.txtBuscarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarCliente.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(193, 38);
            this.txtBuscarCliente.MaxLength = 8;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.Radius = 10;
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarCliente.TabIndex = 52;
            this.txtBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // pnlContenedorCliente
            // 
            this.pnlContenedorCliente.Controls.Add(this.grbListaCliente);
            this.pnlContenedorCliente.Controls.Add(this.pnlBusquedaCliente);
            this.pnlContenedorCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorCliente.Name = "pnlContenedorCliente";
            this.pnlContenedorCliente.Size = new System.Drawing.Size(992, 411);
            this.pnlContenedorCliente.TabIndex = 12;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "null";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "null";
            this.Editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 72;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 87;
            // 
            // idPersona
            // 
            this.idPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idPersona.HeaderText = "idPer";
            this.idPersona.Name = "idPersona";
            this.idPersona.ReadOnly = true;
            this.idPersona.Width = 67;
            // 
            // Dni
            // 
            this.Dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 57;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 86;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 90;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 70;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 88;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 152;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 64;
            // 
            // idDomicilio
            // 
            this.idDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDomicilio.HeaderText = "idDom";
            this.idDomicilio.Name = "idDomicilio";
            this.idDomicilio.ReadOnly = true;
            this.idDomicilio.Width = 76;
            // 
            // Calle
            // 
            this.Calle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 69;
            // 
            // Altura
            // 
            this.Altura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Altura.HeaderText = "Altura";
            this.Altura.Name = "Altura";
            this.Altura.ReadOnly = true;
            this.Altura.Width = 74;
            // 
            // Casa
            // 
            this.Casa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Casa.HeaderText = "Casa";
            this.Casa.Name = "Casa";
            this.Casa.ReadOnly = true;
            this.Casa.Width = 68;
            // 
            // Manzana
            // 
            this.Manzana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Manzana.HeaderText = "Manzana";
            this.Manzana.Name = "Manzana";
            this.Manzana.ReadOnly = true;
            this.Manzana.Width = 95;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Departamento.HeaderText = "Depto";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 72;
            // 
            // Piso
            // 
            this.Piso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 59;
            // 
            // frmListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(992, 411);
            this.Controls.Add(this.pnlContenedorCliente);
            this.Name = "frmListarCliente";
            this.Text = "frmListarCliente";
            this.Load += new System.EventHandler(this.frmListarCliente_Load);
            this.grbListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.pnlBusquedaCliente.ResumeLayout(false);
            this.pnlBusquedaCliente.PerformLayout();
            this.pnlContenedorCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox grbListaCliente;
        private Guna.UI.WinForms.GunaDataGridView dgvListaClientes;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaCliente;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarCliente;
        private Guna.UI.WinForms.GunaTileButton btnBuscarCliente;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorCliente;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaButton btnNuevoCliente;
        private System.Windows.Forms.Panel pnlContenedorCliente;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manzana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
    }
}