using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace kemia
{
    public struct elem
    {
        public int rszam;
        public string nev;
        public string vegyj;
        public double tomeg;
        public double sugar;
        public double elektronneg;
        public double gyak;
        public int felfev; // 1700 elõttit 1700-nak tekint
    }

    class Program
    {
        static elem[] elemek = new elem[150];
        static int elemdb;
        
        static void sorol(string s)
        {
            int p = 0;
            string t;
            s += "\t\t\t\t\t\t\t\t";
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length==0)
                elemek[elemdb].rszam = 0;
            else
                elemek[elemdb].rszam = Convert.ToInt32(t);
            p++;
            elemek[elemdb].nev = "";
            while (s[p] != '\t')
            {
                elemek[elemdb].nev += s[p];
                p++;
            }
            p++;
            elemek[elemdb].vegyj = "";
            while (s[p] != '\t')
            {
                elemek[elemdb].vegyj += s[p];
                p++;
            }
            p++;
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length == 0)
                elemek[elemdb].tomeg = 0;
            else
                elemek[elemdb].tomeg = Convert.ToDouble(t);
            p++;
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length == 0)
                elemek[elemdb].sugar = 0;
            else
                elemek[elemdb].sugar = Convert.ToDouble(t);
            p++;
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length == 0)
                elemek[elemdb].elektronneg = 0;
            else
                elemek[elemdb].elektronneg = Convert.ToDouble(t);
            p++;
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length == 0)
                elemek[elemdb].gyak = 0;
            else
                elemek[elemdb].gyak = Convert.ToDouble(t);
            p++;
            t = "";
            while (s[p] != '\t')
            {
                t += s[p];
                p++;
            }
            if (t.Length < 1)
                t += "x";
            if ((t[0]>'9')||(t[0]<'0'))
            {
                elemek[elemdb].felfev = 1700;
            }
            else
            {
                elemek[elemdb].felfev = Convert.ToInt32(t);
            }
            elemdb++;
        }
        
        static void Main(string[] args)
        {
            string s;
            int ev;
            elemdb = 0;
            StreamReader o = File.OpenText("kemelem.txt");
            o.ReadLine();
            while (!o.EndOfStream)
            {
                s = o.ReadLine();
                sorol(s);
            }
            o.Close();
            do
            {
                Console.Write("Kérek egy évszámot 1700 után:");
                s = Console.ReadLine();
                ev = Convert.ToInt32(s);
            } while (ev<1700);
            Console.WriteLine("{0} évben ismert elemek:",ev);
            for (int i = 0; i < elemdb; i++)
            {
                if (elemek[i].felfev <= ev)
                {
                    Console.WriteLine("{0}, {1}",elemek[i].nev,elemek[i].vegyj);
                }
            }

            Console.ReadKey();
        }
    }
}
