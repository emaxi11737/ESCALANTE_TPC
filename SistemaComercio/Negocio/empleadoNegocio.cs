using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;
using System.Data.SqlClient;

namespace Negocio
{
    public class empleadoNegocio
    {
        public List<Empleado> listarEmpleado()
        {
            List<Empleado> listado = new List<Empleado>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Empleado empleado;
            try
            {
                accesoDatos.setearConsulta("Select Id, Nombre,Apellido,dni,direccion,localidad,mail,telefono from Empleados where activo = 1");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    empleado = new Empleado();
                    empleado.id = (int)accesoDatos.Lector["Id"];

                    if (!Convert.IsDBNull(accesoDatos.Lector["Nombre"]))
                    {
                        empleado.nombre = accesoDatos.Lector["Nombre"].ToString();
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["Apellido"]))
                    {
                        empleado.apellido = accesoDatos.Lector["Apellido"].ToString();
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["dni"]))
                    {
                        empleado.dni = accesoDatos.Lector["dni"].ToString();
                    }

                    if (!Convert.IsDBNull(accesoDatos.Lector["direccion"]))
                    {
                        empleado.direccion = accesoDatos.Lector["direccion"].ToString();
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["localidad"]))
                    {
                        empleado.localidad = accesoDatos.Lector["localidad"].ToString();
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["mail"]))
                    {
                        empleado.mail = accesoDatos.Lector["mail"].ToString();
                    }
                    if (!Convert.IsDBNull(accesoDatos.Lector["telefono"]))
                    {
                        empleado.telefono = accesoDatos.Lector["telefono"].ToString();
                    }





                    listado.Add(empleado);
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
        public void agregarEmpleado(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into Empleados (nombre,apellido ,dni, direccion,localidad,telefono,mail,activo) values";
                comando.CommandText += "('" + nuevo.nombre + "', '" + nuevo.apellido + "', '" + nuevo.dni + "', '" + nuevo.direccion + "', '" + nuevo.localidad +"', '" + nuevo.telefono + "', '" + nuevo.mail + "', '" + nuevo.activo + "')";
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
        public void modificarEmpleado(Empleado modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update EMPLEADOS Set nombre=@nombre, apellido=@apellido, dni=@dni,direccion=@direccion, localidad=@localidad,mail=@mail,telefono=@telefono Where Id=" + modificar.id.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nombre", modificar.nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@apellido", modificar.apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", modificar.dni);
                accesoDatos.Comando.Parameters.AddWithValue("@direccion", modificar.direccion);
                accesoDatos.Comando.Parameters.AddWithValue("@localidad", modificar.localidad);
                accesoDatos.Comando.Parameters.AddWithValue("@mail", modificar.mail);
                accesoDatos.Comando.Parameters.AddWithValue("@telefono", modificar.telefono);


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
        public void eliminarEmpleado(Empleado modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                modificar.activo = false;
                accesoDatos.setearConsulta("update Empleados Set activo=@ACTIVO Where Id=" + modificar.id.ToString());
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