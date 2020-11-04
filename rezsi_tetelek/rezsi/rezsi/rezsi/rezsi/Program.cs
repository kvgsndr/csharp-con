using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezsi
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Adatszerkezet létrehozása
            int[] villany = { 12569, 11896, 9632, 10458, 9450, 8974, 8450, 7933, 10789, 11453, 10694, 13654 };
            int[] víz = { 8300, 6310, 7200, 6780, 6930, 9870, 11587, 12863, 10000, 6320, 6981, 5690 };
            int[] gáz = { 28963, 25742, 13965, 9631, 2500, 2397, 2489, 3789, 7892, 14753, 18654, 27554 };
            string[] hónap = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };

            //2. Lista "táblázatos" formában
            Console.WriteLine("Hónap      Villany         Víz         Gáz");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < 12; i++)
            {
                string kiir = "";
                if (villany[i] < 10000) { kiir += " "; }
                kiir += villany[i] + " Ft    ";
                if (víz[i] < 10000) { kiir += " "; }
                kiir += víz[i] + " Ft    ";
                if (gáz[i] < 10000) { kiir += " "; }
                kiir += gáz[i] + " Ft";

                Console.WriteLine("{0,-12} {1}", hónap[i], kiir);
            }

            Console.WriteLine("---------------------------------------------");

            //3. Éves összesenek meghatározása
            int evesVillany = Összesít(villany);
            int evesVíz = Összesít(víz);
            int evesGáz = Összesít(gáz);
            Console.WriteLine("Éves villanydíjak összege: {0:# ###} Ft", evesVillany);
            Console.WriteLine("Éves vízdíjak összege    : {0:# ###} Ft", evesVíz);
            Console.WriteLine("Éves gázdíjak összege    : {0:# ###} Ft", evesGáz);

            //3.+ Tömb adatainak összegzése a Sum() fgv-nyel
            int összes = villany.Sum();
            Console.WriteLine("Éves villanydíjak összege: {0:# ###} Ft", összes);
            Console.WriteLine("---------------------------------------------");

            //4. Havi átlagok meghatározása
            double atlagVillany = Átlag(villany);
            double atlagVíz = Átlag(víz);
            double atlagGáz = Átlag(gáz);
            Console.WriteLine("Éves villanydíjak átlaga: {0:# ###} Ft", atlagVillany);
            Console.WriteLine("Éves vízdíjak átlaga    : {0:# ###} Ft", atlagVíz);
            Console.WriteLine("Éves gázdíjak átlaga    : {0:# ###} Ft", atlagGáz);

            //4.+ Tömb adatainak átlagszámítása Average() fgv-nyel
            double átlag = villany.Average();
            Console.WriteLine("Éves villanydíjak átlaga: {0:# ###} Ft", átlag);
            Console.WriteLine("---------------------------------------------");

            //5. Adjuk meg a legnagyobb fűtésszámla összegét és hónapját -> Maximum kiválasztás
            int maxertek = gáz[0];
            int maxhely = 0;
            for (int i = 1; i < 12; i++)
            {
                if (gáz[i] > maxertek)
                {
                    maxertek = gáz[i];
                    maxhely = i;
                }
            }
            Console.WriteLine("A legnagyobb fűtésszámla összege {0} Ft, hónapja: {1}.", maxertek, hónap[maxhely]);

            //6. Adjuk meg a legkisebb villanyszámla összegét és hónapját - Minimun kiválasztás
            int minertek = villany[0];
            int minhely = 0;
            for (int i = 1; i < 12; i++)
            {
                if (villany[i] < minertek)
                {
                    minertek = villany[i];
                    minhely = i;
                }
            }
            Console.WriteLine("A legkisebb villanyszámla összege {0} Ft, hónapja: {1}.", minertek, hónap[minhely]);

            //7. A legnagyobb vízdíj összeg és hónapja Max() fgv.nyel
            int maxVíz = víz.Max();
            for (int i = 0; i < 12; i++)
            {
                if (víz[i] == maxVíz)
                {
                    Console.WriteLine("A legnagyobb vízdíj összege {0} Ft, hónapja: {1}.", maxVíz, hónap[i]);
                    break;
                }
            }

            //8. Hány hónapban haladta meg a villanyszámla a gázszámla összegét -> Megszámlálás
            int db = 0;
            for (int i = 0; i < 11; i++)
            {
                if (villany[i] > gáz[i])
                {
                    db++;
                }
            }
            Console.WriteLine("{0} hónapban haladta meg a villanyszámla a gázszámlát.", db);

            //9. Volt-e olyan hónap, amikor a vízdíj magasabb volt, mint a villanyszámla? -> Eldöntés
            int j = 0;
            while (j < 12 && víz[j] <= villany[j])
            {
                j++;
            }
            if (j < 12)
            {
                Console.WriteLine("Volt olyan hónap (pl. {0}), amikor a vízdíj összeg magasabb volt, mint a villanyszámla összege.", hónap[j]);
            }
            else
            {
                Console.WriteLine("Nem volt olyan hónap, amikor a vízdíj összeg magasabb volt, mint a villanyszámla összege.");
            }

            Console.ReadKey();

        }

        private static double Átlag(int[] adatok)
        {
            double atlag = 0;
            foreach (int adat in adatok)
            {
                atlag += adat;
            }
            atlag /= adatok.Length;
            return atlag;
        }

        private static int Összesít(int[] adatok)
        {
            int osszeg = 0;
            foreach (int adat in adatok)
            {
                osszeg += adat;
            }
            return osszeg;
        }
    }
}
