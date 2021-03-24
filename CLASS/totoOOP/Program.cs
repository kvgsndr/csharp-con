using System;
using System.Collections.Generic;
using System.IO;


namespace totoOOP
{
    class Program
    {
        static public void fel(int n)
        { Console.Write($"Feladat {n}:"); }

        static void Main(string[] args)
        {
            List<Adatok> totoList = new List<Adatok>();
            StreamReader fbe = new StreamReader("toto.txt");
            fbe.ReadLine();
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(';');
                totoList.Add(new Adatok(Int32.Parse(elemek[0]), Int32.Parse(elemek[1]), Int32.Parse(elemek[2]), Int32.Parse(elemek[3]), Int32.Parse(elemek[4]), elemek[5]));
            }
            fbe.Close();

            fel(3);
            Console.WriteLine($"A fordulók száma : {totoList.Count}");
            int telital = 0;
            long fizetve = 0;
            foreach (var item in totoList)
            {
                telital += item.T13p1;
                fizetve += item.kifizetve();
            }
            fel(4);
            Console.WriteLine($"A telitalálatos szelvények száma: {telital} db.");

            Console.ReadKey();
        }
    }
}
