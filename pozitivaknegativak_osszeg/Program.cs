using System;

namespace pozitivaknegativak_osszeg
{
    class Program
    {
        static void Main(string[] args)
        {
            double osszeg = 0;
            double szorzat = 1;
            double szam;
            do
            {
                Console.Write("Írj be egy tetszőleges számot:  ");
                szam = Convert.ToDouble(Console.ReadLine());
                //string s = Console.ReadLine();
                //szam = Convert.ToDouble(s);

                if (szam > 0)
                {
                    szorzat *= szam;
                }
                else if (szam < 0)
                {
                    osszeg += szam;
                }    

            } while (szam != 0);

            Console.WriteLine("Negatívak összege = {0}", osszeg);
            Console.WriteLine("Pozitívak szorzata = {0}", szorzat);



        }
    }
}
