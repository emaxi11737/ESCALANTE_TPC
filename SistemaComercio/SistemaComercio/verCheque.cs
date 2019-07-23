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
    public partial class verCheque : Form
    {
        public List<Cheque> listaCheques { get; set; }
        public pagoNegocio negocio { get; set; }
        public verCheque()
        {
            InitializeComponent();
            
        }
        public verCheque(metodoPago p)
        {
            InitializeComponent();
            listaCheques = new List<Cheque>();
            negocio = new pagoNegocio();
            listaCheques = negocio.listarCheques(p);

        }
        public verCheque(Cheque c)
        {
            InitializeComponent();
            listaCheques = new List<Cheque>();
            listaCheques.Add(c);
        }

        private void verCheque_Load(object sender, EventArgs e)
        {
            dgvCheques.DataSource = listaCheques;
        }
    }
}
