using System;

namespace allat_osztály
{   class Allat
    {
        private string nev;
        protected int szomj;
        protected int ehseg;

        public string Nev { get => nev; set => nev = value; }

        public Allat(string nev, int szomj, int ehseg)//konstruktor
        {
            this.Nev = nev;
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
        public virtual void kiir()
        {
          Console.WriteLine("Név: {0}, Szomj: {1}, Éhség: {2}", Nev, szomj, ehseg);
        }

    }

     class Emlos : Allat
     {
        int labakSzama;

        public override void kiir()
        {
            //this.kiir();
            Console.WriteLine("Név: {0}, Szomj: {1}, Éhség: {2}", Nev, szomj, ehseg);
            Console.WriteLine($"Lábak szama: {labakSzama}");
        }
        public Emlos(string nev, int szomj, int ehseg, int labakSzama): base(nev, szomj, ehseg)
        {
            this.labakSzama = labakSzama;
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
			//a.nev="Buksi"; NEM MŰKÖDIK
			a.Nev ="Buksi";
            a.jatszik();
            a.jatszik();
            a.kiir();
            b.kiir();
            b.iszik();
            b.eszik();
            b.kiir();

            Emlos tehen = new Emlos("Riska", 50, 20, 4);
            tehen.kiir();

            

            Console.ReadKey();
        }
    }
}
