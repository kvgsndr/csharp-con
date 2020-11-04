using System;

namespace háromszögek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be egy számot: ");
            int szam=Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i <= szam; i++)
            {
                for (int j = szam-i; j >0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <i ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= szam; i++)
            {
                for (int j = 0; j <i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = szam; k > i-1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
