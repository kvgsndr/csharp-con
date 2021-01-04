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
        {// ki�rja a t�bl�t �s a jelenlegi pontsz�mot �s a sikeres cser�k sz�m�t
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
            Console.WriteLine("{0} pontod van, {1} pr�b�lkoz�sb�l.", pont, sikerdb);
        }
        
        static void feltolt(char[,] t, int db)
        {// t 8*8-as t�bl�t felt�lti v�letlenszer�en bet�kkel
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
        { // duma ki�rat�sa �s egy val�s koordin�ta bek�r�se
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
        {// kisbet�v� alak�tja c-t
            return Convert.ToChar(Convert.ToInt32(c) - Convert.ToInt32('A') + Convert.ToInt32('a'));
        }

        static int eltuntet(char[,] t,int db)
        { // elt�nteti a 3 vagy t�bbeseket �s "lecsurgat" �s �jat ad vissa az elt�ntetett �sszdarabot

            int x,y,p,edb,csdb,cstotal;
            char c;
            Random gen = new Random();
            //v�zszintes vizsg�lat
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
                            {//irt�sra kell jel�lni = kisbet�v�
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
                    {//irt�sra kell jel�lni = kisbet�v�
                        for (p = x - 1; p >= x - edb; p--)
                        {
                            t[p, y] = kisbetuve(t[p, y]);
                        }
                    }
                }
                //f�gg�leges vizsg�lat
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
                            {//irt�sra kell jel�lni = kisbet�v�
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
                    {//irt�sra kell jel�lni = kisbet�v�
                        for (p = y - 1; p >= y - edb; p--)
                        {
                            t[x, p] = kisbetuve(t[x, p]);
                        }
                    }
                }
                //kisbet�k elt�ntet�se �s lecsurgat�s
                csdb = 0;
                for (y = 0; y < 8; y++)
                {
                    for (x = 0; x < 8; x++)
                    {
                        if (Convert.ToInt32(t[x, y]) >= Convert.ToInt32('a'))
                        {// t�ntetni kell
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
                Console.Write ("H�ny bet� legyen (4-10)?");
                betudb = Convert.ToInt32 (Console.ReadLine ());
            } while ((betudb<4)||(betudb>10));
            Console.Clear();
            sikerdb = pont = 0;
            feltolt(tabla, betudb);
            eltuntet(tabla,betudb);
            do
            {
                tablakiir (tabla,pont,sikerdb);
                cs1 = beker("K�rem az els� cser�lend� koordin�t�it (pl. c8){felad�s: xx}",true);
                if (cs1 =="xx")
                {
                    kell = false;
                }
                else
                {
                    cs2 = beker("K�rem a m�sodik cser�lend� koordin�t�it (pl. c7)",false);
                    y1 = Convert.ToInt32(cs1[0]) - Convert.ToInt32('a');
                    x1 = Convert.ToInt32(cs1[1]) - Convert.ToInt32('1');
                    y2 = Convert.ToInt32(cs2[0]) - Convert.ToInt32('a');
                    x2 = Convert.ToInt32(cs2[1]) - Convert.ToInt32('1');
                    if (((x1 == x2) && (Math.Abs(y1 - y2) == 1)) || ((y1 == y2) && (Math.Abs(x1 - x2) == 1)))
                    {// szomsz�dok
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
                Console.WriteLine ("NYERT�L! {0} pontod van.",pont);
            else
                Console.WriteLine ("NEM NYERT�L! {0} pontod van.",pont);
            Console.ReadKey();
        }
    }
}
