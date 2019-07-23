using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class categoriaNegocio
    {
        public List<Categoria> listarCategorias()
        {
            List<Categoria> listado = new List<Categoria>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Categoria cat = new Categoria();
            try
            {
                accesoDatos.setearConsulta("Select Id,Nombre from CATEGORIAS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    cat = new Categoria();
                    cat.id = (int)accesoDatos.Lector["Id"];
                    cat.descripcion = accesoDatos.Lector["Nombre"].ToString();
                    listado.Add(cat);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
