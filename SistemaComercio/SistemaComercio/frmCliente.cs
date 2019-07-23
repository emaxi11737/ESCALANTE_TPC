using System;
using Dominio;
using Negocio;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio
{
    public partial class frmCliente : Form
    {
        private List<Cliente> listaClientesLocal;
       
        public frmCliente()
        {
            
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmagClientecs ventana = new frmagClientecs();
            ventana.ShowDialog();
            cargarGrilla();
  



        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cargarGrilla();
           
        }
        private void cargarGrilla()
        {
            clienteNegocio negocio = new clienteNegocio();
            try
            {
                listaClientesLocal = negocio.listarClientes();
                dgvClientes.DataSource = listaClientesLocal;
                dgvClientes.Columns[0].Visible = false;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                frmagClientecs modificar = new frmagClientecs((Cliente)dgvClientes.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clienteNegocio negocio = new clienteNegocio();
            negocio.eliminarCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
            cargarGrilla();
        }

    }
}
