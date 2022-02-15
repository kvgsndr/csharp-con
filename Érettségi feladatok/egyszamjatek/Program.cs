using System;
using System.Collections.Generic;
using System.IO;

namespace egyszamjatek
{
    class Program
    {public class Adat
               {
                public string nev;
                //int[] tippek = new int[10];
                public List<int> tippek = new List<int>();

               }
        static void Main(string[] args)
        {
            
            StreamReader fbe = new StreamReader("egyszamjatek1.txt");
            List<Adat> adatok = new List<Adat>();
            while(!fbe.EndOfStream)
            {
                Adat egysorAdat = new Adat();
                string sor = fbe.ReadLine();
                string[] elemek = sor.Split(' ');
                egysorAdat.nev = elemek[0];
                for (int i=1; i< elemek.Length; i++)
                {
                    egysorAdat.tippek.Add(Convert.ToInt32(elemek[i]));
                }
                adatok.Add(egysorAdat);
            }
            Console.WriteLine($"3.Feladat: A jatekosok szama: {adatok.Count} fő");
            Console.Write($"4.Feladat: Kérem a forduló sorszámát:");
            int fordulo_sorszam = int.Parse(Console.ReadLine());

            float osszeg = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                osszeg += adatok[i].tippek[fordulo_sorszam-1];
            }
            Console.WriteLine($"5. feladat: A megadott forduló tippjeinek átlaga: {(osszeg / adatok.Count):F2}");


        }
    }
}
