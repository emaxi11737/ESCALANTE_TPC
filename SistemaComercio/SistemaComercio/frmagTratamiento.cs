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
    public partial class frmagTratamiento : Form
    {
        public BindingList<Certificado> listaDetalles = new BindingList<Certificado>();
        public Certificado certificado { get; set; }
        public frmagTratamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            certificado = new Certificado();
            certificado.tipo = cboTipo.Text;
            certificado.cantidadTotal = double.Parse(txtCantidad.Text);
            certificado.codigo = txtCodigo.Text;
            certificado.numeroCertificado = txtnumeroCertificado.Text;
            listaDetalles.Add(certificado);
            refrescarGrilla();
        }
        private void refrescarGrilla()
        {
            dgvCertificados.DataSource = null;
            dgvCertificados.DataSource = listaDetalles;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listaDetalles.Count==0)
            {
                MessageBox.Show("Debes ingresar al menos un certificado");
                return;
            }
            if (txtcantidadCajones.Text.Trim() == "" || txtcantidadMadera.Text.Trim() == "" || txtcantidadPallets.Text.Trim() == "" || txtnumeroTratamiento.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            Tratamiento tratamiento = new Tratamiento();
            tratamiento.fecha = dtpFecha.Value;
            tratamiento.cantidadCajones = int.Parse(txtcantidadCajones.Text);
            tratamiento.cantidadPallets = int.Parse(txtcantidadPallets.Text);
            tratamiento.cantidadmaderaAcomodacion = decimal.Parse(txtcantidadMadera.Text);
            tratamiento.numeroTratamiento = txtnumeroTratamiento.Text;

            tratamiento.cantidadCajones = int.Parse(txtcantidadCajones.Text);
            tratamientoNegocio negocio = new tratamientoNegocio();
            negocio.agregarTratamiento(tratamiento);
            foreach(Certificado item in listaDetalles)
            {
                negocio.agregarCertificados(item, txtnumeroTratamiento.Text, dtpFecha.Value);
            }
            this.Close();

        }

        private void frmagTratamiento_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtcantidadPallets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtcantidadCajones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtcantidadMadera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtnumeroTratamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtnumeroCertificado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))


            {
                e.Handled = true;

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvCertificados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un certificado");
                return;
            }
            foreach (DataGridViewRow item in this.dgvCertificados.SelectedRows)
            {
                int numero = item.Index;       
                listaDetalles.RemoveAt(numero);
                refrescarGrilla();
            
            }
        }
    }
}
