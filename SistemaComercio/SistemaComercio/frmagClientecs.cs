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
    public partial class frmagClientecs : Form
    {
        private Cliente clienteLocal = null;
        public frmagClientecs()
        {
            InitializeComponent();
        }
        public frmagClientecs(Cliente cliente)
        {
            InitializeComponent();
            clienteLocal = cliente;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteNegocio negocio = new clienteNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable clienteLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (clienteLocal == null)
                    clienteLocal = new Cliente();
                clienteLocal.activo = true;
                clienteLocal.cuit = txtCuit.Text;
                clienteLocal.nombre = txtCliente.Text;
                clienteLocal.direccion = txtDireccion.Text;
                clienteLocal.telefono = txtTelefono.Text;
                clienteLocal.condicionIVA = cbxIVA.Text;
                clienteLocal.mail = txtEmail.Text;
                clienteLocal.condicionPago = cbxPago.Text;
                if (txtCuit.Text.Trim() == "" || txtCliente.Text.Trim() == "" || cbxPago.Text.Trim() == "" || cbxIVA.Text.Trim() == "" || txtDireccion.Text.Trim() == ""  || txtTelefono.Text.Trim() == "" || txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }
                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (clienteLocal.id != 0)
                {
                    negocio.modificarCliente(clienteLocal);
                }
                else
                {
                    negocio.agregarCliente(clienteLocal);
                }


                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmagClientecs_Load(object sender, EventArgs e)
        {
            try
            {


                if (clienteLocal != null)
                {
                    clienteLocal.activo = true;
                    txtCliente.Text = clienteLocal.nombre;
                    txtCuit.Text = clienteLocal.cuit;
                    txtDireccion.Text = clienteLocal.direccion;

                    txtEmail.Text = clienteLocal.mail;
                    txtTelefono.Text = clienteLocal.telefono;
                    cbxIVA.Text = clienteLocal.condicionIVA;
                    cbxPago.Text = clienteLocal.condicionPago;


                    //alternativa al retomar una modificacion. Si tenes configurado Display y Value Member
                    //cboUniverso.SelectedValue = clienteLocal.Universo.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))


            {
                e.Handled = true;

                return;
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}