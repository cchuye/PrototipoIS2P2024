
namespace CapaVistaERP.Procesos
{
    partial class Dispo_Diaria
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelarTransaccion = new System.Windows.Forms.Button();
            this.btn_rtrans = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_nombrebanco = new System.Windows.Forms.TextBox();
            this.txt_idbancoag = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_banco = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 389);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(828, 271);
            this.dataGridView1.TabIndex = 122;
            this.dataGridView1.Tag = "tbl_mantenimientos_agregar_bancos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_status);
            this.groupBox1.Controls.Add(this.txt_nombrebanco);
            this.groupBox1.Controls.Add(this.txt_idbancoag);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_banco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btn_cancelarTransaccion);
            this.groupBox1.Controls.Add(this.btn_rtrans);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 344);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Disponibilidad diaria";
            // 
            // btn_cancelarTransaccion
            // 
            this.btn_cancelarTransaccion.Location = new System.Drawing.Point(132, 292);
            this.btn_cancelarTransaccion.Name = "btn_cancelarTransaccion";
            this.btn_cancelarTransaccion.Size = new System.Drawing.Size(372, 33);
            this.btn_cancelarTransaccion.TabIndex = 13;
            this.btn_cancelarTransaccion.Text = "Cancelar ";
            this.btn_cancelarTransaccion.UseVisualStyleBackColor = true;
            // 
            // btn_rtrans
            // 
            this.btn_rtrans.Location = new System.Drawing.Point(132, 253);
            this.btn_rtrans.Name = "btn_rtrans";
            this.btn_rtrans.Size = new System.Drawing.Size(372, 33);
            this.btn_rtrans.TabIndex = 10;
            this.btn_rtrans.Text = "agregar";
            this.btn_rtrans.UseVisualStyleBackColor = true;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(542, 167);
            this.txt_status.Margin = new System.Windows.Forms.Padding(4);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(132, 22);
            this.txt_status.TabIndex = 130;
            this.txt_status.Tag = "manag_status";
            // 
            // txt_nombrebanco
            // 
            this.txt_nombrebanco.Location = new System.Drawing.Point(542, 135);
            this.txt_nombrebanco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombrebanco.Name = "txt_nombrebanco";
            this.txt_nombrebanco.Size = new System.Drawing.Size(132, 22);
            this.txt_nombrebanco.TabIndex = 129;
            this.txt_nombrebanco.Tag = "manag_nombre_banco";
            // 
            // txt_idbancoag
            // 
            this.txt_idbancoag.Location = new System.Drawing.Point(542, 103);
            this.txt_idbancoag.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idbancoag.Name = "txt_idbancoag";
            this.txt_idbancoag.Size = new System.Drawing.Size(132, 22);
            this.txt_idbancoag.TabIndex = 128;
            this.txt_idbancoag.Tag = "manag_id_bancoag";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(542, 52);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 22);
            this.txt_id.TabIndex = 127;
            this.txt_id.Tag = "pk_manag_id_ban";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 24);
            this.comboBox1.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Tipo de moneda:";
            // 
            // combo_banco
            // 
            this.combo_banco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_banco.FormattingEnabled = true;
            this.combo_banco.Location = new System.Drawing.Point(209, 109);
            this.combo_banco.Margin = new System.Windows.Forms.Padding(4);
            this.combo_banco.Name = "combo_banco";
            this.combo_banco.Size = new System.Drawing.Size(297, 24);
            this.combo_banco.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 167);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 125;
            this.label8.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 123;
            this.label2.Text = "Banco a Consultar:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(209, 158);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker2.TabIndex = 126;
            this.dateTimePicker2.Value = new System.DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // Dispo_Diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dispo_Diaria";
            this.Text = "Dispo_Diaria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_nombrebanco;
        private System.Windows.Forms.TextBox txt_idbancoag;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_banco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_cancelarTransaccion;
        private System.Windows.Forms.Button btn_rtrans;
    }
}