namespace CapaVistaERP.Procesos
{
    partial class Mov_bancario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_vistaTransacciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_stCon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valorTrans = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_numeroCuenta = new System.Windows.Forms.TextBox();
            this.txt_ttransaccion = new System.Windows.Forms.TextBox();
            this.cb_tipoTrans = new System.Windows.Forms.ComboBox();
            this.cb_nCuenta = new System.Windows.Forms.ComboBox();
            this.txt_descripcionTransferencia = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.txt_valorTransferencia = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_vistaTransacciones);
            this.groupBox2.Location = new System.Drawing.Point(61, 387);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 316);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista de transacciones";
            // 
            // dgv_vistaTransacciones
            // 
            this.dgv_vistaTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vistaTransacciones.Location = new System.Drawing.Point(18, 39);
            this.dgv_vistaTransacciones.Name = "dgv_vistaTransacciones";
            this.dgv_vistaTransacciones.RowHeadersWidth = 51;
            this.dgv_vistaTransacciones.RowTemplate.Height = 24;
            this.dgv_vistaTransacciones.Size = new System.Drawing.Size(693, 256);
            this.dgv_vistaTransacciones.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_stCon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_valorTrans);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_estado);
            this.groupBox1.Controls.Add(this.txt_numeroCuenta);
            this.groupBox1.Controls.Add(this.txt_ttransaccion);
            this.groupBox1.Controls.Add(this.cb_tipoTrans);
            this.groupBox1.Controls.Add(this.cb_nCuenta);
            this.groupBox1.Controls.Add(this.txt_descripcionTransferencia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Controls.Add(this.txt_valorTransferencia);
            this.groupBox1.Location = new System.Drawing.Point(61, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 344);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar transacciones";
            // 
            // txt_stCon
            // 
            this.txt_stCon.Enabled = false;
            this.txt_stCon.Location = new System.Drawing.Point(641, 145);
            this.txt_stCon.Name = "txt_stCon";
            this.txt_stCon.ReadOnly = true;
            this.txt_stCon.Size = new System.Drawing.Size(41, 22);
            this.txt_stCon.TabIndex = 95;
            this.txt_stCon.Text = "0";
            this.txt_stCon.Visible = false;
            this.txt_stCon.TextChanged += new System.EventHandler(this.txt_stCon_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(589, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 92;
            this.label6.Text = "--";
            // 
            // txt_valorTrans
            // 
            this.txt_valorTrans.Enabled = false;
            this.txt_valorTrans.Location = new System.Drawing.Point(592, 145);
            this.txt_valorTrans.Name = "txt_valorTrans";
            this.txt_valorTrans.ReadOnly = true;
            this.txt_valorTrans.Size = new System.Drawing.Size(41, 22);
            this.txt_valorTrans.TabIndex = 94;
            this.txt_valorTrans.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "Saldo:";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(536, 145);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.ReadOnly = true;
            this.txt_estado.Size = new System.Drawing.Size(41, 22);
            this.txt_estado.TabIndex = 91;
            this.txt_estado.Text = "1";
            this.txt_estado.Visible = false;
            // 
            // txt_numeroCuenta
            // 
            this.txt_numeroCuenta.Location = new System.Drawing.Point(512, 30);
            this.txt_numeroCuenta.Name = "txt_numeroCuenta";
            this.txt_numeroCuenta.Size = new System.Drawing.Size(214, 22);
            this.txt_numeroCuenta.TabIndex = 21;
            this.txt_numeroCuenta.Visible = false;
            // 
            // txt_ttransaccion
            // 
            this.txt_ttransaccion.Location = new System.Drawing.Point(512, 75);
            this.txt_ttransaccion.Name = "txt_ttransaccion";
            this.txt_ttransaccion.Size = new System.Drawing.Size(214, 22);
            this.txt_ttransaccion.TabIndex = 20;
            this.txt_ttransaccion.Visible = false;
            // 
            // cb_tipoTrans
            // 
            this.cb_tipoTrans.FormattingEnabled = true;
            this.cb_tipoTrans.Location = new System.Drawing.Point(290, 73);
            this.cb_tipoTrans.Name = "cb_tipoTrans";
            this.cb_tipoTrans.Size = new System.Drawing.Size(203, 24);
            this.cb_tipoTrans.TabIndex = 19;
            this.cb_tipoTrans.SelectedIndexChanged += new System.EventHandler(this.cb_tipoTrans_SelectedIndexChanged);
            // 
            // cb_nCuenta
            // 
            this.cb_nCuenta.FormattingEnabled = true;
            this.cb_nCuenta.Location = new System.Drawing.Point(290, 30);
            this.cb_nCuenta.Name = "cb_nCuenta";
            this.cb_nCuenta.Size = new System.Drawing.Size(203, 24);
            this.cb_nCuenta.TabIndex = 18;
            this.cb_nCuenta.SelectedIndexChanged += new System.EventHandler(this.cb_nCuenta_SelectedIndexChanged);
            // 
            // txt_descripcionTransferencia
            // 
            this.txt_descripcionTransferencia.Location = new System.Drawing.Point(290, 145);
            this.txt_descripcionTransferencia.Name = "txt_descripcionTransferencia";
            this.txt_descripcionTransferencia.Size = new System.Drawing.Size(214, 84);
            this.txt_descripcionTransferencia.TabIndex = 9;
            this.txt_descripcionTransferencia.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de cuenta:";
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(132, 292);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(372, 33);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar transacción";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            this.btn_cancelarTransaccion.Click += new System.EventHandler(this.btn_cancelarTransaccion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de transacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción: ";
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(132, 253);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(372, 33);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "Realizar transacción";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            this.btn_rtrans.Click += new System.EventHandler(this.btn_rtrans_Click);
            // 
            // txt_valorTransferencia
            // 
            this.txt_valorTransferencia.Location = new System.Drawing.Point(290, 111);
            this.txt_valorTransferencia.Name = "txt_valorTransferencia";
            this.txt_valorTransferencia.Size = new System.Drawing.Size(203, 22);
            this.txt_valorTransferencia.TabIndex = 6;
            // 
            // Mov_bancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mov_bancario";
            this.Text = "Mov_bancario";
            this.Load += new System.EventHandler(this.Mov_bancario_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vistaTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_vistaTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_stCon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_valorTrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_numeroCuenta;
        private System.Windows.Forms.TextBox txt_ttransaccion;
        private System.Windows.Forms.ComboBox cb_tipoTrans;
        private System.Windows.Forms.ComboBox cb_nCuenta;
        private System.Windows.Forms.RichTextBox txt_descripcionTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rtrans;
        private System.Windows.Forms.TextBox txt_valorTransferencia;
    }
}