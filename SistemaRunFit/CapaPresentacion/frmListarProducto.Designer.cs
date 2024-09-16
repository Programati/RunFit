namespace CapaPresentacion
{
    partial class frmListarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProducto));
            this.pnlContenedorProducto = new System.Windows.Forms.Panel();
            this.grbListaProducto = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaProducto = new Guna.UI.WinForms.GunaDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenProducto = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlBusquedaProducto = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnNuevoProducto = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiarBuscarProducto = new Guna.UI.WinForms.GunaTileButton();
            this.btnBuscarProducto = new Guna.UI.WinForms.GunaTileButton();
            this.lblBuscarProducto = new Guna.UI.WinForms.GunaLabel();
            this.txtBuscarProducto = new Guna.UI.WinForms.GunaTextBox();
            this.pnlContenedorProducto.SuspendLayout();
            this.grbListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            this.pnlBusquedaProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorProducto
            // 
            this.pnlContenedorProducto.Controls.Add(this.grbListaProducto);
            this.pnlContenedorProducto.Controls.Add(this.pnlBusquedaProducto);
            this.pnlContenedorProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorProducto.Name = "pnlContenedorProducto";
            this.pnlContenedorProducto.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedorProducto.TabIndex = 0;
            // 
            // grbListaProducto
            // 
            this.grbListaProducto.BackColor = System.Drawing.Color.Transparent;
            this.grbListaProducto.BaseColor = System.Drawing.Color.White;
            this.grbListaProducto.BorderColor = System.Drawing.Color.Black;
            this.grbListaProducto.Controls.Add(this.dgvListaProducto);
            this.grbListaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListaProducto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbListaProducto.ForeColor = System.Drawing.Color.White;
            this.grbListaProducto.LineBottom = 2;
            this.grbListaProducto.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.grbListaProducto.LineLeft = 2;
            this.grbListaProducto.LineRight = 2;
            this.grbListaProducto.Location = new System.Drawing.Point(0, 100);
            this.grbListaProducto.Name = "grbListaProducto";
            this.grbListaProducto.Padding = new System.Windows.Forms.Padding(2, 30, 2, 2);
            this.grbListaProducto.Size = new System.Drawing.Size(800, 350);
            this.grbListaProducto.TabIndex = 60;
            this.grbListaProducto.Text = "Lista de Productos";
            this.grbListaProducto.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProducto.ColumnHeadersHeight = 34;
            this.dgvListaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.ID,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Stock,
            this.StockMinimo,
            this.Marca,
            this.Categoria,
            this.Proveedor,
            this.ImagenProducto});
            this.dgvListaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaProducto.EnableHeadersVisualStyles = false;
            this.dgvListaProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaProducto.Location = new System.Drawing.Point(2, 30);
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.ReadOnly = true;
            this.dgvListaProducto.RowHeadersVisible = false;
            this.dgvListaProducto.RowHeadersWidth = 51;
            this.dgvListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProducto.Size = new System.Drawing.Size(796, 318);
            this.dgvListaProducto.TabIndex = 0;
            this.dgvListaProducto.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.dgvListaProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvListaProducto.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaProducto.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaProducto.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvListaProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvListaProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaProducto.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaProducto.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvListaProducto.ThemeStyle.ReadOnly = true;
            this.dgvListaProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvListaProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaProducto.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaProducto.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvListaProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.Editar.MinimumWidth = 6;
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
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 87;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 47;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 91;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 131;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 6;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 116;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 69;
            // 
            // StockMinimo
            // 
            this.StockMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StockMinimo.HeaderText = "Stock Mínimo";
            this.StockMinimo.MinimumWidth = 6;
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.ReadOnly = true;
            this.StockMinimo.Width = 120;
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 77;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.MinimumWidth = 6;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 99;
            // 
            // ImagenProducto
            // 
            this.ImagenProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ImagenProducto.HeaderText = "Imagen";
            this.ImagenProducto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImagenProducto.MinimumWidth = 6;
            this.ImagenProducto.Name = "ImagenProducto";
            this.ImagenProducto.ReadOnly = true;
            this.ImagenProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImagenProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImagenProducto.Width = 84;
            // 
            // pnlBusquedaProducto
            // 
            this.pnlBusquedaProducto.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaProducto.Controls.Add(this.btnNuevoProducto);
            this.pnlBusquedaProducto.Controls.Add(this.btnLimpiarBuscarProducto);
            this.pnlBusquedaProducto.Controls.Add(this.btnBuscarProducto);
            this.pnlBusquedaProducto.Controls.Add(this.lblBuscarProducto);
            this.pnlBusquedaProducto.Controls.Add(this.txtBuscarProducto);
            this.pnlBusquedaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaProducto.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaProducto.Name = "pnlBusquedaProducto";
            this.pnlBusquedaProducto.Radius = 5;
            this.pnlBusquedaProducto.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaProducto.Size = new System.Drawing.Size(800, 100);
            this.pnlBusquedaProducto.TabIndex = 58;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.AnimationHoverSpeed = 0.07F;
            this.btnNuevoProducto.AnimationSpeed = 0.03F;
            this.btnNuevoProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoProducto.BaseColor = System.Drawing.Color.White;
            this.btnNuevoProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnNuevoProducto.BorderSize = 2;
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevoProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevoProducto.Location = new System.Drawing.Point(20, 33);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnNuevoProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.OnHoverImage = null;
            this.btnNuevoProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevoProducto.Radius = 10;
            this.btnNuevoProducto.Size = new System.Drawing.Size(100, 34);
            this.btnNuevoProducto.TabIndex = 71;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnLimpiarBuscarProducto
            // 
            this.btnLimpiarBuscarProducto.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarBuscarProducto.AnimationSpeed = 0.03F;
            this.btnLimpiarBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarProducto.BaseColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnLimpiarBuscarProducto.BorderSize = 2;
            this.btnLimpiarBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarBuscarProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnLimpiarBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarBuscarProducto.Image")));
            this.btnLimpiarBuscarProducto.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLimpiarBuscarProducto.Location = new System.Drawing.Point(427, 35);
            this.btnLimpiarBuscarProducto.Name = "btnLimpiarBuscarProducto";
            this.btnLimpiarBuscarProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(57)))), ((int)(((byte)(32)))));
            this.btnLimpiarBuscarProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscarProducto.OnHoverImage = null;
            this.btnLimpiarBuscarProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscarProducto.Radius = 5;
            this.btnLimpiarBuscarProducto.Size = new System.Drawing.Size(35, 30);
            this.btnLimpiarBuscarProducto.TabIndex = 56;
            this.btnLimpiarBuscarProducto.Click += new System.EventHandler(this.btnLimpiarBuscarProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.AnimationHoverSpeed = 0.07F;
            this.btnBuscarProducto.AnimationSpeed = 0.03F;
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.BaseColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnBuscarProducto.BorderSize = 2;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscarProducto.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBuscarProducto.Location = new System.Drawing.Point(386, 35);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnBuscarProducto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.OnHoverImage = null;
            this.btnBuscarProducto.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Radius = 5;
            this.btnBuscarProducto.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarProducto.TabIndex = 55;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.lblBuscarProducto.Location = new System.Drawing.Point(136, 42);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(55, 16);
            this.lblBuscarProducto.TabIndex = 1;
            this.lblBuscarProducto.Text = "Codigo";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarProducto.BaseColor = System.Drawing.Color.White;
            this.txtBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProducto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarProducto.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtBuscarProducto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(197, 37);
            this.txtBuscarProducto.MaxLength = 4;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.Radius = 10;
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(183, 29);
            this.txtBuscarProducto.TabIndex = 52;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // frmListarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedorProducto);
            this.Name = "frmListarProducto";
            this.Text = "frmListarProducto";
            this.pnlContenedorProducto.ResumeLayout(false);
            this.grbListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            this.pnlBusquedaProducto.ResumeLayout(false);
            this.pnlBusquedaProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorProducto;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaProducto;
        private Guna.UI.WinForms.GunaTileButton btnLimpiarBuscarProducto;
        private Guna.UI.WinForms.GunaTileButton btnBuscarProducto;
        private Guna.UI.WinForms.GunaTextBox txtBuscarProducto;
        private Guna.UI.WinForms.GunaGroupBox grbListaProducto;
        private Guna.UI.WinForms.GunaDataGridView dgvListaProducto;
        private Guna.UI.WinForms.GunaButton btnNuevoProducto;
        private Guna.UI.WinForms.GunaLabel lblBuscarProducto;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewImageColumn ImagenProducto;
    }
}