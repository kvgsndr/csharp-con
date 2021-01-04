using System;

namespace ciklusok_while
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Határozzuk meg n! értékét! 5!=1*2*3*4*5=120
            Console.Write("Írj be egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            long fakt = 1;
            for (int index = 1; index <= szam; index++)
            {
                fakt *= index;
            }

            Console.WriteLine($"{szam}! = {fakt}");
            
            //Határozzuk meg egy természetes számnak egy természetes számmal való
            //osztásakor keletkező maradékot úgy, hogy a szorzás és osztás műveleteit
            //nem használjuk!     7%3=1
            Console.Write("Írj be egy egész számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("Írj be egy egész számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            Console.Write($"{szam1} % {szam2}=");

            for ( ; szam1>=szam2;  )
            {
                szam1 -= szam2;

            }
            Console.WriteLine(szam1);

            //Határozzuk meg két természetes szám szorzatát úgy, hogy nem használjuk a
            //szorzás műveletét!
            Console.Write("Írj be egy egész számot: ");
             szam1 = int.Parse(Console.ReadLine());
            Console.Write("Írj be egy egész számot: ");
             szam2 = int.Parse(Console.ReadLine());
            long x = 0;
            for (int ii = 0; ii < szam2; ii++)
            {
                x += szam1;
            }

            Console.WriteLine($"{szam1}*{szam2}={x}");

            
            //Határozzuk meg egy valós szám pozitív egész kitevőjű hatványát úgy, hogy
            //nem használjuk a hatványozás műveletét!


            Console.Write("Írj be egy az alapot: ");
             szam1 = int.Parse(Console.ReadLine());
            Console.Write("Írj be a kitevőt: ");
             szam2 = int.Parse(Console.ReadLine());

            x = 1;
            for (int ii = 0; ii < szam2; ii++)
            {
                x *= szam1;
            }

            Console.WriteLine($"{szam1}**{szam2}={x}");


            //Határozzuk meg n! értékét! 5!=1*2*3*4*5=120
            Console.Write("Írj be egy egész számot: ");
            int N = int.Parse(Console.ReadLine());
            long faktorialis = 1;
            
            int i = 2;
             while (i <= N)
                faktorialis *= i++;       // {faktorialis+=i;i++; }
            Console.WriteLine($"{N}!= {faktorialis}");

            
                       //Határozzuk meg egy természetes számnak egy természetes számmal való
                       //osztásakor keletkező maradékot úgy, hogy a szorzás és osztás műveleteit
                       //nem használjuk!

                       Console.Write("Írj be egy egész számot: ");
                       int n = int.Parse(Console.ReadLine());
                       Console.Write("Írj be egy egész osztót: ");
                       int oszto = int.Parse(Console.ReadLine());

                       int maradek = n;

                       while (maradek >= oszto)
                           maradek -= oszto;

                       Console.WriteLine($"{n} % {oszto} = {maradek}");

         


                       //Határozzuk meg két természetes szám szorzatát úgy, hogy nem használjuk a
                       //szorzás műveletét!
                       int a, b;
                       Console.WriteLine("1.szam: ");
                       a = int.Parse(Console.ReadLine());
                       Console.WriteLine("2.szam: ");
                       b = int.Parse(Console.ReadLine());

                       int nagyobb = Math.Max(a, b);
                       int kiss = Math.Min(a, b);
                       long szorzat = 0;

                       
                       while (kiss-- >0)    szorzat += nagyobb;   

                       Console.WriteLine($"{a}*{b}= {szorzat}");
           


                       //Határozzuk meg egy valós szám pozitív egész kitevőjű hatványát úgy, hogy
                       //nem használjuk a hatványozás műveletét!

                       Console.WriteLine("Alap: ");
                       int alap = int.Parse(Console.ReadLine());
                       Console.WriteLine("Kitevő: ");
                       int kitevo = int.Parse(Console.ReadLine());
                       long ertek = 1;
                        i = 0;
                        while (i++ < kitevo) ertek *= alap;

                        Console.WriteLine($"{alap}**{kitevo}= {ertek}");





            Console.ReadKey();
        }
    }
}
