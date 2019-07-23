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
    public partial class listarTratamientos : Form
    {
        private List<Certificado> listacertificadosLocal;
        public detalleNegocio negocio { get; set; }
        public string numeroTratamiento = null;
        public decimal cantidad { get; set; }
        public int opc { get; set; }
        public string  numeroCertificado { get; set; }
        public listarTratamientos(string numeroTratamiento)
        {
            InitializeComponent();
            this.numeroTratamiento = numeroTratamiento;
        }
        public listarTratamientos(string numeroTratamiento,int opc)
        {
            InitializeComponent();
            this.numeroTratamiento = numeroTratamiento;
            this.opc = opc;
            
        }
        public listarTratamientos(decimal cantidad)
        {
            InitializeComponent();
            this.cantidad = cantidad;
        }

        private void listarTratamientos_Load(object sender, EventArgs e)
        {
          
                btnModificar.Visible = true;
            
            if(numeroTratamiento!=null)
            {
                cargarGrilla(numeroTratamiento);
                
            }
            else
            {
                cargarGrilla(cantidad);
            }
            
        }

        private void cargarGrilla(decimal cantidad)
        {
            tratamientoNegocio negocio = new tratamientoNegocio();
            try
            {
                listacertificadosLocal = negocio.listarCertificados(cantidad);
                dgvCertificados.DataSource = listacertificadosLocal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarGrilla(string numeroTratamiento)
        {
            tratamientoNegocio negocio = new tratamientoNegocio();
            try
            {
                listacertificadosLocal = negocio.listarCertificados(numeroTratamiento);
                dgvCertificados.DataSource = listacertificadosLocal;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            numeroCertificado = listacertificadosLocal.ElementAt(dgvCertificados.CurrentCell.RowIndex).numeroCertificado;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dgvCertificados.DataSource = listacertificadosLocal;
            }
            else
            {
                if (txtBusqueda.Text.Length >= 3)
                {
                    List<Certificado> lista;
                    lista = listacertificadosLocal.FindAll(X => X.numeroCertificado.Contains(txtBusqueda.Text));
                    dgvCertificados.DataSource = lista;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            negocio = new detalleNegocio();
            if (negocio.leerRemitocert((Certificado)dgvCertificados.CurrentRow.DataBoundItem)==false)
            {

            }
            else
            {
                MessageBox.Show("No se puede modificar el certificado porque esta ligado a un remito");
            }
        }
    }
}
