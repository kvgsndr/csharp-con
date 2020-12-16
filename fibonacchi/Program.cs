using System;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {
            ulong f0 = 0, f1 = 1;
            int szam =int.Parse(Console.ReadLine());
            ulong f2 = 0;
            while(f2<(ulong)szam)
            {
                f2 = f0 + f1;
                if ((ulong)szam == f2)
                {
                    Console.WriteLine("A {0} szám tagja a Fibanacchi számsornak!", szam);
                    return 0;
                }
                        f0 = f1;
                        f1 = f2;
            }
            Console.WriteLine("A {0} szám NEM tagja a Fibanacchi számsornak!", szam);
            return 1;
        }
    }
}
