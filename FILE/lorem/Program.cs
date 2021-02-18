using System;
using System.IO;

namespace lorem
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName = "lorem.txt";
            char[] elvalasztok = { '.', '?', '!' };
            try 
            {
                StreamReader fbe = new StreamReader(fileName);
                int n = 1;
                while(!fbe.EndOfStream)
                {
                    string sor = fbe.ReadLine();
                    var mondatok = sor.Split(elvalasztok,StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine("A {0}. sor mondatainak szavainak  száma:",n);
                    foreach (var item in mondatok)
                    {
                        string s= item.Trim();
                        var szavak = s.Split(' ');
                        Console.Write($"{szavak.Length} ");
                       
                       
                    }
                    n++;

                    Console.WriteLine();
                }


               
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Hiba történt!!!\n {0}", e.Message);
                Console.ReadKey();
                return;
            }

        }
    }
}
