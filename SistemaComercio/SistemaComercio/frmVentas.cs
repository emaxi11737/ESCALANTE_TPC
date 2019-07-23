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
    public partial class frmVentas : Form
    {
        public List<facturaVenta> listafacturaslocal;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagfactVenta ventana = new frmagfactVenta();
            ventana.ShowDialog();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
         

        }
        private void cargarGrilla()
        {
            facturaventaNegocio negocio = new facturaventaNegocio();
            try
            {
                listafacturaslocal = negocio.listarFacturas();
                dgvFacturas.DataSource = listafacturaslocal;
                dgvFacturas.Columns[0].Visible = false;
               
                dgvFacturas.Columns[6].Visible = false;
                dgvFacturas.Columns[9].Visible = false;


                colorearGrilla();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void colorearGrilla()
        {
            foreach (DataGridViewRow row in dgvFacturas.Rows)
            {
                DateTime fechaVencimiento = Convert.ToDateTime(dgvFacturas[8, row.Index].Value);
                DateTime hoy = DateTime.Now.Date;
                TimeSpan dias = hoy.Subtract(fechaVencimiento);
                int diasnum = dias.Days;



                foreach (DataGridViewColumn col in dgvFacturas.Columns)
                {
                   

                    if ((int)dgvFacturas[12, row.Index].Value - diasnum <=5 && dgvFacturas[11, row.Index].Value.ToString() == "Impago")
                    {
                        dgvFacturas[col.Index, row.Index].Style.BackColor = Color.Yellow;
                    }
                    if (diasnum>= (int)dgvFacturas[12, row.Index].Value && dgvFacturas[11, row.Index].Value.ToString() == "Impago")
                    {
                        dgvFacturas[col.Index, row.Index].Style.BackColor = Color.Red;
                    }
                    if (dgvFacturas[11, row.Index].Value.ToString() == "Pago")
                    {
                        dgvFacturas[col.Index, row.Index].Style.BackColor = Color.Green;
                       
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
