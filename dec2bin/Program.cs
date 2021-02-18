using System;

namespace dec2bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.Write("Irj be egy szamot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            int sz = szam;
            string bin = " ";
            
            do
            {
                bin=bin.Insert(0, Convert.ToString(sz % 2));
                sz /= 2;
            } while (sz > 0);

            Console.Write($"{szam}={bin}");





           

            Console.WriteLine(" binaris szamkent ");

            Console.WriteLine(Convert.ToString(szam, 2) );  
        }
    }
}







/*
14 /2 0
7  /2 1
3  /2 1
1  /2 1
0
*/