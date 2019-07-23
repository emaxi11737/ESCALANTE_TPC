namespace SistemaComercio
{
    partial class verEfectivo
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
            this.dgvEfectivo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEfectivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEfectivo
            // 
            this.dgvEfectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEfectivo.Location = new System.Drawing.Point(12, 22);
            this.dgvEfectivo.Name = "dgvEfectivo";
            this.dgvEfectivo.Size = new System.Drawing.Size(516, 100);
            this.dgvEfectivo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEfectivo);
            this.Name = "verEfectivo";
            this.Text = "verEfectivo";
            this.Load += new System.EventHandler(this.verEfectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEfectivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEfectivo;
        private System.Windows.Forms.Button button1;
    }
}