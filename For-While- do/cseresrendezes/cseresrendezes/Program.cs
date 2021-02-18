using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cseresrendezes
{
    class Program
    {
        static void Main()
        {
            int[] t = { 22, 5, 4, 33, 9, 3, 7, 15, 20 };
            int n = t.Length;

            //Kiíratás rendezés előtt
            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(t[i] + " ");
            } 
            Console.WriteLine();

            //Cserés rendezés
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (t[i] > t[j])
                    {
                        int s = t[j];
                        t[j] = t[i];
                        t[i] = s;
                    }

            //Kiíratás rendezés után
            Console.WriteLine("A rendezett tömb elemei: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(t[i] + " ");
            }
                
            Console.ReadKey();
        }
    }
}
