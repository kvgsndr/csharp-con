using System;
using System.IO;

namespace streamreader1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader filebe = new StreamReader("filebe.txt");
            string egész = filebe.ReadToEnd();
            Console.WriteLine(egész);
            Console.WriteLine("ReadToEnd");
            filebe.Close();

           


            Console.ReadKey();
        }
    }
}
