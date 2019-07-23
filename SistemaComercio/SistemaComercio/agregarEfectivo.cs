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
    public partial class agregarEfectivo : Form
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
        public decimal importe { get; set; }
        public agregarEfectivo()
        {
            InitializeComponent();
           
        }

        private void agregarEfectivo_Load(object sender, EventArgs e)
        {
            importe = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtImporte.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            importe = decimal.Parse(txtImporte.Text.Replace(".", ","));
            this.Close();
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
