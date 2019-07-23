namespace SistemaComercio
{
    partial class frmagProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagProducto));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblprecioUnitario = new System.Windows.Forms.Label();
            this.txtprecioUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecioCompra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 39);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(340, 56);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 46);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(253, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(41, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprecioUnitario
            // 
            this.lblprecioUnitario.AutoSize = true;
            this.lblprecioUnitario.Location = new System.Drawing.Point(13, 183);
            this.lblprecioUnitario.Name = "lblprecioUnitario";
            this.lblprecioUnitario.Size = new System.Drawing.Size(74, 13);
            this.lblprecioUnitario.TabIndex = 23;
            this.lblprecioUnitario.Text = "Precio unitario";
            // 
            // txtprecioUnitario
            // 
            this.txtprecioUnitario.Location = new System.Drawing.Point(108, 180);
            this.txtprecioUnitario.Name = "txtprecioUnitario";
            this.txtprecioUnitario.Size = new System.Drawing.Size(170, 20);
            this.txtprecioUnitario.TabIndex = 22;
            this.txtprecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioUnitario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio compra";
            // 
            // txtprecioCompra
            // 
            this.txtprecioCompra.Location = new System.Drawing.Point(110, 134);
            this.txtprecioCompra.Name = "txtprecioCompra";
            this.txtprecioCompra.Size = new System.Drawing.Size(170, 20);
            this.txtprecioCompra.TabIndex = 28;
            this.txtprecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecioCompra_KeyPress);
            // 
            // frmagProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprecioCompra);
            this.Controls.Add(this.lblprecioUnitario);
            this.Controls.Add(this.txtprecioUnitario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmagProducto";
            this.Text = "frmagProducto";
            this.Load += new System.EventHandler(this.frmagProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblprecioUnitario;
        private System.Windows.Forms.TextBox txtprecioUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecioCompra;
    }
}