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

namespace SistemaComercio
{

    public partial class AgregarCheques : Form
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
        public Cheque cheque { get; set; }
        public AgregarCheques()
        {
            InitializeComponent();
            cheque = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBanco.Text.Trim() == "" || txtCUIT.Text.Trim() == "" || txtImporte.Text.Trim() == "" || txtLocalidad.Text.Trim() == "" || txtNum.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            cheque.importe = decimal.Parse(txtImporte.Text.Replace(".", ","));
            cheque.banco = txtBanco.Text;
            cheque.num = txtNum.Text;
            cheque.cuitComprobante = txtCUIT.Text;
            cheque.localidad = txtLocalidad.Text;
            cheque.fechaPago = dtpfechaCobro.Value;
            this.Close();
        }

        private void AgregarCheques_Load(object sender, EventArgs e)
        {
            cheque = new Cheque();
            cheque.importe = 0;
        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))


            {
                e.Handled = true;

                return;
            }

        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))


            {
                e.Handled = true;

                return;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtImporte.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (txtImporte.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(txtImporte.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (txtImporte.SelectionStart != txtImporte.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = txtImporte.Text.Substring(txtImporte.SelectionStart);

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
                if (alreadyExist(txtImporte.Text, ref sepratorChar))
                {
                    int sepratorPosition = txtImporte.Text.IndexOf(sepratorChar);
                    string afterSepratorString = txtImporte.Text.Substring(sepratorPosition + 1);
                    if (txtImporte.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }
    }
}
