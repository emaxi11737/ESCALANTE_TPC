using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Negocio
{
    public class detalleNegocio
    {
        public List<Detalle> listarDetalles(string remito)
        {
            List<Detalle> listado = new List<Detalle>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Detalle det = new Detalle();
            try
            {
                accesoDatos.setearConsulta("Select p.descripcion,d.cantidad,d.precioVenta,d.precioParcial,d.idRemito from DETALLES as d inner join productos as p on p.id=d.idProducto where  d.idRemito="+remito);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    det = new Detalle();
                    det.producto = new Producto();
                    det.producto.descripcion = accesoDatos.Lector["descripcion"].ToString();
                    det.numeroRemito = accesoDatos.Lector["idRemito"].ToString();
                    det.cantidadVendida = (int)accesoDatos.Lector["cantidad"];
                    if (!Convert.IsDBNull(accesoDatos.Lector["precioVenta"]))
                    {
                        det.precioUnitario = (decimal)accesoDatos.Lector["precioVenta"];
    
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["precioParcial"]))
                    {
                        det.precioParcial = (decimal)accesoDatos.Lector["precioParcial"];

                    }

                    listado.Add(det);
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
        public void agregarDetalles(Detalle item, string remito,string numerocertificado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                


                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                    comando.CommandText = "insert into DETALLES (idRemito,idProducto ,precioVenta,cantidad,precioParcial,numeroCertificado,activo) values";
                    comando.CommandText += "('" + remito + "', '" + item.producto.id + "', '" + item.precioUnitario.ToString().Replace(",", ".") + "', '" + item.cantidadVendida + "', '" + item.precioParcial.ToString().Replace(",", ".") + "', '" + numerocertificado + "', '" + '1' + "')";
                    comando.Connection = conexion;
                    conexion.Open();

                    comando.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarDetalles(Detalle item, string remito)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {



                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into DETALLES (idRemito,idProducto ,precioVenta, Cantidad,precioParcial,activo) values";
                comando.CommandText += "('" + remito.ToString() + "', '" + item.producto.id + "', '" + item.precioUnitario.ToString().Replace(",", ".") + "', '" + item.cantidadVendida + "', '" + item.precioParcial.ToString().Replace(",", ".") + "', '" + '1' + "')";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool leerRemitocert(Certificado cert)
        {
            List<Detalle> listado = new List<Detalle>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Detalle det = new Detalle();
            try
            {
                accesoDatos.setearConsulta("Select numeroCertificado from DETALLES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    if (!Convert.IsDBNull(accesoDatos.Lector["numeroCertificado"]))
                    {
                        det.numeroCertificado = accesoDatos.Lector["numeroCertificado"].ToString();

                    }

                    if(cert.numeroCertificado==det.numeroCertificado)
                    {
                        return true;
                    }
                }

                return false;
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
