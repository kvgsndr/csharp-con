/*
    Kérje be egy másodfokú egyenlet együthatóit, számolja ki a [-6;6] intervallumban egész x
    értékhez tartozó fügvényértékeket és írja ki a képernyőre egy sorba az x értékekeit alá pedig     az y értékeket.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_feladat___másodfoku_fuggvény
{
    class Program
    {   static double[] bekerEgyuthatok()
        { 
            double[] tomb = new double[3];
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.Write("{0}. együtható: ", i + 1);
                    tomb[i] = Convert.ToDouble(Console.ReadLine());
                } while (!ellenorzes(tomb[i]));
            }
            return tomb;
        }

        static bool ellenorzes(double szam)
        {
            if (szam < -5.0 || szam > 5.0)
                return false;
            return true;
        }

        static double masodfoku(double[] egyuthatok, int x)
        {
            return egyuthatok[0] * x * x + egyuthatok[1] * x + egyuthatok[2];
        }

        static void Main(string[] args)
        {
             double[] egyuthatok=new double[3];
            egyuthatok = bekerEgyuthatok();
            Console.Write("x : ");
            for (int x = -6; x <= 6; x++)
                Console.Write("{0,5}", x);
            Console.Write("\ny : ");
            for (int x = -6; x <= 6; x++)
                Console.Write("{0,5}", masodfoku(egyuthatok, x));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
