using System;

namespace masodfoku
{
    class Program
    {    // másodfokú egyenlet megoldása ax^2+bx+c=0
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2;
            string st;
            Console.Write("a=");
            st = Console.ReadLine();
            a = double.Parse(st);
            
            Console.Write("b=");
            st = Console.ReadLine();
            b = Convert.ToDouble(st);

            Console.Write("c=");
            c = double.Parse( Console.ReadLine() );

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine( "Első megoldás x1={0,-10:0.00} második megoldás x2={1,10:0.00}", x1, x2);
                Console.WriteLine($"Első megoldás x1={x1,10:F2} második megoldás x2={x2:F3} ");
            }
            else if(D==0)
            {
                x1 = -b / (2 * a);
                st = String.Format($"Egy megoldás van x={x1}");
                Console.WriteLine(st);
            }
            else
                Console.WriteLine("Az egyenletnek nincs valós megoldása!");

            Console.ReadKey();
        }
    }
}
