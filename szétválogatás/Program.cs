using System;

namespace szétválogatás
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eldöntés tétele, kiválasztás tétele");
            Random rnd = new Random();
            Console.Write("Hány eleme legyen a tömbnek? ");
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            //feltöltés
            for (int i = 0; i < N; i++)
            {
                A[i] = rnd.Next(100) + 1;
            }
            //kiiratás
            foreach (int item in A)
            {
                Console.Write("{0}, ", item);
            }
            //Kiválogatás-megszámlálás
            int cv = 0;
            int[] paros = new int[N];
            int[] paratlan = new int[N];
            int parosdb = 0;
            int paratlandb = 0;
            for (cv = 0; cv < N; cv++)
            {
                if (A[cv] % 2 == 0)
                {
                    paros[parosdb] = A[cv];
                    parosdb = parosdb + 1;
                }
                else
                {
                    paratlan[paratlandb] = A[cv];
                    paratlandb = paratlandb + 1;
                }
            }
            //Kiiratás
            Console.WriteLine();
            Console.WriteLine("A tömbben {0} darab páros szám található", parosdb);
            for (int i = 0; i < parosdb; i++) Console.Write("{0}, ", paros[i]);
            Console.WriteLine();
            Console.WriteLine("A tömbben {0} darab páratlan szám található", paratlandb);
            for (int i = 0; i < paratlandb; i++) Console.Write("{0}, ",  paratlan[i]);
            Console.ReadLine();
        }
    }
}

