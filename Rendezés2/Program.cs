using System;

namespace Rendezés2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 5, 8, 7, 6, 8, 7, 9, 2, 3, 5 };

            Console.WriteLine("Buborékos rendezés:");
            Buborekos(tomb);
            tomb_kiir(tomb);

            Console.WriteLine("Minimumkiválasztásos rendezés: ");
            int[] tomb2 = { 5, 8, 7, 6, 8, 7, 9, 2, 3, 5 };
            minkivalaszt_rendezes(tomb2);
            tomb_kiir(tomb2);




            Console.ReadKey();
        }

        private static void minkivalaszt_rendezes(int[] tomb2)
        {
            for (int i = 0; i < tomb2.Length - 1; i++)
            {
                int min = i;
                for (int j = i; j < tomb2.Length; j++)
                    if (tomb2[j] < tomb2[min]) min = j;
                int tmp = tomb2[i];
                tomb2[i] = tomb2[min];
                tomb2[min] = tmp;
            }
        }

        private static void tomb_kiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
                Console.Write("{0} ", tomb[i]);
            Console.WriteLine();
        }

        private static void Buborekos(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 2; i++)
                for (int j = 0; j < tomb.Length - 1; j++)
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                    }
        }
    }
}
