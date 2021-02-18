using System;
using System.IO;
using System.Collections.Generic;


namespace fájl_feldolgozás
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sorok = new List<string>();
            StreamReader fbe = new StreamReader("10binf2.txt");
            while(!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();

                sorok.Add(sor);
                fbe.ReadLine();
                fbe.ReadLine();
                fbe.ReadLine();
                fbe.ReadLine();

            }
            fbe.Close();
            
            for(int i =0; i<sorok.Count;i++)
            {
                int poz = sorok[i].IndexOf(" (");
                string s=sorok[i].Remove(poz);
                var elemek=s.Split('\t');
                
                sorok[i] = elemek[1];
            }
            StreamWriter fki = new StreamWriter("A10binf2.txt");
            foreach (var item in sorok)
            {
                fki.WriteLine($"0;{item};0");
                Console.WriteLine($"0;{item};0");
            }
            fki.Close();






          
        }
    }
}
