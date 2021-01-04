using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lift
{
    class Program
    {
        struct igeny
        {
            public int ora;
            public int perc;
            public int mp;
            public int cs;
            public int honnan;
            public int hova;
        }
        static void Main(string[] args)
        {
            int szdb, csdb, idb,indh;
            igeny []ig = new igeny [100];
            string tar;
            Console.WriteLine("1. feladat");
            StreamReader olv = new StreamReader("igeny.txt",Encoding.Default);
            szdb = Convert.ToInt32(olv.ReadLine());
            csdb = Convert.ToInt32(olv.ReadLine());
            idb = Convert.ToInt32(olv.ReadLine());
            for (int i = 0; i < idb; i++)
            {
                tar = olv.ReadLine();
                string[] s = tar.Split(' ');
                ig [i].ora = Convert.ToInt32(s[0]);
                ig [i].perc = Convert.ToInt32(s[1]);
                ig [i].mp = Convert.ToInt32(s[2]);
                ig [i].cs = Convert.ToInt32(s[3]);
                ig [i].honnan = Convert.ToInt32(s[4]);
                ig [i].hova = Convert.ToInt32(s[5]);
            }
            olv.Close();
            Console.Write("2. feladat Kérem a lift indulási helyét: ");
            indh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. feladat A lift a {0}. szinten áll az utolsó igény teljesítése után.",ig[idb-1].hova);
            Console.WriteLine("4. feladat");
            int lm = indh, la = indh;
            for (int i = 0; i < idb; i++)
            {
                if (lm < ig[i].hova)
                    lm = ig[i].hova;
                if (lm < ig[i].honnan)
                    lm = ig[i].honnan;
                if (la > ig[i].hova)
                    la = ig[i].hova;
                if (la > ig[i].honnan)
                    la = ig[i].honnan;
            }
            Console.WriteLine("A legmagasabb szint: {0}, a legalacsonyabb {1}.",lm,la);
            Console.WriteLine("5. feladat");
            int udb = 0; int undb = 0;
            if (indh < ig[0].honnan)
                undb++;
			if (ig[0].honnan < ig[0].hova)
				udb++;
			for (int i = 1; i < idb; i++)
            {
                if (ig[i - 1].hova < ig[i].honnan)
                    undb++;
                if (ig[i].honnan < ig[i].hova)
                    udb++;
            }
            Console.WriteLine("Utassal {0}, utas nélkül {1} alkalommal ment felfelé a lift.", udb, undb);
            Console.WriteLine("6. feladat a liftet nem használó csapatok számai");
            int[] iv = new int[50];
            for (int i = 1; i <= csdb; i++)
                iv[i] = 0;
            for (int i = 0; i < idb; i++)
                iv[ig[i].cs]++;
            for (int i = 1; i <= csdb; i++)
                if (iv[i] == 0)
                    Console.Write("{0} ", i);
            Console.WriteLine(" VÉGE a lsitának");
            Console.Write("7. feladat A kiválasztott csapat: ");
            int vcs;
            Random r = new Random();
            vcs = r.Next(1, csdb+1);
            Console.WriteLine(vcs);
            bool szvolt = false;
            int uterk = -1;
            for (int i=0;i<idb;i++)
                if (ig[i].cs == vcs)
                {
                    if ((ig[i].honnan != uterk) && (uterk != -1))
                    {
                        Console.WriteLine("gyalog: {0}-{1}.", uterk, ig[i].honnan);
                        szvolt = true;
                    }
                    uterk = ig[i].hova;
                }
            if (szvolt == false)
                Console.WriteLine("Nem bizonyítható szabálytalanság");
            Console.WriteLine("8. feladat");
            StreamWriter ir = new StreamWriter("blokkol.txt");
            for (int i=0;i<idb;i++)
                if (ig[i].cs == vcs)
                {
                    Console.WriteLine("Befejezés ideje: {0}:{1}:{2}",ig[i].ora,ig[i].perc,ig[i].mp);
                    Console.Write("Sikeresség: ");
                    tar = Console.ReadLine();
                    ir.WriteLine("Befejezés ideje: {0}:{1}:{2}", ig[i].ora, ig[i].perc, ig[i].mp);
                    ir.Write("Sikeresség: ");
                    ir.WriteLine(tar);
                    Console.Write("Feladatkód: ");
                    tar = Console.ReadLine();
                    ir.WriteLine("-----");
                    ir.WriteLine("Indulási emelet: {0}",ig[i].honnan);
                    ir.WriteLine("Célemelet: {0}",ig[i].hova);
                    ir.WriteLine("Feladatkód: {0}", tar);
                }
            ir.Close();
            Console.WriteLine("VÉGE a PROGRAMNAK!!!");
            Console.ReadKey();
        }
    }
}
