using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal f0 = 0, f1 = 1, fn=0;

            Console.Write("Írj be egy pozitív egész számot:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                fn = f1 + f0;
                f0 = f1;
                f1 = fn;
                Console.WriteLine(fn);
            }
            Console.Write($"Fibonacci számsor {n}. eleme={fn}");

        }
    }
}
