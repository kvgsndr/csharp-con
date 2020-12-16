using System;
using System.IO;

namespace szamok_atlaga_file
{
    class Program
    {
        static void Main(string[] args)
        {
            fileletrehoz();
            StreamReader fbe = new StreamReader("szamok.txt");
            StreamWriter fki = new StreamWriter("atlogok.txt");

            while (!fbe.EndOfStream)
            {
               atlag(fbe, fki);

            }

            fbe.Close();
            fki.Close();
           
            
            Console.ReadKey();
        }

        private static void atlag(StreamReader fbe, StreamWriter fki)
        {
            int intszam;
            int osszeg = 0;
            string[] szamok = fbe.ReadLine().Split(';');
            for (int i = 0; i < szamok.Length; i++)
            {
                intszam = int.Parse(szamok[i]);
                osszeg += intszam;
            }
            double atl = (double)osszeg / 5;
            fki.WriteLine(atl);
            Console.WriteLine(atl);
            
        }

        private static void fileletrehoz()
        {
            StreamWriter fki = new StreamWriter("szamok.txt");
            Random rnd = new Random();
            int[] szamok5 = new int[5];


            for (int sor = 0; sor < 543; sor++)
            {


                for (int i = 0; i < 5; i++)
                {
                    szamok5[i] = rnd.Next(1, 91);
                }
                string s = String.Format($"{szamok5[0]};{szamok5[1]};{szamok5[2]};{szamok5[3]};{szamok5[4]}");
                fki.WriteLine(s);

            }

            fki.Close();
        }
    }
}
