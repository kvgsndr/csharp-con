using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nemzetiparkok
{

    class Program
    {
        static public string[] nev = new string[20];
        static public string[] igaz = new string[20];
        static public int[] alapitas = new int[20];
        static public int[] terulet = new int[20];
        static public int db = 0;
        static public int szum = 0;


        static void Main(string[] args)
        {
            beolvasas("np.txt");
            Console.WriteLine("Nemzeti Parkok információi.");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("Hány NP található magyarországon?");
            elso();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Táblázat");
            Console.WriteLine();
            tablazat();
            Console.WriteLine();
            
            ossz();
            Console.WriteLine();
            nagyobb();
            Console.WriteLine();
            alap();
            Console.WriteLine(  );
            dunas();
            Console.WriteLine();
            kereses();
            Console.WriteLine();
            toredek();
            Console.WriteLine();
            min();
            Console.WriteLine();
            max();
            Console.ReadKey();

        }

        private static void max()
        {
            int max = alapitas[0];
            int index = 0;
            for (int i = 0; i < db; i++)
            {
                if (max < alapitas[i])
                {
                    max = alapitas[i];
                    index = i;
                }
            }
        }

        private static void min()
        {
            int min = alapitas[0];
            int index = 0;
            for (int i = 0; i < db; i++)
            {
                if (min>alapitas[i])
                {
                    alapitas[i] = min;
                    index = i;
                }
            }
            Console.WriteLine("A legöregebb nemzeti park jelenleg: " + nev[index]);
        }

        private static void toredek()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Adja meg a szó töredéket:");
            string toredek = Console.ReadLine();
            for (int i = 0; i < db; i++)
            {
                if (nev[i].Contains(toredek))
                {
                    Console.WriteLine(nev[i]);
                }
            }
        }

        private static void kereses()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int index = 0;
            Console.WriteLine("Add meg az igazgatóság nevét:");
            string kereses = Console.ReadLine();
            for (int i = 0; i < db; i++)
            {
                if (igaz[i]==kereses)
                {
                    index = i;
                }
            }
            Console.WriteLine("{0} a következő Nemzeti Park igazatósága: {1}",kereses,nev[index]);
        }

        private static void dunas()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
             int count = 0;
            for (int i = 0; i < db; i++)
            {
                if (nev[i].Contains("Duna"))
                {
                    count++;
                }
            }
            Console.WriteLine("Jelenleg {0} Nemzeti Park viseli a Duna nevet",count);
        }

        private static void alap()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            int count = 0;
            for (int i = 0; i < db; i++)
            {
                if (alapitas[i]==1997)
                {
                    count++;
                }
            }
            Console.WriteLine("Pontosan {0} parkot alapítottak 1997-ben",count);
        }

        private static void nagyobb()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int count = 0;
            for (int i = 0; i < db; i++)
            {
                if (terulet[i]>50000)
                {
                    count++;
                }
            }
            Console.WriteLine("Összesen {0} olyan Nemzeti Park van, amely területe meghaladja az 50.000 hektárt",count);
        }

        private static void ossz()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
             szum = 0;
            for (int i = 0; i < db; i++)
            {
                szum = szum + terulet[i];
            }
            Console.WriteLine("A Nemzeti Parkok összterülete {0} hektár.",szum);
        }

        private static void tablazat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}", "Név", "Igazgatóság", "Terület", "Alapítás");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20}",nev[i],igaz[i],terulet[i],alapitas[i]);
            }
        }

        private static void elso()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Magyarországon {0} Nemzeti Park található.",db);
        }

        private static void beolvasas(string file)
        {
            try
            {
                StreamReader olvas = new StreamReader(file);
                string egysor = "";
                olvas.ReadLine(); //az első sort át kell ugranom.
                while (!olvas.EndOfStream)
                {
                    egysor = olvas.ReadLine(); //eltárolom az egy sornyi adatot.
                    nev[db] = egysor.Split(';')[0];
                    igaz[db] = egysor.Split(';')[1];
                    terulet[db] = Convert.ToInt32(egysor.Split(';')[2]);
                    alapitas[db] = Convert.ToInt32(egysor.Split(';')[3]);
                    db++;
                }
                olvas.Close();
            }
            catch (IOException)
            {

                Console.WriteLine("Hiba a fájlok feldolgozása közben.");
            }
        }
    }
}
