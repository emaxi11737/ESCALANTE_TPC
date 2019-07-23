using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;
namespace Negocio
{
    public class pagoNegocio
    {
        public int idMax()
        {
            int id = 0;
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("Select COUNT(*) as contar,CONVERT(int,Max(id)+1) as idMax from Pagos");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    int cont= (int)accesoDatos.Lector["contar"];
                    if(cont==0)
                    {
                        return 0;
                    }
                    id = (int)accesoDatos.Lector["IdMax"];

                }
                return id;
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

        public List<Transferencia> listarTransferencias(metodoPago p)
        {
            List<Transferencia> listado = new List<Transferencia>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Transferencia t;
            try
            {
                accesoDatos.setearConsulta("select t.importe,c.nombre,t.id,t.banco,t.numeroTransferencia from transferencias as t inner join clientes c on c.id=t.idCliente  where t.id=" + p.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    t = new Transferencia();
                    t.cliente = new Cliente();
                    t.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    t.id = (long)accesoDatos.Lector["id"];
                    t.importe = (decimal)accesoDatos.Lector["importe"];
                    t.Banco = accesoDatos.Lector["banco"].ToString();
                    t.numeroTransferencia = accesoDatos.Lector["numeroTransferencia"].ToString();
                    listado.Add(t);
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
        public List<Efectivo> listarEfectivo(metodoPago p)
        {
            List<Efectivo> listado = new List<Efectivo>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Efectivo e;
            try
            {
                accesoDatos.setearConsulta("select e.importe,c.nombre,e.id from efectivos as e inner join clientes c on c.id=e.idCliente  where e.id=" + p.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    e = new Efectivo();
                    e.cliente = new Cliente();
                    e.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    e.id = (long)accesoDatos.Lector["id"];
                    e.importe = (decimal)accesoDatos.Lector["importe"];
                    listado.Add(e);
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
        public List<Cheque> listarCheques(metodoPago p)
        {
            List<Cheque> listado = new List<Cheque>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Cheque c;
            try
            {
                accesoDatos.setearConsulta("select ch.importe,c.nombre,ch.id,ch.banco,ch.numeroCheque from cheques as ch inner join clientes c on c.id=ch.idCliente  where ch.id=" + p.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    c= new Cheque();
                    c.cliente = new Cliente();
                    c.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    c.id = (long)accesoDatos.Lector["id"];
                    c.importe = (decimal)accesoDatos.Lector["importe"];
                    c.banco = accesoDatos.Lector["banco"].ToString();
                    c.num = accesoDatos.Lector["numeroCheque"].ToString();
                    c.cuitComprobante = accesoDatos.Lector["cuitEmisor"].ToString();
                    c.localidad = accesoDatos.Lector["localidad"].ToString();
                    c.fechaPago = (DateTime)accesoDatos.Lector["fechaPago"];

                    listado.Add(c);
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
        public List<Pago> listarPagos()
        {
            List<Pago> listado = new List<Pago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Pago pago;
            try
            {
                accesoDatos.setearConsulta("select p.id,p.fechaPago,c.nombre from pagos as p inner join clientes c on c.id=p.idCliente where p.activo=1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    pago = new Pago();
                    pago.cliente = new Cliente();
                    pago.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    pago.id = (long)accesoDatos.Lector["id"];
                    pago.fecha = (DateTime)accesoDatos.Lector["fechaPago"];

                    listado.Add(pago);
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
        public List<metodoPago> listarTransferencias(Pago numpago)
        {
            List<metodoPago> listado = new List<metodoPago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            metodoPago pago;
            try
            {
                accesoDatos.setearConsulta("select t.id,t.importe,p.fechaPago,c.nombre from transferencias as t inner join clientes c on c.id=t.idCliente inner join pagos p on p.id=t.idPago where p.id=" + numpago.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    pago = new metodoPago();
                    pago.cliente = new Cliente();
                    pago.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    pago.id = (long)accesoDatos.Lector["id"];
                    pago.fechaPago = (DateTime)accesoDatos.Lector["fechaPago"];
                    pago.importe = (decimal)accesoDatos.Lector["importe"];
                    pago.tipo = "Transferencia";
                    listado.Add(pago);
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
        public List<metodoPago> listarCheques(Pago numpago)
        {
            List<metodoPago> listado = new List<metodoPago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            metodoPago pago;
            try
            {
                accesoDatos.setearConsulta("select ch.importe,p.fechaPago,c.nombre from cheques as ch inner join clientes c on c.id=ch.idCliente inner join pagos p on p.id=ch.idPago where p.id=" + numpago.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    pago = new metodoPago();
                    pago.cliente = new Cliente();
                    pago.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    pago.id = (int)accesoDatos.Lector["id"];
                    pago.fechaPago = (DateTime)accesoDatos.Lector["fechaPago"];
                    pago.importe = (decimal)accesoDatos.Lector["importe"];
                    pago.tipo = "Cheque";
                    listado.Add(pago);

                    listado.Add(pago);
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
        public List<metodoPago> listarEfectivo(Pago numpago)
        {
            List<metodoPago> listado = new List<metodoPago>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            metodoPago pago;
            try
            {
                accesoDatos.setearConsulta("select e.id,e.importe,p.fechaPago,c.nombre from efectivos as e inner join clientes c on c.id=e.idCliente inner join pagos p on p.id=e.idPago where p.id=" + numpago.id);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    pago = new metodoPago();
                    pago.cliente=new Cliente();
                    pago.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    pago.id = (long)accesoDatos.Lector["id"];
                    pago.importe=(decimal)accesoDatos.Lector["importe"];
                    pago.fechaPago = (DateTime)accesoDatos.Lector["fechaPago"];
                    pago.tipo = "Efectivo";

                    listado.Add(pago);
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

        public void eliminarPago(Pago modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update PAGOS Set activo=@ACTIVO  Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@ACTIVO", 0);

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

        public void agregarPago(Cliente cliente,DateTime fecha)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into PAGOS (idCliente,fechaPago,activo) values";
                comando.CommandText += "('" + cliente.id + "', '" + fecha.ToString("MM-dd-yyyy") + "', '" + "1" + "')";
             
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
        public void agregarfacturaxpago(facturaVenta factura,int idpago)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into FACTURASXPAGO (numeroFactura,idPago,activo) values";
                comando.CommandText += "('" + factura.numeroFactura + "','" + idpago + "', '" + "1" + "')";
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
        public void agregarEfectivo(Efectivo efectivo, Cliente cliente,int idpago)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into EFECTIVOS (importe,idCliente,idPago,activo) values";
                comando.CommandText += "('" + efectivo.importe.ToString().Replace(",", ".") + "', '" + cliente.id + "', '" + idpago + "', '" + "1" + "')";
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
        public void agregarTransferencia(Transferencia transferencia, Cliente cliente, int idpago)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into TRANSFERENCIAS (importe,idCliente,idPago,banco,numeroTransferencia,activo) values";
                comando.CommandText += "('" + transferencia.importe.ToString().Replace(",", ".") + "','" + cliente.id + "','" + idpago + "','" + transferencia.Banco + "','" + transferencia.numeroTransferencia + "', '" + "1" + "')";
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
        public void agregarCheque(Cheque cheque, Cliente cliente, int idpago)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into CHEQUES (importe,idCliente,idPago,banco,numeroCheque,fechaPago,cuitEmisor,localidad,activo) values";
                comando.CommandText += "('" + cheque.importe.ToString().Replace(",", ".") + "','" + cliente.id + "','" + idpago + "','" + cheque.banco + "','" + cheque.num + "','" + cheque.fechaPago.ToString("MM-dd-yyyy") + "','" + cheque.cuitComprobante + "','" + cheque.localidad + "', '" + "1" + "')";
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
    }
}
