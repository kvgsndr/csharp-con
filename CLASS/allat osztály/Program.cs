using System;

namespace allat_osztály
{   class Allat
    {
        string nev;
        int szomj;
        int ehseg;

        public Allat(string nev, int szomj, int ehseg)//konstruktor
        {
            this.nev = nev;
            this.szomj = szomj;
            this.ehseg = ehseg;
        }
        public void iszik()
        {
            szomj--;
        }
        public void eszik()
        {
            ehseg--;
        }
        public void jatszik()
        {
            szomj += 5;
            ehseg += 5;
        }
        public void kiir()
        {
            Console.WriteLine("Név: {0}, Szomj: {1}, Éhség: {2}", nev, szomj,ehseg) ;
        }

    }

     class Emlos : Allat
     {
        int labakSzama;

        void kiirelos()
        {
                this.kiir();
                Console.WriteLine($"Lábak szama: {labakSzama}");
        }
        public Emlos()
        { 
        
        }
     }


    class Program
    {
        static void Main(string[] args)
        {
            Allat a = new Allat("Bodri", 50, 50);
            Allat b = new Allat("Cirmi", 30, 20);
            a.kiir();
            a.iszik();
            a.jatszik();
            a.jatszik();
            a.kiir();
            b.kiir();
            b.iszik();
            b.eszik();
            b.kiir();


            Console.ReadKey();
        }
    }
}
