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
        {   if (nevezo != 0)
                this.Nevezo = nevezo;
            else
                this.Nevezo = 1;
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
            return tmp.egyszerusit();
        }

        public Tort reciprok()
        {
            Tort rec = new Tort(Nevezo, Szamlalo);
            return rec.egyszerusit();
        }

        public Tort oszt(Tort tort)
        {
            return this.szoroz(tort.reciprok());
        }

        public Tort osszead(Tort tort)
        {
            Tort tmp = this;
            int b = tmp.Nevezo;

            tmp = tmp.bovit(tort.Nevezo);
            tort = tort.bovit(b);
            tmp.Szamlalo = tmp.Szamlalo + tort.Szamlalo;
            return tmp.egyszerusit();
        }

        public Tort kivonas(Tort tort)
        {
            Tort tmp = this;
            int b = tmp.Nevezo;
            tmp = tmp.bovit(tort.Nevezo);
            tort = tort.bovit(b);
            tmp.Szamlalo = tmp.Szamlalo - tort.Szamlalo;
            return tmp.egyszerusit();
        }

        public string toString()
        {
            return String.Format($"{Szamlalo}/{Nevezo}");
        }

        static public Tort operator +(Tort a, Tort b)
        { Tort eredmeny = new Tort();
            eredmeny = a.osszead(b);
            return eredmeny.egyszerusit();
        }
        static public Tort operator -(Tort a, Tort b)
        {
            Tort eredmeny = new Tort();
            eredmeny = a.kivonas(b);
            return eredmeny.egyszerusit();
        }
        static public Tort operator *(Tort a, Tort b)
        {
            Tort eredmeny = new Tort();
            eredmeny = a.szoroz(b);
            return eredmeny.egyszerusit();
        }
        static public Tort operator /(Tort a, Tort b)
        {
            Tort eredmeny = new Tort();
            eredmeny = a.oszt(b);
            return eredmeny.egyszerusit();
        }
    }
}
