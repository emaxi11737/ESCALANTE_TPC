using System;
using System.Collections.Generic;
using AccesoDatos;
using System.Data.SqlClient;
using Dominio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class clienteNegocio
    {

        public List<Cliente> listarClientes()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente Cliente;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del Cliente. Incluso su universo, que lo traigo con join.
                comando.CommandText = "select C.id, C.Nombre,C.CUIT,C.Direccion,C.MAIL,C.Telefono,C.CONDICIONIVA,C.CONDICIONPAGO,C.ACTIVO From CLIENTES as C  ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Cliente = new Cliente();
                    Cliente.id = lector.GetInt32(0);
                    Cliente.nombre = lector["Nombre"].ToString();
                    Cliente.cuit = lector["CUIT"].ToString();
                    Cliente.direccion = lector["Direccion"].ToString();
                    Cliente.mail = lector["Mail"].ToString();
                    Cliente.telefono = lector["Telefono"].ToString();
                   
                    if (!Convert.IsDBNull(lector["CONDICIONPAGO"]))
                    {
                        Cliente.condicionPago = lector["CONDICIONPAGO"].ToString();
                    }
                    if (!Convert.IsDBNull(lector["CONDICIONIVA"]))
                    {
                        Cliente.condicionIVA = lector["CONDICIONIVA"].ToString();
                    }

                    if (!Convert.IsDBNull(lector["ACTIVO"]))
                    {
                        Cliente.activo = (bool)lector["ACTIVO"];
                    }


                    listado.Add(Cliente);
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

        public decimal sumaxCliente()
        {
            throw new NotImplementedException();
        }

        public void agregarCliente(Cliente nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into CLIENTES (Nombre,CUIT , DIRECCION, TELEFONO,CONDICIONIVA,CONDICIONPAGO,MAIL,LOCALIDAD,PROVINCIA,ACTIVO) values";
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
        public void modificarCliente(Cliente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update CLIENTES Set nombre=@Nombre, cuit=@CUIT, direccion=@DIRECCION, MAIL=@MAIL, telefono=@TELEFONO,condicionIVA=@CONDICIONIVA,CONDICIONPAGO=@CONDICIONPAGO Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@CUIT", modificar.cuit);
                accesoDatos.Comando.Parameters.AddWithValue("@DIRECCION", modificar.direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@MAIL", modificar.mail);
                accesoDatos.Comando.Parameters.AddWithValue("@TELEFONO", modificar.telefono);
                accesoDatos.Comando.Parameters.AddWithValue("@DIRECCION", modificar.direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@LOCALIDAD", modificar.localidad);
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
        public void eliminarCliente(Cliente modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update CLIENTES Set activo=@ACTIVO Where Id=" + modificar.id.ToString());
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
