using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tti
{
    class Program
    {
        static void Main(string[] args)
        {
            string []nev = new string[100];
            int[] mag = new int[100];
            int[] tomeg = new int[100];
            int db;
            string tar = "";
            Console.WriteLine("beolvasás");
			StreamReader olv = new StreamReader("tti.txt",Encoding.Default);
            olv.ReadLine();
            db = 0;
            while (!olv.EndOfStream)
            {
                tar = olv.ReadLine();
                string[] s = tar.Split('\t');
                nev[db] = s[0];
                mag[db] = Convert.ToInt32(s[1]);
                tomeg[db] = Convert.ToInt32(s[2]);
                db = db + 1;
            }
            olv.Close();
            Console.WriteLine("A beolvasott adatok:");
            for (int i = 0; i < db; i++)
            {
                tar = String.Format ("név:{0}, magasság:{1}, tömeg:{2}",nev[i],mag[i],tomeg[i]);
                Console.WriteLine(tar);
            }
            Console.WriteLine("VÉGE");
            Console.WriteLine("A testtömegindexek:");
            double tti;
            double m, t;
            for (int i = 0; i < db; i++)
            {
                m = mag[i];
                t = tomeg[i];
                tti = t / (m/100 * m/100);
                tar = String.Format("{0,-20}{1}", nev[i], tti);
                Console.WriteLine(tar);
            }
            Console.WriteLine("VÉGE");
            Console.ReadKey();
        }
    }
}
