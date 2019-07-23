namespace SistemaComercio
{
    partial class frmagfactVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagfactVenta));
            this.cbotipoComprobante = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFactura = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumeroFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtimportenoGravado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotalFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIVA21 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtimporteGravado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCondicion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvRemito = new System.Windows.Forms.DataGridView();
            this.btnagregarRemito = new System.Windows.Forms.Button();
            this.btneliminarRemito = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).BeginInit();
            this.SuspendLayout();
            // 
            // cbotipoComprobante
            // 
            this.cbotipoComprobante.FormattingEnabled = true;
            this.cbotipoComprobante.Items.AddRange(new object[] {
            "Factura A",
            "Factura B",
            "Nota de Credito",
            "Nota de Debito"});
            this.cbotipoComprobante.Location = new System.Drawing.Point(126, 118);
            this.cbotipoComprobante.Name = "cbotipoComprobante";
            this.cbotipoComprobante.Size = new System.Drawing.Size(206, 21);
            this.cbotipoComprobante.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Tipo de comprobante";
            // 
            // dtpFactura
            // 
            this.dtpFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFactura.Location = new System.Drawing.Point(126, 199);
            this.dtpFactura.Name = "dtpFactura";
            this.dtpFactura.Size = new System.Drawing.Size(122, 20);
            this.dtpFactura.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 55;
            this.label13.Text = "Fecha de factura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "CUIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Cliente";
            // 
            // txtnumeroFactura
            // 
            this.txtnumeroFactura.Location = new System.Drawing.Point(126, 164);
            this.txtnumeroFactura.Name = "txtnumeroFactura";
            this.txtnumeroFactura.Size = new System.Drawing.Size(143, 20);
            this.txtnumeroFactura.TabIndex = 50;
            this.txtnumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroFactura_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Numero de factura";
            // 
            // txtimportenoGravado
            // 
            this.txtimportenoGravado.Location = new System.Drawing.Point(379, 240);
            this.txtimportenoGravado.Name = "txtimportenoGravado";
            this.txtimportenoGravado.Size = new System.Drawing.Size(68, 20);
            this.txtimportenoGravado.TabIndex = 66;
            this.txtimportenoGravado.Text = "0";
            this.txtimportenoGravado.TextChanged += new System.EventHandler(this.txtimportenoGravado_TextChanged);
            this.txtimportenoGravado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimportenoGravado_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Importe no gravado";
            // 
            // txttotalFactura
            // 
            this.txttotalFactura.Location = new System.Drawing.Point(381, 282);
            this.txttotalFactura.Name = "txttotalFactura";
            this.txttotalFactura.ReadOnly = true;
            this.txttotalFactura.Size = new System.Drawing.Size(68, 20);
            this.txttotalFactura.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Total factura";
            // 
            // txtIVA21
            // 
            this.txtIVA21.Location = new System.Drawing.Point(126, 282);
            this.txtIVA21.Name = "txtIVA21";
            this.txtIVA21.ReadOnly = true;
            this.txtIVA21.Size = new System.Drawing.Size(68, 20);
            this.txtIVA21.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "IVA 21%";
            // 
            // txtimporteGravado
            // 
            this.txtimporteGravado.Location = new System.Drawing.Point(126, 240);
            this.txtimporteGravado.Name = "txtimporteGravado";
            this.txtimporteGravado.ReadOnly = true;
            this.txtimporteGravado.Size = new System.Drawing.Size(68, 20);
            this.txtimporteGravado.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Importe gravado";
            // 
            // cboCondicion
            // 
            this.cboCondicion.FormattingEnabled = true;
            this.cboCondicion.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45",
            "60",
            "75",
            "90"});
            this.cboCondicion.Location = new System.Drawing.Point(126, 330);
            this.cboCondicion.Name = "cboCondicion";
            this.cboCondicion.Size = new System.Drawing.Size(171, 21);
            this.cboCondicion.TabIndex = 70;
            this.cboCondicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Condicion de pago";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(262, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 44);
            this.button2.TabIndex = 68;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(43, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 67;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(516, 231);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(536, 310);
            this.dgvProductos.TabIndex = 96;
            // 
            // dgvRemito
            // 
            this.dgvRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemito.Location = new System.Drawing.Point(516, 28);
            this.dgvRemito.MultiSelect = false;
            this.dgvRemito.Name = "dgvRemito";
            this.dgvRemito.Size = new System.Drawing.Size(536, 191);
            this.dgvRemito.TabIndex = 97;
            // 
            // btnagregarRemito
            // 
            this.btnagregarRemito.Location = new System.Drawing.Point(516, -1);
            this.btnagregarRemito.Name = "btnagregarRemito";
            this.btnagregarRemito.Size = new System.Drawing.Size(100, 23);
            this.btnagregarRemito.TabIndex = 98;
            this.btnagregarRemito.Text = "Agregar Remito";
            this.btnagregarRemito.UseVisualStyleBackColor = true;
            this.btnagregarRemito.Click += new System.EventHandler(this.btnagregarRemito_Click);
            // 
            // btneliminarRemito
            // 
            this.btneliminarRemito.Location = new System.Drawing.Point(622, -1);
            this.btneliminarRemito.Name = "btneliminarRemito";
            this.btneliminarRemito.Size = new System.Drawing.Size(104, 23);
            this.btneliminarRemito.TabIndex = 99;
            this.btneliminarRemito.Text = "Eliminar Remito";
            this.btneliminarRemito.UseVisualStyleBackColor = true;
            this.btneliminarRemito.Click += new System.EventHandler(this.btneliminarRemito_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(126, 46);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 100;
            // 
            // frmagfactVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 553);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btneliminarRemito);
            this.Controls.Add(this.btnagregarRemito);
            this.Controls.Add(this.dgvRemito);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.cboCondicion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtimportenoGravado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttotalFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIVA21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtimporteGravado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbotipoComprobante);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpFactura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumeroFactura);
            this.Controls.Add(this.label1);
            this.Name = "frmagfactVenta";
            this.Text = "frmagfactVenta";
            this.Load += new System.EventHandler(this.frmagfactVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotipoComprobante;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtimportenoGravado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotalFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIVA21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtimporteGravado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCondicion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvRemito;
        private System.Windows.Forms.Button btnagregarRemito;
        private System.Windows.Forms.Button btneliminarRemito;
        private System.Windows.Forms.ComboBox cboCliente;
    }
}