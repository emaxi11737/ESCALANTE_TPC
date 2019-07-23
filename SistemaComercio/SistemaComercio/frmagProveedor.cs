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
    public partial class frmagProveedor : Form
    {
        private Proveedor proveedorLocal = null;
        public frmagProveedor()
        {
            InitializeComponent();
        }
        public frmagProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            proveedorLocal = proveedor;
        }
        

     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable proveedorLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (proveedorLocal == null)
                    proveedorLocal = new Proveedor();
                proveedorLocal.activo = true;
                proveedorLocal.cuit = txtCuit.Text;
                proveedorLocal.nombre = txtCliente.Text;
                proveedorLocal.direccion = txtDireccion.Text;
                proveedorLocal.telefono = txtTelefono.Text;
                proveedorLocal.condicionIVA = cbxIVA.Text;
                proveedorLocal.mail = txtEmail.Text;
                proveedorLocal.condicionPago = CondicionPago(cbxPago.Text);

                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (txtCliente.Text.Trim() == "" || txtCuit.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtLocalidad.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtEmail.Text.Trim() == "" )
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }
                if (proveedorLocal.id != 0)
                {
                    negocio.modificarProveedores(proveedorLocal);
                }
                else
                {
                    negocio.agregarproveedor(proveedorLocal);
                }


                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int CondicionPago(string text)
        {
           switch(text)
            {
                case "Contraentrega": return 0;
                    break;
                case "15 dias": return 15;
                    break;
                case "30 dias": return 30;
                    break;
                case "45 dias": return 45;
                    break;
                case "60 dias": return 60;
                    break;
                case "90 dias": return 90;
                    break;
            }
            return 0;
        }

        private void frmagProveedor_Load(object sender, EventArgs e)
        {
            try
            {


                if (proveedorLocal != null)
                {

                    proveedorLocal.activo = true;
                    txtCliente.Text = proveedorLocal.nombre;
                    txtCuit.Text = proveedorLocal.cuit;
                    txtDireccion.Text = proveedorLocal.direccion;
                    txtEmail.Text = proveedorLocal.mail;
                    txtTelefono.Text = proveedorLocal.telefono;
                    cbxIVA.Text = proveedorLocal.condicionIVA;
                    cbxPago.Text = proveedorLocal.condicionPago.ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
