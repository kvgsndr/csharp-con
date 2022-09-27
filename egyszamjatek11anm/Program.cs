using System;
using System.Collections.Generic;
using System.IO;

namespace egyszamjatek11anm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tjatekos> jatek = new List<Tjatekos>();

            try 
            { 
                StreamReader fbe = new StreamReader("egyszamjatek.txt");
                while (!fbe.EndOfStream)
                {
                    jatek.Add(new Tjatekos(fbe.ReadLine()));
                }
                fbe.Close();


            }
            catch(Exception e)
            {
                Console.WriteLine($"HIBA!!!\n {e.Message}");
            }

            Console.WriteLine($"3.feladat: Játékosok száma: {jatek.Count}");
            int fordulokSzama = jatek[0].tippek.Count;
            Console.WriteLine($"4.feladat: Fordulók száma: {fordulokSzama}");
//5.
            bool voltEgyes = false;
            foreach (var elem in jatek)
            {
                if (elem.tippek[0] == 1)
                {
                    voltEgyes = true;
                    break;
                } 
            }
            string ered = voltEgyes ? "volt" : "NEM volt";
            Console.WriteLine($"5.feladat: Az első fordulóban {ered} egyes tipp!");

//6.
            int maxTipp = 0;
            foreach (var elem in jatek)
            {
                foreach ( var tipp in elem.tippek)
                {
                    if (tipp > maxTipp) maxTipp = tipp;
                }
            }
            Console.WriteLine($"6.feladat: A legnagyobb tipp a fordulók során: {maxTipp}");
            //7.
            Console.Write($"7. feladat: Kérem a forduló sorszámát[1−{fordulokSzama}]: ");
            int fordulo = int.Parse(Console.ReadLine());
            if (fordulo < 1 || fordulo > fordulokSzama)
                fordulo = 1;
            //8
            int[] tippSzamol = new int[100];

            foreach (var eleme in jatek)
            {
                tippSzamol[eleme.tippek[fordulo - 1]]++;
            }
            bool voltgyoztes = false;
            int gyoztes = 0;
            for (int i = 1; i <=99; i++)
            {
                if (tippSzamol[i] == 1)
                {
                    voltgyoztes = true;
                    gyoztes = i;
                    break;
                }
            }
            if (voltgyoztes)
                Console.WriteLine($"8.feladat: A nyertes tipp a megadott fordulóban: {gyoztes}");
            else
                Console.WriteLine("8.feladat: Nem volt egyedi tipp a megadott fordulóban!");

            //9
            string gyoztesNeve = "";
            foreach (var item in jatek )
            {
                if (item.tippek[fordulo - 1] == gyoztes)
                    gyoztesNeve = item.nev;

            }

            if (voltgyoztes)
                Console.WriteLine($"9.feladat: A megadott forduló nyertese {gyoztesNeve}");
            else
                Console.WriteLine("9.feladat: Nem volt nyertes a megadott fordulóban!");
            //10
            if (voltgyoztes)
            {
                StreamWriter fki = new StreamWriter("nyertes.txt");
                fki.WriteLine($"Forduló sorszáma: {fordulo}");
                fki.WriteLine($"Nyertes tipp: {gyoztes}");
                fki.WriteLine($"Nyertes játékos:{gyoztesNeve}");
                fki.Close();
            }




            Console.ReadKey();
        }
    }
}
