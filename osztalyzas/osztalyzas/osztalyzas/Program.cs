using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyzas
{
    class Program
    {
        public static string[] nevek = new string[5];
        public static int[] jegyek = new int[5];
        static void Main(string[] args)
        {
            feltoltes();
            vaneotos();
            egyesekdb();
            Console.ReadKey();
        }

        private static void egyesekdb()
        {
            int db = 0;
            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] == 1)
                {
                    db++;
                }
            }
            Console.WriteLine("Egyesek száma: {0}", db);
        }

        private static void vaneotos()
        {
            bool vane = false;
            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] == 5)
                {
                    Console.WriteLine("Ötöse van: {0}-nek",nevek[i]);
                    vane = true;
                }
            }
            if (vane)
            {

            } else
            {
                Console.WriteLine("Nem kapott senki sem ötöst!");
            }
        }

        private static void feltoltes()
        {
            for (int i = 0; i < jegyek.Length; i++)
            {
                Console.WriteLine("Kérem az {0}. nevet: ", i+1);
                nevek[i] = Console.ReadLine();
                Console.WriteLine("Kérem az {0}. jegyet: ", i + 1);
                do
                {
                
                jegyek[i] = Convert.ToInt32(Console.ReadLine());

                } while (jegyek[i]<1 || jegyek[i]>5);
                
            }
        }
    }
}
