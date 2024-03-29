﻿using System;

namespace oktatóprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, eredmeny = 0, valasz = 0, pont = 0;
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                a = rnd.Next(20);
                do
                {
                    b = rnd.Next(20) - 10;
                    eredmeny = a + b;
                } while (eredmeny>15 || eredmeny<-5);
                char ch = b < 0 ? '-' : '+';
                Console.Write("{0}  {1}  {2} = ", a, ch, Math.Abs(b));
                valasz = Convert.ToInt32(Console.ReadLine());
                if (eredmeny==valasz)
                {
                    pont++;
                }

            }
            Console.WriteLine("Pontszám= {0}", pont);

            switch (pont)
            {
                case 0:
                case 1:
                case 2: Console.WriteLine("Elégtelen"); break;
                case 3:
                case 4: Console.WriteLine("Elégséges"); break;
                case 5:
                case 6: Console.WriteLine("Közepes"); break;
                case 7:
                case 8: Console.WriteLine("Jó"); break;
                case 9:
                case 10: Console.WriteLine("Jeles"); break;

                
            }
            Console.ReadKey();
        }
    }
}
