using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
namespace Negocio
{
    public class marcaNegocio
    {
        public List<Marca> listarMarcas()
        {
            List<Marca> listado = new List<Marca>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Marca marc = new Marca();
            try
            {
                accesoDatos.setearConsulta("Select Id,Descripcion from MARCA");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    marc = new Marca();
                    marc.id = (int)accesoDatos.Lector["Id"];
                    marc.descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    listado.Add(marc);
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
