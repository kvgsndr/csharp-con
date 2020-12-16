using System;
using System.IO;

namespace faálkezelés_kivétel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Írd be a file nevét: ");
                string fileneve = Console.ReadLine();
                StreamReader be = new StreamReader(fileneve);
                string s = be.ReadToEnd();
                Console.WriteLine(s);
                be.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("A fájl nem létezik, nem lehet megnyitni!");
            }
            

            Console.ReadKey();
        }
    }
}
