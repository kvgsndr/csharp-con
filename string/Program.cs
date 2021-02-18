using System;

namespace string_pelda
{
    class Program
{
    static void Main(string[] args)
    {
        //string - szöveg idézőjelben
        string szoveg = "Hello World!";

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.WriteLine(szoveg[i]);
            }
            Console.WriteLine();
        Console.WriteLine(szoveg);
        Console.WriteLine( $"{ szoveg.Length} a hossza a következő szövegnek \"{szoveg}\"  ");
            if (szoveg.Contains("ello")) Console.WriteLine("Igen \"ello\" benne van a szövegben");
            else Console.WriteLine("Nem \"ello\"  nincs benne van a szövegben");
            bool a=szoveg.EndsWith('!');
            bool a1 = szoveg.StartsWith("Wo");
            bool b = szoveg.EndsWith("world!");
            //012345678901
            //Hello World!
            int c = szoveg.IndexOf("Wo"); // c==6
            int d = szoveg.IndexOf('o'); // d==4
            Console.WriteLine(d);
            int e = szoveg.LastIndexOf('o'); //e==7
            Console.WriteLine(e);

            Console.WriteLine($"*{szoveg.PadLeft(20)}*");
            Console.WriteLine($"*{szoveg.PadRight(20)}*");

            string s = szoveg.Remove(3);
            Console.WriteLine(s);
            s = szoveg.Remove(3, 5);
            Console.WriteLine(s);

            s = szoveg.Replace('o', 'e');
            Console.WriteLine(s);
            s = szoveg.Replace("Hel", "Bol");
            Console.WriteLine(s);

            string[] ts = szoveg.Split('o');

            Console.WriteLine(ts[0]);
            Console.WriteLine(ts[1]);
            Console.WriteLine(ts[2]);

            for (int i = 0; i < ts.Length; i++)
            {
                Console.WriteLine(ts[i]);
            }

            Console.WriteLine(  szoveg.ToLower());

            Console.WriteLine(szoveg.ToUpper());

            s = szoveg.Substring(5, 3);
            Console.WriteLine(s);



















        }
    }
}
