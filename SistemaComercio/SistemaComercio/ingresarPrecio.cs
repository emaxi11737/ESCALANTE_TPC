using System;
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
    public partial class ingresarPrecio : Form
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
        public decimal precio { get; set; }
        public ingresarPrecio(decimal prec)
        {
            InitializeComponent();
            precio = prec;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            precio = decimal.Parse(txtPrecio.Text);
            this.Close();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtPrecio.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtPrecio.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtPrecio.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtPrecio.SelectionStart != txtPrecio.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtPrecio.Text.Substring(txtPrecio.SelectionStart);

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
                if (alreadyExist(txtPrecio.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtPrecio.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtPrecio.Text.Substring(sepratorPosition + 1);
                    if (txtPrecio.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }
    }
}
