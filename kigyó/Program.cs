using System;
using System.Collections.Generic;

namespace kigyó
{
    

    class Program
    {       public struct Kord
            {
               public int x;
                public int y;
            }
        
        static void Main(string[] args)
        {   Kord kord= new Kord();
            kord.x = 0; kord.y=0;
                
            List<Kord> list = new List<Kord>();
            list.Add(kord);
            Console.Write("Pressa key to start!");
            ConsoleKeyInfo key = Console.ReadKey();
            int x = 0, y = 0;
            int ox = 10, oy = 10;
            Console.SetCursorPosition(ox, oy);
            Console.WriteLine("X");
            bool fut = true;
            while(fut)
            {
               
                
                if (Console.KeyAvailable)
                    key = Console.ReadKey();
                
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:y--;break;
                    case ConsoleKey.DownArrow:y++;break;
                    case ConsoleKey.LeftArrow:x--;break;
                    case ConsoleKey.RightArrow:x++;break;
                    //case 'c':return ;
                }
                kord.x = x;kord.y = y;
               
                 list.Add(kord);
                 if(!(x==ox && y==oy))
                    list.RemoveAt(0);
                 else
                { Random rnd = new Random();
                    ox = rnd.Next(Console.WindowWidth);
                    oy = rnd.Next(Console.WindowHeight);
                }

                Console.Clear();
                foreach (var xykord in list)
                {  
                        
                    Console.SetCursorPosition(xykord.x, xykord.y);
                    Console.WriteLine("@");
                    
                }
                Console.SetCursorPosition(ox, oy);
                Console.WriteLine("X");

                System.Threading.Thread.Sleep(300);
            }

            
        }
    }
}
