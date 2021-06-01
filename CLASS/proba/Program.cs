using System;


namespace proba
{

    class Sajat
    {

        //adatok
        string nev;
        int ev;
        //metódusok
        public Sajat(string n, int e)
        {
            nev = n;
            ev = e;
        }
        public void kiir()
        {
            Console.WriteLine($"{nev} {ev} éves");
        }

    }


    class Program
    {
        

        static void Main(string[] args)
        {
            Sajat elso = new Sajat("Kővágó", 53);
            Sajat masodik = new Sajat("Nagy", 23);
            
            
            elso.kiir(); 
            masodik.kiir();
            
            Console.ReadKey();
        }
    }
}
