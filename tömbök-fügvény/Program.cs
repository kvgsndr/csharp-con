using System;

namespace tömbök_fügvény
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[5];
            tombFeltolt(tomb);
            Console.WriteLine("Tömb elemei:");
            tombKiir(tomb);

            Console.WriteLine("Tömb minimuma = {0}", tombMin(tomb));
            Console.WriteLine("Tömb maximuma = {0}", tombMax(tomb));
            Console.WriteLine("Tömb elemeinek összege= {0}", tombOsszeg(tomb));
            Console.WriteLine("Tömb átlaga = {0}", tombAtlag(tomb));
            Console.WriteLine("Az átlaghoz legközelebbi elem {0}", kozelazAtlaghoz(tomb));

            Console.ReadKey();
        }

        static void tombFeltolt(int[] t)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(50);
            }
         }

        static void tombKiir(int[] t)
        {
            foreach (var item in t)
            {
                Console.Write("{0,4}", item);
            }
            Console.WriteLine();
        }

        static int tombMin(int[] t)
        {
            int min = t[0];
            foreach (var item in t)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        static int tombMax(int[] t)
        {
            int max = t[0];
            foreach (var item in t)
            {
                if (item > max)
                    max = item;
            }
            return max;
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

        static double tombAtlag(int[] t)
        {
            return (double)tombOsszeg(t) / t.Length;
                
        }

        static int kozelazAtlaghoz(int[] t)
        {
            int leg=0;
            double atlag = tombAtlag(t);
            double minkulombseg = tombMax(t);
            foreach (var item in t)
            {   
                double kulombseg = Math.Abs( atlag - item);
                if (kulombseg < minkulombseg)
                {
                    minkulombseg = kulombseg;
                    leg = item;

                }

            }
            return leg;
        }

    }
}
