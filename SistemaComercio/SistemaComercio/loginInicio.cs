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
    public partial class loginInicio : Form
    {
        public Usuario usuario { get; set; }
        public loginInicio()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioNegocio negocio = new usuarioNegocio();
           
            if(negocio.leerdatos(txtUser.Text,txtPass.Text))
            {
                usuario = new Usuario();
                usuario.tipo = negocio.leertipo(txtUser.Text,txtPass.Text);
                frmPrincipal ventana = new frmPrincipal(usuario.tipo);
                ventana.ShowDialog();
               
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Usuario o contrasena incorrectos");


            }
        }

        private void loginInicio_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
