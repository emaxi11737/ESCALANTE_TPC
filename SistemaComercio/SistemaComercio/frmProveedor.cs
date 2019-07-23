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
    public partial class frmProveedor : Form
    {
        private List<Proveedor> listaProveedorLocal;
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmagProveedor ventana = new frmagProveedor();
            ventana.ShowDialog();
            cargarGrilla();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void cargarGrilla()
        {
             ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                listaProveedorLocal = negocio.listarProveedores();
                dgvProveedores.DataSource = listaProveedorLocal;
                dgvProveedores.Columns[0].Visible = false;

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

       
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                frmagProveedor modificar = new frmagProveedor((Proveedor)dgvProveedores.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            negocio.eliminarProveedor((Proveedor)dgvProveedores.CurrentRow.DataBoundItem);
            cargarGrilla();
        }
    }
}

