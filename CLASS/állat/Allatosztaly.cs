/*  
 Készíts egy Allat osztályt
•	Minden állatnak van éhsége, ami egy egész szám
•	Minden állatnak van szomja, ami egy egész szám
•	Amikor egy állat létrejön 50-es az éhsége és 50-es a szomja
•	Minden állat tud csinálni dolgokat:
o	eszik() az éhsége csökken eggyel
o	iszik() a szomja csökken eggyel
o	jatszik() az éhsége és szomja növekszik eggyel

 
 */

using System;

namespace állat
{    
    class Allatosztaly
    {
        static void Main(string[] args)
        {
            
            Allat b = new Allat();
            b.kiir();
            Allat a = new Allat("Bodri", 50, 30);
            a.kiir();
            Allat c = new Allat();
            c.kiir();
            c.Szomj = 20;
            //Console.WriteLine(c.szomj); //hiba private miatt
            
            Console.WriteLine(c.Szomj); //tulajdonság
            c.kiir();

           
            
            
            

            



        }
    }
}
