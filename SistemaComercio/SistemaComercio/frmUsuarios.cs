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
    public partial class frmUsuarios : Form
    {
        public List<Usuario> listaUsuarios = new List<Usuario>();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioNegocio negocio = new usuarioNegocio();
            listaUsuarios = negocio.listarUsuarios();
            dgvUsuarios.DataSource = listaUsuarios;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarUsuario modificar = new agregarUsuario((Usuario)dgvUsuarios.CurrentRow.DataBoundItem);
            modificar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            usuarioNegocio negocio= new usuarioNegocio();
            negocio.eliminarUsuario(usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarUsuario ventana = new agregarUsuario();
            ventana.ShowDialog();
        }
    }
}
