using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csudh
{
    class TDomain
    {
        private string dn;
        private string ip;

        public string Dn { get => dn; set => dn = value; }
        public string Ip { get => ip; set => ip = value; }

        public string Domain(int szint)
        {
            string[] dnbontva = Dn.Split('.');
            int kul =  dnbontva.Length-szint;
            if (kul >= 0)
                return dnbontva[kul];
            else
                return "Nincs";
        }
       
        public void kiir()
        {
            Console.WriteLine(dn);
            Console.WriteLine(ip);
            Console.WriteLine(Domain(3));
            
        }


    }
}
