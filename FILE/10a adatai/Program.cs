using System;
using System.IO;
using System.Collections.Generic;

namespace _10a_adatai
{
    class Program
    {
        static void Main(string[] args)
        {   
            StreamReader fbe = new StreamReader("10ainf2_prog_gy.txt");
            List<string> nevek = new List<string>();
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                int poz = sor.IndexOf(" (");
                sor = sor.Remove(poz);
                string[] elemek = sor.Split('\t');
                sor = elemek[1];

                nevek.Add(sor);
                fbe.ReadLine();
                fbe.ReadLine();
                fbe.ReadLine();
                fbe.ReadLine();
            }
            StreamWriter fki = new StreamWriter("10a_inf2_prog_gy.txt");
            foreach (var item in nevek)
            {
                fki.WriteLine($"0;{item};0");
            }
            fki.Close();
            fbe.Close();

        }
    }
}
