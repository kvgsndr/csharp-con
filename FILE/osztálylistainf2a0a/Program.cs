using System;
using System.IO;
using System.Collections.Generic;


namespace osztálylistainf2a0a
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            StreamReader fbe = new StreamReader("10ainf2.csv");
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                int poz = sor.IndexOf(" (2");
                sor=sor.Remove(poz);
                var elemek = sor.Split(';');
                nevek.Add(elemek[1]);

            }
            int sorSzam;
            do 
            { 
                Console.Write("Sorszám: ");
                sorSzam = int.Parse(Console.ReadLine());
            } while (sorSzam <1 || sorSzam>nevek.Count);

            Console.WriteLine($"{nevek[sorSzam-1]}");

            //0;vezetéknév keresztnév;0
            //10ainf2.txt

            StreamWriter fki = new StreamWriter("10ainf2.txt");

            for (int i = 0; i < nevek.Count; i++)
            {
                fki.WriteLine($"0;{nevek[i]};0");
            }

            fki.Close();
            fbe.Close();



            




        }
    }
}
