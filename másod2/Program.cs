// Másodfokú egyenlet megoldása ax^2+bx+c=0
using System;

namespace másod2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2, D;
            Console.Write("A= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("B= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("C= ");
            c = double.Parse(Console.ReadLine());

            D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                //Console.WriteLine("X1= {0}    X2= {1}", x1, x2);
                Console.WriteLine($"X1= |{x1,-10:0.0000}|    X2= |{x2,+10:F4}|");
            }
            else if (D == 0)
                Console.WriteLine($"Egy megoldás van X= {(-b / (2 * a)),5} ");
            else
                Console.WriteLine("Az egyenletnek nincs valós megoldása!");

            
            Console.WriteLine("Press Any key....");
            Console.ReadKey();
        }
    }
}
