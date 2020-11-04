using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    class Program
    {
        public static int[] pjegyek = new int[10];
        static void Main(string[] args)
        {
            general();
            kiir();
            bfeladat();
            Console.ReadKey();
        }

        private static void bfeladat()
        {
            
        }

        private static void kiir()
        {
            Console.WriteLine("Jegyek átlaga:");
            Console.WriteLine("================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. hónap jegye: {1}",(i+1),pjegyek[i]);
            }
        }

        private static void general()
        {
            Random vsz = new Random();
            for (int i = 0; i < 10; i++)
            {
                pjegyek[i] = vsz.Next(1, 6);
            }
        }
    }
}
