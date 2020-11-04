using System;
using System.Collections.Generic;

namespace kiválogatás_tétele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 7, 3, 5, 4, 2, 6 };
            int n = a.Length;
            int[] b = new int[n];
            int j = 0;
            for (int i = 0; i < n; i++)
                if (a[i] < 5) //Az 5-nél kisebb számokat válogatjuk
                {
                    b[j] = a[i];
                    j++;
                }
            Console.WriteLine("Eredeti:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
            Console.WriteLine("Kiválogatott:");
            for (int i = 0; i < j; i++)
                Console.Write("{0} ", b[i]);
            Console.WriteLine("\n\n");

            /*
                Megoldás függvény segitségével
             */
            b = kivalogat(a);
            Console.WriteLine("Eredeti:");
            tombKiir(a);
            Console.WriteLine("Kiválogatott:");
            tombKiir(b);

            Console.ReadKey();
        }
        static int[] kivalogat(int[] t)
        {
            int n = t.Length;
            int[] eredmeny = new int[n];
            int j = 0;
            for (int i = 0; i < n; i++)
                    if (t[i]<5) eredmeny[j++] = t[i];

            return eredmeny;
          
        }
        static List<int> kivalogat2(int[] t)
        {
            List<int> eredmeny = new List<int>() ;
            foreach (var item in t)
            {
                eredmeny.Add(item);
            }
            return eredmeny;
        }


        static void tombKiir(int[] t)
        {
            foreach (var item in t)
                 Console.Write("{0,4}", item);
            Console.WriteLine();
        
        }



    }
}
