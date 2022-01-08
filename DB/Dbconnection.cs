using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modern_Login.DB
{
    static class DbConnection
    {

        public static MySqlConnection initConnection()
        {
            String connectionString = $"server={Credentials.Server};" +
                $"user id={Credentials.UserID};" +
                $"password={Credentials.Password};" +
                $"database={Credentials.Database}";
            MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            try
            {

                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection Established.....!!!!!");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (conn.State == System.Data.ConnectionState.Closed) Console.WriteLine("Cannot establish the Database connection...");
                Console.WriteLine(ex.Message);
            }
            return new MySqlConnection(connectionString);
        }

    }
}
