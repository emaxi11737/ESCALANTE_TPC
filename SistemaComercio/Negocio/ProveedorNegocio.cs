using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> listarProveedores()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Proveedor> listado = new List<Proveedor>();
            Proveedor proveedor;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del proveedor. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select P.id, P.Nombre,P.CUIT,P.Direccion,P.MAIL,P.Telefono,P.CONDICIONIVA,P.CONDICIONPAGO,P.ACTIVO From Proveedores as P where activo = 1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    proveedor = new Proveedor();
                    proveedor.id = lector.GetInt32(0);
                    proveedor.nombre = lector["Nombre"].ToString();
                    proveedor.cuit = lector["CUIT"].ToString();
                    proveedor.direccion = lector["Direccion"].ToString();
                    proveedor.mail = lector["Mail"].ToString();
                    proveedor.telefono = lector["Telefono"].ToString();
                    if (!Convert.IsDBNull(lector["ACTIVO"]))
                    {
                        proveedor.activo = (bool)lector["ACTIVO"];
                    }

                    if (!Convert.IsDBNull(lector["CONDICIONPAGO"]))
                    {
                        proveedor.condicionPago = (int)lector["CONDICIONPAGO"];
                    }
                    if (!Convert.IsDBNull(lector["CONDICIONIVA"]))
                    {
                        proveedor.condicionIVA = lector["CONDICIONIVA"].ToString();
                    }



                    listado.Add(proveedor);
                }

                return listado;

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
        public void agregarproveedor(Proveedor nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into PROVEEDORES (Nombre,CUIT , DIRECCION, TELEFONO,CONDICIONIVA,CONDICIONPAGO,MAIL,LOCALIDAD,PROVINCIA,ACTIVO) values";
                comando.CommandText += "('" + nuevo.nombre + "', '" + nuevo.cuit + "', '" + nuevo.direccion + "', '" + nuevo.telefono
                 + "', '" + nuevo.condicionIVA + "', '" + nuevo.condicionPago + "', '" + nuevo.mail + "', '" + nuevo.localidad + "', '" + nuevo.provincia + "', '" + nuevo.activo + "')";
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
        public void modificarProveedores(Proveedor modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update PROVEEDORES Set nombre=@Nombre, cuit=@CUIT, direccion=@DIRECCION, MAIL=@MAIL, telefono=@TELEFONO,condicionIVA=@CONDICIONIVA,CONDICIONPAGO=@CONDICIONPAGO Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@CUIT", modificar.cuit);
                accesoDatos.Comando.Parameters.AddWithValue("@DIRECCION", modificar.direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@MAIL", modificar.mail);
                accesoDatos.Comando.Parameters.AddWithValue("@TELEFONO", modificar.telefono);
                accesoDatos.Comando.Parameters.AddWithValue("@CONDICIONIVA", modificar.condicionIVA);
                accesoDatos.Comando.Parameters.AddWithValue("@CONDICIONPAGO", modificar.condicionPago);
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
        public void eliminarProveedor(Proveedor modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update PROVEEDORES Set activo=@ACTIVO Where Id=" + modificar.id.ToString());
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

