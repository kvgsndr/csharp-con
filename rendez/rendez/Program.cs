using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rendez
{
    class Program
    {
        static void Kiirat(string duma,int[] s, int db,bool kell)
        {
            if (kell)
            {
                Console.WriteLine(duma);
                for (int i = 0; i < db; i++)
                {
                    Console.Write(s[i]);
                    Console.Write(", ");
                }
                Console.WriteLine("VÉGE");
            }
        }

        static void Masol(int[] s, int[]st,int db)
        {
            for (int i = 0; i < db; i++)
            {
                st[i] = s[i];
            }
        }

        static long[,] e = new long[5, 3];//bub,javbub,javbub++,mink,quicksort;ido,csere,vizsg
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string t;
            int db;
            bool kikell;
            string[] dt = { "buborék    ", "jav.buborék", "buborék++  ", "minkiv     ", "quicksort  " };
            do
            {
                Console.WriteLine("RENDEZÉS");
                Console.Write("A sokaság elemszáma:");
                t = Console.ReadLine();
                db = Convert.ToInt32(t);
                Console.Write("Kiírjam őket (i), más nem?");
                t = Console.ReadLine();
                kikell = t == "i";
                Random r = new Random();
                int[] s = new int[db];
                int[] st = new int[db];
                for (int i = 0; i < db; i++)
                {
                    s[i] = r.Next(1, 10001);
                }
                Kiirat("Az alapsorozat:",s, db,kikell);
                Masol (s,st,db);
                DateTime d = DateTime.Now;
                DateTime d2 = DateTime.Now;
                //buborék
				e[0, 1] = 0;
				e[0, 2] = 0;
				int cst;
				for (int i = 0; i < db; i++)
				{
					 for (int j = 1; j < db; j++)
					 {
						 e[0, 2]++;
						 if (s[j]<s[j-1])
						 {
							 e[0, 1]++;
							 cst = s[j];
							 s[j] = s[j - 1];
							 s[j - 1] = cst;
						 }
					 }
				 }
				 d2 = DateTime.Now;
				 e[0, 0] = Convert.ToInt64((d2 - d).TotalMilliseconds);
				 Kiirat("Buborék végén:", s, db, kikell);
				 //jav. buborék
				 e[1, 0] = 0;
				 e[1, 1] = 0;
				 e[1, 2] = 0;
				 Masol(st, s, db);
				 d = DateTime.Now;
				 for (int i = 0; i < db; i++)
				 {
					 for (int j = 1; j < db-i; j++)
					 {
						 e[1, 2]++;
						 if (s[j] < s[j - 1])
						 {
							 e[1, 1]++;
							 cst = s[j];
							 s[j] = s[j - 1];
							 s[j - 1] = cst;
						 }
					 }
				 }
				 d2 = DateTime.Now;
				 e[1, 0] = Convert.ToInt64((d2 - d).TotalMilliseconds);
				 Kiirat("Javított buborék végén:", s, db, kikell);
				 //jav. buborék ++
				 e[2, 0] = 0;
				 e[2, 1] = 0;
				 e[2, 2] = 0;
				 Masol(st, s, db);
				 bool bcs;
				 d = DateTime.Now;
				 for (int i = 0; i < db; i++)
				 {
					 bcs = true;
					 for (int j = 1; j < db - i; j++)
					 {
						 e[2, 2]++;
						 if (s[j] < s[j - 1])
						 {
							 e[2, 1]++;
							 bcs = false;
							 cst = s[j];
							 s[j] = s[j - 1];
							 s[j - 1] = cst;
						 }
					 }
					 if (bcs)
						 break;
				 }
				 d2 = DateTime.Now;
				 e[2, 0] = Convert.ToInt64((d2 - d).TotalMilliseconds);
				 Kiirat("Javított buborék ++ végén:", s, db, kikell);
				 //minkiv
				 e[3, 0] = 0;
				 e[3, 1] = 0;
				 e[3, 2] = 0;
				 Masol(st, s, db);
				 int mp;
				 d = DateTime.Now;
				 for (int i = 0; i < db - 1; i++)
				 {
					 mp = i;
					 for (int j = i+1; j < db; j++)
					 {
						 e[3, 2]++;
						 if (s[j] < s[mp])
						 {
							 mp=j;
						 }
					 }
					 e[3, 1]++;
					 if (mp != i)
					 {
						 cst = s[i];
						 s[i] = s[mp];
						 s[mp] = cst;
					 }
				 }
				 d2 = DateTime.Now;
				 e[3, 0] = Convert.ToInt64((d2 - d).TotalMilliseconds);
				 Kiirat("Minkiv végén:", s, db, kikell);
                //quicksort
                e[4, 0] = 0;
                e[4, 1] = 0;
                e[4, 2] = 0;
                Masol(st, s, db);
                d = DateTime.Now;
                Quicksort(s,0, db-1);
                d2 = DateTime.Now;
                e[4, 0] = Convert.ToInt64((d2 - d).TotalMilliseconds);
                Kiirat("QuickSort végén:", s, db, kikell);

                Masol(st, s, db);
                d = DateTime.Now;
                Array.Sort(s);
                d2 = DateTime.Now;
                Kiirat("Beépített végén:", s, db, kikell);

                Console.WriteLine("algoritmus             idő          csere      vizsgálat");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(dt[i]);
                    Console.WriteLine("{0,15}{1,15}{2,15}", e[i, 0], e[i, 1], e[i, 2]);
                }
                Console.WriteLine(Convert.ToInt64((d2 - d).TotalMilliseconds));
                Console.WriteLine(" Esc kilép, többi újra");
                cki=Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }

        static void Quicksort(int[] s, int also, int felso)
        {
            int tp,a,f,cs;
            //feloszt egy elemtől (tp) <= és >=
            tp=s[(also+felso)/2];
            a=also;
            f=felso;
            do
            {
                e[4, 2]++;
                while (s[a] < tp)
                {
                    e[4, 2]++;
                    a++;
                }
                //megvan az első >=
                e[4, 2]++;
                while (s[f] > tp)
                {
                    f--;
                    e[4, 2]++;
                }
                //megvan az első <=
                if (a<f)
                {// ha nem ugyanaz csere
                    e[4, 1]++;
                    cs = s[a];
                    s[a]=s[f];
                    s[f]=cs;
                }
                if (a <= f)
                {
                    a++;
                    f--;
                }
            } while (a<f);
            //lerendezi a két maradék tartományt
            if (also<f)
                Quicksort(s, also, f);
            if (a<felso)
                Quicksort(s, a, felso);
        }
    }
}
