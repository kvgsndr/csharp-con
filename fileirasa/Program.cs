using System;
using System.IO;

namespace fileirasa
{
    class Program
    {
        static void Main(string[] args)
        {  /*//olvasás
            string fnev;
            Console.Write("Allomany neve utvonallal egyutt:");
            fnev = Console.ReadLine();
            StreamReader f = File.OpenText(@fnev);
            while (f.Peek() != -1)
            {
                Console.WriteLine(f.ReadLine());
                f.ReadLine();
            }
            f.Close();
        */

            //írás
            StreamWriter kiir = new StreamWriter("szoveg.txt");
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
                kiir.WriteLine("{0} ", rnd.Next(100));

            kiir.Close();






            Console.ReadKey();
        }
    }
}
