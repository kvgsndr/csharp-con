using System;
using System.Collections.Generic;
using System.IO;

namespace egyszamjatekCLI
{   class Jatekos
    {
        string nev;
        public List<int> tippek = new List<int>();
        
        public Jatekos(string sor)
        {
            string[] elemek = sor.Split(' ');
            nev = elemek[0];
            for(int i=1;i<elemek.Length;i++)
            {
                tippek.Add(int.Parse(elemek[i]));
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> jatekosok = new List<Jatekos>();
            string[] adatok = File.ReadAllLines("egyszamjatek1.txt");
            foreach (var item in adatok)
            {
                jatekosok.Add(new Jatekos(item));
            }

            Console.WriteLine("3. feladat: Játékosok száma: {0} fő", jatekosok.Count);
            Console.Write("4. feladat: Kérem a forduló sorszámát: ");
            int fordulo = int.Parse(Console.ReadLine());

            long osszeg = 0;
            for (int i = 0; i < jatekosok.Count; i++)
            {
                osszeg += jatekosok[i].tippek[fordulo-1];
            }
            Console.WriteLine("5. feladat: A megadott forduló tipjeinek átlaga: {0}", ((float)osszeg / jatekosok.Count));



            Console.ReadKey();
        }
    }
}
