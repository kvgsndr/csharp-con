using System;
using System.IO;
using System.Collections.Generic;

namespace footgolf12a
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tadat> adatok = new List<Tadat>();
            try
            {
                StreamReader fbe = new StreamReader("fob2016.txt");
                while (!fbe.EndOfStream)
                {
                    adatok.Add(new Tadat(fbe.ReadLine()));
                }
                fbe.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("HiBA!!!\n {0}", e.Message); ;
                
            }
            //3
            Console.WriteLine($"3.feladat: Versenyzők száma: {adatok.Count}");

            //4
            int nok = 0;
            foreach (var item in adatok)
            {
                if (item.Kateg == "Noi") nok++;
            }
            Console.WriteLine($"4.feladat: A női versenyzők saránya: {((double)nok / adatok.Count)*100:F2} %");

            //5

            for (int i = 0; i < adatok.Count; i++)
            {

            }

            
            
            Console.ReadKey();
        }
    }
}
