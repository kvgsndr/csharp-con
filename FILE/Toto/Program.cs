using System;
using System.IO;
using System.Collections.Generic;

namespace Toto
{

    class Program
    {

        struct Adat
        {
            public int ev;
            public int het;
            public int fordulo;
            public int t13p1;
            public int ny13p1;
            public string eredmenyek;
        }

        static void Main(string[] args)
        {

            Adat adat = new Adat();
            StreamReader fbe = new StreamReader("toto.txt");
            List<Adat> adatok = new List<Adat>();
            fbe.ReadLine();
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(';');
                adat.ev = int.Parse(elemek[0]);
                adat.het = int.Parse(elemek[1]);
                adat.fordulo = int.Parse(elemek[2]);
                adat.t13p1 = int.Parse(elemek[3]);
                adat.ny13p1 = int.Parse(elemek[4]);
                adat.eredmenyek = elemek[5];

                adatok.Add(adat);
            }
            fbe.Close();
            //3. Határozza meg és írja ki a képernyőre, hány forduló adatai találhatók a forrásállományban!
            Console.WriteLine($"3. feladat: Fordulók száma: {adatok.Count}");

            //4.Számolja meg és írja ki a képernyőre a telitalálatos szelvények számát! 

            //5.Számítsa ki, mekkora volt a „telitalálatos” (T13p1 > 0 vagy Ny13p1> 0) fordulók során
            //a telitalálatos szelvényekre kifizetett nyereményösszegek átlaga!Egy fordulóban a
            //nyereményösszeget a T13p1* Ny13p1 kifejezéssel számolja!Ügyeljen rá, hogy
            //a telitalálatos fordulók során a telitalálatos szelvényekre kifizetett nyereményösszegek
            //összege nem fér el egy 32 bites egész változóban.Az átlagot egész számra kerekítve
            //jelenítse meg!




            int telitalalatosSzelvenyek = 0;
            decimal telitalalatosFordulokOsszege = 0;
            int teleitalalatosFordulokSzama = 0;
            foreach (var item in adatok)
            {
                telitalalatosSzelvenyek += item.t13p1;

                if (item.t13p1 > 0)
                {
                    teleitalalatosFordulokSzama += 1;
                    telitalalatosFordulokOsszege += item.t13p1 * item.ny13p1;
                }



            }
            Console.WriteLine($"4. feladat: Telitalálatos szelvények száma {telitalalatosSzelvenyek} db.");
            Console.WriteLine($"5. feladat: Átlag : {telitalalatosFordulokOsszege / teleitalalatosFordulokSzama:F0}");

            //6.Írja ki annak a két fordulónak az adatait a minta szerint, ahol a legnagyobb és a legkisebb
            //volt az egy telitalálatos szelvény után fizetett nyeremény!Feltételezheti, hogy nem
            //alakult ki holtverseny a két szélsőértéknél és nem fordult olyan elő, hogy a telitalálatos
            //szelvény után ne fizettek volna nyereményt!



            int maxindex = 0, minindex = 0;
            int maxosszeg = int.MinValue, minosszeg = int.MaxValue;

            for (int i = 0; i < adatok.Count; i++)
            {    //max
                if (adatok[i].ny13p1 > maxosszeg)
                {
                    maxosszeg = adatok[i].ny13p1;
                    maxindex = i;

                }
                // min
                if (adatok[i].ny13p1 < minosszeg)
                {
                    minosszeg = adatok[i].ny13p1;
                    minindex = i;

                }

            }

            Console.WriteLine("6. Feladat:");
            Console.WriteLine("Legnagyobb:");
            kiiras(adatok, maxindex);
            Console.WriteLine();

            Console.WriteLine("Legkisebb:");
            kiiras(adatok, minindex);


            static void kiiras(List<Adat> adatok, int index)
            {
                Console.WriteLine($"Év : {adatok[index].ev}");
                Console.WriteLine($"Hét : {adatok[index].het}");
                Console.WriteLine($"Forduló : {adatok[index].fordulo}");
                Console.WriteLine($"Forduló : {adatok[index].fordulo}");
                Console.WriteLine($"Telitalálat : {adatok[index].t13p1} db");
                Console.WriteLine($"Nyeremény : {adatok[index].ny13p1} Ft");
                Console.WriteLine($"Eredmények : {adatok[index].eredmenyek}");
            }


            //7. Forráskódjába tegye elérhetővé a csharp.txt állományból
            //az EredmenyElemzo osztályt definiáló kódrészletet! Az osztály felhasználható arra,
            //hogy megállapítsa egy forduló eredményeiről(pl.: „2X22211X1X11X1”), hogy
            //egyetlen mérkőzés sem végződött döntetlen eredménnyel
            //(NemvoltDontetlenMerkozes).


            //8.Az EredmenyElemzo osztály példányainak alkalmazásával döntse el, hogy volt-e
            //olyan forduló, ahol a 13 + 1 mérkőzés eredménye nem tartalmazott döntetlent! A keresést
            //ne folytassa, ha a választ meg tudja adni! A megállapítását írja a képernyőre!


            foreach (var item in adatok)
            {
                EredmenyElemzo elemzo = new EredmenyElemzo(item.eredmenyek);
                if( !elemzo.NemvoltDontetlenMerkozes)
                {
                    Console.WriteLine($"Nem  volt döntetlen nélküli forduló!");
                    Console.ReadKey();
                    return;
                }
           
            }
            Console.WriteLine($"Volt döntetlen nélküli forduló!");
            Console.ReadKey();





        }


    }
}
