using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patillos
{
    public class CONEXION_BD
    {
        public static MySqlConnection conexion()
        {
            string Servidor = "localhost";
            string Bd = "restarurant";
            string Usuario = "root";
            string Password = "12345678";

            string CadenaConexion = "Database =" + Bd + "; Server =" + Servidor + "; User =" + Usuario + "; Password =" + Password + ";";

            try
            {
                MySqlConnection ConexionBD = new MySqlConnection(CadenaConexion);
                return ConexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return null;
            }
        }
    }
}
