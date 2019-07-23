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
    public partial class graficaProducto : System.Web.UI.Page
    {
        public decimal sumaTotal { get; set; }
        public clienteNegocio negocio;
        public decimal[] barras = new decimal[5];
        public string[] nombre = new string[5];
        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        protected void cuadroProductos_Load(object sender, EventArgs e)
        {

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
                comando.CommandText = "select p.descripcion ,sum(importeTotal)as sumaFacturas from FACTURAVENTA fv inner join REMITOS r on r.numerofactura=fv.numeroFactura inner join detalles d on d.idRemito=r.numeroRemito inner join productos p on d.idProducto=p.id group by p.descripcion  ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    barras[cont] = (decimal)lector["sumaFacturas"];
                    nombre[cont] = lector["Descripcion"].ToString();
                    cont++;

                    if (cont == 5)
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
            cuadroProductos.Series["Series1"].Points.DataBindXY(nombre, barras);
        }
    }
}