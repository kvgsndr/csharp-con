using System;
using System.Collections.Generic;
using System.Text;

namespace Tört_11a
{
    class Tort
    {
        int szamlalo;
        int nevezo;

        public Tort()
        {
            szamlalo = 0;
            nevezo = 1;
        }

        public Tort(int szamlalo, int nevezo )
        {
            this.szamlalo = szamlalo;
            this.nevezo = nevezo;
        }

        public Tort bovit(int n)
        {
            return new Tort(szamlalo * n, nevezo * n);
        }

        public Tort szoroz(Tort tort2)
        {
            return new Tort(szamlalo * tort2.szamlalo, nevezo * tort2.nevezo).egyszerusit();
        }

        public Tort oszt(Tort tort2)
        { 
            return  this.szoroz(tort2.reciprok()).egyszerusit();
            
            //return new Tort(szamlalo * tort2.nevezo, nevezo * tort2.szamlalo);
        }

        public Tort reciprok()
        {
            return new Tort(nevezo, szamlalo);
        }

        public Tort osszead(Tort tort2)
        {
            return new Tort(this.szamlalo * tort2.nevezo + tort2.szamlalo * this.nevezo, this.nevezo * tort2.nevezo).egyszerusit();
        }

        public Tort kivon(Tort tort2)
        {
            return new Tort(this.szamlalo * tort2.nevezo - tort2.szamlalo * this.nevezo, this.nevezo * tort2.nevezo).egyszerusit();
        }


        public string  toString()
        {
          return String.Format($"({szamlalo}/{nevezo})");
        }

        public int LNKO(Tort tort)
        {
            int min;
            min = szamlalo < nevezo ? szamlalo : nevezo;
            //min=Math.Min(szamlalo, nevezo);
            int oszto=1;
            for(int i=min; i>=1;i--)
            {
                if (szamlalo % i == 0 && nevezo % i == 0)
                {
                    oszto = i;
                    break;
                }
            }
            return oszto;
               

        }

        public Tort egyszerusit()
        {   int oszto = LNKO(this);
            Tort tort = new Tort(this.szamlalo/oszto, this.nevezo/oszto);

            return tort;

        }

        


    }
}
