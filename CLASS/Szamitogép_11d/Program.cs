using System;

namespace Szamitogép_11d
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamitogep sz1 = new Szamitogep(2048, false);
            Szamitogep sz2 = new Szamitogep();

            sz2.kapcsol();
            if (sz2.progMasol(800)) Console.WriteLine("Program másolva!");
            else Console.WriteLine("Hiba!!!A programot nem lehet másolni!");

            if (sz2.progMasol(400)) Console.WriteLine("Program másolva!");
            else Console.WriteLine("Hiba!!!A programot nem lehet másolni!");

            if (sz1.progMasol(1)) Console.WriteLine("Program másolva!");
            else Console.WriteLine("Hiba!!!A programot nem lehet másolni!");

            sz1.toString();
            sz2.toString();

            Console.ReadKey();
        }
    }
}
