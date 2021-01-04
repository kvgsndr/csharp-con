using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void utoki(int hossz,int ures)
        {
            Console.Clear();
            for (int i = 0; i < ures; i++)
            {
                Console.WriteLine();
            }
            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine("*");
            }
        }

        static void Varakozik()
        {
//            Thread.Sleep(1000); //helyett jobb az alábbi, mert kilép a gombnyomásra
            for (int j = 0; j < 10; j++)
            {
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                    break;
            }
        }

        static void Main(string[] args)
        {
            int hossz;
			Console.Write("Kérem az ütő hosszát (mozgás z,b; ki q): ");
            hossz = Convert.ToInt32(Console.ReadLine());
            int hol;
            hol = 0;
            int szam;
            ConsoleKeyInfo mit;
            do
            {
                utoki(hossz,hol);
                szam = 0;
                do
                {
                    Console.SetCursorPosition(10,10);
                    Console.Write(szam);
                    szam++;
                    Varakozik();
                } while (!Console.KeyAvailable);
                mit = Console.ReadKey(true);
                if (mit.KeyChar == 'z')
                {
                    if (hol>0)
                    {
                        hol--;
                    }
                }
                if (mit.KeyChar == 'b')
                {
                    if (hol+hossz<24)
                    {
                        hol++;
                    }
                }
            } while (mit.KeyChar!='q');
        }
    }
}
