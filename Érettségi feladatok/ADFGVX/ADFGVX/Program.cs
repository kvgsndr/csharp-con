using System;

namespace ADFGVX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat:");
            Console.Write("\tKérem a Kódot [HOLD]:");
            string kod=Console.ReadLine();
            Console.Write("\tKérem az üzenetet [szeretem a csokit]:");
            string uzenet = Console.ReadLine();
            kod = kod == "" ? "HOLD" : kod.ToUpper();
            uzenet = uzenet == "" ? "szeretem a csokit" : uzenet.ToLower();
            
            ADFGVXrejtjel aDFGVXrejtjel = new ADFGVXrejtjel("kodtabla.txt", uzenet, kod);
            Console.WriteLine($"5.feladat: Az átalakított üzenet: {aDFGVXrejtjel.AtalakitottUzenet()}");
            Console.WriteLine($"6.feladat: s->{aDFGVXrejtjel.Betupar('s')}   x->{aDFGVXrejtjel.Betupar('x')}");
            Console.WriteLine($"7.feladat: A kódszöveg:{aDFGVXrejtjel.Kodszoveg()}");
            Console.WriteLine($"8.feladat: A kódolt üzenet: {aDFGVXrejtjel.KodoltUzenet()}");

            Console.ReadKey();
        }
    }
}
