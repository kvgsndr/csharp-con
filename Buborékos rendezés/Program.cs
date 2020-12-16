using System;

namespace Buborékos_rendezés
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            Random rnd = new Random();
            TombVéletlen(tomb, rnd);
            NewMethod(tomb);
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }
            Console.ReadKey();

            static void NewMethod(int[] tomb)
            {
                for (int i = 0; i < 100 - 1; i++)
                {
                    for (int j = 0; j < 100 - 1 - i; j++)
                    {
                        if (tomb[j] > tomb[j + 1])
                        {
                            int s = tomb[j];
                            tomb[j] = tomb[j + 1];
                            tomb[j + 1] = s;

                        }

                    }
                }
            }
        }

        private static void TombVéletlen(int[] tomb, Random rnd)
        {
            for (int i = 0; i < 100; i++)
            {
                tomb[i] = rnd.Next(100);
            }
        }
    }
}
