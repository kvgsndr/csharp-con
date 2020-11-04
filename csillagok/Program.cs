/*
*
**
***
****
*****

*****
****
***
**
*

    *
   **
  ***
 ****
*****

*****
 ****
  ***
   **
    * 
 
 */

using System;

namespace csillagok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írj be egy számot 1 és 20 között: ");
            int szam = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= szam; i++)
            {
                for (int j = 1 ; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            for (int i = szam; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            Console.WriteLine();

            for (int i = 1; i <= szam; i++)
            {   // szóközök kiírása
                for (int j = szam-i; j >=1 ; j--)
                {
                    Console.Write(" ");
                }
                // csillagok kiírása
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < szam; i++)
            {   // szóközök kiírása
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                // csillagok kiírása
                for  (int j = szam - i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





        }
    }
}
