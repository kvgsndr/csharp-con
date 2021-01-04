using System;
using System.Collections.Generic;
using System.Text;

namespace cserebere
{
    class Program
    {
        static ConsoleColor []szineim = {ConsoleColor.Blue,ConsoleColor.Green,ConsoleColor.Red,ConsoleColor.Magenta,
        ConsoleColor.Yellow,ConsoleColor.Cyan,ConsoleColor.DarkYellow,ConsoleColor.White,ConsoleColor.DarkMagenta,
        ConsoleColor.DarkBlue};

        static void tablakiir(char[,] t, int pont,int sikerdb)
        {// kiírja a táblát és a jelenlegi pontszámot és a sikeres cserék számát
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.SetCursorPosition(x*2 + 10, y*2 + 3);
                    Console.ForegroundColor=szineim[t[x,y]-Convert.ToInt32('A')];
                    Console.Write("{0}", t[x, y]);
                }
            }
            Console.ForegroundColor=ConsoleColor.White;
            for (int x = 0; x < 8; x++)
            {
                Console.SetCursorPosition(x*2 + 10, 1);
                Console.Write("{0}", x + 1);
                Console.SetCursorPosition(8, x*2+3);
                Console.Write("{0}", Convert.ToChar(Convert.ToInt32('a')+x));
            }
            Console.SetCursorPosition(1,20);
            Console.WriteLine("{0} pontod van, {1} próbálkozásból.", pont, sikerdb);
        }
        
        static void feltolt(char[,] t, int db)
        {// t 8*8-as táblát feltölti véletlenszerûen betûkkel
            Random gen = new Random ();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    t[x,y]=Convert.ToChar(Convert.ToInt32('A')+gen.Next(0,db));
                }
            }
        }

        static string beker(string duma,bool kellxx)
        { // duma kiíratása és egy valós koordináta bekérése
            string s;
            bool jo;
            do
            {
                Console.SetCursorPosition(1, 22);
                Console.Write("                                                                           ");
                Console.SetCursorPosition(1, 22);
                Console.Write("{0}", duma);
                s = Console.ReadLine();
                jo = false;
                if (s.Length ==2)
                {
                    if (((s[0]>='a')&&(s[0]<='h')&&(s[1]>='1')&&(s[1]<='8'))||((kellxx)&&(s=="xx")))
                    {
                        jo=true;
                    }
                }
            } while (!jo);
            return s;
        }

        static char kisbetuve(char c)
        {// kisbetûvé alakítja c-t
            return Convert.ToChar(Convert.ToInt32(c) - Convert.ToInt32('A') + Convert.ToInt32('a'));
        }

        static int eltuntet(char[,] t,int db)
        { // eltünteti a 3 vagy többeseket és "lecsurgat" és újat ad vissa az eltüntetett összdarabot

            int x,y,p,edb,csdb,cstotal;
            char c;
            Random gen = new Random();
            //vízszintes vizsgálat
            cstotal = 0;
            csdb = 0;
            do
            {
                cstotal += csdb;
                for (y = 0; y < 8; y++)
                {
                    edb = 1;
                    c = t[0, y];
                    for (x = 1; x < 8; x++)
                    {
                        if (c == t[x, y])
                        {
                            edb++;
                        }
                        else
                        {
                            if (edb >= 3)
                            {//irtásra kell jelölni = kisbetûvé
                                for (p = x - 1; p >= x - edb; p--)
                                {
                                    t[p, y] = kisbetuve(t[p, y]);
                                }
                            }
                            edb = 1;
                            c = t[x, y];
                        }
                    }
                    if (edb >= 3)
                    {//irtásra kell jelölni = kisbetûvé
                        for (p = x - 1; p >= x - edb; p--)
                        {
                            t[p, y] = kisbetuve(t[p, y]);
                        }
                    }
                }
                //függõleges vizsgálat
                for (x = 0; x < 8; x++)
                {
                    edb = 1;
                    c = t[x, 0];
                    for (y = 1; y < 8; y++)
                    {
                        if (c == t[x, y])
                        {
                            edb++;
                        }
                        else
                        {
                            if (edb >= 3)
                            {//irtásra kell jelölni = kisbetûvé
                                for (p = y - 1; p >= y - edb; p--)
                                {
                                    t[x, p] = kisbetuve(t[x, p]);
                                }
                            }
                            edb = 1;
                            c = t[x, y];
                        }
                    }
                    if (edb >= 3)
                    {//irtásra kell jelölni = kisbetûvé
                        for (p = y - 1; p >= y - edb; p--)
                        {
                            t[x, p] = kisbetuve(t[x, p]);
                        }
                    }
                }
                //kisbetûk eltûntetése és lecsurgatás
                csdb = 0;
                for (y = 0; y < 8; y++)
                {
                    for (x = 0; x < 8; x++)
                    {
                        if (Convert.ToInt32(t[x, y]) >= Convert.ToInt32('a'))
                        {// tûntetni kell
                            for (p = y; p > 0; p--)
                            {
                                t[x, p] = t[x, p - 1];
                            }
                            t[x, 0] = Convert.ToChar(Convert.ToInt32('A') + gen.Next(0, db));
                            csdb++;
                        }
                    }
                }
            } while (csdb != 0);
            return cstotal;
        }

        static void Main(string[] args)
        {
            char[,]tabla=new char [8,8];
            string cs1, cs2;
            char tar;
            int x1, x2, y1, y2;
            int pont,sikerdb,betudb,ujpont;
            bool kell=true;
            do
            {
                Console.Write ("Hány betû legyen (4-10)?");
                betudb = Convert.ToInt32 (Console.ReadLine ());
            } while ((betudb<4)||(betudb>10));
            Console.Clear();
            sikerdb = pont = 0;
            feltolt(tabla, betudb);
            eltuntet(tabla,betudb);
            do
            {
                tablakiir (tabla,pont,sikerdb);
                cs1 = beker("Kérem az elsõ cserélendõ koordinátáit (pl. c8){feladás: xx}",true);
                if (cs1 =="xx")
                {
                    kell = false;
                }
                else
                {
                    cs2 = beker("Kérem a második cserélendõ koordinátáit (pl. c7)",false);
                    y1 = Convert.ToInt32(cs1[0]) - Convert.ToInt32('a');
                    x1 = Convert.ToInt32(cs1[1]) - Convert.ToInt32('1');
                    y2 = Convert.ToInt32(cs2[0]) - Convert.ToInt32('a');
                    x2 = Convert.ToInt32(cs2[1]) - Convert.ToInt32('1');
                    if (((x1 == x2) && (Math.Abs(y1 - y2) == 1)) || ((y1 == y2) && (Math.Abs(x1 - x2) == 1)))
                    {// szomszédok
                        tar = tabla[x1, y1];
                        tabla[x1, y1] = tabla[x2, y2];
                        tabla[x2, y2] = tar;
                        ujpont = eltuntet(tabla,betudb);
                        if (ujpont > 0)
                        {
                            pont += ujpont;
                            sikerdb++;
                            if (sikerdb == 10)
                                kell = false;
                        }
                        else
                        {
                            tar = tabla[x1, y1];
                            tabla[x1, y1] = tabla[x2, y2];
                            tabla[x2, y2] = tar;
                        }
                    }
                }
            } while (kell);
            tablakiir(tabla,pont,sikerdb);
            Console.SetCursorPosition(1, 22);
            Console.Write("                                                                           ");
            Console.SetCursorPosition(1, 22);
            if (sikerdb == 10)
                Console.WriteLine ("NYERTÉL! {0} pontod van.",pont);
            else
                Console.WriteLine ("NEM NYERTÉL! {0} pontod van.",pont);
            Console.ReadKey();
        }
    }
}
