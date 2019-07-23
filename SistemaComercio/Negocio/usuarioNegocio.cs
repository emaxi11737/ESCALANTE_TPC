using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AccesoDatos;
using Dominio;


namespace Negocio
{
    public class usuarioNegocio
    {
        public bool leerdatos(string user, string pass)
        {
            List<Usuario> listado = new List<Usuario>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Usuario u;
            try
            {
                accesoDatos.setearConsulta("select UserName,Llave from Usuario");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    u = new Usuario();
                    u.user = accesoDatos.Lector["username"].ToString();
                    u.pass = accesoDatos.Lector["Llave"].ToString();
                    if (u.user == user && u.pass == pass)
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
        public void modificarUsuario(Usuario modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update usuario Set Username=@Username,llave=@llave, tipo=@tipo Where loginId=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@username", modificar.user);
                accesoDatos.Comando.Parameters.AddWithValue("@Llave", modificar.pass);
                accesoDatos.Comando.Parameters.AddWithValue("tipo", modificar.tipo);
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
        public void eliminarUsuario(Usuario modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update USUARIO Set activo=@ACTIVO Where loginID=" + modificar.id.ToString());
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

        public void agregarUsuario(Usuario nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into USUARIO (userName , llave,tipo,activo) values ";
                comando.CommandText += "('" + nuevo.user + "','" + nuevo.pass + "','" + nuevo.tipo + "', '"  + nuevo.activo + "')";
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

        public string leertipo(string user, string pass)
        {
            List<Usuario> listado = new List<Usuario>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Usuario u;
            u = new Usuario();
            try
            {
                accesoDatos.setearConsulta("select UserName,Llave,tipo from Usuario");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {

                    u = new Usuario();
                    u.tipo = accesoDatos.Lector["tipo"].ToString();
                    u.user = accesoDatos.Lector["username"].ToString();
                    u.pass = accesoDatos.Lector["Llave"].ToString();
                    if (u.user == user && u.pass == pass)
                    {
                        return u.tipo;
                        break;
                    }

                }

                return u.tipo;
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
        public List<Usuario> listarUsuarios()
        {
            List<Usuario> listado = new List<Usuario>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Usuario usu = new Usuario();
            try
            {
                accesoDatos.setearConsulta("select loginID,UserName,Llave,tipo from Usuario as u where u.activo=1 ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    usu = new Usuario();
                    usu.id = (int)accesoDatos.Lector["loginID"];
                    usu.user = accesoDatos.Lector["userName"].ToString();
                    usu.pass = accesoDatos.Lector["Llave"].ToString();
                    usu.tipo= accesoDatos.Lector["tipo"].ToString();
                    listado.Add(usu);
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
    }

}

   