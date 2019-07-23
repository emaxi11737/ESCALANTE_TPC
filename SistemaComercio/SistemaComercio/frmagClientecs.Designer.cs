namespace SistemaComercio
{
    partial class frmagClientecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagClientecs));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.cbxIVA = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxPago = new System.Windows.Forms.ComboBox();
            this.lvlPago = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(29, 71);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(29, 111);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(29, 260);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(89, 13);
            this.lblIVA.TabIndex = 2;
            this.lblIVA.Text = "Condicion de IVA";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(89, 27);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(206, 20);
            this.txtCuit.TabIndex = 3;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 108);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(309, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(29, 34);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(56, 13);
            this.lblCUIT.TabIndex = 6;
            this.lblCUIT.Text = "CUIT/DNI";
            // 
            // cbxIVA
            // 
            this.cbxIVA.FormattingEnabled = true;
            this.cbxIVA.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Monotributista",
            "Consumidor Final",
            "Exento"});
            this.cbxIVA.Location = new System.Drawing.Point(124, 252);
            this.cbxIVA.Name = "cbxIVA";
            this.cbxIVA.Size = new System.Drawing.Size(171, 21);
            this.cbxIVA.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(89, 153);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 160);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 208);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(32, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 44);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(256, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 44);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxPago
            // 
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Items.AddRange(new object[] {
            "Contra entrega",
            "15 dias",
            "30 dias",
            "45 dias",
            "60 dias",
            "75 dias",
            "90 dias"});
            this.cbxPago.Location = new System.Drawing.Point(124, 291);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(171, 21);
            this.cbxPago.TabIndex = 20;
            // 
            // lvlPago
            // 
            this.lvlPago.AutoSize = true;
            this.lvlPago.Location = new System.Drawing.Point(29, 299);
            this.lvlPago.Name = "lvlPago";
            this.lvlPago.Size = new System.Drawing.Size(96, 13);
            this.lvlPago.TabIndex = 19;
            this.lvlPago.Text = "Condicion de pago";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(89, 64);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(309, 20);
            this.txtCliente.TabIndex = 4;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // frmagClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 496);
            this.Controls.Add(this.cbxPago);
            this.Controls.Add(this.lvlPago);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cbxIVA);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmagClientecs";
            this.Text = "frmagClientecs";
            this.Load += new System.EventHandler(this.frmagClientecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.ComboBox cbxIVA;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxPago;
        private System.Windows.Forms.Label lvlPago;
        private System.Windows.Forms.TextBox txtCliente;
    }
}