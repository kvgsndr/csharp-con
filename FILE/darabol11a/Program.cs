using System;
using System.IO;

namespace darabol11a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ötöslottó számok ellenőrzése");
            try
            {
                int[] sajatszamok = { 1, 12, 54, 55, 67 };
                int[] szamok = new int[5];
                StreamReader fbe = new StreamReader("otos.csv");
                StreamWriter fki = new StreamWriter("talalatok.txt");
                while( !fbe.EndOfStream)
                {
                    string sor = fbe.ReadLine();
                    var elemek = sor.Split(';');
                    for (int i = 0, j=11; i < 5; i++,j++)
                    {
                        szamok[i] = int.Parse(elemek[j]);
                    }
                    //összehasonlítás
                    int talalat = 0;
                    foreach (var item in sajatszamok)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (item == szamok[i]) talalat++;
                        }
                    }
                    Console.WriteLine($"{talalat}");
                    fki.WriteLine($"{talalat}");


                    

                }


                fki.Close();
                fbe.Close();


            }
            catch(Exception e)
            {
                Console.WriteLine($"Hiba történt!!! \n {e.Message}");
                Console.ReadKey();
                return;

            }


        }
    }
}
