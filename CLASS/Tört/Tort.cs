using System;
using System.Collections.Generic;
using System.Text;

namespace Tört
{
    class Tort
    {
        int szamlalo;
        int nevezo;

        public int Nevezo { get => nevezo; set => nevezo = value; }
        public int Szamlalo { get => szamlalo; set => szamlalo = value; }

        public Tort()
        {
            Szamlalo = 0;
            Nevezo = 1;
        }
        public Tort(int szamlalo, int nevezo)
        {
            this.Nevezo = nevezo;
            this.Szamlalo = szamlalo;
        }

        public Tort bovit(int n)
        {
            Tort tmp = new Tort(Szamlalo * n, Nevezo * n);
            return tmp;

        }
        
        private int lnko()
        {
            
            int osztó = 2;
            int közös = 1;
            while (osztó <= Szamlalo && osztó <= Nevezo)
            {
                if (Szamlalo % osztó == 0 && Nevezo % osztó == 0)
                    közös = osztó;
                osztó++;
            }
            

            return közös;
        }

        public Tort egyszerusit()
        {
            int LNKO = lnko();
            Tort tmp = new Tort(Szamlalo / LNKO, Nevezo / LNKO);
            return tmp;
        }

        public Tort szoroz(Tort tort)
        {
            Tort tmp = new Tort(Szamlalo * tort.Szamlalo, Nevezo * tort.Nevezo);
            return tmp;
        }

        public Tort reciprok()
        {
            Tort rec = new Tort(Nevezo, Szamlalo);
            return rec;
        }

        public Tort oszt(Tort tort)
        {
            return this.szoroz(tort.reciprok());
        }

        public Tort osszead(Tort tort)
        {
            Tort tmp = this;
            tmp = tmp.bovit(tort.Nevezo);
            tort=tort.bovit(tmp.Nevezo);
            tmp.Szamlalo = tmp.Szamlalo + tort.Szamlalo;
            return tmp;
        }

        public Tort kivonas(Tort tort)
        {
            Tort tmp = this;
            tmp = tmp.bovit(tort.Nevezo);
            tort = tort.bovit(tmp.Nevezo);
            tmp.Szamlalo = tmp.Szamlalo - tort.Szamlalo;
            return tmp;
        }

        public void toString()
        {
            Console.WriteLine($"{Szamlalo}/{Nevezo}");
        }
    }
}
