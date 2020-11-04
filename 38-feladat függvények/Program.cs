/*
    Állítson elő 8 egész számot a [0;100]-ban, és írja ki őket egy sorba!
    Egy függvény segítségével számolja ki a számok átlagát és írja ki 2 
    tizedes pontossággal!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_feladat_függvények
{
    class Program
    {   static void veletlen_feltolt(int[] t, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(101);
            }
        }

        static void tombKiir(int[] t, int n)
        {
            for (int  i = 0;  i < n;  i++)
            {
                Console.Write("{0,4}", t[i]);
            }
            Console.WriteLine();
        }

        static double tombAtlag(int[] t, int n)
        {
            long osszeg = 0;
            for (int i = 0; i < n; i++)
            {
                osszeg += t[i];
            }
            return (double)osszeg / n;
        
        }




        static void Main(string[] args)
        {
            int[] tomb = new int[8];
            veletlen_feltolt(tomb, 8);
            tombKiir(tomb, 8);
            Console.WriteLine("A tömb átlaga = {0:0.00}", tombAtlag(tomb, 8));


            Console.ReadKey();
        }
    }
}
