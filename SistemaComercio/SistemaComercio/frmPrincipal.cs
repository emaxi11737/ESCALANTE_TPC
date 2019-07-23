using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace SistemaComercio
{
    public partial class frmPrincipal : Form
    {
        public string tipo { get; set; }
        public frmPrincipal(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCliente ventana = new frmCliente();
            ventana.Show();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProducto ventana = new frmProducto();
            ventana.Show();
            
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados ventana = new frmEmpleados();
            ventana.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras ventana = new frmCompras();
            ventana.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventana = new frmVentas();
            ventana.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            frmTratamientos ventana = new frmTratamientos();
            ventana.Show();
        }

        private void btnFletes_Click(object sender, EventArgs e)
        {
            frmDespachos ventana = new frmDespachos();
            ventana.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            frmPagos ventana = new frmPagos();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProveedor ventana = new frmProveedor();
            ventana.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(tipo == "User")
            {
                btnUsuarios.Visible = false;
            }
            if (tipo == "Admin")
            {
                btnUsuarios.Visible = true;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ventana = new frmUsuarios();
            ventana.ShowDialog();
        }
    }
}
