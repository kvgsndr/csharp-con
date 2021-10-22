/*
   Készítsünk programot, mely egy tört számlálójának és nevezőjének megadása után kiírja az egyszerűsített törtet.
*/

class Program 
   { 
      static void Main(string[] args) 
      { 
         Console.Write("A tört számlálója: "); 
         int a = int.Parse(Console.ReadLine()); 
         int x = a; 
         Console.Write("A tört nevezője: "); 
         int b = int.Parse(Console.ReadLine()); 
         int y = b; 
         while (a != 0 && b != 0) 
         { 
            if (a > b) 
               a = a-b; 
            else 
               b = b-a; 
         } 
         int lnko = Math.Max(a, b); 
         Console.WriteLine(); 
         Console.WriteLine("Az egyszerűsített tört számlálója: {0}", x / lnko); 
         Console.WriteLine("Az egyszerűsített tört nevezője: {0}", y / lnko); 
         Console.ReadLine(); 
      } 
   } 