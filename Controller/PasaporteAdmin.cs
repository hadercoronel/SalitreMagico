using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;

namespace Controladores
{
    public class PasaporteAdmin : Conexion
    {
       
        /// <summary>
        /// Se guardan los datos de los pasaportes comprados
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Mensaje de guardado.</returns>
        public string Guardar(Pasaporte pasaporte)
        {
            string msg = "Guardado";
            try
            {
                if (pasaporte != null)
                {
                    ClienteAdmin clienteAdmin = new ClienteAdmin();
                    Cliente existe = clienteAdmin.ConsultarCliente(pasaporte.Cliente.Identificacion);
                    Conectar();
                    if (existe != null)
                    {
                        var comando = cnn.CreateCommand();
                        comando.CommandText = @"INSERT INTO pasaporte (tipo_pasaporte, fecha, descripcion, precio_regular," +
                            "id_cliente, numero_estacion, estado, id_empleado) VALUES (@tipo_pasaporte, @fecha, @descripcion, @precio_regular," +
                            " @id_cliente, @numero_estacion, @estado, @id_empleado)";
                        comando.Parameters.AddWithValue("@tipo_pasaporte", pasaporte.TipoPasaporte);
                        comando.Parameters.AddWithValue("@fecha", pasaporte.Fecha);
                        comando.Parameters.AddWithValue("@descripcion", pasaporte.Descripcion);
                        comando.Parameters.AddWithValue("@precio_regular", pasaporte.Precio);
                        pasaporte.Cliente = existe;
                        if (pasaporte.Cliente != null)
                        {
                            comando.Parameters.AddWithValue("@id_cliente", pasaporte.Cliente.Id);
                        }
                        comando.Parameters.AddWithValue("@numero_estacion", pasaporte.NumeroEstacion);
                        comando.Parameters.AddWithValue("@estado", pasaporte.Estado);
                        comando.Parameters.AddWithValue("@id_empleado", pasaporte.Empleado.Id);
                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Cliente no esta registrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                msg = "Ocurrio un error consulte con el admin " + ex.Message;
                Console.WriteLine(ex.StackTrace);
            }
            finally 
            {
                Desconectar();
            }
            return msg;
        }
    }
}
