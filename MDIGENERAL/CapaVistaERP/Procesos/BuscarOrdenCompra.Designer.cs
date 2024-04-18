
namespace CapaVistaERP.Procesos
{
    partial class BuscarOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarOrdenCompra));
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.dgv_orden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscarOrden = new System.Windows.Forms.Button();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(713, 32);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(100, 28);
            this.btn_seleccionar.TabIndex = 39;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // dgv_orden
            // 
            this.dgv_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orden.Location = new System.Drawing.Point(36, 91);
            this.dgv_orden.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_orden.Name = "dgv_orden";
            this.dgv_orden.RowHeadersWidth = 51;
            this.dgv_orden.Size = new System.Drawing.Size(777, 185);
            this.dgv_orden.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID de la órden compra";
            // 
            // btn_buscarOrden
            // 
            this.btn_buscarOrden.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_buscarOrden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarOrden.BackgroundImage")));
            this.btn_buscarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarOrden.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarOrden.Image")));
            this.btn_buscarOrden.Location = new System.Drawing.Point(433, 33);
            this.btn_buscarOrden.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscarOrden.Name = "btn_buscarOrden";
            this.btn_buscarOrden.Size = new System.Drawing.Size(31, 25);
            this.btn_buscarOrden.TabIndex = 36;
            this.btn_buscarOrden.UseVisualStyleBackColor = false;
            this.btn_buscarOrden.Click += new System.EventHandler(this.btn_buscarOrden_Click);
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(224, 33);
            this.txt_Orden.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Orden.Multiline = true;
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.Size = new System.Drawing.Size(239, 27);
            this.txt_Orden.TabIndex = 35;
            // 
            // BuscarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 321);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_orden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscarOrden);
            this.Controls.Add(this.txt_Orden);
            this.Name = "BuscarOrdenCompra";
            this.Text = "BuscarOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridView dgv_orden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarOrden;
        private System.Windows.Forms.TextBox txt_Orden;
    }
}