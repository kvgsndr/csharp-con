using System;
using System.Linq;

namespace max3min3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            int[] rend = new int[10];

            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(20);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,3}", tomb[i]);
            }
            Console.WriteLine();

            Array.Sort(tomb); 
            //tomb=tomb.OrderBy( x => x).ToArray();
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,3}", tomb[i]);
            }

            Console.WriteLine("\n\nLegkisebbek:{0} {1} {2} \nLegnagyobbak:{3} {4} {5}",
                tomb[0], tomb[1], tomb[2], tomb[tomb.Length-1], tomb[tomb.Length-2], tomb[tomb.Length-3]);
                


            Console.ReadKey();

        }
    }
}
