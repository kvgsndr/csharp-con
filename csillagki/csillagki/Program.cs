using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csillagki
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma;
            int n;
            do
            {
                Console.Write("Hány csillag?");
                duma = Console.ReadLine();
                try
                {
                    n = Convert.ToInt32(duma);
                    for (int i = 0; i < n; i = i + 1)
                    {
                        Console.Write("*");
                    }
                }
                catch
                {
                    Console.WriteLine("Nem számot írtál be!!!");
                }
                Console.Write("\n\nMégegyszer 'm', más vége! (+enter)");
                duma = Console.ReadLine();
            } while (duma=="m");
        }
    }
}
