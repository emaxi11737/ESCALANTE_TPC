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
    public partial class frmTratamientos : Form
    {
        private List<Tratamiento> listatratamientosLocal;
        public frmTratamientos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagTratamiento ventana = new frmagTratamiento();
            ventana.ShowDialog();
        }

        private void frmTratamientos_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            tratamientoNegocio negocio = new tratamientoNegocio();
            try
            {
                listatratamientosLocal = negocio.listarTratamientos();
                dgvTratamientos.DataSource = listatratamientosLocal;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cert = listatratamientosLocal.ElementAt(dgvTratamientos.CurrentCell.RowIndex).numeroTratamiento;
            listarTratamientos ventana = new listarTratamientos(cert);
            ventana.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cert = listatratamientosLocal.ElementAt(dgvTratamientos.CurrentCell.RowIndex).numeroTratamiento;
            listarTratamientos ventana = new listarTratamientos(cert,2);
            ventana.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cert = listatratamientosLocal.ElementAt(dgvTratamientos.CurrentCell.RowIndex).numeroTratamiento;
            listarTratamientos ventana = new listarTratamientos(cert,1);
            ventana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
