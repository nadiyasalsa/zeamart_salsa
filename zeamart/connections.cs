using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace zeamart
{
    internal class connections
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;

            try
            {
                string Connstring = "server = localhost;database= zeamart;uid=root;password=;";
                koneksi = new MySqlConnection(Connstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
