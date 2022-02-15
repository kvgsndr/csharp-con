using System;
using System.IO;


namespace sudokuCLI
{
    class Program
    {    public static void fel(int n)
            { Console.Write($"{n}. feladat: "); }
        
        static void Main(string[] args)
        {   
            //2.A forráskódba a meglévő osztály elé illessze be az Osztaly.java avagy az Osztaly.cs
            //forrásállományból a Feladvany osztályt definiáló kódrészletét!A beillesztett osztály
            //tetszés szerint bővíthető további tagokkal!
            
            string[] sorok = new string[250];
                
            StreamReader fbe = new StreamReader("feladvanyok.txt");
            int sorokSzama = 0;
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                sorok[sorokSzama] = sor;
                sorokSzama++;
            }
            //3.Olvassa be a feladvanyok.txt állományban lévő adatokat és tárolja el egy olyan
            //adatszerkezetben, ami a további feladatok megoldására alkalmas! Határozza meg és írja ki
            //a képernyőre a minta szerint, hogy hány feladvány található a forrásállományban!
            fel(3);
            Console.WriteLine($"Beolvasva {sorokSzama} feladat.");

            //4. Kérjen be a felhasználótól egy 4...9 intervallumba eső(4≤x≤9) egész számot!A beolvasást
            //addig ismételje, amíg a megfelelő értékhatárból érkező számot nem kapjuk!Határozza meg,
            //és írja a képernyőre, hogy ebből a méretből hány feladvány található a forrásállományban!
            int meret;
            do
            {   fel(4);
                Console.Write("Kérem a feladvány méretét [4..9]: ");
                meret = int.Parse(Console.ReadLine());

            } while (meret<4 || meret>9);

            int feladvanyokSzama = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                if (sorok[i].Length == meret * meret) feladvanyokSzama++;
            }
            Console.WriteLine($"{meret}x{meret} méretű feladványból {feladvanyokSzama} darab van tárolva.");

            //5.Válasszon ki véletlenszerűen egy feladványt, amely az előző feladatban bekért méretű!
            //A kiválasztott feladványt jelenítse meg a képernyőn a minta szerint! Ha nem sikerült
            //véletlenszerű feladványt kiválasztani, akkor dolgozzon a legelső beolvasott feladvánnyal!

            Random rnd = new Random();

            int feladvany= rnd.Next(sorokSzama);
            while (sorok[feladvany].Length != meret * meret)
                feladvany = rnd.Next(sorokSzama);

            fel(5);
            Console.Write($"A kiválasztott feladvány:\n{sorok[feladvany]}");

            //6. Határozza meg és írja a képernyőre a kiválasztott feladvány kitöltöttségét % -os formában
            // a minta szerint!A kitöltöttségen a kitöltött mezők arányát értjük az összes mező számához
            //viszonyítva! A százalékos értéket egész számra kerekítve jelenítse meg!
            fel(6);
            Console.WriteLine($"A feladvány kitöttsége: ttooooooo");

            int nullakSzama(string[] sorok, int sorszam)
            {
                int nullak = 0;
                foreach (var item in sorok[sorszam])
                {
                    if (item == '0') nullak++;
                }
                return nullak;
            }



        }
    }
}
