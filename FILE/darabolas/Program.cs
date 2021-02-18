using System;
using System.Collections.Generic;
using System.IO;

namespace darabolas
{
    class Program
    {    struct  Adatok
            {
                public string nev;
                public int csomagolas;
                public string mertekegyseg;
                public int rendelve;
                public int db;
            }



        static void Main(string[] args)
        {
            string fileName = "patika.csv";
            try
            {
                Adatok sorelemei = new Adatok();
                List<Adatok> adatok = new List<Adatok>();
                StreamReader fbe = new StreamReader(fileName);
                while( !fbe.EndOfStream )
                {
                    string sor = fbe.ReadLine();
                    var elemek = sor.Split(';');

                    sorelemei.nev = elemek[0];
                    sorelemei.csomagolas = int.Parse(elemek[1]);
                    sorelemei.mertekegyseg = elemek[2];
                    sorelemei.rendelve = int.Parse(elemek[3]);
                    sorelemei.db = Convert.ToInt32( elemek[4]);

                    adatok.Add(sorelemei);
                }

                // Hány darab különböző elemet rendeltek
                Console.WriteLine($"Elemek száma = {adatok.Count }");

                //Folyékony elemek száma?
                int folyekony = 0;
                for (int i = 0; i < adatok.Count; i++)
                    if (adatok[i].mertekegyseg == "ml") folyekony++;

                Console.WriteLine($"Folyékony = {folyekony}");





                







            }
            catch(Exception e)
            {
                Console.WriteLine("Hiba történt!!!\n {1}", e.Message );
                Console.ReadKey();
                return;

            }




            Console.ReadKey();  
        }
    }
}
