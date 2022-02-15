using System;
using System.Collections.Generic;
using System.IO;

namespace cbradio
{
    class Program
    {   //6
        static int AtszamolPercre(int ora, int perc)
        {
            return (ora * 60 + perc);
        }
        //Tadat[] adatok = new Tadat[500];
        static void Main(string[] args)
        {   //List<Tadat> adatok = new List<Tadat>();
            Tadat[] adatok = new Tadat[500];
            try
            {
                StreamReader fbe = new StreamReader("cb.txt");
                fbe.ReadLine();
                int n = 0;
                
                while (!fbe.EndOfStream)
                {
                    Tadat ad = new Tadat(fbe.ReadLine());
                    adatok[n] = ad;
                    n++;
                    //adatok.Add(new Tadat(fbe.ReadLine()));
                }
                fbe.Close();

                Console.WriteLine($"3.feladat: Bejegyzések száma: {n}");
                bool van4indit = false;
                for (int i = 0; i < n; i++)
                {
                    if (adatok[i].AdasDb == 4)
                    {
                        van4indit = true;
                        break;
                    }
                }
                string st = van4indit ? "Volt" : "Nem volt ";
                Console.WriteLine($"4. feladat: {st} négy adást indító sofőr");
                //5.
                Console.Write("Kérek egy nevet: ");
                string nev = Console.ReadLine();
                int darabHivas = 0;
                for (int i = 0; i < n; i++)
                {
                    if (adatok[i].Nev == nev) darabHivas += adatok[i].AdasDb;
                }

                if (darabHivas != 0)
                    Console.WriteLine($"{nev} {darabHivas}x használta a CB rádiót");
                else
                    Console.WriteLine("Nincs ilyen nevű sofőr!");

                //7
                StreamWriter fki = new StreamWriter("cb2.txt");
                fki.WriteLine("Kezdés;Név;AdasDB");
                for (int i = 0; i < n; i++)
                {
                    fki.WriteLine($"{AtszamolPercre(adatok[i].Ora, adatok[i].Perc)};{adatok[i].Nev};{adatok[i].AdasDb}");
                }
                fki.Close();

//8.Határozza meg és írja ki a minta szerint a sofőrök számát a forrásállományban található
//becenevek alapján! Feltételezheti, hogy nincs két azonos becenév.

//9.Határozza meg a legtöbb adást indító sofőr nevét! A sofőr neve és az általa indított hívások
//száma a minta szerint jelenen meg a képernyőn!





            }
            catch (Exception e)
            {
                Console.WriteLine($"HIBA!!! {e.Message}");
            }




            Console.ReadKey();
        }
    }
}
