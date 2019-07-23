namespace SistemaComercio
{
    partial class frmagProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmagProveedor));
            this.cbxPago = new System.Windows.Forms.ComboBox();
            this.lvlPago = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cbxIVA = new System.Windows.Forms.ComboBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxPago
            // 
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Items.AddRange(new object[] {
            "Contraentrega",
            "15 dias",
            "30 dias",
            "45 dias",
            "60 dias",
            "75 dias",
            "90 dias"});
            this.cbxPago.Location = new System.Drawing.Point(127, 393);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(171, 21);
            this.cbxPago.TabIndex = 40;
            // 
            // lvlPago
            // 
            this.lvlPago.AutoSize = true;
            this.lvlPago.Location = new System.Drawing.Point(32, 401);
            this.lvlPago.Name = "lvlPago";
            this.lvlPago.Size = new System.Drawing.Size(96, 13);
            this.lvlPago.TabIndex = 39;
            this.lvlPago.Text = "Condicion de pago";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(278, 439);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 44);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(54, 439);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 44);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 303);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(206, 20);
            this.txtEmail.TabIndex = 36;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 310);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 255);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(206, 20);
            this.txtTelefono.TabIndex = 34;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(32, 262);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 33;
            this.lblTelefono.Text = "Telefono";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "Ciudad Autonoma de Buenos Aires",
            "Entre Rios",
            "Corrientes",
            "Catamarca",
            "Misiones",
            "Formosa",
            "Chaco",
            "Chubut",
            "Rio Negro",
            "Tierra del Fuego",
            "Neuquen",
            "Santa Cruz",
            "Jujuy ",
            "Salta",
            "San Juan",
            "Mendoza",
            "La Rioja",
            "Santa Fe",
            "Cordoba",
            "La Pampa",
            "Tucuman"});
            this.cbxProvincia.Location = new System.Drawing.Point(92, 200);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(206, 21);
            this.cbxProvincia.TabIndex = 32;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(32, 208);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 31;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(92, 153);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(309, 20);
            this.txtLocalidad.TabIndex = 30;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(30, 156);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 29;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cbxIVA
            // 
            this.cbxIVA.FormattingEnabled = true;
            this.cbxIVA.Items.AddRange(new object[] {
            "Responsable Inscripto",
            "Monotributista",
            "Consumidor Final",
            "Exento"});
            this.cbxIVA.Location = new System.Drawing.Point(127, 354);
            this.cbxIVA.Name = "cbxIVA";
            this.cbxIVA.Size = new System.Drawing.Size(171, 21);
            this.cbxIVA.TabIndex = 28;
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(32, 33);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(56, 13);
            this.lblCUIT.TabIndex = 27;
            this.lblCUIT.Text = "CUIT/DNI";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(92, 107);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(309, 20);
            this.txtDireccion.TabIndex = 26;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(92, 63);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(309, 20);
            this.txtCliente.TabIndex = 25;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(92, 26);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(206, 20);
            this.txtCuit.TabIndex = 24;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(32, 362);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(89, 13);
            this.lblIVA.TabIndex = 23;
            this.lblIVA.Text = "Condicion de IVA";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(32, 110);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(32, 70);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 13);
            this.lblCliente.TabIndex = 21;
            this.lblCliente.Text = "Proveedor";
            // 
            // frmagProveedor
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
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cbxIVA);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmagProveedor";
            this.Text = "frmagProveedor";
            this.Load += new System.EventHandler(this.frmagProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPago;
        private System.Windows.Forms.Label lvlPago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cbxIVA;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCliente;
    }
}