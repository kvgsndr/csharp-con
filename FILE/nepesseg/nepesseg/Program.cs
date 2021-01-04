using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace nepesseg
{
    class Program
    {
        static void Main(string[] args)
        {
            string mev;
            string es;
            int p;
            int n;
            int f;
            int mf;
            int mn;
            int mk;
            string t;
            string aev;

            StreamReader no = new StreamReader("nepesseg.txt");
            no.ReadLine();
            mk = 0;
            mev = "";
            mf = 0;
            mn = 0;
            while (!no.EndOfStream)
            {
                es = no.ReadLine();
                p = 0;
                aev = "";
                while (es[p] != '\t')
                {
                    aev = aev + es[p];
                    p = p + 1;
                }
                t = "";
                p = p + 1;
                while (es[p] != '\t')
                {
                    t = t + es[p];
                    p = p + 1;
                }
                f = Convert.ToInt32(t);
                t = "";
                p = p + 1;
                while (es[p] != '\t')
                {
                    t = t + es[p];
                    p = p + 1;
                }
                n = Convert.ToInt32(t);
                if (mk < n - f)
                {
                    mev = aev;
                    mk = n - f;
                    mf = f;
                    mn = n;
                }
            }
            no.Close();
            Console.WriteLine("A legnagyobb különbség éve:"+mev);
            Console.WriteLine("A legnagyobb különbség: "+mk);
            Console.WriteLine("A férfiak száma ekkor: "+mf);
			Console.WriteLine("A nők száma ekkor: "+mn);
            Console.ReadKey();
        }
    }
}
