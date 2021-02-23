using System;

namespace kivetelkezeles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kettővel szorzó v. 1.0");
            Console.WriteLine("Adjon meg egy egész páros számot!");
            try
            {   //kritikus kód
                var bevitel = Console.ReadLine();
                int szam = Convert.ToInt32(bevitel);

                if ((szam % 2) != 0)
                {
                    throw new Exception("A szám nem páros");
                }
                Console.WriteLine($"A szorzás eredménye: {szam * 2}");

            }
            catch(FormatException e)  // hiba - kívétel elkapása
            {
                Console.WriteLine("Konverziós hiba!!\n {0}", e.Message);
            }
            catch (Exception ex)  // minden kivétel elkapása
            {
                Console.WriteLine("HIBA történt");
                Console.WriteLine(ex.Message);
            }
            finally  // mindenképpen lefut
            {
                Console.WriteLine("Program vége. Nyomjon egy gombot a kilépéshez");
                Console.ReadKey();
            }

        }
    }
}
