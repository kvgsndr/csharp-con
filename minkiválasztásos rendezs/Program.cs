using System;

namespace minkiválasztásos_rendezs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb1 = { 2, 5, 8, 9, 4, 6, 3, 7, 1, 5, 4, 9, 8, 15, 47 };
            int[] tomb2 = tomb1;
            min_rendez(tomb1);
            tomb_kiir(tomb1);
            max_rendez(tomb2);

            tomb_kiir(tomb2);
          

            Console.ReadKey();
        }

        private static void max_rendez(int[] tomb2)
         {
            for (int i = 0; i < tomb2.Length - 1; i++)
            {
                int max = i;
                for (int j = i; j < tomb2.Length; j++)
                {
                    if (tomb2[max] < tomb2[j]) max = j;
                }
                int tmp = tomb2[i];
                tomb2[i] = tomb2[max];
                tomb2[max] = tmp;
            }
        }

        private static void tomb_kiir(int[] tomb)
        {
            foreach (int v in tomb)
            {
                Console.Write("{0} ", v);
            }
            Console.WriteLine();
        }

        private static void min_rendez(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int min = i;
                for (int j = i; j < tomb.Length; j++)
                {
                    if (tomb[min] > tomb[j]) min = j;
                }
                int tmp = tomb[i];
                tomb[i] = tomb[min];
                tomb[min] = tmp;
            }
        }
    }
}
