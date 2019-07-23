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
    public partial class graficaVenta : System.Web.UI.Page
    {
        public decimal sumaTotal { get; set; }
        public clienteNegocio negocio;
        public decimal[] barras = new decimal[12];
        public string[] nombre = new string[12];
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
                comando.CommandText = "select MONTH(fechaFactura)as mesFactura,SUM(importeTotal) as importeMes from FACTURAVENTA group by MONTH(fechaFactura)";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    barras[cont] = (decimal)lector["importeMes"];
                    nombre[cont] = lector["mesFactura"].ToString();
                    cont++;

                    if (cont == 12)
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
            cuadroVentasmes.Series["Series1"].Points.DataBindXY(nombre, barras);
        }
    }
}