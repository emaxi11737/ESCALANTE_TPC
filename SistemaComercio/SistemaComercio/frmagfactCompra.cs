using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using AccesoDatos;

namespace SistemaComercio
{
    public partial class frmagfactCompra : Form
    {
        public frmagfactCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmagfactCompra_Load(object sender, EventArgs e)
        {
            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

            try
            {
                cboProveedor.DataSource = ProveedorNegocio.listarProveedores();
                cboProveedor.DisplayMember = "NOMBRE";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
