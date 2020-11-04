using System;

namespace véletlenpáros
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int veletlen = 0;
            int szam;
            int paros = 0;
            string s = "";
            while (paros<10)
            {
                szam = rnd.Next();
                veletlen += 1;
                if (szam % 2 == 0)
                {
                    s += szam.ToString()+", ";
                    paros++;
                }
            }
            Console.WriteLine(s);



        }
    }
}
