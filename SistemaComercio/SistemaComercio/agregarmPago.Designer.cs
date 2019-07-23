namespace SistemaComercio
{
    partial class agregarmPago
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
            this.cboPago = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboPago
            // 
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Items.AddRange(new object[] {
            "Transferencia",
            "Efectivo",
            "Cheque"});
            this.cboPago.Location = new System.Drawing.Point(63, 48);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(285, 21);
            this.cboPago.TabIndex = 0;
            this.cboPago.Text = "Cheque";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // agregarmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboPago);
            this.Name = "agregarmPago";
            this.Text = "agregarmPago";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}