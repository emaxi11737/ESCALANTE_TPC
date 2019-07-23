using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using AccesoDatos;
using System.Data.SqlClient;

namespace ESCALANTE_WEB
{
    public partial class graficaCliente : System.Web.UI.Page
    {
        public decimal sumaTotal { get; set; }
        public clienteNegocio negocio;
        public decimal[] barras = new decimal[3];
        public string[] nombre = new string[3];
        protected void Page_Load(object sender, EventArgs e)
        {
            
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            int cont = 0;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del Cliente. Incluso su universo, que lo traigo con join.
                comando.CommandText = "SELECT CONSULTA.Nombre,CONSULTA.sumaFacturas FROM (select c.Id,c.nombre,SUM(f.importeTotal)as sumaFacturas from facturaVenta as f inner join CLIENTES as c on c.Id=f.idCliente where f.activo = 1 group by c.Nombre,c.id) AS CONSULTA inner join FACTURAVENTA f on f.idCliente=CONSULTA.Id group by Id,Nombre,sumaFacturas  ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                   
                        barras[cont]= (decimal)lector["sumaFacturas"];
                    nombre[cont]= lector["Nombre"].ToString();
                    cont++;

                    if (cont == 3)
                    {
                        break;
                    }
                }

                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            Cuadroclientes.Series["Series1"].Points.DataBindXY(nombre, barras);
        }

        protected void Cuadroclientes_Load(object sender, EventArgs e)
        {

        }
    }
}