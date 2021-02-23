using System;

namespace Harcos_11d
{
    class Program
    {
        static void Main(string[] args)
        {
            Harcos h1 = new Harcos("Laci", 100, 5);
            Harcos h2 = new Harcos("Kati", 100, 4);

            while (!h1.harcol(h2))
            {
                h1.toString();
                h2.toString();
            }
            Console.ReadKey();

        }
    }
}
