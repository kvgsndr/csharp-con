using System;
using System.Collections.Generic;
using System.Text;

namespace egyszamjatek11amell
{
    class Tadat
    {
        public string nev;
        public List<int> tippek = new List<int>();

        public Tadat(string sor)
        {
            string[] elemek = sor.Split(' ');
            nev = elemek[elemek.Length - 1];
            for (int i = 0; i < elemek.Length-1; i++)
            {
                tippek.Add( int.Parse( elemek[i]) );
            }
            
        }

        public int maxtipp()
        {
            int max = 0;
            foreach (var t in tippek)
            {
                if (max < t) max = t;
            }
            return max;
        }
    }
}
