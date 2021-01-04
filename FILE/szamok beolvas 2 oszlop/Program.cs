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
            }
            catch(Exception)
            {
                Console.WriteLine("A File nem nyitható meg!!");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < 50; i++)
            {
                var sorelemek=fbe.ReadLine().Split(';');
                oszlop1[i] = int.Parse(sorelemek[0]);
                oszlop2[i] = int.Parse(sorelemek[1]);
            }
            //Melyik tömbben nagyobb az elemek összege?
            long a = osszeg(oszlop1, 50);
            long b = osszeg(oszlop2, 50);
            if ( a > b  )
                Console.WriteLine("Az első oszlopban nagyobb az elemek összege");
            else if(a < b)
                Console.WriteLine("Az második oszlopban nagyobb az elemek összege");
            else
                Console.WriteLine("Azelemek összege egyenlő minkét oszlopban");

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

            //Hány esetben nagyobb a két tömb azonos helyen lévő elemeiből az első tömbben lévő?

            //Melyik tömbben található a legnagyobb szám?
           
            //Helyezd el egy harmadik tömbben a két tömb elemeit úgy, hogy a fájlban azonos sorban 
            //lévő elemek egymás után legyenek! Első tömb 1.eleme, második tömb 1.eleme, első tömb 2.eleme, stb.
            //Írd ki az új tömböt a képernyőre!
            
            //Melyik tömbben található az a két szomszédos szám, amelyeknek legnagyobb az összege?
            
            //Melyik az a legkisebb intervallum, amelyben a két tömb elemei benne vannak?
            
            //Válogasd ki egy negyedik tömbbe a két tömbben lévő számokat úgy, hogy mindegyik szám csak egyszer szerepeljen!
            
            //Melyik tömbben található több egyedi érték ?

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
