using System;

namespace függvények_gyakorlás
{
    class Program
    {   static double haromszogKer(double a, double b, double c)
        {
            return a + b + c;
        }
        static double haromszogTer(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return s * (s - a) * (s - b) * (s - c);
        }
        static double korKer(double r)
        {
            return 2 * r * Math.PI;
        }
        static double korTer(double r)
        {
            return r * r * Math.PI;
        }

        static void Main(string[] args)
        {
            double a, c, b;
            Console.WriteLine("Írd be a háromszög oldalait:");
            do
            {
                Console.Write("a= ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b= ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c= ");
                c = Convert.ToDouble(Console.ReadLine());
                0-+
                    á
            } while ();

        }
    }
}
