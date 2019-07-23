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
    public partial class frmProducto : Form
    {
        private List<Producto> listaProductosLocal;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagProducto ventana = new frmagProducto();
            ventana.ShowDialog();
            cargarGrilla();
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

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                frmagProducto modificar = new frmagProducto((Producto)dgvProductos.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productoNegocio negocio = new productoNegocio();
            negocio.eliminarProducto((Producto)dgvProductos.CurrentRow.DataBoundItem);
            cargarGrilla();
        }
    }
}
