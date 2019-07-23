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

    public partial class frmagProducto : Form
    {
        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }
        private Producto productoLocal = null;
        public frmagProducto()
        {
            InitializeComponent();
        }
        public frmagProducto(Producto producto)
        {
            InitializeComponent();
            productoLocal = producto;
        }

        private void frmagProducto_Load(object sender, EventArgs e)
        {
            marcaNegocio marcaNegocio = new marcaNegocio();
            categoriaNegocio catnegocio = new categoriaNegocio();

            try
            {
                if (productoLocal != null)
                {
                    productoLocal.activo = true;
                    txtDescripcion.Text = productoLocal.descripcion;
                    txtprecioCompra.Text = productoLocal.precioCompra.ToString();
                    txtprecioUnitario.Text = productoLocal.precioVenta.ToString();





                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productoNegocio negocio = new productoNegocio();
            try
            {
                if (txtDescripcion.Text.Trim() == "" || txtprecioCompra.Text.Trim() == "" || txtprecioUnitario.Text.Trim() == "" )
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }
                //MSF-20190420: ahora pasamos a usar siempre la variable productoLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (productoLocal == null)
                    productoLocal = new Producto();
                productoLocal.activo = true;
                decimal precioCompra;

                productoLocal.descripcion = txtDescripcion.Text;


                productoLocal.precioCompra = decimal.Parse(txtprecioCompra.Text.Replace(".", ","));
                productoLocal.precioVenta = decimal.Parse(txtprecioUnitario.Text.Replace(".", ","));



                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (productoLocal.id != 0)
                {
                    negocio.modificarProducto(productoLocal);
                }
                else
                {
                    negocio.agregarproducto(productoLocal);
                }


                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtstockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;


            }
        }

        private void txtprecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (txtprecioCompra.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtprecioCompra.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtprecioCompra.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtprecioCompra.SelectionStart != txtprecioCompra.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtprecioCompra.Text.Substring(txtprecioCompra.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(txtprecioCompra.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtprecioCompra.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtprecioCompra.Text.Substring(sepratorPosition + 1);
                    if (txtprecioCompra.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }


        }

        private void txtprecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (txtprecioUnitario.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtprecioUnitario.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtprecioUnitario.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtprecioUnitario.SelectionStart != txtprecioUnitario.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtprecioUnitario.Text.Substring(txtprecioUnitario.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(txtprecioUnitario.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtprecioUnitario.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtprecioUnitario.Text.Substring(sepratorPosition + 1);
                    if (txtprecioUnitario.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }
    }
}
