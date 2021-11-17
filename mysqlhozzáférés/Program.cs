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
                //MySqlCommand cmd = new MySqlCommand("CREATE TABLE table_1 (name VARCHAR(30), birth_date DATE, sex CHAR(1), country VARCHAR(40));", con);
                //MySqlDataReader reader=cmd.ExecuteReader();
                MySqlCommand cmd2 = new MySqlCommand("INSERT INTO  " +
                    "table_1 (name,birth_date,sex,country) VALUES " +
                    " ('Hajni', '1976-07-05', 'F','Jugoszlavia');", con);
                MySqlDataReader reader = cmd2.ExecuteReader();
                reader.Close();
                
                MySqlCommand cmd3= new MySqlCommand("SELECT * FROM table_1;",con);
                MySqlDataReader reader1 = cmd3.ExecuteReader();

                int sor = 0;
                while (reader1.Read())
                {
                    Console.WriteLine($"{sor++ +1} {reader1["name"]}\t{ reader1["birth_date"]}\t{reader1[2]}\t{reader1[3]}");
                }
                
            }
            Console.WriteLine("vége");
        }
    }
}
