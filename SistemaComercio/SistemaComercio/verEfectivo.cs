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
    public partial class verEfectivo : Form
    {
        public List<Efectivo> efectivo { get; set; }
        public pagoNegocio  negocio { get; set; }
        public verEfectivo(metodoPago p)
        {
            InitializeComponent();
            efectivo = new List<Efectivo>();
            negocio = new pagoNegocio();
            efectivo = negocio.listarEfectivo(p);
        }
        public verEfectivo(Efectivo e)
        {
            InitializeComponent();
            efectivo = new List<Efectivo>();
            efectivo.Add(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verEfectivo_Load(object sender, EventArgs e)
        {
            dgvEfectivo.DataSource = null;
            dgvEfectivo.DataSource = efectivo;
        }
    }
}
