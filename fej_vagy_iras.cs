/*
Készítsünk programot, amely egy képzeletbeli pénzérmét dobál a levegőbe, majd megállapítja, hogy az a fej, vagy az írás oldalára esett-e le. A pénzérme feldobását követően a program írja ki a képernyőre az eredményt, vagyis, hogy hányszor volt fej, és hányszor írás. Természetesen a pénzérme dobások számát is a felhasználó adja meg a program elején.
*/
class Program 
   { 
      static void Main(string[] args) 
      { 
         Console.Write("Hanyszor dobjuk fel a penzt? "); 
         int db = int.Parse(Console.ReadLine()); 
 
         int fej = 0; 
         int iras = 0; 
 
         for (int i = 0; i < db; i++) 
         { 
            Random veletlen = new Random(); 
            int dobas = veletlen.Next(0, 100); 
            if (dobas % 2 == 0) 
            { 
               fej++; 
            } 
            else 
            { 
               iras++; 
            } 
         } 
 
         Console.WriteLine("{0} db fej, {1} db iras.", fej, iras); 
         Console.ReadLine(); 
      } 
   } 