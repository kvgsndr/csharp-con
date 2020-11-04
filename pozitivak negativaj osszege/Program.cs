using System;

namespace pozitivak_negativaj_osszege
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            int negat = 0;
            int pozit = 0; 

            do
            {
                Console.Write("Írj be egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                if (szam < 0)
                    negat += szam;
                else if (szam > 0)
                    pozit += szam;

            } while (szam !=0);

            Console.WriteLine(pozit);
            Console.WriteLine(negat);

        }
    }
}
