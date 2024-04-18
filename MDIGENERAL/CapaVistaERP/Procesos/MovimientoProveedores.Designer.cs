namespace CapaVistaERP.Procesos
{
    partial class MovimientoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoProveedores));
            this.btn_pagoproveedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nitprov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Idprov = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pagoproveedor
            // 
            this.btn_pagoproveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagoproveedor.Location = new System.Drawing.Point(39, 408);
            this.btn_pagoproveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pagoproveedor.Name = "btn_pagoproveedor";
            this.btn_pagoproveedor.Size = new System.Drawing.Size(207, 46);
            this.btn_pagoproveedor.TabIndex = 37;
            this.btn_pagoproveedor.Text = "Pago a proveedor";
            this.btn_pagoproveedor.UseVisualStyleBackColor = true;
            this.btn_pagoproveedor.Click += new System.EventHandler(this.btn_pagoproveedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pagoproveedor);
            this.groupBox1.Controls.Add(this.txt_nitprov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_proveedores);
            this.groupBox1.Controls.Add(this.txt_nombreprov);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Idprov);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 489);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // txt_nitprov
            // 
            this.txt_nitprov.Location = new System.Drawing.Point(740, 50);
            this.txt_nitprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nitprov.Name = "txt_nitprov";
            this.txt_nitprov.Size = new System.Drawing.Size(184, 24);
            this.txt_nitprov.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "NIT Proveedor";
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Location = new System.Drawing.Point(49, 93);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.RowHeadersWidth = 51;
            this.dgv_proveedores.RowTemplate.Height = 24;
            this.dgv_proveedores.Size = new System.Drawing.Size(943, 293);
            this.dgv_proveedores.TabIndex = 34;
            this.dgv_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedores_CellContentClick);
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Location = new System.Drawing.Point(386, 48);
            this.txt_nombreprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(184, 24);
            this.txt_nombreprov.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(959, 50);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(33, 25);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Proveedor";
            // 
            // txt_Idprov
            // 
            this.txt_Idprov.Location = new System.Drawing.Point(173, 46);
            this.txt_Idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Idprov.Name = "txt_Idprov";
            this.txt_Idprov.Size = new System.Drawing.Size(104, 24);
            this.txt_Idprov.TabIndex = 11;
            // 
            // MovimientoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "MovimientoProveedores";
            this.Text = "MovimientoProveedores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pagoproveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Idprov;
        private System.Windows.Forms.TextBox txt_nitprov;
        private System.Windows.Forms.Label label1;
    }
}