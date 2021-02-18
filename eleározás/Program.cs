using System;

namespace eleározás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írd be az első számot");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Írd be az második számot");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) Console.WriteLine("első negyed");
            else if (x < 0 && y > 0) Console.WriteLine("második negyed");
            else if (x < 0 && y < 0) Console.WriteLine("harmadik negyed");
            else if (x > 0 && y < 0) Console.WriteLine("negyedik negyed");
            else Console.WriteLine("a pont tengelyen");

            Console.ReadKey();

        }
    }
}
