using System;
using System.IO;

namespace duna
{
    class Program
    {
        static void Main(string[] args)
        {
            string fajl = "duna.txt";
            double[] vizszint = new double[100];
            int n = 0, n10felett=0, max=0 , min=0;
            double osszeg = 0.0;
            bool volt92 = false;
            try
            {
                StreamReader fbe = new StreamReader(fajl);
                while (!fbe.EndOfStream)
                {
                    vizszint[n] = double.Parse(fbe.ReadLine());
                    n++;
                }
                fbe.Close();

                
                
                
                

                StreamWriter fki = new StreamWriter("magas.txt");
                for (int i = 0; i < n; i++)
                {//1    10m felett
                    if (vizszint[i]>10) n10felett++;
                 //2     átlag   
                    osszeg += vizszint[i];
                 //3      max   min
                    if (vizszint[i] > vizszint[max]) max = i;

                    if(vizszint[i] < vizszint[min]) min = i;
                 //4     9.2m
                    if (vizszint[i] == 9.2) volt92 = true;
                 // file írása  
                    if (vizszint[i] > 15) fki.WriteLine(vizszint[i]);

                }
                fki.Close();

                Console.WriteLine($" {n10felett}-szor volt 10m feletti vízállás!");
                Console.WriteLine($" Az időszak vízállásának átlaga {osszeg/n}");
                Console.WriteLine($" A legnagyobb vízállás ={vizszint[max]}");
                Console.WriteLine($" A vizszint {min}. napon volt legalacsonabb");
                if (volt92)
                    Console.WriteLine($" Volt 9,2m vizszint!");
                else
                    Console.WriteLine($" NEM Volt 9,2m vizszint!");


            }
            catch (Exception )
            {
                Console.WriteLine("A {0} fájlt nem lehet megnyitni!!!!", fajl);
            
            }





        }
    }
}
