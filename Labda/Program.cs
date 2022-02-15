using System;
using System.Drawing;
using System.Diagnostics;

namespace Labda
{
    class Program
    {
        static void Main(string[] args)
        {

            TLabda l = new TLabda(10,10,10);
            l.show();
            l.irany(10, 10);
            for (int i = 0; i < 10; i++)
            {
                l.mozgat();
            }
           
           
            
           
            
           
            

            Console.ReadKey();
        }
                
    }
}
