using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KigyoOOP
{
    class Snake
    {
        int[] xPoziciok;
        int[] yPoziciok;
        int pontszam;
        int x;
        int y;
        int pontx;
        int ponty;
        Random r;
        bool jatekban;

        public int[] XPoziciok { get => xPoziciok; set => xPoziciok = value; }
        public int[] YPoziciok { get => yPoziciok; set => yPoziciok = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Pontx { get => pontx; set => pontx = value; }
        public int Ponty { get => ponty; set => ponty = value; }
        public Random R { get => r; set => r = value; }
        public bool Jatekban { get => jatekban; set => jatekban = value; }

        public Snake()
        {
            xPoziciok = new int[50];
            yPoziciok = new int[50];
            xPoziciok[0] = 35;
            yPoziciok[0] = 20;

            pontszam = 0;

            int pontx = 10;
            int ponty = 10;

            r = new Random();

            jatekban = true;

        }
        public void hatarrajzolas()
        {
            for (int i = 1; i < 41; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("#");
                Console.SetCursorPosition(70, i);
                Console.Write("#");
            }
            for (int i = 1; i < 71; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
                Console.SetCursorPosition(i, 40);
                Console.Write("#");
            }
        }
        public bool vesztesellenorzo(int[] xPoziciok, int[] yPoziciok, int pontszam)
        {
            bool vesztette = false;
            if (xPoziciok[0] == 1 || xPoziciok[0] == 70 || yPoziciok[0] == 1 || yPoziciok[0] == 40)
            {
                vesztette = true;
            }
            for (int i = 1; i < pontszam+1; i++)
            {
                
                if (xPoziciok[0] == xPoziciok[i] && yPoziciok[0] == yPoziciok[i])
                {

                    vesztette = true;
                }
            }
            return vesztette;
        }
        public void Pontszamkiir(int pontszam)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Pontszám: " + pontszam);
        }
        public void Pontkiir(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("O");
        }
        public void kigyiKiir(int pontszam, int[] xPoziciokBe, int[] yPoziciokBe)
        {
            int[] xPoziciokKi = new int[50];
            int[] yPoziciokKi = new int[50];
            // Fej
            Console.SetCursorPosition(xPoziciokBe[0], yPoziciokBe[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("X");

            // Test
            for (int i = 1; i < pontszam + 1; i++)
            {
                Console.SetCursorPosition(xPoziciokBe[i], yPoziciokBe[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("0");

            }

            // Utolso rész törlése
            Console.SetCursorPosition(xPoziciokBe[pontszam + 1], yPoziciokBe[pontszam + 1]);
            Console.WriteLine(" ");

            // Uj koorodinatak beirása
            for (int i = pontszam + 1; i > 0; i--)
            {
                yPoziciokBe[i] = yPoziciokBe[i - 1];
                xPoziciokBe[i] = xPoziciokBe[i - 1];
            }

            // adatok frissitése
            xPoziciokKi = xPoziciokBe;
            yPoziciokKi = yPoziciokBe;
        }
    }
}
