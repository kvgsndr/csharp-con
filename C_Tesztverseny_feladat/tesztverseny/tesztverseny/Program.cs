using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tesztverseny
{
    class Program
    {
        static string joMegoldas = "";
        static string[] megoldasok = new string[500];
        static int db = 0;
        static string[] kod = new string[500];
        static void Main(string[] args)
        {
            beolvas("valaszok.txt");
            resztvevo();
            azonosito();
            sorszam();

            Console.ReadKey();
        }

        private static void sorszam()       //5. feladat
        {
            Console.WriteLine("Add meg a feladat sorszámát:");
            int sorszam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("5. feladat: A feladat sorszáma: {0}", sorszam);
            for (int i = 0; i < db; i++)
            {
                if (joMegoldas[sorszam]==megoldasok[i][sorszam])
            }


        }

        private static void azonosito()     //3. feladat
        {
            Console.WriteLine("Adj meg egy azonosítót: ");
            string beker = Console.ReadLine();

            string bekertMegoldas = "";
            for (int i = 0; i < db; i++)
            {
                if (beker.Equals(kod[i]))       //tartalamazza-e a bekért azonosítót a kod tömb
                {
                    Console.WriteLine("A versenyző azonosítója: {0} ", kod[i]);
                    Console.WriteLine("{0} (a megoldásai)", megoldasok[i]);
                    bekertMegoldas = megoldasok[i];
                }
            }
            //4. feladat

            Console.WriteLine("4. feladat:");
            Console.WriteLine("{0}   (a helyes megoldás)", joMegoldas);
            for (int i = 0; i < joMegoldas.Length; i++)
            {
                if (joMegoldas[i] == bekertMegoldas[i])
                {
                    Console.Write("+");
                } else
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine("(A versenyző helyes válaszai)");


        }

        private static void resztvevo()
        {
            Console.WriteLine("2. feladat: A versenyen {0} versenyző indult", db);
        }

        private static void beolvas(string file)
        {
            try
            {
                StreamReader be = new StreamReader(file);
                string szöveg = "";
                joMegoldas = be.ReadLine();
                string[] darabol = new string[500];
                while ((szöveg = be.ReadLine()) != null)
                {
                    darabol = szöveg.Split(' ');
                    kod[db] = darabol[0];
                    megoldasok[db] = darabol[1];
                    db++;
                }
                Console.WriteLine("A beolvasás sikeres");
            }
            catch (IOException)
            {
                Console.WriteLine("Hiba a {0} file olvasásakor", file);
            }
            
        }
    }
}
