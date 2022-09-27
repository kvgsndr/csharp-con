using System;
using System.Collections.Generic;
using System.Text;

namespace egyszamjatek11anm
{
    class Tjatekos
    {
        public string nev;
        public List<int> tippek = new List<int>();

        public Tjatekos(string sor)
        {
            string[] elemek = sor.Split(' ');
            nev = elemek[elemek.Length - 1];
            for (int i = 0; i < elemek.Length-1; i++)
            {
                tippek.Add(Convert.ToInt32(elemek[i]));
            }
        }
    }
}
