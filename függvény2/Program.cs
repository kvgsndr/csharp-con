using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvény2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[5];
            
            
            tomb_beolvas(a);
            Console.WriteLine("A tömb:");
            tomb_kiir(a);
            tomb_beolvas(b);
            Console.WriteLine("B tömb:");
            tomb_kiir(b);

            Console.ReadKey();
        }
        static double osszead(double a, double b)
        {
            double eredmeny = a + b;  // rövidebb verzió
            return eredmeny;          // return (a+b);
        }

        static void tomb_beolvas(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Írd be a tömb {0}. elemét= ", i + 1);
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void tomb_kiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0,5}", tomb[i]);
            }
            Console.WriteLine();
        
        }
        static long tomb_osszeg(int[] tomb)
        {
            return 00;
        }



    }
}
