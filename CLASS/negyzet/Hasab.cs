using System;
using System.Collections.Generic;
using System.Text;

namespace alakzatok
{
    class Hasab : Negyzet 
    {
        double magas;
         
        public Hasab(int x, int y ,double oldal, double magas) : base(x,y,oldal)
        {
            this.magas = magas;
        }
        public Hasab(Lokacio lok, double oldal, double magas) : base(lok,oldal)
        {
            this.magas = magas;
        }
        public Hasab(Negyzet negyzet, double magas) : base(negyzet)
        {
            this.magas = magas;
        }
        public override void kiir()
        {
            Console.Write($"Hasáb:");
            base.kiir();
            Console.WriteLine($"magasság: {magas}");
        }

    }
}
