using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace bancouh1.Capa_Logica
{
    public class Usuarios_CL
    {



        public static int Agregarusuarios(string correo, string nombre, string clave)
        {
           int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("Insert into USuarios (correo, clave, nombre) values (@correo,@clave,@nombre)", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int Eliminarusuarios(string correo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("delete from USuarios where correo = @correo", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int Actualizarusuarios(string correo, string nombre, string clave)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Capa_Logica.DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update USuarios set clave = @clave, nombre = @nombre where correo = @correo", Conn)
                    {
                        CommandType = CommandType.Text
                    };
                    cmd.Parameters.Add(new SqlParameter("@correo", correo));
                    cmd.Parameters.Add(new SqlParameter("@clave", clave));
                    cmd.Parameters.Add(new SqlParameter("@nombre", nombre));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = 0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public CapaDatos.Cls_Usuarios ObtenerUsuario(string correo)
        {
            // Aquí puedes agregar la lógica para obtener el usuario de la base de datos
            // Por ejemplo, podrías buscar en una lista o en una base de datos y devolver un objeto Cls_Usuarios
            return new CapaDatos.Cls_Usuarios(correo, "claveEjemplo", "nombreEjemplo");
        }

    }
}