using System;

namespace elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x>0)
            {
                Console.WriteLine("Pozitív");
            }
            else if (x < 0)
            {
                Console.WriteLine("Negatív");
            }
            else if (x == 0)
            {
                Console.WriteLine("Nulla");
            }
            switch ( x )
            {
                case 1: Console.WriteLine("Hétfő"); break;
                case 2: Console.WriteLine("Kedd"); break;
                case 3: Console.WriteLine("Szerda"); break;
                default: Console.WriteLine("nem jó számot adtál meg");break;
            }




        }
    }
}
