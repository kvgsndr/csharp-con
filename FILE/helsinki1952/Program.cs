using System;
using System.IO;
using System.Collections.Generic;

namespace helsinki1952
{
    class Program
    {   struct Adat
        {
            public int helyezes;
            public int sportolokSzama;
            public string sportag;
            public string versenyszam;
        }

        static void Main(string[] args)
        {
            Adat adat = new Adat();
            List<Adat> lista = new List<Adat>();
            //Adat[] lista = new Adat[200];
            StreamReader fbe = new StreamReader("helsinki.txt");
            // int sorokSzama = 0;
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(' ');
                adat.helyezes = int.Parse(elemek[0]);
                adat.sportolokSzama = int.Parse(elemek[1]);
                adat.sportag = elemek[2];
                adat.versenyszam = elemek[3];
                lista.Add(adat);
                //lista[sorokSzama] = adat; sorokSzama++;
            }



            Console.WriteLine($"3. feladat:\nPontszerző helyezések száma: {lista.Count}");//sorokSzama 

            int arany = 0, ezust = 0, bronz = 0;
            foreach (var elem in lista)
            {
                switch (elem.helyezes)
                {
                    case 1: arany += 1;break;
                    case 2: ezust++; break;
                    case 3: bronz++;break;
                        
                }
            }
            Console.WriteLine($"4. feladat:\nArany: {arany}\nEzüst: {ezust}\nBronz: {bronz}\nÖsszesen: {arany+ezust+bronz}");

            int pontokSzama = 0;
            foreach (var elem in lista)
            {
                switch (elem.helyezes)
                {
                    case 1: pontokSzama += 7; break;
                    case 2: pontokSzama += 5; break;
                    case 3: pontokSzama += 4; break;
                    case 4: pontokSzama += 3; break;
                    case 5: pontokSzama += 2; break;
                    case 6: pontokSzama += 1; break;
                }
            }
            Console.WriteLine($"5. feladat:\nOlimpiai pontok száma: {pontokSzama}");


            int uszok = 0, torna = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].sportag == "uszas" && lista[i].helyezes <= 3) uszok++;
                else if (lista[i].sportag == "torna" && lista[i].helyezes <= 3) torna++;
            }
            Console.WriteLine("6. feladat:");
            if(uszok>torna)
                Console.WriteLine($"Az úszó sportágban szereztek több érmét!");
            else if(uszok<torna)
                Console.WriteLine($"Az torna sportágban szereztek több érmét!");
            else
                Console.WriteLine($"Egyenlő volt az érmek száma!");
            
            //7.feladat
            StreamWriter fki = new StreamWriter("helsinki2.txt");
            foreach (var elem in lista)
            {
                switch (elem.helyezes)
                {
                    case 1: pontokSzama = 7; break;
                    case 2: pontokSzama = 5; break;
                    case 3: pontokSzama = 4; break;
                    case 4: pontokSzama = 3; break;
                    case 5: pontokSzama = 2; break;
                    case 6: pontokSzama = 1; break;
                }

                if (elem.sportag=="kajakkenu")
                {
                    fki.WriteLine($"{elem.helyezes} {elem.sportolokSzama} {pontokSzama} {"kajak-kenu"} {elem.versenyszam}");
                }
                else
                    fki.WriteLine($"{elem.helyezes} {elem.sportolokSzama} {pontokSzama} {elem.sportag} {elem.versenyszam}");
            }
            fki.Close();




            Console.ReadKey();
        }
    }
}
