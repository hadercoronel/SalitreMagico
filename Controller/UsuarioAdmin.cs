using Modelos;
using Modelos.Enums;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class UsuarioAdmin : Conexion
    {
        public void guardar(Usuario usuario)
        {
            try
            {
                Conectar();

                if (usuario != null)
                {
                    var comando = cnn.CreateCommand();

                    comando.CommandText = @"INSERT INTO usuario (usr_nombre, usr_password) " +
                            "VALUES (@nombre,AES_ENCRYPT(@password,@clave))";
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@password", usuario.Password);
                    comando.Parameters.AddWithValue("@clave", "salitre");
                    comando.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        public Usuario verificarUsuario(Usuario usuario)
        {
            try
            {
                Conectar();
                if (usuario != null)
                {
                    var comando = cnn.CreateCommand();
                    comando.CommandText = @"SELECT id_usuario, usuario, estado FROM usuario " +
                        "WHERE @nombre = usuario;";
                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    MySqlDataReader reader = comando.ExecuteReader();
                    reader.Read();
                    return MapearUsuario(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return usuario;
        }

        public Usuario verificarPassword(Usuario usuario)
        {
            try
            {
                Conectar();
                if (usuario != null)
                {
                    using (var comando = cnn.CreateCommand())
                    {
                        comando.CommandText = @"SELECT id_usuario, usuario, estado FROM usuario " +
                            "WHERE @nombre = usuario && CAST(AES_DECRYPT(password, @clave) AS CHAR(20) CHARACTER SET utf8) = @password";
                        comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        comando.Parameters.AddWithValue("@password", usuario.Password);
                        comando.Parameters.AddWithValue("@clave", "salitre");
                        MySqlDataReader reader = comando.ExecuteReader();
                        reader.Read();
                        return MapearUsuario(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return usuario;
        }

        private Usuario MapearUsuario(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Usuario user = new Usuario
            {
                Id = int.Parse((string)dataReader["usuario"]),
                Nombre = (string)dataReader["password"],
                Estado = (string)dataReader["estado"]
            };
            return user;
        }

        public List<Rol> ConsultarRoles(string usuario)
        {
            Conectar();
            List<Rol> lista = new List<Rol>();
            try
            {
                var comando = cnn.CreateCommand();
                comando.CommandText = @"SELECT tipo_empleado FROM usuario, rol_usuario where usuario = @usuario";
                comando.Parameters.AddWithValue("@usuario", usuario);
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector != null && lector.HasRows)
                {
                    while (lector.Read())
                    {                       
                        lista.Add((Rol)Enum.Parse(typeof(Rol), lector[0] + ""));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return lista;
        }

        private Empleado MapearEmpleado(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Empleado empleado = new Empleado();
            empleado.Id = int.Parse(dataReader[0].ToString());
              empleado.Nombre = (string)dataReader[1];
            return empleado;
        }
        public Empleado verificarEmpleado(Usuario usuario)
        {
            Empleado empleado = null;
            try
            {
                Conectar();
                if (usuario != null)
                {
                    using (var comando = cnn.CreateCommand())
                    {
                        comando.CommandText = @"SELECT e.id_empleado, e.nombre FROM usuario u, empleado e where u.usuario = @usuario AND u.id_empleado = e.id_empleado;";
                        comando.Parameters.AddWithValue("@usuario", usuario.Nombre);
                        MySqlDataReader reader = comando.ExecuteReader();
                        reader.Read();
                         empleado = MapearEmpleado(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return empleado;
        }

    }
}
