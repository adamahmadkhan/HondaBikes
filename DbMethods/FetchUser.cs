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
        public static User login(string InputName)
        {
            MySqlConnection conn = DB.DbConnection.initConnection();
            User user = new User();
            Console.WriteLine(InputName);
            try
            {
                conn.Open();

                String query = $"SELECT * FROM users WHERE name = '{InputName}'";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                
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

        public static User CreateUser(string email,string username, string password)
        {
            MySqlConnection conn = DB.DbConnection.initConnection();
            User user = new User();
            //Console.WriteLine(InputName);
            try
            {
                conn.Open();

                String query = $"INSERT INTO users (email,name,password) VALUES ('{email}','{username}','{password}')";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();

               user.Email = email;
               user.Name = username;
               user.Password = password;
            return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user ;

        }
    }
}
