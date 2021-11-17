using System;
using System.IO;
using System.Collections.Generic;

namespace OrvosiNobeldijasok
{
    class Program
    {
        class Elethossz
        {
            private int Tol { get; set; }
            private int Ig { get; set; }
            public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

            public bool IsmertAzElethossz => ElethosszEvekben != -1;

            public Elethossz(string SzuletesHalalozas)
            {
                string[] m = SzuletesHalalozas.Split('-');
                try
                {
                    Tol = int.Parse(m[0]);
                }
                catch (Exception)
                {
                    Tol = -1;
                }
                try
                {
                    Ig = int.Parse(m[1]);
                }
                catch (Exception)
                {
                    Ig = -1;
                }
            }
        }

        class Adat
        {
            public int Ev { get; set; }
            public string Nev { get; set; }
            public string SzHal { get; set; }
            public string Orszag { get; set; }

            public Adat(string sor)
            {
                var elemek = sor.Split(';');
                Ev = int.Parse(elemek[0]);
                Nev = elemek[1];
                SzHal = elemek[2];
                Orszag = elemek[3];
            }
        }

        class Orsz
        {
            public string orsz;
            public int db;
            public Orsz(string o)
            {
                orsz = o;
                db = 1;
            }
        }
        
        static void Main(string[] args)
        {
            List<Adat> nobeldijasok = new List<Adat>();
            StreamReader fbe = new StreamReader("orvosi_nobeldijak.txt");
            fbe.ReadLine();   // fejléc kihagyása
            while (!fbe.EndOfStream )
            {
                nobeldijasok.Add(new Adat(  fbe.ReadLine() ));

            }


            // 6. feladat

            //Készítsen statisztikát országonként a díjazottak számáról!A statisztikában csak azok
            //az országok jelenjenek meg, ahol az orvosi Nobel-díjasok száma meghaladta az ötöt!
            //Az országok kiírásának sorrendje tetszőleges!

            

            List<Orsz> statisztika = new List<Orsz>();
            foreach (var item in nobeldijasok)
            {
                bool van = false;
                for (int i = 0; i < statisztika.Count; i++)
                {
                    if (statisztika[i].orsz == item.Orszag)
                    {
                        statisztika[i].db++;
                        van = true;
                        break;
                    }
                        
                }
                if (van == false)
                    statisztika.Add(new Orsz(item.Orszag));
            }
            Console.WriteLine("6. Statisztika");
            foreach (var item in statisztika)
            {
                if (item.db > 5)
                    Console.WriteLine($"\t{item.orsz} - {item.db} fő");
            }


            //7. feladat
            //Forráskódjában tegye elérhetővé a java.txt vagy a csharp.txt állományból
            //az Elethossz osztályt definiáló kódrészletet! Az Elethossz osztály példányaival
            //és az összes publikus tagjának felhasználásával számítsa ki és írja ki a képernyőre azon
            //díjazottak átlagos élethosszát, akiknél ez az adat ismert! Az eredményt egy tizedesjegyre
            //kerekítve jelenítse meg!
            int osszEletkor = 0;
            int szamol = 0;
            foreach (var item in nobeldijasok)
            { Elethossz elethosz = new Elethossz(item.SzHal);
                if ( elethosz.IsmertAzElethossz)
                {
                    osszEletkor += elethosz.ElethosszEvekben;
                    szamol++;
                }
            }

            Console.WriteLine($"7. feladat: A keresett átlag: {(double)osszEletkor / szamol:f1} év");

        }
    }
}
