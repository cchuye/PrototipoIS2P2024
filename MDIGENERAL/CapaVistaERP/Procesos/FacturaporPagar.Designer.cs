
namespace CapaVistaERP.Procesos
{
    partial class FacturaporPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaporPagar));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_totalLetras = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nitprov = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_numfactura = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_numorden = new System.Windows.Forms.Button();
            this.cmb_orden = new System.Windows.Forms.ComboBox();
            this.txt_numcompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreprov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Idprov = new System.Windows.Forms.TextBox();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_domicilio = new System.Windows.Forms.TextBox();
            this.dateTimePickerAbono = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefonoprov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.txt_totalLetras);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_iva);
            this.groupBox3.Controls.Add(this.txt_subtotal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 616);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1071, 154);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(948, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 53);
            this.button4.TabIndex = 29;
            this.button4.Text = "Enviar Factura";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_totalLetras
            // 
            this.txt_totalLetras.Location = new System.Drawing.Point(73, 87);
            this.txt_totalLetras.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalLetras.Name = "txt_totalLetras";
            this.txt_totalLetras.Size = new System.Drawing.Size(525, 24);
            this.txt_totalLetras.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(69, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Notas / Observaciones";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(768, 108);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(132, 24);
            this.txt_total.TabIndex = 26;
            // 
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(768, 70);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(132, 24);
            this.txt_iva.TabIndex = 25;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(768, 31);
            this.txt_subtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(132, 24);
            this.txt_subtotal.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(656, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(656, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "IVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(656, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Sub-Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_detalle);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1071, 251);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción de la factura";
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.ID_Producto,
            this.Nombre,
            this.Descripcion,
            this.Precio_unitario,
            this.Total});
            this.dgv_detalle.Location = new System.Drawing.Point(35, 43);
            this.dgv_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.RowHeadersWidth = 51;
            this.dgv_detalle.Size = new System.Drawing.Size(865, 185);
            this.dgv_detalle.TabIndex = 8;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.MinimumWidth = 6;
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio_unitario";
            this.Precio_unitario.MinimumWidth = 6;
            this.Precio_unitario.Name = "Precio_unitario";
            this.Precio_unitario.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nitprov);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txt_numfactura);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.btn_numorden);
            this.groupBox1.Controls.Add(this.cmb_orden);
            this.groupBox1.Controls.Add(this.txt_numcompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombreprov);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Idprov);
            this.groupBox1.Controls.Add(this.dateTimePickerVencimiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_domicilio);
            this.groupBox1.Controls.Add(this.dateTimePickerAbono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_telefonoprov);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1071, 314);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la factura";
            // 
            // txt_nitprov
            // 
            this.txt_nitprov.Location = new System.Drawing.Point(606, 135);
            this.txt_nitprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nitprov.Name = "txt_nitprov";
            this.txt_nitprov.Size = new System.Drawing.Size(253, 24);
            this.txt_nitprov.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(553, 134);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 20);
            this.label21.TabIndex = 32;
            this.label21.Text = "NIT";
            // 
            // txt_numfactura
            // 
            this.txt_numfactura.Location = new System.Drawing.Point(727, 38);
            this.txt_numfactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numfactura.Name = "txt_numfactura";
            this.txt_numfactura.Size = new System.Drawing.Size(132, 24);
            this.txt_numfactura.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(553, 38);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(149, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Numero de factura";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(140, 41);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Órden";
            // 
            // btn_numorden
            // 
            this.btn_numorden.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_numorden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_numorden.BackgroundImage")));
            this.btn_numorden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_numorden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_numorden.Location = new System.Drawing.Point(504, 84);
            this.btn_numorden.Margin = new System.Windows.Forms.Padding(4);
            this.btn_numorden.Name = "btn_numorden";
            this.btn_numorden.Size = new System.Drawing.Size(33, 25);
            this.btn_numorden.TabIndex = 21;
            this.btn_numorden.UseVisualStyleBackColor = false;
            this.btn_numorden.Click += new System.EventHandler(this.btn_numorden_Click);
            // 
            // cmb_orden
            // 
            this.cmb_orden.FormattingEnabled = true;
            this.cmb_orden.Location = new System.Drawing.Point(297, 36);
            this.cmb_orden.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_orden.Name = "cmb_orden";
            this.cmb_orden.Size = new System.Drawing.Size(239, 27);
            this.cmb_orden.TabIndex = 28;
            this.cmb_orden.SelectedIndexChanged += new System.EventHandler(this.cmb_orden_SelectedIndexChanged);
            // 
            // txt_numcompra
            // 
            this.txt_numcompra.Location = new System.Drawing.Point(299, 84);
            this.txt_numcompra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numcompra.Name = "txt_numcompra";
            this.txt_numcompra.Size = new System.Drawing.Size(237, 24);
            this.txt_numcompra.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de compra";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de vencimiento";
            // 
            // txt_nombreprov
            // 
            this.txt_nombreprov.Location = new System.Drawing.Point(297, 132);
            this.txt_nombreprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreprov.Name = "txt_nombreprov";
            this.txt_nombreprov.Size = new System.Drawing.Size(240, 24);
            this.txt_nombreprov.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // txt_Idprov
            // 
            this.txt_Idprov.Location = new System.Drawing.Point(727, 86);
            this.txt_Idprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Idprov.Name = "txt_Idprov";
            this.txt_Idprov.Size = new System.Drawing.Size(136, 24);
            this.txt_Idprov.TabIndex = 11;
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(682, 266);
            this.dateTimePickerVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(177, 24);
            this.dateTimePickerVencimiento.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txt_domicilio
            // 
            this.txt_domicilio.Location = new System.Drawing.Point(297, 180);
            this.txt_domicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_domicilio.Name = "txt_domicilio";
            this.txt_domicilio.Size = new System.Drawing.Size(565, 24);
            this.txt_domicilio.TabIndex = 12;
            // 
            // dateTimePickerAbono
            // 
            this.dateTimePickerAbono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAbono.Location = new System.Drawing.Point(299, 266);
            this.dateTimePickerAbono.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerAbono.Name = "dateTimePickerAbono";
            this.dateTimePickerAbono.Size = new System.Drawing.Size(153, 24);
            this.dateTimePickerAbono.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha abono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Domicilio";
            // 
            // txt_telefonoprov
            // 
            this.txt_telefonoprov.Location = new System.Drawing.Point(297, 222);
            this.txt_telefonoprov.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefonoprov.Name = "txt_telefonoprov";
            this.txt_telefonoprov.Size = new System.Drawing.Size(565, 24);
            this.txt_telefonoprov.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // FacturaporPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 804);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturaporPagar";
            this.Text = "FacturaporPagar";
            this.Load += new System.EventHandler(this.FacturaporPagar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_totalLetras;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nitprov;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_numfactura;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_numorden;
        private System.Windows.Forms.ComboBox cmb_orden;
        private System.Windows.Forms.TextBox txt_numcompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Idprov;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_domicilio;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefonoprov;
        private System.Windows.Forms.Label label5;
    }
}