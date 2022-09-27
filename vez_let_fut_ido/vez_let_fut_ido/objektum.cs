using System;
using System.Collections.Generic;
using System.Text;
using vez_let_fut_ido;

namespace vez_let_fut_ido
{
    class objektum
    {
        string nev;
        int ev;
        int osztaly;

        public string Nev { get => nev; set => nev = value; }
        public int Ev { get => ev; set => ev = value; }
        public int Osztaly { get => osztaly; set => osztaly = value; }

        public objektum(string n, int ev, int osztaly )
        {
            nev = n;
            this.ev = ev;
            Osztaly = osztaly;

        }

        public objektum(string nev)
        {
            Nev = nev;
            ev = 2000;
            osztaly = 9;
        }

        public void elorelep()
        {
            osztaly += 1;
        }

        public string kiir()
        {
            string st = nev + " " + ev.ToString() + " " + osztaly.ToString();
            return st;
        }


    }
}
