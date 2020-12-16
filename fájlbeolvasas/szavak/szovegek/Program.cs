using System;
using System.IO;
namespace szovegek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = new string[600];
            int n = 0;
            try
            {
                StreamReader fbe = new StreamReader("szava2k.txt");
                
                while (!fbe.EndOfStream)
                { szavak[n] = fbe.ReadLine();
                    n++;
                }
                      
                                
                fbe.Close();

            }
            catch(Exception)
            {
                Console.WriteLine("A fájlt nem lehet megnyitni!!");
                Console.ReadKey();

                return;
            }

            //1.
            Console.WriteLine($"A listán {n} szó szerepel!");

            //2
            int maxhossz = 0;
            for (int i = 0; i < n; i++)
            {
                if (szavak[i].Length > szavak[maxhossz].Length) maxhossz = i;
            }

            Console.WriteLine($"A leghosszabb szó: {szavak[maxhossz]}");
            //Console.WriteLine("A leghosszabb szó: {0}", szavak[maxhossz]);

            //3
            StreamWriter fki = new StreamWriter("fbetus.txt");
            for (int i = 0; i < n; i++)
            {
                if (szavak[i].Length == 4 && szavak[i][0] == 'f')
                    fki.Write(szavak[i] + " ");
            }
            fki.Close();
            //4
            int otbetus = 0;
            for (int i = 0; i < n; i++)
            {
                if (szavak[i].Length == 5) otbetus++;
            }
            Console.WriteLine($"A szavak közül {otbetus} ötbetüs van a fájlban!");

            //5
            bool szerepel = false;
            for (int i = 0; i < n; i++)
            {
                if (szavak[i] == "szeretem") szerepel = true;
                
            }
            if (szerepel)
                Console.WriteLine("A \"szeretem\" szó szerepel a listán");
            else
                Console.WriteLine("A \"szeretem\" szó NEM szerepel a listán");

            //6
            for (int i = 0; i < n; i++)
            {
                if(szavak[i].Contains("alt"))
                    Console.WriteLine(szavak[i]);
            }







        }
    }
}
