using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("N= ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[N];
            for (int i = 0; i < N; i++)
            {
                tomb[i] = rnd.Next(100);
            }
            int min = 200;

            for (int i = 0; i < N-1; i++)
            {
                for (int j = i+1; j < N; j++)
                { int k = Math.Abs(tomb[i] - tomb[j]);
                    if (k<min)
                    {
                        min = k;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0,4}", tomb[i]);
            }
            Console.WriteLine("\nLegkisebb külömbség = {0}", min);
            Console.ReadKey();
        }
    }
}
