using System;

namespace ponthatárok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a pontszámokat (elért/maximum--  82/100)");
            string pontok = Console.ReadLine();
            int pont, max;
            pontok=pontok.Trim();
            int  perPoz=pontok.IndexOf('/');
            max = int.Parse(pontok.Substring(perPoz+1));
            pont = int.Parse(pontok.Substring(0, perPoz));

            var ertek = pontok.Split('/');
            pont = int.Parse(ertek[0]);
            max = int.Parse(ertek[1]);

            double szazalek = ((double)pont / max) * 100;
            if(szazalek>=90)
                Console.WriteLine("Jeles(5)");
            else if (szazalek >= 75)
                Console.WriteLine("Jó(4)");
            else if (szazalek >= 60)
                Console.WriteLine("Közepes(3)");
            else if (szazalek >= 50)
                Console.WriteLine("Elégséges(2)");
            else
                Console.WriteLine("Elégtelen(1)");




             Console.ReadKey();
        }
    }
}
