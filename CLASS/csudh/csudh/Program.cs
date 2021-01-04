using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    class Program
    {
        static void Main(string[] args)
        { 
            string sor;
            List<TDomain> adatok = new List<TDomain>();
            string fajlnev = "csudh.txt";
            try
            {
                StreamReader fpbe = new StreamReader(fajlnev);
                sor = fpbe.ReadLine();
                while (!fpbe.EndOfStream)
                {
                    TDomain tmp = new TDomain();
                    sor = fpbe.ReadLine();
                    string[] st = sor.Split(';');
                    tmp.Dn = st[0];
                    tmp.Ip = st[1];
                //    tmp.kiir();
                    adatok.Add(tmp);
                }
                fpbe.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Hiba a {0} fajl megnyitásákor!\n {1}", fajlnev, e.Message);
            }

            Console.WriteLine("\n3.feladat- Domainek száma:{0}", adatok.Count);
            Console.WriteLine("5. feladat Első domain felépítése:");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\t{0}.szint: {1}", i, adatok.First().Domain(i));
            }

            try
            {
                StreamWriter fpki = new StreamWriter("table.html");
                fpki.WriteLine("\n<table>\n" +
                    "<tr>\n" +
                    "<th style='text-align: right'> Ssz</th>\n" +
                    "<th style='text-align: right'> Host domain name</th>\n" +
                    "<th style='text-align: right'> Host IP címe</th>\n"
                   );

                for (int i = 1; i <= 5; i++)
                    fpki.WriteLine("<th style='text-align: left'> {0}.szint</th>\n",i);
                fpki.WriteLine("</tr>");
                
                for(int i=1; i<= adatok.Count; i++)
                {
                    fpki.WriteLine("<tr>\n");
                    fpki.WriteLine("<th style = 'text-align: left' > {0}. </ th >\n", i);
                    fpki.WriteLine("<td>{0}</td>", adatok.ElementAt(i - 1).Dn);
                    fpki.WriteLine("<td>{0}</td>", adatok.ElementAt(i - 1).Ip);
                    for (int j = 1; j <= 5; j++)
                        fpki.WriteLine("<td>{0}</ td > ", adatok.ElementAt(i - 1).Domain(j));
                    fpki.WriteLine("</tr>\n");
                }

                fpki.WriteLine("</table>");

                fpki.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba a {0} fajl megnyitásákor!\n {1}", "table.html", e.Message);
            }

            Console.ReadKey();

        }
        


    }
}
