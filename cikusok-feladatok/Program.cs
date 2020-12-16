using System;   //10b 10a inf1 10a inf2

namespace cikusok_feladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine("{0}. Kővágó Sándor", i+1);
                Console.WriteLine($"{i+1}. Kővágó Sándor");
            }
            

            int i = 1;
            while (i <= 10) Console.WriteLine($"{i++}. Kővágó Sándor");
               
            
            
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,5} ");
            }
            Console.WriteLine();

            for (int i = 2; i <= 20; i+=2)
            {
                Console.Write($"{i,5} ");
            }
            Console.WriteLine();

            for (int i = 5; i < (5+7*10); i += 7)
            {
                Console.Write($"{i,5} ");
            }
            Console.WriteLine();

            for (int i =197; i> (197-10*7); i -= 7)
            {
                Console.Write($"{i,5} ");
            }
            Console.WriteLine();
            
            
            
            
            
            int x = 197;
            for (int i = 0; i<10 ; i += 1)
            {
                Console.Write($"{x,5} ");
                x -= 7;
            }
            Console.WriteLine();

            for (int i = 0, xx=197; i < 10; i++, xx-=7) 
                Console.Write($"{xx,5} ");
            
                
            



           
            int szam , elso=1;
            do
            {
                if (elso != 1) Console.WriteLine("Figyelem ! 3 számjegy!!!!");
                Console.Write("Írj be egy 3 jegyű számot: ");
                szam = int.Parse(Console.ReadLine());
                elso = 0;
            
            } while (szam<100 || szam>999);
          
                       if(szam %7 ==0)
                           Console.WriteLine($" {szam} Osztható 7-el.");
                       else
                           Console.WriteLine(" {0} NEM Osztható 7-el.", szam);

           
            Console.WriteLine();



            int o1 = 0, o2 = 0, o3 = 0;
            for (int i = 1; i < 10; i++)
            {
                int ketto_i = 2 * i, inegyzet = i * i;
                o1 += i;
                o2 += ketto_i;
                o3 += inegyzet;

                Console.WriteLine($"{i,5}{ketto_i,5}{inegyzet,5}");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"{o1,5}{o2,5}{o3,5}");

            

            Console.WriteLine("Írj be az első számot: ");
            int szam2, szam1 = int.Parse(Console.ReadLine());
            bool elso = true;
            do
            {
                if (!elso) Console.WriteLine("A második számnak nagyobbnak kell elennie az elsőtöl!!"); 
                Console.WriteLine("Írj be a második számot: ");
                 szam2 = int.Parse(Console.ReadLine());
                elso = false;

            } while (!(szam2>szam1));

            for (int i = szam2; i>=szam1; i--)
            {
                Console.Write($"{i,5}");
            }



            //Írd ki az első 20 darab 3-al osztható szám felét.

            for(int i=0, szam=3; i<20;i++,szam+=3)
                Console.WriteLine((double)szam/2);
*/
            int szam1;
            //do
            //{
            //    Console.Write("Írj be az első számot: ");
            //    szam1 = int.Parse(Console.ReadLine());
            //} while (!(szam1>0 && szam1<99));

            Console.Write("Írj be az első számot: ");
            szam1 = int.Parse(Console.ReadLine());
            while (!(szam1 > 0 && szam1 < 99))
            {
                Console.Write("Írj be az első számot: ");
                szam1 = int.Parse(Console.ReadLine());
            }


            if (szam1<=6)
                Console.WriteLine("gyerek");
            else if(szam1<=18)
                Console.WriteLine("iskolás");
            else if (szam1<=65)
                Console.WriteLine("dolgozó");
            else
                Console.WriteLine("nyudíjas");


        }
    }
}
