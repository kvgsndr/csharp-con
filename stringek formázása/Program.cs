using System;

namespace stringek_formázása
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.234567;
            Console.WriteLine("{0:x},{1,5}", 1952,5);
            Console.WriteLine("{0},{1,10}", 1952, 5.58);
            Console.WriteLine("{0},{1,-10}A", 1952, 5.58);
            Console.WriteLine("{0},{1,10:0.0000}A", 1952, 5.58);
            Console.WriteLine("{0},{1,-10:0.0000}A", 1952, 5.58);
            string s = String.Format("{0:x},{1,5}", 1952, 5);
            
            Console.WriteLine(s.PadLeft(40));
            
           

        }
    }
}
