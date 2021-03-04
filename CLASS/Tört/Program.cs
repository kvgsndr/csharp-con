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
            t1.toString();
            t2.toString();
            eredmeny = t1.szoroz(t2);
            eredmeny.toString();
            eredmeny.egyszerusit().toString();
        }
    }
}
