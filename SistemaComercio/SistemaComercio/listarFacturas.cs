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
    public partial class listarFacturas : Form
    {
        public facturaVenta factura;
        private List<facturaVenta> listaFacturasLocal;
        public Cliente cliente { get; set; }
        public int opc { get; set; }
        public Pago pago { get; set; }
        public listarFacturas(Cliente cliente,int opc)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.opc = opc;
        }
        public listarFacturas(int opc,Pago pago)
        {
            InitializeComponent();
            this.opc = opc;
            this.pago = pago;
        }
        private void listarFacturas_Load(object sender, EventArgs e)
        {

            cargarGrilla(opc);
            dgvFacturas.Columns[0].Visible = false;


        }

        private void cargarGrilla(int opc)
        {
            facturaventaNegocio negocio = new facturaventaNegocio();

            try
            {
                if(opc==1)
                {
                    listaFacturasLocal = negocio.listarFacturas(cliente);
                    dgvFacturas.DataSource = listaFacturasLocal;
                }
               
                else if(opc==2)
                {
                    listaFacturasLocal = negocio.listarFacturas(pago);
                    dgvFacturas.DataSource = listaFacturasLocal;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            factura = (facturaVenta)dgvFacturas.CurrentRow.DataBoundItem;
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvFacturas.DataSource = listaFacturasLocal;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 3)
                {
                    List<facturaVenta> lista;
                    lista = listaFacturasLocal.FindAll(X => X.cliente.nombre.Contains(txtBusqueda.Text) || X.numeroFactura.Contains(txtBusqueda.Text));
                    dgvFacturas.DataSource = lista;
                }
            }
        }
    }
}
