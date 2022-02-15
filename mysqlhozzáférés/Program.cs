using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace mysqlhozzáférés
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (MySqlConnection con = new MySqlConnection("server=localhost; " +
                                                             "port=3306; " +
                                                             "user=root; " +
                                                             "database=teszt; " +
                                                             "password="))
            {   con.Open();

                MySqlCommand cmd = new MySqlCommand("CREATE TABLE  IF NOT EXISTS tabla1 (name VARCHAR(30), birth_date DATE, sex CHAR(1), country VARCHAR(40));", con);
                
                cmd.ExecuteNonQuery();
                
                MySqlCommand cmd2 = new MySqlCommand("INSERT INTO  " +
                    "tabla1 (name,birth_date,sex,country) VALUES " +
                    " ('Hajni', '1976-07-05', 'F','Jugoszlavia');", con);
                cmd2.ExecuteNonQueryAsync();
                

                MySqlCommand cmd3 = new MySqlCommand("SELECT DISTINCT * FROM tabla1;",con);
                MySqlDataReader reader=cmd3.ExecuteReader();

                int sor = 0;
                while (reader.Read())
                {
                    Console.WriteLine($"{sor++ +1} {reader["name"]}\t{ reader["birth_date"]}\t{reader[2]}\t{reader[3]}");
                }
                
            }
            Console.WriteLine("vége");
        }
    }
}
