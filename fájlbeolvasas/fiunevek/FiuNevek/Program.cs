using System;
using System.IO;
/*
 A fiunevek.txt állomány néhány (maximum 300 db) A betűvel kezdődő fiúnevet tartalmaz.

Írj programot FiuNevek néven, amely az állomány adatainak beolvasásával és feldolgozásával a következő kérdésekre válaszol:

Pontosan hány db anyakönyvezhető fiúnév szerepel a listában?
Listázd a képernyőre az 5 betűs fiúneveket!
Választható-e fiúnévként az Amen név/szó?
Hány db legalább 5 betűs név szerepel, amely „a” betűre is végződik?
Melyik a leghosszabb név a listában? (Ha több van, mindegyiket „mutasd meg”.)
Írd ki rovid.txt fájlba a legrövidebb nevet!
**Írd ki a csaka.txt fájlba azokat az anyakönyvezhető neveket, amely csak 'a' magánhangzót tartalmaznak!
 
 */
namespace FiuNevek
{
    class Program
    {
        static void Main(string[] args)
        {   
            string fileneve = "fiunevek.txt";
            StreamReader fbe;
            bool amenvan = false;
            int maxhossz = 0;
            int minHosszIndex = 0;
            int otbetus_a = 0;
            string[] nevek = new string[300];

            try
            {
                 fbe = new StreamReader(fileneve);
            }
            catch(IOException e)
            {
                Console.WriteLine($"A {fileneve} nem nyitható meg!!\n {e.Message} ");
                return;
            }

            int n = 0;
            while(!fbe.EndOfStream)
            {
                nevek[n++] = fbe.ReadLine();
            }
            fbe.Close();

            Console.WriteLine($"Az anyakönyvezhető fiúnevek száma: {n}");
           
            for (int i = 0; i < n; i++)
            {   int hossz = nevek[i].Length;
                
                if (hossz == 5) Console.WriteLine(nevek[i]);// kiírja az 5 betüs neveket
                
                
                if (nevek[i].Equals("Amen")) amenvan = true; //Keresi az "Amen" nevet

                if (hossz >= 5 && nevek[i][hossz - 1] == 'a') otbetus_a++;
                
                
                if (hossz > maxhossz) maxhossz = hossz;   // leghoszabb 
                
                
                
                if (nevek[minHosszIndex].Length > hossz) minHosszIndex = i;


            }

            Console.WriteLine();

            if(amenvan)
                Console.WriteLine("Igen, válsztható az Amen név! ");
            else
                Console.WriteLine("Nem válsztható az Amen név! ");

            Console.WriteLine($"Legalább 5 betüs \'a\' val végződő nevek száma: {otbetus_a}");

            for (int i = 0; i < n; i++)
            {
                if (nevek[i].Length == maxhossz) Console.WriteLine(nevek[i]);
            }
            Console.WriteLine();
            StreamWriter fki = new StreamWriter("rovid.txt");
            fki.WriteLine(nevek[minHosszIndex]);
            fki.Close();









            Console.ReadKey();
        }
    }
}
