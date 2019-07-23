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
    public partial class frmEmpleados : Form
    {
        private List<Empleado> listaEmpleadosLocal;
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {
            empleadoNegocio negocio = new empleadoNegocio();
            try
            {
                listaEmpleadosLocal = negocio.listarEmpleado();
                dgvEmpleados.DataSource = listaEmpleadosLocal;
                dgvEmpleados.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagEmpleado ventana = new frmagEmpleado();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                frmagEmpleado modificar = new frmagEmpleado((Empleado)dgvEmpleados.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empleadoNegocio negocio = new empleadoNegocio();
            negocio.eliminarEmpleado((Empleado)dgvEmpleados.CurrentRow.DataBoundItem);
            this.Close();
            frmEmpleados ventana = new frmEmpleados();
            ventana.Show();
        }
    }
}

