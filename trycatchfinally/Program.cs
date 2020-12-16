using System;

namespace trycatchfinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j=0;
            try
            {
                i = i / j;
                Console.WriteLine($"Az osztás eredménye:{i}");
                Console.WriteLine("Az osztás eredménye:{0}", i);
                // azon utasítások kerülnek ide, melyek
                // hibát okozhatnak, kivételkezelést igényelnek
            }
            catch ( Exception )
            {
                Console.WriteLine(" Hiba történt!!!");
                // Adott kivételtípus esetén a vezérlés ide kerül
                // ha nemcsak a hiba típusa az érdekes, hanem az
                // is,hogy például egy indexhiba esetén milyen
                // index okozott ‘galibát’, akkor megadhatjuk a
                // típus nevét is, amin keresztül a hibát okozó
                // értéket is ismerhetjük. A név megadása opcionális.
            }
            finally
            {
                Console.WriteLine("Végül lefut a finally blokk is!!");
                // ide jön az a kód, ami mindenképpen végrehajtódik
            }

            i = Int32.MaxValue;
            checked
            {
                try 
                { 
                    i++; //kivétek keletkezik
                }
               catch (OverflowException)
                { 
                    Console.WriteLine(" OverfloeExeption keletkezett!!"); 
                }
                 
            }

            j = Int32.MaxValue;
            unchecked
            {
                j++;            
            }

            Console.WriteLine(i);
            Console.WriteLine(j);



            Console.ReadKey();

        }
    }
}
