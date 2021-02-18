using System;

namespace jármű
{
    class Program
    {
        class Jarmu
        {
            private string tipus;
            private int kerekekSzama;
            private string szin;

            public Jarmu()
            {
                tipus = "";
                kerekekSzama = 1;
                szin = "Szürke";
            }

            public Jarmu(string tipus, int kerek, string szin)
            {
                this.tipus = tipus;
                kerekekSzama = kerek;
                this.szin=szin;

            }

            public void kiir()
            {
                Console.WriteLine($"Kerekek szama: {this.kerekekSzama},Szine: *{szin}*, Tipus: *{tipus}* ");
            }

            public void atfest(string szin)
            {
                this.szin = szin;
            }


        }



        static void Main(string[] args)
        {
            Jarmu a = new Jarmu(); //példányosítás
            Jarmu b = new Jarmu("Női", 3, "Sárga");
            a.kiir();
            b.kiir();
            a.atfest("Piros");
            a.kiir();

            



        }
    }
}
