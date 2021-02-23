/*
 * STATISZTIKA
 * A szamok.txt file minden sora egy egész számot tartalmaz.
 * Ezekből készítünk statisztikai adatokat.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace statisztika
{
    struct gyak // a gyakoriságok tárolására
    {
        public int szam;// elyik szám
        public int db;// hányszor fordul elő
    };

    class Program
    {
        static int[] szamok = new int[0]; //a beolvasott számok
        static int db;// hány darabot olvastunk be
        static gyak[] gyakok = new gyak[0];//az előforduló számok gyakorisága
        static int gyakdb;//hány féle szám van
        static void Main(string[] args)
        {
            string tar;//ideiglenes tárolásra
            db = 0;
            gyakdb = 0;
            int atlag = 0;//átlag számításhoz ide gyűjtöm az összeget
            double harmatlag = 0;//harmónikus közép számításához ide gyűjtöm az 1/x-ek összegét
            int minp = 0;//legkisebb elem pozíciója a tömbben
            int maxp = 0;//legnagyobb elem pozíciója a tömbben
            long negyzatlag = 0;//az elemek négyzetének összege
            double med;//a medián értéke (doble, mert lehet tört is)
            int modp = 0;//a leggyakoribb elem pozíciója a gyakoriság tömbben
            int i;//ciklusokhoz
            double szoras = 0;//ide gyűjtöm a szóráshoz az x-xátlagok négyzetéösszegét
            StreamReader olv = new StreamReader("szamok.txt");
            while (!olv.EndOfStream)
            {
                tar = olv.ReadLine();
                Array.Resize(ref szamok, db + 1); // a tömb méretének növelése
                szamok[db] = Convert.ToInt32(tar);
                atlag += szamok[db];
                negyzatlag += szamok[db] * szamok[db];
                harmatlag += 1 / (double)szamok[db];
                if (szamok[db] > szamok[maxp])
                    maxp = db;
                if (szamok[db] < szamok[minp])
                    minp = db;
                i = 0;
                while (i < gyakdb)
                {
                    if (gyakok[i].szam == szamok[db])
                    {// van már
                        gyakok[i].db++;
                        break;
                    }
                    i++;
                }
                if (i == gyakdb)
                {// új szám
                    Array.Resize(ref gyakok, gyakdb + 1);
                    gyakok[gyakdb].szam = szamok[db];
                    gyakok[gyakdb++].db = 1;
                }
                db++;
            }
            olv.Close();
            Console.Write("STATISZTIKA (");
            Console.Write(db);
            Console.WriteLine(")\n");
            Console.Write("ÁTLAG: ");
            Console.WriteLine((double)atlag / db);
            Console.Write("MIN: ");
            Console.WriteLine(szamok[minp]);
            Console.Write("MAX: ");
            Console.WriteLine(szamok[maxp]);
            Console.Write("SZÓRÁS: ");
            for (i = 0; i < db; i++)
            {
                szoras += ((double)atlag / db - szamok[i]) * ((double)atlag / db - szamok[i]);
            }
            Console.WriteLine(Math.Sqrt(szoras/db));
            Console.Write("MÓDUSZ {leggyakoribb}: ");
            for (i = 0; i < gyakdb; i++)
            {
                if (gyakok[i].db > gyakok[modp].db)
                    modp = i;
            }
            Console.Write(gyakok[modp].szam);
            Console.WriteLine(" ({0} db)", gyakok[modp].db);
            Console.Write("MEDIÁN {középső}: ");
            Array.Sort(szamok);
            if (db % 2 == 0)
            {//páros
                med = ((double)szamok[db / 2] + (double)szamok[db / 2 - 1]) / 2;
            }
            else
            {//páratlan
                med = szamok[db / 2];
            }
            Console.WriteLine(med);
            Console.Write("HARMÓNIKUS ÁTLAG {n/szum(1/x)}: ");
            Console.WriteLine((double)db / harmatlag);
            Console.Write("NÉGYZETES ÁTLAG {gyök(szum(x^2)/n)}: ");
            Console.WriteLine(Math.Sqrt((double)negyzatlag / db));
            Console.ReadKey();
        }
    }
}
