using System;
using System.Collections.Generic;
using System.Text;

namespace alakzatok
{
    class Negyzet : Lokacio
    {
      
        double oldal;

        public double Oldal { get => oldal; set => oldal = value; }

        public Negyzet(int x, int y, double oldal):base(x,y)
        {
            this.Oldal = oldal;
        }
        public Negyzet(Lokacio lok, double oldal):base(lok)
        {
            this.Oldal = oldal;
        }
        public Negyzet(Negyzet negyzet)
        {
            this.Y = base.Y;
            this.X = base.X;
            this.Oldal = negyzet.Oldal;
           
        }
        public double terulet()
        {
            return Math.Pow(Oldal,2);
        }
        public void mozgat(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public override void kiir()
        {
            Console.Write($"Lokáció:");
            base.kiir();
            Console.Write($"Terület: {terulet()}");
        }

    }
}
