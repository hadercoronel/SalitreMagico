using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Conexion
    {
        protected MySqlConnection cnn;

        public void Conectar()
        {
            cnn = new MySqlConnection("datasource=127.0.0.1; port=3306; username=root;password=; database=db_salitre_magico;");
            
            try
            {
                cnn.Open();
                Console.WriteLine("Conectados!!");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        protected void Desconectar() 
        {
            try
            {
                cnn.Close();
                Console.WriteLine("Desconectados");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
