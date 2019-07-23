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
    public partial class listarRemito : Form
    {
        public Remito remito { get; set; }
        private List<Remito> listaremitoslocal;
        private Cliente clientelocal;
        
        public listarRemito()
        {
            InitializeComponent();
        }
        public listarRemito(Cliente cliente)
        {
            InitializeComponent();
            clientelocal = cliente;
        }

        private void listarRemito_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            remito = null;
        }
        private void cargarGrilla()
        {
            remitoNegocio negocio = new remitoNegocio();
            try
            {
                listaremitoslocal = negocio.listarRemitos(clientelocal);
                dgvRemitos.DataSource = listaremitoslocal;




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remito= (Remito)dgvRemitos.CurrentRow.DataBoundItem;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvRemitos.DataSource = listaremitoslocal;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 3)
                {
                    List<Remito> lista;
                    lista = listaremitoslocal.FindAll(X => X.cliente.nombre.Contains(txtBusqueda.Text) || X.numeroRemito.Contains(txtBusqueda.Text));
                    dgvRemitos.DataSource = lista;
                }
            }
        }
    }
}