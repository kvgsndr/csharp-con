using System;
using System.IO;

namespace szamok_beolvas_2_oszlop
{
    class Program
    {
        static void Main(string[] args)
        {   
            StreamReader fbe;
            int[] oszlop1 = new int[50];
            int[] oszlop2 = new int[50];
            try
            {
                fbe = new StreamReader("szamok2oszlop.txt");
                //fbe = File.OpenText("szamok2oszlop.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("A File nem nyitható meg!!");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < 50; i++)
            {
                var sorelemek = fbe.ReadLine().Split(';');
                oszlop1[i] = int.Parse(sorelemek[0]);
                oszlop2[i] = int.Parse(sorelemek[1]);
            }
            //Melyik tömbben nagyobb az elemek összege?
            long a = osszeg(oszlop1, 50);
            long b = osszeg(oszlop2, 50);
            if (a > b)
                Console.WriteLine("Az első oszlopban nagyobb az elemek összege");
            else if (a < b)
                Console.WriteLine("Az második oszlopban nagyobb az elemek összege");
            else
                Console.WriteLine("Az elemek összege egyenlő minkét oszlopban");

            //Melyik tömb tartalmaz több negatív számot?
            a = negativak(oszlop1, 50);
            b = negativak(oszlop2, 50);
            if (a > b)
                Console.WriteLine("Az első oszlopban nagyobb a negativak száma.");
            else if (a < b)
                Console.WriteLine("Az második oszlopban nagyobb a negativak száma.");
            else
                Console.WriteLine("Az  negativ elemek száma egyenlő minkét oszlopban");

            //Van - e olyan szám, ami mindkét tömbben ugyanott található?

            if ( azonoshelyen(oszlop1, oszlop2,50) )
                Console.WriteLine("Igen vannak azonos számok azonos helyen!");
            else
                Console.WriteLine("Nincsenek azonos számok azonos helyen!");


            //Hány esetben nagyobb a két tömb azonos helyen lévő elemeiből az első tömbben lévő?
           
            Console.WriteLine($"{nagyobbakszama(oszlop1, oszlop2, 50)} esetben nagyobb a két tömb azonos helyen lévő elemeiből az első tömbben lévő");



            //Melyik tömbben található a legnagyobb szám?
            a = legnagyobb(oszlop1, 50);
            b = legnagyobb(oszlop2, 50);
            if (a > b)
                Console.WriteLine("A legnagyobb elem az első tömbben található!");
            else if (a < b)
                Console.WriteLine("A legnagyobb elem az második tömbben található!");
            else
                Console.WriteLine("A legnagyobb elem az első és második tömbben található!");




            //Helyezd el egy harmadik tömbben a két tömb elemeit úgy, hogy a fájlban azonos sorban 
            //lévő elemek egymás után legyenek! Első tömb 1.eleme, második tömb 1.eleme, első tömb 2.eleme, stb.
            //Írd ki az új tömböt a képernyőre!
            int[] tomb3 = new int[100];
            int k = 0;
            for (int i = 0; i < 50; i++)
            {
                tomb3[k] = oszlop1[i]; Console.Write($"{tomb3[k]} ");
                k++;
                tomb3[k] = oszlop2[i]; Console.Write($"{tomb3[k]} ");
                k++;
            }
            Console.WriteLine("\n");
            
            tombKiir(tomb3);


            //Melyik tömbben található az a két szomszédos szám, amelyeknek legnagyobb az összege?

            //Melyik az a legkisebb intervallum, amelyben a két tömb elemei benne vannak?

            //Válogasd ki egy negyedik tömbbe a két tömbben lévő számokat úgy, hogy mindegyik szám csak egyszer szerepeljen!

            //Melyik tömbben található több egyedi érték?

        }//Main vége

        static void tombKiir(int[] t)
        {
            foreach (var item in t)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();

        }

        private static int legnagyobb(int[] t, int n)
        {
            int nagy = t[0];
            for (int i = 1; i < n; i++)
            {
                if (nagy<t[i])
                {
                    nagy = t[i];
                }
            }
            return nagy;

        }

        private static int nagyobbakszama(int[] oszlop1, int[] oszlop2, int n)
        {
            int nagyobb = 0;

            for (int i = 0; i < n; i++)
            {
                if (oszlop1[i] > oszlop2[i])
                {
                    nagyobb++;
                }
            }

            return nagyobb;
        }

        private static bool azonoshelyen(int[] oszlop1, int[] oszlop2, int n)
        {
            //bool van = false;
            for (int i = 0; i < n; i++)
            {
                if (oszlop1[i] == oszlop2[i])
                {
                    return true; //2. megoldás
                    //van = true;
                    //break;
                }
            }
            return false; //2. megoldás
            //return van;
        }

        static int negativak(int[] t, int n)
        {
            int db = 0;
                for (int i = 0; i < n; i++)
                {
                    if (t[i] < 0) db++;
                }
            return db;

        }

        static long osszeg(int[] t, int n)
        {
            long szum = 0;
            for (int i = 0; i < n; i++)
            {
                szum += t[i];
            }
            return szum;
        }
    }
}
