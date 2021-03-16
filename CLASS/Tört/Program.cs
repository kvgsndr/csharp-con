using System;

namespace Tört
{
    class Program
    {
        static void Main(string[] args)
        {
            Tort t1 = new Tort(1, 2);
            Tort t2 = new Tort(2, 5);
            Tort eredmeny = new Tort();
            Console.WriteLine(t1.toString());
            Console.WriteLine(t2.toString());
            eredmeny = t1.szoroz(t2);
            Console.WriteLine(eredmeny.toString());
            Console.WriteLine( eredmeny.egyszerusit().toString() );
            eredmeny = t1 + t2;
            Console.WriteLine(t1.toString() +"+" + t2.toString() +"=" +eredmeny.toString());
            eredmeny = t1 * t2 - t1 + t2 + (t1 * t1);
            Console.WriteLine(eredmeny.toString());
        }
    }
}
