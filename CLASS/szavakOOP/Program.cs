using System;
using System.IO;
using System.Collections.Generic;

namespace szavakOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szo> lista = new List<Szo>();
            StreamReader fbe = new StreamReader("szavak.txt");
            while(!fbe.EndOfStream)
            {
                lista.Add(new Szo(fbe.ReadLine()));
            }
            fbe.Close();
            Console.WriteLine($"A listán {lista.Count} szó szerepel!");
            int leghosszabbHossza = 0;
            foreach (var szo in lista)
            {
                if (leghosszabbHossza < szo.hossz()) leghosszabbHossza = szo.hossz();
            }
            Console.WriteLine("A leghosszabb szavak:");
            foreach (var szo in lista)
            {
                if (leghosszabbHossza == szo.hossz())
                {
                    Console.WriteLine(szo.Adat);
                    //break;
                }
            }
            StreamWriter fki = new StreamWriter("fbetus.txt");
            int otbetusDb = 0;
            bool vanszeretem = false;
            foreach (var sz in lista)
            {   
                if (sz.fbetus4()) fki.Write($"{sz.Adat} ");
                if (sz.Adat.Length == 5) otbetusDb++;
                if (sz.Adat.Equals("szeretem")) vanszeretem = true;
            }
            fki.Close();
            Console.WriteLine($"A szavak.txt fájlban {otbetusDb} ötbetüs szó szerepel.");
            string s = vanszeretem ? "szerepel" : "nem szerepel";
            Console.WriteLine($"A \"szeretem\" szo {s} a listaban.");
            for(int i=0; i< lista.Count;i++)
            {
                if (lista[i].alt()) Console.WriteLine(lista[i].Adat);
            }







            Console.ReadKey();  
        }
    }
}
