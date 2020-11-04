using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_tetelek1
{
    class Program
    {
        static public int[] szamok = new int[20];
        //static public int db = 0;
        static void Main(string[] args)
        {
            letrehozas();
            kiir();
            osszeg();
            Console.ReadKey();
        }

        private static void osszeg()
        {
            int szum = 0;
            for (int i = 0; i < 20; i++)
            {
                szum = szum + szamok[i];
            }
            Console.WriteLine("A számok összege: {0}", szum);
        }

        private static void kiir()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(szamok[i]);
            }
        }

        private static void letrehozas()
        {
            //Console.WriteLine("Add meg hány elemű legyen a tömb: ");
            //db = Convert.ToInt32(Console.ReadLine());

            Random vsz = new Random();
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = vsz.Next(1, 101);
            }

        }
    }
}
