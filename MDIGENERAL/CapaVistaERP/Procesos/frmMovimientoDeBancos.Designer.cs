
namespace CapaVistaERP.Procesos
{
    partial class frmMovimientoDeBancos
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
            this.btn_cancelarMovimiento = new System.Windows.Forms.Button();
            this.btn_realizarMovimiento = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_estadoCuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipoCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_noCuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_efecto = new System.Windows.Forms.TextBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_movimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelarMovimiento
            // 
            this.btn_cancelarMovimiento.Location = new System.Drawing.Point(185, 418);
            this.btn_cancelarMovimiento.Name = "btn_cancelarMovimiento";
            this.btn_cancelarMovimiento.Size = new System.Drawing.Size(142, 51);
            this.btn_cancelarMovimiento.TabIndex = 31;
            this.btn_cancelarMovimiento.Text = "Cancelar Movimiento";
            this.btn_cancelarMovimiento.UseVisualStyleBackColor = true;
            // 
            // btn_realizarMovimiento
            // 
            this.btn_realizarMovimiento.Location = new System.Drawing.Point(29, 418);
            this.btn_realizarMovimiento.Name = "btn_realizarMovimiento";
            this.btn_realizarMovimiento.Size = new System.Drawing.Size(142, 51);
            this.btn_realizarMovimiento.TabIndex = 30;
            this.btn_realizarMovimiento.Text = "Realizar Movimiento";
            this.btn_realizarMovimiento.UseVisualStyleBackColor = true;
            this.btn_realizarMovimiento.Click += new System.EventHandler(this.btn_realizarMovimiento_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_estadoCuenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_tipoCuenta);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_noCuenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_nombreCuenta);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(29, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de cuenta";
            // 
            // txt_estadoCuenta
            // 
            this.txt_estadoCuenta.Enabled = false;
            this.txt_estadoCuenta.Location = new System.Drawing.Point(566, 52);
            this.txt_estadoCuenta.Name = "txt_estadoCuenta";
            this.txt_estadoCuenta.Size = new System.Drawing.Size(106, 22);
            this.txt_estadoCuenta.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre de la cuenta";
            // 
            // txt_tipoCuenta
            // 
            this.txt_tipoCuenta.Enabled = false;
            this.txt_tipoCuenta.Location = new System.Drawing.Point(419, 52);
            this.txt_tipoCuenta.Name = "txt_tipoCuenta";
            this.txt_tipoCuenta.Size = new System.Drawing.Size(119, 22);
            this.txt_tipoCuenta.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "No. cuenta";
            // 
            // txt_noCuenta
            // 
            this.txt_noCuenta.Enabled = false;
            this.txt_noCuenta.Location = new System.Drawing.Point(218, 52);
            this.txt_noCuenta.Name = "txt_noCuenta";
            this.txt_noCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_noCuenta.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tipo de cuenta";
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Enabled = false;
            this.txt_nombreCuenta.Location = new System.Drawing.Point(18, 52);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(172, 22);
            this.txt_nombreCuenta.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Estado actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_cuenta);
            this.groupBox2.Controls.Add(this.dtp_fecha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_monto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(408, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 159);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de datos";
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.Location = new System.Drawing.Point(156, 76);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(200, 24);
            this.cb_cuenta.TabIndex = 10;
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(156, 121);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.dtp_fecha.TabIndex = 12;
            this.dtp_fecha.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha";
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(156, 30);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(200, 22);
            this.txt_monto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecionar cuenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_efecto);
            this.groupBox1.Controls.Add(this.txt_concepto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 159);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del movimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Efecto";
            // 
            // txt_efecto
            // 
            this.txt_efecto.Enabled = false;
            this.txt_efecto.Location = new System.Drawing.Point(221, 76);
            this.txt_efecto.Name = "txt_efecto";
            this.txt_efecto.Size = new System.Drawing.Size(77, 22);
            this.txt_efecto.TabIndex = 5;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Enabled = false;
            this.txt_concepto.Location = new System.Drawing.Point(13, 76);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(143, 22);
            this.txt_concepto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Concepto";
            // 
            // cb_movimiento
            // 
            this.cb_movimiento.FormattingEnabled = true;
            this.cb_movimiento.Location = new System.Drawing.Point(29, 63);
            this.cb_movimiento.Name = "cb_movimiento";
            this.cb_movimiento.Size = new System.Drawing.Size(172, 24);
            this.cb_movimiento.TabIndex = 26;
            this.cb_movimiento.SelectedIndexChanged += new System.EventHandler(this.cb_movimiento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "tipo de movimiento";
            // 
            // frmMovimientoDeBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.btn_cancelarMovimiento);
            this.Controls.Add(this.btn_realizarMovimiento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_movimiento);
            this.Controls.Add(this.label1);
            this.Name = "frmMovimientoDeBancos";
            this.Text = "frmMovimientoDeBancos";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelarMovimiento;
        private System.Windows.Forms.Button btn_realizarMovimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_estadoCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipoCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_noCuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_cuenta;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_efecto;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_movimiento;
        private System.Windows.Forms.Label label1;
    }
}