/*    Írd ki az első 100 primm számot */
using System;

namespace _1000prim
{
    class Program
    {
        static void Main(string[] args)
        {
            int primekSzama = 1000;
            /*int szam = 1;

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
             */
            Console.WriteLine("Írd be a prim sorszámát (max 1000)");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            int primek = 0;
            int p = 1;
            do
            { int i = 1;
                do
                {
                    i++;

                } while (p%i!=0  &&   i<=p/2 );

                if (i > p / 2 )primek++;
                
                if(primek==sorszam && i> p/2) Console.WriteLine(p);
                p++;
            } while (primek<primekSzama);




        }
    }
}
