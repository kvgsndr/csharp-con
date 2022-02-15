using System;
using System.Collections.Generic;
using System.Text;

namespace helsinki1952_11amell
{
    class TAdat
    {
        public int helyezes;
        public int spSzama;
        public string sportag;
        public string versenyszam;

        public TAdat(string sor)
        {
            string[] elemek = sor.Split(' ');
            helyezes = Convert.ToInt32(elemek[0]);
            spSzama = Convert.ToInt32(elemek[1]);
            sportag = elemek[2];
            versenyszam = elemek[3];

        }

    }
}
