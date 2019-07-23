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
    public partial class ingresarCantidad : Form
    {
        public int cantidad { get; set; }
        public ingresarCantidad(int cant)
        {
            InitializeComponent();
            cantidad = cant;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            cantidad = int.Parse(txtCantidad.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ingresarCantidad_Load(object sender, EventArgs e)
        {

        }

        private void ingresarCantidad_Activated(object sender, EventArgs e)
        {

        }

        private void ingresarCantidad_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
