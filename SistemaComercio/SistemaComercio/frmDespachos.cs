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
    public partial class frmDespachos : Form
    {
        private List<Remito> listaRemitosLocal;
        public frmDespachos()
        {
            InitializeComponent();
        }

        private void frmDespachos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            remitoNegocio negocio = new remitoNegocio();
            try
            {
                listaRemitosLocal = negocio.listarRemitos();
                dgvRemitos.DataSource = listaRemitosLocal;
                dgvRemitos.Columns[0].Visible = false;
                dgvRemitos.Columns[5].Visible = false;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagRemito ventana = new frmagRemito();
            ventana.ShowDialog();
            cargarGrilla();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string rem = listaRemitosLocal.ElementAt(dgvRemitos.CurrentCell.RowIndex).numeroRemito;
            listarDetalles ventana = new listarDetalles(rem);
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remitoNegocio negocio = new remitoNegocio();
            negocio.eliminarRemito((Remito)dgvRemitos.CurrentRow.DataBoundItem);
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remitoNegocio negocio = new remitoNegocio();
            negocio.modificarRemito((Remito)dgvRemitos.CurrentRow.DataBoundItem);
            cargarGrilla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
