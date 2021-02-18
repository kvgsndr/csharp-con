using System;
using System.IO;

namespace hőmérséklet_átlagok
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileNev = "homersekletstat.txt";
            StreamWriter fki = new StreamWriter(fileNev);
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)// napok
            {
                string sor = "";
                for (int j = 0; j < 24; j++)//órák
                {
                    //fki.Write($"{rnd.Next(20,35)};")
                    sor += rnd.Next(20, 35).ToString() + ";"   ;
                }
                //fki.WriteLine();
                fki.WriteLine(sor);
            }
            fki.Close();

            StreamReader fbe = new StreamReader(fileNev);

            int[,] homersekletek = new int[31, 24];
            int n = 0;
            while(!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                
                var elemek = sor.Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < elemek.Length; j++)
                {
                    homersekletek[n, j] = int.Parse(elemek[j]);
                }
                n++;
            }
            fbe.Close();


            double[] napiAtlag = new double[n];
            for (int i = 0; i < n; i++) //sork
            {
                int osszeg = 0;
                for (int j = 0; j < 24; j++)// oszlopok
                {
                    osszeg += homersekletek[i,j];
                }
                napiAtlag[i] = (double)osszeg / 24;
                
            }

            double haviAtlag1;
            double osszegf = 0;
            for (int i = 0; i < napiAtlag.Length; i++)
            {
                osszegf += napiAtlag[i];
            }
            haviAtlag1 = osszegf / n;

            double haviAtlag2;
            int osszeg2 = 0;
            
            for (int i = 0; i < n; i++) //sorok
                for (int j = 0; j < 24; j++)//oszlopok
                    osszeg2 += homersekletek[i, j];
            
            haviAtlag2 = (double)osszeg2 / (24 * n);






            fki = new StreamWriter(fileNev);

            for (int i = 0; i < n; i++) //sorok
            {
                for (int j = 0; j < 24; j++)  // napi mérések
                {
                    fki.Write($"{homersekletek[i,j],3}");
                }
                fki.WriteLine($"  Átlag= {napiAtlag[i]:F2}");
            }
            fki.Close();




            fbe = new StreamReader(fileNev);
            double atlagosszeg = 0.0;
            while (!fbe.EndOfStream)
            {
                string sor = fbe.ReadLine();
                var elemek = sor.Split(" ");
                atlagosszeg += double.Parse(elemek[elemek.Length - 1]);

            }
            fbe.Close();
            double haviAtlag3 = atlagosszeg / n;








            fki = new StreamWriter(fileNev, true);

            fki.WriteLine($"Havi Átlag módszer 1  = {haviAtlag1}");
            fki.WriteLine($"Havi Átlag módszer 2  = {haviAtlag2}");
            fki.WriteLine($"Havi Átlag módszer 3  = {haviAtlag3}");

            fki.Close();


        }
    }
}
