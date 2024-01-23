using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Modelos;

namespace Controladores
{
    public class ClienteAdmin : Conexion
    {

        public ClienteAdmin() { }
        /// <summary>
        /// Consulta todos los datos de la tabla
        /// </summary>
        /// <returns>datos de la tabla cliente</returns>
        public List<Cliente> Consultar()
        {
            Conectar();
            List<Cliente> lista = new List<Cliente>();
            Cliente modelo = null;
            try
            {
                var comando = cnn.CreateCommand();
                comando.CommandText = @"SELECT nombre, tipo_identificacion, identificacion, telefono, correo_electronico," +
                    "estatura, edad, responsable, numero_ingreso, id_cliente FROM cliente";
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector != null && lector.HasRows)
                {
                    while (lector.Read())
                    {
                        modelo = new Cliente();
                        modelo = new Cliente();
                        modelo.Nombre = (lector[0] + "");
                        modelo.TipoIdentificacion = (TipoIdentificacion)Enum.Parse(typeof(TipoIdentificacion), lector[1] + "");
                        modelo.Identificacion = (lector[2] + "");
                        modelo.Telefono = (lector[3] + "");
                        modelo.CorreoElectronico = (lector[4] + "");
                        modelo.Estatura = float.Parse(lector[5] + "");
                        modelo.Edad = int.Parse(lector[6] + "");
                        modelo.Responsable = lector[7] == null ? new Cliente(int.Parse(lector[7] + "")) : null;
                        modelo.NumeroIngreso = int.Parse(lector[8] + "");
                        modelo.Id = int.Parse(lector[9] + "");
                        lista.Add(modelo);
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

        /// <summary>
        /// consulta un cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns>datos de la persona</returns>
        public Cliente ConsultarCliente(string id)
        {
            Conectar();
            Cliente modelo = null;
            try
            {
                var comando = cnn.CreateCommand();
                comando.CommandText = @"SELECT nombre, tipo_identificacion, identificacion, telefono, correo_electronico," +
                    "estatura, edad, responsable, numero_ingreso, id_cliente FROM cliente WHERE identificacion = @identificacion";
                comando.Parameters.AddWithValue("@identificacion", id);
                MySqlDataReader lector = comando.ExecuteReader();
                
                if (lector != null && lector.HasRows)
                {
                    lector.Read();
                    modelo = new Cliente();
                    modelo.Nombre = (lector[0] + "");
                    modelo.TipoIdentificacion = (TipoIdentificacion)Enum.Parse(typeof(TipoIdentificacion), lector[1] + "");
                    modelo.Identificacion = (lector[2] + "");
                    modelo.Telefono = (lector[3] + "");
                    modelo.CorreoElectronico = (lector[4] + "");
                    modelo.Estatura = float.Parse(lector[5] + "");
                    modelo.Edad = int.Parse(lector[6] + "");
                    modelo.Responsable = lector[7] == null ? new Cliente(int.Parse(lector[7] + "")) : null;
                    modelo.NumeroIngreso = int.Parse(lector[8] + "");
                    modelo.Id = int.Parse(lector[9] + "");
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
            return modelo;
        }

        /// <summary>
        /// se guardan los datos
        /// </summary>
        /// <param name="modelo">Datos del cliente</param>

        public string Guardar(Cliente cliente) 
        {
            string msg = "Guardado";
            try
            {
                if (cliente != null)
                {
                    Cliente existe = ConsultarCliente(cliente.Identificacion);
                    Conectar();
                    if (existe == null)
                    {
                        var comando = cnn.CreateCommand();
                        comando.CommandText = @"INSERT INTO cliente (nombre, tipo_identificacion, identificacion, telefono, correo_electronico," +
                            "estatura, edad, responsable, numero_ingreso) VALUES (@nombre, @tipo_identificacion, @identificacion, @telefono," +
                            " @correo_electronico, @estatura, @edad, @responsable, @numero_ingreso)";
                        comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        comando.Parameters.AddWithValue("@tipo_identificacion", cliente.TipoIdentificacion);
                        comando.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                        comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                        comando.Parameters.AddWithValue("@correo_electronico", cliente.CorreoElectronico);
                        comando.Parameters.AddWithValue("@estatura", cliente.Estatura);
                        comando.Parameters.AddWithValue("@edad", cliente.Edad);
                        if (cliente.Responsable != null)
                        {
                            comando.Parameters.AddWithValue("@responsable", cliente.Responsable.Id);
                        }else
                        {
                            comando.Parameters.AddWithValue("@responsable", 0);
                        }

                        comando.Parameters.AddWithValue("@numero_ingreso", 1);
                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        var comando = cnn.CreateCommand();
                        comando.CommandText = @"UPDATE cliente SET numero_ingreso = @numero_ingreso " +
                            "wHERE identificacion = @identificacion";
                        comando.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                        comando.Parameters.AddWithValue("@numero_ingreso", existe.NumeroIngreso + 1);
                        comando.ExecuteNonQuery();
                    }
                }
            } catch (Exception ex)
            {
                msg = "Ocurrio un error consulte con el admin " + ex.Message;
                Console.WriteLine(ex.StackTrace);
            } finally
            {
                Desconectar();
            }
            return msg;
        }
    }
}
