using System;
using System.IO;

namespace adatok_olvasása_vágása_kiírása___file
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fbe = new StreamReader("patika.csv");
            StreamWriter fki = new StreamWriter("Kimenet.txt");
            long osszeg = 0;
            fki.WriteLine($"{"Megnevezés",25}  {"Darab"}");
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                string[] elemek = sor.Split(';', StringSplitOptions.RemoveEmptyEntries);
                fki.WriteLine($"{elemek[0],25}  {elemek[4]}");
                Console.WriteLine($"{elemek[0],25}  {elemek[4]}");
                osszeg += int.Parse(elemek[3]) * int.Parse(elemek[4]);
            }
            fbe.Close();

            fki.WriteLine("------------------------");
            fki.WriteLine($" Összeg = {osszeg} Ft");
            fki.Close();


            Console.ReadKey();
        }
    }
}
