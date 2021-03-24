using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace függvények1
{
    class Program
    {
       
        public static int csillag( int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Csillagok kiírása eljárással");
            Console.Write("Csillagok Száma= ");
           int szam = Convert.ToInt32( Console.ReadLine());

            for (int i = 1; i <= szam; i++)
            {
                 int s=csillag(i);
            }
            
               
               



            Console.ReadKey();
        }

    }
}
