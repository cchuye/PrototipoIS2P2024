
namespace MenuHCV
{
    partial class Menup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menup));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnPrototipo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Controls.Add(this.btnLogout);
            this.panelLogo.Controls.Add(this.btnPrototipo);
            this.panelLogo.Controls.Add(this.btnseguridad);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(318, 617);
            this.panelLogo.TabIndex = 0;
            // 
            // btnPrototipo
            // 
            this.btnPrototipo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrototipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPrototipo.FlatAppearance.BorderSize = 0;
            this.btnPrototipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrototipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrototipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnPrototipo.Location = new System.Drawing.Point(0, 203);
            this.btnPrototipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrototipo.Name = "btnPrototipo";
            this.btnPrototipo.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.btnPrototipo.Size = new System.Drawing.Size(319, 38);
            this.btnPrototipo.TabIndex = 19;
            this.btnPrototipo.Text = "EPR COMERCIAL";
            this.btnPrototipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrototipo.UseVisualStyleBackColor = false;
            this.btnPrototipo.Click += new System.EventHandler(this.btnPrototipo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = global::Vista_MenuHCV.Properties.Resources.Logo_Bytech;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelSideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(318, 729);
            this.panelSideMenu.TabIndex = 46;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnLogout.Location = new System.Drawing.Point(18, 310);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(301, 31);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "CERRAR SESIÓN";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnseguridad
            // 
            this.btnseguridad.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnseguridad.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseguridad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btnseguridad.Location = new System.Drawing.Point(18, 275);
            this.btnseguridad.Margin = new System.Windows.Forms.Padding(4);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Padding = new System.Windows.Forms.Padding(68, 0, 0, 0);
            this.btnseguridad.Size = new System.Drawing.Size(300, 27);
            this.btnseguridad.TabIndex = 13;
            this.btnseguridad.Text = "SEGURIDAD";
            this.btnseguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnseguridad.UseVisualStyleBackColor = false;
            this.btnseguridad.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Menup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 729);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu General";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSideMenu;
        public System.Windows.Forms.Button btnseguridad;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnPrototipo;
    }
}