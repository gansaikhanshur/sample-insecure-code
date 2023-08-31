using System;
using System.Data.SqlClient;

namespace InsecureCodeExample
{
    class SQLInjectionExample
    {
        public static void Run()
        {
            Console.WriteLine("Enter a username:");
            string userInput = Console.ReadLine();

            string connectionString = "Server=myserver;Database=mydb;User Id=myuser;Password=mypassword;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insecure SQL query with user input
                string sqlQuery = "SELECT * FROM Users WHERE Username = '" + userInput + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["Username"]);
                }
            }
        }
    }
}
