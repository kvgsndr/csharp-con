using System;

namespace másodfokú
{
    class Program
    {   
        // ax^2+bx+c=0
        static void Main(string[] args)
        {  
            double a, b , c;
            double x1, x2;
            Console.Write("a=");
            a= int.Parse( Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            double D = Math.Sqrt(b*b-4*a*c);

            if (D > 0)
            {
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                Console.WriteLine("Első megolsád x1= {0} Második megoldás x2= {1}", x1, x2);
                Console.WriteLine($"Első megolsád x1= {x1} Második megoldás x2= {x2}");
            }
            else if (D == 0)
            { 
                x1 = -b / (2 * a);
                Console.WriteLine("Egy megoldás van x={0}", x1); 
            }
            else
                Console.WriteLine($"Az egyenletnek ({a}x^2 + {b}x + {c}=0) nincs valós megoldása!");


            Console.ReadKey();
            
        }
    }
}
