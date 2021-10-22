/*
Készítsünk konzol programot, amely bekér (esetleg véletlenszerűen generál) egy bitsorozatot (2-es számrendszerbeli számot), majd átváltja 10-es számrendszerbe.

*/
static void Main(string[] args) 
      { 
         Console.Write("Bitsorozat : "); 
         string bitsor= Console.ReadLine(); 
         double osszeg=0; 
         double hatvany = 2; 
         for (int i = 0; i < bitsor.Length; i++) 
         { 
            hatvany=Math.Pow(2,bitsor.Length-i-1); 
            string szamjegy = bitsor.Substring(i, 1); 
            osszeg +=int.Parse(szamjegy)*hatvany; 
         } 
         Console.WriteLine("Az átváltás eredménye : {0}", osszeg); 
         Console.ReadLine(); 
      } 