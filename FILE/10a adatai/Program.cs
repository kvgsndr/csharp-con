using System;
using System.IO;
using System.Collections.Generic;

namespace _10a_adatai
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "9d_csop1_dk.txt";
            StreamReader fbe = new StreamReader(fileName);
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
            fbe.Close();
            StreamWriter fki = new StreamWriter(fileName);
            foreach (var item in nevek)
            {
                fki.WriteLine($"0;{item};0");
            }
            fki.Close();
           

        }
    }
}
