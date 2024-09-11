namespace CapaPresentacion
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContenedorDatosUser = new System.Windows.Forms.Panel();
            this.btnLimpiarCamposUser = new Guna.UI.WinForms.GunaButton();
            this.btnGuardarUser = new Guna.UI.WinForms.GunaButton();
            this.grbListaUsuarios = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaUser = new Guna.UI.WinForms.GunaDataGridView();
            this.pnlEmpleadoName = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblClienteBuscado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlBusquedaUser = new Guna.UI.WinForms.GunaShadowPanel();
            this.pnlBuscarUserDerecha = new System.Windows.Forms.Panel();
            this.btnLimpiarUser = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarUser = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarPorUser = new Guna.UI.WinForms.GunaLabel();
            this.cmbBuscarPorUser = new Guna.UI.WinForms.GunaComboBox();
            this.txtBuscarUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblFormularioUser = new Guna.UI.WinForms.GunaLabel();
            this.pnlDatosUsuarioUser = new Guna.UI.WinForms.GunaShadowPanel();
            this.cmbTipoUsuarioUser = new Guna.UI.WinForms.GunaComboBox();
            this.lblTipoUsuarioUser = new System.Windows.Forms.Label();
            this.lblContrasenaUser = new System.Windows.Forms.Label();
            this.txtPassUser = new Guna.UI.WinForms.GunaTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI.WinForms.GunaTextBox();

            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlContenedorDatosUser.SuspendLayout();
            this.grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUser)).BeginInit();
            this.pnlEmpleadoName.SuspendLayout();
            this.pnlBusquedaUser.SuspendLayout();
            this.pnlBuscarUserDerecha.SuspendLayout();
            this.pnlDatosUsuarioUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorDatosUser
            // 
            this.pnlContenedorDatosUser.AutoScroll = true;
            this.pnlContenedorDatosUser.BackColor = System.Drawing.Color.White;
            this.pnlContenedorDatosUser.Controls.Add(this.btnLimpiarCamposUser);
            this.pnlContenedorDatosUser.Controls.Add(this.btnGuardarUser);
            this.pnlContenedorDatosUser.Controls.Add(this.grbListaUsuarios);
            this.pnlContenedorDatosUser.Controls.Add(this.pnlEmpleadoName);
            this.pnlContenedorDatosUser.Controls.Add(this.pnlBusquedaUser);
            this.pnlContenedorDatosUser.Controls.Add(this.pnlDatosUsuarioUser);
            this.pnlContenedorDatosUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorDatosUser.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorDatosUser.Name = "pnlContenedorDatosUser";
            this.pnlContenedorDatosUser.Size = new System.Drawing.Size(976, 442);
            this.pnlContenedorDatosUser.TabIndex = 52;
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

            this.btnLimpiarCamposUser.Location = new System.Drawing.Point(236, 100);

            this.btnLimpiarCamposUser.Name = "btnLimpiarCamposUser";
            this.btnLimpiarCamposUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.btnLimpiarCamposUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarCamposUser.OnHoverImage = null;
            this.btnLimpiarCamposUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarCamposUser.Radius = 10;
            this.btnLimpiarCamposUser.Size = new System.Drawing.Size(106, 41);
            this.btnLimpiarCamposUser.TabIndex = 68;
            this.btnLimpiarCamposUser.Text = "Limpiar";
            this.btnLimpiarCamposUser.Click += new System.EventHandler(this.btnLimpiarCamposUser_Click);
            // 
            // btnGuardarUser
            // 
            this.btnGuardarUser.AnimationHoverSpeed = 0.07F;
            this.btnGuardarUser.AnimationSpeed = 0.03F;
            this.btnGuardarUser.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarUser.BaseColor = System.Drawing.Color.White;
            this.btnGuardarUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnGuardarUser.BorderSize = 2;
            this.btnGuardarUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardarUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardarUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarUser.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUser.Image")));
            this.btnGuardarUser.ImageSize = new System.Drawing.Size(20, 20);

            this.btnGuardarUser.Location = new System.Drawing.Point(27, 100);
            this.btnGuardarUser.Name = "btnGuardarUser";
            this.btnGuardarUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnGuardarUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardarUser.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardarUser.OnHoverImage = null;
            this.btnGuardarUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardarUser.Radius = 10;
            this.btnGuardarUser.Size = new System.Drawing.Size(106, 41);
            this.btnGuardarUser.TabIndex = 67;
            this.btnGuardarUser.Text = "Guardar";
            this.btnGuardarUser.Click += new System.EventHandler(this.btnGuardarUser_Click);
            // 
            // grbListaUsuarios
            // 
            this.grbListaUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.grbListaUsuarios.BaseColor = System.Drawing.Color.White;
            this.grbListaUsuarios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.Controls.Add(this.dgvListaUser);
            this.grbListaUsuarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbListaUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaUsuarios.ForeColor = System.Drawing.Color.White;
            this.grbListaUsuarios.LineBottom = 2;
            this.grbListaUsuarios.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaUsuarios.LineLeft = 2;
            this.grbListaUsuarios.LineRight = 2;
            this.grbListaUsuarios.Location = new System.Drawing.Point(386, 86);
            this.grbListaUsuarios.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbListaUsuarios.Name = "grbListaUsuarios";
            this.grbListaUsuarios.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaUsuarios.Size = new System.Drawing.Size(590, 356);
            this.grbListaUsuarios.TabIndex = 54;
            this.grbListaUsuarios.Text = "Lista de Usuarios";
            this.grbListaUsuarios.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));

            this.dgvListaUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dgvListaUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaUser.ColumnHeadersHeight = 18;
            this.dgvListaUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,

            this.Rol,
            this.Usuario,
            this.Apellido,
            this.Nombre});
            this.dgvListaUser.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaUser.EnableHeadersVisualStyles = false;
            this.dgvListaUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaUser.Location = new System.Drawing.Point(2, 30);
            this.dgvListaUser.Name = "dgvListaUser";
            this.dgvListaUser.ReadOnly = true;
            this.dgvListaUser.RowHeadersVisible = false;
            this.dgvListaUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUser.Size = new System.Drawing.Size(586, 324);
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
            // pnlEmpleadoName
            // 
            this.pnlEmpleadoName.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmpleadoName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlEmpleadoName.Controls.Add(this.lblClienteBuscado);
            this.pnlEmpleadoName.Location = new System.Drawing.Point(27, 158);
            this.pnlEmpleadoName.Name = "pnlEmpleadoName";
            this.pnlEmpleadoName.Radius = 5;
            this.pnlEmpleadoName.ShadowColor = System.Drawing.Color.Black;
            this.pnlEmpleadoName.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.pnlEmpleadoName.Size = new System.Drawing.Size(315, 73);
            this.pnlEmpleadoName.TabIndex = 53;
            // 
            // lblClienteBuscado
            // 
            this.lblClienteBuscado.AutoSize = true;
            this.lblClienteBuscado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBuscado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblClienteBuscado.Location = new System.Drawing.Point(14, 19);
            this.lblClienteBuscado.Name = "lblClienteBuscado";
            this.lblClienteBuscado.Size = new System.Drawing.Size(190, 19);
            this.lblClienteBuscado.TabIndex = 0;
            this.lblClienteBuscado.Text = "NOMBRE DEL EMPLEADO";
            // 
            // pnlBusquedaUser
            // 
            this.pnlBusquedaUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaUser.Controls.Add(this.pnlBuscarUserDerecha);
            this.pnlBusquedaUser.Controls.Add(this.lblFormularioUser);
            this.pnlBusquedaUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaUser.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaUser.Name = "pnlBusquedaUser";
            this.pnlBusquedaUser.Radius = 5;
            this.pnlBusquedaUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaUser.Size = new System.Drawing.Size(976, 86);
            this.pnlBusquedaUser.TabIndex = 0;
            // 
            // pnlBuscarUserDerecha
            // 
            this.pnlBuscarUserDerecha.Controls.Add(this.btnLimpiarUser);
            this.pnlBuscarUserDerecha.Controls.Add(this.btnBuscarUser);
            this.pnlBuscarUserDerecha.Controls.Add(this.lblBuscarPorUser);
            this.pnlBuscarUserDerecha.Controls.Add(this.cmbBuscarPorUser);
            this.pnlBuscarUserDerecha.Controls.Add(this.txtBuscarUser);
            this.pnlBuscarUserDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBuscarUserDerecha.Location = new System.Drawing.Point(339, 0);
            this.pnlBuscarUserDerecha.Name = "pnlBuscarUserDerecha";
            this.pnlBuscarUserDerecha.Size = new System.Drawing.Size(637, 86);
            this.pnlBuscarUserDerecha.TabIndex = 55;
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
            this.btnLimpiarUser.Location = new System.Drawing.Point(498, 31);
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
            this.btnBuscarUser.Location = new System.Drawing.Point(457, 31);
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
            // lblBuscarPorUser
            // 
            this.lblBuscarPorUser.AutoSize = true;
            this.lblBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorUser.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPorUser.Location = new System.Drawing.Point(7, 38);
            this.lblBuscarPorUser.Name = "lblBuscarPorUser";
            this.lblBuscarPorUser.Size = new System.Drawing.Size(81, 16);
            this.lblBuscarPorUser.TabIndex = 1;
            this.lblBuscarPorUser.Text = "Buscar por:";
            // 
            // cmbBuscarPorUser
            // 
            this.cmbBuscarPorUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbBuscarPorUser.BaseColor = System.Drawing.Color.White;
            this.cmbBuscarPorUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbBuscarPorUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBuscarPorUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuscarPorUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPorUser.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBuscarPorUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarPorUser.ForeColor = System.Drawing.Color.Black;
            this.cmbBuscarPorUser.FormattingEnabled = true;
            this.cmbBuscarPorUser.Items.AddRange(new object[] {
            "N° de Documento",
            "Apellido y Nombre"});
            this.cmbBuscarPorUser.Location = new System.Drawing.Point(92, 34);
            this.cmbBuscarPorUser.Margin = new System.Windows.Forms.Padding(1);
            this.cmbBuscarPorUser.Name = "cmbBuscarPorUser";
            this.cmbBuscarPorUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbBuscarPorUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBuscarPorUser.Radius = 10;
            this.cmbBuscarPorUser.Size = new System.Drawing.Size(169, 24);
            this.cmbBuscarPorUser.TabIndex = 45;
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
            this.txtBuscarUser.Location = new System.Drawing.Point(265, 33);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.PasswordChar = '\0';
            this.txtBuscarUser.Radius = 10;
            this.txtBuscarUser.SelectedText = "";
            this.txtBuscarUser.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarUser.TabIndex = 52;
            this.txtBuscarUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFormularioUser
            // 
            this.lblFormularioUser.AutoSize = true;
            this.lblFormularioUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioUser.ForeColor = System.Drawing.Color.White;
            this.lblFormularioUser.Location = new System.Drawing.Point(12, 29);
            this.lblFormularioUser.Name = "lblFormularioUser";
            this.lblFormularioUser.Size = new System.Drawing.Size(200, 25);
            this.lblFormularioUser.TabIndex = 0;
            this.lblFormularioUser.Text = "Gestionar Usuarios";
            // 
            // pnlDatosUsuarioUser
            // 
            this.pnlDatosUsuarioUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosUsuarioUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlDatosUsuarioUser.Controls.Add(this.cmbTipoUsuarioUser);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblTipoUsuarioUser);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblContrasenaUser);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtPassUser);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuarioUser.Location = new System.Drawing.Point(27, 237);
            this.pnlDatosUsuarioUser.Name = "pnlDatosUsuarioUser";
            this.pnlDatosUsuarioUser.Radius = 5;
            this.pnlDatosUsuarioUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlDatosUsuarioUser.Size = new System.Drawing.Size(315, 193);
            this.pnlDatosUsuarioUser.TabIndex = 49;
            // 
            // cmbTipoUsuarioUser
            // 
            this.cmbTipoUsuarioUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoUsuarioUser.BaseColor = System.Drawing.Color.White;
            this.cmbTipoUsuarioUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.cmbTipoUsuarioUser.BorderSize = 1;
            this.cmbTipoUsuarioUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoUsuarioUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoUsuarioUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuarioUser.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTipoUsuarioUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoUsuarioUser.ForeColor = System.Drawing.Color.Black;
            this.cmbTipoUsuarioUser.FormattingEnabled = true;
            this.cmbTipoUsuarioUser.Items.AddRange(new object[] {
            "Admnistrador",
            "Empleado"});
            this.cmbTipoUsuarioUser.Location = new System.Drawing.Point(102, 144);
            this.cmbTipoUsuarioUser.Margin = new System.Windows.Forms.Padding(1);
            this.cmbTipoUsuarioUser.Name = "cmbTipoUsuarioUser";
            this.cmbTipoUsuarioUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.cmbTipoUsuarioUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbTipoUsuarioUser.Radius = 10;
            this.cmbTipoUsuarioUser.Size = new System.Drawing.Size(183, 24);
            this.cmbTipoUsuarioUser.TabIndex = 44;
            // 
            // lblTipoUsuarioUser
            // 
            this.lblTipoUsuarioUser.AutoSize = true;
            this.lblTipoUsuarioUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuarioUser.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuarioUser.Location = new System.Drawing.Point(14, 148);
            this.lblTipoUsuarioUser.Name = "lblTipoUsuarioUser";
            this.lblTipoUsuarioUser.Size = new System.Drawing.Size(26, 16);
            this.lblTipoUsuarioUser.TabIndex = 42;
            this.lblTipoUsuarioUser.Text = "Rol";
            // 
            // lblContrasenaUser
            // 
            this.lblContrasenaUser.AutoSize = true;
            this.lblContrasenaUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaUser.ForeColor = System.Drawing.Color.White;
            this.lblContrasenaUser.Location = new System.Drawing.Point(14, 89);
            this.lblContrasenaUser.Name = "lblContrasenaUser";
            this.lblContrasenaUser.Size = new System.Drawing.Size(82, 16);
            this.lblContrasenaUser.TabIndex = 41;
            this.lblContrasenaUser.Text = "Contraseña";
            // 
            // txtPassUser
            // 
            this.txtPassUser.BackColor = System.Drawing.Color.Transparent;
            this.txtPassUser.BaseColor = System.Drawing.Color.White;
            this.txtPassUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtPassUser.BorderSize = 1;
            this.txtPassUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassUser.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassUser.Location = new System.Drawing.Point(102, 84);
            this.txtPassUser.Name = "txtPassUser";
            this.txtPassUser.PasswordChar = '●';
            this.txtPassUser.Radius = 10;
            this.txtPassUser.SelectedText = "";
            this.txtPassUser.Size = new System.Drawing.Size(183, 26);
            this.txtPassUser.TabIndex = 40;
            this.txtPassUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(14, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 37;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BaseColor = System.Drawing.Color.White;
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtUsuario.BorderSize = 1;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuario.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(102, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.Radius = 10;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(183, 26);
            this.txtUsuario.TabIndex = 36;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 442);
            this.Controls.Add(this.pnlContenedorDatosUser);
            this.Name = "frmUsuario";
            this.Text = "Gestion de usuarios";
            this.pnlContenedorDatosUser.ResumeLayout(false);
            this.grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUser)).EndInit();
            this.pnlEmpleadoName.ResumeLayout(false);
            this.pnlEmpleadoName.PerformLayout();
            this.pnlBusquedaUser.ResumeLayout(false);
            this.pnlBusquedaUser.PerformLayout();
            this.pnlBuscarUserDerecha.ResumeLayout(false);
            this.pnlBuscarUserDerecha.PerformLayout();
            this.pnlDatosUsuarioUser.ResumeLayout(false);
            this.pnlDatosUsuarioUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTileButton btnBuscarUser;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarUser;
        private Guna.UI.WinForms.GunaTextBox txtBuscarUser;
        private Guna.UI.WinForms.GunaComboBox cmbBuscarPorUser;
        private System.Windows.Forms.Panel pnlBuscarUserDerecha;
        private Guna.UI.WinForms.GunaLabel lblBuscarPorUser;
        private Guna.UI.WinForms.GunaLabel lblFormularioUser;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaUser;
        private System.Windows.Forms.Panel pnlContenedorDatosUser;
        private Guna.UI.WinForms.GunaShadowPanel pnlDatosUsuarioUser;
        private Guna.UI.WinForms.GunaComboBox cmbTipoUsuarioUser;
        private System.Windows.Forms.Label lblTipoUsuarioUser;
        private System.Windows.Forms.Label lblContrasenaUser;
        private Guna.UI.WinForms.GunaTextBox txtPassUser;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI.WinForms.GunaTextBox txtUsuario;
        private Guna.UI.WinForms.GunaShadowPanel pnlEmpleadoName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblClienteBuscado;
        private Guna.UI.WinForms.GunaGroupBox grbListaUsuarios;
        private Guna.UI.WinForms.GunaDataGridView dgvListaUser;
        private Guna.UI.WinForms.GunaButton btnGuardarUser;
        private Guna.UI.WinForms.GunaButton btnLimpiarCamposUser;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}