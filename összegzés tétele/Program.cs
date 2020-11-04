using System;

namespace összegzés_tétele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            tombFeltolt(tomb);
            Console.WriteLine("TÖMB:");
            tombKiir(tomb);
            int N = 0;
            Console.Write("Összeadandó elemek száma (max 100)");
            if (int.TryParse(Console.ReadLine(), out N)  && N<=100 && N>0)
            {
                Console.WriteLine("A tömb első {0} elemének összege= {1}", N, tombNosszeg(tomb, N));
            }
            Console.WriteLine("A tömb elemeinek összege= {0}", tombOsszeg(tomb));
            long pozitivak = pozitivakOsszege(tomb);
            Console.WriteLine("Pozitívak összege = " + pozitivak.ToString());

            Console.ReadKey();
        }

        static void tombKiir(int[] t)
        {
            foreach (var item in t)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void tombFeltolt(int[] t)
        {
            Random rnd = new Random();
            for (int i = 0; i <t.Length ; i++)
            {
                t[i] = rnd.Next(-50,51);
            }
        }

        static long tombNosszeg(int[] t, int n)
        {
            long osszeg = 0;
            for (int i = 0; i < n; i++)
            {
                osszeg += t[i];
            }
            return osszeg;
           
        }

        static long tombOsszeg(int[] t)
        {
            long osszeg = 0;
            foreach (var item in t)
            {
                osszeg += item;
            }
            return osszeg;
        }

        static long pozitivakOsszege(int[] t)
        {
            long osszeg = 0;
            foreach (var item in t)
            {
                if (item> 0)
                {
                    osszeg = osszeg + item;

                }
            }
            return osszeg;
        }



    }
}
