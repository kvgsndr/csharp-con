using System;

namespace megszámlálás_tétele
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            feltoltVeletlen(tomb);
            Console.WriteLine("Véletlen tömb: ");
            tombKiir(tomb);
            Console.WriteLine("Az 15 szám {0}-szer szerepel a tömbben!", megszamol(tomb,15) );
            Console.WriteLine("Az 9 szám {0}-szer szerepel a tömbben!", megszamol(tomb, 9));
            Console.WriteLine("Az 200 szám {0}-szer szerepel a tömbben!", megszamol(tomb, 200));
            Console.WriteLine("20 és 30 között {0} szerepel a tömbben!", megszamol20_30(tomb));
            Console.WriteLine("50 és 100 közötti 3-al osztható számok száma ={0} ", megszamol50_100_osztható3(tomb));
            Console.WriteLine("a 2-vel,  3-al és 7-el osztható számok száma ={0} ", megszamol_2_3_7Oszthato(tomb));


            Console.ReadKey();
        }
        static int megszamol50_100_osztható3(int[] t)
        { int N = 0;
            foreach (var item in t)
            {
                if (item % 3 == 0 && item >= 50 && item <= 100) N++;
            }
            return N;
        }

        static int megszamol(int[] t , int n)
        {
            int N = 0;
            foreach (var elem in t)
            { 
                if (elem == n) N++;
            }
            return N;
        }

        static int megszamol20_30(int[] t)
        {
            int N = 0;
            foreach (var item in t)
            {
                if (item >= 20 && item <= 30) N++;
            }
            return N;
        }

        static int megszamol_2_3_7Oszthato(int[] t)
        {
            int N = 0;
            foreach (var item in t)
                  if (item%2==0 && item%3==0 && item%7==0) 
                    N++;
            
            return N;
        }

        static void tombKiir(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.Write("{0, 4}", t[i]);
                if ((i+1) % 20 == 0) Console.WriteLine();
            }
            Console.WriteLine();
        }


        static void feltoltVeletlen(int[] t)
        {
            Random rnd = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(100) + 1;
            }
        }
    }
}
