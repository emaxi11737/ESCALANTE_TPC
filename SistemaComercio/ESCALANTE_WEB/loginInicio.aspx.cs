using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace ESCALANTE_WEB
{
    public partial class loginInicio : System.Web.UI.Page
    {
        public usuarioNegocio negocio { get; set; }
        public Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            negocio = new usuarioNegocio();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "alert('Debe ingresar usuario y contrasena')", true);
            }
            else
            {
                usuario = new Usuario();
                usuario.user = TextBox1.Text.Trim();
                usuario.pass = TextBox2.Text.Trim();
                if (negocio.leerdatos(usuario.user, usuario.pass) == true)
                {
                    Response.Redirect("/Index.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "alert('Usuario y contrasena incorrectos')", true);
                }

            }
        }
    }
}