using System;

namespace macska
{

    class Program
    {
        static void Main(string[] args)
        {
            Macska cirmi = new Macska("Cirmi", 2.5, false);
            Macska mici = new Macska("Mici", 2.0);
            cirmi.toString();
            mici.toString();

            string uzenet1 = cirmi.eszik(0.2) ? "Sikeres etetés" : "Sikertelen etetés";
            string uzenet2 = mici.eszik(0.2) ? "Sikeres etetés" : "Sikertelen etetés";
            Console.WriteLine($" {uzenet1}  {uzenet2}");
            cirmi.toString();
            mici.toString();

            cirmi.futkos();
            cirmi.futkos();
            mici.futkos();

            cirmi.toString();
            mici.toString();

            


        }
    }
}
