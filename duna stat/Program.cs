using System;
using System.Collections.Generic;
using System.IO;

namespace duna_stat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> vizszint = new List<double>();
            
            StreamReader fbe = new StreamReader("duna.txt");

            while (!fbe.EndOfStream)
            {
               vizszint.Add( double.Parse(fbe.ReadLine()));
            }
            fbe.Close();

            double atlag, osszeg=0;

            foreach (var item in vizszint)
            {
                osszeg += item;
            }
            atlag = osszeg / vizszint.Count;

            StreamWriter fki = new StreamWriter("duna_stat.txt");
            fki.WriteLine($"Átlag vizszint: {atlag}" + Environment.NewLine);

            for (int i = 0; i < vizszint.Count; i++)
            {
                fki.WriteLine($"{vizszint[i],10:0.00} \t {(vizszint[i]-atlag),10:0.000}");
            }
            fki.Close();
            Console.ReadKey();
        }
    }
}
