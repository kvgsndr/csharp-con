using System;
using MySql.Data.MySqlClient;
using System.IO;

namespace WebShopDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySqlConnection con = new MySqlConnection("server=localhost; " +
                                                                "port=3306; " +
                                                                "user=root; " +
                                                                "database=webshop; " +
                                                                "password="))
            {
                con.Open();

                //MySqlCommand cmdTermekek = new MySqlCommand("create table IF NOT EXISTS termekek ( " +
                //    "id int not null AUTO_INCREMENT PRIMARY key, " +
                //    "megnevezes varchar(40) not null UNIQUE," +
                //    " ar numeric(10, 0)); ", con);
                
                //cmdTermekek.ExecuteNonQueryAsync();

                //MySqlCommand cmdVevok = new MySqlCommand(" create table IF NOT EXISTS vevok ( id int not null AUTO_INCREMENT PRIMARY key,    " +
                //    "nev varchar(100) not null,"+
                //    "iranyitoszam varchar(4),"+
                //    "telepules varchar(50)," +
                //    "utcahazszam varchar(100)); ", con);
                //cmdVevok.ExecuteNonQueryAsync();

                //MySqlCommand cmdSzamlafej = new MySqlCommand("create table IF NOT EXISTS szamlafej (" +
                //                            "id int not null AUTO_INCREMENT PRIMARY key,"+
                //                            "szamlaszam varchar(30) not null unique,"+
                //                            "kelt datetime not null,"+
                //                            "teljesites datetime not null,"+
                //                            "vevoid int not null); ", con);
                //cmdSzamlafej.ExecuteNonQueryAsync();

                //MySqlCommand cmdSzamlatetel = new MySqlCommand("create table IF NOT EXISTS szamlatetel (" +
                //        "id int not null AUTO_INCREMENT PRIMARY key,"+
                //        "szamlafejid int not null,"+
                //        "termekid int not null,"+
                //        "mennyiseg int not null,"+
                //        "mennyisegiegyseg varchar(20) not null,"+
                //        "bruttoegysegar numeric(10, 0) not null,"+
                //        "afaszazalek int not null); ", con);
                //cmdSzamlatetel.ExecuteNonQueryAsync();

                //string adatbe = "Insert into vevok(id, nev, iranyitoszam, telepules, utcahazszam) values ";

                //StreamReader fbe = new StreamReader("vevok.txt");
                //while (!fbe.EndOfStream)
                //{
                //    string adat = fbe.ReadLine();
                //    string parancs = adatbe + $" ({adat});";
                //    MySqlCommand par = new MySqlCommand(parancs, con);
                //    par.ExecuteNonQuery();
                //}



                string fel4 = "SELECT id, nev FROM vevok ;";

                MySqlCommand cmd = new MySqlCommand(fel4, con);

                MySqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine($"\t id \t nev");
                while ( reader.Read())
                {
                    Console.WriteLine($"\t {reader["id"]}\t{reader["nev"]}");

                }
                con.Close();

                Console.Write("Addmeg a kliens számát:");
                int szam = int.Parse(Console.ReadLine());


                Console.WriteLine("Új vevő beszúrása:");
                Console.Write("Vevő neve:");
                string nev = Console.ReadLine();
                Console.Write("Vevő irányítószáma:");
                int irSzam = int.Parse(Console.ReadLine());
                Console.Write("Település: ");
                string telepules = Console.ReadLine();
                Console.Write("Utca és házszám: ");
                string cim = Console.ReadLine();

                con.Open();
                cmd.CommandText = $" update vevok set nev= '{nev}', iranyitoszam={irSzam}, utcahazszam='{cim}'  where id={szam}; ";
                cmd.ExecuteNonQuery();
                con.Close();

                //con.Open();
                //cmd.CommandText = $"INSERT INTO vevok  (nev, iranyitoszam, telepules, utcahazszam)" +
                //    $" VALUES ('{nev}', {irSzam}, '{telepules}', '{cim}' ); ";
                //cmd.ExecuteNonQuery();
                //con.Close();
                //con.Open();

                //UPDATE táblázatnév SET m1 = e1[, m2 = e2..., mi = ei][WHERE feltétel];

                //cmd.CommandText = $" update vevok set nev = 'Félix'  where nev='Szabó'; ";
                //cmd.ExecuteNonQuery();
                //con.Close();



            }
        }
    }
}
