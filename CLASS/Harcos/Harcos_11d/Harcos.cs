using System;
using System.Collections.Generic;
using System.Text;

namespace Harcos_11d
{ 
    class Harcos
    {
        string nev;
        int eletero;
        int harciero;

        public string Nev { get => nev; set => nev = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int Harciero { get => harciero; set => harciero = value; }

        public Harcos(string nev, int eletero, int harciero)
        {
            this.Nev = nev;
            this.Eletero = eletero;
            this.Harciero = harciero;
        }

        

        public bool harcol(Harcos harcos)
        {
            this.Eletero -= harcos.Harciero;
            harcos.Eletero -= this.Harciero;
            if (this.Eletero < 0 || harcos.Eletero < 0)
                return true;
            else
                return false;
        }

        public void toString()
        {
            Console.WriteLine($"Név:{Nev} Életerő:{Eletero} Harci erő: {Harciero}");
        }


    }
}
