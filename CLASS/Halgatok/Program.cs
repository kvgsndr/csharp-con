using System;

namespace Hallgatok
{  


    class Program
    {

        class Hallgato
        {
            string azonosito;
            int evfolyam;
            int kreditszam;

            public Hallgato(string az, int ev, int kred)
            {
                azonosito = az;
                evfolyam = ev;
                kreditszam = kred;
            }

            public Hallgato(string azon)
            {
                azonosito = azon;
                evfolyam = 1;
                kreditszam = 0;

            }
            public void targyFelvesz(int pont)
            {
                kreditszam += pont;
            }

            public bool vizsgazik()
            {
                if (kreditszam > 0)
                {
                    evfolyam++;
                    kreditszam = 0;
                    return true;
                }
                else
                    return false;

            }


            public void toString()
            {
                Console.WriteLine($"Azonosító: {azonosito} Évfolyam: {evfolyam} Kreditek: {kreditszam}");
            }



        }
        static void Main(string[] args)
        {
            Hallgato hal1 = new Hallgato("Jani", 2, 10);
            Hallgato hal2 = new Hallgato("Kati");

            hal2.targyFelvesz(12);

            if (hal1.vizsgazik()) Console.WriteLine($"sikeres vizsga!");
            else Console.WriteLine("Megbukott!");

            if (hal2.vizsgazik()) Console.WriteLine($"sikeres vizsga!");
            else Console.WriteLine("Megbukott!");

            hal1.toString();  hal1.ToString();
            hal2.toString();  hal2.ToString();

            Console.ReadKey();

        }
    }
}
