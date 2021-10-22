using System;

namespace teglalap
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap t = new Teglalap(10, 20, new Pont(1.0, 1.0));
            Console.WriteLine(t.toString());
        }
    }
}
