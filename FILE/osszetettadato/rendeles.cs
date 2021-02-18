using System;
using System.Collections.Generic;
using System.IO;

namespace osszetettadato
{
    class rendeles
    {struct Adatok
               {
                   public string nev;
                   public int mennyiseg;
                   public  string mertekegyseg;
                   public  int rendeles;
                   public  int db;
                }

        static void Main(string[] args)
        {

            //string fileName = "patika.csv";   // elválasztó ;
            string fileName = "adatok.txt";   // tab elválasztó


            try 
            {
                StreamReader fbe = new StreamReader(fileName);
                Adatok adatsor;

                List<Adatok> osszadat = new List<Adatok>();

                while(!fbe.EndOfStream)
                {
                    string sor = fbe.ReadLine();
                    //var elemek = sor.Split(';');
                    var elemek = sor.Split((char)ConsoleKey.Tab, StringSplitOptions.RemoveEmptyEntries);
                    adatsor.nev = elemek[0];
                    adatsor.mennyiseg = int.Parse(elemek[1]);
                    adatsor.mertekegyseg = elemek[2];
                    adatsor.rendeles = int.Parse(elemek[3]);
                    adatsor.db = Convert.ToInt32(elemek[4]);
                    osszadat.Add(adatsor);
                 }

                // számold meg az a betüvel kezdődő rendeléseket
                int n = 0;
                for (int i = 0; i < osszadat.Count; i++)
                {
                    if (osszadat[i].nev[0] == 'A')
                    {
                        n++;
                        Console.WriteLine(osszadat[i].nev);

                    }
                        
                }
                Console.WriteLine($"Az \'A\' betűvel kezdődő rendelések száma {n}") ;




            }
            catch(Exception e)
            {
                Console.WriteLine($"Hiba történt!!!\n\n {e.Message}");

            }

            
        }
    }
}
