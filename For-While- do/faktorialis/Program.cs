using System;

namespace faktorialis
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fakt = 1;
            Console.WriteLine("Faktoriális kiszámítása:");
            int szam = 0 /* Convert.ToInt32(Console.ReadLine())*/;
         while(szam<=27)
            {
                fakt = 1;
                if (szam == 0)
                    Console.WriteLine($"{szam}! = 1");
                else
                {
                    for (int i = 2; i <= szam; i++)
                    {
                        fakt *= i;
                    }
                    Console.WriteLine($"{szam}! = {fakt}");

                }
                szam++;
            }
            
                
        }
    }
}
