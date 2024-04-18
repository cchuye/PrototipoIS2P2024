
namespace CapaVistaERP.Procesos
{
    partial class AutorizacionOrdenDeCompra
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aprobar = new System.Windows.Forms.Button();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_MontoOrden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_saldoDisponible = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_totalOrdenLetras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalOrden = new System.Windows.Forms.TextBox();
            this.dtp_fechaAutorizacion = new System.Windows.Forms.DateTimePicker();
            this.cb_numeroOrden = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cuenta = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_NoCuenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nombreCuenta = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(662, 537);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(105, 58);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aprobar
            // 
            this.btn_aprobar.Location = new System.Drawing.Point(662, 451);
            this.btn_aprobar.Name = "btn_aprobar";
            this.btn_aprobar.Size = new System.Drawing.Size(105, 58);
            this.btn_aprobar.TabIndex = 30;
            this.btn_aprobar.Text = "Aprobar";
            this.btn_aprobar.UseVisualStyleBackColor = true;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "[seleccionar]",
            "Aprobado",
            "No aprobado ",
            "En espera",
            "Suspendido"});
            this.cb_estado.Location = new System.Drawing.Point(380, 482);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(235, 24);
            this.cb_estado.TabIndex = 29;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(31, 482);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(287, 107);
            this.txt_Descripcion.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MontoOrden);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_saldoDisponible);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(31, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 141);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Validacion de saldos";
            // 
            // txt_MontoOrden
            // 
            this.txt_MontoOrden.Location = new System.Drawing.Point(199, 76);
            this.txt_MontoOrden.Name = "txt_MontoOrden";
            this.txt_MontoOrden.Size = new System.Drawing.Size(127, 22);
            this.txt_MontoOrden.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Monto de la orden";
            // 
            // txt_saldoDisponible
            // 
            this.txt_saldoDisponible.Location = new System.Drawing.Point(16, 76);
            this.txt_saldoDisponible.Name = "txt_saldoDisponible";
            this.txt_saldoDisponible.Size = new System.Drawing.Size(127, 22);
            this.txt_saldoDisponible.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Saldo Disponible";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_totalOrdenLetras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_totalOrden);
            this.groupBox1.Location = new System.Drawing.Point(31, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 132);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de orden";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuenta asociada";
            // 
            // txt_totalOrdenLetras
            // 
            this.txt_totalOrdenLetras.Location = new System.Drawing.Point(115, 73);
            this.txt_totalOrdenLetras.Name = "txt_totalOrdenLetras";
            this.txt_totalOrdenLetras.Size = new System.Drawing.Size(190, 22);
            this.txt_totalOrdenLetras.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "total en letras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // txt_totalOrden
            // 
            this.txt_totalOrden.Location = new System.Drawing.Point(115, 39);
            this.txt_totalOrden.Name = "txt_totalOrden";
            this.txt_totalOrden.Size = new System.Drawing.Size(190, 22);
            this.txt_totalOrden.TabIndex = 10;
            // 
            // dtp_fechaAutorizacion
            // 
            this.dtp_fechaAutorizacion.Location = new System.Drawing.Point(380, 553);
            this.dtp_fechaAutorizacion.Name = "dtp_fechaAutorizacion";
            this.dtp_fechaAutorizacion.Size = new System.Drawing.Size(235, 22);
            this.dtp_fechaAutorizacion.TabIndex = 24;
            this.dtp_fechaAutorizacion.Value = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            // 
            // cb_numeroOrden
            // 
            this.cb_numeroOrden.FormattingEnabled = true;
            this.cb_numeroOrden.Location = new System.Drawing.Point(31, 51);
            this.cb_numeroOrden.Name = "cb_numeroOrden";
            this.cb_numeroOrden.Size = new System.Drawing.Size(158, 24);
            this.cb_numeroOrden.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de autorizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descripcion de la aprobacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Estado de la orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Numero de orden";
            // 
            // cb_cuenta
            // 
            this.cb_cuenta.FormattingEnabled = true;
            this.cb_cuenta.Location = new System.Drawing.Point(380, 51);
            this.cb_cuenta.Name = "cb_cuenta";
            this.cb_cuenta.Size = new System.Drawing.Size(158, 24);
            this.cb_cuenta.TabIndex = 32;
            this.cb_cuenta.SelectedIndexChanged += new System.EventHandler(this.cb_cuenta_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_NoCuenta);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_nombreCuenta);
            this.groupBox3.Location = new System.Drawing.Point(380, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 132);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la cuenta";
            // 
            // txt_NoCuenta
            // 
            this.txt_NoCuenta.Location = new System.Drawing.Point(159, 73);
            this.txt_NoCuenta.Name = "txt_NoCuenta";
            this.txt_NoCuenta.Size = new System.Drawing.Size(190, 22);
            this.txt_NoCuenta.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Numero de cuenta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nombre de la cuenta";
            // 
            // txt_nombreCuenta
            // 
            this.txt_nombreCuenta.Location = new System.Drawing.Point(159, 39);
            this.txt_nombreCuenta.Name = "txt_nombreCuenta";
            this.txt_nombreCuenta.Size = new System.Drawing.Size(190, 22);
            this.txt_nombreCuenta.TabIndex = 10;
            // 
            // AutorizacionOrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 637);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_cuenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aprobar);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_fechaAutorizacion);
            this.Controls.Add(this.cb_numeroOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutorizacionOrdenDeCompra";
            this.Text = "AutorizacionOrdenDeCompra";
            this.Load += new System.EventHandler(this.AutorizacionOrdenDeCompra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aprobar;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MontoOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_saldoDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_totalOrdenLetras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalOrden;
        private System.Windows.Forms.DateTimePicker dtp_fechaAutorizacion;
        private System.Windows.Forms.ComboBox cb_numeroOrden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cuenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_NoCuenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nombreCuenta;
    }
}