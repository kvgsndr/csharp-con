using System;
using System.IO;

namespace helsinki1952_11a
{
    class Program
    {

        static void Main(string[] args)
        {   int elemekSzama = 0;
            Adat[] adatok = new Adat[200];
            try
            {
                
                
                StreamReader fbe = new StreamReader("helsinki.txt");

                
                while( !fbe.EndOfStream )
                {                                            
                        adatok[elemekSzama] = new Adat(fbe.ReadLine());
                        elemekSzama++;
                }
 
            }
            catch (Exception hiba)
            {
                Console.WriteLine($"HIBA !!! \n {hiba.Message}");
            }

            //3.Határozza meg és írja ki a képernyőre a minta szerint, hogy hány pontszerző helyezést értek
            //el a magyar olimpikonok!
            int pontszerzo = 0;
            for (int i = 0; i < elemekSzama; i++)
            {
                if (adatok[i].Helyezes <= 6) pontszerzo++;
            }
            Console.WriteLine($"3. feladat:\nPontszerző helyezések száma: {pontszerzo}");


            //4.Készítsen statisztikát a megszerzett érmek számáról, majd összesítse az érmek számát a
            //minta szerint!
            int arany = 0, ezust = 0, bronz = 0;
            for (int i = 0; i < elemekSzama; i++)
            {
                switch (adatok[i].Helyezes)
                {
                    case 1: arany++; break;
                    case 2: ezust++; break;
                    case 3: bronz++; break;
                }
            }
            Console.WriteLine($"4. feladat:\nArany: {arany}\nEzüst: {ezust}\nBronz: {bronz} ");
            Console.WriteLine($"Összesen: {arany + ezust + bronz}");

            //            5.Az olimpián az országokat az elért eredményeik alapján rangsorolják. Az 1−6.
            //helyezéseket olimpiai pontokra váltják, és ezt összegzik. Határozza meg és írja ki a minta
            //szerint az elért olimpiai pontok összegét az alábbi táblázat segítségével!
            int olomPontok = 0;
            for (int i = 0; i < elemekSzama; i++)
            {
                switch (adatok[i].Helyezes)
                {
                    case 1: olomPontok += 7; break;
                    case 2: olomPontok += 5; break;
                    case 3: olomPontok += 4; break;
                    case 4: olomPontok += 3; break;
                    case 5: olomPontok += 2; break;
                    case 6: olomPontok += 1; break;
                    
                }
            }
            Console.WriteLine($"5.feladat:\nOlimpiai pontok száma: {olomPontok}");

            //            6.Az úszás és a torna sportágakban világversenyeken mindig jól szerepeltek a magyar
            //sportolók.Határozza meg és írja ki a minta szerint, hogy az 1952 - es nyári olimpián melyik
            // sportágban szereztek több érmet a sportolók! Ha az érmek száma egyenlő, akkor az
            //„Egyenlő volt az érmek száma” felirat jelenjen meg!
            int torna = 0, uszas = 0;

            for (int i = 0; i < elemekSzama; i++)
            {
                if (adatok[i].Sportag == "uszas" && adatok[i].Helyezes <= 3) uszas++;
                if (adatok[i].Sportag == "torna" && adatok[i].Helyezes <= 3) torna++;
            }
            if (torna > uszas)
                Console.WriteLine($"6.feladat:\nTorna sportágban szereztek több érmet!");
            else if(uszas> torna)
                Console.WriteLine($"6.feladat:\nÚszás sportágban szereztek több érmet!");
            else
                Console.WriteLine($"6.feladat:\nEgyenlő volt az érmek száma");




            //            7.A helsinki.txt állományba hibásan, egybeírva „kajakkenu” került a kajak-kenu
            //sportág neve. Készítsen szöveges állományt helsinki2.txt néven, amelybe helyesen,
            //kötőjellel kerül a sportág neve! Az új állomány tartalmazzon minden helyezést a
            //forrásállományból, a sportágak neve elé kerüljön be a megszerzett olimpiai pont is a minta
            //szerint! A sorokban az adatokat szóközzel válassza el egymástól!

            for (int i = 0; i < elemekSzama; i++)
            {
                if (adatok[i].Sportag == "kajakkenu") adatok[i].Sportag = "kajak-kenu";
            }
            
            StreamWriter fki = new StreamWriter("helsinki2.txt");
            for (int i = 0; i < elemekSzama; i++)
            {
                fki.WriteLine($"{adatok[i].Helyezes} {adatok[i].SportolokSzama} {adatok[i].Sportag} {adatok[i].Versenyszam}");
            }
            fki.Close();

            //8.Határozza meg, hogy melyik pontszerző helyezéshez fűződik a legtöbb sportoló!Írja ki a
            //minta szerint a helyezést, a sportágat, a vversenyszámot és a sportolók számát!
            //Feltételezheti, hogy nem alakult ki holtverseny.
            int maxSportolo = 0;
            for (int i = 0; i < elemekSzama; i++)
            {
                if (adatok[i].SportolokSzama > adatok[maxSportolo].SportolokSzama)
                { 
                    maxSportolo = i; 
                }
            }
            Console.WriteLine($"8. feladat:\n" +
                $"Helyezés: {adatok[maxSportolo].Helyezes}\n" +
                $"Sportág: {adatok[maxSportolo].Sportag}\n" +
                $"Versenyszám: {adatok[maxSportolo].Versenyszam}\n" +
                $"Sportolók száma: {adatok[maxSportolo].SportolokSzama}");


                Console.ReadKey();
        }
    }
}
