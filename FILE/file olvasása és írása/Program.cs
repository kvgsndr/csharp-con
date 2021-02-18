using System;
using System.Collections.Generic;
using System.IO;

namespace file_olvasása_és_írása
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fbe = new StreamReader("szavak.txt");
            List<int> szavak = new List<int>();

            while( !fbe.EndOfStream)
            {
                string sor=fbe.ReadLine();
                var elemek = sor.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int szam = Convert.ToInt32(elemek[1]);
                szavak.Add( szam );
            }
            fbe.Close();

            foreach (var szo in szavak)
            {
                Console.WriteLine(szo);
            }
            Console.WriteLine("\n\n");

            for (int i = szavak.Count-1; i >=0 ; i--)
            {
                Console.WriteLine(szavak[i]);
            }

            StreamWriter fki = new StreamWriter("szavakegysorban.txt");

            for (int i = 0; i < szavak.Count; i+=2)
                fki.Write($"{szavak[i]} ");
            fki.WriteLine();

            fki.Close();


            Console.ReadKey();
        }
    }
}
