using System;
using System.IO;

namespace intSzolgTáblázatNumerikus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader fbe = new StreamReader("ADATFORG.txt");
                fbe.ReadLine();
                int osszeAdat = 0;
                int kliensekSzama = 0;
                int maxForgalom = 0;
                string maxKliens ="";
                int Kliensek1000MB = 0;
                while(!fbe.EndOfStream)
                {
                    string sor = fbe.ReadLine();
                    kliensekSzama++;
                    var elemek = sor.Split(';',StringSplitOptions.RemoveEmptyEntries);
                    int osszegKliens = 0;
 
                    for (int i = 2; i < elemek.Length; i++)
                    {
                        osszegKliens += int.Parse(elemek[i]);
                    }
                    osszeAdat += osszegKliens;

                    if(maxForgalom<osszegKliens)
                    {
                        maxForgalom = osszegKliens;
                        maxKliens = elemek[0];
                    }

                    if (elemek[1] == "1000")
                        Kliensek1000MB++;
                }
                Console.WriteLine($"A legtöbb adatot használó ügyfél {maxKliens} adatforgalma={maxForgalom}");
                Console.WriteLine($"A kliensek átlagos adatforgalma={(double)osszeAdat/kliensekSzama:F2}");
                Console.WriteLine($"Az 1000MB sávszélességet használó kliensek száma={Kliensek1000MB}");
                
                StreamWriter fki = new StreamWriter("kimenet.txt");

                fki.WriteLine($"A legtöbb adatot használó ügyfél {maxKliens} adatforgalma={maxForgalom}");
                fki.WriteLine($"A kliensek átlagos adatforgalma={(double)osszeAdat / kliensekSzama:F2}");
                fki.WriteLine($"Az 1000MB sávszélességet használó kliensek száma={Kliensek1000MB}");

                fki.Close();
                fbe.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Hiba!!!\n {e.Message}");
                Console.ReadKey();
                return;
            }
            
            
        }
    }
}
