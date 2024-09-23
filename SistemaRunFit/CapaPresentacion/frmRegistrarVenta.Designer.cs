namespace CapaPresentacion
{
    partial class frmRegistrarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVenta));
            this.lblNumeroVenta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNomPtoRegVtas = new Guna.UI.WinForms.GunaTextBox();
            this.txtBuscarCodigoVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarCodigoVta = new Guna.UI.WinForms.GunaLabel();
            this.lblCantidadVta = new Guna.UI.WinForms.GunaLabel();
            this.lblTituloPtosRegVtas = new Guna.UI.WinForms.GunaLabel();
            this.txtCantidadItenVta = new Guna.UI.WinForms.GunaTextBox();
            this.pnlNumVta = new Guna.UI.WinForms.GunaShadowPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStockRegistrarVenta = new Guna.UI.WinForms.GunaLabel();
            this.txtStockRegistrarVenta = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarDniVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarClteVta = new Guna.UI.WinForms.GunaLabel();
            this.txtNyApeRegVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblNyApRegistrarVenta = new Guna.UI.WinForms.GunaLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVenta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvDetalleVta = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.lblMontoSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlFinalVenta = new System.Windows.Forms.Panel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.btnConfirmarVta = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pbImgProductoVenta = new System.Windows.Forms.PictureBox();
            this.txtBuscarPtoVta = new Guna.UI.WinForms.GunaTileButton();
            this.btnAgregaritemVta = new Guna.UI.WinForms.GunaButton();
            this.btnBuscarClteVta = new Guna.UI.WinForms.GunaTileButton();
            this.pnlNumVta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).BeginInit();
            this.grbDetalleVta.SuspendLayout();
            this.pnlFinalVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProductoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroVenta
            // 
            this.lblNumeroVenta.AutoSize = true;
            this.lblNumeroVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVenta.ForeColor = System.Drawing.Color.White;
            this.lblNumeroVenta.Location = new System.Drawing.Point(35, 24);
            this.lblNumeroVenta.Name = "lblNumeroVenta";
            this.lblNumeroVenta.Size = new System.Drawing.Size(127, 38);
            this.lblNumeroVenta.TabIndex = 61;
            this.lblNumeroVenta.Text = "COMPROBANTE\r\nN° XXXX";
            this.lblNumeroVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomPtoRegVtas
            // 
            this.txtNomPtoRegVtas.BackColor = System.Drawing.Color.Transparent;
            this.txtNomPtoRegVtas.BaseColor = System.Drawing.Color.White;
            this.txtNomPtoRegVtas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtNomPtoRegVtas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomPtoRegVtas.Enabled = false;
            this.txtNomPtoRegVtas.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNomPtoRegVtas.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtNomPtoRegVtas.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNomPtoRegVtas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPtoRegVtas.Location = new System.Drawing.Point(97, 78);
            this.txtNomPtoRegVtas.Name = "txtNomPtoRegVtas";
            this.txtNomPtoRegVtas.PasswordChar = '\0';
            this.txtNomPtoRegVtas.Radius = 10;
            this.txtNomPtoRegVtas.ReadOnly = true;
            this.txtNomPtoRegVtas.SelectedText = "";
            this.txtNomPtoRegVtas.Size = new System.Drawing.Size(278, 26);
            this.txtNomPtoRegVtas.TabIndex = 76;
            this.txtNomPtoRegVtas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBuscarCodigoVta
            // 
            this.txtBuscarCodigoVta.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarCodigoVta.BaseColor = System.Drawing.Color.White;
            this.txtBuscarCodigoVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarCodigoVta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCodigoVta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarCodigoVta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarCodigoVta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarCodigoVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCodigoVta.Location = new System.Drawing.Point(97, 22);
            this.txtBuscarCodigoVta.MaxLength = 4;
            this.txtBuscarCodigoVta.Name = "txtBuscarCodigoVta";
            this.txtBuscarCodigoVta.PasswordChar = '\0';
            this.txtBuscarCodigoVta.Radius = 10;
            this.txtBuscarCodigoVta.SelectedText = "";
            this.txtBuscarCodigoVta.Size = new System.Drawing.Size(98, 26);
            this.txtBuscarCodigoVta.TabIndex = 3;
            this.txtBuscarCodigoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCodigoVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCodigoVta_KeyPress_1);
            // 
            // lblBuscarCodigoVta
            // 
            this.lblBuscarCodigoVta.AutoSize = true;
            this.lblBuscarCodigoVta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodigoVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCodigoVta.Location = new System.Drawing.Point(6, 26);
            this.lblBuscarCodigoVta.Name = "lblBuscarCodigoVta";
            this.lblBuscarCodigoVta.Size = new System.Drawing.Size(74, 18);
            this.lblBuscarCodigoVta.TabIndex = 63;
            this.lblBuscarCodigoVta.Text = "CODIGO";
            // 
            // lblCantidadVta
            // 
            this.lblCantidadVta.AutoSize = true;
            this.lblCantidadVta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVta.ForeColor = System.Drawing.Color.White;
            this.lblCantidadVta.Location = new System.Drawing.Point(6, 54);
            this.lblCantidadVta.Name = "lblCantidadVta";
            this.lblCantidadVta.Size = new System.Drawing.Size(85, 18);
            this.lblCantidadVta.TabIndex = 56;
            this.lblCantidadVta.Text = "CANTIDAD";
            // 
            // lblTituloPtosRegVtas
            // 
            this.lblTituloPtosRegVtas.AutoSize = true;
            this.lblTituloPtosRegVtas.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPtosRegVtas.ForeColor = System.Drawing.Color.White;
            this.lblTituloPtosRegVtas.Location = new System.Drawing.Point(6, 82);
            this.lblTituloPtosRegVtas.Name = "lblTituloPtosRegVtas";
            this.lblTituloPtosRegVtas.Size = new System.Drawing.Size(90, 18);
            this.lblTituloPtosRegVtas.TabIndex = 65;
            this.lblTituloPtosRegVtas.Text = "PRODUCTO";
            // 
            // txtCantidadItenVta
            // 
            this.txtCantidadItenVta.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidadItenVta.BaseColor = System.Drawing.Color.White;
            this.txtCantidadItenVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtCantidadItenVta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadItenVta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCantidadItenVta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtCantidadItenVta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCantidadItenVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadItenVta.Location = new System.Drawing.Point(97, 50);
            this.txtCantidadItenVta.MaxLength = 2;
            this.txtCantidadItenVta.Name = "txtCantidadItenVta";
            this.txtCantidadItenVta.PasswordChar = '\0';
            this.txtCantidadItenVta.Radius = 10;
            this.txtCantidadItenVta.SelectedText = "";
            this.txtCantidadItenVta.Size = new System.Drawing.Size(60, 26);
            this.txtCantidadItenVta.TabIndex = 5;
            this.txtCantidadItenVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadItenVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadItenVta_KeyPress_1);
            // 
            // pnlNumVta
            // 
            this.pnlNumVta.BackColor = System.Drawing.Color.Transparent;
            this.pnlNumVta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlNumVta.Controls.Add(this.groupBox3);
            this.pnlNumVta.Controls.Add(this.groupBox2);
            this.pnlNumVta.Controls.Add(this.groupBox1);
            this.pnlNumVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNumVta.Location = new System.Drawing.Point(0, 0);
            this.pnlNumVta.Name = "pnlNumVta";
            this.pnlNumVta.Padding = new System.Windows.Forms.Padding(10);
            this.pnlNumVta.Radius = 5;
            this.pnlNumVta.ShadowColor = System.Drawing.Color.Black;
            this.pnlNumVta.Size = new System.Drawing.Size(795, 231);
            this.pnlNumVta.TabIndex = 78;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbImgProductoVenta);
            this.groupBox3.Controls.Add(this.txtBuscarPtoVta);
            this.groupBox3.Controls.Add(this.txtBuscarCodigoVta);
            this.groupBox3.Controls.Add(this.lblStockRegistrarVenta);
            this.groupBox3.Controls.Add(this.lblBuscarCodigoVta);
            this.groupBox3.Controls.Add(this.txtStockRegistrarVenta);
            this.groupBox3.Controls.Add(this.btnAgregaritemVta);
            this.groupBox3.Controls.Add(this.lblCantidadVta);
            this.groupBox3.Controls.Add(this.txtNomPtoRegVtas);
            this.groupBox3.Controls.Add(this.txtCantidadItenVta);
            this.groupBox3.Controls.Add(this.lblTituloPtosRegVtas);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(182, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 156);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto";
            // 
            // lblStockRegistrarVenta
            // 
            this.lblStockRegistrarVenta.AutoSize = true;
            this.lblStockRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.lblStockRegistrarVenta.Location = new System.Drawing.Point(35, 114);
            this.lblStockRegistrarVenta.Name = "lblStockRegistrarVenta";
            this.lblStockRegistrarVenta.Size = new System.Drawing.Size(56, 18);
            this.lblStockRegistrarVenta.TabIndex = 79;
            this.lblStockRegistrarVenta.Text = "STOCK";
            // 
            // txtStockRegistrarVenta
            // 
            this.txtStockRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.txtStockRegistrarVenta.BaseColor = System.Drawing.Color.White;
            this.txtStockRegistrarVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtStockRegistrarVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockRegistrarVenta.Enabled = false;
            this.txtStockRegistrarVenta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStockRegistrarVenta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtStockRegistrarVenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStockRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockRegistrarVenta.Location = new System.Drawing.Point(97, 110);
            this.txtStockRegistrarVenta.MaxLength = 2;
            this.txtStockRegistrarVenta.Name = "txtStockRegistrarVenta";
            this.txtStockRegistrarVenta.PasswordChar = '\0';
            this.txtStockRegistrarVenta.Radius = 10;
            this.txtStockRegistrarVenta.SelectedText = "";
            this.txtStockRegistrarVenta.Size = new System.Drawing.Size(60, 26);
            this.txtStockRegistrarVenta.TabIndex = 78;
            this.txtStockRegistrarVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBuscarDniVta);
            this.groupBox2.Controls.Add(this.btnBuscarClteVta);
            this.groupBox2.Controls.Add(this.lblBuscarClteVta);
            this.groupBox2.Controls.Add(this.txtNyApeRegVta);
            this.groupBox2.Controls.Add(this.lblNyApRegistrarVenta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(182, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 55);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtBuscarDniVta
            // 
            this.txtBuscarDniVta.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarDniVta.BaseColor = System.Drawing.Color.White;
            this.txtBuscarDniVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarDniVta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarDniVta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarDniVta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarDniVta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarDniVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarDniVta.Location = new System.Drawing.Point(381, 20);
            this.txtBuscarDniVta.MaxLength = 8;
            this.txtBuscarDniVta.Name = "txtBuscarDniVta";
            this.txtBuscarDniVta.PasswordChar = '\0';
            this.txtBuscarDniVta.Radius = 10;
            this.txtBuscarDniVta.SelectedText = "";
            this.txtBuscarDniVta.Size = new System.Drawing.Size(153, 26);
            this.txtBuscarDniVta.TabIndex = 1;
            this.txtBuscarDniVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarDniVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDniVta_KeyPress_1);
            // 
            // lblBuscarClteVta
            // 
            this.lblBuscarClteVta.AutoSize = true;
            this.lblBuscarClteVta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClteVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarClteVta.Location = new System.Drawing.Point(344, 24);
            this.lblBuscarClteVta.Name = "lblBuscarClteVta";
            this.lblBuscarClteVta.Size = new System.Drawing.Size(34, 18);
            this.lblBuscarClteVta.TabIndex = 66;
            this.lblBuscarClteVta.Text = "DNI";
            // 
            // txtNyApeRegVta
            // 
            this.txtNyApeRegVta.BackColor = System.Drawing.Color.Transparent;
            this.txtNyApeRegVta.BaseColor = System.Drawing.Color.White;
            this.txtNyApeRegVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtNyApeRegVta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNyApeRegVta.Enabled = false;
            this.txtNyApeRegVta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNyApeRegVta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtNyApeRegVta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNyApeRegVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNyApeRegVta.Location = new System.Drawing.Point(73, 20);
            this.txtNyApeRegVta.Name = "txtNyApeRegVta";
            this.txtNyApeRegVta.PasswordChar = '\0';
            this.txtNyApeRegVta.Radius = 10;
            this.txtNyApeRegVta.ReadOnly = true;
            this.txtNyApeRegVta.SelectedText = "";
            this.txtNyApeRegVta.Size = new System.Drawing.Size(265, 26);
            this.txtNyApeRegVta.TabIndex = 72;
            this.txtNyApeRegVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNyApRegistrarVenta
            // 
            this.lblNyApRegistrarVenta.AutoSize = true;
            this.lblNyApRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyApRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.lblNyApRegistrarVenta.Location = new System.Drawing.Point(6, 24);
            this.lblNyApRegistrarVenta.Name = "lblNyApRegistrarVenta";
            this.lblNyApRegistrarVenta.Size = new System.Drawing.Size(61, 18);
            this.lblNyApRegistrarVenta.TabIndex = 73;
            this.lblNyApRegistrarVenta.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumeroVenta);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblFechaVenta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 211);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 27);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.ForeColor = System.Drawing.Color.White;
            this.lblFechaVenta.Location = new System.Drawing.Point(66, 122);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(58, 19);
            this.lblFechaVenta.TabIndex = 77;
            this.lblFechaVenta.Text = "Fecha";
            this.lblFechaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetalleVta
            // 
            this.dgvDetalleVta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dgvDetalleVta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVta.ColumnHeadersHeight = 34;
            this.dgvDetalleVta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Eliminar,
            this.SubTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.Location = new System.Drawing.Point(2, 30);
            this.dgvDetalleVta.MultiSelect = false;
            this.dgvDetalleVta.Name = "dgvDetalleVta";
            this.dgvDetalleVta.ReadOnly = true;
            this.dgvDetalleVta.RowHeadersVisible = false;
            this.dgvDetalleVta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVta.Size = new System.Drawing.Size(791, 235);
            this.dgvDetalleVta.TabIndex = 0;
            this.dgvDetalleVta.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvDetalleVta.ThemeStyle.ReadOnly = true;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 90;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 101;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 106;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubTotal.HeaderText = "SUB TOTAL";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // lblTituloSubtotalVta
            // 
            this.lblTituloSubtotalVta.AutoSize = true;
            this.lblTituloSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblTituloSubtotalVta.Location = new System.Drawing.Point(521, 12);
            this.lblTituloSubtotalVta.Name = "lblTituloSubtotalVta";
            this.lblTituloSubtotalVta.Size = new System.Drawing.Size(88, 28);
            this.lblTituloSubtotalVta.TabIndex = 80;
            this.lblTituloSubtotalVta.Text = "TOTAL:";
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.Controls.Add(this.dgvDetalleVta);
            this.grbDetalleVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDetalleVta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleVta.ForeColor = System.Drawing.Color.White;
            this.grbDetalleVta.LineBottom = 2;
            this.grbDetalleVta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.LineLeft = 2;
            this.grbDetalleVta.LineRight = 2;
            this.grbDetalleVta.Location = new System.Drawing.Point(0, 231);
            this.grbDetalleVta.Name = "grbDetalleVta";
            this.grbDetalleVta.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbDetalleVta.Size = new System.Drawing.Size(795, 267);
            this.grbDetalleVta.TabIndex = 79;
            this.grbDetalleVta.Text = "Detalle de venta N°:";
            this.grbDetalleVta.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblMontoSubtotalVta
            // 
            this.lblMontoSubtotalVta.AutoSize = true;
            this.lblMontoSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblMontoSubtotalVta.Location = new System.Drawing.Point(615, 12);
            this.lblMontoSubtotalVta.Name = "lblMontoSubtotalVta";
            this.lblMontoSubtotalVta.Size = new System.Drawing.Size(142, 28);
            this.lblMontoSubtotalVta.TabIndex = 81;
            this.lblMontoSubtotalVta.Text = "$$$xxxxxxx";
            // 
            // pnlFinalVenta
            // 
            this.pnlFinalVenta.AutoSize = true;
            this.pnlFinalVenta.Controls.Add(this.btnCancelar);
            this.pnlFinalVenta.Controls.Add(this.btnConfirmarVta);
            this.pnlFinalVenta.Controls.Add(this.lblMontoSubtotalVta);
            this.pnlFinalVenta.Controls.Add(this.lblTituloSubtotalVta);
            this.pnlFinalVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFinalVenta.Location = new System.Drawing.Point(0, 504);
            this.pnlFinalVenta.Name = "pnlFinalVenta";
            this.pnlFinalVenta.Size = new System.Drawing.Size(795, 49);
            this.pnlFinalVenta.TabIndex = 84;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.White;
            this.btnCancelar.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderSize = 2;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(191, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(166, 40);
            this.btnCancelar.TabIndex = 82;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnConfirmarVta
            // 
            this.btnConfirmarVta.AnimationHoverSpeed = 0.07F;
            this.btnConfirmarVta.AnimationSpeed = 0.03F;
            this.btnConfirmarVta.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarVta.BaseColor = System.Drawing.Color.White;
            this.btnConfirmarVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnConfirmarVta.BorderSize = 2;
            this.btnConfirmarVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmarVta.FocusedColor = System.Drawing.Color.Red;
            this.btnConfirmarVta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnConfirmarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarVta.Image")));
            this.btnConfirmarVta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmarVta.Location = new System.Drawing.Point(3, 6);
            this.btnConfirmarVta.Name = "btnConfirmarVta";
            this.btnConfirmarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnConfirmarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmarVta.OnHoverImage = null;
            this.btnConfirmarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmarVta.Radius = 10;
            this.btnConfirmarVta.Size = new System.Drawing.Size(166, 40);
            this.btnConfirmarVta.TabIndex = 7;
            this.btnConfirmarVta.Text = "CONFIRMAR";
            this.btnConfirmarVta.Click += new System.EventHandler(this.btnConfirmarVta_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 83;
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
            this.Eliminar.Width = 94;
            // 
            // pbImgProductoVenta
            // 
            this.pbImgProductoVenta.Image = global::CapaPresentacion.Properties.Resources.fotoProducto;
            this.pbImgProductoVenta.Location = new System.Drawing.Point(440, 15);
            this.pbImgProductoVenta.Name = "pbImgProductoVenta";
            this.pbImgProductoVenta.Size = new System.Drawing.Size(135, 135);
            this.pbImgProductoVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgProductoVenta.TabIndex = 80;
            this.pbImgProductoVenta.TabStop = false;
            // 
            // txtBuscarPtoVta
            // 
            this.txtBuscarPtoVta.AnimationHoverSpeed = 0.07F;
            this.txtBuscarPtoVta.AnimationSpeed = 0.03F;
            this.txtBuscarPtoVta.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarPtoVta.BaseColor = System.Drawing.Color.Transparent;
            this.txtBuscarPtoVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarPtoVta.BorderSize = 2;
            this.txtBuscarPtoVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscarPtoVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtBuscarPtoVta.FocusedColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.txtBuscarPtoVta.ForeColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.Image = ((System.Drawing.Image)(resources.GetObject("txtBuscarPtoVta.Image")));
            this.txtBuscarPtoVta.ImageSize = new System.Drawing.Size(25, 25);
            this.txtBuscarPtoVta.Location = new System.Drawing.Point(201, 20);
            this.txtBuscarPtoVta.Name = "txtBuscarPtoVta";
            this.txtBuscarPtoVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.txtBuscarPtoVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.OnHoverForeColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.OnHoverImage = null;
            this.txtBuscarPtoVta.OnPressedColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.Radius = 5;
            this.txtBuscarPtoVta.Size = new System.Drawing.Size(35, 30);
            this.txtBuscarPtoVta.TabIndex = 4;
            // 
            // btnAgregaritemVta
            // 
            this.btnAgregaritemVta.AnimationHoverSpeed = 0.07F;
            this.btnAgregaritemVta.AnimationSpeed = 0.03F;
            this.btnAgregaritemVta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregaritemVta.BaseColor = System.Drawing.Color.White;
            this.btnAgregaritemVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnAgregaritemVta.BorderSize = 2;
            this.btnAgregaritemVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregaritemVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregaritemVta.FocusedColor = System.Drawing.Color.White;
            this.btnAgregaritemVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaritemVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnAgregaritemVta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaritemVta.Image")));
            this.btnAgregaritemVta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregaritemVta.Location = new System.Drawing.Point(280, 106);
            this.btnAgregaritemVta.Name = "btnAgregaritemVta";
            this.btnAgregaritemVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnAgregaritemVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregaritemVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregaritemVta.OnHoverImage = null;
            this.btnAgregaritemVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregaritemVta.Radius = 10;
            this.btnAgregaritemVta.Size = new System.Drawing.Size(95, 41);
            this.btnAgregaritemVta.TabIndex = 6;
            this.btnAgregaritemVta.Text = "Agregar";
            this.btnAgregaritemVta.Click += new System.EventHandler(this.btnAgregaritemVta_Click);
            // 
            // btnBuscarClteVta
            // 
            this.btnBuscarClteVta.AnimationHoverSpeed = 0.07F;
            this.btnBuscarClteVta.AnimationSpeed = 0.03F;
            this.btnBuscarClteVta.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarClteVta.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarClteVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarClteVta.BorderSize = 2;
            this.btnBuscarClteVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClteVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarClteVta.FocusedColor = System.Drawing.Color.White;
            this.btnBuscarClteVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarClteVta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarClteVta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClteVta.Image")));
            this.btnBuscarClteVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarClteVta.Location = new System.Drawing.Point(540, 19);
            this.btnBuscarClteVta.Name = "btnBuscarClteVta";
            this.btnBuscarClteVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarClteVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarClteVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarClteVta.OnHoverImage = null;
            this.btnBuscarClteVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarClteVta.Radius = 5;
            this.btnBuscarClteVta.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarClteVta.TabIndex = 2;
            this.btnBuscarClteVta.Click += new System.EventHandler(this.btnBuscarClteVta_Click);
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(795, 553);
            this.Controls.Add(this.pnlFinalVenta);
            this.Controls.Add(this.grbDetalleVta);
            this.Controls.Add(this.pnlNumVta);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Ventas";
            this.pnlNumVta.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).EndInit();
            this.grbDetalleVta.ResumeLayout(false);
            this.pnlFinalVenta.ResumeLayout(false);
            this.pnlFinalVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProductoVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumeroVenta;
        private Guna.UI.WinForms.GunaButton btnAgregaritemVta;
        private Guna.UI.WinForms.GunaTextBox txtNomPtoRegVtas;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCodigoVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarCodigoVta;
        private Guna.UI.WinForms.GunaLabel lblCantidadVta;
        private Guna.UI.WinForms.GunaLabel lblTituloPtosRegVtas;
        private Guna.UI.WinForms.GunaTileButton txtBuscarPtoVta;
        private Guna.UI.WinForms.GunaTextBox txtCantidadItenVta;
        private Guna.UI.WinForms.GunaShadowPanel pnlNumVta;
        private Guna.UI.WinForms.GunaLabel lblNyApRegistrarVenta;
        private Guna.UI.WinForms.GunaTextBox txtNyApeRegVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarClteVta;
        private Guna.UI.WinForms.GunaTileButton btnBuscarClteVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarDniVta;
        private Guna.UI.WinForms.GunaDataGridView dgvDetalleVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTituloSubtotalVta;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMontoSubtotalVta;
        private Guna.UI.WinForms.GunaButton btnConfirmarVta;
        private System.Windows.Forms.Panel pnlFinalVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaVenta;
        private Guna.UI.WinForms.GunaLabel lblStockRegistrarVenta;
        private Guna.UI.WinForms.GunaTextBox txtStockRegistrarVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImgProductoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}