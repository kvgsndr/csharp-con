/*
 1.Írj egy programot, amely egy N elemet tartalmazó tömbről megmondja, 
   hogy a szomszédos elemek között mekkora legnagyobb különbség!  
 */

using System;

namespace feladatok_1_30
{
    class Program
    {
        static void Main(string[] args)

        {

            Random rnd = new Random();

            Console.Write("Tömb elemeinek száma: ");

            int N = Convert.ToInt32(Console.ReadLine());

            int[] tomb = new int[N];

            for (int i = 0; i < N; i++)
            {
                tomb[i] = rnd.Next(100);
            }
            int max = 0;
            for (int i = 0; i < N - 1; i++)
            {
                int kulombseg = Math.Abs(tomb[i] - tomb[i + 1]);
                if (max < kulombseg)
                    max = kulombseg;
            }

            for (int i = 0; i < N; i++)
                Console.Write("{0,3}", tomb[i]);
            
            Console.WriteLine("\nMaximális külömbség: {0}", max);
            Console.ReadKey();
        }
    }
}
