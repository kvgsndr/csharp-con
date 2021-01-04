/*    Írd ki az első 100 primm számot */
using System;

namespace _1000prim
{
    class Program
    {
        static void Main(string[] args)
        {
            int primekSzama = 1000;
            int szam = 1;
           while(primekSzama>0)
           { 
                int i = 2;
                while (szam % i != 0 && i <= szam / 2) i++;

                if (i > szam / 2)
                {
                    Console.Write($"{szam,5} ");
                    primekSzama--;
                }
                szam++;
           }
        }
    }
}
