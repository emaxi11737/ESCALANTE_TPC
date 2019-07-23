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
    public class remitoNegocio
    {
        public List<Remito> listarRemitos()
        {
            List<Remito> listado = new List<Remito>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Remito r;
            try
            {
                accesoDatos.setearConsulta("select r.numeroRemito,c.nombre,r.idCliente,r.fechaRemito,estado  from remitos as r inner join clientes as c on c.id = r.idcliente");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    r = new Remito();
                    r.cliente = new Cliente();
                    r.numeroRemito = accesoDatos.Lector["numeroRemito"].ToString();
                    r.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    r.fecha = (DateTime)accesoDatos.Lector["fechaRemito"];
                    r.estado = accesoDatos.Lector["estado"].ToString();

                    listado.Add(r);
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
        public List<Remito> listarRemitos(Cliente cliente)
        {
            List<Remito>listado = new List<Remito>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Remito r;
            try
            {
                accesoDatos.setearConsulta("select r.numeroRemito,c.nombre,r.idCliente,r.fechaRemito,estado  from remitos as r inner join clientes as c on c.id = r.idcliente where r.idcliente=" + cliente.id + "and r.estado='No facturado' and r.activo=1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    
                    r = new Remito();
                    r.cliente = new Cliente();
                    r.numeroRemito = accesoDatos.Lector["numeroRemito"].ToString();
                    r.cliente.nombre = accesoDatos.Lector["nombre"].ToString();
                    r.fecha = (DateTime)accesoDatos.Lector["fechaRemito"];
                    r.estado = accesoDatos.Lector["estado"].ToString();

                    listado.Add(r);
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
        public void agregarRemito(Remito nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "set dateformat 'dmy'";
                comando.CommandText = "insert into REMITOS (idCliente,numeroRemito , fechaRemito,estado,activo) values";
                comando.CommandText += "('" + nuevo.cliente.id + "', '" + nuevo.numeroRemito + "', '"  + nuevo.fecha.ToString("MM-dd-yyyy") + "', '" + nuevo.estado + "', '" + "1" + "')";
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
        public void modificarRemito(Remito modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update REMITOS Set id=@idCliente cuit=@CUIT, fecha=@fechaRemito, numeroRemito=@numeroRemito Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@idCliente", modificar.cliente.id);
                accesoDatos.Comando.Parameters.AddWithValue("@fechaRemito", modificar.fecha.ToString("MM-dd-yyyy"));
                accesoDatos.Comando.Parameters.AddWithValue("@numeroRemito", modificar.numeroRemito);
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
        public void modificarRemitos(Remito modificar,string numeroFactura,string estado)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
               
                    accesoDatos.setearConsulta("update REMITOS Set numeroFactura=@numeroFactura,estado=@estado Where numeroRemito=" + modificar.numeroRemito);
                    accesoDatos.Comando.Parameters.Clear();
                    accesoDatos.Comando.Parameters.AddWithValue("@numeroFactura", numeroFactura);
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

        public void eliminarRemito(Remito modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update Remitos Set activo=@ACTIVO Where numeroRemito=" + modificar.numeroRemito.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@ACTIVO", modificar.activo);
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