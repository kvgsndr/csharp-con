using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermek
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] ermek = { 1, 2, 5, 10, 20, 50, 100, 200 };
            Console.WriteLine("Kérem írjon be egy összeget!");
            int osszeg = Convert.ToInt32(Console.ReadLine());

            int[] coinList = new int[100];
            int i, k = 0;
            int szamlalo = 0;

            for (i = ermek.Length - 1; i >= 0; i--)
            {
                while (osszeg >= ermek[i])
                {
                    osszeg -= ermek[i];                  
                    coinList[k++] = ermek[i];
                    szamlalo++;
                }
            }
            for (i = 0; i < k; i++)
            { 
                Console.WriteLine( coinList[i]);
            }

            Console.ReadKey();
        }
      
    }
}
