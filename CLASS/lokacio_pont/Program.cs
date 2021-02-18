using System;

namespace lokacio_pont
{        
    


    class Program
    {
        public class Lokacio
        {
            
            public int X {get; set;}
            public int Y {get; set;}

            public Lokacio(int xx, int yy)
            {
                X = xx;
                Y = yy;

            }
            public virtual void kiir()
            {
                Console.WriteLine($"Lokácio: ({X}, {Y})");
            }

        }//Lokacio

        class Pont : Lokacio
        {
            ConsoleColor szin;
            
            public Pont(int xx, int yy, ConsoleColor szin):base(xx,yy)
            {
                this.szin = szin;
            }

            public override void kiir()
            {
                ConsoleColor eredeti = Console.ForegroundColor;
                Console.ForegroundColor = szin;
                Console.WriteLine($"Pont: ({X}, {Y})");
                Console.ForegroundColor = eredeti;
            }
        }//Pont


static void Main(string[] args)
        {
            Lokacio a = new Lokacio(10, 20);
            Pont b = new Pont(30, 40, ConsoleColor.Green);
            a.kiir();
            b.kiir();
            
            Console.WriteLine("Hello World!");
        }
    }
}
