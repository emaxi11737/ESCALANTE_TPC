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
    public partial class agregarmPago : Form
    {
        public Transferencia t { get; set; }
        public Cheque c { get; set; }
        public Efectivo ef { get; set; }
        public agregarmPago()
        {
            InitializeComponent();
            t = null;
            c = null;
            ef = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
             
             
            
            if(cboPago.Text=="Transferencia")
            {
                t = new Transferencia();
                agregarTransferencias ventana = new agregarTransferencias();
                ventana.ShowDialog();
                if(ventana.transferencia!=null)
                {
                    t = ventana.transferencia;
                    this.Close();
                }
            }
            else if (cboPago.Text == "Cheque")
            {
                c = new Cheque();
                AgregarCheques ventana = new AgregarCheques();
                ventana.ShowDialog();
                if(ventana.cheque!=null)
                {
                    c = ventana.cheque;
                    this.Close();
                }
            }
            else if (cboPago.Text == "Efectivo")
            {
                ef = new Efectivo();
                agregarEfectivo ventana = new agregarEfectivo();
                ventana.ShowDialog();
                if(ventana.importe!=0)
                {
                    ef.importe = ventana.importe;
                    this.Close();
                }
            }
        }
    }
}
