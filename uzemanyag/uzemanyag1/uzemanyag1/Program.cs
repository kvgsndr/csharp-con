using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace uzemanyag1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            string[] forras = File.ReadAllLines("uzemanyag.txt");
            List < Valtozas > v = new List<Valtozas>();
            foreach ( var i in forras)
            {
                v.Add(new Valtozas(i));
            }
            Console.WriteLine("3. feladat: Változások száma: {0}", v.Count);

            //4. feladat
            Console.Write("4. feladat: A legkisebb különbség: ");
            int legkisebbkulonbseg = int.MaxValue;
            foreach (var i in v)
            {
                if (i.Kulonbseg < legkisebbkulonbseg) 
                {
                    legkisebbkulonbseg = i.Kulonbseg;
                }
            }
            Console.WriteLine(legkisebbkulonbseg);

            //5.feladat
            int dbmin = 0;
            foreach (var i in v)
            {
                if (i.Kulonbseg == legkisebbkulonbseg)
                {
                    dbmin++;
                }
            }
            Console.WriteLine("5. feladat: A legkisebb különbség előfordulása: {0}", dbmin);

            //6. feladat
            string volte = "Nem volt";
            foreach (var i in v)
            {
                if (i.szokonape) 
                {
                    volte = "Volt";
                    break;
                }
            }
            Console.WriteLine("6. feladat: {0} változás szökőnapon",volte);
            Console.ReadKey();
        }
    }
}
