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
    public partial class agregarUsuario : Form
    {
        public Usuario usuario = null;
        public agregarUsuario()
        {
            InitializeComponent();
            
        }
        public agregarUsuario(Usuario u)
        {
            InitializeComponent();
            usuario = u;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioNegocio negocio = new usuarioNegocio();
            if (usuario != null)
            {
                if (txtUsuario.Text.Trim() == "" || txtPassword.Text.Trim() == "" || cboTipo.Text.Trim() == "" )
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }
                negocio.modificarUsuario(usuario);
            }
            if (usuario==null)
            {
                usuario = new Usuario();
                usuario.user = txtUsuario.Text;
                usuario.pass = txtPassword.Text;
                usuario.tipo = cboTipo.Text;
                usuario.activo = true;
                negocio.agregarUsuario(usuario);
            }

            this.Close();
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (usuario!=null)
            {
                txtUsuario.Text = usuario.user.ToString();
                txtPassword.Text = usuario.pass.ToString();
                cboTipo.Text = usuario.tipo.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
