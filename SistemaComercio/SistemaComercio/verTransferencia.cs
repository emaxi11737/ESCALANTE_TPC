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
    public partial class verTransferencia : Form
    {
        public List<Transferencia> listaTransferencias { get; set; }
        public pagoNegocio pagonegocio { get; set; }
        public verTransferencia(metodoPago p)
        {
            InitializeComponent();
            listaTransferencias = new List<Transferencia>();
            pagonegocio = new pagoNegocio();
             listaTransferencias=pagonegocio.listarTransferencias(p);
        }
        public verTransferencia(Transferencia t)
        {
            InitializeComponent();
            listaTransferencias = new List<Transferencia>();
            listaTransferencias.Add(t);
        }

        private void verTransferencia_Load(object sender, EventArgs e)
        {
            dgvTransferencias.DataSource = listaTransferencias;
        }
    }
}
