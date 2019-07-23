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
    public partial class frmagEmpleado : Form
    {
        private Empleado empleadolocal = null;
        public frmagEmpleado()
        {
            InitializeComponent();
        }
        public frmagEmpleado(Empleado empleado)
        {
            InitializeComponent();
            empleadolocal = empleado;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            empleadoNegocio negocio = new empleadoNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable empleadolocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (empleadolocal == null)
                    empleadolocal = new Empleado();
                empleadolocal.activo = true;
                empleadolocal.dni = txtDni.Text;
                empleadolocal.nombre = txtNombre.Text;
                empleadolocal.apellido = txtApellido.Text;
                empleadolocal.direccion = txtDireccion.Text;
                empleadolocal.localidad = txtLocalidad.Text;
                empleadolocal.mail = txtMail.Text;
                empleadolocal.telefono = txtTelefono.Text;

                if (txtDni.Text.Trim() == "" || txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDireccion.Text.Trim() == "" || txtLocalidad.Text.Trim() == "" || txtTelefono.Text.Trim() == "" || txtMail.Text.Trim() == "")
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }

                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (empleadolocal.id != 0)
                {
                    negocio.modificarEmpleado(empleadolocal);
                }
                else
                {
                    negocio.agregarEmpleado(empleadolocal);
                }


               
           


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmagEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                if (empleadolocal != null)
                {
                    empleadolocal.activo = true;
                    txtNombre.Text = empleadolocal.nombre;
                    txtApellido.Text = empleadolocal.apellido;
                    txtDni.Text = empleadolocal.dni;
                    txtDireccion.Text = empleadolocal.direccion;
                    txtLocalidad.Text = empleadolocal.localidad;
                    txtMail.Text = empleadolocal.mail;
                    txtTelefono.Text = empleadolocal.telefono;
                 






                    //alternativa al retomar una modificacion. Si tenes configurado Display y Value Member
                    //cboUniverso.SelectedValue = clienteLocal.Universo.Id;
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
