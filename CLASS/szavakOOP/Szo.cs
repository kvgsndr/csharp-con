using System;
using System.Collections.Generic;
using System.Text;

namespace szavakOOP
{
    class Szo
    {
        string adat;

        public string Adat{ get => adat; set => adat = value; }

        public Szo(string szo)
        {
            this.Adat = szo;
        }

        public int  hossz()
        {
            return Adat.Length;
        }
        public bool fbetus4()
        {
            if (Adat[0] == 'f' && Adat.Length == 4) return true;
            else return false;
        }
        public bool alt()
        {
            return Adat.Contains("alt");
        }
    }
}
