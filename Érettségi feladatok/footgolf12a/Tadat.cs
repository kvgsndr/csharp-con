using System;
using System.Collections.Generic;
using System.Text;

namespace footgolf12a
{
    class Tadat
    {
        public string Nev { get; set; }
        public string Kateg { get; set; }
        public string Egyesulet { get; set; }
        public List<int> Pont = new List<int>();

        public Tadat(string sor)
        {
            string[] elem = sor.Split(';');
            Nev = elem[0];
            Kateg = elem[1];
            Egyesulet = elem[2];
            for (int i = 0; i < 8; i++)
                Pont.Add( Convert.ToInt32(elem[i + 3]));

        }
        public int osszPontszam()
            {
                List<int> tomb = new List<int>(Pont);
                int pont = 0;
                tomb.Sort();
                tomb.Reverse();
                if (tomb[tomb.Count - 1] != 0) pont += 10;
                tomb.RemoveAt(tomb.Count - 1);
                if (tomb[tomb.Count - 1] != 0) pont += 10;
                tomb.RemoveAt(tomb.Count - 1);
                foreach(var p in tomb)
                {
                    pont += p + (p != 0 ? 10 : 0);                
                }
                return pont;
			}
             

    }
}
