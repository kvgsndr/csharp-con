using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pitagorasz
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            for (a = 1; a <= 100; a = a + 1)
            {
                for (b = a; b <= 100; b = b + 1)
                {
                    for (c = 1;c <= 100; c = c + 1)
                    {
                        if (a * a + b * b == c * c)
                        {
                            if (a < 10)
                            {
                                Console.Write(" ");
                            }
                            if (a < 100)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(a);
                            Console.Write(", ");
                            if (b < 10)
                            {
                                Console.Write(" ");
                            }
                            if (b < 100)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(b);
                            Console.Write(", ");
                            if (c < 10)
                            {
                                Console.Write(" ");
                            }
                            if (c < 100)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(c);
							Console.WriteLine("  {0,6} +{1,6} ={2,6}",a*a,b*b,c*c);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
