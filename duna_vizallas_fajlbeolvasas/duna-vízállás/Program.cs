using System;
using System.IO;
namespace duna_vízállás
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vizszint = new double[100];

            StreamReader fb = new StreamReader("duna.txt");
            int n = 0;
            while (!fb.EndOfStream)
            {
                vizszint[n] = double.Parse(fb.ReadLine());
                n++;
            }
            fb.Close();
            //A
            int n10felett = 0;
            for (int i = 0; i < n; i++)
                    if (vizszint[i] > 10) n10felett++;
                       
            Console.WriteLine($"A feladat: a vizszint {n10felett} szer volt 10m felett!");
            //Console.WriteLine("A feladat: a vizszint {0} szer volt 10m felett!", n10felett);

            //B
            double osszeg = 0;
            for (int i = 0; i < n; i++)
            {
                osszeg += vizszint[i];
            }
            double atlag = osszeg / n;
            Console.WriteLine($"Az időszak átlagos vízállása {atlag:0.00}");

            //C

            int min = 0;
            for (int i = 0; i <n ; i++)
            {
                if (vizszint[i] < vizszint[min]) min = i;

            }

            Console.WriteLine($" A legkisebb vízállás a {min+1}.napon volt");
            //D
            bool van = false;
            for (int i = 0; i < n; i++)
            {
                if (vizszint[i]==9.2)
                {
                    van = true;
                    break;
                }
            }

            if (van)
                Console.WriteLine("Volt 9,2m vízállás!");
            else
                Console.WriteLine("Nem volt 9,2m vízállás!");

            //E

            StreamWriter fk = new StreamWriter("magas.txt");

            for (int i = 0; i < n; i++)
                if (vizszint[i] > 15) fk.WriteLine(vizszint[i]);

            fk.Close();
            
            

        }
    }
}
