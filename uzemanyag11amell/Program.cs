using System;
using System.IO;
using System.Collections.Generic;

namespace uzemanyag11amell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tadat> adatok = new List<Tadat>();
            try
            {
                string[] adattomb = File.ReadAllLines("uzemanyag.txt");
                foreach (var adat in adattomb)
                {
                    adatok.Add(new Tadat(adat));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Hiba a file beolvasásánál!!!");         
            }

            //3
            Console.WriteLine($"3.feladat: Változások száma: {adatok.Count}");
            //4
            int minimKulombseg = int.MaxValue;
            foreach (var adat in adatok)
            {
                int kulombseg = adat.kulombseg();
                if (minimKulombseg > kulombseg)
                    minimKulombseg = kulombseg;
            }
            Console.WriteLine($"4.feladat: A legkisebb külömbség: {minimKulombseg}");

            //5
            int minKulSzama = 0;
            foreach (var adat in adatok)
            {
                if (adat.kulombseg() == minimKulombseg) minKulSzama++;
            }
            Console.WriteLine($"5.feladat: a legkisebb külömbségek előfordulása: {minKulSzama}");

            //6
            bool voltSzokonap = false;
            foreach (var adat in adatok)
            {
                if (adat.szokonap())
                {
                    voltSzokonap = true;
                    break;
                    
                }
            }
            if(voltSzokonap)
                Console.WriteLine($"6.feladat: Volt változás szökőnapon!");
            else
                Console.WriteLine($"6.feladat: NEM Volt változás szökőnapon!");

            //7
            StreamWriter fki = new StreamWriter("euro.txt");
            foreach (var adat in adatok)
            {
                //fki.WriteLine($"{adat.datum.ToShortDateString()};{(adat.benzin / 307.7):F2};{(adat.gazolaj / 307.7):F2} ");
                fki.WriteLine($"{adat.datum.Year}.{adat.datum.Month}.{adat.datum.Day};{(adat.benzin / 307.7):F2};{(adat.gazolaj / 307.7):F2} ");
            }
            fki.Close();

            //8
            int ev;
            do
            {
                Console.Write($"8.feladat: Kérem adja meg az évszámot [2011..2016]: ");
                ev = int.Parse(Console.ReadLine());

            } while (ev<2011 || ev>2016);





            Console.ReadKey();
        }
    }
}
