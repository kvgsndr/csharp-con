using System;
using System.Collections.Generic;
using System.IO;

namespace helsinki1952_11amell
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<TAdat> adatok = new List<TAdat>();
            

            try
            {
                StreamReader fbe = new StreamReader("helsinki.txt");
         

                while(!fbe.EndOfStream)
                    adatok.Add(new TAdat(fbe.ReadLine()));
               



            }
            catch (Exception hiba)
            {
                Console.WriteLine($"HIBA!!!!! \n {hiba.Message}");
                
            }
            //            3.Határozza meg és írja ki a képernyőre a minta szerint, hogy hány pontszerző helyezést értek
            //el a magyar olimpikonok!

            int pontosHelyezes = 0;

            for (int  i = 0;  i < adatok.Count;  i++)
            {
                if (adatok[i].helyezes <= 6) pontosHelyezes++;
            }
            Console.WriteLine($"3. feladat: \nPontszerzős helyezések száma: {pontosHelyezes}");

            //            4.Készítsen statisztikát a megszerzett érmek számáról, majd összesítse az érmek számát a
            //minta szerint!
            int arany = 0, ezust = 0, bronz = 0;

            foreach (var elem in adatok)
            {
                switch( elem.helyezes)
                {
                    case 1: arany++; break;
                    case 2: ezust++; break;
                    case 3: bronz++; break;
                }
            }
            Console.WriteLine($"4.feladat:\nArany: {arany}\nEzüst: {ezust}\nBronz: {bronz}\nÖsszesen: {arany + ezust + bronz}");
            //            5.Az olimpián az országokat az elért eredményeik alapján rangsorolják. Az 1−6.
            //helyezéseket olimpiai pontokra váltják, és ezt összegzik. Határozza meg és írja ki a minta
            //szerint az elért olimpiai pontok összegét az alábbi táblázat segítségével!
            int pontok = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                switch (adatok[i].helyezes)
                {
                    case 1: pontok += 7; break;
                    case 2: pontok += 5; break;
                    case 3: pontok += 4; break;
                    case 4: pontok += 3; break;
                    case 5: pontok += 2; break;
                    case 6: pontok += 1; break;
                }
            }
            Console.WriteLine($"5,feladat\nAz olimpiai pontok száma: {pontok}");

            //6.Az úszás és a torna sportágakban világversenyeken mindig jól szerepeltek a magyar
            //sportolók.Határozza meg és írja ki a minta szerint, hogy az 1952 - es nyári olimpián melyik
            // sportágban szereztek több érmet a sportolók! Ha az érmek száma egyenlő, akkor az
            //„Egyenlő volt az érmek száma” felirat jelenjen meg!

            int uszasErmek = 0, tornaErmek = 0;
            foreach (var elem in adatok)
            {
                if (elem.sportag == "uszas" && elem.helyezes <= 3) uszasErmek++;
                if (elem.sportag == "torna" && elem.helyezes <= 3) tornaErmek++;

            }
            if (uszasErmek > tornaErmek) 
                Console.WriteLine($"Úszás sportágban szereztek több érmet");
            else if(uszasErmek<tornaErmek) 
                Console.WriteLine($"Torna sportágban szereztek több érmet");
            else 
                Console.WriteLine($"Egyenlő volt az érmek száma");

            //7.A helsinki.txt állományba hibásan, egybeírva "kajakkenu" került a "kajak-kenu"
            //sportág neve. Készítsen szöveges állományt helsinki2.txt néven, amelybe helyesen,
            //kötőjellel kerül a sportág neve! Az új állomány tartalmazzon minden helyezést a
            //forrásállományból, a sportágak neve elé kerüljön be a megszerzett olimpiai pont is a minta
            //szerint! A sorokban az adatokat szóközzel válassza el egymástól!

            foreach (var item in adatok)
            {
                if (item.sportag == "kajakkenu") item.sportag = "kajak-kenu";
            }
            try
            {
                StreamWriter fki = new StreamWriter("helsinki2.txt");
                foreach (var item in adatok)
                {
                    fki.WriteLine($"{item.helyezes} {item.spSzama} {item.sportag} {item.versenyszam}");
                }
                fki.Close();
            }
            catch(Exception kivete)
            {
                Console.WriteLine("Hiba!!!{0}  ", kivete.Message);
            }

            //8.Határozza meg, hogy melyik pontszerző helyezéshez fűződik a legtöbb sportoló!Írja ki a
            //minta szerint a helyezést, a sportágat, a versenyszámot és a sportolók számát!
            //Feltételezheti, hogy nem alakult ki holtverseny.

            int maxsp = 0;
           
            for(int i =0; i< adatok.Count; i++)
            {
                if (adatok[i].spSzama > adatok[maxsp].spSzama) 
                { 
                    maxsp = i; 
                }
                
            }
            Console.WriteLine(
                $"8.feladat:\n" +
                $"Helyezés: {adatok[maxsp].helyezes}\n" +
                $"Sportág: {adatok[maxsp].sportag}\n" +
                $"Versenyszam: {adatok[maxsp].versenyszam}\n" +
                $"Sportolók száma: {adatok[maxsp].spSzama}"
            );
            


            Console.ReadKey();
        }
    }
}
