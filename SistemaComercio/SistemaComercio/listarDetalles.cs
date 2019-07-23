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
using Dominio;

namespace SistemaComercio
{
    public partial class listarDetalles : Form
    {
        public string num { get; set; }
        private List<Detalle> listaDetallesLocal;
        public listarDetalles(string nume)
        {
            InitializeComponent();
            this.num = nume;
        }

        private void listarDetalles_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            //dgvDetalles.Columns[0].Visible = false;
            //dgvDetalles.Columns[5].Visible = false;
        }
        private void cargarGrilla()
        {
            detalleNegocio negocio = new detalleNegocio();
            try
            {
                listaDetallesLocal = negocio.listarDetalles(num);
                dgvDetalles.DataSource = listaDetallesLocal;
   




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
