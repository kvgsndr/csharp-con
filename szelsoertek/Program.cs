using System;

namespace szelsoertek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = { "első", "második", "harmadik", "negyedik", "is" };
            int[] szamok = { 5, 8, 9, 7, 4, 2, 30, 6, 7, 1, 3, 5 };
            int[] eredmeny = new int[szamok.Length];
            int k = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == 7)
                {
                    Console.WriteLine(" A 7 szám a {0} helyen található ", i);
                    eredmeny[k] = i;
                    k++;

                }

            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(" A 7 szám a {0} helyen található ", eredmeny[i]);
            }

            int ii = 0;
            Console.WriteLine();
            while (szamok[ii]!=7 && ii<szamok.Length) ii++;

            if (ii< szamok.Length)
                Console.WriteLine(" A 7 szám a {0} helyen található ", ii);
            else
                Console.WriteLine(" A 7 szám nincsen benne a tömbben!");


            //max
            int max = 0;
            for (int i = 0; i < szamok.Length; i++)
                if (szamok[max]<szamok[i])
                     max=i;
          
            Console.WriteLine("MAX= {0}", szamok[max]);

            Console.Write(" A legrövidebb szó: ");
            string szo = szavak[0];
            int min = szavak[0].Length;

            for (int i = 0; i < szavak.Length; i++)
                if (min > szavak[i].Length)
                {
                    min = szavak[i].Length;
                    szo = szavak[i];
                }
            Console.WriteLine(szo);



            Console.ReadKey();
        }
    }
}
