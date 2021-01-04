using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stat
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            int db;
            int k;
            int v;
            Console.WriteLine("STATISZTIKA");
            Console.Write("A sokaság elemszáma:");
            t = Console.ReadLine();
            db = Convert.ToInt32(t);
            Console.Write("A lehetséges minimum:");
            t = Console.ReadLine();
            k = Convert.ToInt32(t);
            Console.Write("A lehetséges maximum:");
            t = Console.ReadLine();
            v = Convert.ToInt32(t);
            int[] s = new int[db];
            int []esz=new int[v-k+1];
            Random r = new Random();
            for (int i = 0; i < db; i++)
            {
                s[i] = r.Next(k, v+1);
            }
            double a;
            int lkp;
            int lnp;
            a = 0;
            lkp=0;
            lnp=0;
            for (int i = 0; i < v-k+1; i++)
            {
                esz[i] = 0;
            }
            for (int i = 0; i < db; i++)
            {
                a = a + s[i];
                if (s[i] > s[lnp])
                    lnp = i;
                if (s[i] < s[lkp])
                    lkp = i;
                esz[s[i] - k]++;
            }
            a = a / db;
            double aet;
            aet = 0;
            for (int i = 0; i < db; i++)
            {
                aet = aet + Math.Abs(a - s[i]);
            }
            aet = aet / db;
            int mp;
            mp = 0;
            for (int i = 0; i < v - k + 1; i++)
            {
                if (esz[i] > esz[mp])
                    mp = i;
            }
            Console.Write("A sorozat:");
            for (int i = 0; i < db; i++)
            {
                Console.Write(s[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Az átlag:");
            Console.WriteLine(a);
            Console.Write("A legnagyobb:");
            Console.WriteLine(s[lnp]);
            Console.Write("A legkisebb:");
            Console.WriteLine(s[lkp]);
            Console.Write("A módusz (-ok közül a legkisebb):");
            Console.WriteLine(mp+k);
            Console.Write("Az átlagtól való átlagos eltérés:");
            Console.WriteLine(aet);
            // ha nagyon akarom lehet az eddigiekből mediánt is számolni
            int ai; // elemszám alja
            int mdb,fel;
            double median;
            ai = 0;
            fel = db / 2;
            mdb = 0;
            if (db % 2 == 1)
            { // páratlan db
                while (mdb + esz[ai] <= fel)
                {
                    mdb = mdb + esz[ai];
                    ai++;
                }
                median = ai + k;
            }
            else
            {// páros db
                while (mdb + esz[ai] < fel)
                {
                    mdb = mdb + esz[ai];
                    ai++;
                }
                median = ai + k;
                if (mdb + esz[ai] == fel)
                {
                    ai++;
                    while (esz[ai] == 0)
                    {
                        ai++;
                    }
                    median = (median + ai + k) / 2;
                }
            }
            Console.Write("A medián:");
            Console.WriteLine(median);
            Console.ReadKey();
        }
    }
}
