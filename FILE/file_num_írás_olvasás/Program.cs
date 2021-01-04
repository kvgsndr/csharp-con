using System;
using System.Collections.Generic;
using System.IO;

namespace file_num_írás_olvasás
{
    class Program
    {
        static void Main(string[] args)
        {
            
            fileNumLetrehoz("szamok.txt", 15, 10, 1, 10, ';');
            StreamReader fbe;

            try
            {
                 fbe = new StreamReader("szamok.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Hiba történt a fájl megnyitásakor! Kilépés!");
                return;
            }

            while (!fbe.EndOfStream)
            {
                string[] szamaokstring = fbe.ReadLine().Split(';');
                List<int> szamok = new List<int>();
                for (int i = 0; i < szamaokstring.Length; i++)
                {
                    szamok.Add(Convert.ToInt32(szamaokstring[i]));
                }

                int osszeg = 0;
                foreach (var item in szamok)
                {
                    osszeg += item;
                }
                Console.WriteLine($"{(double) osszeg/szamok.Count}");


            }




            Console.ReadKey();
        }

        private static void fileNumLetrehoz(string fileneve, int sorok, int darabpersor, int kezd, int vegso, char elvalaszto)
        {
            StreamWriter fki = new StreamWriter(fileneve);
            Random rnd = new Random();
            for (int i = 0; i < sorok; i++)
            {
                string s = "";
                for (int j = 1; j <= darabpersor; j++)
                {
                    s += rnd.Next(kezd, vegso + 1).ToString();
                    if (j != darabpersor) s += elvalaszto;   // 12;45;.....;21
                }
                fki.WriteLine(s);
            }
            fki.Close();
        }
    }
}
