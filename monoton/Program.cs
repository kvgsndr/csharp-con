using System;

namespace monoton
{    //Adott egy hőmérsékletsorozat. Állapítsuk meg, hogy szigorúan monoton növekvekvő-e!
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írj be hőmérsékleteket:");
            int homerseklet1=int.MinValue, homerseklet2;
            bool monoton = true;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. hőmérséklet: ");
                 homerseklet2 = int.Parse(Console.ReadLine());
                if (homerseklet1 > homerseklet2) monoton = false;
                homerseklet1 = homerseklet2;
            }
            string s = monoton ? "MONOTON" : "Nem MONOTON";
            Console.WriteLine($"A hőmérséklet sorozat {s}");
        }
    }
}
