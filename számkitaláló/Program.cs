using System;

namespace számkitaláló
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam , tipp , tippekSzama = 0;

            Random rnd = new Random();
            szam = rnd.Next(100) + 1;// 1-100
            do
            {
                Console.Write("TIPP= ");
                tipp = Convert.ToInt32(Console.ReadLine());
                tippekSzama++;
                if (szam > tipp)
                    Console.WriteLine("A szám nagyobb!");
                else if (szam < tipp)
                    Console.WriteLine("A szám kisebb!");

            } while (szam != tipp);
            Console.WriteLine("Ügyes vagy {0} ból kitaláltad!!! :)", tippekSzama);
            Console.ReadKey();
        }
    }
}
