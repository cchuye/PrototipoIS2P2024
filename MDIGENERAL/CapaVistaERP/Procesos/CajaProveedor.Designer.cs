namespace CapaVistaERP.Procesos
{
    partial class CajaProveedor
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
            this.cmb_tipo = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_beneficiario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaAbono = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_banco = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Idprov = new System.Windows.Forms.TextBox();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dgv_pagoproveedor = new System.Windows.Forms.DataGridView();
            this.cmb_tipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagoproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.Controls.Add(this.btn_cancelar);
            this.cmb_tipo.Controls.Add(this.txt_concepto);
            this.cmb_tipo.Controls.Add(this.label9);
            this.cmb_tipo.Controls.Add(this.txt_beneficiario);
            this.cmb_tipo.Controls.Add(this.label8);
            this.cmb_tipo.Controls.Add(this.btn_pagar);
            this.cmb_tipo.Controls.Add(this.dateTimePickerFechaAbono);
            this.cmb_tipo.Controls.Add(this.label7);
            this.cmb_tipo.Controls.Add(this.txt_numero);
            this.cmb_tipo.Controls.Add(this.label6);
            this.cmb_tipo.Controls.Add(this.comboBox3);
            this.cmb_tipo.Controls.Add(this.label5);
            this.cmb_tipo.Controls.Add(this.cmb_banco);
            this.cmb_tipo.Controls.Add(this.label4);
            this.cmb_tipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.Location = new System.Drawing.Point(13, 492);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Padding = new System.Windows.Forms.Padding(4);
            this.cmb_tipo.Size = new System.Drawing.Size(1071, 271);
            this.cmb_tipo.TabIndex = 45;
            this.cmb_tipo.TabStop = false;
            this.cmb_tipo.Text = "Pago";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(797, 181);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(148, 46);
            this.btn_cancelar.TabIndex = 54;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(61, 216);
            this.txt_concepto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(652, 36);
            this.txt_concepto.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Concepto";
            // 
            // txt_beneficiario
            // 
            this.txt_beneficiario.Location = new System.Drawing.Point(162, 141);
            this.txt_beneficiario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_beneficiario.Name = "txt_beneficiario";
            this.txt_beneficiario.Size = new System.Drawing.Size(551, 24);
            this.txt_beneficiario.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Beneficiario";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(797, 105);
            this.btn_pagar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(148, 46);
            this.btn_pagar.TabIndex = 49;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaAbono
            // 
            this.dateTimePickerFechaAbono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaAbono.Location = new System.Drawing.Point(552, 93);
            this.dateTimePickerFechaAbono.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFechaAbono.Name = "dateTimePickerFechaAbono";
            this.dateTimePickerFechaAbono.Size = new System.Drawing.Size(161, 24);
            this.dateTimePickerFechaAbono.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "Fecha abono";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(148, 89);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(161, 24);
            this.txt_numero.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Número";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(552, 37);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 27);
            this.comboBox3.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Tipo";
            // 
            // cmb_banco
            // 
            this.cmb_banco.FormattingEnabled = true;
            this.cmb_banco.Location = new System.Drawing.Point(148, 37);
            this.cmb_banco.Name = "cmb_banco";
            this.cmb_banco.Size = new System.Drawing.Size(161, 27);
            this.cmb_banco.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Banco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Idprov);
            this.groupBox1.Controls.Add(this.txt_nombreprov);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.dgv_pagoproveedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 483);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID Proveedor";
            // 
            // txt_Idprov
            // 
            this.txt_Idprov.Location = new System.Drawing.Point(162, 50);
            this.txt_Idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Idprov.Name = "txt_Idprov";
            this.txt_Idprov.Size = new System.Drawing.Size(104, 24);
            this.txt_Idprov.TabIndex = 35;
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Location = new System.Drawing.Point(797, 432);
            this.txt_nombreprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(184, 24);
            this.txt_nombreprov.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total a pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(375, 48);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(606, 24);
            this.txt_nombre.TabIndex = 37;
            // 
            // dgv_pagoproveedor
            // 
            this.dgv_pagoproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pagoproveedor.Location = new System.Drawing.Point(38, 123);
            this.dgv_pagoproveedor.Name = "dgv_pagoproveedor";
            this.dgv_pagoproveedor.RowHeadersWidth = 51;
            this.dgv_pagoproveedor.RowTemplate.Height = 24;
            this.dgv_pagoproveedor.Size = new System.Drawing.Size(943, 293);
            this.dgv_pagoproveedor.TabIndex = 38;
            // 
            // CajaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 765);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.groupBox1);
            this.Name = "CajaProveedor";
            this.Text = "CajaProveedor";
            this.cmb_tipo.ResumeLayout(false);
            this.cmb_tipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagoproveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cmb_tipo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_beneficiario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAbono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_banco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Idprov;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView dgv_pagoproveedor;
    }
}