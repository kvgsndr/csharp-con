using System;
using System.IO;
using System.Collections.Generic;

namespace egyszamjatek12a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tadat> adatok = new List<Tadat>();
            StreamReader fbe;
            
            try
            {
                fbe = new StreamReader("egyszamjatek.txt");
                while(!fbe.EndOfStream)
                 {
                    adatok.Add(new Tadat(fbe.ReadLine()));
                 }

                //3.Határozza meg és írja ki a képernyőre a minta szerint, hogy a játékban hány játékos vett
                //részt!


                Console.WriteLine($"3. feladat: Játékosok száma: {adatok.Count}");

                //4.Határozza meg és írja ki a képernyőre a minta szerint, hogy a játékban hány fordulót
                //játszottak a játékosok!Feltételezheti, hogy minden játékos minden fordulóban részt vett.

                Console.WriteLine($"4. feladat: Fordulók száma: {adatok[0].Tippek.Count}");

                //5.Döntse el és írja ki a képernyőre a minták szerint, hogy az első fordulóban tippelt - e valaki
                //az 1 - es számra!
                bool egyestTippelt = false;
                foreach (var item in adatok)
                {
                    if (item.Tippek[0] == 1)
                    {
                        egyestTippelt = true;
                        break;
                    }
                }
                string st = egyestTippelt == true ? "volt" : "NEM volt";
                Console.WriteLine($"5. feladat: Az első fordulóban {st} egyes tipp");

                //6.Határozza meg és írja ki a minta szerint, hogy a fordulók során melyik volt a legnagyobb
                //tipp!
                int maxTipp = 0;
                foreach (var item in adatok)
                {   
                    foreach (var t in item.Tippek)
                    {
                        if (t > maxTipp) maxTipp = t;
                    }
                    
                }

                Console.WriteLine($"6. feladat: A legnagyobb tipp a fordulók során: {maxTipp}");

                //7.Kérje be egy forduló sorszámát!Az adatbevitel előtt jelenjen meg a lehetséges legkisebb
                //és legnagyobb fordulószám értéke! Például: „7.feladat: Kérem a forduló
                //sorszámát[1−10]:” (Ebben az esetben 10 db forduló volt az egyszamjatek.txt
                //állományban.) Ha a beadott sorszám nem felel meg a lehetséges értékeknek, akkor az
                //1.fordulóval dolgozzon a következő feladatokban!

                Console.Write($"7. feladat: Kérem a fordulók sorszámát [1..{adatok[0].Tippek.Count}]: ");
                int fordulo = int.Parse(Console.ReadLine());
                if (fordulo < 1 || fordulo > 10)  fordulo = 1;

                //8.Az előző feladatban bekért fordulóban határozza meg és írja ki a minta szerint a nyertes
                //tipp értékét!Ha nem volt nyertes tipp a vizsgált fordulóban, akkor a „Nem volt egyedi tipp
                //a megadott fordulóban!” szöveget jelenítse meg!
                int[] fordulóTippjei = new int[100] ;
                foreach (var item in adatok)
                {
                    fordulóTippjei[  item.Tippek[fordulo - 1]  ]++;
                    
                }
                bool vanGyoztes = false;
                int forduloGyoztese = 0;
                for (int i = 0; i < fordulóTippjei.Length; i++)
                {
                    if (fordulóTippjei[i] == 1)
                    {
                        forduloGyoztese = i;
                        Console.WriteLine($"8.feladat: Nyertes tipp a megadott fordulóban: {forduloGyoztese}");
                        vanGyoztes = true;
                        break;
                    }
                }
                if (!vanGyoztes)
                    Console.WriteLine("8.feladat: Nem volt nyertes a megadott fordulóban! ");

                //9
                if (vanGyoztes)
                    foreach (var item in adatok)
                    {
                        if (item.Tippek[fordulo-1] == forduloGyoztese)
                        {
                            Console.WriteLine($"9.feladat: A forduló nyertese: {item.Nev}");
                        }
                    }
                else
                    Console.WriteLine($"9.feladat: Nem volt nyertes a megadott fordulóban!");



                
            }
            catch (Exception kivetel)
            {
                Console.WriteLine($"HIBA!!!\n {kivetel.Message} ");
                
            }



          Console.ReadKey();
        }
    }
}
