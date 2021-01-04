using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace szamla
{
    class Program
    {
		static bool mobil_e(string tsz)
		{
			if (((tsz[0] == '3') && (tsz[1] == '9')) || ((tsz[0] == '4') && (tsz[1] == '1')) || ((tsz[0] == '7') && (tsz[1] == '1')))
				return true;
			else
				return false;
		}

		static bool szamjegy(char szj)
		{
			if ((szj == '0') || (szj == '1') || (szj == '2') || (szj == '3') || (szj == '4') ||
				(szj == '5') || (szj == '6') || (szj == '7') || (szj == '8') || (szj == '9'))
				return true;
			else
				return false;
		}

		static int idoalakit(string mit1)
		{// 12 12 11, 1:2:3, 12
			int p, e;
			string tar, mit;
			p = 0;
			mit = mit1 + ' ';
			tar = "0";
			while (szamjegy(mit[p]))
			{
				tar += mit[p];
				p++;
			}
			e = Convert.ToInt32(tar) * 3600;
			p++;
			if (mit.Length == p)
				return e;
			tar = "0";
			while (szamjegy(mit[p]))
			{
				tar += mit[p];
				p++;
			}
			e += Convert.ToInt32(tar) * 60;
			p++;
			if (mit.Length == p)
				return e;
			tar = "0";
			while (szamjegy(mit[p]))
			{
				tar += mit[p];
				p++;
			}
			e += Convert.ToInt32(tar);
			return e;
		}

		static void Main(string[] args)
		{
			string s, k, tar;
			int kmp, vmp, p;
			int[,] ido = new int[200, 2];
			string[] tszam = new string[200];
			int db;
			Console.Write("Kérek egy telefonszámot:");
			s = Console.ReadLine();
			if (mobil_e(s))
			{
				Console.WriteLine("Ez egy mobilszám");
			}
			else
			{
				Console.WriteLine("Ez nem mobilszám");
			}
			Console.Write("Kérek egy híváskezdési idõt:");
			k = Console.ReadLine();
			Console.Write("Kérek egy hívásbefejezési idõt:");
			s = Console.ReadLine();
			//ó p m szóköz ketõspont ha nincs valami, akkor az 0
			kmp = idoalakit(k);
			vmp = idoalakit(s);
			if (vmp < kmp)
			{
				Console.WriteLine("A vége elõbb van a kezdeténél!!!!");
				Console.ReadKey();
				return;
			}
			Console.WriteLine("{0} perc volt a hívás.", (vmp - kmp) / 60 + 1);

			StreamReader o = File.OpenText("HIVASOK.TXT");
			db = 0;
			while (!o.EndOfStream)
			{
				s = o.ReadLine();
				ido[db, 0] = idoalakit(s);
				p = 0;
				while (s[p] != ' ')
				{
					p++;
				}
				p++;
				while (s[p] != ' ')
				{
					p++;
				}
				p++;
				while (s[p] != ' ')
				{
					p++;
				}
				p++;
				tar = "";
				while (p < s.Length)
				{
					tar += s[p];
					p++;
				}
				ido[db, 1] = idoalakit(tar);
				tszam[db] = o.ReadLine();
				db++;
			}
			o.Close();
			int csdb = 0;
			int mperc, vperc;
			mperc = vperc = 0;
			double fiz = 0;
			int tip;
			StreamWriter w = new StreamWriter("percek.txt");
			for (int i = 0; i < db; i++)
			{
				Console.WriteLine("{0}. hívás {1} percig tartott.", i + 1, (ido[i, 1] - ido[i, 0]) / 60 + 1);
				w.WriteLine("{0} {1}", (ido[i, 1] - ido[i, 0]) / 60 + 1,tszam[i]);
				tip = 0;
				if ((ido[i, 0] >= 7 * 3600) && (ido[i, 0] < 18 * 3600))
				{
					csdb++;
					tip = 1;
				}
				if (mobil_e(tszam[i]))
				{
					mperc += (ido[i, 1] - ido[i, 0]) / 60 + 1;
					tip += 2;
				}
				else
					vperc += (ido[i, 1] - ido[i, 0]) / 60 + 1;
				// ncsúcs vez = 0,nem csúcs mobil= 2, csúcs vez = 1, csúcs mobil = 3
				switch (tip)
				{
				case 0:
					fiz += 15;
					break;
				case 1:
					fiz += 30;
					break;
				case 2:
					fiz += 46.675;
					break;
				case 3:
					fiz += 69.175;
					break;

				}
			}
			w.Close();
			Console.WriteLine("{0} db hívás volt csúcsidõben, és {1} db hívás volt csúcsidõn kívül.", csdb, db - csdb);
			Console.WriteLine("{0} percet beszélt mobilon és {1} percet beszélt vezetékesen.", mperc, vperc);
			Console.WriteLine("{0} forint volt a díj.", fiz);




			Console.ReadKey();


		}
	}
}
