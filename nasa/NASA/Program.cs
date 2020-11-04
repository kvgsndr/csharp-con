using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.feladat
            string[] forras = File.ReadAllLines("NASAlog.txt");
            List<Keres> igenylesek = new List<Keres>();
            foreach (var i in forras)
            {
                igenylesek.Add(new Keres(i));
            }

            //5. feladat:
            Console.WriteLine("5. feladat: Kérések száma: {0}", igenylesek.Count);
            Console.ReadKey();
        }
    }
}
