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
    public class productoNegocio
    {
        public List<Producto> listarProductos()
        {
            List<Producto> listado = new List<Producto>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Producto p;
            try
            {
                accesoDatos.setearConsulta("Select Id, Descripcion,precioCompra,precioVenta,stockMinimo from Productos where activo = 1 ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    p = new Producto();
                    p.id = (int)accesoDatos.Lector["Id"];
                    p.descripcion = accesoDatos.Lector["Descripcion"].ToString();
                  
                    if (!Convert.IsDBNull(accesoDatos.Lector["precioCompra"]))
                    {
                        p.precioCompra = (decimal)accesoDatos.Lector["precioCompra"];
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["precioVenta"]))
                    {
                        p.precioVenta = (decimal)accesoDatos.Lector["precioVenta"];
                    }
                    

                    
                    if (!Convert.IsDBNull(accesoDatos.Lector["stockMinimo"]))
                    {
                        p.stockMinimo = (int)accesoDatos.Lector["stockMinimo"];
                    }





                    listado.Add(p);
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
        public void agregarproducto(Producto nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into productos (Descripcion,precioCompra , precioVenta, stockMinimo,activo) values";
                comando.CommandText += "('" + nuevo.descripcion + "', '" + nuevo.precioCompra.ToString().Replace(",", ".") + "', '" + nuevo.precioVenta.ToString().Replace(",", ".") + "', '" + nuevo.stockMinimo
              + "', '" + nuevo.activo + "')";
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
        public void modificarProducto(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update PRODUCTOS Set descripcion=@DESCRIPCION, precioCompra=@precioCompra, precioVenta=@precioVenta,stockMinimo=@stockMinimo Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@DESCRIPCION", modificar.descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@precioCompra", modificar.precioCompra);
                accesoDatos.Comando.Parameters.AddWithValue("@precioVenta", modificar.precioVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@stockMinimo", modificar.stockMinimo);
      
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
        public void eliminarProducto(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update PRODUCTOS Set activo=@ACTIVO Where Id=" + modificar.id.ToString());
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
