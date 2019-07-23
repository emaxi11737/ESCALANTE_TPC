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
    public partial class listarProductos : Form
    {
        public Producto p { get; set; }
        private List<Producto> listaProductosLocal;
        public listarProductos()
        {
            InitializeComponent();
        }
        private void cargarGrilla()
        {
            productoNegocio negocio = new productoNegocio();
            try
            {
                listaProductosLocal = negocio.listarProductos();
                dgvProductos.DataSource = listaProductosLocal;
                dgvProductos.Columns[0].Visible = false;
                dgvProductos.Columns[4].Visible = false;
                dgvProductos.Columns[6].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listarProductos_Load(object sender, EventArgs e)
        {
            cargarGrilla();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvProductos.DataSource = listaProductosLocal;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 3)
                {
                    List<Producto> lista;
                    lista = listaProductosLocal.FindAll(X => X.descripcion.Contains(txtBusqueda.Text));
                    dgvProductos.DataSource = lista;
                }
            }
        }
    }
}
