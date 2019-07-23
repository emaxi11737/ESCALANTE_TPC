using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class facturaventaNegocio
    {
        public List<facturaVenta> listarFacturas()
        {
            List<facturaVenta> listado = new List<facturaVenta>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            facturaVenta factura;
            try
            {
                accesoDatos.setearConsulta("select f.numeroFactura,f.fechaFactura,f.idCliente,f.condicionPago,f.tipoComprobante,f.importeNeto,f.IVA21,f.importenoGravado,c.nombre,f.importeTotal,f.estado  from facturaVenta as f inner join clientes as c on c.id = f.idcliente where f.activo=1  ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    factura = new facturaVenta();
                    factura.cliente = new Cliente();
                    factura.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    factura.numeroFactura = accesoDatos.Lector["numeroFactura"].ToString();
                    factura.estado = accesoDatos.Lector["estado"].ToString();
                    factura.fechaFactura = (DateTime)accesoDatos.Lector["fechaFactura"];
                    factura.tipoComprobante = accesoDatos.Lector["tipoComprobante"].ToString();
                    factura.importeBruto = (decimal)accesoDatos.Lector["importeTotal"];
                    factura.importeNeto = (decimal)accesoDatos.Lector["importeNeto"];
                    factura.importeIVA = (decimal)accesoDatos.Lector["IVA21"];
                    factura.importenoGravado = (decimal)accesoDatos.Lector["importenoGravado"];
                    factura.condicionPago = (int)accesoDatos.Lector["condicionPago"];

                    listado.Add(factura);
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
        public List<facturaVenta> listarFacturas(Pago pago)
        {
            List<facturaVenta> listado = new List<facturaVenta>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            facturaVenta factura;
            try
            {
                accesoDatos.setearConsulta("select f.numeroFactura,f.fechaFactura,f.idCliente,f.condicionPago,f.tipoComprobante,f.importeNeto,f.IVA21,f.importenoGravado,c.nombre,f.importeTotal,f.estado  from facturaVenta as f inner join clientes as c on c.id = f.idcliente inner join Facturasxpago fp on fp.numeroFactura=f.numeroFactura inner join Pagos p on p.id=fp.idPago where f.activo=1 and idPago =" + pago.id.ToString());
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    factura = new facturaVenta();
                    factura.cliente = new Cliente();
                    factura.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    factura.numeroFactura = accesoDatos.Lector["numeroFactura"].ToString();
                    factura.estado = accesoDatos.Lector["estado"].ToString();
                    factura.fechaFactura = (DateTime)accesoDatos.Lector["fechaFactura"];
                    factura.tipoComprobante = accesoDatos.Lector["tipoComprobante"].ToString();
                    factura.importeBruto = (decimal)accesoDatos.Lector["importeTotal"];
                    factura.importeNeto = (decimal)accesoDatos.Lector["importeNeto"];
                    factura.importeIVA = (decimal)accesoDatos.Lector["IVA21"];
                    factura.importenoGravado = (decimal)accesoDatos.Lector["importenoGravado"];
                    factura.condicionPago = (int)accesoDatos.Lector["condicionPago"];

                    listado.Add(factura);
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
        

        public List<facturaVenta> listarFacturas(Cliente cliente)
        {
            List<facturaVenta> listado = new List<facturaVenta>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            facturaVenta factura;
            try
            {
                accesoDatos.setearConsulta("select f.numeroFactura,f.fechaFactura,f.idCliente,f.condicionPago,f.tipoComprobante,f.importeNeto,f.IVA21,f.importenoGravado,c.nombre,f.importeTotal,f.estado  from facturaVenta as f inner join clientes as c on c.id = f.idcliente where f.estado='Impago' and f.activo=1 and f.idcliente=" + cliente.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    factura = new facturaVenta();
                    factura.cliente = new Cliente();
                    factura.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    factura.numeroFactura = accesoDatos.Lector["numeroFactura"].ToString();
                    factura.estado = accesoDatos.Lector["estado"].ToString();
                    factura.fechaFactura = (DateTime)accesoDatos.Lector["fechaFactura"];
                    factura.tipoComprobante = accesoDatos.Lector["tipoComprobante"].ToString();
                    factura.importeBruto = (decimal)accesoDatos.Lector["importeTotal"];
                    factura.importeNeto = (decimal)accesoDatos.Lector["importeNeto"];
                    factura.importeIVA = (decimal)accesoDatos.Lector["IVA21"];
                    factura.importenoGravado = (decimal)accesoDatos.Lector["importenoGravado"];
                    factura.condicionPago = (int)accesoDatos.Lector["condicionPago"];

                    listado.Add(factura);
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
        public void agregarFactura(facturaVenta nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into facturaVenta (idCliente,numeroFactura , fechaFactura,importeTotal,IVA21,importeNeto,importenoGravado,activo,tipoComprobante,estado,condicionPago) values";
                comando.CommandText += "('" + nuevo.cliente.id + "', '" + nuevo.numeroFactura + "', '" + nuevo.fechaFactura.ToString("MM-dd-yyyy") + "', '" + nuevo.importeBruto.ToString().Replace(",", ".") + "', '" + nuevo.importeIVA.ToString().Replace(",", ".") + "', '" + nuevo.importeNeto.ToString().Replace(",", ".") + "', '" + nuevo.importenoGravado.ToString().Replace(",", ".") + "', '" + nuevo.activo + "', '" + nuevo.tipoComprobante + "', '" + nuevo.estado + "', '" + nuevo.condicionPago + "')";
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
        public void modificarFactura(Factura modificar,string estado)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update facturaVenta Set estado=@estado Where numeroFactura=" + modificar.numeroFactura.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@estado", estado);
     
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

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
        public void modificarPagoFactura(Pago pago)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update FACTURAVENTA set estado='Impago' where numeroFactura in(select numeroFactura from FACTURASXPAGO where idPago=" + pago.id.ToString() + ")");
                accesoDatos.Comando.Parameters.Clear();

                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

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
