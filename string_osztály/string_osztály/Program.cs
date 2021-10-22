using System;

namespace string_osztály
{   


    class Program
    {
        static void Main(string[] args)
        {
            String_osztaly string_Osztaly = new String_osztaly("Ebben a mondatban minden et lecserélünk !");
            Console.WriteLine(string_Osztaly.karakterCsere('e', '*'));
        }
    }
}
