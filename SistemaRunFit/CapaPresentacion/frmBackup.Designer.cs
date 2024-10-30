namespace CapaPresentacion
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.pnlContenedorBackup = new System.Windows.Forms.Panel();
            this.pnlDatosUsuarioUser = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnRestaurar = new Guna.UI.WinForms.GunaButton();
            this.btnSeleccionarArchivo = new Guna.UI.WinForms.GunaButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUltima = new System.Windows.Forms.Label();
            this.lblUltimoBackup = new System.Windows.Forms.Label();
            this.btnMenuMarca = new Guna.UI.WinForms.GunaButton();
            this.lblBackupSistema = new System.Windows.Forms.Label();
            this.btnHacerBackup = new Guna.UI.WinForms.GunaButton();
            this.txtUsuarioBackup = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassBackup = new Guna.UI.WinForms.GunaTextBox();
            this.txtRutaArchivo = new Guna.UI.WinForms.GunaTextBox();
            this.lblUsuarioBackup = new Guna.UI.WinForms.GunaLabel();
            this.lblPassBackup = new Guna.UI.WinForms.GunaLabel();
            this.lblPath = new Guna.UI.WinForms.GunaLabel();
            this.pnlContenedorBackup.SuspendLayout();
            this.pnlDatosUsuarioUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedorBackup
            // 
            this.pnlContenedorBackup.AutoScroll = true;
            this.pnlContenedorBackup.BackColor = System.Drawing.Color.White;
            this.pnlContenedorBackup.Controls.Add(this.pnlDatosUsuarioUser);
            this.pnlContenedorBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorBackup.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorBackup.Name = "pnlContenedorBackup";
            this.pnlContenedorBackup.Size = new System.Drawing.Size(800, 467);
            this.pnlContenedorBackup.TabIndex = 53;
            // 
            // pnlDatosUsuarioUser
            // 
            this.pnlDatosUsuarioUser.AutoScroll = true;
            this.pnlDatosUsuarioUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlDatosUsuarioUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlDatosUsuarioUser.Controls.Add(this.lblPath);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblPassBackup);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblUsuarioBackup);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtRutaArchivo);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtPassBackup);
            this.pnlDatosUsuarioUser.Controls.Add(this.txtUsuarioBackup);
            this.pnlDatosUsuarioUser.Controls.Add(this.btnRestaurar);
            this.pnlDatosUsuarioUser.Controls.Add(this.btnSeleccionarArchivo);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblEstado);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblUltima);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblUltimoBackup);
            this.pnlDatosUsuarioUser.Controls.Add(this.btnMenuMarca);
            this.pnlDatosUsuarioUser.Controls.Add(this.lblBackupSistema);
            this.pnlDatosUsuarioUser.Controls.Add(this.btnHacerBackup);
            this.pnlDatosUsuarioUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosUsuarioUser.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosUsuarioUser.Name = "pnlDatosUsuarioUser";
            this.pnlDatosUsuarioUser.Radius = 5;
            this.pnlDatosUsuarioUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlDatosUsuarioUser.Size = new System.Drawing.Size(800, 467);
            this.pnlDatosUsuarioUser.TabIndex = 49;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AnimationHoverSpeed = 0.07F;
            this.btnRestaurar.AnimationSpeed = 0.03F;
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.BaseColor = System.Drawing.Color.White;
            this.btnRestaurar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnRestaurar.BorderSize = 2;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestaurar.FocusedColor = System.Drawing.Color.Red;
            this.btnRestaurar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.Red;
            this.btnRestaurar.Image = null;
            this.btnRestaurar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRestaurar.Location = new System.Drawing.Point(591, 305);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnRestaurar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRestaurar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRestaurar.OnHoverImage = null;
            this.btnRestaurar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRestaurar.Radius = 10;
            this.btnRestaurar.Size = new System.Drawing.Size(113, 37);
            this.btnRestaurar.TabIndex = 96;
            this.btnRestaurar.Text = "RESTAURAR";
            this.btnRestaurar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click_1);
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionarArchivo.AnimationSpeed = 0.03F;
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarArchivo.BaseColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnSeleccionarArchivo.BorderSize = 2;
            this.btnSeleccionarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarArchivo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionarArchivo.FocusedColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnSeleccionarArchivo.Image = null;
            this.btnSeleccionarArchivo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(565, 132);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnSeleccionarArchivo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.OnHoverImage = null;
            this.btnSeleccionarArchivo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionarArchivo.Radius = 10;
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(152, 60);
            this.btnSeleccionarArchivo.TabIndex = 95;
            this.btnSeleccionarArchivo.Text = "Seleccionar archivo ";
            this.btnSeleccionarArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(44, 291);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(187, 66);
            this.lblEstado.TabIndex = 91;
            this.lblEstado.Text = "Ultima copia \r\nrealizada el: ";
            // 
            // lblUltima
            // 
            this.lblUltima.AutoSize = true;
            this.lblUltima.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltima.Location = new System.Drawing.Point(246, 309);
            this.lblUltima.Name = "lblUltima";
            this.lblUltima.Size = new System.Drawing.Size(102, 33);
            this.lblUltima.TabIndex = 90;
            this.lblUltima.Text = "Estado";
            // 
            // lblUltimoBackup
            // 
            this.lblUltimoBackup.AutoSize = true;
            this.lblUltimoBackup.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoBackup.Location = new System.Drawing.Point(466, 238);
            this.lblUltimoBackup.Name = "lblUltimoBackup";
            this.lblUltimoBackup.Size = new System.Drawing.Size(0, 33);
            this.lblUltimoBackup.TabIndex = 89;
            // 
            // btnMenuMarca
            // 
            this.btnMenuMarca.AnimationHoverSpeed = 0.07F;
            this.btnMenuMarca.AnimationSpeed = 0.03F;
            this.btnMenuMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuMarca.BaseColor = System.Drawing.Color.White;
            this.btnMenuMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnMenuMarca.BorderSize = 2;
            this.btnMenuMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenuMarca.FocusedColor = System.Drawing.Color.Red;
            this.btnMenuMarca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMarca.ForeColor = System.Drawing.Color.Red;
            this.btnMenuMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuMarca.Image")));
            this.btnMenuMarca.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMenuMarca.Location = new System.Drawing.Point(77, 203);
            this.btnMenuMarca.Name = "btnMenuMarca";
            this.btnMenuMarca.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnMenuMarca.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenuMarca.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenuMarca.OnHoverImage = null;
            this.btnMenuMarca.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenuMarca.Radius = 10;
            this.btnMenuMarca.Size = new System.Drawing.Size(113, 37);
            this.btnMenuMarca.TabIndex = 88;
            this.btnMenuMarca.Text = "MENU";
            this.btnMenuMarca.Click += new System.EventHandler(this.btnMenuMarca_Click);
            // 
            // lblBackupSistema
            // 
            this.lblBackupSistema.AutoSize = true;
            this.lblBackupSistema.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupSistema.Location = new System.Drawing.Point(253, 28);
            this.lblBackupSistema.Name = "lblBackupSistema";
            this.lblBackupSistema.Size = new System.Drawing.Size(287, 33);
            this.lblBackupSistema.TabIndex = 65;
            this.lblBackupSistema.Text = "BACKUP DEL SISTEMA";
            // 
            // btnHacerBackup
            // 
            this.btnHacerBackup.AnimationHoverSpeed = 0.07F;
            this.btnHacerBackup.AnimationSpeed = 0.03F;
            this.btnHacerBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnHacerBackup.BaseColor = System.Drawing.Color.White;
            this.btnHacerBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.btnHacerBackup.BorderSize = 2;
            this.btnHacerBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHacerBackup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHacerBackup.FocusedColor = System.Drawing.Color.White;
            this.btnHacerBackup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnHacerBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnHacerBackup.Image")));
            this.btnHacerBackup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHacerBackup.Location = new System.Drawing.Point(61, 100);
            this.btnHacerBackup.Name = "btnHacerBackup";
            this.btnHacerBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(163)))), ((int)(((byte)(108)))));
            this.btnHacerBackup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHacerBackup.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHacerBackup.OnHoverImage = null;
            this.btnHacerBackup.OnPressedColor = System.Drawing.Color.Black;
            this.btnHacerBackup.Radius = 10;
            this.btnHacerBackup.Size = new System.Drawing.Size(152, 60);
            this.btnHacerBackup.TabIndex = 11;
            this.btnHacerBackup.Text = "Hacer Backup";
            this.btnHacerBackup.Click += new System.EventHandler(this.btnHacerBackup_Click);
            // 
            // txtUsuarioBackup
            // 
            this.txtUsuarioBackup.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuarioBackup.BaseColor = System.Drawing.Color.White;
            this.txtUsuarioBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtUsuarioBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuarioBackup.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsuarioBackup.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtUsuarioBackup.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuarioBackup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioBackup.Location = new System.Drawing.Point(565, 214);
            this.txtUsuarioBackup.MaxLength = 30;
            this.txtUsuarioBackup.Name = "txtUsuarioBackup";
            this.txtUsuarioBackup.PasswordChar = '\0';
            this.txtUsuarioBackup.Radius = 10;
            this.txtUsuarioBackup.SelectedText = "";
            this.txtUsuarioBackup.Size = new System.Drawing.Size(183, 26);
            this.txtUsuarioBackup.TabIndex = 97;
            this.txtUsuarioBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassBackup
            // 
            this.txtPassBackup.BackColor = System.Drawing.Color.Transparent;
            this.txtPassBackup.BaseColor = System.Drawing.Color.White;
            this.txtPassBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtPassBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassBackup.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassBackup.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtPassBackup.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassBackup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassBackup.Location = new System.Drawing.Point(565, 255);
            this.txtPassBackup.MaxLength = 30;
            this.txtPassBackup.Name = "txtPassBackup";
            this.txtPassBackup.PasswordChar = '●';
            this.txtPassBackup.Radius = 10;
            this.txtPassBackup.SelectedText = "";
            this.txtPassBackup.Size = new System.Drawing.Size(183, 26);
            this.txtPassBackup.TabIndex = 98;
            this.txtPassBackup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassBackup.UseSystemPasswordChar = true;
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.BackColor = System.Drawing.Color.Transparent;
            this.txtRutaArchivo.BaseColor = System.Drawing.Color.White;
            this.txtRutaArchivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(71)))), ((int)(((byte)(109)))));
            this.txtRutaArchivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRutaArchivo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRutaArchivo.FocusedBorderColor = System.Drawing.Color.SeaGreen;
            this.txtRutaArchivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRutaArchivo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaArchivo.Location = new System.Drawing.Point(552, 100);
            this.txtRutaArchivo.MaxLength = 30;
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.PasswordChar = '\0';
            this.txtRutaArchivo.Radius = 10;
            this.txtRutaArchivo.SelectedText = "";
            this.txtRutaArchivo.Size = new System.Drawing.Size(183, 26);
            this.txtRutaArchivo.TabIndex = 99;
            this.txtRutaArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuarioBackup
            // 
            this.lblUsuarioBackup.AutoSize = true;
            this.lblUsuarioBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioBackup.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioBackup.Location = new System.Drawing.Point(485, 224);
            this.lblUsuarioBackup.Name = "lblUsuarioBackup";
            this.lblUsuarioBackup.Size = new System.Drawing.Size(55, 16);
            this.lblUsuarioBackup.TabIndex = 100;
            this.lblUsuarioBackup.Text = "Usuario";
            // 
            // lblPassBackup
            // 
            this.lblPassBackup.AutoSize = true;
            this.lblPassBackup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassBackup.ForeColor = System.Drawing.Color.White;
            this.lblPassBackup.Location = new System.Drawing.Point(469, 265);
            this.lblPassBackup.Name = "lblPassBackup";
            this.lblPassBackup.Size = new System.Drawing.Size(90, 16);
            this.lblPassBackup.TabIndex = 101;
            this.lblPassBackup.Text = "Contraseña: ";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.White;
            this.lblPath.Location = new System.Drawing.Point(487, 110);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(44, 16);
            this.lblPath.TabIndex = 102;
            this.lblPath.Text = "Ruta: ";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.pnlContenedorBackup);
            this.Name = "frmBackup";
            this.Text = "Form1";
            this.pnlContenedorBackup.ResumeLayout(false);
            this.pnlDatosUsuarioUser.ResumeLayout(false);
            this.pnlDatosUsuarioUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorBackup;
        private Guna.UI.WinForms.GunaShadowPanel pnlDatosUsuarioUser;
        private Guna.UI.WinForms.GunaButton btnHacerBackup;
        private System.Windows.Forms.Label lblBackupSistema;
        private Guna.UI.WinForms.GunaButton btnMenuMarca;
        private System.Windows.Forms.Label lblUltimoBackup;
        private System.Windows.Forms.Label lblUltima;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI.WinForms.GunaButton btnSeleccionarArchivo;
        private Guna.UI.WinForms.GunaButton btnRestaurar;
        private Guna.UI.WinForms.GunaTextBox txtRutaArchivo;
        private Guna.UI.WinForms.GunaTextBox txtUsuarioBackup;
        private Guna.UI.WinForms.GunaLabel lblPath;
        private Guna.UI.WinForms.GunaLabel lblPassBackup;
        private Guna.UI.WinForms.GunaLabel lblUsuarioBackup;
        internal Guna.UI.WinForms.GunaTextBox txtPassBackup;
    }
}