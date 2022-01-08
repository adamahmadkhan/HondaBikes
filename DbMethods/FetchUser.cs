using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modern_Login.DbMethods
{
   
    static class FetchUser
    {
        public static User login()
        {
            MySqlConnection conn = DB.DbConnection.initConnection();
            User user = new User(); 
            try
            {
                conn.Open();

                String query = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("Afaq reader" + reader);
                 while (reader.Read())
                 {
                    String name = reader.GetString("name");
                    //int number = reader.GetInt32("room_number");
                    String password = reader.GetString("password");
                    //Room newRoom = null;
                    Console.WriteLine(user + "  " + password);
                    user.Name = name;
                    user.Password = password;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                return user;
            
        }
    }
}
