using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace sziget
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int i,szdb,db,lhsz,lhszh,szh;
            int[] adat = new int[10000];
            bool tenger,melyf;
            StreamReader olv = File.OpenText("sziget.txt");
            db = 0;
            while (!olv.EndOfStream)
            {
                s = olv.ReadLine();
                if (s.Length > 0)
                {
                    adat[db] = Convert.ToInt32(s);
                    db++;
                }
            }
            olv.Close();
            if (adat[0] != 0)
            {
                tenger = false;
                szdb = -1;
            }
            else
            {
                tenger = true;
                szdb = 0;
            }
            lhszh = 0;
            szh = 0;
            lhsz = 0;
            melyf = false;
            for (i = 0; i < db; i++)
            {
                if (adat[i] < 0)
                {
                    melyf = true;
                }
                if (adat[i] != 0)
                {
                    tenger = false;
                    szh++;
                }
                else
                {
                    if (!tenger)
                    {
                        szdb++;
                        if (szdb > 0)
                        {
                            if (szh > lhszh)
                            {
                                lhszh = szh;
                                lhsz = szdb;
                            }
                        }
                        szh = 0;
                    }
                    tenger = true;
                }
            }
            Console.WriteLine("{0} db sziget volt.",szdb);
            Console.WriteLine("A leghosszabb sziget a {0}. sziget, hossza {1}.", lhsz, lhszh);
            if (melyf)
            {
                Console.WriteLine("Volt mélyföld.");
            }
            else
            {
                Console.WriteLine("Nem volt mélyföld.");
            }
            Console.ReadKey();
        }
    }
}
