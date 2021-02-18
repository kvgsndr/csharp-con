using System;
using System.IO;

namespace lotto5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[5];
            StreamReader fbe = new StreamReader("otos.csv");
            int[] sajatszamok = { 15, 18, 4,27,53 };
            int[] hetiszamok = new int[5];

            


            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(';');
                for (int i = 11,j=0; i < 16; i++, j++)
                {
                    hetiszamok[j] = int.Parse(elemek[i]);
                }
                int találatok = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (sajatszamok[i] == hetiszamok[j]) találatok++;
                    }
                }
                Console.WriteLine($"{elemek[1]}. hét {találatok}") ;
                





            
            }


        }
    }
}
