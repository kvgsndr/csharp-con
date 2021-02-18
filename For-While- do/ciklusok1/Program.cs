
using System;

namespace ciklusok1
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            //Kérjünk be 1 számot és határozzuk meg az osztóit
            int szam;
            Console.Write("Írj be egy számot: ");
            szam = int.Parse(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0) Console.Write(i.ToString() + " ");
            }
           
            //Határozd meg két adott szám legnagyobb közös osztóját

            Console.Write("Írd be az 1 számot: ");
            int szam1= int.Parse(Console.ReadLine());
            Console.Write("Írd be az 2 számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            int oszt = szam1 > szam2 ? szam2 : szam1; // kissebb meghatározása

            for (int i = oszt; i>=1; i--)
            {
                if(szam1%i==0 && szam2%i==0)
                {
                    Console.WriteLine("A legnagyobb közös osztó = {0}", i);
                    break;

                }
            }
             


            // Prim -e
            Console.Write("Írd be az 1 számot: ");
            int szam3 = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i <= szam3/2; i++)
            {
                if (szam3 % i == 0)
                {
                    prim = false;
                    break;
                }
            }

            Console.WriteLine($"A beírt szám prim : {prim}");

            */

            // írd ki a primeket 1000 ig

            for (int szam = 1; szam <= 1000; szam++)
            {
                
                bool prim = true;
                int i;
                for ( i = 2; i <= szam / 2; i++)
                {
                    if (szam % i == 0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim) Console.WriteLine(szam);
            }

            //Házi feladat : Írjuk ki az adott szám primtényezős szorzatát   6=2*3    12=2*2*3







            Console.ReadKey();
        }
    }
}
