using halmaz_osztaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmaz_osztaly
{

    class THalmaz
    {
        List<int> lista = new List<int>();

        public List<int> Lista { get => lista; set => lista = value; }
        public THalmaz()
        {


        }
        public bool add(int szam)
        {
            if (!lista.Contains(szam))
            {
                lista.Add(szam);
                return true;

            }
            else
            {
                return false;
            }

        }
        public void kiurit()
        {
            lista.Clear();

        }
        public int szama()
        {
            return lista.Count;

        }
        public string vane(int szam)
        {
            if (lista.Contains(szam))
            {
                return "Van benne";
            }
            else
            {
                return "Nincs benne";
            }
        }

        public List<int> unio(THalmaz szamok)
        {
            var eredmeny = lista.Union(szamok.Helper());
            return eredmeny.ToList();


        }
        public void toString()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{lista[i]}, ");
            }
        }
        public List<int> Helper()
        {
            return lista;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        THalmaz halm1 = new THalmaz();

        THalmaz halm2 = new THalmaz();

        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            halm1.add(rnd.Next(1, 101));
        }
        for (int i = 0; i < 4; i++)
        {
            halm2.add(rnd.Next(1, 101));
        }

        halm1.toString();
        Console.WriteLine("");

        halm2.toString();
        Console.WriteLine("");

        Console.Write("Két halmaz únioja:");
        for (int i = 0; i < halm1.unio(halm2).Count; i++)
        {
            Console.Write($"{halm1.unio(halm2)[i] }, ");
        }
        Console.ReadKey();
    }
}
