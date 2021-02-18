using System;

namespace ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Kővágó Sándor", i+1);
                
            }

            int k = 1;
            while (k<=10)
            {
                Console.WriteLine($"{k++}. Kővágó Sándor");

            }

            int m = 1;
            do
            {
                Console.WriteLine($"{m++}. Kővágó Sándor");
            } while (m<=10);

            for (int i = 1; i <11 ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int i =2 ; i <=20; i+=2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            for (int i =5; i < (5+7*10); i += 7)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();


            for (int i = 0, x =197; i <10; i++, x-=7)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            
            
            int ii = 0,xx=197;
            while (ii<10)
            {
                Console.Write($"{xx} ");
                ii++;
                xx -= 7;
            }
            Console.WriteLine();
            int szam;
            do
            {
                Console.Write("Írj be egy 3 jegyű számot:");
                szam = int.Parse(Console.ReadLine());
            } while ( szam<100 || szam>999);
            if (szam % 7 == 0)
                Console.WriteLine("osztható 7-el");
            else
                Console.WriteLine("NEM osztható 7-el");
            */

            Console.Write("Írj be egy számot:");
            int szam1 = int.Parse(Console.ReadLine());
            int szam2;
            do
            {
                Console.Write("Írj be egy számot aminagyobb mint az első:");
                szam2 = int.Parse(Console.ReadLine());
            } while (szam1 >=szam2);

        }
    }
}
