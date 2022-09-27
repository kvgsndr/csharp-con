using System;
using System.Collections.Generic;
using System.IO;

namespace egyszamjatek11amell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tadat> adatok = new List<Tadat>();
            
            try
            {   StreamReader fbe = new StreamReader("egyszamjatek.txt");
                while (!fbe.EndOfStream)
                {
                    adatok.Add(new Tadat(fbe.ReadLine()));
                }
                fbe.Close();
            }
            catch (Exception kivetel)
            {
                Console.WriteLine($"HIBA!!!\n {kivetel.Message}");
            }
            int fordulokSzama = adatok[0].tippek.Count;
            Console.WriteLine($"3.feladat: Játékosok száma: {adatok.Count}");
            Console.WriteLine($"4.feladat: Fordulók száma: {fordulokSzama}");
            //5
            bool vanEgyes = false;
            foreach (var adat in adatok)
            {
                if (adat.tippek[0] == 1)
                {
                    vanEgyes = true;
                    break;
                }
            }
            string st = vanEgyes ? "volt" : "NEM volt";
            Console.WriteLine($"5.feladat: Az első fordulóban {st} egyes tipp!");

            //6
            int max = 0;
            foreach (var t in adatok)
            {
                int tmp = t.maxtipp();
                if (max < tmp) max = tmp;
            }
            Console.WriteLine($"6.feladat: A fordulók legnagyobb tippje: {max}");

            //7

            Console.Write($"7. feladat: Kérem a forduló sorszámát[1−{fordulokSzama}]:");
            int fordulo= int.Parse( Console.ReadLine());
            if (fordulo < 1 || fordulo > fordulokSzama)
                fordulo = 1;

            //8
            int[] mennyiTip = new int[100];

            foreach ( var t in adatok)
            {
                mennyiTip[ t.tippek[fordulo-1]]++;
            }

            bool vanNyertes = false;
            int nyertesIndex = 0;
            for (int i = 1; i < mennyiTip.Length; i++)
            {
                if (mennyiTip[i] == 1)
                {
                    vanNyertes = true;
                    nyertesIndex = i;
                    break;

                }
            }
            if (vanNyertes)
                Console.WriteLine($"8.feladat: A nyertes tipp az adott fordulóban: {nyertesIndex}");
            else
                Console.WriteLine($"8.feladat: Nem volt egyedi tipp  megadott fordulóban!");

            //9
            string nyertesNeve = "";
            foreach (var item in adatok)
            {
                if (item.tippek[fordulo - 1] == nyertesIndex)
                {
                    nyertesNeve = item.nev;
                    break;
                }

            }
            if (vanNyertes)
                Console.WriteLine($"9.feladat: A megadott forduló nyertese: {nyertesNeve}");
            else
                Console.WriteLine($"9.feladat: Nem volt nyertes a megadott fordulóban!");

            //10
            if (vanNyertes)
            {
                StreamWriter fki = new StreamWriter("nyertes.txt");
                fki.WriteLine($"Forduló sorszáma: {fordulo}.");
                fki.WriteLine($"Nyertes tipp: {nyertesIndex}");
                fki.WriteLine($"Nyertes játékos: {nyertesNeve}");
                fki.Close();
            }






            Console.ReadKey();
        }
    }
}
