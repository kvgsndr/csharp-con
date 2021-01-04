using System;

namespace hatul_tesztekő
{
    class Program
    {
        static void Main(string[] args)
        {

            // vigyél be egy pozitív egész páros számot
            Console.Write("Vigyél be egy pozitív egész páros számot: ");
            int szam = int.Parse(Console.ReadLine());
            for( ; !(szam>0 && szam % 2==0) ; )
            {
                Console.Write("Rossz szám!!! Vigyél be egy pozitív egész páros számot: ");
                szam = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("OK");


            Console.Write("Vigyél be egy pozitív egész páros számot: ");
            szam = int.Parse(Console.ReadLine());
            while( !(szam > 0 && szam % 2 == 0))
            {
                Console.Write("Rossz szám!!! Vigyél be egy pozitív egész páros számot: ");
                szam = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("OK");
            bool elso=true;
            do
            {   if (!elso) Console.Write("Rossz szám!!!");
                Console.Write(" Vigyél be egy pozitív egész páros számot: ");
                szam = int.Parse(Console.ReadLine());
                elso = false;

            } while (!(szam > 0 && szam % 2 == 0));
            Console.WriteLine("OK");




            Console.ReadKey();
        }
    }
}
