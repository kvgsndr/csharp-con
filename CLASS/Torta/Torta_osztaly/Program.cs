using System;

namespace Torta_osztaly
{
    class Program
    {
        static void Main(string[] args)
        {
            Torta torta1 = new Torta(3, true);
            Torta torta2 = new Torta();

            Console.WriteLine($"Torta 2 megkenve: {torta2.kremmelMegken()}");
            Console.WriteLine($"Torta 2 megkenve: {torta2.kremmelMegken()}");
            torta1.ujEmelet();
            torta1.toString();

            Console.ReadKey();

        }
    }
}
