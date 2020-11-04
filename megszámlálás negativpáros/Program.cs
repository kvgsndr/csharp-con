using System;

namespace megszámlálás_negativpáros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be számoka NULLA végjelig!");
            int negativparos = 0, szam;
            do
            {
                Console.Write("Írd be a számot: ");
                 szam = Convert.ToInt32(Console.ReadLine());
                if (szam<0 && szam%2==0) negativparos++;
            } while (szam != 0);
            Console.WriteLine("Negatív páros számok: {0}", negativparos);
            Console.ReadKey();

        }
    }
}
