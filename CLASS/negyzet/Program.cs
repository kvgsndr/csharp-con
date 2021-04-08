using System;

namespace alakzatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Lokacio l = new Lokacio(20, 25);
            l.kiir();
            Console.WriteLine();
            Negyzet a = new Negyzet(10, 10, 3.5);
            Negyzet b = new Negyzet(l, 5.0);
            a.kiir();
            Console.WriteLine();
            b.kiir();
            Console.WriteLine();
            a.mozgat(10, 30);
            a.kiir();
            Console.WriteLine();

            Hasab h = new Hasab(5, 12, 4.0, 2.0);
            h.kiir();
            h.mozgat(15, 12);
            h.kiir();
            Kor k10 = new Kor();
            k10.kiir();
            
            Console.ReadKey();
        }
    }
}
