using System;

namespace tömb
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            int[] páros = new int[100];
            int[] páratlan = new int[100];
            Random rnd = new Random();
            int m = 0, n = 0;
                       
          
            for (int i = 0; i < tomb.Length; i++)
                if (tomb[i] % 2 == 0)
                {
                    páros[n] = tomb[i];
                    n++;
                }
                else
                {
                    páratlan[m] = tomb[i];
                    m++;
                }
            for (int i = 0; i <100; i++)
                Console.Write("{0}", tomb[i]);
            
            Console.WriteLine("\nPárosak:");
            for (int i = 0; i < n ; i++)
                Console.Write("{0} ", páros[i]);
            
            Console.WriteLine("\nPáratlan:");
            for (int i = 0; i < m; i++)
                Console.Write("{0} ", páratlan[i]);
            
            long sum_páros = 0, sum_páratlan = 0;
            for (int i = 0; i < n; i++)
                sum_páros += páros[i];
            
            for (int i = 0; i < m; i++)
                sum_páratlan += páratlan[i];
            
            if (sum_páros > sum_páratlan)
                Console.WriteLine("\nPárosak összee negyobb!");
            else if (sum_páros < sum_páratlan)
                Console.WriteLine("\nPáratlanok összege negyob!");
            else
                Console.WriteLine("\nEGYENLŐK az összegek!");



        }
    }
}
