using System;
using System.Collections;

namespace ismétlés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
                Console.WriteLine("Nagyobb mint 10");
            else if (n < 10)
                Console.WriteLine("Kisebb mint 10");
            else
                Console.WriteLine("n=10");


           string s= n > 100 ? "Nagyobb 100" : "Kisebb vagy egyenlő  100-al";
            Console.WriteLine(s);

            switch (n)
            {
               case 1: Console.WriteLine("Hétfő"); break;
               case 2: Console.WriteLine("Kedd"); break;
               case 3: Console.WriteLine("Szerda");break;
               case 4: Console.WriteLine("Csütörtök");break;
               default: Console.WriteLine("Péntek Szombat vagy vasárnap");break;
            }


     




        }



    
    }
}
