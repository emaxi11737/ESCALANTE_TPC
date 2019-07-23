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
    public partial class listarPagos : Form
    {
        public List<metodoPago> metodoPagos { get; set; }
        public Pago pago { get; set; }
        public listarPagos(Pago pago)
        {
            InitializeComponent();
            this.pago = pago;
        }

        private void listarPagos_Load(object sender, EventArgs e)
        {
            pagoNegocio negocio = new pagoNegocio();
            metodoPagos = new List<metodoPago>();
            metodoPagos.AddRange(negocio.listarCheques(pago));
            metodoPagos.AddRange(negocio.listarTransferencias(pago));
            metodoPagos.AddRange(negocio.listarEfectivo(pago));
            dgvPagos.DataSource = metodoPagos;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodoPago p = ((metodoPago)dgvPagos.CurrentRow.DataBoundItem);
           
                if (p.tipo=="Transferencia")
                {
                    verTransferencia ventana = new verTransferencia(p);
                    ventana.ShowDialog();
                }
            

                if (p.tipo == "Cheque")
                {
                    verCheque ventana = new verCheque(p);
                    ventana.ShowDialog();
                }
            
            
                if (p.tipo == "Efectivo")
                {
                    verEfectivo ventana = new verEfectivo(p);
                    ventana.ShowDialog();
                }
            

        }
    }
    }


