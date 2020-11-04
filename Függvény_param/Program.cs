using System;

namespace Függvény_param
{
    class Program
    { static int duplaz(ref int szam)
        {
            int eredmeny = 2 * szam;
            szam *= 2;
            return eredmeny;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = duplaz(ref a);
            Console.WriteLine("addott szám={0} és a kétszerese {1}", a, duplaz(ref a));
            Console.WriteLine("addott szám={0} és a kétszerese {1}", a, b);
        }
    }
}
