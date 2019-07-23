namespace SistemaComercio
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnFletes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblTratamientos = new System.Windows.Forms.Label();
            this.lblFletes = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(260, 33);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(150, 131);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(260, 244);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(150, 131);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(37, 33);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(150, 131);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.BackColor = System.Drawing.Color.White;
            this.btnTratamientos.Image = ((System.Drawing.Image)(resources.GetObject("btnTratamientos.Image")));
            this.btnTratamientos.Location = new System.Drawing.Point(37, 467);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(150, 136);
            this.btnTratamientos.TabIndex = 7;
            this.btnTratamientos.UseVisualStyleBackColor = false;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnFletes
            // 
            this.btnFletes.BackColor = System.Drawing.Color.White;
            this.btnFletes.Image = ((System.Drawing.Image)(resources.GetObject("btnFletes.Image")));
            this.btnFletes.Location = new System.Drawing.Point(260, 467);
            this.btnFletes.Name = "btnFletes";
            this.btnFletes.Size = new System.Drawing.Size(150, 136);
            this.btnFletes.TabIndex = 8;
            this.btnFletes.UseVisualStyleBackColor = false;
            this.btnFletes.Click += new System.EventHandler(this.btnFletes_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.White;
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.Location = new System.Drawing.Point(37, 244);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(150, 136);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(72, 176);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(73, 14);
            this.lblProductos.TabIndex = 10;
            this.lblProductos.Text = "Productos";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(311, 176);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(54, 14);
            this.lblClientes.TabIndex = 11;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(311, 389);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(46, 14);
            this.lblVentas.TabIndex = 14;
            this.lblVentas.Text = "Ventas";
            // 
            // lblTratamientos
            // 
            this.lblTratamientos.AutoSize = true;
            this.lblTratamientos.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamientos.Location = new System.Drawing.Point(72, 624);
            this.lblTratamientos.Name = "lblTratamientos";
            this.lblTratamientos.Size = new System.Drawing.Size(85, 14);
            this.lblTratamientos.TabIndex = 16;
            this.lblTratamientos.Text = "Tratamientos";
            // 
            // lblFletes
            // 
            this.lblFletes.AutoSize = true;
            this.lblFletes.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFletes.Location = new System.Drawing.Point(296, 624);
            this.lblFletes.Name = "lblFletes";
            this.lblFletes.Size = new System.Drawing.Size(69, 14);
            this.lblFletes.TabIndex = 17;
            this.lblFletes.Text = "Despachos";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Font = new System.Drawing.Font("Lovelo Black", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagos.Location = new System.Drawing.Point(91, 389);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(42, 14);
            this.lblPagos.TabIndex = 18;
            this.lblPagos.Text = "Pagos";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(374, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios.TabIndex = 19;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(461, 665);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblFletes);
            this.Controls.Add(this.lblTratamientos);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnFletes);
            this.Controls.Add(this.btnTratamientos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnFletes;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblTratamientos;
        private System.Windows.Forms.Label lblFletes;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Button btnUsuarios;
    }
}