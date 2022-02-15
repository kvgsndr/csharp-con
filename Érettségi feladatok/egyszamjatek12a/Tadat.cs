using System;
using System.Collections.Generic;
using System.Text;

namespace egyszamjatek12a
{
    class Tadat
    {
        string nev;
        List<int> tippek = new List<int>();

        public string Nev { get => nev; set => nev = value; }
        public List<int> Tippek { get => tippek; set => tippek = value; }

        public Tadat(string sor)
        {
            string[] elemek = sor.Split(' ');
            for (int i = 0; i < elemek.Length-1; i++)
            {
                Tippek.Add(Convert.ToInt32(elemek[i]));
            }
            Nev = elemek[elemek.Length - 1];

        }

        public int max()
        {
            int maxTipp = int.MinValue;
            foreach (var t in Tippek)
            {
                if (t > maxTipp) maxTipp = t;
            }
            return maxTipp;
        }

    }
}
