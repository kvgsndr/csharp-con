using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Keres
    {
        public string Cim;
        public string DatumIdo;
        public string Kep;
        public string Kod;
        public string Meret;

        public Keres(string sor)
        {
            string[] darabok = sor.Split('*');
            Cim = darabok[0];
            DatumIdo = darabok[1];
            Kep = darabok[2];
            Kod = darabok[3].Split(' ')[0];
            Meret = darabok[3].Split(' ')[1];

        }
        public int ByteMeret //6. feladat
        {
            get
            {
                if (Meret == "-") return 0;
                return int.Parse(Meret);
            }
        }
    }
}
