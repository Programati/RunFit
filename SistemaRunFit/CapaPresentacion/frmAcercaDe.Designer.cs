namespace CapaPresentacion
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoftAcerca = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBusquedaUser = new Guna.UI.WinForms.GunaShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBusquedaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trabajo Grupal Taller 2";
            // 
            // lblSoftAcerca
            // 
            this.lblSoftAcerca.AutoEllipsis = true;
            this.lblSoftAcerca.AutoSize = true;
            this.lblSoftAcerca.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftAcerca.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftAcerca.Location = new System.Drawing.Point(168, 270);
            this.lblSoftAcerca.Name = "lblSoftAcerca";
            this.lblSoftAcerca.Size = new System.Drawing.Size(524, 42);
            this.lblSoftAcerca.TabIndex = 2;
            this.lblSoftAcerca.Text = "Software de gestion de ventas";
            this.lblSoftAcerca.MouseLeave += new System.EventHandler(this.lblSoftAcerca_MouseLeave);
            this.lblSoftAcerca.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblSoftAcerca_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Integrantes:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Canteros Julio LU:53145";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Martinez Matias LU:51068";
            // 
            // pnlBusquedaUser
            // 
            this.pnlBusquedaUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlBusquedaUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(162)))), ((int)(((byte)(198)))));
            this.pnlBusquedaUser.Controls.Add(this.lblSoftAcerca);
            this.pnlBusquedaUser.Controls.Add(this.label1);
            this.pnlBusquedaUser.Controls.Add(this.label5);
            this.pnlBusquedaUser.Controls.Add(this.label4);
            this.pnlBusquedaUser.Controls.Add(this.pictureBox1);
            this.pnlBusquedaUser.Controls.Add(this.label3);
            this.pnlBusquedaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBusquedaUser.Location = new System.Drawing.Point(0, 0);
            this.pnlBusquedaUser.Name = "pnlBusquedaUser";
            this.pnlBusquedaUser.Radius = 5;
            this.pnlBusquedaUser.ShadowColor = System.Drawing.Color.Black;
            this.pnlBusquedaUser.Size = new System.Drawing.Size(912, 490);
            this.pnlBusquedaUser.TabIndex = 6;
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 490);
            this.Controls.Add(this.pnlBusquedaUser);
            this.Name = "frmAcercaDe";
            this.Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBusquedaUser.ResumeLayout(false);
            this.pnlBusquedaUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoftAcerca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaShadowPanel pnlBusquedaUser;
    }
}