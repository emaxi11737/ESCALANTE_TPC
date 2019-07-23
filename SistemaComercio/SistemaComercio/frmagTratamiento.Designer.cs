namespace SistemaComercio
{
    partial class frmagTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagTratamiento));
            this.dgvCertificados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtnumeroCertificado = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnumeroTratamiento = new System.Windows.Forms.TextBox();
            this.txtcantidadPallets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcantidadMadera = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidadCajones = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCertificados
            // 
            this.dgvCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificados.Location = new System.Drawing.Point(305, 91);
            this.dgvCertificados.MultiSelect = false;
            this.dgvCertificados.Name = "dgvCertificados";
            this.dgvCertificados.Size = new System.Drawing.Size(483, 347);
            this.dgvCertificados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Numero de Certificado";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Pallets",
            "Cajones",
            "Madera de acomodacion"});
            this.cboTipo.Location = new System.Drawing.Point(357, 20);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(357, 58);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "0";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(584, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(63, 20);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtnumeroCertificado
            // 
            this.txtnumeroCertificado.Location = new System.Drawing.Point(656, 58);
            this.txtnumeroCertificado.Name = "txtnumeroCertificado";
            this.txtnumeroCertificado.Size = new System.Drawing.Size(63, 20);
            this.txtnumeroCertificado.TabIndex = 9;
            this.txtnumeroCertificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroCertificado_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(132, 150);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(85, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(795, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 43);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(795, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 43);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnumeroTratamiento
            // 
            this.txtnumeroTratamiento.Location = new System.Drawing.Point(132, 100);
            this.txtnumeroTratamiento.Name = "txtnumeroTratamiento";
            this.txtnumeroTratamiento.Size = new System.Drawing.Size(63, 20);
            this.txtnumeroTratamiento.TabIndex = 18;
            this.txtnumeroTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroTratamiento_KeyPress);
            // 
            // txtcantidadPallets
            // 
            this.txtcantidadPallets.Location = new System.Drawing.Point(132, 193);
            this.txtcantidadPallets.Name = "txtcantidadPallets";
            this.txtcantidadPallets.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadPallets.TabIndex = 17;
            this.txtcantidadPallets.Text = "0";
            this.txtcantidadPallets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadPallets_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Numero de tratamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cantidad de pallets";
            // 
            // txtcantidadMadera
            // 
            this.txtcantidadMadera.Location = new System.Drawing.Point(132, 286);
            this.txtcantidadMadera.Name = "txtcantidadMadera";
            this.txtcantidadMadera.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadMadera.TabIndex = 20;
            this.txtcantidadMadera.Text = "0";
            this.txtcantidadMadera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadMadera_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cantidad de madera";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad de cajones";
            // 
            // txtcantidadCajones
            // 
            this.txtcantidadCajones.Location = new System.Drawing.Point(132, 239);
            this.txtcantidadCajones.Name = "txtcantidadCajones";
            this.txtcantidadCajones.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadCajones.TabIndex = 20;
            this.txtcantidadCajones.Text = "0";
            this.txtcantidadCajones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidadCajones_KeyPress);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(142, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmagTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtcantidadCajones);
            this.Controls.Add(this.txtcantidadMadera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnumeroTratamiento);
            this.Controls.Add(this.txtcantidadPallets);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtnumeroCertificado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCertificados);
            this.Name = "frmagTratamiento";
            this.Text = "agregarTratamiento";
            this.Load += new System.EventHandler(this.frmagTratamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCertificados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtnumeroCertificado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnumeroTratamiento;
        private System.Windows.Forms.TextBox txtcantidadPallets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcantidadMadera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidadCajones;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}