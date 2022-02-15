using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake kigyo = new Snake();
            kigyo.Pontszamkiir(kigyo.Pontszam);
            kigyo.hatarrajzolas();
            kigyo.kigyiKiir(kigyo.Pontszam, kigyo.XPoziciok,  kigyo.YPoziciok);
            ConsoleKey gomb = Console.ReadKey().Key;
            kigyo.Pontx = kigyo.R.Next(0 + 2, 70 - 2);
            kigyo.Ponty = kigyo.R.Next(0 + 2, 40 - 2);
            kigyo.Pontkiir(kigyo.Pontx, kigyo.Ponty);

            do
            {
                kigyo.Pontkiir(kigyo.Pontx, kigyo.Ponty);
                switch (gomb)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(kigyo.XPoziciok[0], kigyo.YPoziciok[0]);
                        Console.WriteLine(" ");
                        kigyo.YPoziciok[0]--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(kigyo.XPoziciok[0], kigyo.YPoziciok[0]);
                        Console.WriteLine(" ");
                        kigyo.YPoziciok[0]++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(kigyo.XPoziciok[0], kigyo.YPoziciok[0]);
                        Console.WriteLine(" ");
                        kigyo.XPoziciok[0]--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(kigyo.XPoziciok[0], kigyo.YPoziciok[0]);
                        Console.WriteLine(" ");
                        kigyo.XPoziciok[0]++;
                        break;
                }
                if (kigyo.vesztesellenorzo(kigyo.XPoziciok, kigyo.YPoziciok, kigyo.Pontszam))
                {
                    Console.SetCursorPosition(28, 20);
                    Console.Write("A játéknak vége!");
                    kigyo.Jatekban = false;

                }
                kigyo.kigyiKiir(kigyo.Pontszam,kigyo.XPoziciok, kigyo.YPoziciok);

                if (kigyo.Pontx == kigyo.XPoziciok[0] && kigyo.Ponty == kigyo.YPoziciok[0])
                {
                    kigyo.Pontx = kigyo.R.Next(0 + 2, 70 - 2);
                    kigyo.Ponty = kigyo.R.Next(0 + 2, 40 - 2);
                    kigyo.Pontszam++;
                    kigyo.Pontkiir(kigyo.Pontx, kigyo.Ponty);
                    kigyo.Pontszamkiir(kigyo.Pontszam);
                }
                if (Console.KeyAvailable)
                {
                    gomb = Console.ReadKey().Key;
                }
                System.Threading.Thread.Sleep(200);

            } while (kigyo.Jatekban);


            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
