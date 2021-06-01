using System;
using System.IO;
using System.Collections.Generic;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
        public double kitöltöttség()
        {
            int db = 0;
            for (int i = 0; i < Kezdo.Length; i++)
                if (Kezdo[i] != '0')
                    db++;

            return (double)db / Kezdo.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            StreamReader fbe = new StreamReader("feladvanyok.txt");
            while (!fbe.EndOfStream)
            {
                feladvanyok.Add(new Feladvany(fbe.ReadLine()));
            }
            fbe.Close();
            Console.WriteLine($"3.feladat: Beolvasva {feladvanyok.Count} feladvány");
            //4.
            int fmerete;
            do
            {
                Console.Write("4. feladat: Kérem a feladvány méretét [4..9]: ");
                fmerete = int.Parse(Console.ReadLine());

            } while (fmerete < 4 || fmerete > 9);
            
            List<Feladvany> adottMeretuek = new List<Feladvany>();
            for (int i = 0; i < feladvanyok.Count; i++)
            {
                if (feladvanyok[i].Meret == fmerete)
                {
                    
                    adottMeretuek.Add(feladvanyok[i]);
                }
            }
            Console.WriteLine($"{fmerete}x{fmerete} méretű feladványból {adottMeretuek.Count} darab van tárolva");
            //5.
            Random rnd = new Random();
            int kivalasztott = rnd.Next(adottMeretuek.Count);// 0...Count-1
            Console.WriteLine($"5.feladat: A kiválasztott feladvány: \n {adottMeretuek[kivalasztott].Kezdo}");
            //6.
            Console.WriteLine($"6.feladat: A feladvány kitöltöttsége: {adottMeretuek[kivalasztott].kitöltöttség() * 100:f0}%");
            //7.
            Console.WriteLine("7.feladat: Feladvány kirajzolva:");
            adottMeretuek[kivalasztott].Kirajzol();
            //8.
            string kimenetiFajlNeve = "sudoku"+ fmerete.ToString()+".txt";  //=$"sudoku{fmeret}.txt"
            StreamWriter fki = new StreamWriter(kimenetiFajlNeve);

            foreach (var felad in adottMeretuek)
            {
                fki.WriteLine(felad.Kezdo);
            }
            fki.Close();
            Console.WriteLine($"8.feladat: {kimenetiFajlNeve} állomány {adottMeretuek.Count} darab feladvánnyal létrehozva");

            Console.ReadKey();
        }
    }
}
