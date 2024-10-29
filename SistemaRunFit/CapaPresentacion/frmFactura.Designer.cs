namespace CapaPresentacion
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabeceraFactura = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblIdFactura = new System.Windows.Forms.Label();
            this.lblFacturaNum = new System.Windows.Forms.Label();
            this.lblVendedorFactura = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCorreoRunFit = new System.Windows.Forms.Label();
            this.lblTelefonoRunFit = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccionRunfit = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRunFit = new System.Windows.Forms.Label();
            this.pnlDetalleClienteFactura = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblCorreoCliente = new System.Windows.Forms.Label();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblNyApCliente = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnCerrarFactura = new Guna.UI.WinForms.GunaButton();
            this.pnlDetalleFactura = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgvDetalleFacturaFinal = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotalFactura = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalFactura = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlCabeceraFactura.SuspendLayout();
            this.pnlDetalleClienteFactura.SuspendLayout();
            this.pnlDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFacturaFinal)).BeginInit();
            this.pnlTotalFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabeceraFactura
            // 
            this.pnlCabeceraFactura.BackColor = System.Drawing.Color.Transparent;
            this.pnlCabeceraFactura.BorderColor = System.Drawing.Color.DimGray;
            this.pnlCabeceraFactura.BorderThickness = 4;
            this.pnlCabeceraFactura.Controls.Add(this.lblIdFactura);
            this.pnlCabeceraFactura.Controls.Add(this.lblFacturaNum);
            this.pnlCabeceraFactura.Controls.Add(this.lblVendedorFactura);
            this.pnlCabeceraFactura.Controls.Add(this.lblVendedor);
            this.pnlCabeceraFactura.Controls.Add(this.lblCorreoRunFit);
            this.pnlCabeceraFactura.Controls.Add(this.lblTelefonoRunFit);
            this.pnlCabeceraFactura.Controls.Add(this.lblCiudad);
            this.pnlCabeceraFactura.Controls.Add(this.lblDireccionRunfit);
            this.pnlCabeceraFactura.Controls.Add(this.lblFechaFactura);
            this.pnlCabeceraFactura.Controls.Add(this.lblFecha);
            this.pnlCabeceraFactura.Controls.Add(this.lblRunFit);
            this.pnlCabeceraFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCabeceraFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraFactura.Name = "pnlCabeceraFactura";
            this.pnlCabeceraFactura.Size = new System.Drawing.Size(800, 119);
            this.pnlCabeceraFactura.TabIndex = 0;
            // 
            // lblIdFactura
            // 
            this.lblIdFactura.AutoSize = true;
            this.lblIdFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblIdFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFactura.Location = new System.Drawing.Point(625, 18);
            this.lblIdFactura.Name = "lblIdFactura";
            this.lblIdFactura.Size = new System.Drawing.Size(81, 21);
            this.lblIdFactura.TabIndex = 19;
            this.lblIdFactura.Text = "COD-001";
            // 
            // lblFacturaNum
            // 
            this.lblFacturaNum.AutoSize = true;
            this.lblFacturaNum.BackColor = System.Drawing.Color.Transparent;
            this.lblFacturaNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNum.Location = new System.Drawing.Point(526, 19);
            this.lblFacturaNum.Name = "lblFacturaNum";
            this.lblFacturaNum.Size = new System.Drawing.Size(94, 19);
            this.lblFacturaNum.TabIndex = 18;
            this.lblFacturaNum.Text = "Factura N°:";
            // 
            // lblVendedorFactura
            // 
            this.lblVendedorFactura.AutoSize = true;
            this.lblVendedorFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedorFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorFactura.Location = new System.Drawing.Point(625, 50);
            this.lblVendedorFactura.Name = "lblVendedorFactura";
            this.lblVendedorFactura.Size = new System.Drawing.Size(155, 21);
            this.lblVendedorFactura.TabIndex = 17;
            this.lblVendedorFactura.Text = "Nombre Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblVendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(529, 51);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(91, 19);
            this.lblVendedor.TabIndex = 16;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // lblCorreoRunFit
            // 
            this.lblCorreoRunFit.AutoSize = true;
            this.lblCorreoRunFit.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoRunFit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoRunFit.Location = new System.Drawing.Point(331, 82);
            this.lblCorreoRunFit.Name = "lblCorreoRunFit";
            this.lblCorreoRunFit.Size = new System.Drawing.Size(139, 16);
            this.lblCorreoRunFit.TabIndex = 15;
            this.lblCorreoRunFit.Text = "contacto@runfit.com";
            // 
            // lblTelefonoRunFit
            // 
            this.lblTelefonoRunFit.AutoSize = true;
            this.lblTelefonoRunFit.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoRunFit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoRunFit.Location = new System.Drawing.Point(49, 83);
            this.lblTelefonoRunFit.Name = "lblTelefonoRunFit";
            this.lblTelefonoRunFit.Size = new System.Drawing.Size(115, 19);
            this.lblTelefonoRunFit.TabIndex = 14;
            this.lblTelefonoRunFit.Text = "3794-1234569";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(30, 51);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(146, 19);
            this.lblCiudad.TabIndex = 13;
            this.lblCiudad.Text = "Corrientes Capital";
            // 
            // lblDireccionRunfit
            // 
            this.lblDireccionRunfit.AutoSize = true;
            this.lblDireccionRunfit.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccionRunfit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionRunfit.Location = new System.Drawing.Point(43, 19);
            this.lblDireccionRunfit.Name = "lblDireccionRunfit";
            this.lblDireccionRunfit.Size = new System.Drawing.Size(123, 19);
            this.lblDireccionRunfit.TabIndex = 12;
            this.lblDireccionRunfit.Text = "9 de Julio 1234";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.Location = new System.Drawing.Point(625, 82);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(96, 21);
            this.lblFechaFactura.TabIndex = 11;
            this.lblFechaFactura.Text = "01/01/1999";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(558, 83);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 19);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblRunFit
            // 
            this.lblRunFit.AutoSize = true;
            this.lblRunFit.BackColor = System.Drawing.Color.Transparent;
            this.lblRunFit.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunFit.Location = new System.Drawing.Point(320, 0);
            this.lblRunFit.Name = "lblRunFit";
            this.lblRunFit.Size = new System.Drawing.Size(160, 58);
            this.lblRunFit.TabIndex = 10;
            this.lblRunFit.Text = "RunFit";
            // 
            // pnlDetalleClienteFactura
            // 
            this.pnlDetalleClienteFactura.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetalleClienteFactura.BorderColor = System.Drawing.Color.DimGray;
            this.pnlDetalleClienteFactura.BorderThickness = 4;
            this.pnlDetalleClienteFactura.Controls.Add(this.lblCorreoCliente);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblTelefonoCliente);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblDireccionCliente);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblDniCliente);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblNyApCliente);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblCorreo);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblDni);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblTelefono);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblDireccion);
            this.pnlDetalleClienteFactura.Controls.Add(this.lblCliente);
            this.pnlDetalleClienteFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetalleClienteFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDetalleClienteFactura.Location = new System.Drawing.Point(0, 119);
            this.pnlDetalleClienteFactura.Name = "pnlDetalleClienteFactura";
            this.pnlDetalleClienteFactura.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDetalleClienteFactura.Size = new System.Drawing.Size(800, 79);
            this.pnlDetalleClienteFactura.TabIndex = 1;
            // 
            // lblCorreoCliente
            // 
            this.lblCorreoCliente.AutoSize = true;
            this.lblCorreoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCliente.Location = new System.Drawing.Point(561, 48);
            this.lblCorreoCliente.Name = "lblCorreoCliente";
            this.lblCorreoCliente.Size = new System.Drawing.Size(132, 17);
            this.lblCorreoCliente.TabIndex = 9;
            this.lblCorreoCliente.Text = "correo@gmail.com";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.Location = new System.Drawing.Point(309, 48);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(78, 17);
            this.lblTelefonoCliente.TabIndex = 8;
            this.lblTelefonoCliente.Text = "3794001122";
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionCliente.Location = new System.Drawing.Point(434, 17);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(225, 17);
            this.lblDireccionCliente.TabIndex = 7;
            this.lblDireccionCliente.Text = "Junin 1875 Piso 1 Departamento 1";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(68, 48);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(64, 17);
            this.lblDniCliente.TabIndex = 6;
            this.lblDniCliente.Text = "10123456";
            // 
            // lblNyApCliente
            // 
            this.lblNyApCliente.AutoSize = true;
            this.lblNyApCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyApCliente.Location = new System.Drawing.Point(94, 17);
            this.lblNyApCliente.Name = "lblNyApCliente";
            this.lblNyApCliente.Size = new System.Drawing.Size(126, 17);
            this.lblNyApCliente.TabIndex = 5;
            this.lblNyApCliente.Text = "nombre y apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(507, 48);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(50, 16);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "EMAIL:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(27, 48);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(34, 16);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(228, 48);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 16);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "TELEFONO:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(342, 17);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 16);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "DIRECCION:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(27, 17);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // btnCerrarFactura
            // 
            this.btnCerrarFactura.AnimationHoverSpeed = 0.07F;
            this.btnCerrarFactura.AnimationSpeed = 0.03F;
            this.btnCerrarFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarFactura.BaseColor = System.Drawing.Color.White;
            this.btnCerrarFactura.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnCerrarFactura.BorderSize = 2;
            this.btnCerrarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarFactura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrarFactura.FocusedColor = System.Drawing.Color.White;
            this.btnCerrarFactura.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnCerrarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarFactura.Image")));
            this.btnCerrarFactura.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerrarFactura.Location = new System.Drawing.Point(688, 466);
            this.btnCerrarFactura.Name = "btnCerrarFactura";
            this.btnCerrarFactura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnCerrarFactura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrarFactura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrarFactura.OnHoverImage = null;
            this.btnCerrarFactura.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrarFactura.Radius = 10;
            this.btnCerrarFactura.Size = new System.Drawing.Size(100, 41);
            this.btnCerrarFactura.TabIndex = 18;
            this.btnCerrarFactura.Text = "Cerrar";
            this.btnCerrarFactura.Click += new System.EventHandler(this.btnCerrarFactura_Click);
            // 
            // pnlDetalleFactura
            // 
            this.pnlDetalleFactura.BorderColor = System.Drawing.Color.Gray;
            this.pnlDetalleFactura.BorderThickness = 3;
            this.pnlDetalleFactura.Controls.Add(this.dgvDetalleFacturaFinal);
            this.pnlDetalleFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetalleFactura.Location = new System.Drawing.Point(0, 198);
            this.pnlDetalleFactura.Name = "pnlDetalleFactura";
            this.pnlDetalleFactura.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDetalleFactura.Size = new System.Drawing.Size(800, 202);
            this.pnlDetalleFactura.TabIndex = 19;
            // 
            // dgvDetalleFacturaFinal
            // 
            this.dgvDetalleFacturaFinal.AllowUserToAddRows = false;
            this.dgvDetalleFacturaFinal.AllowUserToDeleteRows = false;
            this.dgvDetalleFacturaFinal.AllowUserToResizeColumns = false;
            this.dgvDetalleFacturaFinal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetalleFacturaFinal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleFacturaFinal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleFacturaFinal.ColumnHeadersHeight = 35;
            this.dgvDetalleFacturaFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleFacturaFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion,
            this.PrecioUnitario,
            this.ImporteTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleFacturaFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleFacturaFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleFacturaFinal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetalleFacturaFinal.Location = new System.Drawing.Point(10, 10);
            this.dgvDetalleFacturaFinal.Name = "dgvDetalleFacturaFinal";
            this.dgvDetalleFacturaFinal.RowHeadersVisible = false;
            this.dgvDetalleFacturaFinal.Size = new System.Drawing.Size(780, 182);
            this.dgvDetalleFacturaFinal.TabIndex = 0;
            this.dgvDetalleFacturaFinal.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvDetalleFacturaFinal.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleFacturaFinal.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleFacturaFinal.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleFacturaFinal.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleFacturaFinal.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleFacturaFinal.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleFacturaFinal.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleFacturaFinal.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDetalleFacturaFinal.ThemeStyle.ReadOnly = false;
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetalleFacturaFinal.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 120;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 138;
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImporteTotal.HeaderText = "Importe Total";
            this.ImporteTotal.Name = "ImporteTotal";
            this.ImporteTotal.Width = 126;
            // 
            // pnlTotalFactura
            // 
            this.pnlTotalFactura.BorderColor = System.Drawing.Color.Gray;
            this.pnlTotalFactura.BorderThickness = 3;
            this.pnlTotalFactura.Controls.Add(this.lblTotal);
            this.pnlTotalFactura.Controls.Add(this.lblTotalFactura);
            this.pnlTotalFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTotalFactura.Location = new System.Drawing.Point(0, 400);
            this.pnlTotalFactura.Name = "pnlTotalFactura";
            this.pnlTotalFactura.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTotalFactura.Size = new System.Drawing.Size(800, 47);
            this.pnlTotalFactura.TabIndex = 20;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(621, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 34);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.BackColor = System.Drawing.Color.White;
            this.lblTotalFactura.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalFactura.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFactura.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTotalFactura.Location = new System.Drawing.Point(709, 5);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(86, 34);
            this.lblTotalFactura.TabIndex = 1;
            this.lblTotalFactura.Text = "$00.00";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.pnlTotalFactura);
            this.Controls.Add(this.btnCerrarFactura);
            this.Controls.Add(this.pnlDetalleFactura);
            this.Controls.Add(this.pnlDetalleClienteFactura);
            this.Controls.Add(this.pnlCabeceraFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.pnlCabeceraFactura.ResumeLayout(false);
            this.pnlCabeceraFactura.PerformLayout();
            this.pnlDetalleClienteFactura.ResumeLayout(false);
            this.pnlDetalleClienteFactura.PerformLayout();
            this.pnlDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFacturaFinal)).EndInit();
            this.pnlTotalFactura.ResumeLayout(false);
            this.pnlTotalFactura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlCabeceraFactura;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDetalleClienteFactura;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCorreoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblNyApCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblRunFit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCorreoRunFit;
        private System.Windows.Forms.Label lblTelefonoRunFit;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccionRunfit;
        private System.Windows.Forms.Label lblFechaFactura;
        private Guna.UI.WinForms.GunaButton btnCerrarFactura;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDetalleFactura;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTotalFactura;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalFactura;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleFacturaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotal;
        private System.Windows.Forms.Label lblIdFactura;
        private System.Windows.Forms.Label lblFacturaNum;
        private System.Windows.Forms.Label lblVendedorFactura;
        private System.Windows.Forms.Label lblVendedor;
    }
}