namespace SistemaComercio
{
    partial class AgregarCheques
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechaCobro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(155, 56);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(184, 20);
            this.txtNum.TabIndex = 0;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de cheque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco";
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(155, 116);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(184, 20);
            this.txtBanco.TabIndex = 2;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(155, 228);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(184, 20);
            this.txtImporte.TabIndex = 4;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(155, 286);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(184, 20);
            this.txtLocalidad.TabIndex = 6;
            this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha de deposito";
            // 
            // dtpfechaCobro
            // 
            this.dtpfechaCobro.Location = new System.Drawing.Point(155, 174);
            this.dtpfechaCobro.Name = "dtpfechaCobro";
            this.dtpfechaCobro.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaCobro.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CUIT del emisor";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(155, 351);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(184, 20);
            this.txtCUIT.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AgregarCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.dtpfechaCobro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Name = "AgregarCheques";
            this.Text = "AgregarCheques";
            this.Load += new System.EventHandler(this.AgregarCheques_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfechaCobro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}