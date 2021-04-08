using System;
using System.Collections.Generic;
using System.Text;

namespace alakzatok
{
    class Kor : Lokacio
    {
        double sugar;

        public Kor()
        {
            X = 10;
            Y = 22;
            sugar = 10;
        }
        public override void kiir()
        {
            Console.WriteLine($"Kör: Terület= {Math.Pow(sugar,2)*Math.PI}");
        }
    }
}
