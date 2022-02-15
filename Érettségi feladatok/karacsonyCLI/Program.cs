using System;
using System.Collections.Generic;
using System.IO;

namespace karacsonyCLI
{
    class NapiMunka
    {
        public static int KeszultDb { get; private set; }
        public int Nap { get; private set; }
        public int HarangKesz { get; private set; }
        public int HarangEladott { get; private set; }
        public int AngyalkaKesz { get; private set; }
        public int AngyalkaEladott { get; private set; }
        public int FenyofaKesz { get; private set; }
        public int FenyofaEladott { get; private set; }

        public NapiMunka(string sor)
        {
            string[] s = sor.Split(';');
            Nap = Convert.ToInt32(s[0]);
            HarangKesz = Convert.ToInt32(s[1]);
            HarangEladott = Convert.ToInt32(s[2]);
            AngyalkaKesz = Convert.ToInt32(s[3]);
            AngyalkaEladott = Convert.ToInt32(s[4]);
            FenyofaKesz = Convert.ToInt32(s[5]);
            FenyofaEladott = Convert.ToInt32(s[6]);

            NapiMunka.KeszultDb += HarangKesz + AngyalkaKesz + FenyofaKesz;
        }

        public int NapiBevetel()
        {
            return -(HarangEladott * 1000 + AngyalkaEladott * 1350 + FenyofaEladott * 1500);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkak = new List<NapiMunka>();
            StreamReader fbe = new StreamReader("diszek.txt");
            
            while(!fbe.EndOfStream)
            {
                napiMunkak.Add(new NapiMunka(fbe.ReadLine()));
            }

            //while (!fbe.EndOfStream)
            //{
            //    string sor = fbe.ReadLine();
            //    NapiMunka napi = new NapiMunka(sor);
            //    napiMunkak.Add(napi);
            //}

            //string[] sorok=File.ReadAllLines("diszek.txt");
            //for (int  i = 0;  i < sorok.Length;  i++)
            //{
            //    napiMunkak.Add(new NapiMunka(sorok[i]));
            //}
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült! ");

            // 5. feladat
            int készult = 1;
            for (int i = 0; i < napiMunkak.Count; i++)
            {
                if ((napiMunkak[i].AngyalkaKesz + napiMunkak[i].HarangKesz + napiMunkak[i].FenyofaKesz) == 0)
                {
                    Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült! ");
                    készult = 0;
                    break;
                }
            }
            if (készult == 1)
                Console.WriteLine("Nem volt olyan nap, amikor egyetlen dísz sem készült!");

            //6. feladat
            int nap = 0;
            do
            {
                Console.Write("Adja meg a keresett napot [1..40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap<1 || nap>40);

            int angy = 0, feny = 0, har = 0;

            for (int i = 0; i < nap; i++)
            {
                angy += napiMunkak[i].AngyalkaKesz + napiMunkak[i].AngyalkaEladott;
                feny += napiMunkak[i].FenyofaKesz + napiMunkak[i].FenyofaEladott;
                har += napiMunkak[i].HarangKesz + napiMunkak[i].HarangEladott;
            }
            Console.WriteLine($"6. feladat: Angyalka={angy} Fenyőfa={feny} Harang={har}");

            //7. feladat
            angy = 0;
            feny = 0;
            har = 0;
            for (int i = 0; i < 40; i++)
            {
                angy +=  -napiMunkak[i].AngyalkaEladott;
                feny +=  -napiMunkak[i].FenyofaEladott;
                har +=   -napiMunkak[i].HarangEladott;
            }

            int max = -1;
            if (angy > max) max = angy;
            if (feny > max) max = feny;
            if (har > max) max = har;
            Console.WriteLine("7.feladat: Legtöbbet eladott dísz {0} darab", max);
            if (max == angy) Console.WriteLine("\tAngyalka");
            if (max == feny) Console.WriteLine("\tFenyőfa");
            if (max == har) Console.WriteLine("\tHarang");

            //8. feladat
            StreamWriter fki = new StreamWriter("bevetel.txt");

            int tizezerFelett = 0;
            for(int i=0; i<napiMunkak.Count;i++)
            {
                if( napiMunkak[i].NapiBevetel()>=10000)
                {
                    tizezerFelett++;
                    fki.WriteLine("{0}:{1}", i + 1, napiMunkak[i].NapiBevetel());
                }
            }
            fki.WriteLine("{0} napon volt legalább 10000 Ft a bevétel", tizezerFelett);

            fki.Close();




        }
    }
}
