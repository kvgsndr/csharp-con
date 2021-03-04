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
            return new Tort(szamlalo * tort2.szamlalo, nevezo * tort2.nevezo);
        }

        public Tort oszt(Tort tort2)
        { 
            return  this.szoroz(tort2.reciprok());
            
            //return new Tort(szamlalo * tort2.nevezo, nevezo * tort2.szamlalo);
        }

        public Tort reciprok()
        {
            return new Tort(nevezo, szamlalo);
        }

        public Tort osszead(Tort tort2)
        {
            return new Tort(this.szamlalo * tort2.nevezo + tort2.szamlalo * this.nevezo, this.nevezo * tort2.nevezo);
        }

        public Tort kivon(Tort tort2)
        {
            return new Tort(this.szamlalo * tort2.nevezo - tort2.szamlalo * this.nevezo, this.nevezo * tort2.nevezo);
        }


        public string  toString()
        {
          return String.Format($"({szamlalo}/{nevezo})");
        }

    }
}
