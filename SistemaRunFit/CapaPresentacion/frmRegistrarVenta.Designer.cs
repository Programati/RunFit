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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNumVta = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblNumVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlDetalleVta = new System.Windows.Forms.Panel();
            this.btnAgregaritemVta = new Guna.UI.WinForms.GunaButton();
            this.txtLimpiarBuscarPtoVta = new Guna.UI.WinForms.GunaTileButton();
            this.lblCantidadVta = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarPtoVta = new Guna.UI.WinForms.GunaTileButton();
            this.txtCantidadItenVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblTituloCltesRegVtas = new Guna.UI.WinForms.GunaLabel();
            this.lblMontoSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTituloSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblBuscarClteVta = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarDniVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblTituloPtosRegVtas = new Guna.UI.WinForms.GunaLabel();
            this.btnLimpiarBuscarClteVta = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarCodigoVta = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarCodigoVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarNombrePtoVta = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarNombrePtoVta = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarClteVta = new Guna.UI.WinForms.GunaTileButton();
            this.lblFormularioRegVta = new Guna.UI.WinForms.GunaLabel();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvDetalleVta = new Guna.UI.WinForms.GunaDataGridView();
            this.Nombre_Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit_Prev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConfirmarVta = new Guna.UI.WinForms.GunaButton();
            this.pnlNumVta.SuspendLayout();
            this.pnlDetalleVta.SuspendLayout();
            this.grbDetalleVta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNumVta
            // 
            this.pnlNumVta.BackColor = System.Drawing.Color.Transparent;
            this.pnlNumVta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlNumVta.Controls.Add(this.lblNumVta);
            this.pnlNumVta.Controls.Add(this.pnlDetalleVta);
            this.pnlNumVta.Controls.Add(this.lblFormularioRegVta);
            this.pnlNumVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNumVta.Location = new System.Drawing.Point(0, 0);
            this.pnlNumVta.Name = "pnlNumVta";
            this.pnlNumVta.Radius = 5;
            this.pnlNumVta.ShadowColor = System.Drawing.Color.Black;
            this.pnlNumVta.Size = new System.Drawing.Size(954, 183);
            this.pnlNumVta.TabIndex = 1;
            // 
            // lblNumVta
            // 
            this.lblNumVta.AutoSize = true;
            this.lblNumVta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblNumVta.Location = new System.Drawing.Point(39, 91);
            this.lblNumVta.Name = "lblNumVta";
            this.lblNumVta.Size = new System.Drawing.Size(97, 19);
            this.lblNumVta.TabIndex = 61;
            this.lblNumVta.Text = "Num Venta";
            // 
            // pnlDetalleVta
            // 
            this.pnlDetalleVta.Controls.Add(this.btnAgregaritemVta);
            this.pnlDetalleVta.Controls.Add(this.txtLimpiarBuscarPtoVta);
            this.pnlDetalleVta.Controls.Add(this.lblCantidadVta);
            this.pnlDetalleVta.Controls.Add(this.txtBuscarPtoVta);
            this.pnlDetalleVta.Controls.Add(this.txtCantidadItenVta);
            this.pnlDetalleVta.Controls.Add(this.lblTituloCltesRegVtas);
            this.pnlDetalleVta.Controls.Add(this.lblMontoSubtotalVta);
            this.pnlDetalleVta.Controls.Add(this.lblTituloSubtotalVta);
            this.pnlDetalleVta.Controls.Add(this.lblBuscarClteVta);
            this.pnlDetalleVta.Controls.Add(this.txtBuscarDniVta);
            this.pnlDetalleVta.Controls.Add(this.lblTituloPtosRegVtas);
            this.pnlDetalleVta.Controls.Add(this.btnLimpiarBuscarClteVta);
            this.pnlDetalleVta.Controls.Add(this.lblBuscarCodigoVta);
            this.pnlDetalleVta.Controls.Add(this.txtBuscarCodigoVta);
            this.pnlDetalleVta.Controls.Add(this.lblBuscarNombrePtoVta);
            this.pnlDetalleVta.Controls.Add(this.txtBuscarNombrePtoVta);
            this.pnlDetalleVta.Controls.Add(this.btnBuscarClteVta);
            this.pnlDetalleVta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetalleVta.Location = new System.Drawing.Point(156, 0);
            this.pnlDetalleVta.Name = "pnlDetalleVta";
            this.pnlDetalleVta.Size = new System.Drawing.Size(798, 183);
            this.pnlDetalleVta.TabIndex = 55;
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
            this.btnAgregaritemVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregaritemVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaritemVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnAgregaritemVta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaritemVta.Image")));
            this.btnAgregaritemVta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregaritemVta.Location = new System.Drawing.Point(668, 46);
            this.btnAgregaritemVta.Name = "btnAgregaritemVta";
            this.btnAgregaritemVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnAgregaritemVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregaritemVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregaritemVta.OnHoverImage = null;
            this.btnAgregaritemVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregaritemVta.Radius = 10;
            this.btnAgregaritemVta.Size = new System.Drawing.Size(106, 41);
            this.btnAgregaritemVta.TabIndex = 75;
            this.btnAgregaritemVta.Text = "Agregar";
            // 
            // txtLimpiarBuscarPtoVta
            // 
            this.txtLimpiarBuscarPtoVta.AnimationHoverSpeed = 0.07F;
            this.txtLimpiarBuscarPtoVta.AnimationSpeed = 0.03F;
            this.txtLimpiarBuscarPtoVta.BackColor = System.Drawing.Color.Transparent;
            this.txtLimpiarBuscarPtoVta.BaseColor = System.Drawing.Color.Transparent;
            this.txtLimpiarBuscarPtoVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtLimpiarBuscarPtoVta.BorderSize = 2;
            this.txtLimpiarBuscarPtoVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLimpiarBuscarPtoVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.txtLimpiarBuscarPtoVta.FocusedColor = System.Drawing.Color.Empty;
            this.txtLimpiarBuscarPtoVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.txtLimpiarBuscarPtoVta.ForeColor = System.Drawing.Color.White;
            this.txtLimpiarBuscarPtoVta.Image = ((System.Drawing.Image)(resources.GetObject("txtLimpiarBuscarPtoVta.Image")));
            this.txtLimpiarBuscarPtoVta.ImageSize = new System.Drawing.Size(25, 25);
            this.txtLimpiarBuscarPtoVta.Location = new System.Drawing.Point(150, 135);
            this.txtLimpiarBuscarPtoVta.Name = "txtLimpiarBuscarPtoVta";
            this.txtLimpiarBuscarPtoVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.txtLimpiarBuscarPtoVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtLimpiarBuscarPtoVta.OnHoverForeColor = System.Drawing.Color.White;
            this.txtLimpiarBuscarPtoVta.OnHoverImage = null;
            this.txtLimpiarBuscarPtoVta.OnPressedColor = System.Drawing.Color.Black;
            this.txtLimpiarBuscarPtoVta.Radius = 5;
            this.txtLimpiarBuscarPtoVta.Size = new System.Drawing.Size(35, 30);
            this.txtLimpiarBuscarPtoVta.TabIndex = 74;
            // 
            // lblCantidadVta
            // 
            this.lblCantidadVta.AutoSize = true;
            this.lblCantidadVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVta.ForeColor = System.Drawing.Color.White;
            this.lblCantidadVta.Location = new System.Drawing.Point(345, 137);
            this.lblCantidadVta.Name = "lblCantidadVta";
            this.lblCantidadVta.Size = new System.Drawing.Size(69, 16);
            this.lblCantidadVta.TabIndex = 56;
            this.lblCantidadVta.Text = "Cantidad";
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
            this.txtBuscarPtoVta.FocusedColor = System.Drawing.Color.Empty;
            this.txtBuscarPtoVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.txtBuscarPtoVta.ForeColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.Image = ((System.Drawing.Image)(resources.GetObject("txtBuscarPtoVta.Image")));
            this.txtBuscarPtoVta.ImageSize = new System.Drawing.Size(25, 25);
            this.txtBuscarPtoVta.Location = new System.Drawing.Point(108, 135);
            this.txtBuscarPtoVta.Name = "txtBuscarPtoVta";
            this.txtBuscarPtoVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.txtBuscarPtoVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.OnHoverForeColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.OnHoverImage = null;
            this.txtBuscarPtoVta.OnPressedColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.Radius = 5;
            this.txtBuscarPtoVta.Size = new System.Drawing.Size(35, 30);
            this.txtBuscarPtoVta.TabIndex = 73;
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
            this.txtCantidadItenVta.Location = new System.Drawing.Point(436, 127);
            this.txtCantidadItenVta.Name = "txtCantidadItenVta";
            this.txtCantidadItenVta.PasswordChar = '\0';
            this.txtCantidadItenVta.Radius = 10;
            this.txtCantidadItenVta.SelectedText = "";
            this.txtCantidadItenVta.Size = new System.Drawing.Size(97, 26);
            this.txtCantidadItenVta.TabIndex = 53;
            this.txtCantidadItenVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadItenVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadItenVta_KeyPress);
            // 
            // lblTituloCltesRegVtas
            // 
            this.lblTituloCltesRegVtas.AutoSize = true;
            this.lblTituloCltesRegVtas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCltesRegVtas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCltesRegVtas.Location = new System.Drawing.Point(484, 9);
            this.lblTituloCltesRegVtas.Name = "lblTituloCltesRegVtas";
            this.lblTituloCltesRegVtas.Size = new System.Drawing.Size(72, 21);
            this.lblTituloCltesRegVtas.TabIndex = 70;
            this.lblTituloCltesRegVtas.Text = "Clientes";
            // 
            // lblMontoSubtotalVta
            // 
            this.lblMontoSubtotalVta.AutoSize = true;
            this.lblMontoSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblMontoSubtotalVta.Location = new System.Drawing.Point(675, 135);
            this.lblMontoSubtotalVta.Name = "lblMontoSubtotalVta";
            this.lblMontoSubtotalVta.Size = new System.Drawing.Size(99, 19);
            this.lblMontoSubtotalVta.TabIndex = 61;
            this.lblMontoSubtotalVta.Text = "$$$xxxxxxx";
            // 
            // lblTituloSubtotalVta
            // 
            this.lblTituloSubtotalVta.AutoSize = true;
            this.lblTituloSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblTituloSubtotalVta.Location = new System.Drawing.Point(570, 134);
            this.lblTituloSubtotalVta.Name = "lblTituloSubtotalVta";
            this.lblTituloSubtotalVta.Size = new System.Drawing.Size(86, 19);
            this.lblTituloSubtotalVta.TabIndex = 60;
            this.lblTituloSubtotalVta.Text = "SUBTOTAL:";
            // 
            // lblBuscarClteVta
            // 
            this.lblBuscarClteVta.AutoSize = true;
            this.lblBuscarClteVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClteVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarClteVta.Location = new System.Drawing.Point(345, 42);
            this.lblBuscarClteVta.Name = "lblBuscarClteVta";
            this.lblBuscarClteVta.Size = new System.Drawing.Size(77, 32);
            this.lblBuscarClteVta.TabIndex = 66;
            this.lblBuscarClteVta.Text = "Buscar por\r\n DNI:";
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
            this.txtBuscarDniVta.Location = new System.Drawing.Point(436, 46);
            this.txtBuscarDniVta.Name = "txtBuscarDniVta";
            this.txtBuscarDniVta.PasswordChar = '\0';
            this.txtBuscarDniVta.Radius = 10;
            this.txtBuscarDniVta.SelectedText = "";
            this.txtBuscarDniVta.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarDniVta.TabIndex = 67;
            this.txtBuscarDniVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarDniVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDniVta_KeyPress);
            // 
            // lblTituloPtosRegVtas
            // 
            this.lblTituloPtosRegVtas.AutoSize = true;
            this.lblTituloPtosRegVtas.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPtosRegVtas.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPtosRegVtas.Location = new System.Drawing.Point(104, 9);
            this.lblTituloPtosRegVtas.Name = "lblTituloPtosRegVtas";
            this.lblTituloPtosRegVtas.Size = new System.Drawing.Size(87, 21);
            this.lblTituloPtosRegVtas.TabIndex = 65;
            this.lblTituloPtosRegVtas.Text = "Productos";
            // 
            // btnLimpiarBuscarClteVta
            // 
            this.btnLimpiarBuscarClteVta.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarBuscarClteVta.AnimationSpeed = 0.03F;
            this.btnLimpiarBuscarClteVta.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarClteVta.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarClteVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarBuscarClteVta.BorderSize = 2;
            this.btnLimpiarBuscarClteVta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscarClteVta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarBuscarClteVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscarClteVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarBuscarClteVta.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarClteVta.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarBuscarClteVta.Image")));
            this.btnLimpiarBuscarClteVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarBuscarClteVta.Location = new System.Drawing.Point(494, 78);
            this.btnLimpiarBuscarClteVta.Name = "btnLimpiarBuscarClteVta";
            this.btnLimpiarBuscarClteVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarBuscarClteVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarClteVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarClteVta.OnHoverImage = null;
            this.btnLimpiarBuscarClteVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarClteVta.Radius = 5;
            this.btnLimpiarBuscarClteVta.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarBuscarClteVta.TabIndex = 64;
            // 
            // lblBuscarCodigoVta
            // 
            this.lblBuscarCodigoVta.AutoSize = true;
            this.lblBuscarCodigoVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodigoVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCodigoVta.Location = new System.Drawing.Point(21, 94);
            this.lblBuscarCodigoVta.Name = "lblBuscarCodigoVta";
            this.lblBuscarCodigoVta.Size = new System.Drawing.Size(81, 32);
            this.lblBuscarCodigoVta.TabIndex = 63;
            this.lblBuscarCodigoVta.Text = "Buscar por \r\n  Codigo:";
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
            this.txtBuscarCodigoVta.Location = new System.Drawing.Point(108, 98);
            this.txtBuscarCodigoVta.Name = "txtBuscarCodigoVta";
            this.txtBuscarCodigoVta.PasswordChar = '\0';
            this.txtBuscarCodigoVta.Radius = 10;
            this.txtBuscarCodigoVta.SelectedText = "";
            this.txtBuscarCodigoVta.Size = new System.Drawing.Size(182, 26);
            this.txtBuscarCodigoVta.TabIndex = 62;
            this.txtBuscarCodigoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCodigoVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCodigoVta_KeyPress);
            // 
            // lblBuscarNombrePtoVta
            // 
            this.lblBuscarNombrePtoVta.AutoSize = true;
            this.lblBuscarNombrePtoVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombrePtoVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarNombrePtoVta.Location = new System.Drawing.Point(15, 41);
            this.lblBuscarNombrePtoVta.Name = "lblBuscarNombrePtoVta";
            this.lblBuscarNombrePtoVta.Size = new System.Drawing.Size(77, 32);
            this.lblBuscarNombrePtoVta.TabIndex = 55;
            this.lblBuscarNombrePtoVta.Text = "Buscar por\r\n Nombre:";
            // 
            // txtBuscarNombrePtoVta
            // 
            this.txtBuscarNombrePtoVta.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarNombrePtoVta.BaseColor = System.Drawing.Color.White;
            this.txtBuscarNombrePtoVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarNombrePtoVta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarNombrePtoVta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarNombrePtoVta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarNombrePtoVta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarNombrePtoVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarNombrePtoVta.Location = new System.Drawing.Point(107, 45);
            this.txtBuscarNombrePtoVta.Name = "txtBuscarNombrePtoVta";
            this.txtBuscarNombrePtoVta.PasswordChar = '\0';
            this.txtBuscarNombrePtoVta.Radius = 10;
            this.txtBuscarNombrePtoVta.SelectedText = "";
            this.txtBuscarNombrePtoVta.Size = new System.Drawing.Size(183, 26);
            this.txtBuscarNombrePtoVta.TabIndex = 58;
            this.txtBuscarNombrePtoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarNombrePtoVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNombrePtoVta_KeyPress);
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
            this.btnBuscarClteVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarClteVta.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarClteVta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarClteVta.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClteVta.Image")));
            this.btnBuscarClteVta.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarClteVta.Location = new System.Drawing.Point(452, 78);
            this.btnBuscarClteVta.Name = "btnBuscarClteVta";
            this.btnBuscarClteVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarClteVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarClteVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarClteVta.OnHoverImage = null;
            this.btnBuscarClteVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarClteVta.Radius = 5;
            this.btnBuscarClteVta.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarClteVta.TabIndex = 59;
            // 
            // lblFormularioRegVta
            // 
            this.lblFormularioRegVta.AutoSize = true;
            this.lblFormularioRegVta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioRegVta.ForeColor = System.Drawing.Color.White;
            this.lblFormularioRegVta.Location = new System.Drawing.Point(26, 22);
            this.lblFormularioRegVta.Name = "lblFormularioRegVta";
            this.lblFormularioRegVta.Size = new System.Drawing.Size(124, 50);
            this.lblFormularioRegVta.TabIndex = 0;
            this.lblFormularioRegVta.Text = "Registro de\r\n    Venta";
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.Controls.Add(this.dgvDetalleVta);
            this.grbDetalleVta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleVta.ForeColor = System.Drawing.Color.White;
            this.grbDetalleVta.LineBottom = 2;
            this.grbDetalleVta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.LineLeft = 2;
            this.grbDetalleVta.LineRight = 2;
            this.grbDetalleVta.Location = new System.Drawing.Point(3, 179);
            this.grbDetalleVta.Name = "grbDetalleVta";
            this.grbDetalleVta.Size = new System.Drawing.Size(948, 311);
            this.grbDetalleVta.TabIndex = 55;
            this.grbDetalleVta.Text = "Detalle de venta N°:";
            this.grbDetalleVta.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvDetalleVta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDetalleVta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVta.ColumnHeadersHeight = 18;
            this.dgvDetalleVta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Prov,
            this.Cuit_Prev,
            this.Column1,
            this.Accion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.Location = new System.Drawing.Point(2, 29);
            this.dgvDetalleVta.Name = "dgvDetalleVta";
            this.dgvDetalleVta.RowHeadersVisible = false;
            this.dgvDetalleVta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVta.Size = new System.Drawing.Size(943, 279);
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
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvDetalleVta.ThemeStyle.ReadOnly = false;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Nombre_Prov
            // 
            this.Nombre_Prov.HeaderText = "Codigo";
            this.Nombre_Prov.Name = "Nombre_Prov";
            // 
            // Cuit_Prev
            // 
            this.Cuit_Prev.HeaderText = "Producto";
            this.Cuit_Prev.Name = "Cuit_Prev";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnConfirmarVta.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmarVta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnConfirmarVta.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarVta.Image")));
            this.btnConfirmarVta.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmarVta.Location = new System.Drawing.Point(778, 496);
            this.btnConfirmarVta.Name = "btnConfirmarVta";
            this.btnConfirmarVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnConfirmarVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmarVta.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmarVta.OnHoverImage = null;
            this.btnConfirmarVta.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmarVta.Radius = 10;
            this.btnConfirmarVta.Size = new System.Drawing.Size(142, 40);
            this.btnConfirmarVta.TabIndex = 76;
            this.btnConfirmarVta.Text = "CONFIRMAR";
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 548);
            this.Controls.Add(this.btnConfirmarVta);
            this.Controls.Add(this.grbDetalleVta);
            this.Controls.Add(this.pnlNumVta);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Ventas";
            this.pnlNumVta.ResumeLayout(false);
            this.pnlNumVta.PerformLayout();
            this.pnlDetalleVta.ResumeLayout(false);
            this.pnlDetalleVta.PerformLayout();
            this.grbDetalleVta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel pnlNumVta;
        private System.Windows.Forms.Panel pnlDetalleVta;
        private Guna.UI.WinForms.GunaLabel lblFormularioRegVta;
        private Guna.UI.WinForms.GunaTextBox txtCantidadItenVta;
        private Guna.UI.WinForms.GunaLabel lblCantidadVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarNombrePtoVta;
        private Guna.UI.WinForms.GunaTileButton btnBuscarClteVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarNombrePtoVta;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Guna.UI.WinForms.GunaDataGridView dgvDetalleVta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit_Prev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTituloSubtotalVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMontoSubtotalVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarCodigoVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCodigoVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNumVta;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarBuscarClteVta;
        private Guna.UI.WinForms.GunaLabel lblTituloCltesRegVtas;
        private Guna.UI.WinForms.GunaLabel lblBuscarClteVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarDniVta;
        private Guna.UI.WinForms.GunaLabel lblTituloPtosRegVtas;
        private Guna.UI.WinForms.GunaTileButton txtLimpiarBuscarPtoVta;
        private Guna.UI.WinForms.GunaTileButton txtBuscarPtoVta;
        private Guna.UI.WinForms.GunaButton btnAgregaritemVta;
        private Guna.UI.WinForms.GunaButton btnConfirmarVta;
    }
}