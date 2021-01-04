using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace hoingas
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string[] vnev = new string[300];
            double[] legn = new double[300];
            double[] legk = new double[300];
            int db, i,lnhipoz;
            double h1, h2;
            char htip;


            StreamReader olv = File.OpenText("homers.txt");
            db = 0;
            while (!olv.EndOfStream)
            {
                vnev[db] = olv.ReadLine();
                s = olv.ReadLine();
                htip = s[0];
                s = olv.ReadLine();
                h1 = Convert.ToDouble(s);
                s = olv.ReadLine();
                h2 = Convert.ToDouble(s);
                if (htip == 'F')
                {
                    h1 = (h1 - 32) * 5 / 9;
                    h2 = (h2 - 32) * 5 / 9;
                }
                if (h1 < h2)
                {
                    legn[db]=h2;
                    legk[db]=h1;
                }
                else
                {
                    legn[db]=h1;
                    legk[db] = h2;
                }
                db++;
            }
            olv.Close();
            lnhipoz = 0;//     1234567890123456789012345678901234567890123456789012345678901234567890
            Console.WriteLine("város:                    max:      min:  hõingás:");
            for (i = 0; i < db; i++)
            {
                if (legn[i] - legk[i] > legn[lnhipoz] - legk[lnhipoz])
                    lnhipoz = i;
                Console.WriteLine("{0,-20:S}{1,10:F1}{2,10:F1}{3,10:F1}",vnev[i],legn[i],legk[i],legn[i]-legk[i]);
            }
            Console.WriteLine("\nA legnagyobb hõingás: {0}", vnev[lnhipoz]);
            Console.ReadKey();
        }
    }
}
