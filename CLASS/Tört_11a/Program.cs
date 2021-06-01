using System;

namespace Tört_11a
{
    class Program
    {
        static void Main(string[] args)
        {
            Tort t1 = new Tort(5, 10);
            Tort t2 = new Tort(15, 50);
            Console.WriteLine(t1.toString());
            Console.WriteLine(t2.toString());
            Tort eredmény = t1.szoroz(t2);
            Console.WriteLine($"{t1.toString()}*{t2.toString()}={eredmény.toString()}");
            eredmény=eredmény.egyszerusit();
            Console.WriteLine($"{t1.toString()}*{t2.toString()}={eredmény.toString()}");

            eredmény = t1.osszead(t2);
            Console.WriteLine($"{t1.toString()}+{t2.toString()}={eredmény.toString()}");
            
        }
    }
}
