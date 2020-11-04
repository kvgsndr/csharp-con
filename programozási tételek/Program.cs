using System;
using System.Linq;

namespace programozási_tételek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1,3,6,7,9,4,5,8,2, -5, -8,3,3};

            /* összegzés tétele 1. verzió*/
            long osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg = osszeg + tomb[i];
            }
            Console.WriteLine("Tömb elemeinek összege : {0}", osszeg);
                       
            /*Összegzés tétele 2. verzió foreach ciklussal*/
            osszeg = 0;
            foreach (var item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine("Tömb elemeinek összege : {0}", osszeg);
           
            /*Keresés tétele 1. verzió */
            Console.Write("Melyik számot keresed? ");
            int keres = Convert.ToInt32(Console.ReadLine());// a keresett elem
            bool van = false;   // keresés eredménye
            for (int i = 0; i < tomb.Length; i++)  //foreach(var item in tomb)
                if (keres == tomb[i])              //   if(kertes == item)
                {                                  //   {   
                    van = true;                    //      van= true;
                    break;                         //      break;
                }                                  //    }
            Console.WriteLine("A keresett szám {0} benne van a tömbben!  {1} ", keres, van);
            Console.ReadKey();

            /* keresés tétele 2.verzió       Ha nincs benne az elem index=-1  ha benne van akkort index >=0  */
            Console.Write("Melyik számot keresed? ");
            keres = Convert.ToInt32(Console.ReadLine());// a keresett elem
            int index = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (keres == tomb[i])
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                Console.WriteLine("Nincs ilyen elem!!!");
            else
                Console.WriteLine("A keresett elem a {0}. helyen szerepel a tömbben!", index);

            /*keresés */
            van=tomb.Contains(keres);
            Console.WriteLine("A keresett szám {0} benne van a tömbben!  {1} ", keres, van);



            /*   Megszámlálás tétele  */
            Console.Write("Melyik számot keresed? ");
            keres = Convert.ToInt32(Console.ReadLine());// a keresett elem
            int keresettElemekSzama = 0;
            foreach (var item in tomb)
            {
                if (item == keres) keresettElemekSzama++;
                
            }
            Console.WriteLine("A keresett elemből {0} található a tömbben!", keresettElemekSzama);



        }
    }
}
