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
    public class tratamientoNegocio
    {
        public List<Tratamiento> listarTratamientos()
        {
            List<Tratamiento> listado = new List<Tratamiento>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Tratamiento t;
            try
            {
                accesoDatos.setearConsulta("select t.numeroTratamiento,t.fecha,t.cantidadPallets,t.cantidadCajones,t.cantidadMadera  from tratamientos as t   ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    t = new Tratamiento();
                    t.numeroTratamiento = accesoDatos.Lector["numeroTratamiento"].ToString();
                    t.fecha = (DateTime)accesoDatos.Lector["fecha"];
                    t.cantidadPallets = (int)accesoDatos.Lector["cantidadPallets"];
                    t.cantidadCajones = (int)accesoDatos.Lector["cantidadCajones"];
                    t.cantidadmaderaAcomodacion = (int)accesoDatos.Lector["cantidadMadera"];
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
        public List<Certificado> listarCertificados(decimal cantidad)
        {
            List<Certificado> listado = new List<Certificado>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Certificado c;
            try
            {
                accesoDatos.setearConsulta("select c.tipo,c.cantidadtotal,c.cantidadentregada,c.fecha,c.codigo,c.numeroRemito,c.numeroCertificado  from Certificados as c  where " + cantidad + " <= c.cantidadTotal - c.cantidadentregada  ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    c = new Certificado();
                    // c.fecha = (DateTime)accesoDatos.Lector["fecha"];
                    c.codigo = accesoDatos.Lector["codigo"].ToString();
                    c.tipo = accesoDatos.Lector["tipo"].ToString();
                    c.numeroCertificado = accesoDatos.Lector["numeroCertificado"].ToString();
                    c.cantidadTotal = (int)accesoDatos.Lector["cantidadTotal"];
                    if (!Convert.IsDBNull(accesoDatos.Lector["cantidadEntregada"]))
                    {
                        c.cantidadEntregada = (int)accesoDatos.Lector["cantidadEntregada"];
                    }


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
        public List<Certificado> listarCertificados(string numeroTratamiento)
        {
            List<Certificado> listado = new List<Certificado>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Certificado c;
            try
            {
                accesoDatos.setearConsulta("select c.tipo,c.cantidadtotal,c.cantidadentregada,c.fecha,c.codigo,c.numeroRemito,c.numeroCertificado  from Certificados as c  where c.numeroTratamiento=" + numeroTratamiento);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    c = new Certificado();
                    c.fecha = (DateTime)accesoDatos.Lector["fecha"];
                    c.codigo = accesoDatos.Lector["codigo"].ToString();
                    c.tipo = accesoDatos.Lector["tipo"].ToString();
                    c.numeroCertificado = accesoDatos.Lector["numeroCertificado"].ToString();
                    if (!Convert.IsDBNull(accesoDatos.Lector["cantidadTotal"]))
                    {
                        c.cantidadTotal = (int)accesoDatos.Lector["cantidadTotal"];
                    }
                    
                    if (!Convert.IsDBNull(accesoDatos.Lector["cantidadEntregada"]))
                    {
                        c.cantidadEntregada = (int)accesoDatos.Lector["cantidadEntregada"];
                    }
                    
         
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
        public void agregarCertificados(Certificado item,string numeroTratamiento,DateTime fecha)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                
                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                    comando.CommandText = "insert into Certificados (numeroTratamiento,tipo,numeroCertificado,codigo,cantidadTotal,fecha,cantidadEntregada,activo) values";
                    comando.CommandText += "('" + numeroTratamiento + "', '" + item.tipo + "', '" + item.numeroCertificado + "', '" + item.codigo + "', '" + item.cantidadTotal + "', '" + fecha.ToString("MM-dd-yyyy") + "', '" + 0 + "', '" + 1 + "')";
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
        public void agregarTratamiento(Tratamiento nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into Tratamientos (numeroTratamiento,cantidadPallets,cantidadCajones,cantidadMadera,fecha,activo)values ";
                comando.CommandText += "('" + nuevo.numeroTratamiento + "', '" + nuevo.cantidadPallets + "', '" + nuevo.cantidadCajones + "', '" + nuevo.cantidadmaderaAcomodacion + "', '" + nuevo.fecha.ToString("MM-dd-yyyy") + "', '" + "1" + "')";
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
        public void modificarCertificado(string numeroCertificado,decimal cantidad)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update Certificados Set cantidadEntregada=cantidadEntregada+@cantidadEntregada  Where numeroCertificado=" + numeroCertificado);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@cantidadEntregada", cantidad);
  


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
