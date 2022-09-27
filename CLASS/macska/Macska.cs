using System;
using System.Collections.Generic;
using System.Text;

namespace macska
{    
    class Macska
    {
        string nev;
        double suly;
        public bool Ehes { get; set; }

        public string Nev { get => nev; set => nev = value; }
        public double Suly
        {
            get
            {
                return suly;
            }

            set 
            {
                if(value>0.2 && value< 500)
                   suly = value;
            }
        }

        //konstruktorok
        public Macska(string nev, double suly, bool ehes)
        {
            this.suly = suly;
            this.Nev = nev;
            this.Ehes = ehes;
        }

        public Macska(string nev, double suly)
        {
            Nev = nev;
            Suly = suly;
            Ehes = true;
        }
        
        public bool eszik(double etel)
        {
            if (Ehes)
            {
                suly += etel;
                Ehes = false;
                return true;
            }
           
            return false;
        }

        
        public void futkos()
        {
            suly -= 0.1;
            if(!Ehes) Ehes = true;
        }

        public void toString()
        {   string éhes= Ehes ? "Igen" : "Nem";
            Console.WriteLine($"Név: {Nev} Súly: {suly} Éhes: {éhes}");
        }
    }
}
