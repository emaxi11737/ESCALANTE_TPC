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
using Negocio;
namespace SistemaComercio
{
    public partial class frmPagos : Form
    {
        public List<Pago> listado { get; set; }
        public frmPagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagPago ventana = new frmagPago();
            ventana.ShowDialog();
            cargarGrilla();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            pagoNegocio negocio = new pagoNegocio();
            try
            {
                cargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarGrilla()
        {
            pagoNegocio negocio = new pagoNegocio();
            listado = negocio.listarPagos();
            dgvPagos.DataSource = null;
            dgvPagos.DataSource = listado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagoNegocio negocio = new pagoNegocio();
            facturaventaNegocio negocio2 = new facturaventaNegocio();
            negocio.eliminarPago((Pago)dgvPagos.CurrentRow.DataBoundItem);
            negocio2.modificarPagoFactura((Pago)dgvPagos.CurrentRow.DataBoundItem);
            
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarFacturas ventana = new listarFacturas(2, (Pago)dgvPagos.CurrentRow.DataBoundItem);
            ventana.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listarPagos ventana = new listarPagos((Pago)dgvPagos.CurrentRow.DataBoundItem);
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
