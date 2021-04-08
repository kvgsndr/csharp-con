using System;
using System.Collections.Generic;
using System.Text;

namespace alakzatok
{
    class Lokacio
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Lokacio(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Lokacio()
        {
            X = 0;
            Y = 0;
        }
        public Lokacio(Lokacio lok)
        {
            this.X = lok.X;
            this.Y = lok.Y;
        }

        public virtual void kiir()
        {
            Console.Write($"Lokáció:({X}, {Y})");  //(x, y)
        }
    }
}
