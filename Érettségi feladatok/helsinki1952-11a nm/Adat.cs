using System;
using System.Collections.Generic;
using System.Text;

namespace helsinki1952_11a
{
    class Adat
    {
        int helyezes;
        int sportolokSzama;
        string sportag;
        string versenyszam;

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int SportolokSzama { get => sportolokSzama; set => sportolokSzama = value; }
        public string Sportag { get => sportag; set => sportag = value; }
        public string Versenyszam { get => versenyszam; set => versenyszam = value; }

        public Adat(string sor)
        {
            string[] elemek = sor.Split(' ');
            Helyezes = Convert.ToInt32(elemek[0]);
            SportolokSzama = Convert.ToInt32(elemek[1]);
            Sportag = elemek[2];
            Versenyszam = elemek[3];
        }
    }
}
