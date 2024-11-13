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
            this.txtNombreProductoVenta = new Guna.UI.WinForms.GunaTextBox();
            this.txtBuscarCodigoVta = new Guna.UI.WinForms.GunaTextBox();
            this.lblBuscarCodigoVta = new Guna.UI.WinForms.GunaLabel();
            this.lblCantidadVta = new Guna.UI.WinForms.GunaLabel();
            this.lblTituloPtosRegVtas = new Guna.UI.WinForms.GunaLabel();
            this.txtCantidadItenVta = new Guna.UI.WinForms.GunaTextBox();
            this.pnlNumVta = new Guna.UI.WinForms.GunaShadowPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarPtoVta = new Guna.UI.WinForms.GunaTileButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMarca = new Guna.UI.WinForms.GunaLabel();
            this.lblCategoria = new Guna.UI.WinForms.GunaLabel();
            this.pbImgProductoVenta = new System.Windows.Forms.PictureBox();
            this.lblStockRegistrarVenta = new Guna.UI.WinForms.GunaLabel();
            this.txtStockRegistrarVenta = new Guna.UI.WinForms.GunaTextBox();
            this.btnAgregaritemVta = new Guna.UI.WinForms.GunaButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFechaVenta = new Guna.UI.WinForms.GunaLabel();
            this.lblNombreYApellidoCliente = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarDniVta = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscarClteVta = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarClteVta = new Guna.UI.WinForms.GunaLabel();
            this.lblNyApRegistrarVenta = new Guna.UI.WinForms.GunaLabel();
            this.dgvDetalleVta = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblTituloSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbDetalleVta = new Guna.UI.WinForms.GunaGroupBox();
            this.lblMontoSubtotalVta = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlFinalVenta = new System.Windows.Forms.Panel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.btnConfirmarVta = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pnlNumVta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProductoVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).BeginInit();
            this.grbDetalleVta.SuspendLayout();
            this.pnlFinalVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProductoVenta
            // 
            this.txtNombreProductoVenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombreProductoVenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreProductoVenta.BackColor = System.Drawing.Color.Transparent;
            this.txtNombreProductoVenta.BaseColor = System.Drawing.Color.White;
            this.txtNombreProductoVenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtNombreProductoVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProductoVenta.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombreProductoVenta.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombreProductoVenta.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreProductoVenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoVenta.Location = new System.Drawing.Point(381, 20);
            this.txtNombreProductoVenta.Name = "txtNombreProductoVenta";
            this.txtNombreProductoVenta.PasswordChar = '\0';
            this.txtNombreProductoVenta.Radius = 10;
            this.txtNombreProductoVenta.SelectedText = "";
            this.txtNombreProductoVenta.Size = new System.Drawing.Size(278, 26);
            this.txtNombreProductoVenta.TabIndex = 76;
            this.txtNombreProductoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreProductoVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProductoVenta_KeyDown);
            this.txtNombreProductoVenta.Leave += new System.EventHandler(this.txtNombreProductoVenta_Leave);
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
            this.txtBuscarCodigoVta.Location = new System.Drawing.Point(97, 20);
            this.txtBuscarCodigoVta.MaxLength = 10;
            this.txtBuscarCodigoVta.Name = "txtBuscarCodigoVta";
            this.txtBuscarCodigoVta.PasswordChar = '\0';
            this.txtBuscarCodigoVta.Radius = 10;
            this.txtBuscarCodigoVta.SelectedText = "";
            this.txtBuscarCodigoVta.Size = new System.Drawing.Size(98, 26);
            this.txtBuscarCodigoVta.TabIndex = 3;
            this.txtBuscarCodigoVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCodigoVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCodigoVta_KeyPress);
            // 
            // lblBuscarCodigoVta
            // 
            this.lblBuscarCodigoVta.AutoSize = true;
            this.lblBuscarCodigoVta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCodigoVta.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCodigoVta.Location = new System.Drawing.Point(6, 24);
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
            this.lblCantidadVta.Location = new System.Drawing.Point(8, 23);
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
            this.lblTituloPtosRegVtas.Location = new System.Drawing.Point(288, 24);
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
            this.txtCantidadItenVta.Location = new System.Drawing.Point(99, 19);
            this.txtCantidadItenVta.MaxLength = 4;
            this.txtCantidadItenVta.Name = "txtCantidadItenVta";
            this.txtCantidadItenVta.PasswordChar = '\0';
            this.txtCantidadItenVta.Radius = 10;
            this.txtCantidadItenVta.SelectedText = "";
            this.txtCantidadItenVta.Size = new System.Drawing.Size(60, 26);
            this.txtCantidadItenVta.TabIndex = 5;
            this.txtCantidadItenVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadItenVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadItenVta_KeyPress);
            // 
            // pnlNumVta
            // 
            this.pnlNumVta.BackColor = System.Drawing.Color.Transparent;
            this.pnlNumVta.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlNumVta.Controls.Add(this.groupBox1);
            this.pnlNumVta.Controls.Add(this.groupBox3);
            this.pnlNumVta.Controls.Add(this.groupBox2);
            this.pnlNumVta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNumVta.Location = new System.Drawing.Point(0, 0);
            this.pnlNumVta.Name = "pnlNumVta";
            this.pnlNumVta.Padding = new System.Windows.Forms.Padding(10);
            this.pnlNumVta.Radius = 5;
            this.pnlNumVta.ShadowColor = System.Drawing.Color.Black;
            this.pnlNumVta.Size = new System.Drawing.Size(849, 275);
            this.pnlNumVta.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtBuscarCodigoVta);
            this.groupBox1.Controls.Add(this.lblTituloPtosRegVtas);
            this.groupBox1.Controls.Add(this.txtBuscarPtoVta);
            this.groupBox1.Controls.Add(this.txtNombreProductoVenta);
            this.groupBox1.Controls.Add(this.lblBuscarCodigoVta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 60);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
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
            this.txtBuscarPtoVta.Location = new System.Drawing.Point(201, 18);
            this.txtBuscarPtoVta.Name = "txtBuscarPtoVta";
            this.txtBuscarPtoVta.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.txtBuscarPtoVta.OnHoverBorderColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.OnHoverForeColor = System.Drawing.Color.White;
            this.txtBuscarPtoVta.OnHoverImage = null;
            this.txtBuscarPtoVta.OnPressedColor = System.Drawing.Color.Black;
            this.txtBuscarPtoVta.Radius = 5;
            this.txtBuscarPtoVta.Size = new System.Drawing.Size(35, 30);
            this.txtBuscarPtoVta.TabIndex = 4;
            this.txtBuscarPtoVta.Click += new System.EventHandler(this.txtBuscarPtoVta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMarca);
            this.groupBox3.Controls.Add(this.lblCategoria);
            this.groupBox3.Controls.Add(this.pbImgProductoVenta);
            this.groupBox3.Controls.Add(this.lblStockRegistrarVenta);
            this.groupBox3.Controls.Add(this.txtStockRegistrarVenta);
            this.groupBox3.Controls.Add(this.btnAgregaritemVta);
            this.groupBox3.Controls.Add(this.lblCantidadVta);
            this.groupBox3.Controls.Add(this.txtCantidadItenVta);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(10, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 128);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Producto";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(198, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(65, 18);
            this.lblMarca.TabIndex = 82;
            this.lblMarca.Text = "MARCA";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(198, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 18);
            this.lblCategoria.TabIndex = 81;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // pbImgProductoVenta
            // 
            this.pbImgProductoVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbImgProductoVenta.Image = global::CapaPresentacion.Properties.Resources.ProductoGenerico;
            this.pbImgProductoVenta.Location = new System.Drawing.Point(691, 16);
            this.pbImgProductoVenta.Name = "pbImgProductoVenta";
            this.pbImgProductoVenta.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pbImgProductoVenta.Size = new System.Drawing.Size(135, 109);
            this.pbImgProductoVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgProductoVenta.TabIndex = 80;
            this.pbImgProductoVenta.TabStop = false;
            // 
            // lblStockRegistrarVenta
            // 
            this.lblStockRegistrarVenta.AutoSize = true;
            this.lblStockRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.lblStockRegistrarVenta.Location = new System.Drawing.Point(8, 51);
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
            this.txtStockRegistrarVenta.Location = new System.Drawing.Point(99, 51);
            this.txtStockRegistrarVenta.MaxLength = 4;
            this.txtStockRegistrarVenta.Name = "txtStockRegistrarVenta";
            this.txtStockRegistrarVenta.PasswordChar = '\0';
            this.txtStockRegistrarVenta.Radius = 10;
            this.txtStockRegistrarVenta.SelectedText = "";
            this.txtStockRegistrarVenta.Size = new System.Drawing.Size(60, 26);
            this.txtStockRegistrarVenta.TabIndex = 78;
            this.txtStockRegistrarVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnAgregaritemVta.Location = new System.Drawing.Point(381, 64);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFechaVenta);
            this.groupBox2.Controls.Add(this.lblNombreYApellidoCliente);
            this.groupBox2.Controls.Add(this.txtBuscarDniVta);
            this.groupBox2.Controls.Add(this.btnBuscarClteVta);
            this.groupBox2.Controls.Add(this.lblBuscarClteVta);
            this.groupBox2.Controls.Add(this.lblNyApRegistrarVenta);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 60);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFechaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.ForeColor = System.Drawing.Color.White;
            this.lblFechaVenta.Location = new System.Drawing.Point(707, 16);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFechaVenta.Size = new System.Drawing.Size(119, 23);
            this.lblFechaVenta.TabIndex = 82;
            this.lblFechaVenta.Text = "01/01/0001";
            // 
            // lblNombreYApellidoCliente
            // 
            this.lblNombreYApellidoCliente.AutoSize = true;
            this.lblNombreYApellidoCliente.BackColor = System.Drawing.Color.White;
            this.lblNombreYApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreYApellidoCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreYApellidoCliente.Location = new System.Drawing.Point(74, 23);
            this.lblNombreYApellidoCliente.Name = "lblNombreYApellidoCliente";
            this.lblNombreYApellidoCliente.Size = new System.Drawing.Size(2, 23);
            this.lblNombreYApellidoCliente.TabIndex = 81;
            this.lblNombreYApellidoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtBuscarDniVta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDniVta_KeyPress);
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
            this.btnBuscarClteVta.Location = new System.Drawing.Point(540, 18);
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
            // lblNyApRegistrarVenta
            // 
            this.lblNyApRegistrarVenta.AutoSize = true;
            this.lblNyApRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyApRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.lblNyApRegistrarVenta.Location = new System.Drawing.Point(6, 24);
            this.lblNyApRegistrarVenta.Name = "lblNyApRegistrarVenta";
            this.lblNyApRegistrarVenta.Size = new System.Drawing.Size(65, 18);
            this.lblNyApRegistrarVenta.TabIndex = 73;
            this.lblNyApRegistrarVenta.Text = "Cliente:";
            // 
            // dgvDetalleVta
            // 
            this.dgvDetalleVta.AllowUserToAddRows = false;
            this.dgvDetalleVta.AllowUserToDeleteRows = false;
            this.dgvDetalleVta.AllowUserToResizeColumns = false;
            this.dgvDetalleVta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.dgvDetalleVta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleVta.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleVta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleVta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVta.ColumnHeadersHeight = 34;
            this.dgvDetalleVta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Talle,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal,
            this.Eliminar});
            this.dgvDetalleVta.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.Location = new System.Drawing.Point(2, 50);
            this.dgvDetalleVta.MultiSelect = false;
            this.dgvDetalleVta.Name = "dgvDetalleVta";
            this.dgvDetalleVta.ReadOnly = true;
            this.dgvDetalleVta.RowHeadersVisible = false;
            this.dgvDetalleVta.RowHeadersWidth = 51;
            this.dgvDetalleVta.RowTemplate.Height = 30;
            this.dgvDetalleVta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVta.Size = new System.Drawing.Size(845, 177);
            this.dgvDetalleVta.TabIndex = 0;
            this.dgvDetalleVta.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVta.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvDetalleVta.ThemeStyle.ReadOnly = true;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvDetalleVta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDetalleVta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleVta_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 111;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 127;
            // 
            // Talle
            // 
            this.Talle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Talle.HeaderText = "Talle";
            this.Talle.Name = "Talle";
            this.Talle.ReadOnly = true;
            this.Talle.Width = 82;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 132;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioUnitario.HeaderText = "Precio Unit.";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 149;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SubTotal.HeaderText = "SUB TOTAL";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 140;
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
            this.Eliminar.Width = 116;
            // 
            // lblTituloSubtotalVta
            // 
            this.lblTituloSubtotalVta.AutoSize = true;
            this.lblTituloSubtotalVta.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTituloSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblTituloSubtotalVta.Location = new System.Drawing.Point(690, 0);
            this.lblTituloSubtotalVta.Name = "lblTituloSubtotalVta";
            this.lblTituloSubtotalVta.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTituloSubtotalVta.Size = new System.Drawing.Size(88, 38);
            this.lblTituloSubtotalVta.TabIndex = 80;
            this.lblTituloSubtotalVta.Text = "TOTAL:";
            this.lblTituloSubtotalVta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbDetalleVta
            // 
            this.grbDetalleVta.BackColor = System.Drawing.Color.Transparent;
            this.grbDetalleVta.BaseColor = System.Drawing.Color.White;
            this.grbDetalleVta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.Controls.Add(this.dgvDetalleVta);
            this.grbDetalleVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDetalleVta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleVta.ForeColor = System.Drawing.Color.White;
            this.grbDetalleVta.LineBottom = 2;
            this.grbDetalleVta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbDetalleVta.LineLeft = 2;
            this.grbDetalleVta.LineRight = 2;
            this.grbDetalleVta.LineTop = 50;
            this.grbDetalleVta.Location = new System.Drawing.Point(0, 275);
            this.grbDetalleVta.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.grbDetalleVta.Name = "grbDetalleVta";
            this.grbDetalleVta.Padding = new System.Windows.Forms.Padding(2, 50, 2, 2);
            this.grbDetalleVta.Size = new System.Drawing.Size(849, 229);
            this.grbDetalleVta.TabIndex = 79;
            this.grbDetalleVta.Text = "Detalle de venta";
            this.grbDetalleVta.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // lblMontoSubtotalVta
            // 
            this.lblMontoSubtotalVta.AutoSize = true;
            this.lblMontoSubtotalVta.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMontoSubtotalVta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSubtotalVta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.lblMontoSubtotalVta.Location = new System.Drawing.Point(778, 0);
            this.lblMontoSubtotalVta.Name = "lblMontoSubtotalVta";
            this.lblMontoSubtotalVta.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblMontoSubtotalVta.Size = new System.Drawing.Size(71, 38);
            this.lblMontoSubtotalVta.TabIndex = 81;
            this.lblMontoSubtotalVta.Text = "$0.00";
            this.lblMontoSubtotalVta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlFinalVenta
            // 
            this.pnlFinalVenta.AutoSize = true;
            this.pnlFinalVenta.Controls.Add(this.lblTituloSubtotalVta);
            this.pnlFinalVenta.Controls.Add(this.btnCancelar);
            this.pnlFinalVenta.Controls.Add(this.btnConfirmarVta);
            this.pnlFinalVenta.Controls.Add(this.lblMontoSubtotalVta);
            this.pnlFinalVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFinalVenta.Location = new System.Drawing.Point(0, 504);
            this.pnlFinalVenta.Name = "pnlFinalVenta";
            this.pnlFinalVenta.Size = new System.Drawing.Size(849, 49);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(675, 24);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 19);
            this.lblPrecio.TabIndex = 77;
            this.lblPrecio.Text = "$00.00";
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(849, 553);
            this.Controls.Add(this.grbDetalleVta);
            this.Controls.Add(this.pnlFinalVenta);
            this.Controls.Add(this.pnlNumVta);
            this.Name = "frmRegistrarVenta";
            this.Text = "Registrar Ventas";
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            this.pnlNumVta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProductoVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVta)).EndInit();
            this.grbDetalleVta.ResumeLayout(false);
            this.pnlFinalVenta.ResumeLayout(false);
            this.pnlFinalVenta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnAgregaritemVta;
        private Guna.UI.WinForms.GunaTextBox txtNombreProductoVenta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarCodigoVta;
        private Guna.UI.WinForms.GunaLabel lblBuscarCodigoVta;
        private Guna.UI.WinForms.GunaLabel lblCantidadVta;
        private Guna.UI.WinForms.GunaLabel lblTituloPtosRegVtas;
        private Guna.UI.WinForms.GunaTileButton txtBuscarPtoVta;
        private Guna.UI.WinForms.GunaTextBox txtCantidadItenVta;
        private Guna.UI.WinForms.GunaShadowPanel pnlNumVta;
        private Guna.UI.WinForms.GunaLabel lblNyApRegistrarVenta;
        private Guna.UI.WinForms.GunaLabel lblBuscarClteVta;
        private Guna.UI.WinForms.GunaTileButton btnBuscarClteVta;
        private Guna.UI.WinForms.GunaTextBox txtBuscarDniVta;
        private Guna.UI.WinForms.GunaDataGridView dgvDetalleVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTituloSubtotalVta;
        private Guna.UI.WinForms.GunaGroupBox grbDetalleVta;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMontoSubtotalVta;
        private Guna.UI.WinForms.GunaButton btnConfirmarVta;
        private System.Windows.Forms.Panel pnlFinalVenta;
        private Guna.UI.WinForms.GunaLabel lblStockRegistrarVenta;
        private Guna.UI.WinForms.GunaTextBox txtStockRegistrarVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbImgProductoVenta;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI.WinForms.GunaLabel lblFechaVenta;
        private Guna.UI.WinForms.GunaLabel lblNombreYApellidoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLabel lblCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Guna.UI.WinForms.GunaLabel lblMarca;
        private System.Windows.Forms.Label lblPrecio;
    }
}