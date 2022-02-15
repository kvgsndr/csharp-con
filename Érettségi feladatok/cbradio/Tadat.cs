using System;
using System.Collections.Generic;
using System.Text;

namespace cbradio
{
    class Tadat
    {
        public int Ora { get; set; }
        public int Perc { get; set; }
        public int AdasDb { get; set; }
        public string Nev { get; set; }

        public Tadat(string sor)
        {
            string[] elemek = sor.Split(';');
            Ora = Convert.ToInt32(elemek[0]);
            Perc = Convert.ToInt32(elemek[1]);
            AdasDb = Convert.ToInt32(elemek[2]);
            Nev = elemek[3];


        }
    }
}
