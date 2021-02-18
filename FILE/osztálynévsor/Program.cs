using System;
using System.IO;
using System.Collections.Generic;

namespace osztálynévsor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            nevek.Add(" ");// nulladik elem
            StreamReader fbe = new StreamReader("10ainf1.csv");
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(';');
                nevek.Add(elemek[1]);
            }
            int sorSzam;
            do
            {
                Console.Write("Írj be egy sorszámot:");
                sorSzam = int.Parse(Console.ReadLine());
            } while (sorSzam < 1 || sorSzam > nevek.Count - 1);

            Console.WriteLine(nevek[sorSzam]);

            // 0;vezetéknév és keresztnév;0
            // 10ainf1.txt
            StreamWriter fki = new StreamWriter("10ainf1.txt");

            for (int i = 1; i < nevek.Count; i++)
            {
                fki.WriteLine($"0;{nevek[i]};0");
            }
            fki.Close();
            fbe.Close();




            Console.ReadKey();
        }
    }
}
