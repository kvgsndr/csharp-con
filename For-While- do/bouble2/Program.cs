using System;

namespace buuble2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            
            TombVéletlen(tomb);
            bubleSort(tomb);
            tombKiir(tomb);

            Console.ReadKey();
        }

        private static void TombVéletlen(int[] tomb)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(100);
            }
        }

        static void bubleSort(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = 0; j < tomb.Length - 1 - i; j++)
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

        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }

        }

        static void rendezo(int[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[i])
                    {
                        int c = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = c;
                    }
                }
            }


        }

    }
}
    

