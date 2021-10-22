/*
	Készítsünk konzolos alkalmazást, amely beolvas egy számot, majd kiírja a számjegyek összegét a képernyőre.

Magyarázat: A beolvasott számot ne konvertáljuk számmá, ahogy azt a számításokat végző programok esetén tenni szoktuk, hanem hagyjuk meg string formában, mivel így könnyedén szét tudjuk szedni elemeire, vagyis a számjegyeire, melyeket azután át tudunk konvertálni számmá az összeadáshoz. Az konverzióhoz használjuk a int.Parse() metódust az adott string elemre (szam[i].ToString()). Figyelem! A string elemeit is konvertálnunk kell, mivel azok karakter típusúak.
*/

class Program 
   { 
      static void Main(string[] args) 
      { 
         Console.Write("Kerek egy szamot: "); 
         string szam = Console.ReadLine(); 
 
         int osszeg = 0; 
 
         for (int i = 0; i < szam.Length; i++) 
         { 
            osszeg = osszeg + int.Parse(szam[i].ToString()); 
         } 
 
         Console.WriteLine("A szamjegyek osszege: {0}.", osszeg); 
         Console.ReadLine(); 
      } 
   } 