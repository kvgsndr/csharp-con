using System;
using System.IO;

namespace szövegfájlbairvégjelig
{
    class Program
    {
        static void Main(string[] args)
        {
            string sor;
            if (File.Exists("bevitel.txt")) Console.WriteLine("Létezik a bevitel.txt");
            FileStream fs = new FileStream("bevitel.txt", FileMode.Append);
            StreamWriter ki = new StreamWriter(fs);

            


            Console.WriteLine("Írj be szöveget VÉGE végjelig:");
            sor = Console.ReadLine();

            while (sor != "VÉGE")
            {
                ki.WriteLine(sor);
                sor= Console.ReadLine();
            }
            ki.Close();
            fs.Close();
            Console.WriteLine("VÉGE as bevitelnek");

            fs = new FileStream("bevitel.txt", FileMode.Open );

            StreamReader be = new StreamReader(fs);

            string s = be.ReadToEnd();
            Console.WriteLine("Bevitel.txt fájl tartalma:");
            Console.WriteLine(s);





            Console.ReadKey();

        }
    }
}
